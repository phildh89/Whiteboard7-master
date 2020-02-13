using System;

namespace AlphabetizeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AlphabetizeString.Program.Main()");
            Console.WriteLine(Alphabetize("Today is the tenth of Feb"));

        }
        public static string Alphabetize(string input)
        {
            string alphabetizeString ="";
            

            for (int i = 'a';i <= 'z'; i++)
            {
                for (int x = 0; x < input.Length; x++)
                {
                    if (input[x] == i)
                    {
                        alphabetizeString += (char)i;
                        break;
                    }
                }

            }
            
            
            
            
            return alphabetizeString;
        }
    }
}
