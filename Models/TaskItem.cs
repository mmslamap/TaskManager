using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public TaskItem()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
