using Katas.Core;
using System.Collections.Generic;
using Xunit;

namespace Testing
{
    public class RotateArrayTests
    {
        [Fact]
        public void RotateListElements_ShouldReturnEmptyList_WhenPassedEmptyList()
        {
            // arrange
            var empty = new List<int>();
            int numRotations = 0;

            var x = new RotateArray();

            // act
            var actual = x.RotateListElements(empty, numRotations);

            // assert
            Assert.Equal(empty, actual);
        }

        [Fact]
        public void RotateListElements_ShouldReturnUnchangedList_WhenPassedListAndZeroRotations()
        {
            // arrange
            var original = new List<int>() { 1, 2, 3 };
            int numRotations = 0;
            var expected = original;

            var x = new RotateArray();

            // act
            var actual = x.RotateListElements(original, numRotations);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RotateListElements_ShouldReturnListRotatedOnce_WhenPassedListAndASingleRotation()
        {
            // arrange
            var original = new List<int>() { 1, 2, 3 };
            int numRotations = 1;
            var expected = new List<int>() { 3, 1, 2 };

            var original5 = new List<int>() { 1, 2, 3, 4, 5 };
            int numRotations5 = 3;
            var expected5 = new List<int> { 3, 4, 5, 1, 2 };

            var x = new RotateArray();
            
            // act 
            var actual = x.RotateListElements(original, numRotations);
            var actual5 = x.RotateListElements(original5, numRotations5);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected5, actual5);
        }

        [Fact]
        public void RotateListElements_ShouldReturnListRotatedToLeft_WhenPassedNegativeRotationNum()
        {
            // arrange
            var original = new List<int>() { 1, 2, 3 };
            int numRotations = -1;
            var expected = new List<int>() { 2, 3, 1 };

            var original5 = new List<int>() { 1, 2, 3, 4, 5 };
            int numRotations5 = -3;
            var expected5 = new List<int>() { 4, 5, 1, 2, 3 };

            var x = new RotateArray();
            
            // act
            var actual = x.RotateListElements(original, numRotations);
            var actual5 = x.RotateListElements(original5, numRotations5);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected5, actual5);
        }

        [Fact]
        public void RotateListElements_ShouldRotateList_WhenPassedNumHigherThanCount()
        {
            // arrange
            var original = new List<int> { 1, 2, 3 };
            int numRotations = 5;
            var expected = new List<int> { 2, 3, 1 };
            
            var original5 = new List<int> { 1, 2, 3, 4, 5 };
            int numRotations5 = 13;
            var expected5 = new List<int> { 3, 4, 5, 1, 2 };
            
            var x = new RotateArray();
            
            // act 
            var actual = x.RotateListElements(original, numRotations);
            var actual5 = x.RotateListElements(original5, numRotations5);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected5, actual5);
        }

        [Fact]
        public void RotateListElements_WhenPassedIntListAndNegNumLargerThanListCount_ShouldReturnListRotated()
        {
            // arrange
            var original = new List<int>() { 1, 2, 3 };
            int numRotations = -4;
            var expected = new List<int>() { 2, 3, 1 };

            var original6 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            int numRotations6 = -16;
            var expected6 = new List<int>() { 5, 6, 1, 2, 3, 4 };

            var x = new RotateArray();

            // act
            var actual = x.RotateListElements(original, numRotations);
            var actual6 = x.RotateListElements(original6, numRotations6);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);

        }
    }
}
