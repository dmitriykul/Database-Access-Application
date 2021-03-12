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
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public AddNewDoneOrderForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clientID = -1, productID = -1, workerID = -1, otdelID = -1;
            string date = dateOfOrder.Text;
            try
            {
                clientID = Convert.ToInt32(clientId.Text);
                productID = Convert.ToInt32(productId.Text);
                workerID = Convert.ToInt32(workerId.Text);
                otdelID = Convert.ToInt32(otdelId.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка, возможно неправильно введён какой-либо ID\n{ex.Message}", "Ошибка в ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }

            string queryToAddNewDoneOrder = $"INSERT INTO [Выполненные заказы] (Клиент, Продукт, Работник, Отдел, Дата) VALUES ({clientID}, {productID}, {workerID}, {otdelID}, #{date}#)";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewDoneOrder, myConnection);
            MessageBox.Show("Данные о новом заказе добавлены");
        }

        private void AddNewDoneOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            
        }
    }
}
