using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class CopyArrayElements
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 7, 8, 4, 2, 1 };
        int[] array2 = p.CopyElements(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Elements of the array is {0}", array2[i]);
        }

        Console.ReadLine();
    }

    public int[] CopyElements(int[] array)
    {
        int[] outputArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            outputArray[i] = array[i];
        }
        return outputArray;
    }


}
