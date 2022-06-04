using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAvatarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAvatarAsync(Avatar avatar)
        {
            throw new NotImplementedException();
        }
    }
}
