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

    public class StudentAndLessonConfiguration : IEntityTypeConfiguration<StudentAndLesson>
    {
        public void Configure(EntityTypeBuilder<StudentAndLesson> builder)
        {
            

            builder.Property(p => p.StudentId);
            builder.Property(p => p.StudentName);
            //builder.Property(p => p.LessonName);
            builder.Property(p => p.CourseName);
            builder.Property(p => p.ClassName);




            builder.HasIndex(p => p.StudentId);
            builder.HasIndex(p => p.StudentName);
            //builder.HasIndex(p => p.LessonName);
            builder.HasIndex(p => p.CourseName);
            builder.HasIndex(p => p.ClassName);


            

        }
    }

}
