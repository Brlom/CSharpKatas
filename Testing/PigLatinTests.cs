using System;
using Katas.Core;
using Xunit;

namespace Testing
{
    public class PigLatinTests
    {
        [Fact]
        public void PigLatin_WhenPassedEmptyStr_ShouldReturnEmptyStr()
        {
            // arrange
            string empty = String.Empty;
            PigLatin x = new PigLatin();

            // act
            string actual = x.PigLatinKata(empty);

            // assert
            Assert.Equal(empty, actual);
        }

        [Fact]
        public void PigLatin_WhenPassedStrStartingWithVowel_ShouldReturnAppendedStr()
        {
            // arrange
            string vowelStr = "algorithm";
            PigLatin x = new PigLatin();
            string pigLatinStr = "algorithmway";

            // act
            string actual = x.PigLatinKata(vowelStr);

            // assert
            Assert.Equal(pigLatinStr, actual);
        }

        [Fact]
        public void PigLatin_WhenPassedStrStartingWithConst_ShouldReturnAppendedStr()
        {
            // arrange
            string constStr = "northcoders";
            PigLatin x = new PigLatin();
            string pigLatinStr = "orthcodersnay";

            // act
            string actual = x.PigLatinKata(constStr);

            // assert
            Assert.Equal(pigLatinStr, actual);
        }

        [Fact]
        public void PigLatin_WhenPassedStrStartingWithSeveralConst_ShouldReturnAppendedStr()
        {
            // arrange
            string constStr = "sheffield";
            PigLatin x = new PigLatin();
            string pigLatinStr = "effieldshay";

            // act
            string actual = x.PigLatinKata(constStr);

            // assert
            Assert.Equal(pigLatinStr, actual);
        }

        [Fact]
        public void PigLatin_WhenSeveralWordsPassedIn_ShouldEachWordAsPigLatin()
        {
            // arrange
            string constStr = "keep on coding";
            PigLatin x = new PigLatin();
            string pigLatinStr = "eepkay onway odingcay";

            // act
            string actual = x.PigLatinKata(constStr);

            // arrange 
            Assert.Equal(pigLatinStr, actual);
        }

        [Fact]
        public void PigLatin_WhenPunctuationPresent_ShouldKeepPunctuation()
        {
            // arrange
            string constStr = "keep on coding.";
            string constStr2 = "keep! on coding.";
            string constStr3 = "keep! on, coding.";

            PigLatin x = new PigLatin();
            
            string pigLatinStr = "eepkay onway odingcay.";
            string pigLatinStr2 = "eepkay! onway odingcay.";
            string pigLatinStr3 = "eepkay! onway, odingcay.";

            // act
            string actual = x.PigLatinKata(constStr);
            string actual2 = x.PigLatinKata(constStr2);
            string actual3 = x.PigLatinKata(constStr3);

            // assert
            Assert.Equal(pigLatinStr, actual);
            Assert.Equal(pigLatinStr2, actual2);
            Assert.Equal(pigLatinStr3, actual3);
        }

        [Fact]
        public void PigLatin_WhenStrHasUpperAndLower_ShouldReturnUpperAndLower()
        {
            // arrange
            string constStr = "KEep ON cODinG";
            PigLatin x = new PigLatin();
            string pigLatinStr = "EepKay ONway ODinGcay";

            // act
            string actual = x.PigLatinKata(constStr);

            // assert
            Assert.Equal(pigLatinStr, actual);
        }
    }
}
