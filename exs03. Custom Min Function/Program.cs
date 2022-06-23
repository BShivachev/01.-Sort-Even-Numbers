using System;
using System.Linq;

namespace exs03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple program that reads from the console a set of integers and prints back on the console the smallest number from the collection. Use Func<T, T>. 

            int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Func<int[],int> func = x=>x.Min();
            Console.WriteLine(func(numbers));
        }
    }
}
