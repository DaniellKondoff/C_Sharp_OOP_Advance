using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CustomList
{
    public static class Sorter
    {

        public static void Sort<T>(CustomList<T> collection) where T : IComparable<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                var firstElement = collection[i];

                for (int j = i+1; j < collection.Count; j++)
                {
                    var secondElement = collection[j];

                    if (firstElement.CompareTo(secondElement) > 0)
                    {
                        collection.Swap(i, j);
                    }
                }
            }
        }
    }
}
