using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessHelper.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> usersList;

        public UserRepository()
        {
            usersList = new List<User>
            {
                new User
                {
                    Id = 0,
                    Name = "qwe",
                    Surname = "ewq",
                    Login = "1234",
                    Password = "1234",
                    Task_rate = 0,
                    Id_avatar = 0,
                    Id_rank = 0,    
                    Id_role = 0
                },
                new User
                {
                    Id = 1,
                    Name = "qwe",
                    Surname = "ewq",
                    Login = "1234",
                    Password = "1234",
                    Task_rate = 10,
                    Id_avatar = 1,
                    Id_rank = 2,
                    Id_role = 1
                }
            };
        }



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
            return usersList;
        }

        public User GetUser(int id)
        {
            User user = usersList.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public User FindUserByLogin(string login)
        {
            return usersList.FirstOrDefault(x => x.Login == login);
        }
        

        


    }
}
