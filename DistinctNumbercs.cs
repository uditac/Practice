using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class DistinctNumbercs
{
    public static void Main(string[] args)
    {
        DistinctNumbercs distinct = new DistinctNumbercs();
        int[] a = { 2, 1, 1, 2, 3, 1 };
        int v = distinct.Distinct(a);
        Console.WriteLine(v);
        Console.ReadLine();
    }

    public int Distinct(int[] A)
    {
        var distinctArray = A.Select(x => x).Distinct().ToArray();

        return distinctArray.Sum();
    }
}
