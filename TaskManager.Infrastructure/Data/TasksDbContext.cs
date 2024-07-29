// TaskManager.Infrastructure/Data/TasksDbContext.cs
using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Entities;

namespace TaskManager.Infrastructure.Data
{
    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options)
            : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
