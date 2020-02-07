using StorageProgram.Implemantations;
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

namespace StorageProgram
{
    public partial class CreateNewItemFrm : MetroFramework.Forms.MetroForm
    {
        private readonly StorageFrm _storageFrm;

        Storage storage = new Storage();
        UnitOfWork _unitOfWork = new UnitOfWork(new DatabaseStorage());


        public CreateNewItemFrm(StorageFrm storageFrm)
        {
            InitializeComponent();
            _storageFrm = storageFrm;
        }

        private void CreateNewItemBtn_Click(object sender, EventArgs e)
        {
            storage.ItemName = CreateNewItemNameTxb.Text.Trim();
            storage.ItemDescription = CreateNewItemDescriptionTxb.Text.Trim();

            if (string.IsNullOrEmpty(CreateNewItemNameTxb.Text.Trim()))
                MessageBox.Show("Vyplňte prosím název položky.");
            else
            {
                storage.ItemCount = 0;
                storage.ItemPurchasePrice = 0;

                _unitOfWork.Storage.Add(storage);
                _unitOfWork.Complete();
                MessageBox.Show("Položka uložena.");
                _storageFrm.LoadToDataGridView();
                CreateNewItemNameTxb.Clear();
                CreateNewItemDescriptionTxb.Clear();
            }
        }

    }
}
