using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class Rotate_Array
{
    public static void Main(string[] args)
    {
        int k = 3; int[] a = { 2, 3, 4, 5 };
        int len = a.Length;
        int[] B = new int[len]; B = p.rotatearray(a, k);

        for (int i = 0; i < a.Length; i++) { Console.WriteLine("{0}", B[i]); }
        Console.ReadLine();
        Console.WriteLine(p.rotatearray(a, k));
    }

    public int[] rotatearray(int[] a, int k)
    {
        int[] B = new int[a.Length];

        if (a.Length > 0 && k != 0)
        {
            for (int i = 0; i < a.Length; i++)
            {
                B[(k + i) % (a.Length)] = a[i];

            }

        }
        else
        {
            return a;
        }
        return B;
    }

}


