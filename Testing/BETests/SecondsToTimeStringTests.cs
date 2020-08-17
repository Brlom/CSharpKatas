using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class SecondsToTimeStringTests
    {
        [Fact]
        public void SecondsToTimeString_ConvertSecondsToString_WhenPassedSeconds_ShouldReturnSecondsAsStr()
        {
            // arrange
            double original = 0;
            string expected = $"{original} seconds";

            double original2 = 1;
            string expected2 = $"{original2} second";

            double original3 = 15;
            string expected3 = $"{original3} seconds";

            var x = new SecondsToTimeString();

            // act
            var actual = x.ConvertSecondsToString(original);
            var actual2 = x.ConvertSecondsToString(original2);
            var actual3 = x.ConvertSecondsToString(original3);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
        }

        [Fact]
        public void SecondsToTimeString_ConvertSecondsToString_WhenPassedSecondsAbove59_ShouldReturnCorrectlyConvertedStr()
        {
            // arrange
            double original = 60;
            string expected = "1 minute";

            double original2 = 61;
            string expected2 = "1 minute 1 second";

            double original3 = 120;
            string expected3 = "2 minutes";

            var x = new SecondsToTimeString();

            // act
            string actual = x.ConvertSecondsToString(original);
            string actual2 = x.ConvertSecondsToString(original2);
            string actual3 = x.ConvertSecondsToString(original3);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);

        }
    }
}
