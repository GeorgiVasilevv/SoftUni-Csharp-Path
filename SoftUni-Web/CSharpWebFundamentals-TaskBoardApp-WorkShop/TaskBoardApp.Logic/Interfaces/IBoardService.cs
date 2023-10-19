using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardApp.Core.ViewModels.Board;

namespace TaskBoardApp.Core.Interfaces
{
    public interface IBoardService
    {
        Task<IEnumerable<BoardViewModel>> GetAllAsync();
        Task<IEnumerable<BoardSelectViewModel>> GetAllForSelectAsync();
        Task<bool> ExistsByIdAsync(int id);
    }
}
