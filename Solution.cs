using System;

namespace CodePractice
{
    class Solution
    {
        static void Main(string[] args)
        {

            var n = Convert.ToInt32(Console.ReadLine());

            var array = Console.ReadLine().TrimEnd();
            var ar = Array.ConvertAll(array.Split(' '), int.Parse);

            /*var result = sockMerchant(n, ar);*/

            /*var a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            var b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            var result = compareTriplets(a, b);*/

            /*var n = Convert.ToInt32(Console.ReadLine());
            var arr = new int[n][];
            for (var i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            }*/

            //sorting array


            Warmup.plusMinusProblem(ar);

            //Console.WriteLine(result);
            //Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}
