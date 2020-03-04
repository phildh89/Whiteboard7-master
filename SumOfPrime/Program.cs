using System;

namespace SumOfPrime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfPrime.Program.Main()");

            Console.WriteLine(SumOfPrime(4));
        }
        public static int SumOfPrime(int num)
        {
            int primeCount = 0;
            int primeSum = 0;
            if (num < 0) return 0;
            int i = 2;


            while (primeCount < num)
            {
                if (IsPrime.Program.IsPrime(i))
                {
                    primeSum += i;
                    primeCount++;
                }

                i++;
            }

            return primeSum;
        }
    }
}
