using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Launcher
    {
        public static string InputString { get; set; }
        public static string Pattern { get; set; }
        public static int[] Answers { get; set; }
        static void Main(string[] args)
        {
            const string pathIn = @"D:\projects\Algo\SearchAlgorithm\string_test5.txt";
            const string pathOut = @"D:\projects\Algo\SearchAlgorithm\string_out.txt";
            ReadWithFile(pathIn);
            Answers = (int[])BruteForceAlgorithm().ToArray().Clone();
            WriteInFile(pathOut);
        }

        public static void LaunchAlgorithms()
        {
            
        }
        public static List<int> BruteForceAlgorithm()
        {
            List<int> answers = new List<int>();
            if (Pattern.Length > InputString.Length)
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
            List<int> answers = new List<int>();
            if (Pattern.Length > InputString.Length)
            {
                answers.Add(-1);
                return answers;
            }
            int skip;
            for (int i = 0; i <= InputString.Length - Pattern.Length; i+=skip)
            {
                skip = 0;
                for (int j = Pattern.Length - 1; j >= 0; j--)
                {
                    if (InputString[i + j] != Pattern[j])
                    {
                        skip = Math.Max(1, j);
                        break;
                    }
                }
                if (skip == 0)
                {
                    answers.Add(i);
                    skip = Pattern.Length;
                }
            }
            if (answers.Count == 0)
                answers.Add(-1);
            return answers;
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
                foreach (var answer in Answers)
                {
                    sr.WriteLine($"{answer} --> {answer + Pattern.Length}" );
                }
                sr.Close();
            }
            Console.WriteLine("Answer in string out file");
        }
    }
}
