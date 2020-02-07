using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;
using StorageProgram.Interfaces;
using Microsoft.VisualBasic;



namespace StorageProgram.Implemantations
{
    class ItemsInStockDeliveryRepository : Repository<ItemsInStockDelivery>, IItemsInStockDeliveryRepository
    {
        public ItemsInStockDeliveryRepository(DatabaseStorage databaseStorage) : base(databaseStorage)
        {
        }

        public DatabaseStorage database
        {
            get { return _dbContext as DatabaseStorage; }
        }

        public void AddItemsToStorageFromOrder(int idToTake)
        {
            var item = database.ItemsInStockDeliveries.Where(ip => ip.ItemInDeliveryFromDeliveryNote == idToTake).ToList();

            foreach (var itemtoAdd in item)
            {
                if (itemtoAdd.ItemInDeliveryOrderOrDelivery == "Objednávka.")
                {
                    var storageToAdd = database.Storages.First(i => i.ItemId == itemtoAdd.ItemInDeliveryFromItemInStockId);
                    storageToAdd.ItemCount += itemtoAdd.ItemInDeliveryCount;
                }
            }
        }

        public void AddItemToDelivery(int itemToTake, string OrderOrDelivery, int designationOfDelivery, int deliveryNoteIdToTake)
        {
            ItemsInStockDelivery itemsInStockDelivery = new ItemsInStockDelivery();
            var deliveryCount = Interaction.InputBox("Kolik kusů?", "Počet", 0.ToString());
            var sellPrice = Interaction.InputBox("Jaká bude cena?", "Cena", 0.ToString());

            var item = database.Storages.Where(it => it.ItemId == itemToTake).ToList();
            var deliveryOrOrderNote = database.DeliveryNotes.First(note => note.DeliveryNoteId == deliveryNoteIdToTake);

            foreach (var newItem in item)
            {
                itemsInStockDelivery.ItemInDeliveryName = newItem.ItemName;
                itemsInStockDelivery.ItemInDeliveryFromItemInStockId = newItem.ItemId;
                itemsInStockDelivery.ItemInDeliveryDescription = newItem.ItemDescription;
                itemsInStockDelivery.ItemInDeliverySellPrice = Convert.ToInt32(sellPrice);
                itemsInStockDelivery.ItemInDeliveryCount = Convert.ToInt32(deliveryCount);
                itemsInStockDelivery.ItemInDeliveryFromDeliveryNote = designationOfDelivery;
                itemsInStockDelivery.ItemInDeliveryOrderOrDelivery = OrderOrDelivery;

                if (itemsInStockDelivery.ItemInDeliveryOrderOrDelivery == "Dodávka.")
                {
                    newItem.ItemCount -= Convert.ToInt32(deliveryCount);
                }

                deliveryOrOrderNote.DeliveryNoteCount += Convert.ToInt32(sellPrice);
                database.ItemsInStockDeliveries.Add(itemsInStockDelivery);
            }
        }

        public void DeleteItemFromDelivery(int itemToTake, int deliveryNoteIdToTake)
        {
            var item = database.ItemsInStockDeliveries.Where(it => it.ItemInDeliveryId == itemToTake).ToList();
            var deliveryOrOrderNote = database.DeliveryNotes.First(note => note.DeliveryNoteId == deliveryNoteIdToTake);


            foreach (var itemToDelete in item)
            {
                if (itemToDelete.ItemInDeliveryOrderOrDelivery == "Dodávka.")
                {
                    var storageToCountUpAfterDelete = database.Storages.First(i => i.ItemId == itemToDelete.ItemInDeliveryFromItemInStockId);
                    storageToCountUpAfterDelete.ItemCount += itemToDelete.ItemInDeliveryCount;
                }

                deliveryOrOrderNote.DeliveryNoteCount -= Convert.ToInt32(itemToDelete.ItemInDeliverySellPrice);
                database.ItemsInStockDeliveries.Remove(itemToDelete);
            }
        }

        public List<ItemsInStockDelivery> ReturnSortedByDeliveryId(int idToTake)
        {
            return database.ItemsInStockDeliveries.Where(item => item.ItemInDeliveryFromDeliveryNote == idToTake).ToList();

        }
    }
}
