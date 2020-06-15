namespace StorageProgram
{
    partial class InvoiceFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InvoiceDgv = new MetroFramework.Controls.MetroGrid();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDesignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inviceNameOfCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateMaturityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateNewInvoiceBtn = new MetroFramework.Controls.MetroButton();
            this.DelteInvoiceBtn = new MetroFramework.Controls.MetroButton();
            this.storageData = new StorageProgram.StorageData();
            this.invoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter1 = new StorageProgram.StorageDataTableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceDgv
            // 
            this.InvoiceDgv.AllowUserToAddRows = false;
            this.InvoiceDgv.AllowUserToResizeRows = false;
            this.InvoiceDgv.AutoGenerateColumns = false;
            this.InvoiceDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvoiceDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoiceDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InvoiceDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIdDataGridViewTextBoxColumn,
            this.invoiceDesignationDataGridViewTextBoxColumn,
            this.inviceNameOfCompanyDataGridViewTextBoxColumn,
            this.invoiceAmountDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.invoiceDateMaturityDataGridViewTextBoxColumn,
            this.invoiceTypeDataGridViewTextBoxColumn});
            this.InvoiceDgv.DataSource = this.invoiceBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceDgv.EnableHeadersVisualStyles = false;
            this.InvoiceDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InvoiceDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvoiceDgv.Location = new System.Drawing.Point(211, 63);
            this.InvoiceDgv.Name = "InvoiceDgv";
            this.InvoiceDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InvoiceDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceDgv.Size = new System.Drawing.Size(638, 407);
            this.InvoiceDgv.TabIndex = 0;
            this.InvoiceDgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceDgv_CellEndEdit);
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // invoiceDesignationDataGridViewTextBoxColumn
            // 
            this.invoiceDesignationDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDesignation";
            this.invoiceDesignationDataGridViewTextBoxColumn.HeaderText = "Označení faktury";
            this.invoiceDesignationDataGridViewTextBoxColumn.Name = "invoiceDesignationDataGridViewTextBoxColumn";
            // 
            // inviceNameOfCompanyDataGridViewTextBoxColumn
            // 
            this.inviceNameOfCompanyDataGridViewTextBoxColumn.DataPropertyName = "InviceNameOfCompany";
            this.inviceNameOfCompanyDataGridViewTextBoxColumn.HeaderText = "Jméno společnosti";
            this.inviceNameOfCompanyDataGridViewTextBoxColumn.Name = "inviceNameOfCompanyDataGridViewTextBoxColumn";
            // 
            // invoiceAmountDataGridViewTextBoxColumn
            // 
            this.invoiceAmountDataGridViewTextBoxColumn.DataPropertyName = "InvoiceAmount";
            this.invoiceAmountDataGridViewTextBoxColumn.HeaderText = "Částka";
            this.invoiceAmountDataGridViewTextBoxColumn.Name = "invoiceAmountDataGridViewTextBoxColumn";
            this.invoiceAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Datum přijetí faktury";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDateMaturityDataGridViewTextBoxColumn
            // 
            this.invoiceDateMaturityDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDateMaturity";
            this.invoiceDateMaturityDataGridViewTextBoxColumn.HeaderText = "Datum splatnosti";
            this.invoiceDateMaturityDataGridViewTextBoxColumn.Name = "invoiceDateMaturityDataGridViewTextBoxColumn";
            this.invoiceDateMaturityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceTypeDataGridViewTextBoxColumn
            // 
            this.invoiceTypeDataGridViewTextBoxColumn.DataPropertyName = "InvoiceType";
            this.invoiceTypeDataGridViewTextBoxColumn.HeaderText = "Vydaná/přijatá";
            this.invoiceTypeDataGridViewTextBoxColumn.Name = "invoiceTypeDataGridViewTextBoxColumn";
            this.invoiceTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            // 
            // zltMgx2tGNDataSet1
            // 
            // 
            // invoiceTableAdapter
            // 
            // 
            // CreateNewInvoiceBtn
            // 
            this.CreateNewInvoiceBtn.Location = new System.Drawing.Point(37, 63);
            this.CreateNewInvoiceBtn.Name = "CreateNewInvoiceBtn";
            this.CreateNewInvoiceBtn.Size = new System.Drawing.Size(168, 48);
            this.CreateNewInvoiceBtn.TabIndex = 1;
            this.CreateNewInvoiceBtn.Text = "Vytvořit novou fakturu";
            this.CreateNewInvoiceBtn.UseSelectable = true;
            this.CreateNewInvoiceBtn.Click += new System.EventHandler(this.CreateNewInvoiceBtn_Click);
            // 
            // DelteInvoiceBtn
            // 
            this.DelteInvoiceBtn.Location = new System.Drawing.Point(23, 447);
            this.DelteInvoiceBtn.Name = "DelteInvoiceBtn";
            this.DelteInvoiceBtn.Size = new System.Drawing.Size(135, 23);
            this.DelteInvoiceBtn.TabIndex = 2;
            this.DelteInvoiceBtn.Text = "Vymazat fakturu";
            this.DelteInvoiceBtn.UseSelectable = true;
            this.DelteInvoiceBtn.Click += new System.EventHandler(this.DelteInvoiceBtn_Click);
            // 
            // storageData
            // 
            this.storageData.DataSetName = "StorageData";
            this.storageData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource1
            // 
            this.invoiceBindingSource1.DataMember = "Invoice";
            this.invoiceBindingSource1.DataSource = this.storageData;
            // 
            // invoiceTableAdapter1
            // 
            this.invoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // InvoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 493);
            this.Controls.Add(this.DelteInvoiceBtn);
            this.Controls.Add(this.CreateNewInvoiceBtn);
            this.Controls.Add(this.InvoiceDgv);
            this.Name = "InvoiceFrm";
            this.Text = "Faktury";
            this.Load += new System.EventHandler(this.InvoiceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid InvoiceDgv;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private MetroFramework.Controls.MetroButton CreateNewInvoiceBtn;
        private MetroFramework.Controls.MetroButton DelteInvoiceBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDesignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inviceNameOfCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateMaturityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTypeDataGridViewTextBoxColumn;
        private StorageData storageData;
        private System.Windows.Forms.BindingSource invoiceBindingSource1;
        private StorageDataTableAdapters.InvoiceTableAdapter invoiceTableAdapter1;
    }
}