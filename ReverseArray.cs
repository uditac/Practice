using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice;

public class ReverseArray
{
    public static void Main(string[] args)
    {
        var p = new ReverseArray();
        int[] array = { 5, 7, 8, 4, 2, 1 }; int start = 0, end = 5;
       
        p.Reverse_Array(array, start, end);
      
    }

    public void Reverse_Array(int[] array, int start, int end)
    {
        int temp;
        while (start < end)
        {
            temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }

    }
}
