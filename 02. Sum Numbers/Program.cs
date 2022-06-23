using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a line of integers separated by ", ". Print on two lines the count of numbers and their sum. 

            string input =Console.ReadLine();
            Func<string, int> parsing = x =>int.Parse(x);
            int[] numbers=input.Split(", ").Select(parsing).ToArray();
            
            Action<string> print = x =>Console.WriteLine(x);            
            print(numbers.Length.ToString());
            print(numbers.Sum().ToString());

        }
    }
}
