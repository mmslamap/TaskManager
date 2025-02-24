using TaskManager.Models;
using TaskManager.Repository;

namespace TaskManager.Services
{
    public class TaskItemService : ITaskItemService
    {
        private readonly ITaskItemRepository _taskItemRepository;
        public TaskItemService(ITaskItemRepository taskItemRepository) 
        {
            _taskItemRepository = taskItemRepository;
        }

        public async Task<TaskItem> AddTaskItemAsync(TaskItem taskItem)
        {
            return await _taskItemRepository.AddTaskItemAsync(taskItem);
        }

        public async Task<bool> DeleteTaskItemAsync(int id)
        {
            var taskItemToDelete = await _taskItemRepository.GetTaskItemByIdAsync(id);

            if (taskItemToDelete == null)
            {
                return false;
            }

            await _taskItemRepository.DeleteTaskItemAsync(id);
            return true;
        }

        public async Task<IEnumerable<TaskItem>> GetAllTaskItemsAsync()
        {
            return await _taskItemRepository.GetAllTaskItemsAsync();
        }

        public async Task<TaskItem?> GetTaskItemByIdAsync(int id)
        {
            try
            {
                return await _taskItemRepository.GetTaskItemByIdAsync(id);
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException(e.Message, e);
            }
        }

        public async Task<TaskItem?> UpdateTaskItemAsync(TaskItem task)
        {
            try
            {
                return await _taskItemRepository.UpdateTaskItemAsync(task);
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException(e.Message, e);
            }
        }
    }
}
