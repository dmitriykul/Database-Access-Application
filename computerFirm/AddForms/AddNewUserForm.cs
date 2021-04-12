using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computerFirm.MainForms
{
    public partial class AddNewUserForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewUserForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void addNewUserBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            int roleId = Convert.ToInt32(roleTextBox.Text);
            string queryToInsertNewUser = $"INSERT INTO [User] (UserLogin, UserPassword, UserRole) VALUES ('{login}', '{password}', '{roleId}')";
            WorkerDb.MakeQueryForChangeTable(queryToInsertNewUser, myConnection);
            MessageBox.Show("Данные о новом пользователе добавлены");
        }

        private void AddNewUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
