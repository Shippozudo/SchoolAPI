using EscolaAPI.DTOs;
using Dominio;
using EFContext.Repositorios;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Services
{
    public class TeacherService
    {

        private readonly TeacherRepository _teacherRepository;

        public TeacherService(TeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> SelectTeacher()
        {
            return _teacherRepository.GetAll();
        }

        public Teacher SelectTeacherId(int id)
        {
            return _teacherRepository.Find(id);
        }



        public TeacherDTO RegisterTeacher(TeacherDTO teacherDTO)
        {
            teacherDTO.Validar();
            if (!teacherDTO.Valido)
                throw new Exception("Nome inválido");

            var newTeacher = new Teacher
            {
                Id = 0,
                Name = teacherDTO.Name

            };
            _teacherRepository.Insert(newTeacher);

            return new TeacherDTO
            {
                Id = newTeacher.Id,
                Name = newTeacher.Name,
            };

        }


        public TeacherDTO UpdateTeacher(int id, TeacherDTO teacherDTO)
        {
            teacherDTO.Validar();
            if (!teacherDTO.Valido)
                throw new Exception("Nome inválido");

            var UpdateTeacher = new Teacher
            {
                Id = id,
                Name = teacherDTO.Name


            };
            _teacherRepository.Update(UpdateTeacher);

            return new TeacherDTO
            {
                Id = UpdateTeacher.Id,
                Name = UpdateTeacher.Name

            };

        }


        public void DeleteTeacher(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
        }

    }
}
