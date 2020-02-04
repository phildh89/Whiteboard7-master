using System;

// this file contains a monte carlo simulation and 
// infinite loop to progressively provide an estimation
// of pi. It needs to be run monitored, because it 
// requires user intervention to stop it.  
namespace pi
{
    class Program
    {
        public static Tuple<double,double> GetCoords(Random r)
        {
            double A=0.0;
            double B=0.0;

            return Tuple.Create(A, B);
        }

        public static double Radius(double X, double Y) => Math.Sqrt(X * X + Y * Y);

        public static void EstimatePi()
        {
            // initialize random
            Random r = new Random();
            int exponent = 1;

            while(true)
            {
                // reset counters
                exponent++;
                int iterations;
                int inCircleCount = 0;

                // run through monte carlo method
                for (iterations = 1; iterations < Math.Pow(10,exponent); iterations++)
                {
                    double X = r.NextDouble();
                    double Y = r.NextDouble();
                    double Z = Radius(X, Y);
                    //inCircleCount += (Z <= 1) ? 1 : 0;
                    if (Z <= 1.0) inCircleCount++;
                }

                // print the result
                Console.WriteLine((double)4.0 * (double)inCircleCount / (double)iterations);
            }
            
        }
        static void Main(string[] args)
        {
            EstimatePi();
            Console.WriteLine("pi.Program.Main()");
        }
    }
}
