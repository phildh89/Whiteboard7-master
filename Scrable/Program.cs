using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrable
{
    class Program
    {
        public static Dictionary<char, int> tileScore = new Dictionary<char, int>();
        static void Main(string[] args)
        {
            AddValue();
            Console.Write("Enter your word(s): ");
            string word = Console.ReadLine();
            Console.Write($"\nTotal Points for the word '{word}': ");
            Console.WriteLine(ScrableScore(word));
        }
        public static void AddValue()
        {
            tileScore.Add('a', 1);
            tileScore.Add('b', 3);
            tileScore.Add('c', 3);
            tileScore.Add('d', 2);
            tileScore.Add('e', 1);
            tileScore.Add('f', 4);
            tileScore.Add('g', 2);
            tileScore.Add('h', 4);
            tileScore.Add('i', 1);
            tileScore.Add('j', 8);
            tileScore.Add('k', 5);
            tileScore.Add('l', 1);
            tileScore.Add('m', 3);
            tileScore.Add('n', 1);
            tileScore.Add('o', 1);
            tileScore.Add('p', 3);
            tileScore.Add('q', 10);
            tileScore.Add('r', 1);
            tileScore.Add('s', 1);
            tileScore.Add('t', 1);
            tileScore.Add('u', 1);
            tileScore.Add('v', 4);
            tileScore.Add('w', 4);
            tileScore.Add('x', 8);
            tileScore.Add('y', 4);
            tileScore.Add('z', 10);
        }

        public static int ScrableScore(string input)
        {
            int totalScore = 0;
            input = input.ToLower();

            foreach (var x in input)
            {
                if (tileScore.ContainsKey(x))
                {
                    totalScore += tileScore[x];
                }
            }


            return totalScore;
        }
    }
}
