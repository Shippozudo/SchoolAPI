using Dominio;
using EscolaAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Services;
using System;

namespace SchoolAPI.Controllers
{
    [ApiController, Route("[controller]")]
    public class LessonController : ControllerBase
    {
        
        private readonly LessonService _lessonService;

        public LessonController( LessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet, Route("/lesson/")]
        public IActionResult SelectLesson()
        {
            return Ok(_lessonService.SelectLesson());

        }

        [HttpGet, Route("/lesson/{id}")]
        public IActionResult SelectLessonId(int id)
        {
            return Ok(_lessonService.SelectLessonId(id));

        }


        [HttpPost, Route("/lesson")]
        public IActionResult RegisterLesson([FromQuery] LessonDTO lessonDTO)
        {
            return Created("", _lessonService.RegisterLesson(lessonDTO));
        }



        [HttpPut, Route("/lesson/{id}")]
        public IActionResult UpdateLesson(int id, [FromQuery] LessonDTO lessonDTO)
        {
            return Created("", _lessonService.UpdateLesson(id, lessonDTO));
        }


        [HttpDelete, Route("/lesson/{id}")]
        public IActionResult DeleteLesson(Lesson lesson)
        {
            _lessonService.DeleteLesson(lesson);
            return Ok();
        }





        //[HttpGet, Route("/lesson/teacher")]
        //public IActionResult SelectLessonTeacher()
        //{
        //    return Ok(_lessonService.SelectLessonTeacher());

        //}

    }
}
