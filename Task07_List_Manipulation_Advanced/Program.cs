using System;
using System.Linq;
using System.Collections.Generic;

namespace Task07_List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string comand = string.Empty;

            bool isChanged = false;

            while (comand != "end")
            {
                string[] rawComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                comand = rawComand[0];
                if (comand == "Add")
                {
                    //int addNumber = int.Parse(rawComand[1]);
                    numbers.Add(int.Parse(rawComand[1]));
                    isChanged = true;
                }
                else if (comand == "Remove")
                {
                    numbers.Remove(int.Parse(rawComand[1]));
                    isChanged = true;
                }
                else if (comand == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(rawComand[1]));
                    isChanged = true;
                }
                else if (comand == "Insert")
                {
                    numbers.Insert(int.Parse(rawComand[2]), int.Parse(rawComand[1]));
                    isChanged = true;
                }
                else if(comand == "Contains")
                {
                    if(numbers.Contains(int.Parse(rawComand[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if(comand == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(numbers[i] % 2 == 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if(comand == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if(comand == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if(comand == "Filter")
                {
                    if(rawComand[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int filter = int.Parse(rawComand[2]);
                            if (numbers[i] < filter)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (rawComand[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int filter = int.Parse(rawComand[2]);
                            if (numbers[i] > filter)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (rawComand[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int filter = int.Parse(rawComand[2]);
                            if (numbers[i] <= filter)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (rawComand[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int filter = int.Parse(rawComand[2]);
                            if (numbers[i] >= filter)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            if(isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            
        }
    }
}
