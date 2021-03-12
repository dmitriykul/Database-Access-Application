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
    public partial class FormForAddWorkerToDB : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения

        public FormForAddWorkerToDB()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void addWorkerToDbBtn_Click(object sender, EventArgs e)
        {
            string name = workerName.Text;
            string secondName = workerSecondName.Text;
            string thirdName = workerThirdName.Text;
            int post = -1;
            int otdel = -1;
            try
            {
            post = Convert.ToInt32(workerPost.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, неправильно введён номер должности", "Ошибка в номере должности",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
            otdel = Convert.ToInt32(workerOtdel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, возможно неправильно введён номер отдела", "Ошибка в номере отдела",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string phoneNum = workerPhoneNum.Text;
            string queryToAddNewWorker = $"INSERT INTO Работники (Фамилия, Имя, Отчество, Должность, Отдел, Номер_телефона) VALUES ('{name}', '{secondName}', '{thirdName}', {post}, {otdel}, '{phoneNum}')";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewWorker, myConnection);
        }

        private void closeAddFormBtn_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Close();
        }

        private void FormForAddWorkerToDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
