using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class OddOcurrences
{
    public static void Main(string[] args)
    {
        OddOcurrences odd = new OddOcurrences();    
        int[] a = { 1, 2, 3, 1, 2, 3, 5, 7 };
        int b = odd.OddOcuurences(a);
        Console.WriteLine(b);
    }

    public int OddOcuurences(int[] array)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        foreach (var item in array)
        {
            if (!dictionary.ContainsKey(item))
            {
                dictionary.Add(item, 1);
            }
            else
            {
                dictionary[item]++;

            }
        }

        var query = dictionary.Where(k => (k.Value % 2) != 0).ToDictionary(k => k.Key);
        foreach (var item in query)
        {
            Console.WriteLine(item.Key);
        }

        return 0;
    }
}
