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

namespace computerFirm.ReportForms
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        //public static string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ComputerFirm.accdb;Persist Security Info=True";
        public static string connectString = @"Provider =Microsoft.ACE.OLEDB.12.0;Data Source =|DataDirectory|\ComputerFirm.accdb;Persist Security Info=True";
        //public static string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =|DataDirectory|\bin\Debug\ComputerFirm.accdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public LoginForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text ?? "";
            string password = textBoxPassword.Text ?? "";
            string query = "UPDATE [User] SET [User].UserLogin = \"" + login + "\" WHERE ([User].[UserLogin] = \"" + login + "\" AND [User].[UserPassword] = \"" + password + "\")";
            myConnection.Open();    // база данных открыта
            var check = WorkerDb.GetData(query, myConnection);
            if (check == 0)
            {
                MessageBox.Show("Неправильный логин или пароль, повторите попытку", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                myConnection.Close();
            }
            else
            {
                var roleAttributes = WorkerDb.GetRoleAttributes(login, myConnection);
                this.Hide();
                mainForm = new MainForm(roleAttributes, connectString);
                //mainForm.Owner = this;
                mainForm.ShowDialog();
                myConnection.Close();
                this.Close();
                
            }
        }
    }
}
