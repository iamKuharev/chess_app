using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;

namespace ChessHelper.Domain.Repositories.RepositoriesUser
{
    public interface IAvatarRepository
    {
        Avatar GetAvatar(int id);

        IList<Avatar> GetAllAvatars();

        Task<bool> AddAvatarAsync(Avatar avatar);

        Task<bool> UpdateAvatarAsync(Avatar avatar);

        Task<bool> DeleteAvatarAsync(int id);
    }
}
