using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter a Collumn: ");
            int colum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<List<double>> numbers = new List<List<double>>();
            double totalsum = 0.0;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                numbers.Add(new List<double>());
                for (int  j= 0; j < colum; j++)
                {
                    Console.Write($"Enter Number {j + 1}: ");
                    double nums = double.Parse(Console.ReadLine());
                    numbers[i].Add(nums);
                    totalsum += nums;
                }
            }

            Console.WriteLine();

            Console.Write("The Numbers are:");
            for (int k = 0; k < numbers.Count; k++)
            {
                Console.WriteLine();
                for (int l = 0; l < numbers[k].Count; l++)
                {
                    Console.Write($"Number{k+1}: {numbers[k][l]}" + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"The total of Sum: {totalsum}; Average: {totalsum / (rows * colum)}");
            Console.ReadKey();
        }
    }
}
