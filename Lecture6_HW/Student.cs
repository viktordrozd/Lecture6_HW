using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_HW
{
    public class Student : Person
    {
        public List<Course>? Courses { get; set; }

        public Student(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string DescribeYourself()
        {
            return $"Student: Name - {Name}, Age - {Age}";
        }
    }
}
