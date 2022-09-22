using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class TheoryRepository : ITheoryRepository
    {
        private PostContext DbContext;
        public TheoryRepository(PostContext context)
        {
            DbContext = context;
        }

        public IList<Theory> GetAllTheory()
        {
            return DbContext.Theories.Include(t => t.TypeTheory).ToList();
        }

        public Theory GetTheory(int id)
        {
            return DbContext.Theories.Include(t => t.TypeTheory).FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> AddTheory(Theory theory)
        {
            try
            {
                await DbContext.Theories.AddAsync(theory);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public async Task<bool> UpdateTheory(Theory theory)
        {
            try
            {
                DbContext.Theories.Update(theory);
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

        public async Task<bool> DeleteTheory(int id)
        {
            Theory user = DbContext.Theories.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.Theories.Remove(user);
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
