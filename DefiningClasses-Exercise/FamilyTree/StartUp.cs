using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    public class StartUp
    {
        static List<Person> persons;
        static List<string> relationships;

        public static void Main(string[] args)
        {
            persons = new List<Person>();
            relationships = new List<string>();

            string mainPersonInfo = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("-") == false)
                {
                    AddMember(input);
                    input = Console.ReadLine();
                    continue;
                }

                relationships.Add(input);

                input = Console.ReadLine();
            }

            foreach (var memberInfo in relationships)
            {
                string[] inputArgs = memberInfo.Split(" - ",StringSplitOptions.RemoveEmptyEntries);

                Person parent = GetPerson(inputArgs[0]);
                Person child = GetPerson(inputArgs[1]);


                if (parent.Children.Contains(child) == false)
                {
                    parent.Children.Add(child);
                }
                if (child.Parents.Contains(parent) == false)
                {
                    child.Parents.Add(parent);
                }
            }

            Print(mainPersonInfo);
        }

        private static void Print(string mainPersonInfo)
        {
            Person mainPerson = GetPerson(mainPersonInfo);

            Console.WriteLine($"{mainPerson.Name} {mainPerson.Birthday}");
            Console.WriteLine("Parents:");

            foreach (var parent in mainPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");

            }

            Console.WriteLine("Children:");

            foreach (var child in mainPerson.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }

        private static Person GetPerson(string input)
        {
            if (input.Contains("/"))
            {
                return persons.FirstOrDefault(x => x.Birthday == input);
            }

            return persons.FirstOrDefault(x => x.Name == input);
        }

        private static void AddMember(string input)
        {
            string[] inputInfo = input.Split();
            string name = inputInfo[0] + " " + inputInfo[1];
            string birthday = inputInfo[2];

            Person person = new Person(name, birthday);
            persons.Add(person);
        }
    }
}
