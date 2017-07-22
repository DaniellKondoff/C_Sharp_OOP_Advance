using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericSwapMethodString
{
    
    public class Box<T>
    {
        private readonly IList<T> collection;
        public Box()
        {
            this.collection = new List<T>();
        }
        public T Value { get; }

        public void InsertItems(T item)
        {
            this.collection.Add(item);
        }
        public void Swap(int a, int b)
        {
            T firstElement = this.collection[a];
            T secondElement = this.collection[b];
            this.collection[a] = secondElement;
            this.collection[b] = firstElement;
        }

        public void PrintElements()
        {
            foreach (var element in this.collection)
            {
                Console.WriteLine($"{element.GetType().FullName}: {element.ToString()}");
            }
        }
        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
