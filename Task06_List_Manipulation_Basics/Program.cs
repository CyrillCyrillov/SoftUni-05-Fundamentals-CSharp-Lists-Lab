using System;
using System.Linq;
using System.Collections.Generic;

namespace Task06_List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string comand = string.Empty;

            while(comand != "end")
            {
                string[] rawComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                comand = rawComand[0];
                if(comand == "Add")
                {
                    //int addNumber = int.Parse(rawComand[1]);
                    numbers.Add(int.Parse(rawComand[1]));
                }
                else if(comand == "Remove")
                {
                    numbers.Remove(int.Parse(rawComand[1]));
                }
                else if(comand == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(rawComand[1]));
                }
                else if(comand == "Insert")
                {
                    numbers.Insert(int.Parse(rawComand[2]), int.Parse(rawComand[1]));
                }
            }
            
            
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
