using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Configurations
{
    public class ComplainConfiguration : IEntityTypeConfiguration<Complain>
    {
        public void Configure(EntityTypeBuilder<Complain> entity)
        {
            entity.HasKey(e => e.IdComplains)
                .HasName("PK__complain__DC12E46E98597387");

            entity.Property(e => e.IdComplains)
                .ValueGeneratedOnAdd()
                .HasColumnName("IdComplain");
            

            entity.ToTable("complains");

            entity.Property(e => e.IdDepartment)
                .IsRequired()
                .HasColumnName("IdDepartment");

            entity.Property(e => e.Content)
                .IsUnicode()
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IdStudent)
                .HasMaxLength(225)
                .IsUnicode(false);

            //entity.Property(e => e.Picture).IsUnicode(false);

            //entity.Property(e => e.Picturecontent).HasColumnName("picturecontent");

            entity.Property(e => e.Reply)
                .HasColumnName("reply")
                .HasColumnType("nvarchar(max)")
                .HasColumnType("nvarchar(max)")
                .IsUnicode();

            entity.Property(e => e.Status)
                .HasColumnName("status")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                .HasDefaultValueSql("N'Bản nháp'")
                .IsUnicode();

            entity.Property(e => e.Title)
                .HasMaxLength(225)
                .IsUnicode()
                .HasColumnType("nvarchar(225)")
                .IsRequired();

            entity.Property(e => e.IsPublic)
                .HasColumnName("IsPublic")
                .HasDefaultValueSql("0");

            entity.HasOne(d => d.Department)
                .WithMany(p => p.Complains)
                .HasForeignKey(d => d.IdDepartment);


            entity.HasOne(d => d.IdStudentNavigation)
                .WithMany(p => p.Complains)
                .HasForeignKey(d => d.IdStudent)
                .HasConstraintName("FK__complains__IdStu__2D27B809");
        }
    }
}
