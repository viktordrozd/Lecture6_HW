﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_HW
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student>? Students { get; set; } = new List<Student>();

        public string PrintCourse()
        {
            var result = "";

            result += $"CourseId - {CourseId} \n";
            result += $"CourseName - {CourseName} \n";
            result += $"Teacher - {Teacher.Name} \n";
            result += $"Students: {GetStudents()}";

            return result;
        }

        private string GetStudents()
        {
            if (Students.Count == 0)
            {
                return "None";
            }
            else
            {
                var str = "";
                foreach (var student in Students)
                {
                    str += student.Name + " ";
                }
                return str;
            }

        }
    }
}
