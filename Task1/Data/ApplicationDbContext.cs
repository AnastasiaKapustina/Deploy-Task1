using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Task1.Data;

namespace Mobilography.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MultiplicationResult>().HasData(
                new { Id = Guid.NewGuid(), Result = 4 },
                new { Id = Guid.NewGuid(), Result = 5 },
                new { Id = Guid.NewGuid(), Result = 7 },
                new { Id = Guid.NewGuid(), Result = 12 },
                new { Id = Guid.NewGuid(), Result = 21 },
                new { Id = Guid.NewGuid(), Result = 24 },
                new { Id = Guid.NewGuid(), Result = 25 },
                new { Id = Guid.NewGuid(), Result = 32 },
                new { Id = Guid.NewGuid(), Result = 33 },
                new { Id = Guid.NewGuid(), Result = 36 },
                new { Id = Guid.NewGuid(), Result = 39 },
                new { Id = Guid.NewGuid(), Result = 40 },
                new { Id = Guid.NewGuid(), Result = 42 },
                new { Id = Guid.NewGuid(), Result = 44 },
                new { Id = Guid.NewGuid(), Result = 45 },
                new { Id = Guid.NewGuid(), Result = 46 }
            );

        }

        public DbSet<MultiplicationResult> MultiplicationResults { get; set; }
    }
}
