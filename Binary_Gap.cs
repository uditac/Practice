using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class Binary_Gap
{
    public static void Main(string[] args)
    {
        int n = 13;
        Console.WriteLine(p.binarygap(n));
    }

    public int binarygap(int n)
    {
        string bits = Convert.ToString(n, 2);
        int maxDiff = 0, newdiff = 0;
        char[] chars = bits.ToCharArray();

        if (chars.Length == 0)
        {
            return 0;
        }
        else
        {

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '1')
                {
                    for (int j = i + 1; j < chars.Length; j++)
                    {
                        if (chars[j] == '0')
                        {
                            newdiff++;
                        }
                        else
                        {
                            maxDiff = Math.Max(maxDiff, newdiff);
                            newdiff = 0;
                            break;
                        }
                    }
                }

            }
        }
        return maxDiff;

    }

}
