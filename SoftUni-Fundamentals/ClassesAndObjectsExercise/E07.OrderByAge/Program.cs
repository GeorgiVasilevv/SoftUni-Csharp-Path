using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] tokens = cmd.Split().ToArray();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person1 = people.FirstOrDefault( p => p.Id== id );
                if (person1==null)
                {
                Person person= new Person(name,id,age);
                people.Add(person);

                }
                else
                {
                    person1.Age= age;
                    person1.Name= name;
                    person1.Id= id;
                }
                cmd = Console.ReadLine();
            }

            List<Person> orderedList = people.OrderBy(p => p.Age).ToList();

            foreach (Person person in orderedList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

    }
}
