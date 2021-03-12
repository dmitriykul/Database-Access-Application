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
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillServices = "SELECT [Список услуг].serviceID, [Список услуг].[Вид_услуги], [Список услуг].Стоимость, Отделы.Наименование " +
            "FROM Отделы INNER JOIN[Список услуг] ON Отделы.departmentID = [Список услуг].Отдел";
        OleDbDataAdapter servicesAdapter;
        DataTable servicesTable;
        public ListOfOrdersForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
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
            string query = $"DELETE FROM [Список услуг] WHERE [Вид_услуги] = '{nameServiceToDelete}'";    // запрос на удаление услуги по наименованию
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
            AddNewServiceForm formDB = new AddNewServiceForm();
            formDB.Owner = this;
            formDB.Show();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInListOfServicesForm formDB = new SearchInListOfServicesForm();
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

            string querytoCheckTrue = $"UPDATE Отделы SET Отделы.[Наименование] = Отделы.[Наименование] WHERE Отделы.[Наименование] = '{otdelName}'";
            OleDbCommand commandToDo = new OleDbCommand(querytoCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;

            string query = $"UPDATE [Список услуг] SET [Список услуг].[Вид_услуги] = '{serviceName}', [Список услуг].Стоимость = {serviceCost} WHERE serviceID = {serviceId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            query = $"UPDATE [Список услуг] " +
                $"SET Отдел=DLookUp(\"departmentID\", \"Отделы\", \"[Наименование]= '{otdelName}'\") " +
                $"WHERE [Список услуг].serviceID = {serviceId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
        }
    }
}
