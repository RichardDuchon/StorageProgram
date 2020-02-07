using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;

namespace StorageProgram.Interfaces
{
    public interface IStorageRepository : IRepository<Storage>
    {
        Storage GetMostInStock(int most);
    }
}
