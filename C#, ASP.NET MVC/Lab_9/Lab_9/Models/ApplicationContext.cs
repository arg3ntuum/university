using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab_9.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Immovables> Immovables { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated(); // створюємо базу даних при першому зверненні
        }
    }
}