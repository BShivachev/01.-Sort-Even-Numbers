using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads one line of integers separated by ", ". Then prints the even numbers of that sequence sorted in increasing order.
            
            //Combined way
            //string input =Console.ReadLine();
            //int[] inputNum= input.Split(", ").Select(x => int.Parse(x)).ToArray();
            //int[] evenNum=inputNum.Where(x => x %2== 0).ToArray();
            //int[] sortedNum=evenNum.OrderBy(x => x).ToArray();
            //Console.WriteLine(string.Join(", ",sortedNum));

            //Functional way:

            Console.WriteLine(string.Join(", ",
                Console.ReadLine()
                .Split(", ")
                .Select(x=>int.Parse(x))
                .Where(x=>x%2==0)
                .OrderBy(x=>x)
                .ToArray()
                ));

        }
    }
}
