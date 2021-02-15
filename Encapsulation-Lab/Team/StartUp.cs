using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split();
                    string firstName = input[0];
                    string lastname = input[1];
                    int age = int.Parse(input[2]);
                    decimal salary = decimal.Parse(input[3]);

                    Person person = new Person(firstName, lastname, age, salary);

                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.FirstTeam.Count} players.");

        }
    }
}
