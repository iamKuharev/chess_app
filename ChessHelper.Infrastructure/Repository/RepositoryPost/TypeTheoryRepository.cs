using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class TypeTheoryRepository : ITypeTheoryRepository
    {
        private PostContext DbContext;
        public TypeTheoryRepository(PostContext context)
        {
            DbContext = context;
        }

        public bool AddTypeTheory(TypeTheory theory)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTypeTheory(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TypeTheory> GetAllTypeTheory()
        {
            return DbContext.TypeTheories.ToList();
        }

        public TypeTheory GetTypeTheory(int id)
        {
            return DbContext.TypeTheories.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateTypeTheory(TypeTheory theory)
        {
            throw new NotImplementedException();
        }
    }
}
