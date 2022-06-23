using System;
using System.Collections.Generic;
using System.Linq;


namespace exs06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reverses a collection and removes elements that are divisible by a given integer n. Use predicates/functions. 

            int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int divideNum=int.Parse(Console.ReadLine());
            Func<int[],int[]> reverse = arr => arr.Reverse().ToArray();
            Predicate <int> isDividable= number=>number%divideNum!=0;
            List<int> resultList = reverse(numbers).ToList();
                //.Where(i => !isDividable(i)).ToList();
            
            
            Console.WriteLine(string.Join(" ",resultList.FindAll(isDividable)));
        }
    }
}
