using System.Buffers.Text;

namespace Lecture6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Based on the work that was done in homework 5: 
            //-add class Teacher. The Student class and the Teacher class must have a common base class from which they will be inherited.
            //- In the base class (from the previous paragraph) add the Describe Yourself method. (Alternative print) 
            //- Override the Describe Yourself method in the Student class and in the Teacher class.

            var person1 = new Person("Person1", 20);

            var course = new Course();

            var teacher1 = new Teacher("Teacher1", 40);

            var student = new Student("Student1", 30);
            var student2 = new Student("Student2", 35);


            course.CourseId = "01";
            course.CourseName = "Course1";
            course.Teacher = teacher1;
            course.Students.Add(student);
            course.Students.Add(student2);


            Console.WriteLine("Printing object from base class Person:");
            Console.WriteLine(person1.DescribeYourself() + "\n");

            Console.WriteLine("Printing object from derived class Student:");
            Console.WriteLine(student.DescribeYourself() + "\n");
            Console.WriteLine(student2.DescribeYourself() + "\n");

            Console.WriteLine("Printing object from derived class Teacher:");
            Console.WriteLine(teacher1.DescribeYourself() + "\n");

            Console.WriteLine("Printing Course:");
            Console.WriteLine(course.PrintCourse());

        }
    }
}
