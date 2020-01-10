// ========================================================
// Flatting array
// ========================================================

// int[] theFirstArray = {2, 52, 56, 12, 3};
// int[] theSecondArray = {1, 0, 65, 42};
// int[] theThirdArray = {3, 4, 6};
//
// CombineArray(theFirstArray, theSecondArray, theThirdArray)
// Expected result: {0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65};

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp
{
    public class FlatArray
    {
        public static int[] Combine(params int[][] arrays)
        {
            List<int> temp = new List<int>();

            foreach(var arr in arrays)
                temp.AddRange(arr);

            
            int[] ret = temp.ToArray();
            Array.Sort(ret);

            return ret;

            throw new NotImplementedException();
        }
    }
}
