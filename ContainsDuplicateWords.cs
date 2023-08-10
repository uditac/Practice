using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class ContainsDuplicateWords
{
    public static void Main(string[] args)
    {
        ContainsDuplicateWords p = new ContainsDuplicateWords();
        string[] A = { "co", "dil", "ity" };
        int length = p.solution(A);
        Console.WriteLine(length);

        Console.ReadLine();
    }

    public int solution(string[] A)
    {
        String S = string.Empty;
        List<string> S2 = new List<string>();
        bool containsDuplicates = false;
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                S = A[i] + A[j];
                containsDuplicates = HasUniqueCharacters(S);
                if (containsDuplicates == false)
                    S2.Add(S);
                S = string.Empty;
            }
        }
        var longest = S2.OrderByDescending(x => x.Length).First();
           int length = longest.Length;
        return length;

    }

    public static bool HasUniqueCharacters(string input)
    {
        HashSet<char> uniqueChars = new HashSet<char>();

        foreach (char c in input)
        {
            if (uniqueChars.Contains(c))
                return false;

            uniqueChars.Add(c);
        }

        return true;
    }
}
