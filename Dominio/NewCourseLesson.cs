﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class NewCourseLesson : Base<int>
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int LessonId { get; set; }
    }
}
