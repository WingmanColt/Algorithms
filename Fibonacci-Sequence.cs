using System;

namespace Algorithms
{
    class FibonacciSequence
    {

        static int fibSolve_Reccursion(int n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }

            return fibSolve_Reccursion(n - 1) + fibSolve_Reccursion(n - 2);
        }

        static int[] numbers;
        static int fibSolve_ReccursionWithMemorise(int n)
        {
            if(numbers[n] != 0)
            {
                return numbers[n];
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            var result = fibSolve_ReccursionWithMemorise(n - 1) + fibSolve_ReccursionWithMemorise(n - 2);

            numbers[n] = result;

            return result;
        }

        static int fibSolve_Iteration(int n)
        {
            int a = 0;
            int b = 1;

            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            numbers = new int[n + 1];

            // Complexity: O(n)
            Console.WriteLine(fibSolve_ReccursionWithMemorise(n));

            // Complexity: O(1.6n)
            // Console.WriteLine(fibSolve_Reccursion(n)); 

            Console.WriteLine(fibSolve_Iteration(n));
        }
    }
}
