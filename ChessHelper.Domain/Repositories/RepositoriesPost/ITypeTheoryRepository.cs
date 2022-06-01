using ChessHelper.Domain.Entities.EntitiesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesPost
{
    public interface ITypeTheoryRepository
    {
        TypeTheory GetTypeTheory(int id);

        IList<TypeTheory> GetAllTypeTheory();

        bool AddTypeTheory(TypeTheory theory);

        bool UpdateTypeTheory(TypeTheory theory);

        bool DeleteTypeTheory(int id);
    }
}
