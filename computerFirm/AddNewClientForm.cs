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
    public partial class AddNewClientForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewClientForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientName = firstNameTextBox.Text;
            string secName = secondNameTextBox.Text;
            string thirdName = thirdNameTextBox.Text;
            string phoneNum = phoneNumTextbox.Text;
            string queryToAddNewClient = $"INSERT INTO Клиенты (Фамилия_Клиента, Имя, Отчество, [Номер телефона]) VALUES ('{secName}', '{clientName}', '{thirdName}', '{phoneNum}')";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewClient, myConnection);
            MessageBox.Show("Данные о новом клиенте добавлены");
        }

        private void AddNewClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
