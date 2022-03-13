using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Configurations
{
    public class AppUsersConfigurations : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> entity)
        {
            entity.ToTable("AppUsers");
            entity.Property(x => x.Name)
                .HasMaxLength(200);
            entity.Property(x => x.IdDepartment);
            entity.Property(x => x.IdStudent)
                        .HasMaxLength(225);
        }
    }
}
