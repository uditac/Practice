using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class FrogJump
{
    public static void Main(string[] args)
    {
        FrogJump p = new FrogJump();
        int[] a = { 100, 101, 101 }; int x = 101;
        int i = p.FrogJumpRiver(a, x);
        Console.WriteLine(i);
        Console.ReadLine();
    }

    public int FrogJumpRiver(int[] a, int x)
    {
        int i = 0;

        //    possible solution
        if ((a.Length != 0) || (x != 0))
        {
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }


            }
        }
        return i;
    }
}
