using AspNetCore.MVC.EFC.Models;
using AspNetCore.MVC.EFC.Models.Enum;
using System;
using System.Linq;

namespace AspNetCore.MVC.EFC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{ FirstMidName = "Miguel", LastName = "Bandeira", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Davi", LastName = "Barbosa", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Arthur", LastName = "Barros", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Pedro", LastName = "Cabral", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Gabriel", LastName = "Café", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Sophia", LastName = "Camacho", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Alice", LastName = "Dias", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Julia", LastName = "Duarte", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Isabella", LastName = "Evangelista", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Manuela", LastName = "Fagundes", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Bernardo", LastName = "Ferreira", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Lucas", LastName = "Galvão", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Luiza", LastName = "Gonzaga", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Matheus", LastName = "Hernandes", EnrollmentDate = DateTime.Now },
                new Student{ FirstMidName = "Valentina", LastName = "Lopes", EnrollmentDate = DateTime.Now }
            };

            foreach (var studant in students)
            {
                context.Add(studant);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course { Id = 4022, Title = "Analise e Desenvolvimento de Sistemas", Credits = 3 },
                new Course { Id = 4041, Title = "Ciências da Computacao", Credits = 3 },
                new Course { Id = 1045, Title = "Jogos Digitais", Credits = 4 },
                new Course { Id = 3141, Title = "Sistemas de Informacao", Credits = 4 },
                new Course { Id = 2021, Title = "Sistemas para Internet", Credits = 3 },
                new Course { Id = 2042, Title = "Banco de Dados", Credits = 4 },
                new Course { Id = 3042, Title = "Rede de Computadores", Credits = 4 }
            };

            foreach(var course in courses)
            {
                context.Add(course);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{ StudentId = 1,CourseId = 1050, Grade = Grade.A},
                new Enrollment{StudentId = 1, CourseId = 1050, Grade=Grade.A},
                new Enrollment{StudentId = 1, CourseId = 4022, Grade=Grade.C},
                new Enrollment{StudentId = 1, CourseId = 4041, Grade=Grade.B},
                new Enrollment{StudentId = 2, CourseId = 1045, Grade=Grade.B},
                new Enrollment{StudentId = 2, CourseId = 3141, Grade=Grade.F},
                new Enrollment{StudentId = 2, CourseId = 2021, Grade=Grade.F},
                new Enrollment{StudentId = 3, CourseId = 1050},
                new Enrollment{StudentId = 4, CourseId = 1050},
                new Enrollment{StudentId = 4, CourseId = 4022,Grade=Grade.F},
                new Enrollment{StudentId = 5, CourseId = 4041,Grade=Grade.C},
                new Enrollment{StudentId = 6, CourseId = 1045},
                new Enrollment{StudentId = 7, CourseId = 3141,Grade=Grade.A}
            };
            
            foreach(var enrollment in enrollments)
            {
                context.Add(enrollment);
            }
            context.SaveChanges();
        }
    }
}
