﻿using School.Domain;
using School.Service;
using System;

namespace School.UI
{
    public abstract class IUI
    {
        public GradeService GradeService;

        public StudentService StudentService;

        public TeacherService TeacherService;

        public IUI(GradeService gradeService, StudentService studentService, TeacherService teacherService)
        {
            GradeService = gradeService;
            StudentService = studentService;
            TeacherService = teacherService;
        }

        public void Menu()
        {
            Console.WriteLine("0- Exit the menu");
            Console.WriteLine("1-");
        }

	}
}
