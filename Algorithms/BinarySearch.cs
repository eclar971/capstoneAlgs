using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Algorithms
{
    class Program
    {
        private static List<int> ints = new List<int>();
        static void Main(string[] args)
        {
            int x = 100000;
            for (int j = 0; j < x; j++)
            {
                int num = new Random().Next(0, x);
                while (ints.Contains(num))
                {
                    num = new Random().Next(0, x);
                }
                ints.Add(num);
            }
            //Merge sort run and stop watch
            var watch = System.Diagnostics.Stopwatch.StartNew();

            watch.Stop();
            Console.WriteLine("Merge sort time");
            int[] ints4 = MergeSort.SortArray(ints.ToArray(),0,ints.Count-1);
            if (!watch.IsRunning) // checks if it is not running
                watch.Start(); // Start the counter from where it stopped

            watch.Stop();
            Console.WriteLine($"Total Execution Time: {watch.Elapsed}");
            //Selection sort run and stop watch
            //watch = System.Diagnostics.Stopwatch.StartNew();
//
            //watch.Stop();
            //Console.WriteLine("Selection sort time");
            //List<int> ints2 = SelectionSort.sort(ints);
            //if (!watch.IsRunning) // checks if it is not running
            //    watch.Start(); // Start the counter from where it stopped
//
            //watch.Stop();
            //Console.WriteLine($"Total Execution Time: {watch.Elapsed}");
            ////bubble sort run and stop watch
            //watch = System.Diagnostics.Stopwatch.StartNew();
//
            //watch.Stop();
            //Console.WriteLine("Bubble sort time");
            //List<int> ints1 = bubble_Sort.sort(ints);
            //if (!watch.IsRunning) // checks if it is not running
            //    watch.Start(); // Start the counter from where it stopped
//
            //watch.Stop();
            //Console.WriteLine($"Total Execution Time: {watch.Elapsed}");
            ////quick sort run and stop watch
            //watch = System.Diagnostics.Stopwatch.StartNew();
//
            //watch.Stop();
            //Console.WriteLine("Quick sort time");
            //int[] ints3 = QuickSort.quickSort(ints.ToArray(), 0, ints.Count - 1);
            //if (!watch.IsRunning) // checks if it is not running
            //    watch.Start(); // Start the counter from where it stopped
//
            //watch.Stop();
            //Console.WriteLine($"Total Execution Time: {watch.Elapsed}");
            //// get user input
            //Console.WriteLine($"Please enter a # between {ints.Min()} and {ints.Max()}");
            //int ui = Convert.ToInt32(Console.ReadLine());
            //while (!ints.Contains(ui))
            //{
            //    Console.WriteLine("please try a different number");
            //    ui = Convert.ToInt32(Console.ReadLine());
            //}
            ////linear search run and stop watch
            //watch = System.Diagnostics.Stopwatch.StartNew();
//
            //watch.Stop();
            //Console.WriteLine("linear search");
            //Console.WriteLine(LinearSearch.search(ints, ui));
            //if (!watch.IsRunning) // checks if it is not running
            //    watch.Start(); // Start the counter from where it stopped
//
            //watch.Stop();
            //Console.WriteLine($"Total Execution Time: {watch.Elapsed}");
            ////Binary Search run and stopwatch
            //watch = System.Diagnostics.Stopwatch.StartNew();
//
            //watch.Stop();
//
            //Console.WriteLine("Binary search");
            //Console.WriteLine(Search(ints.Count / 2, ui, ints.Count / 4));
//
//
            //if (!watch.IsRunning) // checks if it is not running
            //    watch.Start(); // Start the counter from where it stopped
//
            //watch.Stop();
            //Console.WriteLine($"Total Execution Time: {watch.Elapsed}");
        }

        /// <summary>
        /// recursively does a binary search of a list of ints
        /// </summary>
        /// <param name="Index">starting position</param>
        /// <param name="SearchingGoal">number you are looking for</param>
        /// <param name="StepSize">current half size step for the binary search</param>
        /// <returns>index of the num searched for</returns>
        static int Search(int Index, int SearchingGoal, int StepSize)
        {
            if (SearchingGoal > ints[Index])
            {
                Index += StepSize;
            }
            else if (SearchingGoal < ints[Index] && Index - StepSize != 0)
            {
                Index -= StepSize;
            }
            if (SearchingGoal != ints[Index])
            {
                StepSize = StepSize / 2 != 0 ? StepSize / 2 : 1;
                Index = Search(Index, SearchingGoal, StepSize);
            }
            return Index;
        }
    }
}