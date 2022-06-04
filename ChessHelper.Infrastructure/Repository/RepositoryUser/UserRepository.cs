using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories;
using ChessHelper.Infrastructure.Repository.RepositoryUser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            return DbContext.User.FirstOrDefault(x => x.Login == login);
        }

        public IList<User> GetAllUsers()
        {
            return DbContext.User.ToList();
        }

        public User GetUser(int id)
        {
            return DbContext.User.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
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
    }
}
