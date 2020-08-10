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

    }
}
