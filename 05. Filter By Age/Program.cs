//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _05._Filter_By_Age
//{


//    internal class Program
//    {
//        class Person
//        {
//            public string Name { get; set; }
//            public int Age { get; set; }
//            public Person(string name, int age)
//            {
//                Name = name;
//                Age = age;
//            }
//        }


//        static void Main(string[] args)
//        {
//            int numOfInputs = int.Parse(Console.ReadLine());
//            List<Person> people = ReadAndAddPeopleToList(numOfInputs);
//            string condition = Console.ReadLine();
//            int treshold = int.Parse(Console.ReadLine());
//            string format = Console.ReadLine();            
//        }
//        private static List<Person> ReadAndAddPeopleToList(int number)
//        {
//            List<Person> peopleAdd = new List<Person>();
//            for (int i = 0; i < number; i++)
//            {
//                string input = Console.ReadLine();
//                string[] inputStr = input.Split(", ");
//                string name = inputStr[0];
//                int age = int.Parse(inputStr[1]);
//                peopleAdd.Add(new Person(name, age));

//            }
//            return peopleAdd;
//        }
//        private static List<Person> CreateFilter(string condition, int treshold, List<Person> list)
//        {
//            List<Person> result = new List<Person>();
//            if (condition == "younger")
//            {
//                result = list.Where(age => age.Age < treshold).ToList();
//            }
//            else if (condition == "older")
//            {
//                result=list.Where(age=>age.Age >= treshold).ToList();
//            }
//            return result;

//        }


//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;

class FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        // Read the list of people (name + age)
        List<Person> people = ReadPeople();

        // Read the condition + threshold
        string condition = Console.ReadLine();
        int ageThreshold = int.Parse(Console.ReadLine());
        Func<Person, bool> filter = CreatePersonFilter(condition, ageThreshold);

        // Filter all matching people by {condition + threshold}
        List<Person> matchingPeople = people.Where(filter).ToList();

        // Print all matching people in the specified format 
        string formatString = Console.ReadLine();
        Action<Person> printPerson = CreatePersonPrinter(formatString);
        PrintPeople(matchingPeople, printPerson);
    }

    static List<Person> ReadPeople()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            people.Add(new Person { Name = name, Age = age });
        }
        return people;
    }

    static Func<Person, bool> CreatePersonFilter(
        string condition, int ageThreshold)
    {
        if (condition == "older")
            return p => p.Age >= ageThreshold;
        if (condition == "younger")
            return p => p.Age < ageThreshold;
        throw new ArgumentException($"Invalid filter: {condition} {ageThreshold}");
    }

    static Action<Person> CreatePersonPrinter(string format)
    {
        if (format == "name age")
            return ( p) => Console.WriteLine($"{p.Name} - {p.Age}");
        if (format == "name")
            return ( p) => Console.WriteLine($"{p.Name}");
        if (format == "age")
            return ( p) => Console.WriteLine($"{p.Age}");
        throw new ArgumentException("Invalid format: " + format);
    }

    static void PrintPeople(List<Person> people, Action<Person> printPerson)
    {
        foreach (var person in people)
            printPerson(person);
    }
}
