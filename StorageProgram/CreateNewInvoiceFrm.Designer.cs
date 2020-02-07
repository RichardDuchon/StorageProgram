namespace StorageProgram
{
    partial class CreateNewInvoiceFrm
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
            this.CreateNewInvoiceForCustomerBtn = new MetroFramework.Controls.MetroButton();
            this.CreateNewInvoiceForOurCompanyBtn = new MetroFramework.Controls.MetroButton();
            this.InvoiceDesignationLbl = new MetroFramework.Controls.MetroLabel();
            this.InvoiceNameOfCompanyLbl = new MetroFramework.Controls.MetroLabel();
            this.InvoiceDateLbl = new MetroFramework.Controls.MetroLabel();
            this.InvoiceDateMaturityLbl = new MetroFramework.Controls.MetroLabel();
            this.InvoiceDesignationTxb = new MetroFramework.Controls.MetroTextBox();
            this.InvoiceNameOfCompanyTxb = new MetroFramework.Controls.MetroTextBox();
            this.InvoiceDateTxb = new MetroFramework.Controls.MetroTextBox();
            this.InvoiceDateMaturityTxb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // CreateNewInvoiceForCustomerBtn
            // 
            this.CreateNewInvoiceForCustomerBtn.Location = new System.Drawing.Point(317, 290);
            this.CreateNewInvoiceForCustomerBtn.Name = "CreateNewInvoiceForCustomerBtn";
            this.CreateNewInvoiceForCustomerBtn.Size = new System.Drawing.Size(168, 48);
            this.CreateNewInvoiceForCustomerBtn.TabIndex = 0;
            this.CreateNewInvoiceForCustomerBtn.Text = "Vystavit fakturu pro zákazníka";
            this.CreateNewInvoiceForCustomerBtn.UseSelectable = true;
            this.CreateNewInvoiceForCustomerBtn.Click += new System.EventHandler(this.CreateNewInvoiceForCustomerBtn_Click);
            // 
            // CreateNewInvoiceForOurCompanyBtn
            // 
            this.CreateNewInvoiceForOurCompanyBtn.Location = new System.Drawing.Point(317, 364);
            this.CreateNewInvoiceForOurCompanyBtn.Name = "CreateNewInvoiceForOurCompanyBtn";
            this.CreateNewInvoiceForOurCompanyBtn.Size = new System.Drawing.Size(168, 48);
            this.CreateNewInvoiceForOurCompanyBtn.TabIndex = 1;
            this.CreateNewInvoiceForOurCompanyBtn.Text = "Založit fakturu od dodavatele";
            this.CreateNewInvoiceForOurCompanyBtn.UseSelectable = true;
            this.CreateNewInvoiceForOurCompanyBtn.Click += new System.EventHandler(this.CreateNewInvoiceForOurCompanyBtn_Click);
            // 
            // InvoiceDesignationLbl
            // 
            this.InvoiceDesignationLbl.AutoSize = true;
            this.InvoiceDesignationLbl.Location = new System.Drawing.Point(107, 88);
            this.InvoiceDesignationLbl.Name = "InvoiceDesignationLbl";
            this.InvoiceDesignationLbl.Size = new System.Drawing.Size(107, 19);
            this.InvoiceDesignationLbl.TabIndex = 2;
            this.InvoiceDesignationLbl.Text = "Označení faktury";
            // 
            // InvoiceNameOfCompanyLbl
            // 
            this.InvoiceNameOfCompanyLbl.AutoSize = true;
            this.InvoiceNameOfCompanyLbl.Location = new System.Drawing.Point(101, 135);
            this.InvoiceNameOfCompanyLbl.Name = "InvoiceNameOfCompanyLbl";
            this.InvoiceNameOfCompanyLbl.Size = new System.Drawing.Size(113, 19);
            this.InvoiceNameOfCompanyLbl.TabIndex = 3;
            this.InvoiceNameOfCompanyLbl.Text = "Název společnosti";
            // 
            // InvoiceDateLbl
            // 
            this.InvoiceDateLbl.AutoSize = true;
            this.InvoiceDateLbl.Location = new System.Drawing.Point(111, 200);
            this.InvoiceDateLbl.Name = "InvoiceDateLbl";
            this.InvoiceDateLbl.Size = new System.Drawing.Size(103, 19);
            this.InvoiceDateLbl.TabIndex = 5;
            this.InvoiceDateLbl.Text = "Datum vystavení";
            // 
            // InvoiceDateMaturityLbl
            // 
            this.InvoiceDateMaturityLbl.AutoSize = true;
            this.InvoiceDateMaturityLbl.Location = new System.Drawing.Point(108, 237);
            this.InvoiceDateMaturityLbl.Name = "InvoiceDateMaturityLbl";
            this.InvoiceDateMaturityLbl.Size = new System.Drawing.Size(106, 19);
            this.InvoiceDateMaturityLbl.TabIndex = 6;
            this.InvoiceDateMaturityLbl.Text = "Datum splatnosti";
            // 
            // InvoiceDesignationTxb
            // 
            // 
            // 
            // 
            this.InvoiceDesignationTxb.CustomButton.Image = null;
            this.InvoiceDesignationTxb.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.InvoiceDesignationTxb.CustomButton.Name = "";
            this.InvoiceDesignationTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvoiceDesignationTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvoiceDesignationTxb.CustomButton.TabIndex = 1;
            this.InvoiceDesignationTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvoiceDesignationTxb.CustomButton.UseSelectable = true;
            this.InvoiceDesignationTxb.CustomButton.Visible = false;
            this.InvoiceDesignationTxb.Lines = new string[0];
            this.InvoiceDesignationTxb.Location = new System.Drawing.Point(285, 88);
            this.InvoiceDesignationTxb.MaxLength = 32767;
            this.InvoiceDesignationTxb.Name = "InvoiceDesignationTxb";
            this.InvoiceDesignationTxb.PasswordChar = '\0';
            this.InvoiceDesignationTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvoiceDesignationTxb.SelectedText = "";
            this.InvoiceDesignationTxb.SelectionLength = 0;
            this.InvoiceDesignationTxb.SelectionStart = 0;
            this.InvoiceDesignationTxb.ShortcutsEnabled = true;
            this.InvoiceDesignationTxb.Size = new System.Drawing.Size(256, 23);
            this.InvoiceDesignationTxb.TabIndex = 7;
            this.InvoiceDesignationTxb.UseSelectable = true;
            this.InvoiceDesignationTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvoiceDesignationTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InvoiceNameOfCompanyTxb
            // 
            // 
            // 
            // 
            this.InvoiceNameOfCompanyTxb.CustomButton.Image = null;
            this.InvoiceNameOfCompanyTxb.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.InvoiceNameOfCompanyTxb.CustomButton.Name = "";
            this.InvoiceNameOfCompanyTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvoiceNameOfCompanyTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvoiceNameOfCompanyTxb.CustomButton.TabIndex = 1;
            this.InvoiceNameOfCompanyTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvoiceNameOfCompanyTxb.CustomButton.UseSelectable = true;
            this.InvoiceNameOfCompanyTxb.CustomButton.Visible = false;
            this.InvoiceNameOfCompanyTxb.Lines = new string[0];
            this.InvoiceNameOfCompanyTxb.Location = new System.Drawing.Point(285, 135);
            this.InvoiceNameOfCompanyTxb.MaxLength = 32767;
            this.InvoiceNameOfCompanyTxb.Name = "InvoiceNameOfCompanyTxb";
            this.InvoiceNameOfCompanyTxb.PasswordChar = '\0';
            this.InvoiceNameOfCompanyTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvoiceNameOfCompanyTxb.SelectedText = "";
            this.InvoiceNameOfCompanyTxb.SelectionLength = 0;
            this.InvoiceNameOfCompanyTxb.SelectionStart = 0;
            this.InvoiceNameOfCompanyTxb.ShortcutsEnabled = true;
            this.InvoiceNameOfCompanyTxb.Size = new System.Drawing.Size(256, 23);
            this.InvoiceNameOfCompanyTxb.TabIndex = 8;
            this.InvoiceNameOfCompanyTxb.UseSelectable = true;
            this.InvoiceNameOfCompanyTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvoiceNameOfCompanyTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InvoiceDateTxb
            // 
            // 
            // 
            // 
            this.InvoiceDateTxb.CustomButton.Image = null;
            this.InvoiceDateTxb.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.InvoiceDateTxb.CustomButton.Name = "";
            this.InvoiceDateTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvoiceDateTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvoiceDateTxb.CustomButton.TabIndex = 1;
            this.InvoiceDateTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvoiceDateTxb.CustomButton.UseSelectable = true;
            this.InvoiceDateTxb.CustomButton.Visible = false;
            this.InvoiceDateTxb.Lines = new string[0];
            this.InvoiceDateTxb.Location = new System.Drawing.Point(285, 196);
            this.InvoiceDateTxb.MaxLength = 32767;
            this.InvoiceDateTxb.Name = "InvoiceDateTxb";
            this.InvoiceDateTxb.PasswordChar = '\0';
            this.InvoiceDateTxb.PromptText = "00.00.0000";
            this.InvoiceDateTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvoiceDateTxb.SelectedText = "";
            this.InvoiceDateTxb.SelectionLength = 0;
            this.InvoiceDateTxb.SelectionStart = 0;
            this.InvoiceDateTxb.ShortcutsEnabled = true;
            this.InvoiceDateTxb.Size = new System.Drawing.Size(256, 23);
            this.InvoiceDateTxb.TabIndex = 10;
            this.InvoiceDateTxb.UseSelectable = true;
            this.InvoiceDateTxb.WaterMark = "00.00.0000";
            this.InvoiceDateTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvoiceDateTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InvoiceDateMaturityTxb
            // 
            // 
            // 
            // 
            this.InvoiceDateMaturityTxb.CustomButton.Image = null;
            this.InvoiceDateMaturityTxb.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.InvoiceDateMaturityTxb.CustomButton.Name = "";
            this.InvoiceDateMaturityTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvoiceDateMaturityTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvoiceDateMaturityTxb.CustomButton.TabIndex = 1;
            this.InvoiceDateMaturityTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvoiceDateMaturityTxb.CustomButton.UseSelectable = true;
            this.InvoiceDateMaturityTxb.CustomButton.Visible = false;
            this.InvoiceDateMaturityTxb.Lines = new string[0];
            this.InvoiceDateMaturityTxb.Location = new System.Drawing.Point(285, 237);
            this.InvoiceDateMaturityTxb.MaxLength = 32767;
            this.InvoiceDateMaturityTxb.Name = "InvoiceDateMaturityTxb";
            this.InvoiceDateMaturityTxb.PasswordChar = '\0';
            this.InvoiceDateMaturityTxb.PromptText = "00.00.0000";
            this.InvoiceDateMaturityTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvoiceDateMaturityTxb.SelectedText = "";
            this.InvoiceDateMaturityTxb.SelectionLength = 0;
            this.InvoiceDateMaturityTxb.SelectionStart = 0;
            this.InvoiceDateMaturityTxb.ShortcutsEnabled = true;
            this.InvoiceDateMaturityTxb.Size = new System.Drawing.Size(256, 23);
            this.InvoiceDateMaturityTxb.TabIndex = 11;
            this.InvoiceDateMaturityTxb.UseSelectable = true;
            this.InvoiceDateMaturityTxb.WaterMark = "00.00.0000";
            this.InvoiceDateMaturityTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvoiceDateMaturityTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CreateNewInvoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InvoiceDateMaturityTxb);
            this.Controls.Add(this.InvoiceDateTxb);
            this.Controls.Add(this.InvoiceNameOfCompanyTxb);
            this.Controls.Add(this.InvoiceDesignationTxb);
            this.Controls.Add(this.InvoiceDateMaturityLbl);
            this.Controls.Add(this.InvoiceDateLbl);
            this.Controls.Add(this.InvoiceNameOfCompanyLbl);
            this.Controls.Add(this.InvoiceDesignationLbl);
            this.Controls.Add(this.CreateNewInvoiceForOurCompanyBtn);
            this.Controls.Add(this.CreateNewInvoiceForCustomerBtn);
            this.Name = "CreateNewInvoiceFrm";
            this.Text = "Vytvoření faktury";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CreateNewInvoiceForCustomerBtn;
        private MetroFramework.Controls.MetroButton CreateNewInvoiceForOurCompanyBtn;
        private MetroFramework.Controls.MetroLabel InvoiceDesignationLbl;
        private MetroFramework.Controls.MetroLabel InvoiceNameOfCompanyLbl;
        private MetroFramework.Controls.MetroLabel InvoiceDateLbl;
        private MetroFramework.Controls.MetroLabel InvoiceDateMaturityLbl;
        private MetroFramework.Controls.MetroTextBox InvoiceDesignationTxb;
        private MetroFramework.Controls.MetroTextBox InvoiceNameOfCompanyTxb;
        private MetroFramework.Controls.MetroTextBox InvoiceDateTxb;
        private MetroFramework.Controls.MetroTextBox InvoiceDateMaturityTxb;
    }
}