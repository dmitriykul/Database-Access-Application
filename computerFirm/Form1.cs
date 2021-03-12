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
    public partial class Form1 : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        string queryForFillTableByWorkers = "SELECT Работники.workerID, Работники.Фамилия, Работники.Имя, Работники.Отчество, Должности.Название, Отделы.Наименование, Работники.Номер_телефона" +
            " FROM Должности INNER JOIN (Отделы INNER JOIN Работники ON Отделы.departmentID = Работники.Отдел) ON Должности.postID = Работники.Должность";
        OleDbDataAdapter workersTable;
        DataTable tableWorkersWithoutNums;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();   // закрытие связи с базой данных по выходу из приложения
        }

        private void deleteWorkerBtn_Click(object sender, EventArgs e)
        {
            int workerId = -1;
            try
            {
                workerId = Convert.ToInt32(workerid.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно введён код сотрудника, повторите попытку!", "Ошибка в коде сотрудника",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM Работники WHERE workerID = {workerId}";    // запрос на удаление сотрудника по коду
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о сотруднике {workerId} удалены");
        }

        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            FormForAddWorkerToDB formDB = new FormForAddWorkerToDB();
            formDB.Owner = this;
            formDB.Show();
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);
        }

        private void фамилияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Owner = this;
            searchForm.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Owner = this;
            searchForm.Show();
        }

        private void updateTableStringBtn_Click(object sender, EventArgs e)
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
                dataGridView1.Rows[index].Cells[3].Value.ToString() == "" ||
                dataGridView1.Rows[index].Cells[4].Value.ToString() == "" ||
                dataGridView1.Rows[index].Cells[5].Value.ToString() == "" ||
                dataGridView1.Rows[index].Cells[6].Value.ToString() == "")
            {
                MessageBox.Show("Не все данные присутствуют в таблице", "Внимание");
                return;
            }

            // Считываем данные
            string secName = dataGridView1.Rows[index].Cells[1].Value.ToString(),
                name = dataGridView1.Rows[index].Cells[2].Value.ToString(),
                thirdName = dataGridView1.Rows[index].Cells[3].Value.ToString(),
                post = dataGridView1.Rows[index].Cells[4].Value.ToString(),
                otdel = dataGridView1.Rows[index].Cells[5].Value.ToString(),
                phoneNum = dataGridView1.Rows[index].Cells[6].Value.ToString();
            int workerId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

            string queryToCheckTrue = $"UPDATE Должности SET Должности.[Название] = Должности.[Название] WHERE [Должности].[Название] = '{post}'";
            OleDbCommand commandToDo = new OleDbCommand(queryToCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;
            queryToCheckTrue = $"UPDATE Отделы SET [Отделы].[Наименование] = [Отделы].[Наименование] WHERE [Отделы].[Наименование] = '{otdel}'";
            commandToDo = new OleDbCommand(queryToCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;

            string queryToUpdateString = $"UPDATE Работники SET Работники.Фамилия = '{secName}', Работники.Имя = '{name}', Работники.Отчество = '{thirdName}', Работники.Номер_телефона = '{phoneNum}' WHERE Работники.workerID = {workerId}";
            WorkerDb.MakeQueryForChangeTable(queryToUpdateString, myConnection);
            queryToUpdateString = $"UPDATE Работники " +
                $"SET Должность=DLookUp(\"postID\", \"Должности\", \"[Название]= '{post}'\") " +
                $"WHERE Работники.workerID = {workerId}";
            WorkerDb.MakeQueryForChangeTable(queryToUpdateString, myConnection);
            queryToUpdateString = $"UPDATE Работники " +
                $"SET Отдел=DLookUp(\"departmentID\", \"Отделы\", \"[Наименование]= '{otdel}'\") " +
                $"WHERE Работники.workerID = {workerId}";
            WorkerDb.MakeQueryForChangeTable(queryToUpdateString, myConnection);
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);
        }
    }
}
