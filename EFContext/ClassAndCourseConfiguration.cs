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


    public class ClassAndCourseConfiguration : IEntityTypeConfiguration<ClassAndCourse>
    {
        public void Configure(EntityTypeBuilder<ClassAndCourse> builder)
        {


            builder.Property(p => p.ClassName).HasMaxLength(3);
            builder.Property(p => p.CourseName).HasMaxLength(150);

            builder.HasIndex(p => p.ClassName);
            builder.HasIndex(p => p.CourseName);



            //builder.Property(p => p.Nome).HasMaxLength(150);
            //builder.Property(p => p.Sobrenome).HasMaxLength(300);
            //builder.Property(p => p.Documento).HasMaxLength(11);

            //builder.HasIndex(p => p.Documento).IsUnique();
            //builder.HasIndex(p => new { p.Nome, p.Sobrenome });

        }
    }

}
