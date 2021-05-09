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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchInDoneServicesForm(string connect)
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
            string query = "SELECT Service.[ServiceName] as [Наименование услуги], " +
                "DoneService.DoneServiceCost as [Стоимость], " +
                "Client.[ClientSecName] as [Фамилия клиента], " +
                "Department.[DepartmentName] as [Наименование отдела], " +
                "DoneService.DoneServiceDate as [Дата], " +
                "Worker.[SecName] as [Фамилия работника] " +
                "FROM((Department INNER JOIN(Client INNER JOIN DoneService ON Client.ClientID = DoneService.DoneServiceClient) ON Department.DepartmentID = DoneService.DoneServiceDepartment) " +
                "INNER JOIN Worker ON(Worker.WorkerID = DoneService.DoneServiceWorker) AND (Department.DepartmentID = Worker.Department)) " +
                "INNER JOIN Service ON(Service.ServiceID = DoneService.DoneServiceName) AND (Department.DepartmentID = Service.ServiceDepartment) " +
                "WHERE ";
            
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"(Client.ClientSecName LIKE '%{clientIdForSearch.Text}%')";
                return query;
            }
            else if (checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"(Client.ClientSecName LIKE '%{clientIdForSearch.Text}%') AND ";

            if (checks[1] == 1 && hasNoChecked(checks, 1))
            {
                query += $"(Worker.SecName LIKE '%{workerIdForSearch.Text}%')";
                return query;
            }
            else if (checks[1] == 1 && !hasNoChecked(checks, 1))
                query += $"(Worker.SecName LIKE '%{workerIdForSearch.Text}%') AND ";
            if (checks[2] == 1)
            {
                query += $"(Service.[ServiceName] LIKE '%{serviceNameIdSearch.Text}%')";
                return query;
            }
            return "SELECT Service.[ServiceName] as [Наименование услуги], " +
                "DoneService.DoneServiceCost as [Стоимость], " +
                "Client.ClientSecName as [Фамилия клиента], " +
                "Department.DepartmentName as [Наименование отдела], " +
                "DoneService.DoneServiceDate as [Дата], " +
                "Worker.SecName as [Фамилия работника] " +
            "FROM Service, DoneService, Client, Department, Worker " +
            "WHERE (Service.ServiceID = DoneService.DoneServiceName) AND (Client.ClientID = DoneService.DoneServiceClient) AND " +
            "(Department.DepartmentID = DoneService.DoneServiceDepartment) AND (Worker.WorkerID = DoneService.DoneServiceWorker)";
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
