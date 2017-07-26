using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Student
    {
        public Student(string name,int age,string number)
        {
            this.Name = name;
            this.Age = age;
            this.Number = number;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Number { get; set; }

        //public int CompareTo(Student otherStudent)
        //{
        //    int result = this.Age.CompareTo(otherStudent.Age);
        //    if (result != 0)
        //    {
        //        return result;
        //    }
        //    if (this.Name != otherStudent.Name)
        //    {
        //        return this.Name.CompareTo(otherStudent.Name);
        //    }

        //    return 0;
        //}
    }
}
