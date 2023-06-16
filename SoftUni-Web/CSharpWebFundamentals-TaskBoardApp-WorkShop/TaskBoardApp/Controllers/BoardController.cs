using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Core.Interfaces;
using TaskBoardApp.Core.ViewModels.Board;

namespace TaskBoardApp.Controllers
{
    [Authorize]
    public class BoardController : Controller
    {
        private readonly IBoardService boardService;

        public BoardController(IBoardService boardService)
        {
            this.boardService = boardService;
        }


        public async Task<IActionResult> All()
        {
            IEnumerable<BoardViewModel> boards = await boardService.GetAllAsync();

            return View(boards);
        }
    }
}
