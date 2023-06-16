using System.ComponentModel.DataAnnotations;

using static TaskBoardApp.Common.EntityValidationConstants.Board;

namespace TaskBoardApp.Data.Entities.Models
{
    public class Board
    {
        public Board()
        {
            Tasks = new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(BoardMaxNameLen)]
        public string Name { get; set; } = null!;

        public ICollection<Task> Tasks { get; set; }
    }
}
