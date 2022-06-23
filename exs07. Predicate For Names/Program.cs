using System;
using System.Collections.Generic;

namespace exs07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that filters a list of names according to their length. On the first line, you will be given an integer n, representing a name's length. On the second line, you will be given some names as strings separated by space. Write a function that prints only the names whose length is less than or equal to n. 

            int lenghtOfNames=int.Parse(Console.ReadLine());
            
            List<string> namesList = new List<string>(Console.ReadLine().Split());
            Predicate<string> equalLenght=name=>name.Length<=lenghtOfNames;            
            //namesList.FindAll(equalLenght).ForEach(Console.WriteLine);
            Console.WriteLine(string.Join("\n", namesList.FindAll(equalLenght)));

        }
    }
}
