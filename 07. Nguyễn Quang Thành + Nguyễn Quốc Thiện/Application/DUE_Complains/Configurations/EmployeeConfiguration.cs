using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {

            entity.HasOne(d => d.Department)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Employees__idDep__2E1BDC42");

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();

            entity.ToTable("Employees");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.DepartmentId).HasColumnName("idDepartment").IsRequired();

            entity.Property(e => e.Name)
                .HasMaxLength(225)
                .HasColumnName("name")
                .IsUnicode()
                .HasColumnType("nvarchar(225)");

            entity.Property(e => e.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("varchar(256)");

            entity.Property(e => e.Position)
                .HasMaxLength(225)
                .HasColumnName("position")
                .HasColumnType("nvarchar(225)")
                .IsUnicode();
            

        }
    }
}
