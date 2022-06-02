using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
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

        public bool AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Post> GetAllPost()
        {

            return DbContext.Posts.ToList();
        }

        public Post GetPost(int id)
        {
            return DbContext.Posts.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
