using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace computerFirm
{
    class WorkerDb
    {
        public static void UpdateTable(OleDbConnection connection, OleDbDataAdapter adapter, DataTable table, string query, DataGridView view)
        {
            adapter = new OleDbDataAdapter(query, connection);
            table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            view.DataSource = table;
        }

        public static void UpdateTable(OleDbConnection connection, OleDbDataAdapter adapter, DataTable table, string query)
        {
            adapter = new OleDbDataAdapter(query, connection);
            table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Метод для проверки, существует ли данный пользователь в базе данных
        public static int GetData(string query, OleDbConnection connection)
        {
            OleDbCommand commandToDo = new OleDbCommand(query, connection);
            try
            {
                var res = commandToDo.ExecuteNonQuery();
                return res;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // Получить список: (Имя роли, изменение информации, удаление информации, добавление информации)
        public static List<string> GetRoleAttributes(string login, OleDbConnection connection)
        {
            try
            {
                List<string> roleAttributes = new List<string> { };
                OleDbCommand commandToGetRole = connection.CreateCommand();
                commandToGetRole.CommandText = "SELECT [Role].[RoleName], [Role].[ChangeInformation], [Role].[DeleteInformation], [Role].[AddInformation]" +
                    " FROM [Role], [User] WHERE ([User].[UserLogin] = \"" + login + "\") " +
                    "AND ([User].UserRole = [Role].[RoleID])";
                OleDbDataReader thisReader = commandToGetRole.ExecuteReader();
                string role = string.Empty;
                while (thisReader.Read())
                {
                    roleAttributes.Add(Convert.ToString(thisReader["RoleName"]));
                    roleAttributes.Add(Convert.ToString(thisReader["ChangeInformation"]));
                    roleAttributes.Add(Convert.ToString(thisReader["DeleteInformation"]));
                    roleAttributes.Add(Convert.ToString(thisReader["AddInformation"]));
                }
                thisReader.Close();

                return roleAttributes;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string> { };
            }
        }

        // Получить словарь (ID, field)
        public static Dictionary<int, string> GetDataByIdAndField(string id, string field, string table, OleDbConnection connection)
        {
                Dictionary<int, string> results = new Dictionary<int, string> { };
            try
            {
                OleDbCommand commandGetDataByIdField = connection.CreateCommand();
                commandGetDataByIdField.CommandText = $"SELECT {id}, {field} FROM {table}";
                OleDbDataReader thisReader = commandGetDataByIdField.ExecuteReader();
                while(thisReader.Read())
                {
                    results[Convert.ToInt32(thisReader[id])] = Convert.ToString(thisReader[field]);
                }

                thisReader.Close();
                return results;
            }
            catch (OleDbException ex)
            {

                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Dictionary<int, string> { };
            }
        }

        public static Dictionary<int, string> GetDataByTwoDifferentTables(string id, string field, string table, string field2, int field3, OleDbConnection connection)
        {
            Dictionary<int, string> results = new Dictionary<int, string> { };
            try
            {
                OleDbCommand commandGetDataByIdField = connection.CreateCommand();
                commandGetDataByIdField.CommandText = $"SELECT {id}, {field} FROM {table} WHERE {table}.{field2} = {field3}";
                OleDbDataReader thisReader = commandGetDataByIdField.ExecuteReader();
                while (thisReader.Read())
                {
                    results[Convert.ToInt32(thisReader[id])] = Convert.ToString(thisReader[field]);
                }

                thisReader.Close();
                return results;
            }
            catch (OleDbException ex)
            {

                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Dictionary<int, string> { };
            }
        }

        public static int MakeQueryForChangeTable(string query, OleDbConnection connection)
        {
            OleDbCommand commandToDo = new OleDbCommand(query, connection);
            try {
                commandToDo.ExecuteNonQuery();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 1;
            
        }

        public static DataTable MakeReportTable(OleDbConnection connection, OleDbDataAdapter adapter, string query)
        {
            adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public static bool CheckPhoneNumber(string phoneNum)
        {
            foreach (char digit in phoneNum)
            {
                if (!Char.IsNumber(digit))
                    return false;
            }
            return true;
        }
    }
}
