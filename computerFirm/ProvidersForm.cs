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
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public ProvidersForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter1.Fill(this.computerFirmDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet4.Поставщики". При необходимости она может быть перемещена или удалена.

        }

        private void ProvidersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewProviderForm formDb = new AddNewProviderForm();
            formDb.Owner = this;
            formDb.Show();
        }

        private void ProvidersForm_Activated(object sender, EventArgs e)
        {
            this.поставщикиTableAdapter1.Fill(this.computerFirmDataSet.Поставщики);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProvidersForm formDb = new SearchProvidersForm();
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
            

            string query = $"UPDATE Поставщики SET [Наименование фирмы] = '{providerName}', Email = '{providerEmail}' WHERE providerID = {providerId}";
            OleDbCommand commandToUpdate = new OleDbCommand(query, myConnection);
            // Выполняем запрос
            if (commandToUpdate.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show($"Данные о поставщике {providerName} обновлены");
                this.поставщикиTableAdapter1.Fill(this.computerFirmDataSet.Поставщики);    // обновление данных из таблицы на экран
            }
        }
    }
}
