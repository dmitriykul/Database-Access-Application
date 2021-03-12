using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace computerFirm
{
    public partial class AddNewServiceForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения

        public AddNewServiceForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void addNewServiceBtn_Click(object sender, EventArgs e)
        {
            string serviceName = serviceNameTextBox.Text;
            string serviceCost = serviceCostTextBox.Text;
            int serviceOtdelId = -1;
            try
            {
                serviceOtdelId = Convert.ToInt32(serviceOtdelTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при введении ID отдела, выполняющего услугу, повторите попытку\n{ex.Message}", "Ошибка в ID отдела",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string queryToAddNewService = $"INSERT INTO [Список услуг] ([Вид_услуги], Стоимость, Отдел) VALUES ('{serviceName}', '{serviceCost}', {serviceOtdelId})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewService, myConnection);
            MessageBox.Show("Данные о новой услуге добавлены");
        }

        private void AddNewServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
