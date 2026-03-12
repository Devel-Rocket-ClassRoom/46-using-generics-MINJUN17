using System;
using System.Collections.Generic;
using System.Text;

class MyStack<T>
{
    private T[] _stack;
    private int _stackCount = 0;
    public int Count
    {
        get { return _stackCount; }
    }
    public bool IsEmpty
    {
        get { return _stackCount == 0; }
    }

    public MyStack(int capacity)
    {
        _stack = new T[capacity];
    }
    public void Push(T item)
    {
        _stack[_stackCount] = item;
        _stackCount++;
    }
    public T Pop()
    {
        _stackCount--;
        T item = _stack[_stackCount];
        _stack[_stackCount] = default;
        return item;
    }
    public T Peek()
    {
        return _stack[_stackCount - 1];
    }
    
}
