using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {

        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.ToTable("Departments");

            entity.HasKey(e => e.DepartmentId)
               .HasName("PK__Departme__3214EC07150FB4F0");

            entity.Property(e => e.DepartmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            entity.Property(e => e.Name)
                .HasMaxLength(225)
                .HasColumnName("name")
                .IsUnicode();

            entity.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("phone")
                .IsFixedLength(true);

            entity.Property(e => e.Totalemployee).HasColumnName("totalemployee");

            entity.Property(e => e.Totalstudent).HasColumnName("totalstudent");
        }
    }
}
