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
    public partial class SearchProductForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchProductForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
        }

        private void searchInProduct_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), makeQuery(), dataGridView1);
            myConnection.Close();
        }

        public string makeQuery()
        {
            string query = $"SELECT Product.Product as [Продукт], " +
                $"Provider.ProviderName as [Поставщик], " +
                $"Product.Cost as [Стоимость], " +
                $"Product.IsOnSclad as [Наличие на складе] FROM Product, Provider " +
                $"WHERE (Product.Provider = Provider.ProviderID) AND (Product.Product LIKE '%{productNameTextBox.Text}%') AND (Product.IsOnSclad = {Convert.ToBoolean(isThere.Checked)})";
            return query;
        }
    }
}
