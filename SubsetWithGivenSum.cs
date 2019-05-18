using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class Program
    {
        static bool isSubsetSum(int[] set, int n, int sum)
        {
            // The value of subset[i][j] will be true if there  
            // is a subset of set[0..j-1] with sum equal to i 
            bool[,] subset = new bool[sum + 1, n + 1];

            // If sum is 0, then answer is true 
            for (int i = 0; i <= n; i++)
                subset[0, i] = true;

            // If sum is not 0 and set is empty, then answer is false 
            for (int i = 1; i <= sum; i++)
                subset[i, 0] = false;

            // Fill the subset table in bottom up manner 
            for (int i = 1; i <= sum; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    subset[i, j] = subset[i, j - 1];
                    if (i >= set[j - 1])
                        subset[i, j] = subset[i, j] ||
                                       subset[i - set[j - 1], j - 1];

                }
            }

            return subset[sum, n];
        }
        static void Main(string[] args)
        {
            int[] set = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int sum = 16;
            int n = set.Length;
            if (isSubsetSum(set, n, sum) == true)
                Console.WriteLine("Found a subset with given sum");
            else
                Console.WriteLine("No subset with given sum");

        } 
       

    }
}
