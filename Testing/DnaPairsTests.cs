using Katas.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class DnaPairsTests
    {
        [Fact]
        public void DnaPairs_Valid_CheckReturnsEmptyWhenPassedEmptyString()
        {
            // arrange
            string empty = String.Empty;

            // act
            var dnaPairs = new DnaPairs(empty);

            // assert
            Assert.Empty(dnaPairs.pairsArr);
        }

        [Fact]
        public void DnaPairs_Valid_CheckReturnsPairValueWhenPassedOneDNAValue()
        {
            // arrange
            string dnaString = "G";
            char[][] expectedArr = new char[][] { new char[] { 'G', 'C' } };

            // act
            var dnaPairs = new DnaPairs(dnaString);

            // assert
            Assert.Equal(dnaPairs.pairsArr, expectedArr);
        }

        [Fact]
        public void DnaPairs_Valid_CheckReturnsTwoKeyValueArrWhenPassedTwoValues()
        {
            // arrange
            string dnaString = "AG";
            char[][] expectedArr = new char[][] { new char[] { 'A', 'T' }, new char[] { 'G', 'C' } };

            // act
            var dnaPairs = new DnaPairs(dnaString);

            // arrange
            Assert.Equal(dnaPairs.pairsArr, expectedArr);
        }

        [Fact]
        public void DnaPairs_Valid_CheckReturnsAllKeyValuePairsWhenPassedStringWithSeveral()
        {
            // arrange
            string dnaString = "ATCG";
            char[][] expectedArr = new char[][] { new char[] { 'A', 'T' }, new char[] { 'T', 'A' }, new char[] { 'C', 'G' }, new char[] { 'G', 'C' } };

            // act
            var dnaPairs = new DnaPairs(dnaString);

            // arrange
            Assert.Equal(dnaPairs.pairsArr, expectedArr);
        }

        [Fact]
        public void DnaPairs_Valid_ShouldThrowAwayInvalidChars()
        {
            // arrange
            string dnaString = "LATZZCGY";
            char[][] expectedArr = new char[][] { new char[] { 'A', 'T' }, new char[] { 'T', 'A' }, new char[] { 'C', 'G' }, new char[] { 'G', 'C' } };

            // act 
            var dnaPairs = new DnaPairs(dnaString);

            // arrange 
            Assert.Equal(dnaPairs.pairsArr, expectedArr);
        }

        [Fact]
        public void DnaPairs_Valid_ShouldWorkWithUpperAndLowerCase()
        {
            // arrange
            string dnaString = "aTCg";
            char[][] expectedArr = new char[][] { new char[] { 'A', 'T' }, new char[] { 'T', 'A' }, new char[] { 'C', 'G' }, new char[] { 'G', 'C' } };

            // act 
            var dnaPairs = new DnaPairs(dnaString);

            // arrange 
            Assert.Equal(dnaPairs.pairsArr, expectedArr);
        }
    }
}
