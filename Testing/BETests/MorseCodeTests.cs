using Katas.BE;
using Xunit;

namespace Testing.BETests
{
    public class MorseCodeTests
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(null, true)]
        [InlineData("", true)]
        public void DecodeMorse_ShouldReturnEmptyString_WhenPassedNullOrEmpty(string morseCode, bool toMorse)
        {
            // arrange
            string expected = string.Empty;

            var sut = new MorseCode();

            // act
            var actual = sut.MorseDecode(morseCode, toMorse);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("....", false, "H")]
        [InlineData("H", true, "....")]
        public void DecodeMorse_ShouldReturnDecodedValue_WhenPassedSingleValue(string original, bool toMorse, string expected)
        {
            // arrange
            var sut = new MorseCode();

            // act
            var actual = sut.MorseDecode(original, toMorse);

            // assert
            Assert.Equal(expected, actual);
        }
      
        [Theory]
        [InlineData(".... ..", false, "Hi")]
        [InlineData("Hi", true, ".... ..")]
        [InlineData(".... . .-.. .-.. ---", false, "Hello")]
        [InlineData("Hello", true, ".... . .-.. .-.. ---")]
        [InlineData("-. --- .-. - .... -.-. --- -.. . .-. ...", false, "Northcoders")]
        [InlineData("Northcoders", true, "-. --- .-. - .... -.-. --- -.. . .-. ...")]
        public void DecodeMorse_ShouldReturnDecodedWord_WhenPassedSingleWord(string original, bool toMorse, string expected)
        {
            // arrange
            var sut = new MorseCode();

            // act
            var actual = sut.MorseDecode(original, toMorse);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("--. --- --- -..   -- --- .-. -. .. -. --.   -. --- .-. - .... -.-. --- -.. . .-. ...", false, "Good morning northcoders")]
        [InlineData("Good morning northcoders", true, "--. --- --- -..   -- --- .-. -. .. -. --.   -. --- .-. - .... -.-. --- -.. . .-. ...")]
        public void DecodeMorse_ShouldReturnDecodedString_WhenPassedMultipleWordStr(string original, bool toMorse, string expected)
        {
            // arrange
            var sut = new MorseCode();

            // act
            var actual = sut.MorseDecode(original, toMorse);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
