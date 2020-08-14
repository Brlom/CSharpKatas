using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class PasswordScoreTests
    {
        [Fact]
        public void GetPasswordScore_ShouldReturnZero_WhenPassedEmptyString()
        {
            // arrange
            var original = String.Empty;
            int expected = 0;

            var x = new PasswordScore();

            // act
            var actual = x.GetPasswordScore(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPasswordScore_ShouldReturnScore_WhenPassedStrWithOnlyChars()
        {
            // arrange
            string original = "bob";
            int expected = 1;

            string original2 = "bobbybob";
            int expected2 = 2;

            string original3 = "bobbobbob";
            int expected3 = 3;

            var x = new PasswordScore();

            // act
            var actual = x.GetPasswordScore(original);
            var actual2 = x.GetPasswordScore(original2);
            var actual3 = x.GetPasswordScore(original3);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
        }

        [Fact]
        public void GetPasswordScore_ShouldReturnScoreOfFour_WhenPassedStrOverCertainLengthIncOneInt()
        {
            // arrange
            var original = "bobbobbob1";
            var expected = 4;

            var x = new PasswordScore();

            // act
            var actual = x.GetPasswordScore(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPasswordScore_ShouldReturnScoreOfFive_WhenPassedStrOverCertainLengthIncOneIntAndOneSpecChar()
        {
            // arrange
            var original = "bobbob1#2$";
            var expected = 5;

            var x = new PasswordScore();

            // act
            var actual = x.GetPasswordScore(original);

            // assert
            Assert.Equal(expected, actual);
        }

    }
}
