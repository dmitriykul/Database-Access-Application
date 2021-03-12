using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace computerFirm
{
    class WorkerDb
    {
        public static void UpdateTable(OleDbConnection connection, OleDbDataAdapter adapter, DataTable table, string query, DataGridView view)
        {
            adapter = new OleDbDataAdapter(query, connection);
            table = new DataTable();
            try
            {
            adapter.Fill(table);
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            view.DataSource = table;
        }

        public static void UpdateTable(OleDbConnection connection, OleDbDataAdapter adapter, DataTable table, string query)
        {
            adapter = new OleDbDataAdapter(query, connection);
            table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static int MakeQueryForChangeTable(string query, OleDbConnection connection)
        {
            OleDbCommand commandToDo = new OleDbCommand(query, connection);
            try {
                commandToDo.ExecuteNonQuery();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 1;
            
        }

        public static DataTable MakeReportTable(OleDbConnection connection, OleDbDataAdapter adapter, string query)
        {
            adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
