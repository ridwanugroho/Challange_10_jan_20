using System;
using System.Collections.Generic;
using Xunit;
using ChallengeApp;

namespace tester
{
    public class UnitTest1
    {
        [Fact]
        public void tes_basic_statistic()
        {
            int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
            Assert.Equal(100, BasicStatistic.FindMax(numbers));
            Assert.Equal(-19, BasicStatistic.FindMin(numbers));
            Assert.Equal(17.73, BasicStatistic.CalculateAverage(numbers));
            Assert.Equal(195, BasicStatistic.CalculateTotal(numbers));
        }

        [Fact]
        public void tes_combine_array()
        {
            int[] arr1 = {2, 52};
            int[] arr2 = {65, 42};
            int[] arr3 = {3, 4, 6};

            int[] expected = {2, 3, 4, 6, 42, 52, 65};
            Assert.Equal(expected, FlatArray.Combine(arr1, arr2, arr3));
        }

        [Fact]
        public void tes_generating_kalender()
        {
             string expected =  "S    S    R    K    J    S    M\n"
                               +"                         1    2    \n"
                               +"3    4    5    6    7    8    9    \n"
                               +"10   11   12   13   14   15   16   \n"
                               +"17   18   19   20   21   22   23   \n"
                               +"24   25   26   27   28   29   ";

            Assert.Equal(expected, GenerateCalendar.createTable("Februari 2020"));
        }

        [Fact]
        public void tes_how_many_duplicate()
        {
            int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
            var expected =  new SortedList<int, int>();
            expected.Add(1, 3);
            expected.Add(2, 1);
            expected.Add(3, 3);
            expected.Add(4, 2);
            expected.Add(5, 3);

            Assert.Equal(expected, HowManyDuplicates.Run(dups));
        }

        [Fact]
        public void tes_multiplication_aray()
        {
            int[] expected = {1, 12, 25, -8};
            int[] arr1 = {1, 3, -5, 4};
            int[] arr2 = {1, 4, -5, -2};
            Assert.Equal(expected, MultiplicationOfTwoArray.arrMultiply(arr1, arr2));
        }

        [Fact]
        public void tes_separator()
        {
            var expected = "M+a+k+a+n+i+k+m+a+t+T+u+h+a+n+m+u+m+a+n+a+k+a+h+y+a+n+g+e+n+g+k+a+u+d+u+s+t+a+k+a+n";
            Assert.Equal(expected, Separator.Run("Maka nikmat Tuhanmu manakah yang engkau dustakan", "+"));
        }

        [Fact]
        public void tes_triangle_of_numbers()
        {
            var expected = "1\n"
                          +"12\n"
                          +"123\n"
                          +"1234\n"
                          +"12345\n"
                          +"123456\n"; 
            
            Assert.Equal(expected, TriangleOfNumbers.Run(6));
        }

        [Fact]
        public void tes_triagle_stars()
        {
            var expected = "*\n"
                          +"**\n"
                          +"***\n"
                          +"****\n"
                          +"*****\n"
                          +"******\n";

            Assert.Equal(expected, TriangleStars.Run(6));
        }

        [Fact]
        public void TestName()
        {
            var expected = "AkU AdAlAh AnAk gEmbAlA sElAlU rIAng";
            Assert.Equal(expected, VowelToUppercase.upperVowel("aku adalah anak gembala selalu riang"));
        }
    }
}
