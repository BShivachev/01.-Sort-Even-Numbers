using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a collection of names as strings from the console, appends "Sir" in front of every name, and prints it back on the console. Use Action<T>. 

            //string names = Console.ReadLine();
            //string[] namesArr = names.Split(' ');
            //Action<string> action = name => Console.WriteLine($"Sir {name}");
            ////foreach (var item in namesArr)
            ////{
            ////    action(item);
            ////}
            //Array.ForEach(namesArr, action);

            List<string> names = Console.ReadLine().Split().ToList();
            //Func < име, модифицирано име>

              Func<string, string> addPrefix = name => "Sir " + name;

            foreach (string name in names)
            {
                Console.WriteLine(addPrefix(name));
            }
        }
    }
}
