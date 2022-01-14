using Dominio;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFContext
{
    public class AppContext : DbContext
    {

        public DbSet<Base<int>> Bases { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassAndCourse> ClassAndCourses { get; set; }
        public DbSet<CourseLesson> CourseLessons { get; set; }
        public DbSet<StudentCourseClass> StudentCourseClasses { get; set; }
        public DbSet<StudentAndLesson> StudentAndLessons { get; set; }



        public AppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
