using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Configurations
{
    public class AppRolesConfigurations : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> entity)
        {
            entity.ToTable("AppRoles");
            entity.Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired();
        }
                
    }
}

