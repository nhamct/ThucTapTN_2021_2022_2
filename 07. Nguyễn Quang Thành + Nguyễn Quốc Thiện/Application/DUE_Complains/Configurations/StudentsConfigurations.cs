using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Configurations
{
    public class StudentsConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            entity.ToTable("Students");
            entity.HasKey(e => e.Studentcode)
                .HasName("PK__Students__A5703329F248FB09");

            entity.Property(e => e.Studentcode)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("studentcode")
                .IsRequired();

            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("email")
                .HasColumnType("varchar(256)");

            entity.Property(e => e.Name).HasColumnName("name")
                .IsUnicode()
                .HasColumnType("nvarchar(max)");

            entity.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("phone");

            entity.Property(e => e.Sclass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sclass");


            entity.HasOne(x => x.DepartmentNavi)
                .WithMany(y => y.Students)
                .HasForeignKey(z => z.DepartmentId);


        }
    }
}
