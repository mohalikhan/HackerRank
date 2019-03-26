using System;
using System.Collections.Generic;

namespace CodePractice
{
    internal class Warmup
    {
        // Complete the sockMerchant function below.
        public static int sockMerchant(int n, int[] ar)
        {
            var toReturn = 0;
            var list = new List<int>();
            for (var i = 0; i < n; i++)
            {
                if (list.Contains(ar[i]))
                {
                    toReturn++;
                    list.RemoveAt(list.IndexOf(ar[i]));
                }
                else
                {
                    list.Add(ar[i]);
                }
            }

            return toReturn;
        }

        // add array together
        public static int simpleArraySum(int[] ar)
        {
            var toReturn = 0;
            for (var i = 0; i < ar.Length; i++)
            {
                toReturn += ar[i];
            }

            return toReturn;
        }

        // Complete the compareTriplets function below.
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var bob = 0;
            var alice = 0;
            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }

                if (a[i] < b[i])
                {
                    bob++;
                }
            }
            return new List<int> { alice, bob };
        }

        // Complete the aVeryBigSum function below.
        public static long aVeryBigSum(long[] ar)
        {
            long toReturn = 0;
            for (var i = 0; i < ar.Length; i++)
            {
                toReturn += ar[i];
            }

            return toReturn;

        }

        // Complete the diagonalDifference function below.
        public static int diagonalDifference(int[][] arr)
        {
            var first = 0;
            var second = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        first += arr[i][j];
                    if ((i + j) == (arr.Length - 1))
                        second += arr[i][j];
                }
            }

            return Math.Abs(first - second);
        }

        //Plus Minus (algorithm) problem
        public static void plusMinusProblem(int[] arr)
        {
            var positiveNumbers = 0;
            var negativeNumbers = 0;
            var zeroNumbers = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    ++positiveNumbers;
                else if (arr[i] < 0)
                    ++negativeNumbers;
                else
                    ++zeroNumbers;
            }

            Console.WriteLine((double)positiveNumbers / arr.Length);
            Console.WriteLine((double)negativeNumbers / arr.Length);
            Console.WriteLine((double)zeroNumbers / arr.Length);
        }

        // Staircase problem
        public static void staircaseProblem(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                var spaces = new string(' ', n - i);
                var hashes = new string('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }

        //Mini-Max Sum problem
        public static void mini_maxProblem(int[] numbers)
        {
            var sumOfAllNumbers = 0L;
            var minimum = Int64.MaxValue;
            var maximum = 0L;
            for (var i = 0; i < 5; i++)
            {
                sumOfAllNumbers += numbers[i];
                if (numbers[i] < minimum)
                    minimum = numbers[i];

                if (numbers[i] > maximum)
                    maximum = numbers[i];

            }
            Console.WriteLine($"{sumOfAllNumbers - maximum} {sumOfAllNumbers - minimum}");
        }

        // Time Conversion
        public static string timeConversion(string time)
        {
            var amOrPm = time.Substring(8);
            var hourComponent = time.Substring(0, 2);
            var remainingTimeComponent = time.Substring(2, 6);
            if (amOrPm == "AM" && hourComponent == "12")
            {
                hourComponent = "00";
            }
            else if (amOrPm == "PM")
            {
                var numericHourComponent = Int32.Parse(hourComponent);
                if (numericHourComponent != 12)
                {
                    hourComponent = Convert.ToString(12 + numericHourComponent);
                }
            }

            return hourComponent + remainingTimeComponent;
        }

        // Birthday cake candles problem
        public static int birthdayCakeCandles(int[] ar)
        {
            var maxValue = ar[0];
            var maxValueOccurence = 1;

            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] == maxValue)
                {
                    maxValueOccurence++;
                    continue;
                }
                if (ar[i] > maxValue)
                {
                    maxValue = ar[i];
                    maxValueOccurence = 1;
                }
            }
            return maxValueOccurence;
        }
    }
}
