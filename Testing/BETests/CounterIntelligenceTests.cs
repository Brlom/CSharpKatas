using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class CounterIntelligenceTests
    {
        [Fact]
        public void CounterIntelligence_StringDecoder_ShouldReturnStr()
        {
            // arrange
            var original = String.Empty;
            var expected = String.Empty;
            var x = new CounterIntelligence();

            // act
            var actual = x.StringDecoder(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CounterIntelligence_StringDecoder_WhenPassedOneChar_ShouldReturnX()
        {
            // arrange
            string original = "Y";
            string expected = "X";
            var x = new CounterIntelligence();

            // act
            var actual = x.StringDecoder(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CounterIntelligence_StringDecoder_WhenPassedStrWithSpace_ShouldReturnDecodedStr()
        {
            // arranage
            string original = "BCDY";
            string expected = "ABCX";
            var x = new CounterIntelligence();

            // act
            var actual = x.StringDecoder(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CounterIntelligence_StringDecoder_WhenPassedStrWithNoSpace_ShouldReturnDecodedStr()
        {
            // arranage
            string original = "BCD Y";
            string expected = "ABC X";
            var x = new CounterIntelligence();

            // act
            var actual = x.StringDecoder(original);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
