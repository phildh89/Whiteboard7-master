using System;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortingArray.Porgram.Main()");

            int[] testArray = { 4, 1, 6, 5, 1, 6, 2, 5 };
            PrintArray(testArray);
            Console.WriteLine("\n");
            PrintArray(SortArray(testArray));
        }
        public static void PrintArray(int[] arrPrint)
        {
            foreach (var p in arrPrint)
            {
                Console.Write(p);
            }
        }

        public static int[] SortArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i+1; k < arr.Length; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
