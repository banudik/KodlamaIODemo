using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses").HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.Name).HasColumnName("Name").IsRequired();
        builder.Property(x => x.CategoryId).HasColumnName("CategoryId").IsRequired();
        builder.Property(x => x.InstructorId).HasColumnName("InstructorId").IsRequired();
        builder.Property(x => x.ImageUrl).HasColumnName("ImageUrl").IsRequired();
        builder.Property(x => x.Price).HasColumnName("Price").IsRequired();
        builder.Property(x => x.CreatedDate).HasColumnName("Created Date");
        builder.Property(x => x.DeletedDate).HasColumnName("Deleted Date");
        builder.Property(x => x.UpdatedDate).HasColumnName("Updated Date");

        builder.HasOne(x => x.Instructor).WithMany(x => x.Courses).HasForeignKey(x => x.InstructorId);


    }
}
