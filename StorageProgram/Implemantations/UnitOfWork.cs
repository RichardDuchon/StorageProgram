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
        //private readonly DatabaseStorage _databaseStorage;
        private readonly DatabaseForStorage _databaseForStorage;

        public UnitOfWork(DatabaseForStorage databaseStorage)
        {
            _databaseForStorage = databaseStorage;
            Storage = new StorageRepository(_databaseForStorage);
            Users = new UsersRepository(_databaseForStorage);
            Invoice = new InvoiceRepository(_databaseForStorage);
            ItemsInStockDelivery = new ItemsInStockDeliveryRepository(_databaseForStorage);
            DeliveryNote = new DeliveryNoteRepository(_databaseForStorage);
            Company = new CompanyRepository(_databaseForStorage);
        }

        public IInvoiceRepository Invoice { get; private set; }
        public IStorageRepository Storage { get; private set; }
        public IUsersRepository Users { get; private set; }
        public IItemsInStockDeliveryRepository ItemsInStockDelivery { get; private set; }
        public IDeliveryNoteRepository DeliveryNote { get; private set; }
        public ICompanyRepository Company { get; private set; }

        public int Complete()
        {
            return _databaseForStorage.SaveChanges();
        }

        public void Dispose()
        {
            _databaseForStorage.Dispose();
        }
    }
}
