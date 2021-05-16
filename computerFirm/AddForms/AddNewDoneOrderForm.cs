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
    public partial class AddNewDoneOrderForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> clients;
        private Dictionary<int, string> products;
        private Dictionary<int, string> workers;
        private Dictionary<int, string> departments;
        public AddNewDoneOrderForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            this.FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            clients = WorkerDb.GetDataByIdAndField("ClientID", "ClientSecName", "Client", myConnection);
            if(clients.Count() != 0)
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

            products = WorkerDb.GetDataByIdAndField("ProductID", "Product", "Product", myConnection);
            if(products.Count() != 0)
            {
                productComboBox.Enabled = true;
                productComboBox.DataSource = new BindingSource(products, null);
                productComboBox.DisplayMember = "Value";
                productComboBox.ValueMember = "Key";
            }
            else
            {
                productComboBox.Enabled = false;
            }
            departments = WorkerDb.GetDataByIdAndField("DepartmentID", "DepartmentName", "Department", myConnection);
            if(departments.Count() != 0)
            {
                departmentComboBox.Enabled = true;
                departmentComboBox.DataSource = new BindingSource(departments, null);
                departmentComboBox.DisplayMember = "Value";
                departmentComboBox.ValueMember = "Key";
            }
            else
            {
                departmentComboBox.Enabled = false;
            }

            int otdelServiceId = ((KeyValuePair<int, string>)departmentComboBox.SelectedItem).Key;

            workers = WorkerDb.GetDataByTwoDifferentTables("WorkerID", "SecName", "Worker", "Department", otdelServiceId, myConnection);
            if(workers.Count() != 0 && otdelServiceId != 0)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int clientID = -1, productID = -1, workerID = -1, otdelID = -1;
            //string date = dateOfOrder.Text;
            string date = dateOrder.Value.ToString("dd/MM/yyyy");
            date = date.Replace(".", "/");
            try
            {
                clientID = ((KeyValuePair<int, string>)clientComboBox.SelectedItem).Key;
                productID = ((KeyValuePair<int, string>)productComboBox.SelectedItem).Key;
                workerID = ((KeyValuePair<int, string>)workerComboBox.SelectedItem).Key;
                otdelID = ((KeyValuePair<int, string>)departmentComboBox.SelectedItem).Key;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка, возможно неправильно введён какой-либо ID\n{ex.Message}", "Ошибка в ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return;
            }

            List<string> dateTest = date.Split('/').ToList();
            if (dateTest.Count != 3 || Convert.ToInt32(dateTest[0]) <= 0 || Convert.ToInt32(dateTest[0]) > 31 ||
                Convert.ToInt32(dateTest[1]) <= 0 || Convert.ToInt32(dateTest[1]) > 12)
            {
                MessageBox.Show("Неправильный формат даты", "Ошибка в поле Дата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryToAddNewDoneOrder = $"INSERT INTO DoneOrder (DoneOrderClient, DoneOrderProduct, DoneOrderWorker, DoneOrderDepartment, DoneOrderDate) VALUES ({clientID}, {productID}, {workerID}, {otdelID}, #{date}#)";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewDoneOrder, myConnection);
            MessageBox.Show("Данные о новом выполненном заказе добавлены");
        }

        private void AddNewDoneOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            
        }

        private void departmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int otdelServiceId = ((KeyValuePair<int, string>)departmentComboBox.SelectedItem).Key;

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
