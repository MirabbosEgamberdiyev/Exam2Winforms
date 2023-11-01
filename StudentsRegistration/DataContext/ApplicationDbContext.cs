using Microsoft.EntityFrameworkCore;
using StudentsRegistration.Models;

namespace StudentsRegistration.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection
            const string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; Database=StudentRegister;";
         
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Student> Students { get; set; }

    }
}