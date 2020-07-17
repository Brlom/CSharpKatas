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
            Assert.Empty(dnaPairs.pairsList);
        }

        [Fact]
        public void DnaPairs_Valid_CheckReturnsPairValueWhenPassedOneDNAValue()
        {
            // arrange
            string dnaString = "G";

            // act
            var dnaPairs = new DnaPairs(dnaString);

            // assert
            Assert.Equal(dnaPairs.pairsList, new List<char[]>() { new char[] { 'G', 'C' } });
        }
    }
}
