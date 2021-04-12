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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillDoneServicesTable = "SELECT Service.[ServiceName] as [Наименование услуги], " +
            "DoneService.DoneServiceCost as [Стоимость], " +
            "Client.ClientSecName as [Фамилия клиента], " +
            "Department.DepartmentName as [Наименование отдела], " +
            "DoneService.DoneServiceDate as [Дата], " +
            "Worker.SecName as [Фамилия работника] " +
            "FROM Service, DoneService, Client, Department, Worker " +
            "WHERE (Service.ServiceID = DoneService.DoneServiceName) AND (Client.ClientID = DoneServiceClient) AND " +
            "(Department.DepartmentID = DoneService.DoneServiceDepartment) AND (Worker.WorkerID = DoneService.DoneServiceWorker)";
        OleDbDataAdapter doneServicesAdapter;
        DataTable doneServicesTable;
        public DoneServicesForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
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
            AddDoneService formDB = new AddDoneService(connectString);
            formDB.Owner = this;
            formDB.Show();
        }

        private void DoneServicesForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, doneServicesAdapter, doneServicesTable, queryToFillDoneServicesTable, dataGridView1);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInDoneServicesForm searchForm = new SearchInDoneServicesForm(connectString);
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
