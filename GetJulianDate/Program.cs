using System;

namespace GetJulianDate
{
    public class Program
    {
        public static int[] Month = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        static void Main(string[] args)
        {
            Console.WriteLine("GetJulianDate.Program.Main()");

            Console.WriteLine($"\n\n\tJulian date: {ConvertToJulian(1, 0)}");
        }

        public static int ConvertToJulian(int month, int day)
        {
            int julianMonth = 0;

            //TODO: Limit month and day input to give valid date. >0 and 13>month

            for (int i = 0; i < month - 1; i++)
            {
                julianMonth += (Month[i]);
            }



            return julianMonth + day;
        }
    }
}
