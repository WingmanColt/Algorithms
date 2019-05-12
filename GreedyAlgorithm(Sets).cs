using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class Program
    {
        /// <summary>
        /* Greedy algorithm 
         * Check all sets parts from one global set.
         * Take minimum sets to fill like global set.
         * Only for small sets, numbers, etc.
         */       
        /// </summary>

        static void Main(string[] args)
        {
            var universe = new[] { 1, 3, 5, 7, 9, 11, 20, 30, 40 };

            var sets = new[]
            {
                new[] { 20 },
                new[] {1, 5, 20, 30 },
                new[] {3, 7, 20, 30, 40},
                new[] {9, 30},
                new[] {11, 20, 30, 40},
                new[] {3, 7, 40}
            };

            var selectedSets = ChooseSets(sets.ToList(), universe.ToList() );

            foreach (var set in selectedSets)
            {
                Console.WriteLine($"{{ {String.Join(",", set)} }}");
            }
        }
        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            var result = new List<int[]>();
            var universeSet = new HashSet<int>(universe);
            var hashSet = new HashSet<int[]>(sets);

            while (universeSet.Count > 0)
            {
                var currentSet = hashSet
                    .OrderByDescending(s => s.Count(e => universeSet.Contains(e)))
                    .First();


                result.Add(currentSet);
                sets.Remove(currentSet);

                foreach (var item in currentSet)
                {
                    universeSet.Remove(item);
                }
            }
            return result;
        }
    }
}
