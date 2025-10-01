using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace im102
{
    class Program
    {
     

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter string: ");
                string instri = Console.ReadLine();

                if (instri == "*")
                {
                    Console.WriteLine("Invalid Input!!!!");
                    break;
                }

                string original = instri;
                string lowerInput = instri.ToLower();

                string reversed = "";
                for (int i = lowerInput.Length - 1; i >= 0; i--)
                {
                    reversed += lowerInput[i];
                }

                
                string result = (lowerInput == reversed) ? "Yes" : "No";

                Console.WriteLine($"Original String: {original}");
                Console.WriteLine($"Reversed String: {reversed}");
                Console.WriteLine($"Palindrome? {result}");

            }

            Console.ReadKey();
        }
    }
}
