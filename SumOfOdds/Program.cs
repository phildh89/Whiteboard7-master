using System;

namespace SumOfOdds
{
    class Program
    {
        public static int GetSumOfOdds(int nCount)
        {
            int sum = 0;
            int nextOddNumber = 1;

            for (int i = 0; i < nCount; i++)
            {
                //sum = sum + nextOddNumber;
                sum += nextOddNumber;

                // nextOddNumber = nextOddNumber +2;
                nextOddNumber += 2;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tSumOfOdds.Program.Main()");

            int n = 3;
            Console.WriteLine($"\tsum of first {n} odds is: {GetSumOfOdds(n)}");
        }
    }
}
