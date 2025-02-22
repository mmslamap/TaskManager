
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Repository
{
    public class TaskItemRepository : ITaskItemRepository
    {
        private readonly ApplicationDbContext _context;
        public TaskItemRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<TaskItem> AddTaskItemAsync(TaskItem taskItem)
        {
            if (taskItem == null) 
            { 
                throw new ArgumentNullException(nameof(taskItem));
            }

            await _context.TaskItems.AddAsync(taskItem);
            await _context.SaveChangesAsync();

            return taskItem;
        }

        public async Task DeleteTaskItemAsync(int id)
        {
            var taskItem = await _context.TaskItems.FindAsync(id);
            if (taskItem != null)
            {
                _context.TaskItems.Remove(taskItem);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Task not found");
            }
        }

        public async Task<IEnumerable<TaskItem>> GetAllTaskItemsAsync()
        {
            return await _context.TaskItems.ToListAsync();
        }

        public async Task<TaskItem> GetTaskItemByIdAsync(int id)
        {
            var taskItem = await _context.TaskItems.FindAsync(id);

            if (taskItem == null)
            {
                throw new InvalidOperationException("Task not found");
            }

            return taskItem;
        }

        public Task<TaskItem> UpdateTaskItemAsync(TaskItem task)
        {
            var checkTaskItem = _context.TaskItems.Find(task.Id);

            if (checkTaskItem == null)
            {
                throw new InvalidOperationException("Task not found");
            }

            var taskItem = _context.TaskItems.Attach(task);

            return Task.FromResult(taskItem.Entity);
        }
    }
}
