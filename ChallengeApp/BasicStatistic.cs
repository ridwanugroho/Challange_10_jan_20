// ========================================================
// Basic statistics - WITHOUT LINQ
// ========================================================

// int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
//
// FindMax(numbers);
//
// FindMin(numbers);
//
// CalculateAverage(numbers);
//
// CalculateTotal(numbers);

using System;

namespace ChallengeApp
{
    public class BasicStatistic
    {
        public static int FindMax(int[] numbers)
        {
            // Find maximum value "without" using LINQ
            int ln = numbers.Length;
            int max = 0;
			int temp = 0;
            for(int i=0; i<ln; i++){
                temp = numbers[i];
				if(temp > max){
					max = temp;
				}
            }
			
            return max;
            throw new NotImplementedException();
        }

        public static int FindMin(int[] numbers)
        {
            // Find minimum value "without" using LINQ
            int ln = numbers.Length;
            int min = 0;
			int temp = 0;
            for(int i=0; i<ln; i++){
                temp = numbers[i];
				if(temp < min){
					min = temp;
				}
            }
            return min;

            throw new NotImplementedException();
        }

        public static double CalculateAverage(int[] numbers)
        {
            // Calculate average value "without" using LINQ
            int ln = numbers.Length;
			double avg = 0;
			foreach(int i in numbers)
				avg += i;
			
			return Math.Round(avg/ln, 2);

            throw new NotImplementedException();
        }

        public static int CalculateTotal(int[] numbers)
        {
            // Calculate total value "without" using LINQ
            int sum = 0;
			foreach(int i in numbers)
				sum += i;

            return sum;
            throw new NotImplementedException();
        }
    }
}
