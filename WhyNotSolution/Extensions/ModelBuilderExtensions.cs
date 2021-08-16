using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models;

namespace WhyNotSolution.Extensions {
    public static class ModelBuilderExtensions {
        public static void SeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Role>().HasData(
               new Role() { Id = 1, RoleName = "Test Role 1" }
               );

            modelBuilder.Entity<User>().HasData(
               new User() { Id = 1, DisplayName = "Admin", UserName = "admin", Password = "admin", RoleId = 1 }
               );

            modelBuilder.Entity<Post>().HasData(
               new Post() { Id = 1, Title = "TEst", Content = "Test", IsAnonymous = false, PostByUserId = 1 }
               );
        }
    }
}
