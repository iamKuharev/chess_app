using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities.EntitiesPost;

namespace ChessHelper.Domain.Repositories.RepositoriesPost
{
    public interface IVideoLessonRepository
    {
        VideoLesson GetVideoLesson(int id);

        IList<VideoLesson> GetAllVideoLessons();

        Task<bool> AddVideoLesson(VideoLesson videoLesson);

        Task<bool> UpdateVideoLesson(VideoLesson videoLesson);

        Task<bool> DeleteVideoLesson(int id);
    }
}
