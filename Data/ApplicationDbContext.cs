namespace TaskManager.Data
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Models;
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
