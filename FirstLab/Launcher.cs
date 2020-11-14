using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;


namespace FirstLab
{
    class Launcher
    {
        public static int InsertionSortComparisonCounter { get; set; }
        public static int InsertionSortSwapCounter { get; set; }
        public static int HeapSortComparisonCounter { get; set; }
        public static int HeapSortSwapCounter { get; set; }

        const string formatConference = "|Name: {0,10}   |Count of members: {1,4}   |Price: {2,5}   |City: {3,8}";

        static void Main(string[] args)
        {
            List<Conference> values = File.ReadAllLines(@"D:\projects\Algo\FirstLab\data.csv")
                                          .Select(v => Conference.FromCsv(v))
                                          .ToList();

            var insertionSortTime = Stopwatch.StartNew();
            Sorter.InsertionSort(values);
            insertionSortTime.Stop();
            Console.WriteLine("\nInsertion Sort descending by count of members:\n");

            foreach (var k in values)
            {
                Console.WriteLine(string.Format(formatConference, k.Name, k.CountOfMembers, k.TicketPriceInHryvnia, k.City));
            }

            Console.WriteLine("\n==================================================");
            Console.WriteLine("Insertion: comparisons:" + Launcher.InsertionSortComparisonCounter + "   swaps:" + Launcher.InsertionSortSwapCounter + "   time:" + insertionSortTime.ElapsedMilliseconds + "ms");
            Console.WriteLine("==================================================");

            var heapSortTime = Stopwatch.StartNew();
            Sorter.HeapSort(values);
            heapSortTime.Stop();
            Console.WriteLine("\nHeap Sort ascending by price:\n");
            foreach (var k in values)
            {
                Console.WriteLine(string.Format(formatConference, k.Name, k.CountOfMembers, k.TicketPriceInHryvnia, k.City));
            }

            Console.WriteLine("\n==================================================");
            Console.WriteLine("Heap: comparisons:" + Launcher.HeapSortComparisonCounter + "   swaps:" + Launcher.HeapSortSwapCounter + "   time:" + heapSortTime.ElapsedMilliseconds + "ms");
            Console.WriteLine("==================================================");
        }
    }
}
