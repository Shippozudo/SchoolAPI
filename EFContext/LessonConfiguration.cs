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

    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {


            builder.Property(p => p.LessonName).HasMaxLength(150);
            builder.Property(p => p.idTeacher);

            

            builder.HasIndex(p => p.LessonName);
            builder.HasIndex(p => p.idTeacher);


            //builder.Property(p => p.Nome).HasMaxLength(150);
            //builder.Property(p => p.Sobrenome).HasMaxLength(300);
            //builder.Property(p => p.Documento).HasMaxLength(11);

            //builder.HasIndex(p => p.Documento).IsUnique();
            //builder.HasIndex(p => new { p.Nome, p.Sobrenome });

        }
    }

}
