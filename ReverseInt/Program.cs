using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReverseInt.Program.Main()");
            Reverse(10, 15);
        }
        public static void Reverse(int x, int y)
        {
            y = x + y;
            x = y - x;
            y = y - x;



            Console.WriteLine($"x={x}, y={y}");
        }
    }
}
