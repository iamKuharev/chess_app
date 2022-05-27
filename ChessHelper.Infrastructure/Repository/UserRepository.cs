using System;
using System.Collections.Generic;
using System.Text;
using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories;

namespace ChessHelper.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeliteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
