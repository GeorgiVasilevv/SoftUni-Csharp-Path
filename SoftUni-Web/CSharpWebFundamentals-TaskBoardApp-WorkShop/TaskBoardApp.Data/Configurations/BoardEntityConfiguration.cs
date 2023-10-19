using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardApp.Data.Entities.Models;

namespace TaskBoardApp.Data.Configurations
{
    internal class BoardEntityConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.HasData(this.GenerateBoards());
        }

        private ICollection<Board> GenerateBoards()
        {
            ICollection<Board> boards = new HashSet<Board>()
            {
                new Board()
                {
                    Id = 1,
                    Name = "Open",
                },
                new Board()
                {
                    Id = 2,
                    Name = "In Progress"
                },
                new Board()
                {
                    Id = 3,
                    Name = "Done"
                }
            };

            return boards;
        }
    }
}
