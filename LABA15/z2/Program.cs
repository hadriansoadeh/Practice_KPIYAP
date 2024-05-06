using System;
using System.Collections.Generic;

class MyDictionary<TKey, TValue>
{
    private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value)
    {
        dictionary.Add(key, value);
    }

    public TValue this[TKey key]
    {
        get { return dictionary[key]; }
    }

    public int Count
    {
        get { return dictionary.Count; }
    }
}

class Program
{
    static void Main()
    {
        MyDictionary<string, int> myNumbers = new MyDictionary<string, int>();

        myNumbers.Add("один", 1);
        myNumbers.Add("два", 2);
        myNumbers.Add("три", 3);

        Console.WriteLine("Общее количество пар ключ-значение: " + myNumbers.Count);

        Console.WriteLine("Значение для ключа 'два': " + myNumbers["два"]);
    }
}
