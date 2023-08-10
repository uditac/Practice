using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice;

public class Brackets
{
    public static void Main(string[] args)
    {
        Brackets p = new Brackets();

        string s = "{[()()]}";
        int v = p.Brackets_find(s);
        Console.WriteLine(v);
        Console.ReadLine();


    }

     public int Brackets_find(string s)
    {
        if (s.Length > 20000) throw new ArgumentOutOfRangeException();
        if(string.IsNullOrEmpty(s)) return 0;
        var stack = new Stack<char>(s.Length);
       foreach(var value in stack)
        {
            switch(value)
            {
                case '{':
                case '[':
                case '(':
                    stack.Push(value); break;
                case '}':
                    if(stack.Count == 0 || stack.Pop()!='}')
                        return 0;
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != ']')
                        return 0;
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '}')
                        return 0;
                    break;
                default: return 0;

            }
           

           
        }

        if (stack.Count != 0)
            return 0;
        return 1;
    }

}
