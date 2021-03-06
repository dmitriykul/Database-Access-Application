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
    public partial class ClientsForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        string queryToFillClients = "SELECT " +
            "ClientSecName as [Фамилия], " +
            "ClientName as [Имя], " +
            "ClientThirdName as [Отчество], " +
            "ClientPhoneNumber as [Номер телефона] FROM Client";
        public ClientsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public ClientsForm(List<string> role, string connect)
        {
            InitializeComponent();
            connectString = connect;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            if(!Convert.ToBoolean(role[3]))
            {
                button1.Hide();
            }
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            //this.клиентыTableAdapter1.Fill(this.computerFirmDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet6.Клиенты". При необходимости она может быть перемещена или удалена.
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), queryToFillClients, dataGridView1);
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewClientForm formDb = new AddNewClientForm(connectString);
            formDb.Owner = this;
            formDb.Show();
        }

        private void ClientsForm_Activated(object sender, EventArgs e)
        {
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), queryToFillClients, dataGridView1);
            //this.клиентыTableAdapter1.Fill(this.computerFirmDataSet.Клиенты);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClientsForm formDb = new SearchClientsForm(connectString);
            formDb.Owner = this;
            formDb.Show();
        }
    }
}
