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
using System.Data.SqlClient;

namespace computerFirm
{
    public partial class ListOfOrdersForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillServices = "SELECT Service.ServiceID as [Код услуги], " +
            "Service.ServiceName as [Наименование услуги], " +
            "Service.ServiceCost as [Стоимость услуги], " +
            "Department.DepartmentName as [Наименование отдела]" +
            "FROM Department INNER JOIN Service ON Department.DepartmentID = Service.ServiceDepartment";
        private Dictionary<int, string> services;
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
            // если роль "Продавец" или "Мастер", то скрыть возможность работы с таблицей Услуги
            if (role[0] == "seller" || role[0] == "master")
            {
                button3.Hide();

                label2.Hide();
                ServicesComboBox.Hide();
                button2.Hide();

                button1.Hide();
            }
            if (!Convert.ToBoolean(role[1]))
            {
                button3.Hide();
            }
            if (!Convert.ToBoolean(role[2]))
            {
                label2.Hide();
                ServicesComboBox.Hide();
                button2.Hide();
            }
            if (!Convert.ToBoolean(role[3]))
            {
                button1.Hide();
            }

            services = WorkerDb.GetDataByIdAndField("ServiceID", "ServiceName", "Service", myConnection);
            if(services.Count != 0)
            {
                ServicesComboBox.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                ServicesComboBox.DataSource = new BindingSource(services, null);
                ServicesComboBox.DisplayMember = "Value";
                ServicesComboBox.ValueMember = "Key";
            }
            else
            {
                ServicesComboBox.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void ListOfOrdersForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, servicesAdapter, servicesTable, queryToFillServices, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
        }

        private void ListOfOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idServiceToDelete = ((KeyValuePair<int, string>)ServicesComboBox.SelectedItem).Key;
            string nameServiceToDelete = ((KeyValuePair<int, string>)ServicesComboBox.SelectedItem).Value;
            string query = $"DELETE FROM Service WHERE ServiceID = {idServiceToDelete}";    // запрос на удаление услуги по наименованию
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о услуге {nameServiceToDelete} удалены");
            WorkerDb.UpdateTable(myConnection, servicesAdapter, servicesTable, queryToFillServices, dataGridView1);
        }

        private void ListOfOrdersForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, servicesAdapter, servicesTable, queryToFillServices, dataGridView1);
            services = WorkerDb.GetDataByIdAndField("ServiceID", "ServiceName", "Service", myConnection);
            if (services.Count != 0)
            {
                ServicesComboBox.Enabled = true;
                button2.Enabled = true;
                ServicesComboBox.DataSource = new BindingSource(services, null);
                ServicesComboBox.DisplayMember = "Value";
                ServicesComboBox.ValueMember = "Key";
            }
            else
            {
                ServicesComboBox.Enabled = false;
                button2.Enabled = false;
            }
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

            MessageBox.Show($"Данные о услуге {serviceName} обновлены");
        }
    }
}
