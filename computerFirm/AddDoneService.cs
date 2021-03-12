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
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public AddDoneService()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void addDoneServices_Click(object sender, EventArgs e)
        {
            int clientId = -1, nameServiceId = -1, otdelServiceId = -1, workerServiceId = -1;
            string date = serviceDate.Text, cost = serviceCost.Text;
            try
            {
                clientId = Convert.ToInt32(serviceClientId.Text);
                nameServiceId = Convert.ToInt32(serviceNameId.Text);
                otdelServiceId = Convert.ToInt32(serviceOtdelId.Text);
                workerServiceId = Convert.ToInt32(serviceWorkerId.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка ввода какого-либо поля id, повторите попытку\n{ex.Message}", "Ошбика ввода id",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string queryToAddNewDoneService = $"INSERT INTO [Выполненные услуги] (Наименование, Стоимость, Клиент, Отдел, Дата, Работник) VALUES ({nameServiceId}, '{cost}', {clientId}, {otdelServiceId}, #{date}#, {workerServiceId})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewDoneService, myConnection);
            MessageBox.Show("Данные о выполненной услуге добавлены");

        }

        private void AddDoneService_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
