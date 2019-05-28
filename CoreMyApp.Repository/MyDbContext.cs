using System;
using CoreMyApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreMyApp.Repository
{
    public class MyDbContext : DbContext
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