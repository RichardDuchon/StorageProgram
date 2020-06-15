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
        public InvoiceRepository(DatabaseForStorage databaseForStorage) : base(databaseForStorage)
        {
        }

        public DatabaseForStorage database
        {
            get { return _dbContext as DatabaseForStorage; }
        }
    }
}
