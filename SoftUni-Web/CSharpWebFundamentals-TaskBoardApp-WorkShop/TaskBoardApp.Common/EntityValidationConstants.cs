using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoardApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Task
        {
            public const int TaskMaxTitleLen = 70;
            public const int TaskMinTitleLen = 5;

            public const int TaskMaxDescriptionLen = 1000;
            public const int TaskMinDescriptionLen = 10;
        }

        public static class Board
        {
            public const int BoardMaxNameLen = 30;
            public const int BoardMinNameLen = 3;
        }
    }
}
