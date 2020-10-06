using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;

namespace StorageProgram.Interfaces
{
    public interface IDeliveryNoteRepository : IRepository<DeliveryNote>
    {
        void CreateOrderOrDelivery(string deliveryOrOrder, string companyName, int companyId);

        Tuple<string, int> Return(int itemToTake);
    }
}
