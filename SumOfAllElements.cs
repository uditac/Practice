using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class SumOfAllElements
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 7, 8, 4, 2, 1 };
        var p = new SumOfAllElements();
        Console.WriteLine(p.SumOfAll_Elements(array));
    }
    public int SumOfAll_Elements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }


}
