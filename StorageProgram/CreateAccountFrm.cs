using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageProgram.Database;
using StorageProgram.Implemantations;

namespace StorageProgram
{
    public partial class CreateAccountFrm : MetroFramework.Forms.MetroForm
    {
        Users user = new Users();
        UnitOfWork _unitOfWork = new UnitOfWork(new DatabaseForStorage());


        public CreateAccountFrm()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            user.UsersUsername = AccountNameTxb.Text.Trim();
            user.UsersPassword = AccountPasswordAgainTxb.Text.Trim();

            if (_unitOfWork.Users.CheckIfNameExist(AccountNameTxb.Text.Trim()))
                MessageBox.Show("Toto jméno už někdo používá.");
            else if (AccountPasswordTxb.Text != AccountPasswordAgainTxb.Text)
                MessageBox.Show("Hesla se neshodují.");
            else if(string.IsNullOrEmpty(AccountNameTxb.Text.Trim()))
                MessageBox.Show("Vyplňte jméno.");
            else if(string.IsNullOrEmpty(AccountPasswordTxb.Text.Trim()))
                MessageBox.Show("Vyplňte heslo.");
            else
            {
                _unitOfWork.Users.Add(user);
                _unitOfWork.Complete();
                MessageBox.Show("Váš účet byl úspěšně vytvořen.");
                AccountNameTxb.Clear();
                AccountPasswordTxb.Clear();
                AccountPasswordAgainTxb.Clear();
            }

        }
    }
}
