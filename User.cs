using System;
using System.Collections.Generic;

namespace RegistrationOnCourses
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Midname { get; set; }
        public string EduLevel { get; set; } = null!;
    }
}
