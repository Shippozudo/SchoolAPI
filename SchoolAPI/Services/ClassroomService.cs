using EFContext.Repositorios;
using EscolaAPI.DTOs;
using Dominio;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Services
{
    public class ClassroomService
    {
        private readonly ClassroomRepository _classroomRepository;

        public ClassroomService(ClassroomRepository classroomRepository)
        {
            _classroomRepository = classroomRepository;
        }



        public IEnumerable<Classroom> SelectClassroom()
        {
            return _classroomRepository.GetAll();
        }

        public Classroom SelectClassroomId(int id)
        {
            return _classroomRepository.Find(id);
        }



        public ClassroomDTO RegisterClass(ClassroomDTO classroomDTO)
        {
            classroomDTO.Validar();

            if (!classroomDTO.Valido)
                throw new Exception("Nome inválido, deve ser igual ou maior a 100 e menor que 200");


            var newClassroom = new Classroom
            {
                Id = 0,
                Name = classroomDTO.Name,
                idCourse = classroomDTO.idCourse

            };
            //var classroomName = _classroomRepository.VerifyRegisterClass(newClassroom);

            //foreach (var c in classroomName)
            //{
            //    if (c == newClassroom.Name)
            //        throw new Exception("A turma já existe");
            //}
            _classroomRepository.Insert(newClassroom);

            return new ClassroomDTO
            {
                Id = newClassroom.Id,
                Name = newClassroom.Name,
                idCourse = newClassroom.idCourse
            };

        }


        public ClassroomDTO UpdateClass(int id, ClassroomDTO classroomDTO)
        {

            classroomDTO.Validar();

            if (!classroomDTO.Valido)
                throw new Exception("Nome inválido, deve ser igual ou maior a 100 e menor que 200");


            var Updateclassroom = new Classroom
            {
                Id = id,
                Name = classroomDTO.Name,
                idCourse = classroomDTO.idCourse


            };

            //var classroomName = _classroomRepository.VerifyRegisterClass(Updateclassroom);

            //foreach (var c in classroomName)
            //{
            //    if (c == Updateclassroom.Name)
            //        throw new Exception("A turma já existe");
            //}
            _classroomRepository.Update(Updateclassroom);

            return new ClassroomDTO
            {
                Id = Updateclassroom.Id,
                Name = Updateclassroom.Name,
                idCourse = Updateclassroom.idCourse

            };

        }


        public void DeleteClass(Classroom classroom)
        {
             _classroomRepository.Delete(classroom);
            
        }



        //public IEnumerable<ClassAndCourse> SelectClassAndCourse()
        //{
        //    return _classroomRepository.SelectClassAndCourse();
        //}




       

    }
}
