using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class TennisTournament
{
    public static void Main(string[] args)
    {
        TennisTournament p = new TennisTournament();
        int k = 5, c = 5;
        int o = p.solution(k, c);
        Console.WriteLine(o);
        Console.ReadLine();
    }

    public int solution(int p, int c)
    {
        int noOfGrps = p / 2;
        if ((p < 300000 && p > 1) && (c < 300000 && c > 1))
        {
            if (noOfGrps < c)
            {
                return noOfGrps;
            }
            else
            {
                return c;
            }
        }
        return -1;


    }
}
