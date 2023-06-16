using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardApp.Core.ViewModels.Task;

namespace TaskBoardApp.Core.Interfaces
{
    public interface ITaskService
    {
        Task AddAsync(string ownerId, TaskFormModel viewModel);
        Task<TaskDetailsViewModel> GetForDetailsByIdAsync(int id);
        Task<TaskEditViewModel> FindByIdAsync(int id);
        Task EditAsync(TaskEditViewModel viewModel, int id);
        Task<TaskViewModel> FindByIdAsyncForDelete(int id);
        Task DeleteAsync(TaskViewModel viewModel);
    }
}
