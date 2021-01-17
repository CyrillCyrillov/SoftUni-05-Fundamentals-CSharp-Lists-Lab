using System;
using System.Linq;
using System.Collections.Generic;


namespace Task03_Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listOne = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            
            List<double> listTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            bool addOperation = false;
            if(listOne.Count == listTwo.Count)
            {
                addOperation = true;
            }

            int indexOfListTwo = 0;
            
            for (int i = 0; i < listOne.Count - 1; i += 2)
            {
                listOne.Insert(i + 1, listTwo[indexOfListTwo]);
                indexOfListTwo += 1;
                if(indexOfListTwo > listTwo.Count - 1)
                {
                    break;
                }
            }

            if(indexOfListTwo < listTwo.Count - 1)
            {
                for (int i = indexOfListTwo; i <= listTwo.Count - 1; i++)
                {
                    listOne.Add(listTwo[i]);
                }
            }

            if(addOperation)
            {
                listOne.Add(listTwo[listTwo.Count - 1]);
            }

            Console.WriteLine(String.Join(' ', listOne));
        }
    }
}
