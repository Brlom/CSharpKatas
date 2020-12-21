using Katas.BE.BE2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests.BE2
{
    public class UniqueAndOrderedTests
    {
        // TESTS - Strings

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FindUniqueVals_ShouldReturnEmptyList_WhenNullOrEmptyValues_String(string values)
        {
            // arrange
            var expected = new List<char>();

            var sut = new UniqueAndOrdered();

            // act
            var actual = sut.FindUniqueVals<char, char>(values);

            // assert
            Assert.Equal(expected, actual);
        }
        
        public static IEnumerable<object[]> dataStrList()
        {
            yield return new object[] { "A", new List<char>() { 'A' } };
            yield return new object[] { "AA", new List<char>() { 'A' } };
            yield return new object[] { "ABA", new List<char>() { 'A', 'B' } };
        }

        [Theory]
        [MemberData(nameof(dataStrList))]
        public void FindUniqueVals_ShouldReturnListOfUniqueChars_WhenPassedNonUniqueStr(string original, List<char> expected)
        {
            // arrange
            var sut = new UniqueAndOrdered();

            // act
            var actual = sut.FindUniqueVals<char, char>(original);

            // assert
            Assert.Equal(expected, actual);
        }

        // TESTS - LIST OF NUMBERS

        public static IEnumerable<object[]> emptyList()
        {
            yield return new object[] { new List<int>() };
        }

        [Theory]
        [MemberData(nameof(emptyList))]
        public void FindUniqueVals_ShouldReturnEmptyList_WhenNullOrEmptyValues_IntList(List<int> values)
        {
            // arrange
            var expected = new List<int>();

            var sut = new UniqueAndOrdered();

            // act
            var actual = sut.FindUniqueVals<int, int>(values);

            // assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> dataIntList()
        {
            yield return new object[] { new List<int>() { 1 }, new List<int>() { 1 } };
            yield return new object[] { new List<int>() { 1, 1 }, new List<int>() { 1 } };
            yield return new object[] { new List<int>() { 1, 2, 3, 1 }, new List<int>() { 1, 2, 3 } };
            yield return new object[] { new List<int>() { 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 1, 1 }, new List<int>() { 1, 2, 3 } };   
        }

        [Theory]
        [MemberData(nameof(dataIntList))]
        public void FindUniqueVals_ShouldReturnListOfUniqueInts_WhenPassedListOfInts(List<int> values, List<int> expectedList)
        {
            // arrange
            var expected = expectedList;

            var sut = new UniqueAndOrdered();

            // act
            var actual = sut.FindUniqueVals<int, int>(values);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
