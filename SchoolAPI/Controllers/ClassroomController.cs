using Dominio;
using EscolaAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Services;
using System;

namespace SchoolAPI.Controllers
{
    [ApiController, Route("[controller]")]

    public class ClassroomController : ControllerBase
    {

        private readonly ClassroomService _classroomService;

        public ClassroomController(ClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        [HttpGet, Route("/classroom/")]
        public IActionResult SelectClass()
        {
            return Ok(_classroomService.SelectClassroom());

        }

        [HttpGet, Route("/classroom/{id}")]
        public IActionResult SelectClassId(int id)
        {
            return Ok(_classroomService.SelectClassroomId(id));

        }


        [HttpPost, Route("/classroom")]
        public IActionResult RegisterClass([FromQuery] ClassroomDTO classroomDTO)
        {
            return Created("", _classroomService.RegisterClass(classroomDTO));
        }



        [HttpPut, Route("/classroom/{id}")]
        public IActionResult UpdateClass(int id, [FromQuery] ClassroomDTO classroomDTO)
        {
            return Created("", _classroomService.UpdateClass(id, classroomDTO));
        }


        [HttpDelete, Route("/classroom/{id}")]
        public IActionResult DeleteClass(Classroom classroom)
        {
            _classroomService.DeleteClass(classroom);
            return Ok();
        }



        //[HttpGet, Route("/classroom/Course")]
        //public IActionResult SelectClassAndCourse()
        //{
        //    return Ok(_classroomService.SelectClassAndCourse());

        //}





    }
}
