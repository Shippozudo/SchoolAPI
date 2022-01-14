using EscolaAPI.DTOs;
using Dominio;
using EFContext.Repositorios;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Services
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;
        //private readonly StudentLessonRepository _studentLessonRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }

        public IEnumerable<Student> SelectStudent()
        {
            return _studentRepository.GetAll();
        }

        public Student SelectStudentId(int id)
        {
            return _studentRepository.Find(id);
        }



        public StudentDTO RegisterStudent(StudentDTO studentDTO)
        {
            studentDTO.Validar();

            if (!studentDTO.Valido)
                throw new Exception("Nome inválido");

            var student = new Student
            {
                Id = 0,
                Name = studentDTO.Name,
                IdClassroom = studentDTO.IdClassroom,
                IdCourse = studentDTO.IdCourse

            };
            _studentRepository.Insert(student);

            return new StudentDTO
            {
                Id = student.Id,
                Name = student.Name,
                IdClassroom = student.IdClassroom,
                IdCourse = student.IdCourse
            };

        }




        public StudentDTO UpdateStudent(int id, StudentDTO studentDTO)
        {
            studentDTO.Validar();

            if (!studentDTO.Valido)
                throw new Exception("Nome inválido");

            var student = new Student
            {
                Id = id,
                Name = studentDTO.Name,
                IdClassroom = studentDTO.IdClassroom,
                IdCourse = studentDTO.IdCourse

            };
            _studentRepository.Update(student);

            return new StudentDTO
            {
                Id = student.Id,
                Name = student.Name,
                IdClassroom = student.IdClassroom,
                IdCourse = student.IdCourse,
            };

        }


        public void DeleteStudent(Student student)
        {
            _studentRepository.Delete(student);
        }





        //    public IEnumerable<StudentAndLesson> SelectStudentLesson()
        //    {
        //        return _studentLessonRepository.SelectStudentLesson();
        //    }




        //    public StudentLessonDTO RegisterStudentLesson(StudentLessonDTO studentLessonDTO)
        //    {
        //        studentLessonDTO.Validar();

        //        if (!studentLessonDTO.Valido)
        //            throw new Exception("Guid inválido");

        //        var studentLesson = new StudentLesson
        //        {
        //            StudentId = studentLessonDTO.StudentId,
        //            LessonId = studentLessonDTO.LessonId,
        //            ClassId = studentLessonDTO.ClassId,
        //            CourseId = studentLessonDTO.CourseId,
        //        };

        //        int count = _studentLessonRepository.VerifyCountStudentLesson(studentLesson);
        //        var lesson = _studentLessonRepository.VerifyStudentLesson(studentLesson);

        //        if (count + 1 <= 3)
        //        {
        //            foreach (var l in lesson)
        //            {
        //                if (l == studentLesson.LessonId)
        //                    throw new Exception("A matéria já foi adicionada ao Aluno");

        //            }
        //            _studentLessonRepository.RegisterStudentLesson(studentLesson);

        //        }
        //        else
        //            throw new Exception("O aluno pode ter no máximo 3 matérias");




        //        return new StudentLessonDTO
        //        {
        //            StudentId = studentLesson.StudentId,
        //            LessonId = studentLesson.LessonId,
        //            ClassId = studentLesson.ClassId,
        //            CourseId = studentLesson.CourseId
        //        };
        //    }



        //    public StudentLessonDTO UpdateStudentLesson(StudentLessonDTO studentLessonDTO)
        //    {
        //        studentLessonDTO.Validar();

        //        if (!studentLessonDTO.Valido)
        //            throw new Exception("Guid inválido");

        //        var studentLesson = new StudentLesson
        //        {

        //            StudentId = studentLessonDTO.StudentId,
        //            ClassId = studentLessonDTO.ClassId,
        //            CourseId = studentLessonDTO.CourseId

        //        };
        //        _studentLessonRepository.UpdateStudentLesson(studentLesson);

        //        return new StudentLessonDTO
        //        {

        //            StudentId = studentLesson.StudentId,
        //            ClassId = studentLesson.ClassId,
        //            CourseId = studentLesson.CourseId

        //        };
        //    }

        //    public bool DeleteStudentLesson(Guid idStudent, Guid idLesson)
        //    {
        //        return _studentLessonRepository.DeleteStudentLesson(idStudent, idLesson);
        //    }



        //}

    }
}
