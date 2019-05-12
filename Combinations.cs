using System;

namespace Algorithm
{
    class Program
    {
        static int k = 3;
        static int n = 5;
        static int[] arr = new int[k];

        static void Combination(int index, int start)
        {
            if(index >= k)
            {
                Console.WriteLine(String.Join("", arr));
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    arr[index] = i;
                    Combination(index + 1, i + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            Combination(0, 0);
        }

    }
}
