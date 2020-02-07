namespace StorageProgram
{
    partial class DeliveryNoteFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StorageInDeliveryDgv = new MetroFramework.Controls.MetroGrid();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zltMgx2tGNDataSet1 = new StorageProgram.zltMgx2tGNDataSet1();
            this.DeliveryNoteDgv = new MetroFramework.Controls.MetroGrid();
            this.deliveryNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryStorageDgv = new MetroFramework.Controls.MetroGrid();
            this.itemsInStockDeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateDeliveryNoteBtn = new MetroFramework.Controls.MetroButton();
            this.CreateOrderNoteBtn = new MetroFramework.Controls.MetroButton();
            this.AddItemToDeliveryBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteDeliveryNoteBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteItemFromDeliveryBtn = new MetroFramework.Controls.MetroButton();
            this.AddItemsInOrderToStorageBtn = new MetroFramework.Controls.MetroButton();
            this.storageTableAdapter = new StorageProgram.zltMgx2tGNDataSet1TableAdapters.StorageTableAdapter();
            this.deliveryNoteTableAdapter = new StorageProgram.zltMgx2tGNDataSet1TableAdapters.DeliveryNoteTableAdapter();
            this.itemsInStockDeliveryTableAdapter = new StorageProgram.zltMgx2tGNDataSet1TableAdapters.ItemsInStockDeliveryTableAdapter();
            this.ItemsInStockLbl = new MetroFramework.Controls.MetroLabel();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPurchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsInNoteLbl = new MetroFramework.Controls.MetroLabel();
            this.OrderOrDeliveryLbl = new MetroFramework.Controls.MetroLabel();
            this.itemInDeliveryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliverySellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteIndicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StorageInDeliveryDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zltMgx2tGNDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryNoteDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryStorageDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInStockDeliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageInDeliveryDgv
            // 
            this.StorageInDeliveryDgv.AllowUserToAddRows = false;
            this.StorageInDeliveryDgv.AllowUserToResizeRows = false;
            this.StorageInDeliveryDgv.AutoGenerateColumns = false;
            this.StorageInDeliveryDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorageInDeliveryDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorageInDeliveryDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StorageInDeliveryDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageInDeliveryDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.StorageInDeliveryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageInDeliveryDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemPurchasePriceDataGridViewTextBoxColumn});
            this.StorageInDeliveryDgv.DataSource = this.storageBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StorageInDeliveryDgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.StorageInDeliveryDgv.EnableHeadersVisualStyles = false;
            this.StorageInDeliveryDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StorageInDeliveryDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorageInDeliveryDgv.Location = new System.Drawing.Point(23, 63);
            this.StorageInDeliveryDgv.Name = "StorageInDeliveryDgv";
            this.StorageInDeliveryDgv.ReadOnly = true;
            this.StorageInDeliveryDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageInDeliveryDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.StorageInDeliveryDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StorageInDeliveryDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StorageInDeliveryDgv.Size = new System.Drawing.Size(544, 746);
            this.StorageInDeliveryDgv.TabIndex = 0;
            this.StorageInDeliveryDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageInDeliveryDgv_CellClick);
            this.StorageInDeliveryDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageInDeliveryDgv_CellContentClick);
            this.StorageInDeliveryDgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageInDeliveryDgv_CellContentDoubleClick);
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
            // DeliveryNoteDgv
            // 
            this.DeliveryNoteDgv.AllowUserToAddRows = false;
            this.DeliveryNoteDgv.AllowUserToResizeRows = false;
            this.DeliveryNoteDgv.AutoGenerateColumns = false;
            this.DeliveryNoteDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeliveryNoteDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeliveryNoteDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DeliveryNoteDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryNoteDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DeliveryNoteDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryNoteDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryNoteIdDataGridViewTextBoxColumn,
            this.deliveryNoteIndicationDataGridViewTextBoxColumn,
            this.deliveryNoteCountDataGridViewTextBoxColumn,
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn});
            this.DeliveryNoteDgv.DataSource = this.deliveryNoteBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryNoteDgv.DefaultCellStyle = dataGridViewCellStyle14;
            this.DeliveryNoteDgv.EnableHeadersVisualStyles = false;
            this.DeliveryNoteDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DeliveryNoteDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeliveryNoteDgv.Location = new System.Drawing.Point(829, 63);
            this.DeliveryNoteDgv.Name = "DeliveryNoteDgv";
            this.DeliveryNoteDgv.ReadOnly = true;
            this.DeliveryNoteDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryNoteDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DeliveryNoteDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DeliveryNoteDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryNoteDgv.Size = new System.Drawing.Size(668, 277);
            this.DeliveryNoteDgv.TabIndex = 1;
            this.DeliveryNoteDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryNoteDgv_CellClick);
            this.DeliveryNoteDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryNoteDgv_CellContentClick);
            this.DeliveryNoteDgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryNoteDgv_CellContentDoubleClick);
            // 
            // deliveryNoteBindingSource
            // 
            this.deliveryNoteBindingSource.DataMember = "DeliveryNote";
            this.deliveryNoteBindingSource.DataSource = this.zltMgx2tGNDataSet1;
            // 
            // DeliveryStorageDgv
            // 
            this.DeliveryStorageDgv.AllowUserToAddRows = false;
            this.DeliveryStorageDgv.AllowUserToResizeRows = false;
            this.DeliveryStorageDgv.AutoGenerateColumns = false;
            this.DeliveryStorageDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeliveryStorageDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeliveryStorageDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DeliveryStorageDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryStorageDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DeliveryStorageDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryStorageDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemInDeliveryIdDataGridViewTextBoxColumn,
            this.itemInDeliveryNameDataGridViewTextBoxColumn,
            this.itemInDeliveryCountDataGridViewTextBoxColumn,
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn,
            this.itemInDeliverySellPriceDataGridViewTextBoxColumn,
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn,
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn,
            this.itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn});
            this.DeliveryStorageDgv.DataSource = this.itemsInStockDeliveryBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryStorageDgv.DefaultCellStyle = dataGridViewCellStyle17;
            this.DeliveryStorageDgv.EnableHeadersVisualStyles = false;
            this.DeliveryStorageDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DeliveryStorageDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeliveryStorageDgv.Location = new System.Drawing.Point(829, 372);
            this.DeliveryStorageDgv.Name = "DeliveryStorageDgv";
            this.DeliveryStorageDgv.ReadOnly = true;
            this.DeliveryStorageDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryStorageDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DeliveryStorageDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DeliveryStorageDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryStorageDgv.Size = new System.Drawing.Size(668, 418);
            this.DeliveryStorageDgv.TabIndex = 2;
            // 
            // itemsInStockDeliveryBindingSource
            // 
            this.itemsInStockDeliveryBindingSource.DataMember = "ItemsInStockDelivery";
            this.itemsInStockDeliveryBindingSource.DataSource = this.zltMgx2tGNDataSet1;
            // 
            // CreateDeliveryNoteBtn
            // 
            this.CreateDeliveryNoteBtn.Location = new System.Drawing.Point(655, 63);
            this.CreateDeliveryNoteBtn.Name = "CreateDeliveryNoteBtn";
            this.CreateDeliveryNoteBtn.Size = new System.Drawing.Size(168, 48);
            this.CreateDeliveryNoteBtn.TabIndex = 3;
            this.CreateDeliveryNoteBtn.Text = "Vytvořit dodávku";
            this.CreateDeliveryNoteBtn.UseSelectable = true;
            this.CreateDeliveryNoteBtn.Click += new System.EventHandler(this.CreateDeliveryNoteBtn_Click);
            // 
            // CreateOrderNoteBtn
            // 
            this.CreateOrderNoteBtn.Location = new System.Drawing.Point(655, 117);
            this.CreateOrderNoteBtn.Name = "CreateOrderNoteBtn";
            this.CreateOrderNoteBtn.Size = new System.Drawing.Size(168, 48);
            this.CreateOrderNoteBtn.TabIndex = 4;
            this.CreateOrderNoteBtn.Text = "Vytvořit objednávku";
            this.CreateOrderNoteBtn.UseSelectable = true;
            this.CreateOrderNoteBtn.Click += new System.EventHandler(this.CreateOrderNoteBtn_Click);
            // 
            // AddItemToDeliveryBtn
            // 
            this.AddItemToDeliveryBtn.Location = new System.Drawing.Point(573, 336);
            this.AddItemToDeliveryBtn.Name = "AddItemToDeliveryBtn";
            this.AddItemToDeliveryBtn.Size = new System.Drawing.Size(138, 86);
            this.AddItemToDeliveryBtn.TabIndex = 5;
            this.AddItemToDeliveryBtn.Text = "Přidat položku do\r\ndodacího listu";
            this.AddItemToDeliveryBtn.UseSelectable = true;
            this.AddItemToDeliveryBtn.Click += new System.EventHandler(this.AddItemToDeliveryBtn_Click);
            // 
            // DeleteDeliveryNoteBtn
            // 
            this.DeleteDeliveryNoteBtn.Location = new System.Drawing.Point(1197, 34);
            this.DeleteDeliveryNoteBtn.Name = "DeleteDeliveryNoteBtn";
            this.DeleteDeliveryNoteBtn.Size = new System.Drawing.Size(124, 23);
            this.DeleteDeliveryNoteBtn.TabIndex = 6;
            this.DeleteDeliveryNoteBtn.Text = "Smazat dodací list";
            this.DeleteDeliveryNoteBtn.UseSelectable = true;
            this.DeleteDeliveryNoteBtn.Click += new System.EventHandler(this.DeleteDeliveryNoteBtn_Click);
            // 
            // DeleteItemFromDeliveryBtn
            // 
            this.DeleteItemFromDeliveryBtn.Location = new System.Drawing.Point(829, 796);
            this.DeleteItemFromDeliveryBtn.Name = "DeleteItemFromDeliveryBtn";
            this.DeleteItemFromDeliveryBtn.Size = new System.Drawing.Size(168, 48);
            this.DeleteItemFromDeliveryBtn.TabIndex = 7;
            this.DeleteItemFromDeliveryBtn.Text = "Smazat položku ";
            this.DeleteItemFromDeliveryBtn.UseSelectable = true;
            this.DeleteItemFromDeliveryBtn.Click += new System.EventHandler(this.DeleteItemFromDeliveryBtn_Click);
            // 
            // AddItemsInOrderToStorageBtn
            // 
            this.AddItemsInOrderToStorageBtn.Location = new System.Drawing.Point(1287, 796);
            this.AddItemsInOrderToStorageBtn.Name = "AddItemsInOrderToStorageBtn";
            this.AddItemsInOrderToStorageBtn.Size = new System.Drawing.Size(168, 48);
            this.AddItemsInOrderToStorageBtn.TabIndex = 8;
            this.AddItemsInOrderToStorageBtn.Text = "Naskladnit zboží z objednávky";
            this.AddItemsInOrderToStorageBtn.UseSelectable = true;
            this.AddItemsInOrderToStorageBtn.Click += new System.EventHandler(this.AddItemsInOrderToStorageBtn_Click);
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryNoteTableAdapter
            // 
            this.deliveryNoteTableAdapter.ClearBeforeFill = true;
            // 
            // itemsInStockDeliveryTableAdapter
            // 
            this.itemsInStockDeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // ItemsInStockLbl
            // 
            this.ItemsInStockLbl.AutoSize = true;
            this.ItemsInStockLbl.Location = new System.Drawing.Point(473, 41);
            this.ItemsInStockLbl.Name = "ItemsInStockLbl";
            this.ItemsInStockLbl.Size = new System.Drawing.Size(94, 19);
            this.ItemsInStockLbl.TabIndex = 9;
            this.ItemsInStockLbl.Text = "Zboží skladem";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Název položky";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            this.itemCountDataGridViewTextBoxColumn.DataPropertyName = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.HeaderText = "Kusů skladem";
            this.itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            this.itemCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Popis položky";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemPurchasePriceDataGridViewTextBoxColumn
            // 
            this.itemPurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPurchasePrice";
            this.itemPurchasePriceDataGridViewTextBoxColumn.HeaderText = "Nákupní cena";
            this.itemPurchasePriceDataGridViewTextBoxColumn.Name = "itemPurchasePriceDataGridViewTextBoxColumn";
            this.itemPurchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ItemsInNoteLbl
            // 
            this.ItemsInNoteLbl.AutoSize = true;
            this.ItemsInNoteLbl.Location = new System.Drawing.Point(1396, 350);
            this.ItemsInNoteLbl.Name = "ItemsInNoteLbl";
            this.ItemsInNoteLbl.Size = new System.Drawing.Size(89, 19);
            this.ItemsInNoteLbl.TabIndex = 10;
            this.ItemsInNoteLbl.Text = "Položky v listu";
            // 
            // OrderOrDeliveryLbl
            // 
            this.OrderOrDeliveryLbl.AutoSize = true;
            this.OrderOrDeliveryLbl.Location = new System.Drawing.Point(1342, 38);
            this.OrderOrDeliveryLbl.Name = "OrderOrDeliveryLbl";
            this.OrderOrDeliveryLbl.Size = new System.Drawing.Size(135, 19);
            this.OrderOrDeliveryLbl.TabIndex = 11;
            this.OrderOrDeliveryLbl.Text = "Objednávky a výdejky";
            // 
            // itemInDeliveryIdDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryIdDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryId";
            this.itemInDeliveryIdDataGridViewTextBoxColumn.HeaderText = "ItemInDeliveryId";
            this.itemInDeliveryIdDataGridViewTextBoxColumn.Name = "itemInDeliveryIdDataGridViewTextBoxColumn";
            this.itemInDeliveryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemInDeliveryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemInDeliveryNameDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryNameDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryName";
            this.itemInDeliveryNameDataGridViewTextBoxColumn.HeaderText = "Číslo dodacího listu";
            this.itemInDeliveryNameDataGridViewTextBoxColumn.Name = "itemInDeliveryNameDataGridViewTextBoxColumn";
            this.itemInDeliveryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemInDeliveryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemInDeliveryCountDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryCountDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryCount";
            this.itemInDeliveryCountDataGridViewTextBoxColumn.HeaderText = "Počet kusů";
            this.itemInDeliveryCountDataGridViewTextBoxColumn.Name = "itemInDeliveryCountDataGridViewTextBoxColumn";
            this.itemInDeliveryCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemInDeliveryCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemInDeliveryDescriptionDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryDescription";
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.HeaderText = "Popis položky";
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.Name = "itemInDeliveryDescriptionDataGridViewTextBoxColumn";
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemInDeliverySellPriceDataGridViewTextBoxColumn
            // 
            this.itemInDeliverySellPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliverySellPrice";
            this.itemInDeliverySellPriceDataGridViewTextBoxColumn.HeaderText = "Cena za kus";
            this.itemInDeliverySellPriceDataGridViewTextBoxColumn.Name = "itemInDeliverySellPriceDataGridViewTextBoxColumn";
            this.itemInDeliverySellPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryFromItemInStockId";
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn.HeaderText = "ItemInDeliveryFromItemInStockId";
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn.Name = "itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn";
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryFromDeliveryNote";
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn.HeaderText = "ItemInDeliveryFromDeliveryNote";
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn.Name = "itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn";
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryOrderOrDelivery";
            this.itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn.HeaderText = "Objednávka/výdej";
            this.itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn.Name = "itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn";
            this.itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryNoteIdDataGridViewTextBoxColumn
            // 
            this.deliveryNoteIdDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNoteId";
            this.deliveryNoteIdDataGridViewTextBoxColumn.HeaderText = "Číslo dodacího listu";
            this.deliveryNoteIdDataGridViewTextBoxColumn.Name = "deliveryNoteIdDataGridViewTextBoxColumn";
            this.deliveryNoteIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryNoteIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryNoteIndicationDataGridViewTextBoxColumn
            // 
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNoteIndication";
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.HeaderText = "Označení dodacího listu";
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.Name = "deliveryNoteIndicationDataGridViewTextBoxColumn";
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryNoteCountDataGridViewTextBoxColumn
            // 
            this.deliveryNoteCountDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNoteCount";
            this.deliveryNoteCountDataGridViewTextBoxColumn.HeaderText = "Celková cena";
            this.deliveryNoteCountDataGridViewTextBoxColumn.Name = "deliveryNoteCountDataGridViewTextBoxColumn";
            this.deliveryNoteCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn
            // 
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNoteOrderOrDelivery";
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn.HeaderText = "Objednávka/výdejka";
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn.Name = "deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn";
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeliveryNoteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 868);
            this.Controls.Add(this.OrderOrDeliveryLbl);
            this.Controls.Add(this.ItemsInNoteLbl);
            this.Controls.Add(this.ItemsInStockLbl);
            this.Controls.Add(this.AddItemsInOrderToStorageBtn);
            this.Controls.Add(this.DeleteItemFromDeliveryBtn);
            this.Controls.Add(this.DeleteDeliveryNoteBtn);
            this.Controls.Add(this.AddItemToDeliveryBtn);
            this.Controls.Add(this.CreateOrderNoteBtn);
            this.Controls.Add(this.CreateDeliveryNoteBtn);
            this.Controls.Add(this.DeliveryStorageDgv);
            this.Controls.Add(this.DeliveryNoteDgv);
            this.Controls.Add(this.StorageInDeliveryDgv);
            this.Name = "DeliveryNoteFrm";
            this.Text = "Dodací listy";
            this.Load += new System.EventHandler(this.DeliveryNoteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageInDeliveryDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zltMgx2tGNDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryNoteDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryStorageDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInStockDeliveryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid StorageInDeliveryDgv;
        private MetroFramework.Controls.MetroGrid DeliveryNoteDgv;
        private MetroFramework.Controls.MetroGrid DeliveryStorageDgv;
        private zltMgx2tGNDataSet1 zltMgx2tGNDataSet1;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private zltMgx2tGNDataSet1TableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource;
        private zltMgx2tGNDataSet1TableAdapters.DeliveryNoteTableAdapter deliveryNoteTableAdapter;
        private System.Windows.Forms.BindingSource itemsInStockDeliveryBindingSource;
        private zltMgx2tGNDataSet1TableAdapters.ItemsInStockDeliveryTableAdapter itemsInStockDeliveryTableAdapter;
        private MetroFramework.Controls.MetroButton CreateDeliveryNoteBtn;
        private MetroFramework.Controls.MetroButton CreateOrderNoteBtn;
        private MetroFramework.Controls.MetroButton AddItemToDeliveryBtn;
        private MetroFramework.Controls.MetroButton DeleteDeliveryNoteBtn;
        private MetroFramework.Controls.MetroButton DeleteItemFromDeliveryBtn;
        private MetroFramework.Controls.MetroButton AddItemsInOrderToStorageBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPurchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoteIndicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoteCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliveryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliveryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliveryCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliveryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliverySellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel ItemsInStockLbl;
        private MetroFramework.Controls.MetroLabel ItemsInNoteLbl;
        private MetroFramework.Controls.MetroLabel OrderOrDeliveryLbl;
    }
}