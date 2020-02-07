using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;


namespace StorageProgram.Interfaces
{
    public interface IUsersRepository : IRepository<User>
    {
        User Login(string userName, string userPassword);
        bool CheckIfNameExist(string nameToCheck);

    }
}
