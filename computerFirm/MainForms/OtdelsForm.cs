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
    public partial class OtdelsForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> departments;
        string queryToFillOtdels = "SELECT DepartmentID as [Код отдела], " +
            "DepartmentName as [Название отдела] FROM Department";
        OleDbDataAdapter otdelsAdapter;
        DataTable otdelsTable;
        public OtdelsForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public OtdelsForm(List<string> role, string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта

            // Если роль "Продавец" или "Мастер", то скрыть возможность работы с таблицей Отделы
            if(role[0]=="seller" || role[0] == "master")
            {
                label2.Hide();
                departmentsComboBox.Hide();
                deleteOtdelBtn.Hide();

                label3.Hide();
                otdelNameTextbox.Hide();
                button1.Hide();

                queryToFillOtdels = "SELECT " +
                "DepartmentName as [Название отдела] FROM Department";
            }

            if(!Convert.ToBoolean(role[2]))
            {
                label2.Hide();
                departmentsComboBox.Hide();
                deleteOtdelBtn.Hide();
            }

            if(!Convert.ToBoolean(role[3]))
            {
                label3.Hide();
                otdelNameTextbox.Hide();
                button1.Hide();
            }

            departments = WorkerDb.GetDataByIdAndField("DepartmentID", "DepartmentName", "Department", myConnection);
            if (departments.Count != 0)
            {
                departmentsComboBox.Enabled = true;
                deleteOtdelBtn.Enabled = true;
                departmentsComboBox.DataSource = new BindingSource(departments, null);
                departmentsComboBox.DisplayMember = "Value";
                departmentsComboBox.ValueMember = "Key";
            }
            else
            {
                departmentsComboBox.Enabled = false;
                deleteOtdelBtn.Enabled = false;
            }
        }

        private void OtdelsForm_Load(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, otdelsAdapter, otdelsTable, queryToFillOtdels, dataGridView1);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }

        private void OtdelsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void deleteOtdelBtn_Click(object sender, EventArgs e)
        {
            int otdelId = -1;
            string depName = "";
            try
            {
                otdelId = ((KeyValuePair<int, string>)departmentsComboBox.SelectedItem).Key;
                depName = ((KeyValuePair<int, string>)departmentsComboBox.SelectedItem).Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неправильно введён код сотрудника, повторите попытку!\n{ex.Message}", "Ошибка в коде отдела",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = $"DELETE FROM Department WHERE DepartmentID = {otdelId}";    // запрос на удаление сотрудника по коду
            WorkerDb.MakeQueryForChangeTable(query, myConnection);
            MessageBox.Show($"Данные о отделе {depName} удалены");
            WorkerDb.UpdateTable(myConnection, otdelsAdapter, otdelsTable, queryToFillOtdels, dataGridView1);
        }

        private void OtdelsForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, otdelsAdapter, otdelsTable, queryToFillOtdels, dataGridView1);
            departments = WorkerDb.GetDataByIdAndField("DepartmentID", "DepartmentName", "Department", myConnection);
            if (departments.Count != 0)
            {
                departmentsComboBox.Enabled = true;
                deleteOtdelBtn.Enabled = true;
                departmentsComboBox.DataSource = new BindingSource(departments, null);
                departmentsComboBox.DisplayMember = "Value";
                departmentsComboBox.ValueMember = "Key";
            }
            else
            {
                departmentsComboBox.Enabled = false;
                deleteOtdelBtn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameOtdel = otdelNameTextbox.Text;
            if(nameOtdel == "")
            {
                MessageBox.Show("Пожалуйства, введите наименование отдела", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string queryToAddNewOtdel = $"INSERT INTO Department (DepartmentName) VALUES ('{nameOtdel}')";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewOtdel, myConnection);
            MessageBox.Show("Данные о новом отделе добавлены", "Успешно");
        }
    }
}
