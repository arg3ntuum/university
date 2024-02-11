using Microsoft.EntityFrameworkCore;

namespace Lab_6_2.Models
{

    public class ApplicationContext : DbContext

    {

        public DbSet<Student> Students { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)

        : base(options)

        {

            Database.EnsureCreated(); // створюємо базу даних при першому зверненні

        }
    }
}