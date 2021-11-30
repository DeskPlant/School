using School.DataBase;
using School.Domain;
using School.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace School
{
	/*
	teacher 1-n courses

	student n-n courses

	CRUD operations
	*/


	public class Program
	{
		public static readonly string ConnectionString = ConfigurationManager.AppSettings.Get("connection-string");

		public static void Main()
		{
            System.Console.ForegroundColor = System.ConsoleColor.Magenta;
            SchoolContext schoolContext = new(ConnectionString);

			TeacherRepository repo = new(schoolContext);


			foreach (var item in repo.GetAll())
			{
				Console.WriteLine(item);
			}


           // repo.Delete(repo.GetAll().ElementAt(0).Id);

            //List<Grade> grades = new()
            //{
            //    new Grade { Id = Guid.NewGuid(), Value = 5, Subject = "Math" },
            //    new Grade { Id = Guid.NewGuid(), Value = 7, Subject = "Biology" },
            //    new Grade { Id = Guid.NewGuid(), Value = 4, Subject = "Chemistry" },
            //    new Grade { Id = Guid.NewGuid(), Value = 10, Subject = "Physics" },
            //    new Grade { Id = Guid.NewGuid(), Value = 10, Subject = "Computer Science" }
            //};

            //List<Teacher> teachers = new()
            //{
            //    new Teacher { Id = Guid.NewGuid(), FirstName = "Steve", LastName = "Jobs", Students = null },
            //    new Teacher { Id = Guid.NewGuid(), FirstName = "Abhimanyu", LastName = "Vatsa", Students = null }
            //};

            //List<Student> students = new()
            //{
            //    new Student { Id = Guid.NewGuid(), FirstName = "Student0", LastName = "Stu0", Teachers = teachers, Grades = new List<Grade> { grades[0], grades[1] } },
            //    new Student { Id = Guid.NewGuid(), FirstName = "Student1", LastName = "Stu1", Teachers = teachers, Grades = new List<Grade> { grades[2], grades[3] } }
            //};

            //schoolContext.Grades.AddRange(grades);

            //schoolContext.Teachers.AddRange(teachers);

            //schoolContext.Students.AddRange(students);

            //schoolContext.SaveChanges();
        }
	}
}
