using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Configurations
{
    public class ImageComplainsConfigurations : IEntityTypeConfiguration<ImageComplain>
    {
        public void Configure(EntityTypeBuilder<ImageComplain> entity)
        {
            entity.ToTable("ImageComplain");

            entity.HasKey(e => e.id)
            .HasName("PK__ImageCom__3213E83F160F617E");

            entity.Property(e => e.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd();

            entity.Property(e => e.IdComplain)
            .HasColumnName("IdComplain")
            .IsRequired(true);

            entity.HasOne(d => d.complain)
            .WithMany(x => x.ImageComplain)
            .HasForeignKey(d => d.IdComplain)
            .HasConstraintName("FK__ImageComp__IdCom__73BA3083");


            entity.Property(e => e.content_image)
            .HasColumnName("content_image");

            entity.Property(e => e.filesize)
            .HasColumnName("filesize");

            entity.Property(e => e.IsDefault)
            .HasColumnName("IsDefault")
            .IsRequired(true);

            entity.Property(e => e.Path_image)
            .HasColumnName("Path_image")
            .IsRequired(true);
        }
    }
}
