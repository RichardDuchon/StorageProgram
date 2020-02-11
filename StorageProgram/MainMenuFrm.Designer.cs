namespace StorageProgram
{
    partial class MainMenuFrm
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
            this.StorageBtn = new MetroFramework.Controls.MetroButton();
            this.InvoiceBtn = new MetroFramework.Controls.MetroButton();
            this.DeliveryNoteBtn = new MetroFramework.Controls.MetroButton();
            this.LoginMenuBtn = new MetroFramework.Controls.MetroButton();
            this.CompanyBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // StorageBtn
            // 
            this.StorageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StorageBtn.Location = new System.Drawing.Point(311, 71);
            this.StorageBtn.Name = "StorageBtn";
            this.StorageBtn.Size = new System.Drawing.Size(168, 48);
            this.StorageBtn.TabIndex = 0;
            this.StorageBtn.Text = "Sklad";
            this.StorageBtn.UseSelectable = true;
            this.StorageBtn.Click += new System.EventHandler(this.StorageBtn_Click);
            // 
            // InvoiceBtn
            // 
            this.InvoiceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvoiceBtn.Location = new System.Drawing.Point(311, 230);
            this.InvoiceBtn.Name = "InvoiceBtn";
            this.InvoiceBtn.Size = new System.Drawing.Size(168, 48);
            this.InvoiceBtn.TabIndex = 1;
            this.InvoiceBtn.Text = "Faktury";
            this.InvoiceBtn.UseSelectable = true;
            this.InvoiceBtn.Click += new System.EventHandler(this.InvoiceBtn_Click);
            // 
            // DeliveryNoteBtn
            // 
            this.DeliveryNoteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeliveryNoteBtn.Location = new System.Drawing.Point(311, 151);
            this.DeliveryNoteBtn.Name = "DeliveryNoteBtn";
            this.DeliveryNoteBtn.Size = new System.Drawing.Size(168, 48);
            this.DeliveryNoteBtn.TabIndex = 2;
            this.DeliveryNoteBtn.Text = "Dodací listy";
            this.DeliveryNoteBtn.UseSelectable = true;
            this.DeliveryNoteBtn.Click += new System.EventHandler(this.DeliveryNoteBtn_Click);
            // 
            // LoginMenuBtn
            // 
            this.LoginMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginMenuBtn.Location = new System.Drawing.Point(23, 404);
            this.LoginMenuBtn.Name = "LoginMenuBtn";
            this.LoginMenuBtn.Size = new System.Drawing.Size(195, 23);
            this.LoginMenuBtn.TabIndex = 3;
            this.LoginMenuBtn.Text = "Zpět do přihlašovacího menu";
            this.LoginMenuBtn.UseSelectable = true;
            this.LoginMenuBtn.Click += new System.EventHandler(this.LoginMenuBtn_Click);
            // 
            // CompanyBtn
            // 
            this.CompanyBtn.Location = new System.Drawing.Point(311, 314);
            this.CompanyBtn.Name = "CompanyBtn";
            this.CompanyBtn.Size = new System.Drawing.Size(168, 48);
            this.CompanyBtn.TabIndex = 4;
            this.CompanyBtn.Text = "Firmy";
            this.CompanyBtn.UseSelectable = true;
            // 
            // MainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompanyBtn);
            this.Controls.Add(this.LoginMenuBtn);
            this.Controls.Add(this.DeliveryNoteBtn);
            this.Controls.Add(this.InvoiceBtn);
            this.Controls.Add(this.StorageBtn);
            this.Name = "MainMenuFrm";
            this.Text = "Hlavní menu";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton StorageBtn;
        private MetroFramework.Controls.MetroButton InvoiceBtn;
        private MetroFramework.Controls.MetroButton DeliveryNoteBtn;
        private MetroFramework.Controls.MetroButton LoginMenuBtn;
        private MetroFramework.Controls.MetroButton CompanyBtn;
    }
}