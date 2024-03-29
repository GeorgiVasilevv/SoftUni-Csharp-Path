﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardApp.Core.ViewModels.Task;

namespace TaskBoardApp.Core.ViewModels.Board
{
    public class BoardViewModel
    {
        public BoardViewModel()
        {
            Tasks = new HashSet<TaskViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<TaskViewModel> Tasks { get; set; }

    }
}
