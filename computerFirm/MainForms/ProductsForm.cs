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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        string queryForFillTableByProducts = "SELECT Product.ProductID as [Код продукта], " +
            "Product.Product as [Продукт], " +
            "Provider.[ProviderName] as [Фирма], " +
            "Product.Cost as [Стоимость], " +
            "Product.IsOnSclad as [Наличие на складе] " +
            "FROM Provider INNER JOIN Product ON Provider.ProviderID = Product.Provider";
        OleDbDataAdapter productsTableAdapter;
        DataTable productsTable;
        public ProductsForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public ProductsForm(List<string> role, string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта

            // Если роль "Продавец" или "Мастер", то скрыть возможности работы с таблицей Продукты
            if(role[0] == "seller" || role[0] == "master")
            {
                label2.Hide();
                productIdToDeleteTextBox.Hide();
                button2.Hide();

                button1.Hide();

                queryForFillTableByProducts = "SELECT " +
                "Product.Product as [Продукт], " +
                "Provider.[ProviderName] as [Фирма], " +
                "Product.Cost as [Стоимость], " +
                "Product.IsOnSclad as [Наличие на складе] " +
                "FROM Provider INNER JOIN Product ON Provider.ProviderID = Product.Provider";
            }
            if(!Convert.ToBoolean(role[1]))
            {
                changeInfoProductBtn.Hide();
            }
            if (!Convert.ToBoolean(role[2]))
            {
                label2.Hide();
                productIdToDeleteTextBox.Hide();
                button2.Hide();
            }
            if (!Convert.ToBoolean(role[3]))
            {
                button1.Hide();
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, productsTableAdapter, productsTable, queryForFillTableByProducts, dataGridView2);
            dataGridView2.Columns[0].ReadOnly = true;
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
            string query = $"DELETE FROM Product WHERE ProductID = {productIdToDelete}";    // запрос на удаление
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
            AddNewProductForm formDb = new AddNewProductForm(connectString);
            formDb.Owner = this;
            formDb.Show();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProductForm formDb = new SearchProductForm(connectString);
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

            string queryToCheckTrue = $"UPDATE Provider SET Provider.ProviderName = Provider.ProviderName WHERE Provider.ProviderName = '{productProviderName}'";
            OleDbCommand commandToDo = new OleDbCommand(queryToCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;

            //if (WorkerDb.MakeQueryForChangeTable(queryToCheckTrue, myConnection) == 0)
            //    return;

            string query = $"UPDATE Product SET [Product] = '{productName}', Cost = {productCost}, IsOnSclad = {productIsThere} WHERE ProductID = {productId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            query = $"UPDATE Product " +
                $"SET Provider=DLookUp(\"ProviderID\", \"Provider\", \"[ProviderName]= '{productProviderName}'\") " +
                $"WHERE Product.ProductID = {productId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
        }
    }
}
