using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class CountDiv
{
    public static void Main(string[] args)
    {
        CountDiv p = new CountDiv();
        int a = 10, b = 6, c = 2;
        int d = p.Countdiv(a, b, c);
        Console.WriteLine(d);
    }

    public int Countdiv(int a, int b, int k)
    {
        if (b > a)
            return 0;
        else
            return a / k - b / k + (b % k == 0 ? 1 : 0);
    }

}
