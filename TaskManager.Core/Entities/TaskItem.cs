// TaskManager.Core/Entities/TaskItem.cs
namespace TaskManager.Core.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool IsComplete { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
