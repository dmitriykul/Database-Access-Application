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
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchProductForm()
        {
            InitializeComponent();
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
            string query = $"SELECT Продукция.Продукт, Поставщики.[Наименование фирмы], Продукция.Стоимость, Продукция.[Наличие на складе] FROM Продукция, Поставщики " +
                $"WHERE (Продукция.Поставщик = Поставщики.providerID) AND (Продукция.Продукт LIKE '%{productNameTextBox.Text}%') AND (Продукция.[Наличие на складе] = {Convert.ToBoolean(isThere.Checked)})";
            return query;
        }
    }
}
