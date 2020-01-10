// ========================================================
// Multiplication of two arrays
// ========================================================

// int[] firstArray = {1, 3, -5, 4};
// int[] secondArray = {1, 4, -5, -2};
//
// MultiplyArray(firstArray, secondArray)
//
// Expected result { 1, 12, 25, -8 }

namespace ChallengeApp
{
    public class MultiplicationOfTwoArray
    {
        public static int[] arrMultiply(int[] arr1, int[] arr2)
        {
            if(arr1.Length != arr1.Length)
                return null;

            else
            {
                for(int i=0; i<arr1.Length; i++)
                    arr1[i] = arr1[i] * arr2[i];

                return arr1;
            }
        }
    }
}
