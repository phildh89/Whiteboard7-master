using System;

namespace CountCapitalLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CountCapitalLetters.Program.Main()");

            Console.WriteLine(CountCap("Welcome To The Jungle"));
        }
        public static int CountCap(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input.ToLower()[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
