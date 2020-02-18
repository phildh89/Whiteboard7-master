using System;

namespace DistinctCountArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DistinctCountArray.Program.Main()");

            int[] example = { 2, 3, 5, 6, 2 };


            Console.WriteLine(DistinctCount(example));
        }
        public static int DistinctCount(int[] inputArray)
        {
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isNew = true;
                for (int k = 0; k < i; k++)
                {
                    if (inputArray[k] == inputArray[i])
                    {
                        isNew = false;
                    }

                }
                if(isNew == true)count++;

            }


            return count;
        }


    }
}
