using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class TheoryRepository : ITheoryRepository
    {
        private PostContext DbContext;
        public TheoryRepository(PostContext context)
        {
            DbContext = context;
        }

        public bool AddTheory(Theory theory)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTheory(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Theory> GetAllTheory()
        {
            return DbContext.Theories.ToList();
        }

        public Theory GetTheory(int id)
        {
            return DbContext.Theories.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateTheory(Theory theory)
        {
            throw new NotImplementedException();
        }
    }
}
