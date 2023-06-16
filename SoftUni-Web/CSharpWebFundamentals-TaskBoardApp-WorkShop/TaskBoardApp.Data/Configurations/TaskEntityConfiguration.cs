using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = TaskBoardApp.Data.Entities.Models.Task;

namespace TaskBoardApp.Data.Configurations
{
    internal class TaskEntityConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder
            .HasOne(t => t.Board)
            .WithMany(t => t.Tasks)
            .HasForeignKey(t => t.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.GenerateTasks());
        }

        private ICollection<Task> GenerateTasks()
        {
            ICollection<Task> tasks = new HashSet<Task>()
            {
                new Task()
                {
                    Id = 1,
                    Title = "Improve CSS styles",
                    Description = "Implement better styling for all public pages",
                    CreatedOn = DateTime.UtcNow.AddDays(-200),
                    OwnerId = "be1dcc81-9cce-4795-abd4-12e2ac83934c",
                    BoardId = 1
                },
                 new Task()
                {
                    Id = 2,
                    Title = "Android Client App",
                    Description = "Create Android client App for the RESTful TaskBoard service",
                    CreatedOn = DateTime.UtcNow.AddMonths(-5),
                    OwnerId = "2305ea94-4ac0-4309-b4b9-458d513e4ff4",
                    BoardId = 1
                },
                new Task()
                {
                    Id = 3,
                    Title = "Desktop Client App",
                    Description = "Create Desktop client App for the RESTful TaskBoard service",
                    CreatedOn = DateTime.UtcNow.AddMonths(-1),
                    OwnerId = "be1dcc81-9cce-4795-abd4-12e2ac83934c",
                    BoardId = 2
                },
                new Task()
                {
                    Id = 4,
                    Title = "Create Tasks",
                    Description = "Implement [Create Task] page for adding tasks",
                    CreatedOn = DateTime.UtcNow.AddYears(-1),
                    OwnerId = "2305ea94-4ac0-4309-b4b9-458d513e4ff4",
                    BoardId = 3
                }
            };

            return tasks;
        }
    }
}
