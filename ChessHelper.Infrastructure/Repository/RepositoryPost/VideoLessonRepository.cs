using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class VideoLessonRepository : IVideoLessonRepository
    {
        readonly PostContext DbContext;
        public VideoLessonRepository(PostContext context)
        {
            DbContext = context;
        }

        public bool AddVideoLesson(VideoLesson videoLesson)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVideoLesson(int id)
        {
            throw new NotImplementedException();
        }

        public IList<VideoLesson> GetAllVideoLessons()
        {
            return DbContext.VideoLessons.ToList();
        }

        public VideoLesson GetVideoLesson(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateVideoLesson(VideoLesson videoLesson)
        {
            throw new NotImplementedException();
        }
    }
}
