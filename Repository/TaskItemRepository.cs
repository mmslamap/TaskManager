
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
        public async Task<TaskItem> AddTaskAsync(TaskItem task)
        {
            return null;
        }

        public async Task DeleteTaskAsync(int id)
        {
        }

        public Task<IEnumerable<TaskItem>> GetAllTasksAsync()
        {
            return null;
        }

        public async Task<TaskItem> GetTaskByIdAsync(int id)
        {
            return null;
        }

        public Task UpdateTaskAsync(TaskItem task)
        {
            return null;
        }
    }
}
