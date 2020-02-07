using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;

namespace StorageProgram.Interfaces
{
    public interface IItemsInStockDeliveryRepository : IRepository<ItemsInStockDelivery>
    {
        void AddItemToDelivery(int itemToTake, string OrderOrDelivery, int designationOfDelivery, int deliveryNoteIdToTake);
        void DeleteItemFromDelivery(int itemToTake, int deliveryNoteIdToTake);
        void AddItemsToStorageFromOrder(int idToTake);
        List<ItemsInStockDelivery> ReturnSortedByDeliveryId(int idToTake);

    }
}
