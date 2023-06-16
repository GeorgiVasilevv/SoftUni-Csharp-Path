using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Core.Interfaces;
using TaskBoardApp.Core.ViewModels.Task;
using TaskBoardApp.Extensions;

namespace TaskBoardApp.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly IBoardService boardService;
        private readonly ITaskService taskService;

        public TaskController(IBoardService boardService, ITaskService taskService)
        {
            this.boardService = boardService;
            this.taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TaskFormModel model = new TaskFormModel()
            {
                Boards = await boardService.GetAllForSelectAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Boards = await boardService.GetAllForSelectAsync();
                return View(model);
            }

            bool boardExists = await boardService.ExistsByIdAsync(model.BoardId);

            if (!boardExists)
            {
                ModelState.AddModelError(nameof(model.BoardId), "Selected board does not exist!");

                model.Boards = await boardService.GetAllForSelectAsync();
                return View(model);
            }

            string ownerId = User.GetId();

            await taskService.AddAsync(ownerId, model);

            return this.RedirectToAction("All", "Board");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                TaskDetailsViewModel viewModel =
                    await taskService.GetForDetailsByIdAsync(id);

                return View(viewModel);

            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Board");
            }


        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                TaskEditViewModel model = await taskService.FindByIdAsync(id);

                string ownerId = User.GetId();
                if (ownerId != model.OwnerId)
                {
                    ModelState.AddModelError(nameof(ownerId), "Invalid owner");
                    return RedirectToAction("All", "Board");
                }

                model.Boards = await boardService.GetAllForSelectAsync();

                return View(model);
            }
            catch (Exception)
            {
                return RedirectToAction("All", "Board");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(TaskEditViewModel model, int id)
        {
            try
            {
                await taskService.EditAsync(model, id);

                if (!ModelState.IsValid)
                {
                    model.Boards = await boardService.GetAllForSelectAsync();
                    return View(model);
                }

                string ownerId = User.GetId();
                if (ownerId != model.OwnerId)
                {
                    ModelState.AddModelError(nameof(ownerId), "Invalid owner");
                    return RedirectToAction("All", "Board");
                }

                return RedirectToAction("All", "Board");
            }
            catch (Exception)
            {
                return RedirectToAction("All", "Board");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            TaskViewModel task = await taskService.FindByIdAsyncForDelete(id);

            if (task == null)
            {
                return RedirectToAction("All", "Board");
            }
            string ownerId = User.GetId();
            if (ownerId != task.Owner)
            {
                ModelState.AddModelError(nameof(ownerId), "Invalid owner");
                return RedirectToAction("All", "Board");
            }

            return View(task);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(TaskViewModel model)
        {
            TaskViewModel task = await taskService.FindByIdAsyncForDelete(model.Id);

            if (task == null)
            {
                return RedirectToAction("All", "Board");
            }
            string ownerId = User.GetId();
            if (ownerId != task.Owner)
            {
                ModelState.AddModelError(nameof(ownerId), "Invalid owner");
                return RedirectToAction("All", "Board");
            }

            try
            {
                await taskService.DeleteAsync(task);

                return RedirectToAction("All", "Board");
            }
            catch (Exception)
            {
                return RedirectToAction("All", "Board");
            }

        }
    }
}
