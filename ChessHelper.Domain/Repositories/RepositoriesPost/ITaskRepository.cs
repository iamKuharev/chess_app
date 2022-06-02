using ChessHelper.Domain.Entities.EntitiesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesPost
{
    public interface ITaskRepository
    {
        Entities.EntitiesPost.Task GetTask(int id);

        IList<Entities.EntitiesPost.Task> GetAllTask();

        Task<bool> AddTask(Entities.EntitiesPost.Task task);

        Task<bool> UpdateTask(Entities.EntitiesPost.Task task);

        Task<bool> DeleteTask(int id);
    }
}
