using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;        // модель для работы с базами данных

namespace computerFirm
{
    public partial class ProductsForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        string queryForFillTableByProducts = "SELECT Продукция.productID, Продукция.Продукт, Поставщики.[Наименование фирмы], Продукция.Стоимость, Продукция.[Наличие на складе] " +
            "FROM Поставщики INNER JOIN Продукция ON Поставщики.providerID = Продукция.Поставщик";
        OleDbDataAdapter productsTableAdapter;
        DataTable productsTable;
        public ProductsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, productsTableAdapter, productsTable, queryForFillTableByProducts, dataGridView2);
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int productIdToDelete = -1;
            try
            {
                productIdToDelete = Convert.ToInt32(productIdToDeleteTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введён код продукта, повторите попытку!", "Ошибка в коде продукта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM Продукция WHERE productID = {productIdToDelete}";    // запрос на удаление
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о продукте {productIdToDelete} удалены");
            WorkerDb.UpdateTable(myConnection, productsTableAdapter, productsTable, queryForFillTableByProducts, dataGridView2);
        }

        private void ProductsForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, productsTableAdapter, productsTable, queryForFillTableByProducts, dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewProductForm formDb = new AddNewProductForm();
            formDb.Owner = this;
            formDb.Show();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProductForm formDb = new SearchProductForm();
            formDb.Owner = this;
            formDb.Show();
        }

        private void changeInfoProductBtn_Click(object sender, EventArgs e)
        {
            // Обновление записей в таблице
            // Проверка количества выбранных строк
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание");
                return;
            }

            // Запоминаем выбранную строку
            int index = dataGridView2.SelectedRows[0].Index;

            // Проверим данные
            if (dataGridView2.Rows[index].Cells[1].Value.ToString() == "" ||
                dataGridView2.Rows[index].Cells[2].Value.ToString() == "" ||
                dataGridView2.Rows[index].Cells[3].Value.ToString() == "" ||
                dataGridView2.Rows[index].Cells[4].Value.ToString() == "")
            {
                MessageBox.Show("Не все данные присутствуют в таблице", "Внимание");
                return;
            }

            // Считываем данные
            int productId = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
            string productName = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string productProviderName = dataGridView2.Rows[index].Cells[2].Value.ToString();
            decimal productCost = Convert.ToDecimal(dataGridView2.Rows[index].Cells[3].Value);
            bool productIsThere = Convert.ToBoolean(dataGridView2.Rows[index].Cells[4].Value);

            string queryToCheckTrue = $"UPDATE Поставщики SET Поставщики.[Наименование фирмы] = Поставщики.[Наименование фирмы] WHERE Поставщики.[Наименование фирмы] = '{productProviderName}'";
            OleDbCommand commandToDo = new OleDbCommand(queryToCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;

            //if (WorkerDb.MakeQueryForChangeTable(queryToCheckTrue, myConnection) == 0)
            //    return;

            string query = $"UPDATE Продукция SET [Продукт] = '{productName}', Стоимость = '{productCost}', [Наличие на складе] = {productIsThere} WHERE productID = {productId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            query = $"UPDATE Продукция " +
                $"SET Поставщик=DLookUp(\"providerID\", \"Поставщики\", \"[Наименование фирмы]= '{productProviderName}'\") " +
                $"WHERE Продукция.productID = {productId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
        }
    }
}
