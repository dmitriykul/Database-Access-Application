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
    public partial class AddNewProviderForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewProviderForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string providerName = providerNameTextBox.Text;
            string email = providerEmailTextBox.Text;

            string queryToAddNewProvider = $"INSERT INTO Поставщики ([Наименование фирмы], Email) VALUES ('{providerName}', '{email}')";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewProvider, myConnection);
            MessageBox.Show("Данные о новом поставщике добавлены");
        }

        private void AddNewProviderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
