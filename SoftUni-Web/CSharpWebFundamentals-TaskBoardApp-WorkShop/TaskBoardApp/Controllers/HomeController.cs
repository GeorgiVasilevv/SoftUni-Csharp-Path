using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TaskBoardApp.Core.ViewModels.Home;
using TaskBoardApp.Data.Entities;

namespace TaskBoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskBoardAppDbContext dbContext;

        public HomeController(TaskBoardAppDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }
        public IActionResult Index()
        {
            var taskBoards = dbContext
                .Boards
                .Select(b => b.Name)
                .Distinct();

            var tasksCounts= new List<HomeBoardModel>();
            foreach (var taskBoard in taskBoards)
            {
                var tasksInBoard = dbContext.Tasks.Where(t => t.Board.Name == taskBoard).Count();
                tasksCounts.Add(new HomeBoardModel()
                {
                    BoardName = taskBoard,
                    TasksCount = tasksInBoard
                });
            }

            var userTasksCount = -1;

            if (User.Identity.IsAuthenticated)
            {
                var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                userTasksCount = dbContext.Tasks.Where(t=> t.OwnerId == currentUserId).Count();
            }

            var homeModel = new HomeViewModel()
            {
                AllTasksCount = dbContext.Tasks.Count(),
                BoardsWithTasksCount = tasksCounts,
                UserTasksCount = userTasksCount
            };
            return View(homeModel);
        }
    }
}