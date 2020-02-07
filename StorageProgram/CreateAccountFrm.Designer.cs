namespace StorageProgram
{
    partial class CreateAccountFrm
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
            this.AccountNameLbl = new MetroFramework.Controls.MetroLabel();
            this.AccountPasswordLbl = new MetroFramework.Controls.MetroLabel();
            this.AccountPasswordAgainLbl = new MetroFramework.Controls.MetroLabel();
            this.CreateAccountBtn = new MetroFramework.Controls.MetroButton();
            this.AccountNameTxb = new MetroFramework.Controls.MetroTextBox();
            this.AccountPasswordTxb = new MetroFramework.Controls.MetroTextBox();
            this.AccountPasswordAgainTxb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // AccountNameLbl
            // 
            this.AccountNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountNameLbl.AutoSize = true;
            this.AccountNameLbl.Location = new System.Drawing.Point(200, 128);
            this.AccountNameLbl.Name = "AccountNameLbl";
            this.AccountNameLbl.Size = new System.Drawing.Size(73, 19);
            this.AccountNameLbl.TabIndex = 0;
            this.AccountNameLbl.Text = "Název účtu";
            // 
            // AccountPasswordLbl
            // 
            this.AccountPasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountPasswordLbl.AutoSize = true;
            this.AccountPasswordLbl.Location = new System.Drawing.Point(200, 187);
            this.AccountPasswordLbl.Name = "AccountPasswordLbl";
            this.AccountPasswordLbl.Size = new System.Drawing.Size(41, 19);
            this.AccountPasswordLbl.TabIndex = 1;
            this.AccountPasswordLbl.Text = "Heslo";
            // 
            // AccountPasswordAgainLbl
            // 
            this.AccountPasswordAgainLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountPasswordAgainLbl.AutoSize = true;
            this.AccountPasswordAgainLbl.Location = new System.Drawing.Point(200, 242);
            this.AccountPasswordAgainLbl.Name = "AccountPasswordAgainLbl";
            this.AccountPasswordAgainLbl.Size = new System.Drawing.Size(105, 19);
            this.AccountPasswordAgainLbl.TabIndex = 2;
            this.AccountPasswordAgainLbl.Text = "Zopakovat heslo";
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateAccountBtn.Location = new System.Drawing.Point(363, 303);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(152, 23);
            this.CreateAccountBtn.TabIndex = 3;
            this.CreateAccountBtn.Text = "Vytvořit účet";
            this.CreateAccountBtn.UseSelectable = true;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // AccountNameTxb
            // 
            this.AccountNameTxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.AccountNameTxb.CustomButton.Image = null;
            this.AccountNameTxb.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.AccountNameTxb.CustomButton.Name = "";
            this.AccountNameTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AccountNameTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AccountNameTxb.CustomButton.TabIndex = 1;
            this.AccountNameTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AccountNameTxb.CustomButton.UseSelectable = true;
            this.AccountNameTxb.CustomButton.Visible = false;
            this.AccountNameTxb.Lines = new string[0];
            this.AccountNameTxb.Location = new System.Drawing.Point(363, 128);
            this.AccountNameTxb.MaxLength = 32767;
            this.AccountNameTxb.Name = "AccountNameTxb";
            this.AccountNameTxb.PasswordChar = '\0';
            this.AccountNameTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AccountNameTxb.SelectedText = "";
            this.AccountNameTxb.SelectionLength = 0;
            this.AccountNameTxb.SelectionStart = 0;
            this.AccountNameTxb.ShortcutsEnabled = true;
            this.AccountNameTxb.Size = new System.Drawing.Size(181, 23);
            this.AccountNameTxb.TabIndex = 4;
            this.AccountNameTxb.UseSelectable = true;
            this.AccountNameTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AccountNameTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AccountPasswordTxb
            // 
            this.AccountPasswordTxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.AccountPasswordTxb.CustomButton.Image = null;
            this.AccountPasswordTxb.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.AccountPasswordTxb.CustomButton.Name = "";
            this.AccountPasswordTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AccountPasswordTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AccountPasswordTxb.CustomButton.TabIndex = 1;
            this.AccountPasswordTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AccountPasswordTxb.CustomButton.UseSelectable = true;
            this.AccountPasswordTxb.CustomButton.Visible = false;
            this.AccountPasswordTxb.Lines = new string[0];
            this.AccountPasswordTxb.Location = new System.Drawing.Point(363, 183);
            this.AccountPasswordTxb.MaxLength = 32767;
            this.AccountPasswordTxb.Name = "AccountPasswordTxb";
            this.AccountPasswordTxb.PasswordChar = '*';
            this.AccountPasswordTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AccountPasswordTxb.SelectedText = "";
            this.AccountPasswordTxb.SelectionLength = 0;
            this.AccountPasswordTxb.SelectionStart = 0;
            this.AccountPasswordTxb.ShortcutsEnabled = true;
            this.AccountPasswordTxb.Size = new System.Drawing.Size(177, 23);
            this.AccountPasswordTxb.TabIndex = 5;
            this.AccountPasswordTxb.UseSelectable = true;
            this.AccountPasswordTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AccountPasswordTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AccountPasswordAgainTxb
            // 
            this.AccountPasswordAgainTxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.AccountPasswordAgainTxb.CustomButton.Image = null;
            this.AccountPasswordAgainTxb.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.AccountPasswordAgainTxb.CustomButton.Name = "";
            this.AccountPasswordAgainTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AccountPasswordAgainTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AccountPasswordAgainTxb.CustomButton.TabIndex = 1;
            this.AccountPasswordAgainTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AccountPasswordAgainTxb.CustomButton.UseSelectable = true;
            this.AccountPasswordAgainTxb.CustomButton.Visible = false;
            this.AccountPasswordAgainTxb.Lines = new string[0];
            this.AccountPasswordAgainTxb.Location = new System.Drawing.Point(363, 242);
            this.AccountPasswordAgainTxb.MaxLength = 32767;
            this.AccountPasswordAgainTxb.Name = "AccountPasswordAgainTxb";
            this.AccountPasswordAgainTxb.PasswordChar = '*';
            this.AccountPasswordAgainTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AccountPasswordAgainTxb.SelectedText = "";
            this.AccountPasswordAgainTxb.SelectionLength = 0;
            this.AccountPasswordAgainTxb.SelectionStart = 0;
            this.AccountPasswordAgainTxb.ShortcutsEnabled = true;
            this.AccountPasswordAgainTxb.Size = new System.Drawing.Size(177, 23);
            this.AccountPasswordAgainTxb.TabIndex = 6;
            this.AccountPasswordAgainTxb.UseSelectable = true;
            this.AccountPasswordAgainTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AccountPasswordAgainTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CreateAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountPasswordAgainTxb);
            this.Controls.Add(this.AccountPasswordTxb);
            this.Controls.Add(this.AccountNameTxb);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.AccountPasswordAgainLbl);
            this.Controls.Add(this.AccountPasswordLbl);
            this.Controls.Add(this.AccountNameLbl);
            this.Name = "CreateAccountFrm";
            this.Text = "Vytváření účtu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel AccountNameLbl;
        private MetroFramework.Controls.MetroLabel AccountPasswordLbl;
        private MetroFramework.Controls.MetroLabel AccountPasswordAgainLbl;
        private MetroFramework.Controls.MetroButton CreateAccountBtn;
        private MetroFramework.Controls.MetroTextBox AccountNameTxb;
        private MetroFramework.Controls.MetroTextBox AccountPasswordTxb;
        private MetroFramework.Controls.MetroTextBox AccountPasswordAgainTxb;
    }
}