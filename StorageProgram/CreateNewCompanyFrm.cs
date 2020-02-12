using StorageProgram.Database;
using StorageProgram.Implemantations;
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
    public partial class CreateNewCompanyFrm : MetroFramework.Forms.MetroForm
    {
        private readonly CompanyFrm _companyFrm;
        Company company = new Company();
        UnitOfWork _unitOfWork = new UnitOfWork(new DatabaseStorage());


        public CreateNewCompanyFrm(CompanyFrm companyFrm)
        {
            InitializeComponent();
            _companyFrm = companyFrm;
        }

        private void CreateNewCompanyBtn_Click(object sender, EventArgs e)
        {
            company.CompanyName = NameOfCompanyTxb.Text;
            company.CompanyIdentificationNumber = Convert.ToInt32(IdentificationNumberTxb.Text);
            company.CompanyResidence = CompanyResidenceTxb.Text;
            _unitOfWork.Company.Add(company);
            _unitOfWork.Complete();
            MessageBox.Show("Společnost uložena.");
            _companyFrm.LoadCompanyToDataGridView();
            NameOfCompanyTxb.Clear();
            IdentificationNumberTxb.Clear();
            CompanyResidenceTxb.Clear();
            
        }
    }
}
