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
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillDoneOrdersTable = "SELECT Клиенты.Фамилия_клиента, Продукция.Продукт, Работники.Фамилия, Отделы.Наименование, [Выполненные заказы].Дата " +
            "FROM Отделы INNER JOIN(Работники INNER JOIN (Продукция INNER JOIN (Клиенты INNER JOIN [Выполненные заказы] " +
            "ON Клиенты.clientID = [Выполненные заказы].Клиент) " +
            "ON Продукция.productID = [Выполненные заказы].Продукт) " +
            "ON Работники.workerID = [Выполненные заказы].Работник) " +
            "ON(Отделы.departmentID = Работники.Отдел) AND(Отделы.departmentID = [Выполненные заказы].Отдел)";
        OleDbDataAdapter doneOrdersAdapter;
        DataTable doneOrdersTable;
        public DoneOrdersForm()
        {
            InitializeComponent();
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
            AddNewDoneOrderForm formDB = new AddNewDoneOrderForm();
            formDB.Owner = this;
            formDB.Show();
        }

        private void DoneOrdersForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, doneOrdersAdapter, doneOrdersTable, queryToFillDoneOrdersTable, dataGridView1);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInDoneOrdersForm searchForm = new SearchInDoneOrdersForm();
            searchForm.Owner = this;
            searchForm.Show();
        }

        private void поискВПромежуткеДатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDoneOrdersBetweenDateForm formDb = new SearchDoneOrdersBetweenDateForm();
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
