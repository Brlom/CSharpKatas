using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class MorseCodeTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void DecodeMorse_ShouldReturnEmptyString_WhenPassedNullOrEmpty(string morseCode)
        {
            // arrange
            string expected = string.Empty;

            var sut = new MorseCode();

            // act
            var actual = sut.MorseDecode(morseCode);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
