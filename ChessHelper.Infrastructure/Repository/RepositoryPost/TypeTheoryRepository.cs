using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class TypeTheoryRepository : ITypeTheoryRepository
    {
        private PostContext DbContext;
        public TypeTheoryRepository(PostContext context)
        {
            DbContext = context;
        }

        public IList<TypeTheory> GetAllTypeTheory()
        {
            return DbContext.TypeTheories.ToList();
        }

        public TypeTheory GetTypeTheory(int id)
        {
            return DbContext.TypeTheories.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> AddTypeTheory(TypeTheory typeTheory)
        {
            try
            {
                await DbContext.TypeTheories.AddAsync(typeTheory);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public async Task<bool> UpdateTypeTheory(TypeTheory typeTheory)
        {
            try
            {
                DbContext.TypeTheories.Update(typeTheory);
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

        public async Task<bool> DeleteTypeTheory(int id)
        {
            TypeTheory user = DbContext.TypeTheories.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.TypeTheories.Remove(user);
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
