using System;

namespace IsPrime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IsPrime.Program.Main()");

            Console.WriteLine(IsPrime(7));

        }
        public static bool IsPrime(int num)
        {
            if (num < 2) return false; //because prime numbers are above 2
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
