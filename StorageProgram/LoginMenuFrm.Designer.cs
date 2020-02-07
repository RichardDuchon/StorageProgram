namespace StorageProgram
{
    partial class LoginMenuFrm
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
            this.LoginNameLbl = new MetroFramework.Controls.MetroLabel();
            this.LoginPasswordLbl = new MetroFramework.Controls.MetroLabel();
            this.LoginAccountBtn = new MetroFramework.Controls.MetroButton();
            this.CreateAccountBtn = new MetroFramework.Controls.MetroButton();
            this.LoginNameTxb = new MetroFramework.Controls.MetroTextBox();
            this.LoginPasswordTxb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // LoginNameLbl
            // 
            this.LoginNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginNameLbl.AutoSize = true;
            this.LoginNameLbl.Location = new System.Drawing.Point(204, 142);
            this.LoginNameLbl.Name = "LoginNameLbl";
            this.LoginNameLbl.Size = new System.Drawing.Size(118, 19);
            this.LoginNameLbl.TabIndex = 0;
            this.LoginNameLbl.Text = "Přihlašovací jméno";
            // 
            // LoginPasswordLbl
            // 
            this.LoginPasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPasswordLbl.AutoSize = true;
            this.LoginPasswordLbl.Location = new System.Drawing.Point(281, 205);
            this.LoginPasswordLbl.Name = "LoginPasswordLbl";
            this.LoginPasswordLbl.Size = new System.Drawing.Size(41, 19);
            this.LoginPasswordLbl.TabIndex = 1;
            this.LoginPasswordLbl.Text = "Heslo";
            // 
            // LoginAccountBtn
            // 
            this.LoginAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginAccountBtn.Location = new System.Drawing.Point(340, 261);
            this.LoginAccountBtn.Name = "LoginAccountBtn";
            this.LoginAccountBtn.Size = new System.Drawing.Size(168, 48);
            this.LoginAccountBtn.TabIndex = 2;
            this.LoginAccountBtn.Text = "Přihlásit se";
            this.LoginAccountBtn.UseSelectable = true;
            this.LoginAccountBtn.Click += new System.EventHandler(this.LoginAccountBtn_Click);
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateAccountBtn.Location = new System.Drawing.Point(340, 364);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(168, 48);
            this.CreateAccountBtn.TabIndex = 3;
            this.CreateAccountBtn.Text = "Vytvořit účet";
            this.CreateAccountBtn.UseSelectable = true;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // LoginNameTxb
            // 
            this.LoginNameTxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.LoginNameTxb.CustomButton.Image = null;
            this.LoginNameTxb.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.LoginNameTxb.CustomButton.Name = "";
            this.LoginNameTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LoginNameTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginNameTxb.CustomButton.TabIndex = 1;
            this.LoginNameTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginNameTxb.CustomButton.UseSelectable = true;
            this.LoginNameTxb.CustomButton.Visible = false;
            this.LoginNameTxb.Lines = new string[0];
            this.LoginNameTxb.Location = new System.Drawing.Point(328, 142);
            this.LoginNameTxb.MaxLength = 32767;
            this.LoginNameTxb.Name = "LoginNameTxb";
            this.LoginNameTxb.PasswordChar = '\0';
            this.LoginNameTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginNameTxb.SelectedText = "";
            this.LoginNameTxb.SelectionLength = 0;
            this.LoginNameTxb.SelectionStart = 0;
            this.LoginNameTxb.ShortcutsEnabled = true;
            this.LoginNameTxb.Size = new System.Drawing.Size(205, 23);
            this.LoginNameTxb.TabIndex = 5;
            this.LoginNameTxb.UseSelectable = true;
            this.LoginNameTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginNameTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginPasswordTxb
            // 
            this.LoginPasswordTxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.LoginPasswordTxb.CustomButton.Image = null;
            this.LoginPasswordTxb.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.LoginPasswordTxb.CustomButton.Name = "";
            this.LoginPasswordTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LoginPasswordTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginPasswordTxb.CustomButton.TabIndex = 1;
            this.LoginPasswordTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginPasswordTxb.CustomButton.UseSelectable = true;
            this.LoginPasswordTxb.CustomButton.Visible = false;
            this.LoginPasswordTxb.Lines = new string[0];
            this.LoginPasswordTxb.Location = new System.Drawing.Point(328, 205);
            this.LoginPasswordTxb.MaxLength = 32767;
            this.LoginPasswordTxb.Name = "LoginPasswordTxb";
            this.LoginPasswordTxb.PasswordChar = '*';
            this.LoginPasswordTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginPasswordTxb.SelectedText = "";
            this.LoginPasswordTxb.SelectionLength = 0;
            this.LoginPasswordTxb.SelectionStart = 0;
            this.LoginPasswordTxb.ShortcutsEnabled = true;
            this.LoginPasswordTxb.Size = new System.Drawing.Size(205, 23);
            this.LoginPasswordTxb.TabIndex = 6;
            this.LoginPasswordTxb.UseSelectable = true;
            this.LoginPasswordTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginPasswordTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginPasswordTxb);
            this.Controls.Add(this.LoginNameTxb);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.LoginAccountBtn);
            this.Controls.Add(this.LoginPasswordLbl);
            this.Controls.Add(this.LoginNameLbl);
            this.Name = "LoginMenuFrm";
            this.Text = "Přihlašovací menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LoginNameLbl;
        private MetroFramework.Controls.MetroLabel LoginPasswordLbl;
        private MetroFramework.Controls.MetroButton LoginAccountBtn;
        private MetroFramework.Controls.MetroButton CreateAccountBtn;
        private MetroFramework.Controls.MetroTextBox LoginNameTxb;
        private MetroFramework.Controls.MetroTextBox LoginPasswordTxb;
    }
}

