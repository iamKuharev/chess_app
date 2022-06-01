using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
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

        public bool AddTask(Domain.Entities.EntitiesPost.Task task)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Domain.Entities.EntitiesPost.Task> GetAllTask()
        {
            return DbContext.Tasks.ToList();
        }

        public Domain.Entities.EntitiesPost.Task GetTask(int id)
        {
            return DbContext.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateTask(Domain.Entities.EntitiesPost.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
