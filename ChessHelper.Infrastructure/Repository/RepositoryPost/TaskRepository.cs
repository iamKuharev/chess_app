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
    public class TaskRepository : ITaskRepository
    {
        private PostContext DbContext;
        public TaskRepository(PostContext context)
        {
            DbContext = context;
        }

        public IList<Domain.Entities.EntitiesPost.Task> GetAllTask()
        {
            return DbContext.Tasks.Include(t => t.Theory).ToList();
        }

        public Domain.Entities.EntitiesPost.Task GetTask(int id)
        {
            return DbContext.Tasks.Include(t => t.Theory).FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> AddTask(Domain.Entities.EntitiesPost.Task task)
        {
            try
            {
                await DbContext.Tasks.AddAsync(task);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public async Task<bool> UpdateTask(Domain.Entities.EntitiesPost.Task task)
        {
            try
            {
                DbContext.Tasks.Update(task);
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

        public async Task<bool> DeleteTask(int id)
        {
            Domain.Entities.EntitiesPost.Task user = DbContext.Tasks.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.Tasks.Remove(user);
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
