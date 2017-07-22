using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CustomList
{
    public class CustomList<T> where T : IComparable<T>
    {
        private readonly IList<T> collection;
        public CustomList()
        {
            this.collection = new List<T>();
        }

        public int Count => this.collection.Count;

        public T this[int index]
        {
            get
            {
                return this.collection[index];
            }
        }

        public void Add(T element)
        {
            this.collection.Add(element);
        }

        public T Remove(int index)
        {
            var elementForRemovind = this.collection[index];
            this.collection.RemoveAt(index);
            return elementForRemovind;
        }

        public bool Contains(T element)
        {
            if (this.collection.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int a, int b)
        {
            T firstElement = this.collection[a];
            T secondElement = this.collection[b];
            this.collection[a] = secondElement;
            this.collection[b] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            int count = this.collection.Count(e => e.CompareTo(element) > 0);
            return count;
        }

        public T Max()
        {
            return this.collection.Max<T>();
        }

        public T Min()
        {
            return this.collection.Min<T>();
        }

        public void Print()
        {
            foreach (var el in this.collection)
            {
                Console.WriteLine(el);
            }
        }
    }
}
