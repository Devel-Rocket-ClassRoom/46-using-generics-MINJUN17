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
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
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
            T temp = array[first];
            array[first] = array[last];
            array[last] = temp;

            first++;
            last--;
        }
    }
}
