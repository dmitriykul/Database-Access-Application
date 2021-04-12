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
    public partial class SearchDoneOrdersBetweenDateForm : Form
    {
        public static string connectString;
        private OleDbConnection myConnection;   // переменная для соединения
        OleDbDataAdapter resultsSearch;
        DataTable dataTableWithSearchResults = new DataTable();

        public SearchDoneOrdersBetweenDateForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        public SearchDoneOrdersBetweenDateForm(string connection)
        {
            InitializeComponent();
            connectString = connection;
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            resultsSearch = new OleDbDataAdapter(makeQuery(), myConnection);
            dataTableWithSearchResults = new DataTable();
            resultsSearch.Fill(dataTableWithSearchResults);
            dataGridView1.DataSource = dataTableWithSearchResults;
        }

        public string makeQuery()
        {
            string start = dateTimePicker1.Value.ToShortDateString().Replace('.', '/');
            string end = dateTimePicker2.Value.ToShortDateString().Replace('.', '/');
            string query = $"SELECT [DoneOrderClient], [DoneOrderProduct], [DoneOrderWorker], [DoneOrderDepartment], [DoneOrderDate] FROM [DoneOrder] WHERE [DoneOrderDate] BETWEEN #{start}# AND #{end}#";
            return query;
        }

        private void SearchDoneOrdersBetweenDateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            resultsSearch = new OleDbDataAdapter(makeQuery(), myConnection);
            dataTableWithSearchResults = new DataTable();
            resultsSearch.Fill(dataTableWithSearchResults);
            dataGridView1.DataSource = dataTableWithSearchResults;
        }
    }
}
