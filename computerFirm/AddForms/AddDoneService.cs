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
    public partial class AddDoneService : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> services;
        private Dictionary<int, string> clients;
        private Dictionary<int, string> departments;
        private Dictionary<int, string> workers;
        public AddDoneService(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            clients = WorkerDb.GetDataByIdAndField("ClientID", "ClientSecName", "Client", myConnection);
            if (clients.Count() != 0)
            {
                clientComboBox.Enabled = true;
                clientComboBox.DataSource = new BindingSource(clients, null);
                clientComboBox.DisplayMember = "Value";
                clientComboBox.ValueMember = "Key";
            }
            else
            {
                clientComboBox.Enabled = false;
            }

            departments = WorkerDb.GetDataByIdAndField("DepartmentID", "DepartmentName", "Department", myConnection);
            if (departments.Count() != 0)
            {
                departComboBox.Enabled = true;
                departComboBox.DataSource = new BindingSource(departments, null);
                departComboBox.DisplayMember = "Value";
                departComboBox.ValueMember = "Key";
            }
            else
            {
                departComboBox.Enabled = false;
            }

            services = WorkerDb.GetDataByIdAndField("ServiceID", "ServiceName", "Service", myConnection);
            if(services.Count() != 0)
            {
                serviceNameComboBox.Enabled = true;
                serviceNameComboBox.DataSource = new BindingSource(services, null);
                serviceNameComboBox.DisplayMember = "Value";
                serviceNameComboBox.ValueMember = "Key";
            }
            else
            {
                serviceNameComboBox.Enabled = false;
            }

            int otdelServiceId = ((KeyValuePair<int, string>)departComboBox.SelectedItem).Key;

            workers = WorkerDb.GetDataByTwoDifferentTables("WorkerID", "SecName", "Worker", "Department", otdelServiceId, myConnection);
            if(workers.Count() != 0)
            {
                workerComboBox.Enabled = true;
                workerComboBox.DataSource = new BindingSource(workers, null);
                workerComboBox.DisplayMember = "Value";
                workerComboBox.ValueMember = "Key";
            }
            else
            {
                workerComboBox.Enabled = false;
            }
        }

        private void addDoneServices_Click(object sender, EventArgs e)
        {
            int clientId = -1, nameServiceId = -1, otdelServiceId = -1, workerServiceId = -1;
            //string date = serviceDate.Text;
            string costText = serviceCost.Text;
            string date = dateService.Value.ToString("dd/MM/yyyy");
            date = date.Replace(".", "/");
            int cost = 0;
            try
            {
                clientId = ((KeyValuePair<int, string>)clientComboBox.SelectedItem).Key;
                nameServiceId = ((KeyValuePair<int, string>)serviceNameComboBox.SelectedItem).Key;
                otdelServiceId = ((KeyValuePair<int, string>)departComboBox.SelectedItem).Key;
                workerServiceId = ((KeyValuePair<int, string>)workerComboBox.SelectedItem).Key;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка ввода какого-либо поля id, повторите попытку\n{ex.Message}", "Ошбика ввода id",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cost = Math.Abs(Convert.ToInt32(costText));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Неверный формат поля Стоимость", "Ошибка в поле Стоимость", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // проверка даты
            List<string> dateTest = date.Split('/').ToList();
            if (dateTest.Count != 3 || Convert.ToInt32(dateTest[0]) <= 0 || Convert.ToInt32(dateTest[0]) > 31 ||
                Convert.ToInt32(dateTest[1]) <= 0 || Convert.ToInt32(dateTest[1]) > 12)
            {
                MessageBox.Show("Неправильный формат даты", "Ошибка в поле Дата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryToAddNewDoneService = $"INSERT INTO DoneService (DoneServiceName, DoneServiceCost, DoneServiceClient, DoneServiceDepartment, DoneServiceDate, DoneServiceWorker) VALUES ({nameServiceId}, {cost}, {clientId}, {otdelServiceId}, #{date}#, {workerServiceId})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewDoneService, myConnection);
            MessageBox.Show("Данные о выполненной услуге добавлены");

        }

        private void AddDoneService_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void departComboBox_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void departComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int otdelServiceId = ((KeyValuePair<int, string>)departComboBox.SelectedItem).Key;

            workers = WorkerDb.GetDataByTwoDifferentTables("WorkerID", "SecName", "Worker", "Department", otdelServiceId, myConnection);
            if(workers.Count() != 0)
            {
                workerComboBox.Enabled = true;
                workerComboBox.DataSource = new BindingSource(workers, null);
                workerComboBox.DisplayMember = "Value";
                workerComboBox.ValueMember = "Key";
            }
            else
            {
                workerComboBox.Enabled = false;
            }
        }
    }
}
