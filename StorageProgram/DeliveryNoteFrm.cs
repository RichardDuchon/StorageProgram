﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Microsoft.VisualBasic;
using StorageProgram.Implemantations;
using StorageProgram.Database;
using System.IO;


namespace StorageProgram
{
    public partial class DeliveryNoteFrm : MetroFramework.Forms.MetroForm
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new DatabaseForStorage());

        int idOfItemFromStorage = 0;
        int deliveryNoteIndication = 0;


        public DeliveryNoteFrm()
        {
            InitializeComponent();
        }

        private void DeliveryNoteFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wkL3rf6tSaDataSet.ItemsInStockDelivery' table. You can move, or remove it, as needed.
            this.itemsInStockDeliveryTableAdapter.Fill(this.wkL3rf6tSaDataSet.ItemsInStockDelivery);
            // TODO: This line of code loads data into the 'wkL3rf6tSaDataSet.DeliveryNote' table. You can move, or remove it, as needed.
            this.deliveryNoteTableAdapter.Fill(this.wkL3rf6tSaDataSet.DeliveryNote);
            // TODO: This line of code loads data into the 'wkL3rf6tSaDataSet.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter.Fill(this.wkL3rf6tSaDataSet.Storage);
        }

        private void RefreshDeliveryNoteDgv()
        {
            deliveryNoteBindingSource2.DataSource = _unitOfWork.DeliveryNote.GetAll();

        }

        private void CreateDeliveryNoteBtn_Click(object sender, EventArgs e)
        {
            //Pokud se změní název "Dodávka." musí se změnit název i v ItemStockDeliveryRepository
            _unitOfWork.DeliveryNote.CreateOrderOrDelivery("Dodávka.");
            _unitOfWork.Complete();
            RefreshDeliveryNoteDgv();
        }

        private void CreateOrderNoteBtn_Click(object sender, EventArgs e)
        {

            //Pokud se změní název "Objednávka." musí se změnit název i v ItemStockDeliveryRepository
            _unitOfWork.DeliveryNote.CreateOrderOrDelivery("Objednávka.");
            _unitOfWork.Complete();
            RefreshDeliveryNoteDgv();
        }

        private void AddItemToDeliveryBtn_Click(object sender, EventArgs e)
        {
            _unitOfWork.ItemsInStockDelivery.AddItemToDelivery(idOfItemFromStorage, _unitOfWork.DeliveryNote.Return(deliveryNoteIndication).Item1,
                _unitOfWork.DeliveryNote.Return(deliveryNoteIndication).Item2, deliveryNoteIndication);
            _unitOfWork.Complete();
            ShowDataInDeliveryStorageNote();
            ShowDataInDeliveryNote();
            ShowDataInStorage();
        }

        private void ShowDataInDeliveryNote()
        {
            deliveryNoteBindingSource2.DataSource = _unitOfWork.DeliveryNote.GetAll();

        }

        private void ShowDataInStorage()
        {
            storageBindingSource2.DataSource = _unitOfWork.Storage.GetAll();
        }

        private void ShowDataInDeliveryStorageNote()
        {
            deliveryNoteIndication = Convert.ToInt32(DeliveryNoteDgv.CurrentRow.Cells["deliveryNoteIdDataGridViewTextBoxColumn"].Value);

            itemsInStockDeliveryBindingSource2.DataSource = _unitOfWork.ItemsInStockDelivery.ReturnSortedByDeliveryId(deliveryNoteIndication);
        }

        private void DeliveryNoteDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataInDeliveryStorageNote();
        }

        private void DeliveryNoteDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataInDeliveryStorageNote();
        }

        private void DeliveryNoteDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataInDeliveryStorageNote();
        }

        private void DeleteDeliveryNoteBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteItemConfirmation = MessageBox.Show("Opravdu chcete smazat tento list?", "Smazat list", MessageBoxButtons.YesNo);

            if (DeliveryNoteDgv.SelectedRows.Count == 1)
            {
                if (deleteItemConfirmation == DialogResult.Yes)
                {
                    if (DeliveryStorageDgv.Rows.Count > 1)
                    {
                        MessageBox.Show("Nelze odstranit list, který obsahuje položky.");
                    }
                    else
                    {
                        foreach (DataGridViewRow row in DeliveryNoteDgv.SelectedRows)
                        {
                            _unitOfWork.DeliveryNote.Remove(_unitOfWork.DeliveryNote.GetById(deliveryNoteIndication));
                            DeliveryNoteDgv.Rows.RemoveAt(row.Index);
                        }
                    }
                    _unitOfWork.Complete();
                }
            }
        }

        private void StorageInDeliveryDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataFromStorage();
        }

        private void StorageInDeliveryDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataFromStorage();
        }
        private void StorageInDeliveryDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataFromStorage();
        }
        private void ShowDataFromStorage()
        {
            var getIdOfItemFromStorage = Convert.ToInt32(StorageInDeliveryDgv.CurrentRow.Cells["itemIdDataGridViewTextBoxColumn"].Value);
            idOfItemFromStorage = getIdOfItemFromStorage;
        }

        private void DeleteItemFromDeliveryBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteItemConfirmation = MessageBox.Show("Opravdu chcete smazat tuto položku?", "Smazat položku", MessageBoxButtons.YesNo);

            if (deleteItemConfirmation == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DeliveryStorageDgv.SelectedRows)
                {
                    _unitOfWork.ItemsInStockDelivery.DeleteItemFromDelivery(Convert.ToInt32(DeliveryStorageDgv.CurrentRow.Cells["itemInDeliveryIdDataGridViewTextBoxColumn"].Value)
                        , deliveryNoteIndication);
                    DeliveryStorageDgv.Rows.RemoveAt(row.Index);
                }
                _unitOfWork.Complete();
                ShowDataInDeliveryStorageNote();
                ShowDataInDeliveryNote();
            }
        }

        private void AddItemsInOrderToStorageBtn_Click(object sender, EventArgs e)
        {
            _unitOfWork.ItemsInStockDelivery.AddItemsToStorageFromOrder(Convert.ToInt32(DeliveryNoteDgv.CurrentRow.Cells["deliveryNoteIdDataGridViewTextBoxColumn"].Value));
            _unitOfWork.Complete();
            ShowDataInStorage();
        }
    }
}
