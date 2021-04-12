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
using System.Data.SqlClient;

namespace computerFirm
{
    public partial class ListOfOrdersForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillServices = "SELECT " +
            "Service.ServiceName as [Наименование услуги], " +
            "Service.ServiceCost as [Стоимость услуги], " +
            "Department.DepartmentName as [Наименование отдела]" +
            "FROM Department INNER JOIN Service ON Department.DepartmentID = Service.ServiceDepartment";
        OleDbDataAdapter servicesAdapter;
        DataTable servicesTable;
        public ListOfOrdersForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public ListOfOrdersForm(List<string> role, string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            if (!Convert.ToBoolean(role[1]))
            {
                button3.Hide();
            }
            if (!Convert.ToBoolean(role[2]))
            {
                label2.Hide();
                serviceToDeleteTextBox.Hide();
                button2.Hide();
            }
            if (!Convert.ToBoolean(role[3]))
            {
                button1.Hide();
            }
        }

        private void ListOfOrdersForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, servicesAdapter, servicesTable, queryToFillServices, dataGridView1);
        }

        private void ListOfOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameServiceToDelete = serviceToDeleteTextBox.Text;
            string query = $"DELETE FROM Service WHERE ServiceName = '{nameServiceToDelete}'";    // запрос на удаление услуги по наименованию
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о услуге '{nameServiceToDelete}' удалены");
            WorkerDb.UpdateTable(myConnection, servicesAdapter, servicesTable, queryToFillServices, dataGridView1);
        }

        private void ListOfOrdersForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, servicesAdapter, servicesTable, queryToFillServices, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewServiceForm formDB = new AddNewServiceForm(connectString);
            formDB.Owner = this;
            formDB.Show();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInListOfServicesForm formDB = new SearchInListOfServicesForm(connectString);
            formDB.Owner = this;
            formDB.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Обновление записей в таблице
            // Проверка количества выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание");
                return;
            }

            // Запоминаем выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            // Проверим данные
            if (dataGridView1.Rows[index].Cells[1].Value.ToString() == "" ||
                dataGridView1.Rows[index].Cells[2].Value.ToString() == "" ||
                dataGridView1.Rows[index].Cells[3].Value.ToString() == "")
            {
                MessageBox.Show("Не все данные присутствуют в таблице", "Внимание");
                return;
            }

            // Считываем данные
            int serviceId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            string serviceName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            decimal serviceCost = Convert.ToDecimal(dataGridView1.Rows[index].Cells[2].Value);
            string otdelName = dataGridView1.Rows[index].Cells[3].Value.ToString();

            //string querytoCheckTrue = $"SELECT * FROM Отделы WHERE [Отделы].[Наименование] = '{otdelName}'";

            string querytoCheckTrue = $"UPDATE Department SET Department.[DepartmentName] = Department.[DepartmentName] WHERE Department.[DepartmentName] = '{otdelName}'";
            OleDbCommand commandToDo = new OleDbCommand(querytoCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;

            string query = $"UPDATE Service SET Service.[ServiceName] = '{serviceName}', Service.ServiceCost = {serviceCost} WHERE ServiceID = {serviceId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            query = $"UPDATE Service " +
                $"SET ServiceDepartment=DLookUp(\"DepartmentID\", \"Department\", \"[DepartmentName]= '{otdelName}'\") " +
                $"WHERE Service.ServiceID = {serviceId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
        }
    }
}