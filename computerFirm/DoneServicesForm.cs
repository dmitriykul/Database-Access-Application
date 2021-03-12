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
    public partial class DoneServicesForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillDoneServicesTable = "SELECT [Список услуг].[Вид_услуги], [Выполненные услуги].Стоимость, Клиенты.Фамилия_клиента, Отделы.Наименование, [Выполненные услуги].Дата, Работники.[Фамилия] " +
            "FROM [Список услуг], [Выполненные услуги], Клиенты, Отделы, Работники " +
            "WHERE ([Список услуг].serviceID = [Выполненные услуги].Наименование) AND (Клиенты.clientID = [Выполненные услуги].Клиент) AND " +
            "(Отделы.departmentID = [Выполненные услуги].Отдел) AND (Работники.workerID = [Выполненные услуги].Работник)";
        OleDbDataAdapter doneServicesAdapter;
        DataTable doneServicesTable;
        public DoneServicesForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void DoneServicesForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, doneServicesAdapter, doneServicesTable, queryToFillDoneServicesTable, dataGridView1);
        }

        private void DoneServicesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoneService formDB = new AddDoneService();
            formDB.Owner = this;
            formDB.Show();
        }

        private void DoneServicesForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, doneServicesAdapter, doneServicesTable, queryToFillDoneServicesTable, dataGridView1);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInDoneServicesForm searchForm = new SearchInDoneServicesForm();
            searchForm.Owner = this;
            searchForm.Show();
        }

        private void makeReportServiceBtn_Click(object sender, EventArgs e)
        {
            //DataTable doneServicesReportTable = WorkerDb.MakeReportTable(myConnection, doneServicesReportAdapter, queryToFillDoneServicesTable);
            DoneServicesReportForm serviceReport = new DoneServicesReportForm();
            serviceReport.Owner = this;
            serviceReport.Show();
        }
    }
}
