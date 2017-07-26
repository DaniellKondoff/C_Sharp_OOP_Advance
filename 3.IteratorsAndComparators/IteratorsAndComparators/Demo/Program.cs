using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("pesho", 70, "123456");
            Student studentTwo = new Student("admin", 70, "123456");
            Student studentThree = new Student("Gosho", 50, "123456");

            University uni = new University();
            uni.AddStudent(studentOne);
            uni.AddStudent(studentTwo);
            uni.AddStudent(studentThree);

            //foreach (var student in uni)
            //{
            //    Console.WriteLine(student.Name);
            //}


            //Camparable Part

            SortedSet<Student> sortedStudents = new SortedSet<Student>(new StudentComparator());
            sortedStudents.Add(studentOne);
            sortedStudents.Add(studentTwo);
            sortedStudents.Add(studentThree);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
