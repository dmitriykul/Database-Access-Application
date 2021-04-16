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
    public partial class ProvidersForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillTableByProviders = "SELECT ProviderID as [Код поставщика], " +
            "ProviderName as [Наименованние фирмы]," +
            "ProviderEmail as [Электронная почта] FROM Provider";
        OleDbDataAdapter providerAdapter;
        DataTable providerTable;
        public ProvidersForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public ProvidersForm(List<string> role, string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта

            // Если роль "Продавец" или "Мастер", то скрыть возможности работы с таблицей Поставщики
            if(role[0]=="seller" || role[0]=="master")
            {
                button2.Hide();

                button1.Hide();
            }
            if(!Convert.ToBoolean(role[1]))
            {
                button2.Hide();
            }
            if(!Convert.ToBoolean(role[3]))
            {
                button1.Hide();
            }
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, providerAdapter, providerTable, queryToFillTableByProviders, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
        }

        private void ProvidersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewProviderForm formDb = new AddNewProviderForm(connectString);
            formDb.Owner = this;
            formDb.Show();
        }

        private void ProvidersForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, providerAdapter, providerTable, queryToFillTableByProviders, dataGridView1);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProvidersForm formDb = new SearchProvidersForm(connectString);
            formDb.Owner = this;
            formDb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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
                dataGridView1.Rows[index].Cells[2].Value.ToString() == "")
            {
                MessageBox.Show("Не все данные присутствуют в таблице", "Внимание");
                return;
            }

            // Считываем данные
            int providerId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            string providerName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string providerEmail = dataGridView1.Rows[index].Cells[2].Value.ToString();
            

            string query = $"UPDATE Provider SET [ProviderName] = '{providerName}', ProviderEmail = '{providerEmail}' WHERE ProviderID = {providerId}";
            OleDbCommand commandToUpdate = new OleDbCommand(query, myConnection);
            // Выполняем запрос
            if (commandToUpdate.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show($"Данные о поставщике {providerName} обновлены");
                WorkerDb.UpdateTable(myConnection, providerAdapter, providerTable, queryToFillTableByProviders, dataGridView1);
            }
        }
    }
}
