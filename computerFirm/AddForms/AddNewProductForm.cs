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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> providers;
        public AddNewProductForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            providers = WorkerDb.GetDataByIdAndField("ProviderID", "ProviderName", "Provider", myConnection);
            providerComboBox.DataSource = new BindingSource(providers, null);
            providerComboBox.DisplayMember = "Value";
            providerComboBox.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = productNameTextBox.Text;
            decimal productCost = -1;
            int productProviderId = -1;

            if(productName == "" || productName == null)
            {
                MessageBox.Show("Не все поля заполнены, заполните все поля", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                productCost = Convert.ToDecimal(productCostTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка в вводе цены, повторите попытку\n{ex.Message}", "Ошибка в цене");
                return;
            }

            try
            {
                //productProviderId = Convert.ToInt32(productProviderTextBox.Text);
                productProviderId = ((KeyValuePair<int, string>)providerComboBox.SelectedItem).Key;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка в вводе ID поставщика, повторите попытку\n{ex.Message}", "Ошибка в ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryToAddNewProduct = $"INSERT INTO Product (Product, Provider, Cost, IsOnSclad) VALUES ('{productName}', '{productProviderId}', {productCost}, {isThere.Checked})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewProduct, myConnection);
            MessageBox.Show($"Данные о продукте {productName} Добавлены", "Успешно");

        }

        private void AddNewProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
