using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class CountCar
{
    public static void Main(string[] args)
    {
        CountCar p = new CountCar();    
        int[] a = { 0, 1, 0, 1, 1 };
        int d = p.MissingCar(a);
        Console.WriteLine(d);
    }

    public int MissingCar(int[] A)
    {
        int car = 0;
        int count = 0;
        int direction = 0;


        foreach (var i in A)
        {
            if (i == 0)
            {
                count++;
            }
            if (count > 0)
            {
                if (i == 1)
                {
                    direction = count + direction;
                    if (direction > 100000)
                        return -1;
                }
            }
        }

        return direction;
    }
}
