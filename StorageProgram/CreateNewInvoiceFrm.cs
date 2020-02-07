using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageProgram.Database;
using StorageProgram.Implemantations;

namespace StorageProgram
{
    public partial class CreateNewInvoiceFrm : MetroFramework.Forms.MetroForm
    {
        private readonly InvoiceFrm _invoiceFrm;
        Invoice invoice = new Invoice();
        UnitOfWork _unitOfWork = new UnitOfWork(new DatabaseStorage());


        public CreateNewInvoiceFrm(InvoiceFrm invoiceFrm)
        {
            InitializeComponent();
            _invoiceFrm = invoiceFrm;
        }

        private void CreateNewInvoiceForCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateNewInvoice("Přijatá faktura.");

        }

        private void CreateNewInvoiceForOurCompanyBtn_Click(object sender, EventArgs e)
        {
            CreateNewInvoice("Vystavená faktura.");
        }

        public void CreateNewInvoice(string typeOfInvoice)
        {
            DateTime dateValueCheck;

            invoice.InvoiceDesignation = InvoiceDesignationTxb.Text.Trim();
            invoice.InviceNameOfCompany = InvoiceNameOfCompanyTxb.Text.Trim();
            invoice.InvoiceType = typeOfInvoice;


            if (string.IsNullOrEmpty(invoice.InvoiceDesignation))
                MessageBox.Show("Vyplňte označení faktury.");
            else if (string.IsNullOrEmpty(invoice.InviceNameOfCompany))
                MessageBox.Show("Vyplňte název společnosti.");
            else if (DateTime.TryParse(InvoiceDateTxb.Text.Trim(), out dateValueCheck) == false && DateTime.TryParse(InvoiceDateMaturityTxb.Text.Trim(), out dateValueCheck) == false)
                MessageBox.Show("Špatně zadaný datum.");
            else
            {
                invoice.InvoiceDate = Convert.ToDateTime(InvoiceDateTxb.Text.Trim());
                invoice.InvoiceDateMaturity = Convert.ToDateTime(InvoiceDateMaturityTxb.Text.Trim());

                MessageBox.Show("Faktra uložena.");
                _unitOfWork.Invoice.Add(invoice);
                _unitOfWork.Complete();
                _invoiceFrm.RefreshInvoice();
            }


        }
    }
}
