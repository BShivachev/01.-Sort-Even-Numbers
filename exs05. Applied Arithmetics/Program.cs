using System;
using System.Collections.Generic;
using System.Linq;

namespace exs05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that executes some mathematical operations on a given collection. On the first line, you are given a list of numbers. On the next lines you are passed different commands that you need to apply to all the numbers in the list: 
            //            "add"->add 1 to each number
            //"multiply"->multiply each number by 2
            //"subtract"->subtract 1 from each number
            //"print"->print the collection
            //"end"->ends the input


            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> resultedList = new List<int>();
            Action<int[]> print = list => Console.WriteLine(string.Join(" ", list));
            Func<int, int> calculate = null;
            while (command != "end")
            {
                if (command != "print")
                {
                    calculate = GetCommand(command);
                    numbers = numbers.Select(calculate).ToArray();
                }
                else
                {
                    print(numbers);
                }
                command = Console.ReadLine();
            }
        }
        static Func<int, int> GetCommand(string command)
        {
            Func<int, int> result = null;
            if (command == "add")
            {
                result = number => number + 1;
            }
            else if (command == "multiply")
            {
                result = number => number *= 2;
            }
            else if (command == "subtract")
            {
                result = number => number -= 1;
            }

            return result;
        }
    }
}
