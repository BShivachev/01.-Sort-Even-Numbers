using System;
using System.Collections.Generic;
using System.Linq;

namespace exs04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range=Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Predicate<int> predicate = GetStatus(command);

            
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (predicate(i))
                {
                    //numbers.Add(i);
                    Console.Write(i+" ");
                }
            }                        
        }
        static Predicate<int> GetStatus(string command)
        {
            Predicate<int> result=null;
            if (command== "even")
            {
                 result = number => number % 2 == 0;
            }
            if (command=="odd")
            {
                result = number => number % 2 != 0;
            }
            return result;
        }
         
    }
}
