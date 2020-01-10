// ========================================================
// How many duplicates
// ========================================================

// int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
//
// Expected result
// 1 -> 3x
// 2 -> 1x
// 3 -> 3x
// 4 -> 2x
// 5 -> 2x

using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp
{
    public class HowManyDuplicates
    {
        public static SortedList<int, int> Run(int[] num)
        {
            var counter = new SortedList<int, int>();

            foreach (var x in num.GroupBy(xx => xx))
                counter.Add(x.Key, x.Count());
            
            return counter;

            throw new NotImplementedException();
        }
    }
}
