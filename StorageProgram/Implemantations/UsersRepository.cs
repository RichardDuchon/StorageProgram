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
    class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(DatabaseForStorage databaseForStorage) : base(databaseForStorage)
        {
        }


        public DatabaseForStorage database
        {
            get { return _dbContext as DatabaseForStorage; }
        }

        public bool CheckIfNameExist(string nameToCheck)
        {
            return database.Users.Any(name => name.UsersUsername == nameToCheck);
        }

        public Users Login(string userName, string userPassword)
        {
             return database.Users.SingleOrDefault(log => log.UsersUsername == userName && log.UsersPassword == userPassword);
        }

    }
}
