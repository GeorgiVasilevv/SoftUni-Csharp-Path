using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardApp.Core.ViewModels.Board;
using static TaskBoardApp.Common.EntityValidationConstants.Task;
namespace TaskBoardApp.Core.ViewModels.Task
{
    public class TaskFormModel
    {
        [Required]
        [StringLength(TaskMaxTitleLen, MinimumLength = TaskMinTitleLen, ErrorMessage = "Title should be at least {2} characters long.")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(TaskMaxDescriptionLen, MinimumLength = TaskMinDescriptionLen, ErrorMessage = "Description should be at least {2} characters long.")]
        public string Description { get; set; } = null!;

        [Display(Name = "Board")]
        public int BoardId { get; set; }
        public IEnumerable<BoardSelectViewModel>? Boards { get; set; }
    }
}
