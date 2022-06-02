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
    public class VideoLessonRepository : IVideoLessonRepository
    {
        readonly PostContext DbContext;
        public VideoLessonRepository(PostContext context)
        {
            DbContext = context;
        }

        public IList<VideoLesson> GetAllVideoLessons()
        {
            return DbContext.VideoLessons.ToList();
        }

        public VideoLesson GetVideoLesson(int id)
        {
            return DbContext.VideoLessons.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> AddVideoLesson(VideoLesson videoLesson)
        {
            try
            {
                await DbContext.VideoLessons.AddAsync(videoLesson);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public async Task<bool> UpdateVideoLesson(VideoLesson videoLesson)
        {
            try
            {
                DbContext.VideoLessons.Update(videoLesson);
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

        public async Task<bool> DeleteVideoLesson(int id)
        {
            VideoLesson user = DbContext.VideoLessons.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.VideoLessons.Remove(user);
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
