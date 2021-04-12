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
    public partial class AddNewServiceForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        private Dictionary<int, string> departments;

        public AddNewServiceForm(string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            departments = WorkerDb.GetDataByIdAndField("DepartmentID", "DepartmentName", "Department", myConnection);
            departmentComboBox.DataSource = new BindingSource(departments, null);
            departmentComboBox.DisplayMember = "Value";
            departmentComboBox.ValueMember = "Key";
        }

        private void addNewServiceBtn_Click(object sender, EventArgs e)
        {
            string serviceName = serviceNameTextBox.Text;
            string serviceCost = serviceCostTextBox.Text;
            int serviceOtdelId = -1;

            if(serviceName == "" || serviceCost == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Не все поля заполнены", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                //serviceOtdelId = Convert.ToInt32(serviceOtdelTextBox.Text);
                serviceOtdelId = ((KeyValuePair<int, string>)departmentComboBox.SelectedItem).Key;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при введении ID отдела, выполняющего услугу, повторите попытку\n{ex.Message}", "Ошибка в ID отдела",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string queryToAddNewService = $"INSERT INTO Service (ServiceName, ServiceCost, ServiceDepartment) VALUES ('{serviceName}', '{serviceCost}', {serviceOtdelId})";
            WorkerDb.MakeQueryForChangeTable(queryToAddNewService, myConnection);
            MessageBox.Show("Данные о новой услуге добавлены");
        }

        private void AddNewServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
