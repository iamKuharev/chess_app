using ChessHelper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);

        User FindUserByLogin(string login);

        IList<User> GetAllUsers();

        bool AddUser(User user);
        
        bool DeliteUser(int id);


    }
}
