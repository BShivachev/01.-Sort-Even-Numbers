using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads one line of double prices separated by ", ". Print the prices with added VAT for all of them. Format them to 2 signs after the decimal point. The order of the prices must be the same. 
            //VAT is equal to 20 % of the price. 

            string input = Console.ReadLine();
            decimal[] prices=input.Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse).ToArray();
            Func<decimal, decimal> addingVAT = price => price *= 1.2m;
            
            prices=prices.Select(addingVAT).ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
