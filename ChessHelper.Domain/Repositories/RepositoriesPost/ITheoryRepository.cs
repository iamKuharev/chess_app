using ChessHelper.Domain.Entities.EntitiesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesPost
{
    public interface ITheoryRepository
    {
        Theory GetTheory(int id);

        IList<Theory> GetAllTheory();

        bool AddTheory(Theory theory);

        bool UpdateTheory(Theory theory);

        bool DeleteTheory(int id);
    }
}
