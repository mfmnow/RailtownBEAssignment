using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mfm.RailtownAi.Data.Services
{
    public class TestDbContext : DbContext, ITestDbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }

        public void EnsureCreated()
        {
            Database.EnsureCreated();
        }

        public DbSet<TestEntity> TestModels { get; set; }
        public DbSet<UserEntity> UserEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEntity>().ToTable("TestModel");
        }
    }
}

