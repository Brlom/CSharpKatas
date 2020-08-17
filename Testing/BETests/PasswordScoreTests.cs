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

            string original4 = "bobbobbobbob";
            int expected4 = 3;

            var x = new PasswordScore();

            // act
            var actual = x.GetPasswordScore(original);
            var actual2 = x.GetPasswordScore(original2);
            var actual3 = x.GetPasswordScore(original3);
            var actual4 = x.GetPasswordScore(original4);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
        }

        [Fact]
        public void GetPasswordScore_ShouldReturnScoreOfFour_WhenPassedStrOverCertainLengthIncOneInt()
        {
            // arrange
            var original = "bobbobbob1";
            var expected = 4;

            var original2 = "bob1bobbob";
            var expected2 = 4;

            var x = new PasswordScore();

            // act
            var actual = x.GetPasswordScore(original);
            var actual2 = x.GetPasswordScore(original2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void GetPasswordScore_ShouldReturnScoreOfFive_WhenPassedStrOverLengthOverEightIncOneIntAndOneSpecChar()
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

        [Fact]
        public void GetPasswordScore_ShouldReturnScoreOfSix_WhenPassedStrOverLengthOverTwelveIncOneInt()
        {
            // arrange
            var original = "bobbobbobbob123";
            var expected = 6;

            var original2 = "bob1bob2bob3bob";
            var expected2 = 6;

            var original3 = "bobbob280bobbob";
            var expected3 = 6;

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
        public void GetPasswordScore_ShouldReturnScoreOfSix_WhenPassedStrOverLengthOverTwelveIncOneIntAndOneSpecChar()
        {
            // arrange
            var original = "bobbobbob1!2@3#";
            var expected = 7;

            var original2 = "#bob1bo!b2bob@3";
            var expected2 = 7;

            var original3 = "#123bobbo!bbob@%&/";
            var expected3 = 7;

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
    }
}
