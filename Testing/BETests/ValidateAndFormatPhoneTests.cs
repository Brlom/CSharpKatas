using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class ValidateAndFormatPhoneTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("08559912983")]
        [InlineData("+2082394891246")]
        [InlineData("This is not a valid number")]
        public void SendToTwilio_ShouldReturnInvalid_WhenValidationFails(string enteredNum)
        {
            // arrange
            string expected = "Invalid phone number";

            var sut = new ValidateAndFormatPhone();

            // act
            string actual = sut.SendToTwilio(enteredNum);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SendToTwilio_ShouldReturnFormattedNum_WhenValidPrivateNumProvided()
        {
            // arrange
            string original = "01616603202";
            string expected = "+441616603202";

            var sut = new ValidateAndFormatPhone();

            // act
            string actual = sut.SendToTwilio(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SendToTwilio_ShouldReturnFormattedNum_WhenLongerValidNumProvided()
        {
            // arrange
            string original = "00441616603202";
            string expected = "+441616603202";

            var sut = new ValidateAndFormatPhone();

            // act
            var actual = sut.SendToTwilio(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SendToTwilio_ShouldReturnFormattedNum_WhenValid0DigitNumProvided()
        {
            // arrange
            string original = "07540706000";
            string expected = "+447540706000";

            var sut = new ValidateAndFormatPhone();

            // act
            var actual = sut.SendToTwilio(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SendToTwilio_ShouldReturnFormattedNum_WhenValid44DigitNumProvided()
        {
            // arrange
            string original = "+447540706000";
            string expected = "+447540706000";

            var sut = new ValidateAndFormatPhone();

            // act
            var actual = sut.SendToTwilio(original);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
