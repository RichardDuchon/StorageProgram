namespace StorageProgram
{
    partial class StorageFrm
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
            this.StorageDgv = new MetroFramework.Controls.MetroGrid();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddItemBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteItemBtn = new MetroFramework.Controls.MetroButton();
            this.storageData = new StorageProgram.StorageData();
            this.storageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storageTableAdapter1 = new StorageProgram.StorageDataTableAdapters.StorageTableAdapter();
            this.itemPurchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StorageDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageDgv
            // 
            this.StorageDgv.AllowUserToAddRows = false;
            this.StorageDgv.AllowUserToResizeRows = false;
            this.StorageDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StorageDgv.AutoGenerateColumns = false;
            this.StorageDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorageDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorageDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StorageDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StorageDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemPurchasePriceDataGridViewTextBoxColumn});
            this.StorageDgv.DataSource = this.storageBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StorageDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.StorageDgv.EnableHeadersVisualStyles = false;
            this.StorageDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StorageDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorageDgv.Location = new System.Drawing.Point(300, 72);
            this.StorageDgv.Name = "StorageDgv";
            this.StorageDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StorageDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StorageDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StorageDgv.Size = new System.Drawing.Size(855, 521);
            this.StorageDgv.TabIndex = 0;
            this.StorageDgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageDgv_CellEndEdit);
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            // 
            // zltMgx2tGNDataSet1
            // 
            // 
            // storageTableAdapter
            // 
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemBtn.Location = new System.Drawing.Point(79, 72);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(160, 60);
            this.AddItemBtn.TabIndex = 1;
            this.AddItemBtn.Text = "Přidat novou položku";
            this.AddItemBtn.UseSelectable = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteItemBtn.Location = new System.Drawing.Point(23, 570);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(151, 23);
            this.DeleteItemBtn.TabIndex = 3;
            this.DeleteItemBtn.Text = "Smazat položku";
            this.DeleteItemBtn.UseSelectable = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // storageData
            // 
            this.storageData.DataSetName = "StorageData";
            this.storageData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageDataBindingSource
            // 
            this.storageDataBindingSource.DataSource = this.storageData;
            this.storageDataBindingSource.Position = 0;
            // 
            // storageBindingSource1
            // 
            this.storageBindingSource1.DataMember = "Storage";
            this.storageBindingSource1.DataSource = this.storageDataBindingSource;
            // 
            // storageTableAdapter1
            // 
            this.storageTableAdapter1.ClearBeforeFill = true;
            // 
            // itemPurchasePriceDataGridViewTextBoxColumn
            // 
            this.itemPurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPurchasePrice";
            this.itemPurchasePriceDataGridViewTextBoxColumn.HeaderText = "Nákupní cena";
            this.itemPurchasePriceDataGridViewTextBoxColumn.Name = "itemPurchasePriceDataGridViewTextBoxColumn";
            this.itemPurchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Popis položky";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            this.itemCountDataGridViewTextBoxColumn.DataPropertyName = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.HeaderText = "Kusů skladem";
            this.itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            this.itemCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Název položky";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // StorageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 616);
            this.Controls.Add(this.DeleteItemBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.StorageDgv);
            this.Name = "StorageFrm";
            this.Text = "Sklad";
            this.Load += new System.EventHandler(this.StorageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid StorageDgv;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private MetroFramework.Controls.MetroButton AddItemBtn;
        private MetroFramework.Controls.MetroButton DeleteItemBtn;
        private System.Windows.Forms.BindingSource storageDataBindingSource;
        private StorageData storageData;
        private System.Windows.Forms.BindingSource storageBindingSource1;
        private StorageDataTableAdapters.StorageTableAdapter storageTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPurchasePriceDataGridViewTextBoxColumn;
    }
}