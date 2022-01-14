using Dominio;
using EscolaAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Services;
using System;

namespace SchoolAPI.Controllers
{
    [ApiController, Route("[controller]")]

    public class TeacherController : ControllerBase
    {

        private readonly TeacherService _teacherService;

        public TeacherController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet, Route("/teacher/")]
        public IActionResult SelectTeacher()
        {
            return Ok(_teacherService.SelectTeacher());

        }

        [HttpGet, Route("/teacher/{id}")]
        public IActionResult SelectTeacherId(int id)
        {
            return Ok(_teacherService.SelectTeacherId(id));

        }


        [HttpPost, Route("/teacher")]
        public IActionResult RegisterTeacher([FromBody] TeacherDTO teacherDTO)
        {
            return Created("", _teacherService.RegisterTeacher(teacherDTO));
        }



        [HttpPut, Route("/teacher/{id}")]
        public IActionResult UpdateTeacher(int id, [FromBody] TeacherDTO teacherDTO)
        {
            return Created("", _teacherService.UpdateTeacher(id, teacherDTO));
        }


        [HttpDelete, Route("/teacher/{id}")]
        public IActionResult DeleteTeacher(Teacher teacher)
        {
            _teacherService.DeleteTeacher(teacher);
            return Ok();
        }



    }
}
