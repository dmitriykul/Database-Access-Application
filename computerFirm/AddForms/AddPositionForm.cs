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
    public partial class AddPositionForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        public AddPositionForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void addPositionBtn_Click(object sender, EventArgs e)
        {
            string posName = positionName.Text;
            if(posName == "")
            {
                MessageBox.Show("Пожалуйста, введите название должности", "Не введено название должности", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            decimal posSalary = 0;
            try
            {
                posSalary = Convert.ToDecimal(positionSalary.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введено поле Зарплата, повторите попытку!", "Ошибка в поле Зарплата",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryForAddPosition = $"INSERT INTO Post (PostName, Salary) VALUES ('{posName}', {posSalary})";
            WorkerDb.MakeQueryForChangeTable(queryForAddPosition, myConnection);
            MessageBox.Show("Данные о новой должности добавлены");
        }

        private void closeAddPositionFormBtn_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Close();
        }
    }
}
