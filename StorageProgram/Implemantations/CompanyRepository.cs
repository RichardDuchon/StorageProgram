using StorageProgram.Database;
using StorageProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProgram.Implemantations
{
    class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(DatabaseStorage databaseStorage) : base(databaseStorage)
        {
        }

        public DatabaseStorage database
        {
            get { return _dbContext as DatabaseStorage; }
        }
    }
}
