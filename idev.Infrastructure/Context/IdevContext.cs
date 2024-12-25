using idev.Domain.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace idev.Infrastructure.Context
{
    public class IdevContext : DbContext
    {
        // Constructor to pass options
        public IdevContext(DbContextOptions<IdevContext> options) : base(options) { }

        // DBSets for your Entities
        public DbSet<TaskManager> Tasks { get; set; }
        public DbSet<Status> TaskStatus { get; set; }

        // Config the DB Connection (OnConfiguring is usually for runtime, not migrations)
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                // Replace "YourConnectionString" with your actual connection string or fetch it from configuration
                builder.UseSqlServer("Server=172.18.100.50,1433;Database=MikaTasks;User Id=sa;Password=1234Qwer@;Encrypt=False;");
            }
        }

        // Fluent API Config 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Entity Working ...
            modelBuilder.Entity<TaskManager>().OwnsOne(one => one.Status);

            base.OnModelCreating(modelBuilder);
        }
    }

    // Design-Time DbContext Factory for migrations
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IdevContext>
    {
        public IdevContext CreateDbContext(string[] args)
        {
            // Use a new instance of DbContextOptionsBuilder to configure the context at design time
            var optionsBuilder = new DbContextOptionsBuilder<IdevContext>();

            // Use the same connection string here, or use environment variables, or configuration
            optionsBuilder.UseSqlServer("Server=172.18.100.50,1433;Database=MikaTasks;User Id=sa;Password=1234Qwer@;Encrypt=False;");

            return new IdevContext(optionsBuilder.Options);
        }
    }
}
