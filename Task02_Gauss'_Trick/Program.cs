using System;
using System.Linq;
using System.Collections.Generic;

namespace Task02_Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            int midleOfList = numbers.Count / 2;

            for (int i = 0; i < midleOfList; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
