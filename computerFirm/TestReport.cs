using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computerFirm
{
    public partial class TestReport : Form
    {
        public TestReport()
        {
            InitializeComponent();
        }

        private void TestReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.DataTable2TableAdapter.Fill(this.ComputerFirmDataSet.DataTable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.DataTable1TableAdapter.Fill(this.ComputerFirmDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.Работники". При необходимости она может быть перемещена или удалена.
            this.РаботникиTableAdapter.Fill(this.ComputerFirmDataSet.Работники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.Выполненные_заказы". При необходимости она может быть перемещена или удалена.
            this.Выполненные_заказыTableAdapter.Fill(this.ComputerFirmDataSet.Выполненные_заказы);

            this.reportViewer1.RefreshReport();
        }
    }
}
