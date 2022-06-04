using ChessHelper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesUser
{
    public interface IRoleRepository
    {
        Role GetRoleUserById(int id);

        Task<bool> SetRoleUserById(int id_User, int Id_Role);
    }
}
