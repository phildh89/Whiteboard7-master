using System;

namespace SumOfPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfPrime.Program.Main()");

            Console.WriteLine(SumOfPrime(1));
        }
        public static int SumOfPrime(int num)
        {
            int primeCount = 0;
            int primeSum = 0;
            if (num < 0) return 0;
            for (int i = 2; primeCount <= num; i++)
            {
                if (num % i == 0)
                {
                    continue;
                }
                
                primeSum+= i;
                primeCount++;
            }

            return primeSum;
        }
    }
}
