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
    public partial class CompanyFrm : MetroFramework.Forms.MetroForm
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new Database.DatabaseForStorage());

        public CompanyFrm()
        {
            InitializeComponent();
        }

        private void CompanyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wkL3rf6tSaDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.wkL3rf6tSaDataSet.Company);
        }


        public void LoadCompanyToDataGridView()
        {
            companyBindingSource2.DataSource = _unitOfWork.Company.GetAll();
        }

        private void CreateNewCompanyBtn_Click(object sender, EventArgs e)
        {
            CreateNewCompanyFrm createNewCompanyFrm = new CreateNewCompanyFrm(this);
            createNewCompanyFrm.Show();
        }

        private void DeleteCompanyBtn_Click(object sender, EventArgs e)
        {

            DialogResult deleteItemConfirmation = MessageBox.Show("Opravdu chcete tuto společnost vymazat?", "Smazat společnost", MessageBoxButtons.YesNo);

            if (CompanyDgv.SelectedRows.Count == 1)
            {
                if (deleteItemConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in CompanyDgv.SelectedRows)
                    {
                        _unitOfWork.Company.Remove(_unitOfWork.Company.GetById(Convert.ToInt32(row.Cells["companyIdDataGridViewTextBoxColumn"].Value)));
                        CompanyDgv.Rows.RemoveAt(row.Index);
                    }
                    _unitOfWork.Complete();

                }
            }

        }

        private void CompanyDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = this.CompanyDgv.Rows[e.RowIndex];
                viewRow.Cells["companyNameDataGridViewTextBoxColumn"].Value = DeliveryNoteFrm.nameOfCompany;
                //viewRow.Cells["companyIdDataGridViewTextBoxColumn"].Value = DeliveryNoteFrm.idOfCompany;
                this.Close();

            }
        }

        private void CompanyDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = this.CompanyDgv.Rows[e.RowIndex];
                viewRow.Cells["companyNameDataGridViewTextBoxColumn"].Value = DeliveryNoteFrm.nameOfCompany;
                //viewRow.Cells["companyIdDataGridViewTextBoxColumn"].Value = DeliveryNoteFrm.idOfCompany;
            }

            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (CompanyDgv.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in CompanyDgv.SelectedRows)
                {
                    DeliveryNoteFrm.nameOfCompany = row.Cells["companyNameDataGridViewTextBoxColumn"].Value.ToString();
                    DeliveryNoteFrm.idOfCompany = Convert.ToInt32(row.Cells["companyIdDataGridViewTextBoxColumn"].Value);
                }
            }
            this.Close();
        }
    }
}
