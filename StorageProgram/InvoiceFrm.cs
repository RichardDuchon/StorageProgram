using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using StorageProgram.Implemantations;

namespace StorageProgram
{
    public partial class InvoiceFrm : MetroFramework.Forms.MetroForm
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new Database.DatabaseStorage());

        public InvoiceFrm()
        {
            InitializeComponent();
        }

        private void InvoiceFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zltMgx2tGNDataSet1.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.zltMgx2tGNDataSet1.Invoice);

        }

        private void CreateNewInvoiceBtn_Click(object sender, EventArgs e)
        {
            CreateNewInvoiceFrm createNewInvoiceFrm = new CreateNewInvoiceFrm(this);
            createNewInvoiceFrm.Show();
        }
        public void RefreshInvoice()
        {
            invoiceBindingSource.DataSource = _unitOfWork.Invoice.GetAll();
        }

        private void DelteInvoiceBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteItemConfirmation = MessageBox.Show("Opravdu chcete tyto faktury vymazat?", "Smazat faktury", MessageBoxButtons.YesNo);

            if (InvoiceDgv.SelectedRows.Count > 0)
            {
                if (deleteItemConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in InvoiceDgv.SelectedRows)
                    {
                        _unitOfWork.Invoice.Remove(_unitOfWork.Invoice.GetById(Convert.ToInt32(row.Cells["invoiceIdDataGridViewTextBoxColumn"].Value)));
                        InvoiceDgv.Rows.RemoveAt(row.Index);
                    }
                    _unitOfWork.Complete();

                }
            }
        }

        private void InvoiceDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editItem = _unitOfWork.Invoice.GetById(Convert.ToInt32(InvoiceDgv.CurrentRow.Cells["invoiceIdDataGridViewTextBoxColumn"].Value));

            editItem.InvoiceDesignation = InvoiceDgv.CurrentRow.Cells["invoiceDesignationDataGridViewTextBoxColumn"].Value.ToString();
            editItem.InviceNameOfCompany = InvoiceDgv.CurrentRow.Cells["inviceNameOfCompanyDataGridViewTextBoxColumn"].Value.ToString();
            _unitOfWork.Complete();

        }
    }
}
