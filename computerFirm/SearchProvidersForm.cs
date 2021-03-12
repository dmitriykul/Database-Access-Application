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
    public partial class SearchProvidersForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchProvidersForm()
        {
            InitializeComponent();
        }

        private void searchInDoneServices_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), makeQuery(), dataGridView1);
            myConnection.Close();
        }

        public string makeQuery()
        {
            string query = $"SELECT [Наименование фирмы], Email FROM [Поставщики] WHERE [Наименование фирмы] LIKE '%{providerNameTextBox.Text}%'";
            return query;
        }
    }
}
