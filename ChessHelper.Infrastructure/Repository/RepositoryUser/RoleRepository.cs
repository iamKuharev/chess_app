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
    public class RoleRepository : DbConRepository, IRoleRepository
    {
        public RoleRepository(UserContext context) : base(context)
        {
        }

        public Role GetRoleUserById(int id)
        {
            return DbContext.Roles.FirstOrDefault(x => x.Id == DbContext.Users.FirstOrDefault(p => p.Id == id).RoleId);
        }

        public async Task<bool> SetRoleUserById(int id_User, int Id_Role)
        {
            User user = DbContext.Users.FirstOrDefault(p => p.Id == id_User);
            Role role = DbContext.Roles.FirstOrDefault(p => p.Id == Id_Role);

            if (user != null && role != null)
            {
                try
                {
                    user.RoleId = Id_Role;
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
    }
}
