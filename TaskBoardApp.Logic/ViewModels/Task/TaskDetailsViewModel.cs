using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardApp.Core.ViewModels.Task
{
    public class TaskDetailsViewModel : TaskViewModel
    {
        public string CreatedOn { get; init; } = null!;
        public string Board { get; set; }
    }
}
