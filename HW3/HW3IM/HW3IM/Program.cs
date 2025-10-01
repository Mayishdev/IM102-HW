using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3IM
{
    class Program
    {
        static void chartonum(string charac)
        {
            Dictionary<char, int> charnum = new Dictionary<char, int>();

            
            charac = charac.ToLower();

            foreach (char inputs in charac)
            {
                if (inputs == ' ' || inputs == ',') continue;

                if (charnum.ContainsKey(inputs))
                    charnum[inputs]++;
                else
                    charnum[inputs] = 1;
            }

            foreach (var item in charnum)
            {
                Console.Write($"{item.Key}={item.Value}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {


            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');

            foreach (string part in parts)
            {
                Console.WriteLine($"Frequency for \"{part.Trim()}\":");
                chartonum(part.Trim());
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
