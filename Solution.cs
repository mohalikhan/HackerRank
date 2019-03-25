using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Solution
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
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
        static int simpleArraySum(int[] ar)
        {
            var toReturn = 0;
            for (var i = 0; i < ar.Length; i++)
            {
                toReturn += ar[i];
            }

            return toReturn;
        }

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
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
        static long aVeryBigSum(long[] ar)
        {
            long toReturn = 0;
            for (var i = 0; i < ar.Length; i++)
            {
                toReturn += ar[i];
            }

            return toReturn;

        }

        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
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

        static void Main(string[] args)
        {

            /*var n = Convert.ToInt32(Console.ReadLine());

            var array = Console.ReadLine().TrimEnd();
            var ar = Array.ConvertAll(array.Split(' '), int.Parse);

            var result = sockMerchant(n, ar);*/

            /*var a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            var b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            var result = compareTriplets(a, b);*/

            var n = Convert.ToInt32(Console.ReadLine());
            var arr = new int[n][];
            for (var i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            }

            var result = diagonalDifference(arr);

            Console.WriteLine(result);
            //Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}
