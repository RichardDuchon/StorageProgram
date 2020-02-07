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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StorageInDeliveryDgv = new MetroFramework.Controls.MetroGrid();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPurchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zltMgx2tGNDataSet1 = new StorageProgram.zltMgx2tGNDataSet1();
            this.DeliveryNoteDgv = new MetroFramework.Controls.MetroGrid();
            this.deliveryNoteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteIndicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryStorageDgv = new MetroFramework.Controls.MetroGrid();
            this.itemInDeliveryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliverySellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryFromItemInStockIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryFromDeliveryNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInDeliveryOrderOrDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageInDeliveryDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StorageInDeliveryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageInDeliveryDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemPurchasePriceDataGridViewTextBoxColumn});
            this.StorageInDeliveryDgv.DataSource = this.storageBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StorageInDeliveryDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.StorageInDeliveryDgv.EnableHeadersVisualStyles = false;
            this.StorageInDeliveryDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StorageInDeliveryDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorageInDeliveryDgv.Location = new System.Drawing.Point(23, 63);
            this.StorageInDeliveryDgv.Name = "StorageInDeliveryDgv";
            this.StorageInDeliveryDgv.ReadOnly = true;
            this.StorageInDeliveryDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageInDeliveryDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StorageInDeliveryDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StorageInDeliveryDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StorageInDeliveryDgv.Size = new System.Drawing.Size(490, 746);
            this.StorageInDeliveryDgv.TabIndex = 0;
            this.StorageInDeliveryDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageInDeliveryDgv_CellClick);
            this.StorageInDeliveryDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageInDeliveryDgv_CellContentClick);
            this.StorageInDeliveryDgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageInDeliveryDgv_CellContentDoubleClick);
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
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // DeliveryNoteDgv
            // 
            this.DeliveryNoteDgv.AllowUserToAddRows = false;
            this.DeliveryNoteDgv.AllowUserToResizeRows = false;
            this.DeliveryNoteDgv.AutoGenerateColumns = false;
            this.DeliveryNoteDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeliveryNoteDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeliveryNoteDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DeliveryNoteDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryNoteDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DeliveryNoteDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryNoteDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryNoteIdDataGridViewTextBoxColumn,
            this.deliveryNoteIndicationDataGridViewTextBoxColumn,
            this.deliveryNoteCountDataGridViewTextBoxColumn,
            this.deliveryNoteOrderOrDeliveryDataGridViewTextBoxColumn});
            this.DeliveryNoteDgv.DataSource = this.deliveryNoteBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryNoteDgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.DeliveryNoteDgv.EnableHeadersVisualStyles = false;
            this.DeliveryNoteDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DeliveryNoteDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeliveryNoteDgv.Location = new System.Drawing.Point(829, 63);
            this.DeliveryNoteDgv.Name = "DeliveryNoteDgv";
            this.DeliveryNoteDgv.ReadOnly = true;
            this.DeliveryNoteDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryNoteDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DeliveryNoteDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DeliveryNoteDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryNoteDgv.Size = new System.Drawing.Size(668, 277);
            this.DeliveryNoteDgv.TabIndex = 1;
            this.DeliveryNoteDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryNoteDgv_CellClick);
            this.DeliveryNoteDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryNoteDgv_CellContentClick);
            this.DeliveryNoteDgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryNoteDgv_CellContentDoubleClick);
            // 
            // deliveryNoteIdDataGridViewTextBoxColumn
            // 
            this.deliveryNoteIdDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNoteId";
            this.deliveryNoteIdDataGridViewTextBoxColumn.HeaderText = "Číslo dodacího listu";
            this.deliveryNoteIdDataGridViewTextBoxColumn.Name = "deliveryNoteIdDataGridViewTextBoxColumn";
            this.deliveryNoteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryNoteIndicationDataGridViewTextBoxColumn
            // 
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNoteIndication";
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.HeaderText = "Označení dodacího listu";
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.Name = "deliveryNoteIndicationDataGridViewTextBoxColumn";
            this.deliveryNoteIndicationDataGridViewTextBoxColumn.ReadOnly = true;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryStorageDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryStorageDgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.DeliveryStorageDgv.EnableHeadersVisualStyles = false;
            this.DeliveryStorageDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DeliveryStorageDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeliveryStorageDgv.Location = new System.Drawing.Point(829, 346);
            this.DeliveryStorageDgv.Name = "DeliveryStorageDgv";
            this.DeliveryStorageDgv.ReadOnly = true;
            this.DeliveryStorageDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryStorageDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DeliveryStorageDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DeliveryStorageDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryStorageDgv.Size = new System.Drawing.Size(668, 444);
            this.DeliveryStorageDgv.TabIndex = 2;
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
            // 
            // itemInDeliveryCountDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryCountDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryCount";
            this.itemInDeliveryCountDataGridViewTextBoxColumn.HeaderText = "Počet kusů";
            this.itemInDeliveryCountDataGridViewTextBoxColumn.Name = "itemInDeliveryCountDataGridViewTextBoxColumn";
            this.itemInDeliveryCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemInDeliveryDescriptionDataGridViewTextBoxColumn
            // 
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemInDeliveryDescription";
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.HeaderText = "Popis položky";
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.Name = "itemInDeliveryDescriptionDataGridViewTextBoxColumn";
            this.itemInDeliveryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.AddItemToDeliveryBtn.Location = new System.Drawing.Point(519, 346);
            this.AddItemToDeliveryBtn.Name = "AddItemToDeliveryBtn";
            this.AddItemToDeliveryBtn.Size = new System.Drawing.Size(138, 86);
            this.AddItemToDeliveryBtn.TabIndex = 5;
            this.AddItemToDeliveryBtn.Text = "Přidat položku do\r\ndodacího listu";
            this.AddItemToDeliveryBtn.UseSelectable = true;
            this.AddItemToDeliveryBtn.Click += new System.EventHandler(this.AddItemToDeliveryBtn_Click);
            // 
            // DeleteDeliveryNoteBtn
            // 
            this.DeleteDeliveryNoteBtn.Location = new System.Drawing.Point(1309, 34);
            this.DeleteDeliveryNoteBtn.Name = "DeleteDeliveryNoteBtn";
            this.DeleteDeliveryNoteBtn.Size = new System.Drawing.Size(124, 23);
            this.DeleteDeliveryNoteBtn.TabIndex = 6;
            this.DeleteDeliveryNoteBtn.Text = "Smazat dodací list";
            this.DeleteDeliveryNoteBtn.UseSelectable = true;
            this.DeleteDeliveryNoteBtn.Click += new System.EventHandler(this.DeleteDeliveryNoteBtn_Click);
            // 
            // DeleteItemFromDeliveryBtn
            // 
            this.DeleteItemFromDeliveryBtn.Location = new System.Drawing.Point(655, 761);
            this.DeleteItemFromDeliveryBtn.Name = "DeleteItemFromDeliveryBtn";
            this.DeleteItemFromDeliveryBtn.Size = new System.Drawing.Size(168, 48);
            this.DeleteItemFromDeliveryBtn.TabIndex = 7;
            this.DeleteItemFromDeliveryBtn.Text = "Smazat položku ";
            this.DeleteItemFromDeliveryBtn.UseSelectable = true;
            this.DeleteItemFromDeliveryBtn.Click += new System.EventHandler(this.DeleteItemFromDeliveryBtn_Click);
            // 
            // AddItemsInOrderToStorageBtn
            // 
            this.AddItemsInOrderToStorageBtn.Location = new System.Drawing.Point(1309, 813);
            this.AddItemsInOrderToStorageBtn.Name = "AddItemsInOrderToStorageBtn";
            this.AddItemsInOrderToStorageBtn.Size = new System.Drawing.Size(188, 23);
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
            // DeliveryNoteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 868);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPurchasePriceDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton CreateDeliveryNoteBtn;
        private MetroFramework.Controls.MetroButton CreateOrderNoteBtn;
        private MetroFramework.Controls.MetroButton AddItemToDeliveryBtn;
        private MetroFramework.Controls.MetroButton DeleteDeliveryNoteBtn;
        private MetroFramework.Controls.MetroButton DeleteItemFromDeliveryBtn;
        private MetroFramework.Controls.MetroButton AddItemsInOrderToStorageBtn;
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
    }
}