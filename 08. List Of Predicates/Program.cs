using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find all numbers in the range 1...N that is divisible by the numbers of a given sequence. On the first line, you will be given an integer N – which is the end of the range.On the second line, you will be given a sequence of integers which are the dividers.Use predicates/ functions.


            int n = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();


            List<int> numbers = new List<int>(); //всички числа от 1 до n
            for (int number = 1; number <= n; number++)
            {
                numbers.Add(number);
            }

            List<int> printNumbers = new List<int>(); //числата, които се делят на всички делители

            foreach (int number in numbers)
            {
                bool isDivisible = true;
                //true -> ако числото се дели на всички делители
                //false -> ако числото не се дели на всички делители

                //ако се дели на всички числа без остатък от dividers
                foreach (int divider in dividers)
                {
                    //приема число -> дали числото се дели на divider
                    Predicate<int> divisible = number => number % divider == 0;
                    //true -> числото се дели на текущия делител
                    //false -> числото не се дели на текущия делител
                    if (!divisible(number)) //number % divider == 0
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    printNumbers.Add(number);

                }
            }

            Console.WriteLine(string.Join(" ", printNumbers));
        }
    }
}
