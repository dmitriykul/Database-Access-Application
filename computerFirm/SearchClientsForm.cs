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
    public partial class SearchClientsForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchClientsForm()
        {
            InitializeComponent();
        }

        private void searchInClients_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), makeQuery(), dataGridView1);
            myConnection.Close();
        }

        public string makeQuery()
        {
            string query = $"SELECT Фамилия_клиента, Имя, Отчество, [Номер телефона] FROM Клиенты WHERE ";
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"(Фамилия_клиента LIKE '%{secNameTextBox.Text}%')";
                return query;
            }
            else if (checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"(Фамилия_клиента LIKE '%{secNameTextBox.Text}%') AND ";
            if (checks[1] == 1 && hasNoChecked(checks, 1))
            {
                query += $"(Имя LIKE '%{nameTextbox.Text}%')";
                return query;
            }
            else if (checks[1] == 1 && !hasNoChecked(checks, 1))
                query += $"(Имя LIKE '%{nameTextbox.Text}%') AND ";
            if (checks[2] == 1 && hasNoChecked(checks, 2))
            {
                query += $"(Отчество LIKE '%{thirdNameTextbox.Text}%')";
                return query;
            }
            else if (checks[2] == 1 && !hasNoChecked(checks, 2))
                query += $"(Отчество LIKE '%{thirdNameTextbox.Text}%') AND ";
            if (checks[3] == 1)
            {
                query += $"([Номер телефона] LIKE '{phoneNumTextbox.Text}%')";
                return query;
            }
            return "SELECT Фамилия_клиента, Имя, Отчество, [Номер телефона] FROM Клиенты";
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
