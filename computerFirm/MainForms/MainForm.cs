using computerFirm.MainForms;
using computerFirm.ReportForms;
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
    public partial class MainForm : Form
    {
        Form1 workers;                          // работники
        PositionsForm positionsForm;            // должности
        ClientsForm clientsForm;                // клиенты
        DoneOrdersForm doneOrdersForm;          // выполненные заказы
        ListOfOrdersForm listOfOrdersForm;      // список услуг
        OtdelsForm otdelsForm;                  // отделы
        ProductsForm productsForm;              // продукция
        ProvidersForm providersForm;            // поставщики
        DoneServicesForm doneServicesForm;      // выполненные услуги
        ManageUsersForm manageUsersForm;        // редактирование пользователей
        LoginForm loginForm;                    // форма для входа
        List<string> roleAttributes;
        string connectionString;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(List<string> role, string connection)
        {
            InitializeComponent();
            if(role[0] != "administrator")
            {
                menuStrip1.Hide();
            }
            roleAttributes = role;
            connectionString = connection;
        }

        private void openWorkersBtn_Click(object sender, EventArgs e)
        {
            if(workers == null || workers.IsDisposed)
            {
            workers = new Form1(roleAttributes, connectionString);
            workers.Owner = this;
            workers.Show();
            }
        }

        private void closeAllBtn_Click(object sender, EventArgs e)
        {
            if(workers != null) workers.Dispose();
            if (positionsForm != null) positionsForm.Close();
            if (clientsForm != null) clientsForm.Close();
            if (doneOrdersForm != null) doneOrdersForm.Close();
            if (listOfOrdersForm != null) listOfOrdersForm.Close();
            if (otdelsForm != null) otdelsForm.Close();
            if (productsForm != null) productsForm.Close();
            if (providersForm != null) providersForm.Close();
            if (doneServicesForm != null) doneServicesForm.Close();              
        }

        private void openPositionsBtn_Click(object sender, EventArgs e)
        {
            if (positionsForm == null || positionsForm.IsDisposed)
            {
                positionsForm = new PositionsForm(roleAttributes, connectionString);
                positionsForm.Owner = this;
                positionsForm.Show();
            }
        }

        private void openDoneOrdersBtn_Click(object sender, EventArgs e)
        {
            if (doneOrdersForm == null || doneOrdersForm.IsDisposed)
            {
                doneOrdersForm = new DoneOrdersForm(connectionString);
                doneOrdersForm.Owner = this;
                doneOrdersForm.Show();
            }
        }

        private void openDoneServicesBtn_Click(object sender, EventArgs e)
        {
            if (doneServicesForm == null || doneServicesForm.IsDisposed)
            {
                doneServicesForm = new DoneServicesForm(connectionString);
                doneServicesForm.Owner = this;
                doneServicesForm.Show();
            }
        }

        private void openListOfOrdersBtn_Click(object sender, EventArgs e)
        {
            if (listOfOrdersForm == null || listOfOrdersForm.IsDisposed)
            {
                listOfOrdersForm = new ListOfOrdersForm(roleAttributes, connectionString);
                listOfOrdersForm.Owner = this;
                listOfOrdersForm.Show();
            }
        }

        private void openProvidersBtn_Click(object sender, EventArgs e)
        {
            if (providersForm == null || providersForm.IsDisposed)
            {
                providersForm = new ProvidersForm(connectionString);
                providersForm.Owner = this;
                providersForm.Show();
            }
        }

        private void openProductsBtn_Click(object sender, EventArgs e)
        {
            if (productsForm == null || productsForm.IsDisposed)
            {
                productsForm = new ProductsForm(roleAttributes, connectionString);
                productsForm.Owner = this;
                productsForm.Show();
            }
        }

        private void openClientsbtn_Click(object sender, EventArgs e)
        {
            if (clientsForm == null || clientsForm.IsDisposed)
            {
                clientsForm = new ClientsForm(roleAttributes, connectionString);
                clientsForm.Owner = this;
                clientsForm.Show();
            }
        }

        private void openOtdelsBtn_Click(object sender, EventArgs e)
        {
            if (otdelsForm == null || otdelsForm.IsDisposed)
            {
                otdelsForm = new OtdelsForm(roleAttributes, connectionString);
                otdelsForm.Owner = this;
                otdelsForm.Show();
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            //this.TopLevel = true;
        }

        private void редактироватьПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageUsersForm = new ManageUsersForm(connectionString);
            manageUsersForm.Owner = this;
            manageUsersForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (workers != null) workers.Dispose();
            if (positionsForm != null) positionsForm.Close();
            if (clientsForm != null) clientsForm.Close();
            if (doneOrdersForm != null) doneOrdersForm.Close();
            if (listOfOrdersForm != null) listOfOrdersForm.Close();
            if (otdelsForm != null) otdelsForm.Close();
            if (productsForm != null) productsForm.Close();
            if (providersForm != null) providersForm.Close();
            if (doneServicesForm != null) doneServicesForm.Close();
            loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
            
        }
    }
}
