using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTask.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
    
}
