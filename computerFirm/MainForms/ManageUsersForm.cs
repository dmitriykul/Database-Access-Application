using computerFirm.AddForms;
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
    public partial class ManageUsersForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> roles;
        private Dictionary<int, string> users;
        string queryToFillUsers = "SELECT [User].UserID as [Код пользователя], " +
            "[User].[UserLogin] as [Логин], " +
            "[User].[UserPassword] as [Пароль], " +
            "[Role].[RoleName] as [Роль] FROM [User], [Role] WHERE [User].[UserRole] = [Role].RoleID";
        string queryToFillRoles = "SELECT RoleID as [Код роли], [RoleName] as [Роль], " +
            "[ChangeInformation] as [Изменение информации], " +
            "[DeleteInformation] as [Удаление информации], " +
            "[AddInformation] as [Добавление информации] FROM Role";

        OleDbDataAdapter rolesTable;
        DataTable tableRoles;
        OleDbDataAdapter usersTable;
        DataTable tableUsersWithoutNums;

        public ManageUsersForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта

            roles = WorkerDb.GetDataByIdAndField("RoleID", "RoleName", "Role", myConnection);
            if (roles.Count != 0)
            {
                rolesComboBox.Enabled = true;
                deleteRoleBtn.Enabled = true;
                changePropsBtn.Enabled = true;

                rolesComboBox.DataSource = new BindingSource(roles, null);
                rolesComboBox.DisplayMember = "Value";
                rolesComboBox.ValueMember = "Key";
            }
            else
            {
                rolesComboBox.Enabled = false;
                deleteRoleBtn.Enabled = false;
                changePropsBtn.Enabled = false;
            }

            users = WorkerDb.GetDataByIdAndField("UserID", "UserLogin", "[User]", myConnection);
            if (users.Count != 0)
            {
                usersComboBox.Enabled = true;
                btnDeleteUser.Enabled = true;

                usersComboBox.DataSource = new BindingSource(users, null);
                usersComboBox.DisplayMember = "Value";
                usersComboBox.ValueMember = "Key";
            }
            else
            {
                usersComboBox.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, usersTable, tableUsersWithoutNums, queryToFillUsers, dataGridView1);
            WorkerDb.UpdateTable(myConnection, rolesTable, tableRoles, queryToFillRoles, dataGridView2);
            dataGridView1.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;
        }

        private void ManageUsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();   // закрытие связи с базой данных по выходу из приложения
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int userId = -1;
            string userLogin = "";
            try
            {
                userId = ((KeyValuePair<int, string>)usersComboBox.SelectedItem).Key;
                userLogin = ((KeyValuePair<int, string>)usersComboBox.SelectedItem).Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно введён код пользователя, повторите попытку!", "Ошибка в коде пользователя",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM [User] WHERE UserID = {userId}";    // запрос на удаление пользователя по коду
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о Пользователе {userLogin} удалены");
        }

        private void ManageUsersForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, rolesTable, tableRoles, queryToFillRoles, dataGridView2);
            WorkerDb.UpdateTable(myConnection, usersTable, tableUsersWithoutNums, queryToFillUsers, dataGridView1);
            roles = WorkerDb.GetDataByIdAndField("RoleID", "RoleName", "Role", myConnection);
            if (roles.Count != 0)
            {
                rolesComboBox.Enabled = true;
                deleteRoleBtn.Enabled = true;
                changePropsBtn.Enabled = true;

                rolesComboBox.DataSource = new BindingSource(roles, null);
                rolesComboBox.DisplayMember = "Value";
                rolesComboBox.ValueMember = "Key";
            }
            else
            {
                rolesComboBox.Enabled = false;
                deleteRoleBtn.Enabled = false;
                changePropsBtn.Enabled = false;
            }

            users = WorkerDb.GetDataByIdAndField("UserID", "UserLogin", "[User]", myConnection);
            if (users.Count != 0)
            {
                usersComboBox.Enabled = true;
                btnDeleteUser.Enabled = true;

                usersComboBox.DataSource = new BindingSource(users, null);
                usersComboBox.DisplayMember = "Value";
                usersComboBox.ValueMember = "Key";
            }
            else
            {
                usersComboBox.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm addUerForm = new AddNewUserForm(connectString);
            addUerForm.Owner = this;
            addUerForm.Show();
        }

        private void deleteRoleBtn_Click(object sender, EventArgs e)
        {
            int roleId = -1;
            string roleName = "";
            try
            {
                roleId = ((KeyValuePair<int, string>)rolesComboBox.SelectedItem).Key;
                roleName = ((KeyValuePair<int, string>)rolesComboBox.SelectedItem).Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно введён код роли, повторите попытку!", "Ошибка в коде роли",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM Role WHERE RoleID = {roleId}";    // запрос на удаление роли по коду
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о роли {roleName} удалены");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewRoleForm addRoleForm = new AddNewRoleForm(connectString);
            addRoleForm.Owner = this;
            addRoleForm.Show();
        }

        private void changePropsBtn_Click(object sender, EventArgs e)
        {
            // Обновление записей в таблице
            // Проверка количества выбранных строк
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание");
                return;
            }

            // Запоминаем выбранную строку
            int index = dataGridView2.SelectedRows[0].Index;

            // Проверим данные
            if (
                dataGridView2.Rows[index].Cells[2].Value.ToString() == "" ||
                dataGridView2.Rows[index].Cells[3].Value.ToString() == "" ||
                dataGridView2.Rows[index].Cells[4].Value.ToString() == ""
                )
            {
                MessageBox.Show("Не все данные присутствуют в таблице", "Внимание");
                return;
            }

            // Считываем данные
            bool changeInf = Convert.ToBoolean(dataGridView2.Rows[index].Cells[2].Value);
            bool deleteInf = Convert.ToBoolean(dataGridView2.Rows[index].Cells[3].Value);
            bool addInf = Convert.ToBoolean(dataGridView2.Rows[index].Cells[4].Value);
            string roleName = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string queryToUpdateString = $"UPDATE Role SET Role.ChangeInformation = {changeInf}," +
                $"Role.DeleteInformation = {deleteInf}," +
                $"Role.AddInformation = {addInf}";
            WorkerDb.MakeQueryForChangeTable(queryToUpdateString, myConnection);
            WorkerDb.UpdateTable(myConnection, rolesTable, tableRoles, queryToFillRoles, dataGridView2);
            MessageBox.Show($"Данные о роли {roleName} изменены", "Данные изменены", MessageBoxButtons.OK);
        }
    }
}
