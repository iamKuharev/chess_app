using ChessHelper.Domain.Entities.EntitiesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesPost
{
    public interface IPostRepository
    {
        Post GetPost(int id);

        IList<Post> GetAllPost();

        bool AddPost(Post post);

        bool UpdatePost(Post post);

        bool DeletePost(int id);
    }
}
