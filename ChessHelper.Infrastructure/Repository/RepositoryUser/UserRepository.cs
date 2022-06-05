using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Entities.EntitiesGame;
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
        {
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                await DbContext.Users.AddAsync(user);
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
        {
            User user = DbContext.Users.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.Users.Remove(user);
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
            return DbContext.Users.Include(u => u.Avatar)
                                 .Include(u => u.Rank)
                                 .Include(u => u.Role)
                                 .FirstOrDefault(x => x.Login == login);
        }

        public IList<User> GetAllUsers()
        {
            return DbContext.Users.Include(u => u.Avatar)
                                 .Include(u => u.Rank)
                                 .Include(u => u.Role)
                                 .ToList();
        }

        public User GetUser(int id)
        {
            return DbContext.Users.Include(u => u.Avatar)
                                 .Include(u => u.Rank)
                                 .Include(u => u.Role)
                                 .FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {

            try
            {
                DbContext.Users.Update(user);
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


