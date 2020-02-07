using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageProgram.Implemantations;


namespace StorageProgram
{
    public partial class LoginMenuFrm : MetroFramework.Forms.MetroForm
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new Database.DatabaseStorage());

        public LoginMenuFrm()
        {

            InitializeComponent();
            LoginNameTxb.Text = 1.ToString();
            LoginPasswordTxb.Text = 1.ToString();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            CreateAccountFrm createAccountFrm = new CreateAccountFrm();
            createAccountFrm.Show();
        }

        private void LoginAccountBtn_Click(object sender, EventArgs e)
        {
            if (_unitOfWork.Users.Login(LoginNameTxb.Text, LoginPasswordTxb.Text) != null)
            {
                this.Hide();
                MainMenuFrm mainMenuFrm = new MainMenuFrm();
                mainMenuFrm.Show();
            }
            else
                MessageBox.Show("Špatně zadané údaje.");
        }
    }
}
