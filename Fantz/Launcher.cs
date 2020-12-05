using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
            Dictionary<long, string> substring = new Dictionary<long, string>();
            Dictionary<int, int> memorized = new Dictionary<int, int>();
            SubstringsCreator(substring);
            if (Bits[0] == '0')
                return -1;
            SearchBinarySubsting(substring, memorized);
            return memorized[Bits.Length];
        }
        private static void SearchBinarySubsting(Dictionary<long, string> subStrings, Dictionary<int, int> memorized)
        {
            for (int length = 1; length <= Bits.Length; length++)
            {
                if (Bits[Bits.Length - length] == '0')
                {
                    memorized.Add(length, -1);
                    continue;
                }
                if (subStrings.ContainsValue(Bits.Substring(Bits.Length - length, length)))
                {
                    memorized.Add(length, 1);
                    continue;
                }
                memorized.Add(length, int.MaxValue);
                for ( int leftSubLength = 1; leftSubLength < length; leftSubLength++)
                {
                    string leftSubString = Bits.Substring(Bits.Length - length, leftSubLength);
                    if (subStrings.ContainsValue(leftSubString) && memorized[length - leftSubLength] > 0)
                    {
                        memorized[length] = Math.Min(memorized[length], memorized[length - leftSubLength] + 1);
                    }
                }
                if (memorized[length] == int.MaxValue)
                    memorized[length] = -1;
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