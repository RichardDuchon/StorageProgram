﻿using StorageProgram.Implemantations;
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
            this.companyTableAdapter1.Fill(this.storageData.Company);
        }

        public void LoadCompanyToDataGridView()
        {
            companyBindingSource1.DataSource = _unitOfWork.Company.GetAll();
        }

        private void CreateNewCompanyBtn_Click(object sender, EventArgs e)
        {
            CreateNewCompanyFrm createNewCompanyFrm = new CreateNewCompanyFrm(this);
            createNewCompanyFrm.Show();
        }

        private void CompanyDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
