// TaskManager.Infrastructure/Repositories/TaskRepository.cs
using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using TaskManager.Infrastructure.Data;

namespace TaskManager.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TasksDbContext _dbContext;

        public TaskRepository(TasksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await _dbContext.Tasks.ToListAsync();
        }

        public async Task<TaskItem> GetByIdAsync(int id)
        {
            return await _dbContext.Tasks.FindAsync(id)??new TaskItem();
        }

        public async Task AddAsync(TaskItem task)
        {
            _dbContext.Tasks.Add(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TaskItem task)
        {
            _dbContext.Tasks.Update(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var task = await _dbContext.Tasks.FindAsync(id);
            if (task != null)
            {
                _dbContext.Tasks.Remove(task);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
