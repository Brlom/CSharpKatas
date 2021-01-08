using Katas.BE.BE2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests.BE2
{
    public class InsertNewValueTests
    {
        [Fact]
        public void AddNewValueToList_ShouldReturnNewList_WithAddedValue()
        {
            // arrange
            var originalList = new List<int>() { 1, 4, 5, 10 };
            int newValue = 2;

            var expected = new List<int>() { 1, 2, 4, 5, 10 };

            var sut = new InsertNewValue();

            // act
            var actual = sut.AddNewValueToList(originalList, newValue);

            // assert
            Assert.Equal(expected, actual);
        }

    }
}
