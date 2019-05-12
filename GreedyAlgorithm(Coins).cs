using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static int finalSum = 20;
        static int currentSum = 0;
        static int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 };
        static Queue<int> result = new Queue<int>();

        static void GreedyCoins()
        {
            for (int i = 0; i < coins.Length; i++)
            {
                if (currentSum + coins[i] > finalSum)
                    continue;

                currentSum += coins[i];
                result.Enqueue(coins[i]);

                if (currentSum == finalSum)
                    Console.WriteLine(string.Join(", ", result));
            }
        }

        static void Main(string[] args)
        {
            GreedyCoins();
        }

    }
}
