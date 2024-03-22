using MeowLab.Models;
using Microsoft.EntityFrameworkCore;

namespace MeowLab
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Добавление начальных данных для сущности Person
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Alex", Surname = "Green", Age = 30, Birthday = new DateTime(1992, 1, 15) },
                new Person { Id = 2, Name = "Kira", Surname = "Fox", Age = 25, Birthday = new DateTime(1997, 5, 20) }
            );
        }
    }
}
