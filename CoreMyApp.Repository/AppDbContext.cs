using App.Core.Repository.DataContext;
using CoreMyApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreMyApp.Repository
{
    public class AppDbContext : BaseDatabaseContext
    {
        //public MyDbContext(DbContextOptions options) : base(options)
        //{
        //}

        private DbSet<Employee> Employee { get; set; }
        private DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql(@"Server=localhost;Database=test;Username=test;Password=123");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}