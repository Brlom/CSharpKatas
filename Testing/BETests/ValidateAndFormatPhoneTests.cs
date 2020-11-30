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
    }
}
