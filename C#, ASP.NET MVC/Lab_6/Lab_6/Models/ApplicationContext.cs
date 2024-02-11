using Microsoft.EntityFrameworkCore;

namespace Lab_6.Models
{

    public class ApplicationContext : DbContext

    {

        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)

        : base(options)

        {

            Database.EnsureCreated(); // створюємо базу даних при першому зверненні

        }
    }
}