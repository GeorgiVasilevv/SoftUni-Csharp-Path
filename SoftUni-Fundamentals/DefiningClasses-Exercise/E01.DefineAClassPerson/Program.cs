using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //Person person = new Person(name,age);
            //Console.WriteLine(person.Name + " " + person.Age);

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age= int.Parse(personInfo[1]);

                Person person = new Person(name,age);
                family.AddMember(person);
            }
            //Person oldest = family.GetOldestMember();
            //Console.WriteLine($"{oldest.Name} {oldest.Age}");

            List<Person> sortedFamily = family.People
                .FindAll(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var member in sortedFamily)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
