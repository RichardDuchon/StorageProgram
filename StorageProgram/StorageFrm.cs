using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using StorageProgram.Implemantations;
using StorageProgram.Interfaces;

namespace StorageProgram
{
    public partial class StorageFrm : MetroFramework.Forms.MetroForm
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new Database.DatabaseForStorage());

        public StorageFrm()
        {
            InitializeComponent();
        }

        private void StorageFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wkL3rf6tSaDataSet.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter.Fill(this.wkL3rf6tSaDataSet.Storage);
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            CreateNewItemFrm createNewItemFrm = new CreateNewItemFrm(this);
            createNewItemFrm.Show();
        }

        public void LoadToDataGridView()
        {
            storageBindingSource3.DataSource = _unitOfWork.Storage.GetAll();
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteItemConfirmation = MessageBox.Show("Opravdu chcete tyto položky vymazat?", "Smazat položky", MessageBoxButtons.YesNo);

            if (StorageDgv.SelectedRows.Count > 0)
            {
                if (deleteItemConfirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in StorageDgv.SelectedRows)
                    {
                        _unitOfWork.Storage.Remove(_unitOfWork.Storage.GetById(Convert.ToInt32(row.Cells["itemIdDataGridViewTextBoxColumn"].Value)));
                        StorageDgv.Rows.RemoveAt(row.Index);
                    }
                    _unitOfWork.Complete();
                }
            }
        }

        private void StorageDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editItem = _unitOfWork.Storage.GetById(Convert.ToInt32(StorageDgv.CurrentRow.Cells["itemIdDataGridViewTextBoxColumn"].Value));
            editItem.ItemName = StorageDgv.CurrentRow.Cells["itemNameDataGridViewTextBoxColumn"].Value.ToString();
            editItem.ItemDescription = StorageDgv.CurrentRow.Cells["itemDescriptionDataGridViewTextBoxColumn"].Value.ToString();
            _unitOfWork.Complete();
        }
    }
}
