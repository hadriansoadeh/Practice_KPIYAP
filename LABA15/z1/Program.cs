using System;
using System.Collections.Generic;

class MyList<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T this[int index]
    {
        get { return items[index]; }
    }

    public int Count
    {
        get { return items.Count; }
    }
}

class Program
{
    static void Main()
    {
        MyList<int> myNumbers = new MyList<int>();

        myNumbers.Add(10);
        myNumbers.Add(20);
        myNumbers.Add(30);

        for (int i = 0; i < myNumbers.Count; i++)
        {
            Console.WriteLine(myNumbers[i]);
        }
    }
}
