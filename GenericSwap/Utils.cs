using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Utils
{

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a; 
        a = b;
        b = temp;
    }
    public static void SwapInArray<T>(T[] array, int index1,  int index2)
    {
        Swap(ref array[index1], ref array[index2]);
    }

    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        return array.Min();
    }
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        return array.Max();
    }
    public static void Reverse<T>(T[] array)
    {
        int first = 0;
        int last = array.Length - 1;
        while (first < last)
        {
            SwapInArray<T>(array, first, last);
            first++;
            last--;
        }
    }
}
