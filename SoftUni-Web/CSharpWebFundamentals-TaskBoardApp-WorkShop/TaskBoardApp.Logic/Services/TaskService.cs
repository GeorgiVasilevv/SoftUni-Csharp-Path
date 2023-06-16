using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Core.Interfaces;
using TaskBoardApp.Core.ViewModels.Task;
using TaskBoardApp.Data.Entities;

namespace TaskBoardApp.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskBoardAppDbContext dbContext;

        public TaskService(TaskBoardAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async System.Threading.Tasks.Task AddAsync(string ownerId, TaskFormModel viewModel)
        {
            Data.Entities.Models.Task task = new Data.Entities.Models.Task()
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                BoardId = viewModel.BoardId,
                CreatedOn = DateTime.UtcNow,
                OwnerId = ownerId
            };

            await dbContext.Tasks.AddAsync(task);
            await dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(TaskViewModel viewModel)
        {
            Data.Entities.Models.Task task = await dbContext
                .Tasks
                .Where(t=> t.Id == viewModel.Id)
                .FirstOrDefaultAsync();

            dbContext.Remove(task);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(TaskEditViewModel viewModel, int id)
        {
            Data.Entities.Models.Task model = await dbContext
                .Tasks
                .Where(t => t.Id == id)
                .FirstAsync();

            model.Title = viewModel.Title;
            model.Description = viewModel.Description;
            model.BoardId = viewModel.BoardId;

            await dbContext.SaveChangesAsync();

        }

        public async Task<TaskEditViewModel> FindByIdAsync(int id)
        {
            TaskEditViewModel model = await dbContext
                .Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskEditViewModel()
                {
                    OwnerId = t.OwnerId,
                    Title = t.Title,
                    Description = t.Description,
                    BoardId = t.BoardId,
                })
                .FirstAsync();

            return model;
        }

        public async Task<TaskViewModel> FindByIdAsyncForDelete(int id)
        {
            TaskViewModel? model = await dbContext
                .Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskViewModel()
                {
                    Owner = t.OwnerId,
                    Title = t.Title,
                    Id = id,
                    Description = t.Description,
                })
                .FirstOrDefaultAsync();

            return model;
        }

        public async Task<TaskDetailsViewModel> GetForDetailsByIdAsync(int id)
        {
            TaskDetailsViewModel modelForView = await dbContext
                .Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskDetailsViewModel()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                    Board = t.Board.Name,
                    Owner = t.Owner.UserName
                })
                .FirstAsync();

            return modelForView;
        }
    }
}
