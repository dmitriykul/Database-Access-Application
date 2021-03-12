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
    public partial class SearchInDoneServicesForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchInDoneServicesForm()
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
            string query = "SELECT [Список услуг].[Вид_услуги], [Выполненные услуги].Стоимость, Клиенты.Фамилия_клиента, Отделы.Наименование, [Выполненные услуги].Дата, Работники.Фамилия " +
                "FROM((Отделы INNER JOIN(Клиенты INNER JOIN[Выполненные услуги] ON Клиенты.clientID = [Выполненные услуги].Клиент) ON Отделы.departmentID = [Выполненные услуги].Отдел) " +
                "INNER JOIN Работники ON(Работники.workerID = [Выполненные услуги].Работник) AND(Отделы.departmentID = Работники.Отдел)) " +
                "INNER JOIN[Список услуг] ON([Список услуг].serviceID = [Выполненные услуги].Наименование) AND(Отделы.departmentID = [Список услуг].Отдел) " +
                "WHERE ";
            
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"(Клиенты.Фамилия_клиента LIKE '%{clientIdForSearch.Text}%')";
                return query;
            }
            else if (checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"(Клиенты.Фамилия_клиента LIKE '%{clientIdForSearch.Text}%') AND ";

            if (checks[1] == 1 && hasNoChecked(checks, 1))
            {
                query += $"(Работники.Фамилия LIKE '%{workerIdForSearch.Text}%')";
                return query;
            }
            else if (checks[1] == 1 && !hasNoChecked(checks, 1))
                query += $"(Работники.Фамилия LIKE '%{workerIdForSearch.Text}%') AND ";
            if (checks[2] == 1)
            {
                query += $"([Список услуг].[Вид_услуги] LIKE '%{serviceNameIdSearch.Text}%')";
                return query;
            }
            return "SELECT [Список услуг].[Вид_услуги], [Выполненные услуги].Стоимость, Клиенты.Фамилия_клиента, Отделы.Наименование, [Выполненные услуги].Дата, Работники.[Фамилия] " +
            "FROM [Список услуг], [Выполненные услуги], Клиенты, Отделы, Работники " +
            "WHERE ([Список услуг].serviceID = [Выполненные услуги].Наименование) AND (Клиенты.clientID = [Выполненные услуги].Клиент) AND " +
            "(Отделы.departmentID = [Выполненные услуги].Отдел) AND (Работники.workerID = [Выполненные услуги].Работник)";
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
