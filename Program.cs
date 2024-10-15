using System;
using System.Collections;

public class MyList : IList
{
    private object[] _items = new object[10];

    public int Count
    {
        get { return _count; }
    }

    private int _count = 0;

    public bool IsFixedSize
    {
        get { return true; }
    }

    public bool IsReadOnly
    {
        get { return false; }
    }

    public bool IsSynchronized
    {
        get { return false; }
    }

    public object SyncRoot
    {
        get { return this; }
    }

    public object this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            return _items[index];
        }
        set
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            _items[index] = value;
        }
    }

    public int Add(object value)
    {
        if (_count >= _items.Length)
            throw new InvalidOperationException("List is full");
        _items[_count] = value;
        _count++;
        return _count - 1;
    }

    public void Clear()
    {
        _count = 0;
    }

    public bool Contains(object value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_items[i].Equals(value))
                return true;
        }
        return false;
    }

    public int IndexOf(object value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_items[i].Equals(value))
                return i;
        }
        return -1;
    }

    public void Insert(int index, object value)
    {
        if (index < 0 || index > _count)
            throw new IndexOutOfRangeException();
        if (_count >= _items.Length)
            throw new InvalidOperationException("List is full");
        for (int i = _count; i > index; i--)
        {
            _items[i] = _items[i - 1];
        }
        _items[index] = value;
        _count++;
    }

    public void Remove(object value)
    {
        int index = IndexOf(value);
        if (index != -1)
            RemoveAt(index);
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException();
        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        _count--;
    }

    public void CopyTo(Array array, int index)
    {
        for (int i = 0; i < _count; i++)
        {
            array.SetValue(_items[i], index++);
        }
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _items[i];
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList list = new MyList();
        list.Add("Hello");
        list.Add("World");
        list.Add("!");

        Console.WriteLine("Count: " + list.Count);

        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        list.RemoveAt(1);

        Console.WriteLine("Count: " + list.Count);

        foreach (object item in list)
        {
            Console.WriteLine(item);
        }
    }
}