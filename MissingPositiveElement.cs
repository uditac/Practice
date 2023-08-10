using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class MissingPositiveElement
{
     public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3 };
        MissingPositiveElement p = new MissingPositiveElement();
        int n = p.MissingPositive_Element(a);
        Console.WriteLine(n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.ReadLine();
    }

    public int MissingPositive_Element(int[] a)
    {
        int n = a.Length;
        bool[] present = new bool[n + 1];

        for (int i = 0; i < n; i++)
        {
            if ((a[i] > 0) && (a[i] <= n))
            {
                present[a[i]] = true;
                Console.WriteLine(present[a[i]]);
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (!present[i] == false)
            {
                return i;
            }
        }
        return n + 1;
    }

}
