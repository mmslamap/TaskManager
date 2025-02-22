namespace TaskManager.Repository
{
    using TaskManager.Models;
    public interface ITaskItemRepository
    {
        Task<TaskItem> GetTaskItemByIdAsync(int id);
        Task<IEnumerable<TaskItem>> GetAllTaskItemsAsync();
        Task<TaskItem> AddTaskItemAsync(TaskItem taskItem);
        Task<TaskItem> UpdateTaskItemAsync(TaskItem taskItem);
        Task DeleteTaskItemAsync(int id);
    }
}
