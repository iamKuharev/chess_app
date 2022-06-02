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
    public class PostRepository : IPostRepository
    {
        private PostContext DbContext;
        public PostRepository(PostContext context)
        {
            DbContext = context;
        }

        public IList<Post> GetAllPost()
        {

            return DbContext.Posts.ToList();
        }

        public Post GetPost(int id)
        {
            return DbContext.Posts.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> AddPost(Post post)
        {
            try
            {
                await DbContext.Posts.AddAsync(post);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public async Task<bool> UpdatePost(Post post)
        {
            try
            {
                DbContext.Posts.Update(post);
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

        public async Task<bool> DeletePost(int id)
        {
            Post user = DbContext.Posts.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.Posts.Remove(user);
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
