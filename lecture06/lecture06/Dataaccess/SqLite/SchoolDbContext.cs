using Lecture06.Entities;
using Microsoft.EntityFrameworkCore;
namespace Lecture06.DataAccess.SqLite;

    public class SchoolDbContext : DbContext {
        public DbSet<Student> Student => Set<Student>();
        public DbSet<Education> Education => Set<Education>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite(@"Data Source = Resources/School.db");
        }
    }
