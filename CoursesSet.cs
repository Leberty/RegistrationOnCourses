using System;
using System.Collections.Generic;

namespace RegistrationOnCourses
{
    public partial class CoursesSet
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? CourseCountHours { get; set; }
        public DateTime? CourseStart { get; set; }
        public DateTime? CourseFinish { get; set; }
    }
}
