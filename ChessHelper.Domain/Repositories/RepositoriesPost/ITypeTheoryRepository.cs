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

        Task<bool> AddTypeTheory(TypeTheory theory);

        Task<bool> UpdateTypeTheory(TypeTheory theory);

        Task<bool> DeleteTypeTheory(int id);
    }
}
