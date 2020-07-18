using Katas.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class SentenceToCamelCaseTests
    {
        [Fact]
        public void SentenceToCamelCase_WhenPassedEmptyStr_ShouldReturnEmptyStr()
        {
            // arrange
            string empty = String.Empty;
            SentenceToCamelCase x = new SentenceToCamelCase();

            // act
            string actual = x.ConvertToCamelCase("", false);

            // assert
            Assert.Equal(empty, actual);
        }
    }
}
