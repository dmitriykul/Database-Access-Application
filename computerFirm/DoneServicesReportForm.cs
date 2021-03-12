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
    public partial class DoneServicesReportForm : Form
    {
        public DoneServicesReportForm()
        {
            InitializeComponent();
        }

        private void DoneServicesReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.DataTable1TableAdapter.Fill(this.ComputerFirmDataSet.DataTable1);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
