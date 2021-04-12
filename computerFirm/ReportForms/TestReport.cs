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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.DataTable4". При необходимости она может быть перемещена или удалена.
            this.DataTable4TableAdapter.Fill(this.ComputerFirmDataSet.DataTable4);
            

            this.reportViewer1.RefreshReport();
        }
    }
}
