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
    public partial class SearchInDoneOrdersForm : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ComputerFirm.mdb;Persist Security Info=True";
        private OleDbConnection myConnection;   // переменная для соединения
        public SearchInDoneOrdersForm()
        {
            InitializeComponent();
        }

        private void searchInDoneOrders_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);  // Объект, который будет отвечать за соединение с базой данных
            myConnection.Open();    // база данных открыта
            WorkerDb.UpdateTable(myConnection, new OleDbDataAdapter(), new DataTable(), makeQuery(), dataGridView1);
            myConnection.Close();
        }

        public string makeQuery()
        {
            string query = "SELECT Клиенты.Фамилия_клиента, Продукция.Продукт, Работники.Фамилия, Отделы.Наименование, [Выполненные заказы].Дата " +
                "FROM Отделы INNER JOIN(Работники INNER JOIN (Продукция INNER JOIN (Клиенты INNER JOIN [Выполненные заказы] " +
                "ON Клиенты.clientID = [Выполненные заказы].Клиент) " +
                "ON Продукция.productID = [Выполненные заказы].Продукт) " +
                "ON Работники.workerID = [Выполненные заказы].Работник) " +
                "ON(Отделы.departmentID = Работники.Отдел) AND(Отделы.departmentID = [Выполненные заказы].Отдел) " +
                "WHERE ";
            List<int> checks = countOfChecks();
            checks.Reverse();
            if (checks[0] == 1 && hasNoChecked(checks, 0))
            {
                query += $"(Клиенты.Фамилия_клиента LIKE '{clientIdForSearch.Text}%')";
                return query;
            }
            else if (checks[0] == 1 && !hasNoChecked(checks, 0))
                query += $"(Клиенты.Фамилия_клиента LIKE '{clientIdForSearch.Text}%') AND ";

            if (checks[1] == 1)
            {
                query += $"(Работники.Фамилия LIKE '{workerIdForSearch.Text}%')";
                return query;
            }
            return "SELECT Клиенты.Фамилия_клиента, Продукция.Продукт, Работники.Фамилия, Отделы.Наименование, [Выполненные заказы].Дата " +
                "FROM Отделы INNER JOIN(Работники INNER JOIN (Продукция INNER JOIN (Клиенты INNER JOIN [Выполненные заказы] " +
                "ON Клиенты.clientID = [Выполненные заказы].Клиент) " +
                "ON Продукция.productID = [Выполненные заказы].Продукт) " +
                "ON Работники.workerID = [Выполненные заказы].Работник) " +
                "ON(Отделы.departmentID = Работники.Отдел) AND(Отделы.departmentID = [Выполненные заказы].Отдел)";
        }

        public bool hasNoChecked(List<int> checks, int pos)
        {
            for (int p = pos + 1; p < checks.Count; p++)
                if (checks[p] == 1)
                    return false;
            return true;
        }

        public List<int> countOfChecks()
        {
            List<int> result = new List<int>();
            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                    result.Add(1);
                else
                    result.Add(0);
            }
            return result;
        }
    }
}
