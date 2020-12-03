using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fantz
{
    class Launcher
    {
        public static string Bits { get; set; }
        public static int Number { get; set; }
        public static int Answer { get; set; }
        static void Main(string[] args)
        {
            const string pathIn = @"D:\projects\Algo\Fantz\fantz_in.txt";
            const string pathOut = @"D:\projects\Algo\Fantz\fantz_out.txt";
            Bits = ReadWithFile(pathIn);
            Answer = Algorithm();
            WriteInFile(pathOut);
        }
        public static int Algorithm()
        {
            int answer = 0;
            Answer = int.MaxValue;
            int freeBits = Bits.Length;
            Dictionary<long, string> substring = new Dictionary<long, string>();
            SubstringsCreator(substring);
            SearchBinarySubsting(substring, freeBits, answer);
            if (Answer == int.MaxValue)
                return -1;

            return Answer;
        }
        private static void SearchBinarySubsting(Dictionary<long, string> subStrings, int freeBits, int answer)
        {
            foreach (var subString in subStrings)
            {
                if (subString.Value.Length <= freeBits)
                {
                    if (subStrings.ContainsValue(Bits.Substring(Bits.Length - freeBits, subString.Value.Length)))
                    {
                        answer++;
                        freeBits -= subString.Value.Length;
                        SearchBinarySubsting(subStrings, freeBits, answer);
                        if (freeBits == 0 && answer < Answer)
                            Answer = answer;
                    }
                }
            }
        }
        private static void SubstringsCreator(Dictionary<long, string> subStrings)
        {
            long canBeMax = long.MaxValue;
            if (Number == 1)
            {
                subStrings.Add(1, "1");
                return;
            }
            if (Bits.Length < 64)
            {
                canBeMax = (long)Math.Pow(2, Bits.Length);
            }
            for (int power = (int)Math.Log(canBeMax, Number); power >= 0; power--)
            {
                subStrings.Add((long)Math.Pow(Number, power), Convert.ToString((long)Math.Pow(Number, power), 2));
            }
        }
        public static string ReadWithFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                var array = sr.ReadLine().Split(' ').ToArray();
                Number = Convert.ToInt32(array[1]);
                sr.Close();
                return (string)array[0].Clone();
            }
        }
        public static void WriteInFile(string path)
        {
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                sr.WriteLine(Answer);
                sr.Close();
            }
            Console.WriteLine("Answer in fantz out file");
        }
    }
}