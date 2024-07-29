// TaskManager.Core/Interfaces/ITaskRepository.cs
using TaskManager.Core.Entities;

namespace TaskManager.Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem> GetByIdAsync(int id);
        Task AddAsync(TaskItem task);
        Task UpdateAsync(TaskItem task);
        Task DeleteAsync(int id);
    }
}
