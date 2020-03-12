using System;

namespace SumArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumArray.Program.Main()");

            double[] doubleArr = {2.0,-1.9 };
            Console.WriteLine(GetSumArray(doubleArr));
        }
        public static double GetSumArray(double[] arrInput)
        {
            double result = 0;
            foreach (var i in arrInput)
            {
                result += i;
            }


            return result;
        }
    }
}
