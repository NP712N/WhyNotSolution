using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models;

namespace WhyNotSolution.Configurations {
    public class PostConfiguration : IEntityTypeConfiguration<Post> {
        public void Configure(EntityTypeBuilder<Post> builder) {
            builder.ToTable("Posts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.IsAnonymous).HasDefaultValue(true);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(p => p.User).WithMany(u => u.Posts).HasForeignKey(p => p.PostByUserId);
        }
    }
}
