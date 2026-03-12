using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    private TKey[] _keys;
    private TValue[] _values;
    private int _count;
    public int Count { get { return _count; } }
    public Registry(int Capacity)
    {
        _keys = new TKey[Capacity];
        _values = new TValue[Capacity];
    }

    public void Register(TKey key, TValue value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_keys[i].Equals(key))
            {
                _values[i] = value;
                return;
            }
        }
        _keys[_count] = key;
        _values[_count] = value;
        _count++;
    }

    public TValue Find(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_keys[i].Equals(key))
            {
                return _values[i];
            }
        }
        return default;
    }
    public bool Contains(TKey key)
    {
        if (_keys.Contains(key))
        {
            return true;
        }
        return false;
    }
    
    public void PrintAll()
    {
        for(int i = 0; i < _count; i++)
        {
            Console.WriteLine($"[{_keys[i]}] {_values[i]}");
        }
    }
}
