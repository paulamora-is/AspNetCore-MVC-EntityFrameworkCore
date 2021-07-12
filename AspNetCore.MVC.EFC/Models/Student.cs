using System;
using System.Collections.Generic;

namespace AspNetCore.MVC.EFC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}