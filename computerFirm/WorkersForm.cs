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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (String.IsNullOrEmpty(txtSearch.Text))
                {
                    this.работникиTableAdapter.Fill(this.computerFirmDataSet.Работники);
                    работникиBindingSource.DataSource = this.computerFirmDataSet.Работники;
                    //dataGridView.DataSource = работникиBindingSource;
                }
                else
                {
                    var query = from o in this.computerFirmDataSet.Работники
                                where o.Имя.Contains(txtSearch.Text) || o.Фамилия.Contains(txtSearch.Text) ||
                                        o.Отчество.Contains(txtSearch.Text) || o.Номер_телефона.Contains(txtSearch.Text)
                                select o;

                    работникиBindingSource.DataSource = query.ToList();
                    //dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    работникиBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtFirstName.Focus();
                this.computerFirmDataSet.Работники.AddРаботникиRow(this.computerFirmDataSet.Работники.NewРаботникиRow());
                работникиBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                работникиBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtFirstName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                работникиBindingSource.EndEdit();
                //работникиTableAdapter.Update(this.computerFirmDataSet.Работники);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                работникиBindingSource.ResetBindings(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            работникиBindingSource.ResetBindings(false);
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.computerFirmDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.computerFirmDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.computerFirmDataSet.Работники);
            работникиBindingSource.DataSource = this.computerFirmDataSet.Работники;
        }
    }
}
