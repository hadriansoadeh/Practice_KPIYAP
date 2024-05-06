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

static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
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

        int[] array = myNumbers.GetArray();

        Console.WriteLine("Значения в массиве:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
