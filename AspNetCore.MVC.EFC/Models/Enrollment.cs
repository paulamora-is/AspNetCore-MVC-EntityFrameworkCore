using AspNetCore.MVC.EFC.Models.Enum;

namespace AspNetCore.MVC.EFC.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
