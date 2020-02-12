using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProgram.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStorageRepository Storage { get; }
        IUsersRepository Users { get; }
        IInvoiceRepository Invoice { get; }
        IItemsInStockDeliveryRepository ItemsInStockDelivery { get; }
        IDeliveryNoteRepository DeliveryNote { get; }
        ICompanyRepository Company { get; }
        int Complete();
    }
}
