using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Wchain
{
    class Launcher
    {
        public static Dictionary<string, int> WordsChain { get; set; }
        public static string[] Words { get; set; }
        public static int Answer { get; set; }
        static void Main(string[] args)
        {
            const string pathIn = @"D:\projects\Algo\Wchain\wchain_in.txt";
            const string pathOut = @"D:\projects\Algo\Wchain\wchain_out.txt";
            WordsChain = new Dictionary<string, int>();
            Words = ReadWithFile(pathIn);
            Answer = Algorithm();
            WriteInFile(pathOut);
        }
        public static int Algorithm()
        {
            int maxLength = 0;
            Array.Sort(Words, (a, b) => a.Length - b.Length);
            foreach (string word in Words)
            {
                WordsChain[word] = 1;
                for (int i = 0; i < word.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(word);
                    sb.Remove(i, 1);
                    string nextWord = sb.ToString();
                    if (WordsChain.ContainsKey(nextWord) && WordsChain[word] < WordsChain[nextWord] + 1)
                    {
                        WordsChain[word] = WordsChain[nextWord] + 1;
                    }
                }
                maxLength = maxLength > WordsChain[word] ? maxLength : WordsChain[word];
            }
            return maxLength;
        }
        public static string[] ReadWithFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int wordNumbers = Convert.ToInt32(sr.ReadLine());
                string[] words = new string[wordNumbers];
                for (int i = 0; i < wordNumbers; i++)
                {
                    words[i] = sr.ReadLine();
                }
                sr.Close();
                return words;
            }
        }
        public static void WriteInFile(string path)
        {
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                sr.WriteLine(Answer);
                sr.Close();
            }
            Console.WriteLine("Answer in wchain out file");
        }
    }
}