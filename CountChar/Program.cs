using System;

namespace CountChar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CountChar.Program.Main()");
            Console.WriteLine(CountChar("Something sd fs1331333!"));
        }
        public static int CountChar(string input)
        {
            int count = 0;
            foreach (char i in input)
            {
                if ((i >='a' && i <='z') || (i>='A' && i<='Z'))
                {
                    count++;
                }
            }


            return count;
        }
    }
}
