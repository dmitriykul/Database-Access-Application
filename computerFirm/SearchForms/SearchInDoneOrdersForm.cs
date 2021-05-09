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
    public partial class SearchInDoneOrdersForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchInDoneOrdersForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
        }

        private void searchInDoneOrders_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), makeQuery(), dataGridView1);
            myConnection.Close();
        }

        public string makeQuery()
        {
            string query = "SELECT Client.ClientSecName as [Фамилия клиента], " +
                "Product.Product as [Наименование продукта], " +
                "Worker.SecName as [Фамилия работника], " +
                "Department.DepartmentName as [Наименование отдела], " +
                "DoneOrder.DoneOrderDate as [Дата] " +
                "FROM Department INNER JOIN(Worker INNER JOIN (Product INNER JOIN (Client INNER JOIN DoneOrder " +
                "ON Client.ClientID = DoneOrder.DoneOrderClient) " +
                "ON Product.ProductID = DoneOrder.DoneOrderProduct) " +
                "ON Worker.WorkerID = DoneOrder.DoneOrderWorker) " +
                "ON(Department.DepartmentID = Worker.Department) AND (Department.DepartmentID = DoneOrder.DoneOrderDepartment) " +
                "WHERE ";
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"(Client.ClientSecName LIKE '{clientIdForSearch.Text}%')";
                return query;
            }
            else if (checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"(Client.ClientSecName LIKE '{clientIdForSearch.Text}%') AND ";

            if (checks[1] == 1)
            {
                query += $"(Worker.SecName LIKE '{workerIdForSearch.Text}%')";
                return query;
            }
            return "SELECT Client.ClientSecName as [Фамилия клиента], " +
                "Product.Product as [Наименование продукта], " +
                "Worker.SecName as [Фамилия работника], " +
                "Department.DepartmentName as [Наименование отдела], " +
                "DoneOrder.DoneOrderDate as [Дата] " +
                "FROM Department INNER JOIN(Worker INNER JOIN (Product INNER JOIN (Client INNER JOIN DoneOrder " +
                "ON Client.ClientID = DoneOrder.DoneOrderClient) " +
                "ON Product.ProductID = DoneOrder.DoneOrderProduct) " +
                "ON Worker.WorkerID = DoneOrder.DoneOrderWorker) " +
                "ON(Department.DepartmentID = Worker.Department) AND(Department.DepartmentID = DoneOrder.DoneOrderDepartment)";
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
