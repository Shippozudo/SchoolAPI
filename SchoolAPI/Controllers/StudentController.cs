using EscolaAPI.DTOs;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.DTOs;
using SchoolAPI.Services;
using System;

namespace SchoolAPI.Controllers
{

    [ApiController, Route("[controller]")]

    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }



        [HttpGet, Route("/student/")]
        public IActionResult SelectStudent()
        {
            return Ok(_studentService.SelectStudent());

        }

        [HttpGet, Route("/student/{id}")]
        public IActionResult SelectStudentId(int id)
        {
            return Ok(_studentService.SelectStudentId(id));

        }


        [HttpPost, Route("/student")]
        public IActionResult RegisterStudent([FromBody] StudentDTO studentDTO)
        {
            return Created("", _studentService.RegisterStudent(studentDTO));
        }


        [HttpPut, Route("/student/{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentDTO studentDTO)
        {
            return Created("", _studentService.UpdateStudent(id, studentDTO));
        }


        [HttpDelete, Route("/student/")]
        public IActionResult DeleteStudent(Student student)
        {
            _studentService.DeleteStudent(student);
            return Ok();
        }






        //[HttpGet, Route("/student/lesson")]
        //public IActionResult SelectStudentLesson()
        //{
        //    return Ok(_studentService.SelectStudentLesson());

        //}



        //[HttpPost, Route("/student/lesson")]
        //public IActionResult RegisterStudentLesson([FromQuery] StudentLessonDTO studentLessonDTO)
        //{
        //    return Created("", _studentService.RegisterStudentLesson(studentLessonDTO));
        //}


        //[HttpPut, Route("/student/lesson")]
        //public IActionResult UpdateStudentLesson([FromQuery] StudentLessonDTO studentLessonDTO)
        //{
        //    return Created("", _studentService.UpdateStudentLesson(studentLessonDTO));
        //}




        //[HttpDelete, Route("/student/lesson")]
        //public IActionResult DeleteStudentLesson(Guid idStudent, Guid idLesson)
        //{
        //    return Created("", _studentService.DeleteStudentLesson(idStudent, idLesson));
        //}


    }


}
