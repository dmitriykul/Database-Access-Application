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
    public partial class SearchInListOfServicesForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchInListOfServicesForm()
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
            string query = "SELECT [Список услуг].serviceID, [Список услуг].[Вид_услуги], [Список услуг].Стоимость, Отделы.Наименование " +
                "FROM Отделы INNER JOIN[Список услуг] ON Отделы.departmentID = [Список услуг].Отдел WHERE";
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"([Список услуг].[Вид_услуги] LIKE '%{serviceNameTextbox.Text}%')";
                return query;
            }
            else if (checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"([Список услуг].[Вид_услуги] LIKE '%{serviceNameTextbox.Text}%') AND ";

            if (checks[1] == 1)
            {
                query += $"(Отделы.Наименование LIKE '%{serviceOtdelTextBox.Text}%')";
                return query;
            }
            return "SELECT [Список услуг].serviceID, [Список услуг].[Вид_услуги], [Список услуг].Стоимость, Отделы.Наименование " +
                "FROM Отделы INNER JOIN[Список услуг] ON Отделы.departmentID = [Список услуг].Отдел";
        }

        public bool hasNoChecked(List<int> checks, int pos)
        {
            for (int p = pos + 1; p < checks.Count; p++)
                if (checks[p] == 1)
                    return false;
            return true;
        }

        public List<int> countOfChecks()
        {
            List<int> result = new List<int>();
            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                    result.Add(1);
                else
                    result.Add(0);
            }
            return result;
        }
    }
}
