using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories;
using ChessHelper.Infrastructure.Repository.RepositoryUser;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace ChessHelper.Infrastructure.Repository
{
    public class UserRepository : DbConRepository, IUserRepository
    {
        public UserRepository(UserContext context) : base(context)
        {
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
            return DbContext.Users.Include(x => x.Role).ToList();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User FindUserByLogin(string login)
        {
            //return usersList.FirstOrDefault(x => x.Login == login);
            throw new NotImplementedException();
        }

        public ClaimsIdentity GetIdentity(string login, string password)
        {
            User user = DbContext.Users.Include(x => x.Role).FirstOrDefault(x => x.Login == login && x.Password == password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Title)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }
    }
}


/*usersList = new List<User>
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
            };*/