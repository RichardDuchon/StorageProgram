using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;
using StorageProgram.Interfaces;
using System.Windows.Forms;
using StorageProgram.Implemantations;
using System.Data.Entity;



namespace StorageProgram.Interfaces
{
    class StorageRepository : Repository<Storage>, IStorageRepository
    {
        public StorageRepository(DatabaseStorage databaseStorage) : base(databaseStorage)
        {
        }


        Storage IStorageRepository.GetMostInStock(int most)
        {
            return database.Storages.Include(a => a.ItemId).SingleOrDefault(a => a.ItemId == most);

        }

        public DatabaseStorage database
        {
            get { return _dbContext as DatabaseStorage; }
        }
    }
}
