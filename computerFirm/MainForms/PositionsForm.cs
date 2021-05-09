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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> positions;
        string queryToFillTableByPosts = "SELECT PostID as [Код должности], " +
            "PostName as [Название должности], " +
            "Salary as [Зарплата] FROM Post";
        OleDbDataAdapter postTable;
        DataTable tablePost;
        public PositionsForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public PositionsForm(List<string> role, string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            // Если роль "Продавец" или "Мастер", то скрыть возможность работы стаблицей Должности
            if(role[0] == "seller" || role[0] == "master")
            {
                button1.Hide();

                label2.Hide();
                positionsComboBox.Hide();
                deletePositionBtn.Hide();

                addPositionBtn.Hide();

                queryToFillTableByPosts = "SELECT " +
                "PostName as [Название должности], " +
                "Salary as [Зарплата] FROM Post";
            }
            if(!Convert.ToBoolean(role[1]))
            {
                button1.Hide();
            }
            if(!Convert.ToBoolean(role[2]))
            {
                label2.Hide();
                positionsComboBox.Hide();
                deletePositionBtn.Hide();
            }
            if(!Convert.ToBoolean(role[3]))
            {
                addPositionBtn.Hide();
            }

            positions = WorkerDb.GetDataByIdAndField("PostID", "PostName", "Post", myConnection);
            if (positions.Count != 0)
            {
                positionsComboBox.Enabled = true;
                deletePositionBtn.Enabled = true;
                button1.Enabled = true;
                positionsComboBox.DataSource = new BindingSource(positions, null);
                positionsComboBox.DisplayMember = "Value";
                positionsComboBox.ValueMember = "Key";
            }
            else
            {
                positionsComboBox.Enabled = false;
                deletePositionBtn.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, postTable, tablePost, queryToFillTableByPosts, dataGridView1);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }

        private void addPositionBtn_Click(object sender, EventArgs e)
        {
            AddPositionForm formForAddPos = new AddPositionForm(connectString);
            formForAddPos.Owner = this;
            formForAddPos.Show();
        }

        private void deletePositionBtn_Click(object sender, EventArgs e)
        {
            int posId = -1;
            string postName = "";
            try
            {
                posId = ((KeyValuePair<int, string>)positionsComboBox.SelectedItem).Key;
                postName = ((KeyValuePair<int, string>)positionsComboBox.SelectedItem).Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введён код должности, повторите попытку!", "Ошибка в коде должности",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM Post WHERE PostID = {posId}";    // запрос на удаление сотрудника по коду
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о должности {postName} удалены");
        }

        private void PositionsForm_Activated(object sender, EventArgs e)
        {
            //this.должностиTableAdapter1.Fill(this.computerFirmDataSet.Должности);
            WorkerDb.UpdateTable(myConnection, postTable, tablePost, queryToFillTableByPosts, dataGridView1);
            positions = WorkerDb.GetDataByIdAndField("PostID", "PostName", "Post", myConnection);
            if (positions.Count != 0)
            {
                positionsComboBox.Enabled = true;
                deletePositionBtn.Enabled = true;
                button1.Enabled = true;
                positionsComboBox.DataSource = new BindingSource(positions, null);
                positionsComboBox.DisplayMember = "Value";
                positionsComboBox.ValueMember = "Key";
            }
            else
            {
                positionsComboBox.Enabled = false;
                deletePositionBtn.Enabled = false;
                button1.Enabled = false;
            }
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


            string query = $"UPDATE Post SET PostName = '{positionName}', Salary = {positionSalary} WHERE PostID = {postId}";
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о должности {positionName} изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
