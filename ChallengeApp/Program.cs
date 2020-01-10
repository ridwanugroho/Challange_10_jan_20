using System;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
            Console.WriteLine("max value : {0}", BasicStatistic.FindMax(numbers));
            Console.WriteLine("min value : {0}", BasicStatistic.FindMin(numbers));
            Console.WriteLine("avg value : {0}", BasicStatistic.CalculateAverage(numbers));
            Console.WriteLine("sum value : {0}", BasicStatistic.CalculateTotal(numbers));
            Console.WriteLine("==========================================================");

            Console.WriteLine("Combine Array");
            int[] arr1 = {2, 52, 56, 12, 3};
            int[] arr2 = {1, 0, 65, 42};
            int[] arr3 = {3, 4, 6};
            int[] arr = FlatArray.Combine(arr1, arr2, arr3);
            foreach (var x in arr)
                Console.Write($"{x}   ");  

            Console.WriteLine();
            Console.WriteLine("==========================================================");

            Console.WriteLine("generate calendar");
            
            Console.WriteLine("==========================================================");

            Console.WriteLine("how many duplicate");
            int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
            var dup = HowManyDuplicates.Run(dups);

            foreach(var x in dup)
                Console.WriteLine("{0} ==> {1}x", x.Key, x.Value);

            Console.WriteLine("==========================================================");

            Console.WriteLine("array multiplication");
        
            int[] arr4 = {1, 3, -5, 4};
            int[] arr5 = {1, 4, -5, -2};
            int[] res = MultiplicationOfTwoArray.arrMultiply(arr4, arr5);

            foreach(var x in res)
                Console.Write($"{x} ");
            Console.WriteLine();
            Console.WriteLine("==========================================================");

            Console.WriteLine("Separator");
            Console.WriteLine(Separator.Run("okeoekokv okokasd"));
            Console.WriteLine(Separator.Run("okeoekokv okokasd", "%"));
            Console.WriteLine("==========================================================");

            Console.WriteLine("triangle of number");
            Console.WriteLine(TriangleOfNumbers.Run(4));
            Console.WriteLine("==========================================================");

            Console.WriteLine("triangle of star");
            Console.WriteLine(TriangleStars.Run(4));
            Console.WriteLine("==========================================================");

            Console.WriteLine("vowel to upper");
            Console.WriteLine(VowelToUppercase.upperVowel("okeoke jos cendol dawet"));
            Console.WriteLine("==========================================================");

            Console.WriteLine("Generate Calendar");

            Console.WriteLine(GenerateCalendar.createTable("Februari 2020"));
            // GenerateCalendar.createTable("January 2019");

        }
    }
}
