using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services;
using Xunit.Sdk;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskItemController : ControllerBase
    {
        private readonly ITaskItemService _taskItemService;

        public TaskItemController(ITaskItemService taskItemService)
        {
            _taskItemService = taskItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTaskItemsAsync()
        {
            var taskItems = await _taskItemService.GetAllTaskItemsAsync();

            return Ok(taskItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskItemByIdAsync(int id)
        {
            try
            {
                var taskItem = await _taskItemService.GetTaskItemByIdAsync(id);

                return Ok(taskItem);
            }
            catch (Exception e)
            {  
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddTaskItemAsync([FromBody] TaskItem task)
        {
            var newTaskItem = await _taskItemService.AddTaskItemAsync(task);

            return Ok(newTaskItem);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTaskItemAsync([FromBody] TaskItem task)
        {
            try
            {
                var updatedTaskItem = await _taskItemService.UpdateTaskItemAsync(task);
                return Ok(updatedTaskItem);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskItemAsync(int id)
        {
            var result = await _taskItemService.DeleteTaskItemAsync(id);

            if (result)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
