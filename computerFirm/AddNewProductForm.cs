using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace computerFirm
{
    public partial class AddNewProductForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewProductForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = productNameTextBox.Text;
            string productCost = productCostTextBox.Text;
            int productProviderId = -1;

            try
            {
                productProviderId = Convert.ToInt32(productProviderTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка в вводе ID поставщика, повторите попытку\n{ex.Message}", "Ошибка в ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string queryToAddNewProduct = $"INSERT INTO Продукция (Продукт, Поставщик, Стоимость, [Наличие на складе]) VALUES ('{productName}', '{productProviderId}', '{productCost}', {isThere.Checked})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewProduct, myConnection);
            MessageBox.Show($"Данные о продукте {productName} Добавлены", "Успешно");

        }

        private void AddNewProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
