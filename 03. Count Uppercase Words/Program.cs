using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a line of text from the console. Print all the words that start with an uppercase letter in the same order you've received them in the text.
            Func<string,bool> func = (x =>x[0]==x.ToUpper()[0]);
            //Predicate<string> predicate = (x => x[0]==x.ToUpper()[0]);
            string input=Console.ReadLine();
            string[] wordsArr=input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string[] words=wordsArr.Where(word=>func(word)).ToArray();
            Action<string[]> print = upperWord => Console.WriteLine(string.Join("\n", upperWord));
            print(words);

        }
    }
}
