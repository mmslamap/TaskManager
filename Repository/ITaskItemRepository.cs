namespace TaskManager.Repository
{
    using TaskManager.Models;
    public interface ITaskItemRepository
    {
        Task<TaskItem> GetTaskByIdAsync(int id);
        Task<IEnumerable<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> AddTaskAsync(TaskItem taskItem);
        Task UpdateTaskAsync(TaskItem taskItem);
        Task DeleteTaskAsync(int id);
    }
}
