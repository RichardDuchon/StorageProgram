namespace StorageProgram
{
    partial class CompanyFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CompanyDgv = new MetroFramework.Controls.MetroGrid();
            this.companyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIdentificationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyResidenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storageData = new StorageProgram.StorageData();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateNewCompanyMenuBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteCompanyBtn = new MetroFramework.Controls.MetroButton();
            this.companyTableAdapter1 = new StorageProgram.StorageDataTableAdapters.CompanyTableAdapter();
            this.wkL3rf6tSaDataSet = new StorageProgram.wkL3rf6tSaDataSet();
            this.companyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new StorageProgram.wkL3rf6tSaDataSetTableAdapters.CompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wkL3rf6tSaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyDgv
            // 
            this.CompanyDgv.AllowUserToResizeRows = false;
            this.CompanyDgv.AutoGenerateColumns = false;
            this.CompanyDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CompanyDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CompanyDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CompanyDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIdDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.companyIdentificationNumberDataGridViewTextBoxColumn,
            this.companyResidenceDataGridViewTextBoxColumn});
            this.CompanyDgv.DataSource = this.companyBindingSource2;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CompanyDgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.CompanyDgv.EnableHeadersVisualStyles = false;
            this.CompanyDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CompanyDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CompanyDgv.Location = new System.Drawing.Point(184, 63);
            this.CompanyDgv.Name = "CompanyDgv";
            this.CompanyDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CompanyDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CompanyDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompanyDgv.Size = new System.Drawing.Size(593, 364);
            this.CompanyDgv.TabIndex = 0;
            this.CompanyDgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDgv_CellContentDoubleClick);
            this.CompanyDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDgv_CellDoubleClick);
            // 
            // companyIdDataGridViewTextBoxColumn
            // 
            this.companyIdDataGridViewTextBoxColumn.DataPropertyName = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.HeaderText = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.Name = "companyIdDataGridViewTextBoxColumn";
            this.companyIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Název společnosti";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 225;
            // 
            // companyIdentificationNumberDataGridViewTextBoxColumn
            // 
            this.companyIdentificationNumberDataGridViewTextBoxColumn.DataPropertyName = "CompanyIdentificationNumber";
            this.companyIdentificationNumberDataGridViewTextBoxColumn.HeaderText = "IČO";
            this.companyIdentificationNumberDataGridViewTextBoxColumn.Name = "companyIdentificationNumberDataGridViewTextBoxColumn";
            // 
            // companyResidenceDataGridViewTextBoxColumn
            // 
            this.companyResidenceDataGridViewTextBoxColumn.DataPropertyName = "CompanyResidence";
            this.companyResidenceDataGridViewTextBoxColumn.HeaderText = "Sídlo společnosti";
            this.companyResidenceDataGridViewTextBoxColumn.Name = "companyResidenceDataGridViewTextBoxColumn";
            this.companyResidenceDataGridViewTextBoxColumn.Width = 225;
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            this.companyBindingSource1.DataSource = this.storageData;
            // 
            // storageData
            // 
            this.storageData.DataSetName = "StorageData";
            this.storageData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            // 
            // CreateNewCompanyMenuBtn
            // 
            this.CreateNewCompanyMenuBtn.Location = new System.Drawing.Point(10, 95);
            this.CreateNewCompanyMenuBtn.Name = "CreateNewCompanyMenuBtn";
            this.CreateNewCompanyMenuBtn.Size = new System.Drawing.Size(168, 48);
            this.CreateNewCompanyMenuBtn.TabIndex = 1;
            this.CreateNewCompanyMenuBtn.Text = "Přidat novou společnost";
            this.CreateNewCompanyMenuBtn.UseSelectable = true;
            this.CreateNewCompanyMenuBtn.Click += new System.EventHandler(this.CreateNewCompanyBtn_Click);
            // 
            // DeleteCompanyBtn
            // 
            this.DeleteCompanyBtn.Location = new System.Drawing.Point(23, 404);
            this.DeleteCompanyBtn.Name = "DeleteCompanyBtn";
            this.DeleteCompanyBtn.Size = new System.Drawing.Size(109, 23);
            this.DeleteCompanyBtn.TabIndex = 2;
            this.DeleteCompanyBtn.Text = "Smazat společnost";
            this.DeleteCompanyBtn.UseSelectable = true;
            this.DeleteCompanyBtn.Click += new System.EventHandler(this.DeleteCompanyBtn_Click);
            // 
            // companyTableAdapter1
            // 
            this.companyTableAdapter1.ClearBeforeFill = true;
            // 
            // wkL3rf6tSaDataSet
            // 
            this.wkL3rf6tSaDataSet.DataSetName = "wkL3rf6tSaDataSet";
            this.wkL3rf6tSaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource2
            // 
            this.companyBindingSource2.DataMember = "Company";
            this.companyBindingSource2.DataSource = this.wkL3rf6tSaDataSet;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteCompanyBtn);
            this.Controls.Add(this.CreateNewCompanyMenuBtn);
            this.Controls.Add(this.CompanyDgv);
            this.Name = "CompanyFrm";
            this.Text = "Společnosti";
            this.Load += new System.EventHandler(this.CompanyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wkL3rf6tSaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid CompanyDgv;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdentificationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyResidenceDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton CreateNewCompanyMenuBtn;
        private MetroFramework.Controls.MetroButton DeleteCompanyBtn;
        private StorageData storageData;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private StorageDataTableAdapters.CompanyTableAdapter companyTableAdapter1;
        private wkL3rf6tSaDataSet wkL3rf6tSaDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource2;
        private wkL3rf6tSaDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
    }
}