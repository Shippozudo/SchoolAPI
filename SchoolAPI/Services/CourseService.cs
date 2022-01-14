using EscolaAPI.DTOs;
using EFContext.Repositorios;
using SchoolAPI.DTOs;
using Dominio;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Repository
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public IEnumerable<Course> SelectCourse()
        {
            return _courseRepository.GetAll();
        }

        public Course SelectCourseId(int id)
        {
            return _courseRepository.Find(id);
        }

        public CourseDTO RegisterCourse(CourseDTO courseDTO)
        {

            courseDTO.Validar();

            if (!courseDTO.Valido)
                throw new Exception("Nome inválido");

            var newCourse = new Course
            {
                Id = 0,
                Name = courseDTO.Name,

            };


            //var courseName = _courseRepository.VerifyRegisterCourse(newCourse);
            //foreach (var c in courseName)
            //{
            //    if (c == newCourse.Name)
            //        throw new Exception("O curso já foi cadastrado");
            //}
            _courseRepository.Insert(newCourse);

            return new CourseDTO
            {
                Id = newCourse.Id,
                Name = newCourse.Name,
            };

        }
        public CourseDTO UpdateCourse(int id, CourseDTO courseDTO)
        {
            courseDTO.Validar();

            if (!courseDTO.Valido)
                throw new Exception("Nome inválido");


            var updateCourse = new Course
            {
                Id = id,
                Name = courseDTO.Name

            };

            //var courseName = _courseRepository.VerifyRegisterCourse(updateCourse);
            //foreach (var c in courseName)
            //{
            //    if (c == updateCourse.Name)
            //        throw new Exception("O curso já foi cadastrado");
            //}

            _courseRepository.Update(updateCourse);

            return new CourseDTO
            {
                Id = updateCourse.Id,
                Name = updateCourse.Name

            };

        }

        public void DeleteCourse(Course course)
        {
             _courseRepository.Delete(course);
        }

        //public IEnumerable<CourseLesson> SelectCourseLesson()
        //{
        //    return _courseRepository.SelectCourseLesson();
        //}

        //public CourseLessonDTO InsertCourseLesson(CourseLessonDTO courseLessonDTO)
        //{
        //    courseLessonDTO.Validar();
        //    if (!courseLessonDTO.Valido)
        //        throw new Exception("Nome inválido");


        //    var newCourseLesson = new NewCourseLesson
        //    {
        //        Id = Guid.NewGuid(),
        //        CourseId = courseLessonDTO.CourseId,
        //        LessonId = courseLessonDTO.LessonId

        //    };
        //    var lessonID = _courseRepository.VerifyInsertCourseLesson(newCourseLesson);

        //    foreach (var l in lessonID)
        //    {
        //        if (l == newCourseLesson.LessonId)
        //            throw new Exception("Materia já adicionada ao Curso");
        //    }
        //    _courseRepository.InsertCourseLesson(newCourseLesson);

        //    return new CourseLessonDTO
        //    {
        //        Id = newCourseLesson.Id,
        //        CourseId = newCourseLesson.CourseId,
        //        LessonId = newCourseLesson.LessonId
        //    };

        //}

        //public bool DeleteCourseLesson(Guid idCurso, Guid idLesson)
        //{
        //    return _courseRepository.DeleteCourseLesson(idCurso, idLesson);
        //}
    }
}
