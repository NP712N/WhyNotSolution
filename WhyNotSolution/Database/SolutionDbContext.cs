using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Configurations;
using WhyNotSolution.Extensions;

namespace WhyNotSolution.Models.Database {
    public class SolutionDbContext: DbContext {
        public SolutionDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  {
            // Configuration models
            ConfigData(modelBuilder);

            // Seeding Data
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }

        private void ConfigData(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
