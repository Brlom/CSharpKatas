using Katas.BE.BE2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests.BE2
{
    public class FindMissingLetterTests
    {
        public static IEnumerable<object[]> testData()
        {
            yield return new object[] { new List<char>() { 'A', 'B' }, String.Empty };
            yield return new object[] { new List<char>() { 'a', 'b' }, String.Empty };
            yield return new object[] { new List<char>() { 'A', 'C' }, "B" };
            yield return new object[] { new List<char>() { 'a', 'c' }, "b" };
            yield return new object[] { new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F' }, String.Empty };
            yield return new object[] { new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f' }, String.Empty };
            yield return new object[] { new List<char>() { 'A', 'B', 'C', 'E', 'F' }, "D" };
            yield return new object[] { new List<char>() { 'a', 'b', 'c', 'e', 'f' }, "d"};
            yield return new object[] { new List<char>() { 'E', 'F', 'G', 'I' }, "H" };
            yield return new object[] { new List<char>() { 'e', 'f', 'g', 'i' }, "h" };
        }

        [Theory]
        [MemberData(nameof(testData))]
        public void FindTheMissingLetters_ShouldReturnAString_ContainingMissingLetter(List<char> original, string expected)
        {
            // arrange
            var sut = new FindMissingLetter();

            // act 
            var actual = sut.FindTheMissingLetter(original);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
