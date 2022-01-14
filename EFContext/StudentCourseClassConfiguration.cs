using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext
{

    public class StudentCourseClassConfiguration : IEntityTypeConfiguration<StudentCourseClass>
    {
        public void Configure(EntityTypeBuilder<StudentCourseClass> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.StudentId);
            builder.Property(p => p.LessonId);
            builder.Property(p => p.CourseId);
            builder.Property(p => p.ClassId);




            builder.HasIndex(p => p.StudentId);
            builder.HasIndex(p => p.LessonId);
            builder.HasIndex(p => p.CourseId);
            builder.HasIndex(p => p.ClassId);


        }
    }

}
