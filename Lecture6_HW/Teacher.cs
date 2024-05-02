using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_HW
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public override string DescribeYourself()
        {
            return $"Teacher: Name - {Name}, Age - {Age}";
        }
    }
}
