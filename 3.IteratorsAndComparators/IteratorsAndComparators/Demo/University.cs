using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class University : IEnumerable<Student>
    {
        public University()
        {
            this.Students = new List<Student>();
        }
        private IList<Student> Students { get; }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            //return this.Students.GetEnumerator();
            //return new UnyIterator(this.Students);
            for (int i = 0; i < this.Students.Count; i+=2)
            {
                yield return this.Students[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        

        private class UnyIterator : IEnumerator<Student>
        {
            private int currentIndex;
            private readonly IList<Student> students;

            public UnyIterator(IList<Student> students)
            {
                this.Reset();
                this.students = students;
            }

            public Student Current
            {
                get
                {
                    return this.students[currentIndex];
                }
            }

            object IEnumerator.Current => this.Current;
           

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return (this.currentIndex += 2) < this.students.Count;
            }

            public void Reset()
            {
                this.currentIndex = -2;
            }
        }
    }
}
