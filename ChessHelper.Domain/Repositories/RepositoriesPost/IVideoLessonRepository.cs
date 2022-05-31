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

        bool AddVideoLesson(VideoLesson videoLesson);

        bool UpdateVideoLesson(VideoLesson videoLesson);

        bool DeleteVideoLesson(int id);
    }
}
