using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileContent = ReadFile();

            List<int> numbers = new List<int>();

            foreach (string row in fileContent)
            {
                numbers.Add(int.Parse(row));
            }

            int freq;

            List<int> reachedFrequences = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int freq = numbers[0];

                reachedFrequences.Add(countReachedFreq(numbers, i));
                numbers.

                reachedFrequences.Add((numbers[i] + reachedFrequences[i - 1]));
                int total = 0;

                for (int j = 0; j < i; j++)
                {
                    total += numbers[j];

                    foreach (int reachedF in reachedFrequences)
                    {
                        if (reachedF == total)
                            Console.WriteLine(total);
                    }
                }
            }

        }

        private static int countReachedFreq(List<int> numbers, int i)
        {
            int reachedF = 0;

            for (int j = 0; j <= i; j++)
            {
                reachedF += numbers[j];
            }

            return reachedF;
        }

        private static string[] ReadFile()
        {
            return File.ReadAllLines(@"C:\Users\Administrator\source\repos\AdventOfCode\Day1.txt");
        }
    }
}
