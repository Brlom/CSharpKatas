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
        public void CounterIntelligence_StringDecoder_WhenPassedStrWithASpace_ShouldReturnDecodedStr()
        {
            // arranage
            string original = "BCD Y";
            string expected = "ABC X";
            string original2 = "CDE Z";
            string expected2 = "ABC X";

            var x = new CounterIntelligence();

            // act
            var actual = x.StringDecoder(original);
            var actual2 = x.StringDecoder(original2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void CounterIntelligence_StringDecoder_WhenPassedStrWithSeveralSpaces_ShouldReturnDecodedStr()
        {
            // arrange
            string original = "NKRRU YCKKZNKGXZ D";
            string expected = "HELLO SWEETHEART X";

            var x = new CounterIntelligence();

            // act
            var actual = x.StringDecoder(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CounterIntelligence_StringDecoder_WhenPassedStrWithPunctuation_ShouldReturnDecodedStr()
        {
            // arrange
            string original = "ANVNVKNA CX YRLT DY IDLLQRWR XW HXDA FJH QXVN OAXV FXAT, MJAURWP G";
            string expected = "REMEMBER TO PICK UP ZUCCHINI ON YOUR WAY HOME FROM WORK, DARLING X";

            var x = new CounterIntelligence();

            // act 
            var actual = x.StringDecoder(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CounterIntelligence_StringDecoder_WhenPassedLowerCaseStr_ShouldReturnDecodedUpperStr()
        {
            // arrange
            string original = "ngbk g toik jge :) d";
            string expected = "HAVE A NICE DAY :) X";

            var x = new CounterIntelligence();

            // act
            var actual = x.StringDecoder(original);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
