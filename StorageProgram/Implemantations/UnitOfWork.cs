using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;
using System.Data.Entity;
using StorageProgram.Implemantations;
using StorageProgram.Interfaces;

namespace StorageProgram.Implemantations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseStorage _databaseStorage;

        public UnitOfWork(DatabaseStorage databaseStorage)
        {
            _databaseStorage = databaseStorage;
            Storage = new StorageRepository(_databaseStorage);
            Users = new UsersRepository(_databaseStorage);
            Invoice = new InvoiceRepository(_databaseStorage);
            ItemsInStockDelivery = new ItemsInStockDeliveryRepository(_databaseStorage);
            DeliveryNote = new DeliveryNoteRepository(_databaseStorage);
        }

        public IInvoiceRepository Invoice { get; private set; }
        public IStorageRepository Storage { get; private set; }
        public IUsersRepository Users { get; private set; }
        public IItemsInStockDeliveryRepository ItemsInStockDelivery { get; private set; }
        public IDeliveryNoteRepository DeliveryNote { get; private set; }

        public int Complete()
        {
            return _databaseStorage.SaveChanges();
        }

        public void Dispose()
        {
            _databaseStorage.Dispose();
        }
    }
}
