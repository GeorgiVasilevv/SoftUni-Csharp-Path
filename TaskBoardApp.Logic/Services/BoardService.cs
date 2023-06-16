using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Core.Interfaces;
using TaskBoardApp.Core.ViewModels.Board;
using TaskBoardApp.Core.ViewModels.Task;
using TaskBoardApp.Data.Entities;

namespace TaskBoardApp.Core.Services
{
    public class BoardService : IBoardService
    {
        private readonly TaskBoardAppDbContext dbContext;

        public BoardService(TaskBoardAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            bool exists = await dbContext
                .Boards
                .AnyAsync(b=> b.Id == id);

            return exists;
        }

        public async Task<IEnumerable<BoardViewModel>> GetAllAsync()
        {
            IEnumerable<BoardViewModel> boards = await dbContext.Boards
                .Select(b => new BoardViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Tasks = b.Tasks.Select(t => new TaskViewModel()
                    {
                        Id = t.Id,
                        Title = t.Title,
                        Description = t.Description,
                        Owner = t.Owner.UserName
                    })
                    .ToArray()
                })
                .ToArrayAsync();

            return boards;
        }

        public async Task<IEnumerable<BoardSelectViewModel>> GetAllForSelectAsync()
        {
            IEnumerable<BoardSelectViewModel> boards = await dbContext
                .Boards
                .Select(b => new BoardSelectViewModel()
                {
                    Id = b.Id,
                    Name = b.Name
                })
                .ToArrayAsync();

            return boards;
        }
    }
}
