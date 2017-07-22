using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box<T>
{
    private readonly IList<T> collectionBox;

    public Box()
    {
        this.collectionBox = new List<T>();
    }

    public int Count { get { return this.collectionBox.Count; } }
    public void Add(T element)
    {
        collectionBox.Add(element);
    }

    public T Remove()
    {
        var lastOne = this.collectionBox.Last<T>();
        this.collectionBox.RemoveAt(this.collectionBox.Count-1);
        return lastOne;
    }
}

