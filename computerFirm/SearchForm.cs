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
    public partial class SearchForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchBySecondNameBtn_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), makeQuery(), dataGridView1);
            myConnection.Close();
        }

        public string makeQuery()
        {
            //string query = "SELECT Фамилия, Имя, Отчество, Должность, Отдел, Номер_Телефона FROM Работники WHERE ";
            string query = "SELECT Работники.Фамилия, Работники.Имя, Работники.Отчество, Должности.Название, Отделы.Наименование, Работники.Номер_телефона " +
                "FROM Должности INNER JOIN(Отделы INNER JOIN Работники ON Отделы.departmentID = Работники.Отдел) ON Должности.postID = Работники.Должность WHERE ";
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"(Работники.Фамилия LIKE '%{secondNameForSearch.Text}%')";
                return query;
            }
            else if(checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"(Работники.Фамилия LIKE '%{secondNameForSearch.Text}%') AND ";
            if (checks[1] == 1 && hasNoChecked(checks, 1))
            {
                query += $"(Работники.Имя LIKE '%{nameForSearch.Text}%')";
                return query;
            }
            else if (checks[1] == 1 && !hasNoChecked(checks, 1))
                query += $"(Работники.Имя LIKE '%{nameForSearch.Text}%') AND ";
            if (checks[2] == 1 && hasNoChecked(checks, 2))
            {
                query += $"(Должности.Название LIKE '%{postForSearch.Text}%')";
                return query;
            }
            else if (checks[2] == 1 && !hasNoChecked(checks, 2))
                query += $"(Должности.Название LIKE '%{postForSearch.Text}%') AND ";
            if (checks[3] == 1 && hasNoChecked(checks, 3))
            {
                query += $"(Отделы.Наименование LIKE '%{otdelForSearch.Text}%')";
                return query;
            }
            else if (checks[3] == 1 && !hasNoChecked(checks, 3))
                query += $"(Отделы.Наименование LIKE '%{otdelForSearch.Text}%') AND ";
            if (checks[4] == 1)
            {
                query += $"(Работники.Номер_телефона LIKE '{phoneNumForSearch.Text}%')";
                return query;
            }
            return "SELECT Работники.workerID, Работники.Фамилия, Работники.Имя, Работники.Отчество, Должности.Название, Отделы.Наименование, Работники.Номер_телефона" +
            " FROM Должности INNER JOIN (Отделы INNER JOIN Работники ON Отделы.departmentID = Работники.Отдел) ON Должности.postID = Работники.Должность";
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
