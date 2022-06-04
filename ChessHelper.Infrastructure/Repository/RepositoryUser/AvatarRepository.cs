using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryUser
{
    public class AvatarRepository : IAvatarRepository
    {
        private readonly UserContext DbContext;

        public AvatarRepository(UserContext context)
        {
            DbContext = context;
        }

        public IList<Avatar> GetAllAvatars()
        {
            return DbContext.Avatars.ToList();
        }

        public Avatar GetAvatar(int id)
        {
            return DbContext.Avatars.FirstOrDefault(p => p.Id == id);
        }

        public Task<bool> AddAvatarAsync(Avatar avatar)
        {
            try
            {
                await DbContext.Avatars.AddAsync(avatar);
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

        public async Task<bool> DeleteAvatarAsync(int id)
        {
            Avatar avatar = DbContext.Avatars.FirstOrDefault(p => p.Id == id);
            if (avatar != null)
            {
                try
                {
                    DbContext.Avatars.Remove(avatar);
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

        public async Task<bool> UpdateAvatarAsync(Avatar avatar)
        {
            try
            {
                DbContext.Avatars.Update(avatar);
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
