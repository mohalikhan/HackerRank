using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Sorting
    {
        //bigSorting problem
        public static string[] bigSorting(string[] unsorted)
        {
            Array.Sort(unsorted, new CustomComparer());
            return unsorted;
        }

        // Complete the countingSort  1 function below.
        public static int[] countingSort(int[] arr)
        {
            var output = new int[100];
            foreach (var i in arr)
                output[i] += 1;

            return output;
        }

        // Complete the countingSort 2 function below.
        public static int[] countingSort2(int[] arr)
        {
            var numberFrequency = new int[100];
            foreach (var i in arr)
                numberFrequency[i] += 1;

            for (var i = 1; i < 100; i++)
                numberFrequency[i] += numberFrequency[i - 1];

            var sortedOutput = new int[arr.Length];

            foreach (var num in arr)
            {
                var position = numberFrequency[num];
                numberFrequency[num] -= 1;
                sortedOutput[position - 1] = num;
            }
            return sortedOutput;
        }

        // Complete the quickSort function below.
        public static int[] QuickSort(int[] arr)
        {
            var pivot = arr[0];
            var lessList = new List<int>();
            var equalList = new List<int>();
            var moreList = new List<int>();
            var outputArr = new int[arr.Length];

            equalList.Add(arr[0]);

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                    lessList.Add(arr[i]);
                else if (arr[i] > pivot)
                {
                    moreList.Add(arr[i]);
                }
                else
                {
                    equalList.Add(arr[i]);
                }
            }

            var j = 0;

            foreach (var item in lessList)
                outputArr[j++] = item;

            foreach (var item in equalList)
                outputArr[j++] = item;

            foreach (var item in moreList)
                outputArr[j++] = item;


            return outputArr;
        }

        static int[] QuickSort2(int[] arr)
        {
            var pivot = arr[0];
            var smallerItems = new List<int>();
            var equalItems = new List<int>();
            var biggerItems = new List<int>();
            var outputArr = new int[arr.Length];

            equalItems.Add(arr[0]);

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                    smallerItems.Add(arr[i]);
                else if (arr[i] > pivot)
                {
                    biggerItems.Add(arr[i]);
                }
                else
                {
                    equalItems.Add(arr[i]);
                }
            }

            if (smallerItems.Count > 1)
                smallerItems = QuickSort2(smallerItems.ToArray()).ToList();

            if (biggerItems.Count > 1)
                biggerItems = QuickSort2(biggerItems.ToArray()).ToList();

            var j = 0;

            foreach (var item in smallerItems)
            {
                outputArr[j++] = item;
                Console.Write(item);
                Console.Write(' ');
            }

            foreach (var item in equalItems)
            {
                outputArr[j++] = item;
                Console.Write(item);
                Console.Write(' ');
            }

            foreach (var item in biggerItems)
            {
                outputArr[j++] = item;
                Console.Write(item);
                Console.Write(' ');
            }

            Console.WriteLine();
            return outputArr;
        }

        // Complete the runningTime function below.
        static int runningTime(int[] arr)
        {
            var shiftCount = 0;
            for (var i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                var j = i - 1;
                while (j >= 0 && value < arr[j])
                {
                    arr[j + 1] = arr[j];
                    shiftCount++;
                    j = j - 1;
                }
                arr[j + 1] = value;
            }
            return shiftCount;
        }
    }

    public class CustomComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length < y.Length)
                return -1;
            if (x.Length > y.Length)
            {
                return 1;
            }

            if (x == y)
                return 0;
            var i = 0;
            while (x[i] == y[i]) i++;
            return x[i].CompareTo(y[i]);
        }
    }
}
