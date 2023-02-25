using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string exerciseName = Console.ReadLine();
            int grade = 0;
            int badGradeCounter = 0;
            int counter = 0;
            double sum = 0;
            bool isFailed = false;
            string lastExercise = "";
            while (exerciseName != "Enough")
            {
                lastExercise = exerciseName;
                grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    badGradeCounter++;
                }

                if (badGrades <= badGradeCounter)
                {
                    isFailed = true;
                    break;
                }

                sum += grade;
                exerciseName = Console.ReadLine();

                counter++;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sum / counter:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
