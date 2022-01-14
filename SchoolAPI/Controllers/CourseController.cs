using Dominio;
using EscolaAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.DTOs;
using SchoolAPI.Repository;
using System;

namespace SchoolAPI.Controllers
{
    [ApiController, Route("[controller]")]

    public class CourseController : ControllerBase
    {

        private readonly CourseService _courseService;

        public CourseController(CourseService courseService)
        {
            _courseService = courseService;
        }


        [HttpGet, Route("/course/")]
        public IActionResult SelectCourse()
        {
            return Ok(_courseService.SelectCourse());

        }

        [HttpGet, Route("/course/{id}")]
        public IActionResult SelectCourseId(int id)
        {
            return Ok(_courseService.SelectCourseId(id));

        }


        [HttpPost, Route("/course")]
        public IActionResult RegisterCourse([FromQuery] CourseDTO CourseDTO)
        {
            return Created("", _courseService.RegisterCourse(CourseDTO));
        }



        [HttpPut, Route("/course/{id}")]
        public IActionResult UpdateCourse(int id, [FromQuery] CourseDTO CourseDTO)
        {
            return Created("", _courseService.UpdateCourse(id, CourseDTO));
        }


        [HttpDelete, Route("/course/{id}")]
        public IActionResult DeleteCourse(Course course)
        {
            _courseService.DeleteCourse(course);
            return Ok();
        }






        //[HttpGet, Route("/course/lesson")]
        //public IActionResult SelectCourseLesson()
        //{
        //    return Ok(_courseService.SelectCourseLesson());

        //}



        //[HttpPost, Route("/course/lesson")]
        //public IActionResult InsertCourseLesson([FromQuery] CourseLessonDTO courseLessonDTO)
        //{
        //    return Created("", _courseService.InsertCourseLesson(courseLessonDTO));
        //}



        //[HttpDelete, Route("/course/{idCurso}/{idLesson}")]
        //public IActionResult DeleteCourseLesson(Guid idCurso, Guid idLesson)
        //{
        //    _courseService.DeleteCourseLesson(idCurso, idLesson);
        //    return Ok();
        //}


    }
}
