using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;
using System.Data.Entity;
using StorageProgram.Interfaces;

namespace StorageProgram.Implemantations
{
    class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DatabaseStorage databaseStorage) : base(databaseStorage)
        {
        }

        public DatabaseStorage database
        {
            get { return _dbContext as DatabaseStorage; }
        }
    }
}
