using System;

namespace exs01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a collection of strings from the console and then prints them onto the console. Each name should be printed on a new line. Use Action<T>. 

            string names = Console.ReadLine();
            string[] namesArr= names.Split(' ');
            Action<string> action = name => Console.WriteLine(name);
            //foreach (var item in namesArr)
            //{
            //    action(item);
            //}
            Array.ForEach(namesArr,action);
        }
    }
}
