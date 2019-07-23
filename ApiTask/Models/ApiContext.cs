using Microsoft.EntityFrameworkCore;

namespace ApiTask.Models
{
    public class ApiContext : DbContext
    {
        protected ApiContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Task> Task { get; set; }
    }
    
}
