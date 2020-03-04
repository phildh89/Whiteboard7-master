using System;

namespace ClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClockAngle.Program.Main()");
            Console.Write("Angle = ");
            Console.WriteLine(ClockAngle(11,1));
        }
        public static int ClockAngle(int hour, int minute)
        {
            if (hour > 12 || hour < 0 || minute < 0 || minute > 60)
            {
                Console.WriteLine("invalid entry");
            }
            else
            {
                int minAngle = 6 * minute;

                int hourAngle = 30 * hour;

                int angle = Math.Abs(minAngle - hourAngle);

                return angle;
            }


            return 0;
        }
    }
}
