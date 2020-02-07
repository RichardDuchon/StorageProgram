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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StorageDgv = new MetroFramework.Controls.MetroGrid();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPurchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zltMgx2tGNDataSet1 = new StorageProgram.zltMgx2tGNDataSet1();
            this.storageTableAdapter = new StorageProgram.zltMgx2tGNDataSet1TableAdapters.StorageTableAdapter();
            this.AddItemBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteItemBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.StorageDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zltMgx2tGNDataSet1)).BeginInit();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StorageDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemPurchasePriceDataGridViewTextBoxColumn});
            this.StorageDgv.DataSource = this.storageBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StorageDgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.StorageDgv.EnableHeadersVisualStyles = false;
            this.StorageDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StorageDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorageDgv.Location = new System.Drawing.Point(300, 72);
            this.StorageDgv.Name = "StorageDgv";
            this.StorageDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StorageDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StorageDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StorageDgv.Size = new System.Drawing.Size(855, 521);
            this.StorageDgv.TabIndex = 0;
            this.StorageDgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageDgv_CellEndEdit);
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Název položky";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            this.itemCountDataGridViewTextBoxColumn.DataPropertyName = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.HeaderText = "Kusů skladem";
            this.itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            this.itemCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Popis položky";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // itemPurchasePriceDataGridViewTextBoxColumn
            // 
            this.itemPurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPurchasePrice";
            this.itemPurchasePriceDataGridViewTextBoxColumn.HeaderText = "Nákupní cena";
            this.itemPurchasePriceDataGridViewTextBoxColumn.Name = "itemPurchasePriceDataGridViewTextBoxColumn";
            this.itemPurchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.zltMgx2tGNDataSet1;
            // 
            // zltMgx2tGNDataSet1
            // 
            this.zltMgx2tGNDataSet1.DataSetName = "zltMgx2tGNDataSet1";
            this.zltMgx2tGNDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.zltMgx2tGNDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid StorageDgv;
        private zltMgx2tGNDataSet1 zltMgx2tGNDataSet1;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private zltMgx2tGNDataSet1TableAdapters.StorageTableAdapter storageTableAdapter;
        private MetroFramework.Controls.MetroButton AddItemBtn;
        private MetroFramework.Controls.MetroButton DeleteItemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPurchasePriceDataGridViewTextBoxColumn;
    }
}