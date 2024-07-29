// TaskManager.Application/Services/TaskService.cs
using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;

namespace TaskManager.Application.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<TaskItem>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllAsync();
        }

        public async Task<TaskItem> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetByIdAsync(id);
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            await _taskRepository.AddAsync(task);
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            await _taskRepository.UpdateAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteAsync(id);
        }
    }
}
