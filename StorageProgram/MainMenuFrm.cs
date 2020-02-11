using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProgram
{
    public partial class MainMenuFrm : MetroFramework.Forms.MetroForm
    {
        public MainMenuFrm()
        {
            InitializeComponent();
        }

        private void LoginMenuBtn_Click(object sender, EventArgs e)
        {
            LoginMenuFrm loginMenuFrm = new LoginMenuFrm();
            loginMenuFrm.Show();
        }

        private void StorageBtn_Click(object sender, EventArgs e)
        {
            StorageFrm storageFrm = new StorageFrm();
            storageFrm.Show();
        }

        private void DeliveryNoteBtn_Click(object sender, EventArgs e)
        {
            DeliveryNoteFrm deliveryNoteFrm = new DeliveryNoteFrm();
            deliveryNoteFrm.Show();
        }

        private void InvoiceBtn_Click(object sender, EventArgs e)
        {
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            invoiceFrm.Show();
        }

        private void CompanyBtn_Click(object sender, EventArgs e)
        {
            CompanyFrm companyFrm = new CompanyFrm();
            companyFrm.Show();
        }
    }
}
