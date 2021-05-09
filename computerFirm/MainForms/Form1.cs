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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> workers;
        string queryForFillTableByWorkers = "SELECT Worker.WorkerID as [Код Работника], " +
            "Worker.SecName as [Фамилия], " +
            "Worker.WorkerName as [Имя], " +
            "Worker.ThirdName as [Отчество], " +
            "Post.PostName as [Должность], " +
            "Department.DepartmentName as [Отдел], " +
            "Worker.PhoneNumber as [Номер телефона]" +
            " FROM Post INNER JOIN (Department INNER JOIN Worker ON Department.departmentID = Worker.Department) ON Post.PostID = Worker.Post";
        OleDbDataAdapter workersTable;
        DataTable tableWorkersWithoutNums;

        public Form1(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public Form1(List<string> role, string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            // Если роль "Продавец" или "Мастер", то скрыть возможность работы с таблицей Работники
            if(role[0] == "seller" || role[0] == "master")
            {
                updateTableStringBtn.Hide();

                label2.Hide();
                workersComboBox.Hide();
                deleteWorkerBtn.Hide();

                addWorkerBtn.Hide();

                /*queryForFillTableByWorkers = "SELECT " +
                "Worker.SecName as [Фамилия], " +
                "Worker.WorkerName as [Имя], " +
                "Worker.ThirdName as [Отчество], " +
                "Post.PostName as [Должность], " +
                "Department.DepartmentName as [Отдел], " +
                "Worker.PhoneNumber as [Номер телефона]" +
                " FROM Post INNER JOIN (Department INNER JOIN Worker ON Department.departmentID = Worker.Department) ON Post.PostID = Worker.Post";*/

            }
            if(!Convert.ToBoolean(role[1]))
            {
                updateTableStringBtn.Hide();
            }
            if(!Convert.ToBoolean(role[2]))
            {
                label2.Hide();
                workersComboBox.Hide();
                deleteWorkerBtn.Hide();
            }
            if(!Convert.ToBoolean(role[3]))
            {
                addWorkerBtn.Hide();
            }

            workers = WorkerDb.GetDataByIdAndField("WorkerID", "SecName", "Worker", myConnection);
            if(workers.Count != 0)
            {
                workersComboBox.Enabled = true;
                deleteWorkerBtn.Enabled = true;
                updateTableStringBtn.Enabled = true;
                workersComboBox.DataSource = new BindingSource(workers, null);
                workersComboBox.DisplayMember = "Value";
                workersComboBox.ValueMember = "Key";
            }
            else
            {
                workersComboBox.Enabled = false;
                deleteWorkerBtn.Enabled = false;
                updateTableStringBtn.Enabled = false;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();   // закрытие связи с базой данных по выходу из приложения
        }

        private void deleteWorkerBtn_Click(object sender, EventArgs e)
        {
            int workerId = -1;
            string secName = "";
            try
            {
                workerId = ((KeyValuePair<int, string>)workersComboBox.SelectedItem).Key;
                secName = ((KeyValuePair<int, string>)workersComboBox.SelectedItem).Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно введён код сотрудника, повторите попытку!", "Ошибка в коде сотрудника",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM Worker WHERE WorkerID = {workerId}";    // запрос на удаление сотрудника по коду
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о сотруднике {secName} удалены");
        }

        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            FormForAddWorkerToDB formDB = new FormForAddWorkerToDB(connectString);
            formDB.Owner = this;
            formDB.Show();
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);
        }

        private void фамилияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(connectString);
            searchForm.Owner = this;
            searchForm.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);
            workers = WorkerDb.GetDataByIdAndField("WorkerID", "SecName", "Worker", myConnection);
            if (workers.Count != 0)
            {
                workersComboBox.Enabled = true;
                deleteWorkerBtn.Enabled = true;
                updateTableStringBtn.Enabled = true;
                workersComboBox.DataSource = new BindingSource(workers, null);
                workersComboBox.DisplayMember = "Value";
                workersComboBox.ValueMember = "Key";
            }
            else
            {
                workersComboBox.Enabled = false;
                deleteWorkerBtn.Enabled = false;
                updateTableStringBtn.Enabled = false;
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(connectString);
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

            string queryToCheckTrue = $"UPDATE Post SET Post.[PostName] = Post.[PostName] WHERE [Post].[PostName] = '{post}'";
            OleDbCommand commandToDo = new OleDbCommand(queryToCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;
            queryToCheckTrue = $"UPDATE Department SET [Department].[DepartmentName] = [Department].[DepartmentName] WHERE [Department].[DepartmentName] = '{otdel}'";
            commandToDo = new OleDbCommand(queryToCheckTrue, myConnection);
            if (commandToDo.ExecuteNonQuery() == 0)
                return;

            string queryToUpdateString = $"UPDATE Worker SET Worker.SecName = '{secName}', Worker.WorkerName = '{name}', Worker.ThirdName = '{thirdName}', Worker.PhoneNumber = '{phoneNum}' WHERE Worker.WorkerID = {workerId}";
            WorkerDb.MakeQueryForChangeTable(queryToUpdateString, myConnection);
            queryToUpdateString = $"UPDATE Worker " +
                $"SET Post=DLookUp(\"PostID\", \"Post\", \"[PostName]= '{post}'\") " +
                $"WHERE Worker.WorkerID = {workerId}";
            WorkerDb.MakeQueryForChangeTable(queryToUpdateString, myConnection);
            queryToUpdateString = $"UPDATE Worker " +
                $"SET Department=DLookUp(\"DepartmentID\", \"Department\", \"[DepartmentName]= '{otdel}'\") " +
                $"WHERE Worker.WorkerID = {workerId}";
            WorkerDb.MakeQueryForChangeTable(queryToUpdateString, myConnection);
            WorkerDb.UpdateTable(myConnection, workersTable, tableWorkersWithoutNums, queryForFillTableByWorkers, dataGridView1);

            MessageBox.Show($"Данные о работнике {secName} обновлены", "Данные обновлены", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
