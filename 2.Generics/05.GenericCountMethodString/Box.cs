using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        private readonly IList<T> data;
        private int counter = 0;
        public Box()
        {
            this.data = new List<T>();
        }

        public void InsertItems(T item)
        {
            this.data.Add(item);
        }

        public int GetCounter { get { return this.counter; } }
        public void Comper(T compererItem)
        {
            foreach (var item in this.data)
            {
                if (item.CompareTo(compererItem) > 0)
                {
                    counter++;
                }
            }
        }

    }
}
