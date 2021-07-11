using AspNetCore.MVC.EFC.Models;
using AspNetCore.MVC.EFC.Enum;
using System;
using System.Linq;

namespace AspNetCore.MVC.EFC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated(); //Automatically creates the database

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{ Name = "Miguel", LastName = "Bandeira", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Davi", LastName = "Barbosa", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Arthur", LastName = "Barros", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Pedro", LastName = "Cabral", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Gabriel", LastName = "Café", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Sophia", LastName = "Camacho", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Alice", LastName = "Dias", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Julia", LastName = "Duarte", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Isabella", LastName = "Evangelista", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Manuela", LastName = "Fagundes", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Bernardo", LastName = "Ferreira", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Lucas", LastName = "Galvão", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Luiza", LastName = "Gonzaga", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Matheus", LastName = "Hernandes", EnrollmentDate = DateTime.Now },
                new Student{ Name = "Valentina", LastName = "Lopes", EnrollmentDate = DateTime.Now }
            };

            foreach (var studant in students)
            {
                context.Add(studant);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course { Title = "Analise e Desenvolvimento de Sistemas", Credits = 3 },
                new Course { Title = "Ciências da Computacao", Credits = 3 },
                new Course { Title = "Jogos Digitais", Credits = 4 },
                new Course { Title = "Sistemas de Informacao", Credits = 4 },
                new Course { Title = "Sistemas para Internet", Credits = 3 },
                new Course { Title = "Banco de Dados", Credits = 4 },
                new Course { Title = "Rede de Computadores", Credits = 4 }
            };

            foreach(var course in courses)
            {
                context.Add(course);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{ StudentId = 1,CourseId =  2, Grade = Grade.A},
                new Enrollment{ StudentId = 1, CourseId = 1, Grade = Grade.A},
                new Enrollment{ StudentId = 2, CourseId = 2, Grade = Grade.C},
                new Enrollment{ StudentId = 2, CourseId = 3, Grade = Grade.B},
                new Enrollment{ StudentId = 3, CourseId = 3, Grade = Grade.B},
                new Enrollment{ StudentId = 3, CourseId = 1, Grade = Grade.F},
                new Enrollment{ StudentId = 4, CourseId = 6, Grade = Grade.F},
                new Enrollment{ StudentId = 4, CourseId = 7},
                new Enrollment{ StudentId = 5, CourseId = 5},
                new Enrollment{ StudentId = 6, CourseId = 3,Grade = Grade.F},
                new Enrollment{ StudentId = 7, CourseId = 4,Grade = Grade.C},
                new Enrollment{ StudentId = 8, CourseId = 1},
                new Enrollment{ StudentId = 9, CourseId = 4,Grade = Grade.A},
                new Enrollment{ StudentId = 9, CourseId = 2,Grade = Grade.F},
                new Enrollment{ StudentId = 9, CourseId = 6,Grade = Grade.C},
                new Enrollment{ StudentId = 10, CourseId = 7},
                new Enrollment{ StudentId = 10, CourseId = 3,Grade = Grade.A},
                new Enrollment{ StudentId = 11, CourseId = 5,Grade = Grade.F},
                new Enrollment{ StudentId = 11, CourseId = 3,Grade = Grade.C},
                new Enrollment{ StudentId = 12, CourseId = 1},
                new Enrollment{ StudentId = 13, CourseId = 7,Grade = Grade.A},
                new Enrollment{ StudentId = 13, CourseId = 4,Grade = Grade.C},
                new Enrollment{ StudentId = 14, CourseId = 1},
                new Enrollment{ StudentId = 14, CourseId = 2,Grade = Grade.A}
            };
            
            foreach(var enrollment in enrollments)
            {
                context.Add(enrollment);
            }
            context.SaveChanges();
        }
    }
}
