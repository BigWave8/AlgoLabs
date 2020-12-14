using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SearchAlgorithm
{
    class Launcher
    {
        public static string InputString { get; set; }
        public static string Pattern { get; set; }
        public static int[] Answers { get; set; }
        static void Main(string[] args)
        {
            const string pathIn = @"D:\projects\Algo\SearchAlgorithm\string_test6.txt";
            const string pathOut = @"D:\projects\Algo\SearchAlgorithm\string_out.txt";
            ReadWithFile(pathIn);
            Answers = (int[])BruteForceAlgorithm().ToArray().Clone();
            //Answers = (int[])BoyerMooreAlgorithm().ToArray().Clone();
            WriteInFile(pathOut);
        }
        public static List<int> BruteForceAlgorithm()
        {
            List<int> answers = new List<int>();
            if (Pattern.Length > InputString.Length || Pattern.Length == 0 || InputString.Length == 0)
            {
                answers.Add(-1);
                return answers;
            }
            for (int i = 0; i <= InputString.Length - Pattern.Length; i++)
            {
                for (int j = 0; j < Pattern.Length; j++)
                {
                    if (InputString[i+j] != Pattern[j])
                        break;
                    if (j == Pattern.Length - 1)
                    {
                        answers.Add(i);
                    }
                }
            }
            if (answers.Count == 0)
                answers.Add(-1);
            return answers;
        }
        public static List<int> BoyerMooreAlgorithm()
        {
            Dictionary<char, int> skips = new Dictionary<char, int>();
            CreatePassTable(skips);
            List<int> answers = new List<int>();
            if (Pattern.Length > InputString.Length || Pattern.Length == 0 || InputString.Length == 0)
            {
                answers.Add(-1);
                return answers;
            }
            for (int i = 0; i <= InputString.Length - Pattern.Length;)
            {
                for (int j = Pattern.Length - 1; j >= 0; j--)
                {
                    if (InputString[i + j] != Pattern[j])
                    {
                        if (skips.ContainsKey(InputString[i + j]))
                        {
                            i += skips[InputString[i + Pattern.Length - 1]];
                        }
                        else
                        {
                            i += Pattern.Length;
                        }
                        break;
                    }
                    if (j == 0)
                    {
                        answers.Add(i);
                        i++;
                    }
                }
            }
            if (answers.Count == 0)
                answers.Add(-1);
            return answers;
        }
        private static void CreatePassTable(Dictionary<char, int> skips)
        {
            for (int i = 1; i < Pattern.Length; i++)
            {
                if (!skips.ContainsKey(Pattern[Pattern.Length - i - 1]))
                {
                    skips[Pattern[Pattern.Length - i - 1]] = i;
                }
            }
            if (!skips.ContainsKey(Pattern[Pattern.Length - 1]))
            {
                skips[Pattern[Pattern.Length - 1]] = Pattern.Length;
            }
        }
        public static void ReadWithFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                var array = sr.ReadLine().Split(' ').ToArray();
                InputString = array[0];
                Pattern = array[1];
                sr.Close();
            }
        }
        public static void WriteInFile(string path)
        {
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                if (Answers[0] == -1)
                {
                    sr.WriteLine("Not found");
                }
                else
                {
                    foreach (var answer in Answers)
                    {
                        sr.WriteLine($"{answer} --> {answer + Pattern.Length}");
                    }
                }
                sr.Close();
            }
            Console.WriteLine("Answer in string out file");
        }
    }
}