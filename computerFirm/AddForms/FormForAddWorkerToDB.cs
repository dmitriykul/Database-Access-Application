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
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        Dictionary<int, string> posts;
        Dictionary<int, string> departs;

        public FormForAddWorkerToDB(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта

            departs = WorkerDb.GetDataByIdAndField("DepartmentID", "DepartmentName", "Department", myConnection);
            if(departs.Count != 0)
            {
                departmentComboBox.Enabled = true;
                addWorkerToDbBtn.Enabled = true;
                departmentComboBox.DataSource = new BindingSource(departs, null);
                departmentComboBox.DisplayMember = "Value";
                departmentComboBox.ValueMember = "Key";
            }
            else
            {
                departmentComboBox.Enabled = false;
                addWorkerToDbBtn.Enabled = false;
            }

            posts = WorkerDb.GetDataByIdAndField("PostID", "PostName", "Post", myConnection);
            // int departmentId = ((KeyValuePair<int, string>)departmentComboBox.SelectedItem).Key;
            // posts = WorkerDb.GetDataByTwoDifferentTables("PostID", "PostName", "Post", "Department", departmentId, myConnection);
            if (posts.Count() != 0)
            {
                postComboBox.Enabled = true;
                addWorkerToDbBtn.Enabled = true;
                postComboBox.DataSource = new BindingSource(posts, null);
                postComboBox.DisplayMember = "Value";
                postComboBox.ValueMember = "Key";
            }
            else
            {
                postComboBox.Enabled = false;
                addWorkerToDbBtn.Enabled = false;
            }
        }

        private void addWorkerToDbBtn_Click(object sender, EventArgs e)
        {
            string name = workerName.Text;
            string secondName = workerSecondName.Text;
            string thirdName = workerThirdName.Text;
            string phoneNum = workerPhoneNum.Text;
            int post = -1;
            int otdel = -1;

            if(name == "" || secondName == "" || thirdName == "" || phoneNum == "")
            {
                MessageBox.Show("Не все поля заполнены, пожалуйста, заполните все поля", "Не все поля заполнены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                //post = Convert.ToInt32(workerPost.Text);
                post = ((KeyValuePair<int, string>)postComboBox.SelectedItem).Key;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, неправильно введён номер должности", "Ошибка в номере должности",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //otdel = Convert.ToInt32(workerOtdel.Text);
                otdel = ((KeyValuePair<int, string>)departmentComboBox .SelectedItem).Key;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, возможно неправильно введён номер отдела", "Ошибка в номере отдела",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if(phoneNum.Length != 11 || !WorkerDb.CheckPhoneNumber(phoneNum))
            {
                MessageBox.Show("Неправильно введён номер телефона, номер должен состоять из 11 цифр (89999999999)", "Неправильный номер телефона",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string queryToAddNewWorker = $"INSERT INTO Worker (SecName, WorkerName, ThirdName, Post, Department, PhoneNumber) VALUES ('{name}', '{secondName}', '{thirdName}', {post}, {otdel}, '{phoneNum}')";
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

        private void FormForAddWorkerToDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.computerFirmDataSet.Post);

        }
    }
}
