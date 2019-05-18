using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class Program
    {
       
        static void Main(string[] args)
        {
           var numbers = new[] { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };

           var solutions = new int[numbers.Length];
           var prevBestSolution = new int[numbers.Length];

           var maxSolution = 0;
           var maxSolutionIndex = 0;

           for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
           {
               var solution = 1;
               var prevBestSolutionIndex = -1;

               var currentNumber = numbers[currentIndex];

               for (int solutionIndex = 0; solutionIndex < currentIndex; solutionIndex++)
               {
                   var prevNumber = numbers[solutionIndex];
                   var prevSolution = solutions[solutionIndex];

                   if(currentNumber > prevNumber && solution <= prevSolution)
                   {
                       solution = prevSolution + 1;
                       prevBestSolutionIndex = solutionIndex;
                   }
               }
                solutions[currentIndex] = solution;
               prevBestSolution[currentIndex] = prevBestSolutionIndex;

               if(solution > maxSolution)
               {
                   maxSolution = solution;
                   maxSolutionIndex = currentIndex;
               }
           }
           Console.WriteLine(maxSolution);

           var index = maxSolutionIndex;
           var result = new List<int>();

           while (index != -1)
           {
               var currentNumber = numbers[index];
               result.Add(currentNumber);
               index = prevBestSolution[index];
           }

           result.Reverse();

          Console.Write(string.Join(" ", result));


    }
    }
}
