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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewProviderForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string providerName = providerNameTextBox.Text;
            string email = providerEmailTextBox.Text;
            
            if(providerName == "" || email == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Не все поля заполнены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string queryToAddNewProvider = $"INSERT INTO Provider (ProviderName, ProviderEmail) VALUES ('{providerName}', '{email}')";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewProvider, myConnection);
            MessageBox.Show("Данные о новом поставщике добавлены");
        }

        private void AddNewProviderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
