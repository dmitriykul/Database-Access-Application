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
using System.Text.RegularExpressions;

namespace computerFirm
{
    public partial class AddNewClientForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewClientForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientName = firstNameTextBox.Text;
            string secName = secondNameTextBox.Text;
            string thirdName = thirdNameTextBox.Text;
            string phoneNum = phoneNumTextbox.Text;
            if(clientName == "" || secName == "" || thirdName == "" || phoneNum == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if(phoneNum.Length != 11 || !WorkerDb.CheckPhoneNumber(phoneNum))
            {
                MessageBox.Show("Номер должен состоять из 11 цифр (89999999999)", "Некорректный ввод номера телефона", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string queryToAddNewClient = $"INSERT INTO Client (ClientSecName, ClientName, ClientThirdName, ClientPhoneNumber) VALUES ('{secName}', '{clientName}', '{thirdName}', '{phoneNum}')";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewClient, myConnection);
            MessageBox.Show("Данные о новом клиенте добавлены");
        }

        

        private void AddNewClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
