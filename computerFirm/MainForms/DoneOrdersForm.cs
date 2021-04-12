using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;        // модель для работы с базами данных

namespace computerFirm
{
    public partial class DoneOrdersForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillDoneOrdersTable = "SELECT Client.ClientSecName as [Фамилия клиента], " +
            "Product.Product as [Наименование продукта], " +
            "Worker.SecName as [Фамилия работника], " +
            "Department.DepartmentName as [Наименование отдела], " +
            "DoneOrder.DoneOrderDate as [Дата]" +
            "FROM Department INNER JOIN(Worker INNER JOIN (Product INNER JOIN (Client INNER JOIN DoneOrder " +
            "ON Client.ClientID = DoneOrder.DoneOrderClient) " +
            "ON Product.ProductID = DoneOrder.DoneOrderProduct) " +
            "ON Worker.WorkerID = DoneOrder.DoneOrderWorker) " +
            "ON(Department.DepartmentID = Worker.Department) AND(Department.DepartmentID = DoneOrder.DoneOrderDepartment)";
        OleDbDataAdapter doneOrdersAdapter;
        DataTable doneOrdersTable;
        public DoneOrdersForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void DoneOrdersForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, doneOrdersAdapter, doneOrdersTable, queryToFillDoneOrdersTable, dataGridView1);
        }

        private void DoneOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewDoneOrderForm formDB = new AddNewDoneOrderForm(connectString);
            formDB.Owner = this;
            formDB.Show();
        }

        private void DoneOrdersForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, doneOrdersAdapter, doneOrdersTable, queryToFillDoneOrdersTable, dataGridView1);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInDoneOrdersForm searchForm = new SearchInDoneOrdersForm(connectString);
            searchForm.Owner = this;
            searchForm.Show();
        }

        private void поискВПромежуткеДатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDoneOrdersBetweenDateForm formDb = new SearchDoneOrdersBetweenDateForm(connectString);
            formDb.Owner = this;
            formDb.Show();
        }

        private void makeReportBtn_Click(object sender, EventArgs e)
        {
            TestReport testReport = new TestReport();
            testReport.Owner = this;
            testReport.Show();
        }
    }
}
