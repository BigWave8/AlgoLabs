using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab3
{
    class Launcher
    {
        public static Dictionary<string, LinkedList<string>> Documents { get; set; }
        public static Dictionary<string, bool> DocumentsUsed { get; set; }
        public static List<string> Answer { get; set; }
        static void Main(string[] args)
        {
            const string pathIn = @"D:\projects\Algo\Lab3\govern_in.txt";
            const string pathOut = @"D:\projects\Algo\Lab3\govern_out.txt";
            Documents = new Dictionary<string, LinkedList<string>>();
            DocumentsUsed = new Dictionary<string, bool>();
            Answer = new List<string>();
            ReadWithFile(pathIn);
            Algorithm();
            WriteInFile(pathOut);
        }
        public static void Algorithm()
        {
            foreach(KeyValuePair<string, LinkedList<string>> dict in Documents)
            {
                Algorithm(dict.Key);
            }
        }
        private static void Algorithm(string key)
        {
            foreach (string item in Documents[key]) 
            {
                if (DocumentsUsed[item] == false)
                {
                    Algorithm(item); 
                }
            }
            if (DocumentsUsed[key] == false)
            {
                Answer.Add(key);
                DocumentsUsed[key] = true;
            }
        }
        public static void ReadWithFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var array = line.Split(' ').ToArray();
                    string document = array[0];
                    if (Documents.ContainsKey(document))
                    {
                        LinkedList<string> temp = Documents[document];
                        temp.AddLast(array[1]);
                        Documents[document] = temp;
                    }
                    else
                    {
                        var neighbor = new LinkedList<string>();
                        neighbor.AddLast(array[1]);
                        Documents.Add(document, neighbor);
                        DocumentsUsed.Add(document, false);
                    }
                    if (!Documents.ContainsKey(array[1]))
                    {
                        var neighbor = new LinkedList<string>();
                        Documents.Add(array[1], neighbor);
                        DocumentsUsed.Add(array[1], false);
                    }
                }
                sr.Close();
            }
        }
        public static void WriteInFile(string path)
        {
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                foreach (string print in Answer)
                {
                    sr.WriteLine(print);
                }
                sr.Close();
            }
            Console.WriteLine("Answer in govern out file");
        }
    }
}