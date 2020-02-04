using System;

// Write a program that calculates tuition over a five year 
// period. Tuition starts at $6000 and each year it increases 
// by 2%. You will display to the screen the following: For 
// year n your tuition will be x

namespace tuition
{
    class Program
    {
        public static void DiplayAnnualTuitionCost()
        {
            decimal tuition = 6000M;

            for (int year = 0; year < 5; year++)
            {
                Console.WriteLine($"For year {year + 1} your tuition will be {tuition}");
                tuition *= 1.02M;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("tuition.Program.Main()");
            DiplayAnnualTuitionCost();
        }
    }
}
