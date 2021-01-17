using System;
using System.Linq;
using System.Collections.Generic;

namespace Task05_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i -= 1;
                }
            }

            if(numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
