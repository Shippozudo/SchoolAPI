using Dominio;
using EFContext.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SchoolAPI.Repository;
using SchoolAPI.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SchoolAPI", Version = "v1" });
            });



            var connectionString = Configuration.GetConnectionString("Oracle");

            services.AddDbContext<EFContext.AppContext>(
                configuration =>
                {
                    configuration.UseOracle(connectionString,
                        opt =>
                        {
                            opt.MigrationsAssembly(typeof(EFContext.AppContext).Assembly.GetName().Name);
                        });
                });

            services.AddTransient<IStudentRepository, EFContext.Repositorios.StudentRepository>();
            //builder.Services.AddTransient<IPessoasRepository, DapperContext.Repositorios.PessoaRepository>();





            services.AddTransient<LessonService>();
            services.AddTransient<CourseService>();
            services.AddTransient<TeacherService>();
            services.AddTransient<StudentService>();
            services.AddTransient<ClassroomService>();





            services.AddTransient<CourseRepository>();
            services.AddTransient<LessonRepository>();
            services.AddTransient<StudentRepository>();
            services.AddTransient<TeacherRepository>();
            services.AddTransient<ClassroomRepository>();
            //services.AddTransient<StudentLessonRepository>();

        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SchoolAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
