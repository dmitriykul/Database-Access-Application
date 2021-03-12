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
    public partial class PositionsForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public PositionsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter1.Fill(this.computerFirmDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet1.Должности". При необходимости она может быть перемещена или удалена.

        }

        private void addPositionBtn_Click(object sender, EventArgs e)
        {
            AddPositionForm formForAddPos = new AddPositionForm();
            formForAddPos.Owner = this;
            formForAddPos.Show();
        }

        private void deletePositionBtn_Click(object sender, EventArgs e)
        {
            int posId = -1;
            try
            {
                posId = Convert.ToInt32(positionId.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введён код должности, повторите попытку!", "Ошибка в коде должности",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM Должности WHERE postID = {posId}";    // запрос на удаление сотрудника по коду
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о должности {posId} удалены");
        }

        private void PositionsForm_Activated(object sender, EventArgs e)
        {
            this.должностиTableAdapter1.Fill(this.computerFirmDataSet.Должности);
        }

        private void PositionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
            int postId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            string positionName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            decimal positionSalary = Convert.ToDecimal(dataGridView1.Rows[index].Cells[2].Value);


            string query = $"UPDATE Должности SET Название = '{positionName}', Зарплата = {positionSalary} WHERE postID = {postId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
        }
    }
}
