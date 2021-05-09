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

namespace computerFirm.AddForms
{
    public partial class AddNewRoleForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewRoleForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void addNewRoleBtn_Click(object sender, EventArgs e)
        {
            string roleName = roleNameTextBox.Text;
            bool changeInf = changeInfCheckBox.Checked;
            bool deleteInf = deleteInfCheckBox.Checked;
            bool addInf = addInfCheckBox.Checked;
            if(String.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Введите название роли", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string queryToAddNewRole = $"INSERT INTO Role (RoleName, ChangeInformation, DeleteInformation, AddInformation) VAlUES ('{roleName}'," +
                $" {changeInf}, {deleteInf}, {addInf})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewRole, myConnection);
            MessageBox.Show("Данные о новой роли добавлены");
        }

        private void AddNewRoleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
