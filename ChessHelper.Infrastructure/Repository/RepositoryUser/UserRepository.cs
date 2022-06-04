using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories;
using ChessHelper.Infrastructure.Repository.RepositoryUser;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace ChessHelper.Infrastructure.Repository
{
    public class UserRepository : DbConRepository, IUserRepository
    {
        public UserRepository(UserContext context) : base(context)
<<<<<<< HEAD
        {
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                await DbContext.User.AddAsync(user);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                return false;
            }
        }

        public async Task<bool> DeliteUserAsync(int id)
=======
        {
        }

        public bool AddUser(User user)
>>>>>>> AddAuth
        {
            User user = DbContext.User.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.User.Remove(user);
                    await DbContext.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                    Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public User FindUserByLogin(string login)
        {
            return DbContext.User.Include(u => u.Avatar)
                                 .Include(u => u.Rank)
                                 .Include(u => u.Role)
                                 .FirstOrDefault(x => x.Login == login);
        }

        public IList<User> GetAllUsers()
        {
<<<<<<< HEAD
            return DbContext.User.Include(u => u.Avatar)
                                 .Include(u => u.Rank)
                                 .Include(u => u.Role)
                                 .ToList();
=======
            return DbContext.Users.Include(x => x.Role).ToList();
>>>>>>> AddAuth
        }

        public User GetUser(int id)
        {
<<<<<<< HEAD
            return DbContext.User.Include(u => u.Avatar)
                                 .Include(u => u.Rank)
                                 .Include(u => u.Role)
                                 .FirstOrDefault(x => x.Id == id);
=======
            throw new NotImplementedException();
>>>>>>> AddAuth
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
<<<<<<< HEAD
            try
            {
                DbContext.User.Update(user);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                return false;
            }
        }
=======
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
>>>>>>> AddAuth
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