using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProgram.Database;
using System.Data.Entity;
using StorageProgram.Interfaces;
using System.Windows.Forms;

namespace StorageProgram.Implemantations
{
    class UsersRepository : Repository<User>, IUsersRepository
    {
        public UsersRepository(DatabaseStorage databaseStorage) : base(databaseStorage)
        {
        }


        public DatabaseStorage database
        {
            get { return _dbContext as DatabaseStorage; }
        }

        public bool CheckIfNameExist(string nameToCheck)
        {
            return database.Users.Any(name => name.UsersUsername == nameToCheck);
        }

        public User Login(string userName, string userPassword)
        {
             return database.Users.SingleOrDefault(log => log.UsersUsername == userName && log.UsersPassword == userPassword);
        }

    }
}
