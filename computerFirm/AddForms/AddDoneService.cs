﻿using System;
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

            services = WorkerDb.GetDataByIdAndField("ServiceID", "ServiceName", "Service", myConnection);
            serviceNameComboBox.DataSource = new BindingSource(services, null);
            serviceNameComboBox.DisplayMember = "Value";
            serviceNameComboBox.ValueMember = "Key";
            clients = WorkerDb.GetDataByIdAndField("ClientID", "ClientSecName", "Client", myConnection);
            clientComboBox.DataSource = new BindingSource(clients, null);
            clientComboBox.DisplayMember = "Value";
            clientComboBox.ValueMember = "Key";
            departments = WorkerDb.GetDataByIdAndField("DepartmentID", "DepartmentName", "Department", myConnection);
            departComboBox.DataSource = new BindingSource(departments, null);
            departComboBox.DisplayMember = "Value";
            departComboBox.ValueMember = "Key";
            workers = WorkerDb.GetDataByIdAndField("WorkerID", "SecName", "Worker", myConnection);
            workerComboBox.DataSource = new BindingSource(workers, null);
            workerComboBox.DisplayMember = "Value";
            workerComboBox.ValueMember = "Key";
        }

        private void addDoneServices_Click(object sender, EventArgs e)
        {
            int clientId = -1, nameServiceId = -1, otdelServiceId = -1, workerServiceId = -1;
            string date = serviceDate.Text, cost = serviceCost.Text;
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

            string queryToAddNewDoneService = $"INSERT INTO DoneService (DoneServiceName, DoneServiceCost, DoneServiceClient, DoneServiceDepartment, DoneServiceDate, DoneServiceWorker) VALUES ({nameServiceId}, '{cost}', {clientId}, {otdelServiceId}, #{date}#, {workerServiceId})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewDoneService, myConnection);
            MessageBox.Show("Данные о выполненной услуге добавлены");

        }

        private void AddDoneService_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}