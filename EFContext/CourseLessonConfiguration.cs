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

    public class CourseLessonConfiguration : IEntityTypeConfiguration<CourseLesson>
    {
        public void Configure(EntityTypeBuilder<CourseLesson> builder)
        {


            builder.Property(p => p.CourseId);
            builder.Property(p => p.Course).HasMaxLength(150);
            //builder.Property(p => p.Lesson);

            builder.HasIndex(p => p.CourseId);
            builder.HasIndex(p => p.Course);
            //builder.HasIndex(p => p.Lesson);


            //builder.Property(p => p.Nome).HasMaxLength(150);
            //builder.Property(p => p.Sobrenome).HasMaxLength(300);
            //builder.Property(p => p.Documento).HasMaxLength(11);

            //builder.HasIndex(p => p.Documento).IsUnique();
            //builder.HasIndex(p => new { p.Nome, p.Sobrenome });

        }
    }

}
