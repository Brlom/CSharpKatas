using Katas.Core;
using System;
using Xunit;

namespace Testing
{
    public class HerdTheBabiesTests
    {
        [Fact]
        public void SortTheBabies_WhenPassedAnEmptyStr_ShouldReturnEmptyStr()
        {
            // arrange
            string original = String.Empty;
            HerdTheBabies x = new HerdTheBabies();

            // act
            string actual = x.SortTheBabies(original);

            // assert
            Assert.Equal(original, actual);
        }

        [Fact]
        public void SortTheBabies_WhenPassedAStrWith1Upper1Lower_ShouldReturnCharsInOrder()
        {
            // arrange
            string original = "aA";
            HerdTheBabies x = new HerdTheBabies();
            string expected = "Aa";

            // act
            string actual = x.SortTheBabies(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SortTheBabies_WhenPassedAStrWithSeveralLettersOnlyOneCase_ShouldReturnInOrder()
        {
            // arrange
            string original = "adepd";
            string originalUpper = "ADEPD";
            var x = new HerdTheBabies();
            string expected = "addep";
            string expectedUpper = "ADDEP";

            // act
            string actual = x.SortTheBabies(original);
            string actualUpper = x.SortTheBabies(originalUpper);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expectedUpper, actualUpper);
        }

        [Fact]
        public void SortTheBabies_WhenPassedAStrWithSeveralLetters_ShouldReturnInOrder()
        {
            // arrange
            string original = "aBA";
            HerdTheBabies x = new HerdTheBabies();
            string expected = "AaB";

            // act
            string actual = x.SortTheBabies(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SortTheBabies_WhenPassedAStrWithSeveralLettersWithOneUpperCase_ShouldReturnInOrder()
        {
            // arrange
            string original = "bbaBccAC";
            HerdTheBabies x = new HerdTheBabies();
            string expected = "AaBbbCcc";

            // act 
            string actual = x.SortTheBabies(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SortTheBabies_WhenPassedAStrWithSeveralLettersAndCases_ShouldReturnInOrder()
        {
            // arrange
            string original = "AaBbbBaAbAbbAbB";
            HerdTheBabies x = new HerdTheBabies();
            string expected = "AAAAaaBBBbbbbbb";

            // act 
            string actual = x.SortTheBabies(original);

            // assert
            Assert.Equal(expected, actual);
        }

    }
}
