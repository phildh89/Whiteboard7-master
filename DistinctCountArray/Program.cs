using System;

namespace DistinctCountArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DistinctCountArray.Program.Main()");

            int[] example = { 2, 7,15,15,1,10,15,2,7 };


            Console.WriteLine(DistinctCount(example));
        }
        public static int DistinctCount(int[] inputArray)
        {
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isNew = true;
           
                    for (int k = i-1; k > 0; k--)
                    {

                        if (inputArray[k] == inputArray[i])
                        {
                            isNew = false;
                            break;
                        }

                    }
                
                if(isNew == true)count++;

            }


            return count;
        }


    }
}
