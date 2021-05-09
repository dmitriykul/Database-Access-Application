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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchInListOfServicesForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
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
            string query = "SELECT " +
                "Service.ServiceName as [Наименование услуги], " +
                "Service.ServiceCost as [Стоимость услуги], " +
                "Department.DepartmentName as [Наименование отдела] " +
                "FROM Department INNER JOIN Service ON Department.DepartmentID = Service.ServiceDepartment WHERE";
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"(Service.ServiceName LIKE '%{serviceNameTextbox.Text}%')";
                return query;
            }
            else if (checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"(Service.ServiceName LIKE '%{serviceNameTextbox.Text}%') AND ";

            if (checks[1] == 1)
            {
                query += $"(Department.DepartmentName LIKE '%{serviceOtdelTextBox.Text}%')";
                return query;
            }
            return "SELECT Service.ServiceName as [Наименование услуги], " +
                "Service.ServiceCost as [Стоимость услуги], " +
                "Department.DepartmentName as [Наименование отдела] " +
                "FROM Department INNER JOIN Service ON Department.DepartmentID = Service.ServiceDepartment";
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
