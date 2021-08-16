using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models;

namespace WhyNotSolution.Configurations {
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(16);
            builder.Property(x => x.DisplayName).HasMaxLength(50);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.UtcNow);

            builder.HasMany(u => u.Posts).WithOne(p => p.User).HasForeignKey(p => p.PostByUserId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
        }
    }
}
