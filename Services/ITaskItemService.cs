using TaskManager.Models;

namespace TaskManager.Services
{
    public interface ITaskItemService
    {
        Task<TaskItem> GetTaskItemByIdAsync(int id);
        Task<IEnumerable<TaskItem>> GetAllTaskItemsAsync();
        Task<TaskItem> AddTaskItemAsync(TaskItem task);
        Task<TaskItem> UpdateTaskItemAsync(TaskItem task);
        Task<bool> DeleteTaskItemAsync(int id);
    }
}
