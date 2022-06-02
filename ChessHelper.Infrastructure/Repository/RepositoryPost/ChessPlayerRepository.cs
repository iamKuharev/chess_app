using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class ChessPlayerRepository : IChessPlayerRepository
    {
        private PostContext DbContext;
        public ChessPlayerRepository(PostContext context)
        {
            DbContext = context;
        }

        public async Task<bool> AddChessPlayer(ChessPlayer chessPlayer)
        {
            try
            {
                await DbContext.ChessPlayers.AddAsync(chessPlayer);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("\n\n\n"+ex.Message+"\n\n\n");
                Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");

                return false;
            }
        }

        public async Task<bool> DeleteChessPlaeyr(int id)
        {
            ChessPlayer user = await DbContext.ChessPlayers.FirstOrDefaultAsync(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.ChessPlayers.Remove(user);
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

        public IList<ChessPlayer> GetAllChessPlayers()
        { 
            return DbContext.ChessPlayers.ToList();
        }

        public ChessPlayer GetChessPlayer(int id)
        {
            return DbContext.ChessPlayers.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> UpdateChessPlayer(ChessPlayer chessPlayer)
        {
            try
            {
                DbContext.ChessPlayers.Update(chessPlayer);
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
    }
}
