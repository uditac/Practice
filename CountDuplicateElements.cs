using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class CountDuplicateElements
{

    public static void Main(string[] args)
    {
        CountDuplicateElements c = new CountDuplicateElements();
        int numOfElements = 6;
        int[] array = { 5, 7, 8, 4, 2, 1 };
        Console.WriteLine(c.MethodFunc(array,numOfElements));
    }

    public int MethodFunc(int[] array, int numOfElements)
    {
        int numberOfDuplElemenets = 0;

        // copy the array in another

        int[] outputArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            outputArray[i] = array[i];
        }

        // find duplicates

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < outputArray.Length; j++)
            {
                //            if (array[i] == outputArray[j])
                {
                    numberOfDuplElemenets++;
                    break;
                }
            }

        }

        return numberOfDuplElemenets;

    }

}

