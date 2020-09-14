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
            string expected = "";

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

            double original4 = 1257;
            string expected4 = "20 minutes 57 seconds";

            var x = new SecondsToTimeString();

            // act
            string actual = x.ConvertSecondsToString(original);
            string actual2 = x.ConvertSecondsToString(original2);
            string actual3 = x.ConvertSecondsToString(original3);
            string actual4 = x.ConvertSecondsToString(original4);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
        }

        [Fact]
        public void SecondsToTimeString_ConvertSecondsToString_WhenPassedNumLargerThan3600_ReturnsHoursAsWellAsMinutesAndSeconds()
        {
            // arrange
            double original = 3661;
            string expected = "1 hour 1 minute 1 second";

            double original2 = 3600;
            string expected2 = "1 hour";

            double original3 = 3660;
            string expected3 = "1 hour 1 minute";

            double original4 = 18116;
            string expected4 = "5 hours 1 minute 56 seconds";

            var x = new SecondsToTimeString();

            // act
            var actual = x.ConvertSecondsToString(original);
            var actual2 = x.ConvertSecondsToString(original2);
            var actual3 = x.ConvertSecondsToString(original3);
            var actual4 = x.ConvertSecondsToString(original4);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
        }

        [Fact]
        public void SecondsToTimeString_ConvertSecondsToString_WhenPassedNumLargerThan86400_ReturnsDaysAsWellAsHoursMinutesAndSeconds()
        {
            // arrange - 86400secs
            double original = 90061;
            string expected = "1 day 1 hour 1 minute 1 second";

            double original2 = 400461;
            string expected2 = "4 days 15 hours 14 minutes 21 seconds";

            var x = new SecondsToTimeString();

            // act
            var actual = x.ConvertSecondsToString(original);
            var actual2 = x.ConvertSecondsToString(original2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void SecondsToTimeString_ConvertSecondsToString_WhenPassedNumLargerThan604800_ReturnsWeeksAsWellAsDaysHoursMinutesAndSeconds()
        {
            // arrange - 604800secs
            double original = 694861;
            string expected = "1 week 1 day 1 hour 1 minute 1 second";

            double original2 = 4090479;
            string expected2 = "6 weeks 5 days 8 hours 14 minutes 39 seconds";

            var x = new SecondsToTimeString();

            // act
            var actual = x.ConvertSecondsToString(original);
            var actual2 = x.ConvertSecondsToString(original2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void SecondsToTimeString_ConvertSecondsToString_WhenPassedNumLargerThan31449600_ReturnsYearsAsWellAsWeeksDaysHoursMinutesAndSeconds()
        {
            // arrange - 31449600secs
            double original = 32144461;
            string expected = "1 year 1 week 1 day 1 hour 1 minute 1 second";

            double original2 = 127702942;
            string expected2 = "4 years 2 weeks 1 day 1 hour 2 minutes 22 seconds";

            double original3 = 32140942;
            string expected3 = "1 year 1 week 1 day 2 minutes 22 seconds";

            double original4 = 630806400;
            string expected4 = "20 years";

            var x = new SecondsToTimeString();

            // act
            var actual = x.ConvertSecondsToString(original);
            var actual2 = x.ConvertSecondsToString(original2);
            var actual3 = x.ConvertSecondsToString(original3);
            var actual4 = x.ConvertSecondsToString(original4);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
        }
    }
}
