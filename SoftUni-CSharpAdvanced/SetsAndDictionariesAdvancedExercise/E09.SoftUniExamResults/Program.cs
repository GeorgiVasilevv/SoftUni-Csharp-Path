using System;
using System.Collections.Generic;
using System.Linq;

namespace E09.SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> studentResults = new Dictionary<string,int>();
            Dictionary<string,int> submissionResults = new Dictionary<string,int>();

            string command;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = command.Split('-');

                string studentName = tokens[0];
                string language = tokens[1];

                if (language == "banned")
                {
                    studentResults.Remove(studentName);
                    continue;
                }

                int points=int.Parse(tokens[2]);


                if (!studentResults.ContainsKey(studentName))
                {
                    studentResults.Add(studentName, 0);
                }

                if (studentResults[studentName] < points)
                {
                    studentResults[studentName] = points;
                }

                if (!submissionResults.ContainsKey(language))
                {
                    submissionResults.Add(language,0);
                }
                submissionResults[language]++;

            }

            Console.WriteLine("Results:");
            foreach (var student in studentResults.OrderByDescending(x=>x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var submission in submissionResults.OrderByDescending(x=>x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
