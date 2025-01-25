using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first grade: ");
            int firstgrade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second grade: ");
            int secondgrade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third grade: ");
            int thirdgrade = Convert.ToInt32(Console.ReadLine());


            int average = CalculateAverage(firstgrade, secondgrade, thirdgrade);
            string grade = DetermineGrade(average);

            Console.WriteLine($"Average Marks: {average}");
            Console.WriteLine($"Grade: {grade}");




        }

        static int CalculateAverage(int firstgrade, int secondgrade, int thirdgrade)
        {
            int average = (firstgrade + secondgrade + thirdgrade) / 3;
            return average;
        }

        static string DetermineGrade(int average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80 && average < 90)
            {
                return "B";
            }
            else if (average >= 70 && average < 80)
            {
                return "C";
            }
            else if (average >= 60 && average < 70)
            {
                return "D";
            }
            else
            {
                return "F!";
            }
            
        }
    }
}
