using System;
using System.Collections.Generic;
using System.Text;
using ChessHelper.Domain.Entities;

namespace ChessHelper.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int Id);

        IList<User> GetAllUsers();

        bool AddUser(User user);

        bool DeliteUser(int id);
    }
}
