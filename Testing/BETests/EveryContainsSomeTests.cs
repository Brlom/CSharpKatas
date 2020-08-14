using Katas.BE;
using System;
using System.Collections.Generic;
using Xunit;

namespace Testing.BETests
{
    public class EveryContainsSomeTests
    {
        [Fact]
        public void EveryContainsSome_Every_WhenPassedListOfNumsAndDel_ShouldReturnBool()
        {
            // arrange
            var originalList = new List<int>()
            {
                2, 
                4,
                5
            };
            bool expected = false;

            var originalList2 = new List<int>()
            {
                2,
                4,
                12
            };
            bool expected2 = true;

            var x = new EveryContainsSome();

            // act
            // Instantiate the delegate
            EvaluateInt handler = x.Evaluate;
            var actual = x.Every(originalList, handler);
            var actual2 = x.Every(originalList2, handler);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        // TODO: should make this work for other types as well.
        [Fact]
        public void EveryContainsSome_Contains_ShouldReturnBool_WhenPassedListAndItemInList()
        {
            // arrange
            var originalList = new List<int>()
            {
                1,
                2,
                3
            };
            int num = 3;
            bool expected = true;

            var originalList2 = new List<int>()
            {
                1,
                2,
                3
            };
            int num2 = 4;
            bool expected2 = false;

            var x = new EveryContainsSome();

            // act
            var actual = x.Contains(originalList, num);
            var actual2 = x.Contains(originalList2, num2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void EveryContainsSome_Some_ShouldReturnBool_WhenPassedListContainingTruthyVal()
        {
            // arrange
            var originalList = new List<Object>()
            {
                null, 
                0, 
                "yes",
                false
            };
            bool expected = true;

            var originalList2 = new List<Object>()
            {
                null,
                0,
                -3.16,
                false
            };
            bool expected2 = false;

            var x = new EveryContainsSome();

            // act
            var actual = x.Some(originalList);
            var actual2 = x.Some(originalList2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void EveryContainsSome_Evaluate_ShouldCheckTruthinessOfPassedParamMod2_AndReturnBool()
        {
            // arrange
            var original = 4;
            var expected = true;

            var original2 = 3;
            var expected2 = false;

            var original3 = 0;
            var expected3 = false;

            var original4 = -4;
            var expected4 = false;

            var x = new EveryContainsSome();

            // act
            var actual = x.Evaluate(original);
            var actual2 = x.Evaluate(original2);
            var actual3 = x.Evaluate(original3);
            var actual4 = x.Evaluate(original4);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
        }
    }
}
