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

    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {


            builder.Property(p => p.Name).HasMaxLength(150);
           
            builder.HasIndex(p => p.Name);


            //builder.Property(p => p.Nome).HasMaxLength(150);
            //builder.Property(p => p.Sobrenome).HasMaxLength(300);
            //builder.Property(p => p.Documento).HasMaxLength(11);

            //builder.HasIndex(p => p.Documento).IsUnique();
            //builder.HasIndex(p => new { p.Nome, p.Sobrenome });

        }
    }

}
