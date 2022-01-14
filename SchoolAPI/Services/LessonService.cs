using Dominio;
using EFContext.Repositorios;
using EscolaAPI.DTOs;
using SchoolAPI.DTOs;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Services
{
    public class LessonService
    {
        private readonly LessonRepository _lessonRepository;

        public LessonService(LessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }


        public IEnumerable<Lesson> SelectLesson()
        {
            return _lessonRepository.GetAll();
        }

        public Lesson SelectLessonId(int id)
        {
            return _lessonRepository.Find(id);
        }





        public LessonDTO RegisterLesson(LessonDTO lessonDTO)
        {
            lessonDTO.Validar();

            if (!lessonDTO.Valido)
                throw new Exception("Nome inválido");

            var newLesson = new Lesson
            {
                Id = 0,
                LessonName = lessonDTO.LessonName,

            };

            //var lessonName = _lessonRepository.VerifyRegisterLesson(newLesson);
            //foreach (var l in lessonName)
            //{
            //    if (l == newLesson.LessonName)
            //        throw new Exception("A matéria já foi cadastrada");

            //}

            _lessonRepository.Insert(newLesson);

            return new LessonDTO
            {
                Id = newLesson.Id,
                LessonName = newLesson.LessonName,
            };

        }

        public LessonDTO UpdateLesson(int id, LessonDTO lessonDTO)
        {
            lessonDTO.Validar();

            if (!lessonDTO.Valido)
                throw new Exception("Nome inválido");

            var UpdateLesson = new Lesson
            {
                Id = id,
                LessonName = lessonDTO.LessonName,
                idTeacher = lessonDTO.idTeacher,

            };
            _lessonRepository.Update(UpdateLesson);


            return new LessonDTO
            {
                Id = UpdateLesson.Id,
                LessonName = UpdateLesson.LessonName,
                idTeacher = lessonDTO.idTeacher,
            };

        }


        public void DeleteLesson(Lesson lesson)
        {
            _lessonRepository.Delete(lesson);
        }

        
        //public IEnumerable<LessonCourseTeacherDTO> SelectLessonTeacher()
        //{
        //    return _lessonRepository.SelectLessonTeacher();
        //}


    }
}
