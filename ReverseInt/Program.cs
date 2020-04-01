using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ReverseInt.Program.Main()");
            //Reverse(10, 15);

            Console.WriteLine(ReverseInt(-132165));
        }
        public static void Reverse(int x, int y)
        {
            y = x + y;
            x = y - x;
            y = y - x;



            Console.WriteLine($"x={x}, y={y}");
        }
        public static int ReverseInt(int input)
        {
            int result = 0;
            int lastNum = 0;
            bool isNegative = input < 0 ? true : false;
            if (input < 0)  //% wont work with negitive numbers
            {
                input *= -1;
            }
            while (input > 0)
            {
                lastNum = input % 10;
                result = result * 10 + lastNum;
                input = input / 10;
            }
            if (isNegative == true)
            {
                result *= -1;
            }
            return result;
        }
    }
}
