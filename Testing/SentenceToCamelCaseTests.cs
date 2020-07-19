using Katas.Core;
using NuGet.Frameworks;
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

        [Fact]
        public void SentenceToCamelCase_WhenPassedStrAndTrue_ShouldReturnUpperCamelCaseStr()
        {
            // arrange
            string original = "this sentence";
            bool shouldItBeUpperCamelCase = true;
            SentenceToCamelCase x = new SentenceToCamelCase();
            string expectedReturn = "ThisSentence";

            // act
            string actual = x.ConvertToCamelCase(original, shouldItBeUpperCamelCase);

            // assert
            Assert.Equal(expectedReturn, actual);
        }

        [Fact]
        public void SentenceToCamelCase_WhenPassedStrAndFalse_ShouldReturnLowerCamelCaseStr()
        {
            // arrange
            string original = "this sentence";
            bool shouldItBeUpperCamelCase = false;
            SentenceToCamelCase x = new SentenceToCamelCase();
            string expectedReturn = "thisSentence";

            // act
            string actual = x.ConvertToCamelCase(original, shouldItBeUpperCamelCase);

            // assert
            Assert.Equal(expectedReturn, actual);
        }

        [Fact]
        public void SentenceToCamelCase_WhenPassedStrangeStrAndTrue_ShouldReturnUpperCamelCaseStr()
        {
            // arrange
            string original = "This Bigger strange Sentence";
            bool shouldItBeUpperCamelCase = true;
            SentenceToCamelCase x = new SentenceToCamelCase();
            string expectedReturn = "ThisBiggerStrangeSentence";

            // act
            string actual = x.ConvertToCamelCase(original, shouldItBeUpperCamelCase);

            // assert
            Assert.Equal(expectedReturn, actual);
        }

        [Fact]
        public void SentenceToEnglish_WhenPassedEmptyStr_ShouldReturnEmptyStr()
        {
            // arrange
            string empty = String.Empty;
            SentenceToCamelCase x = new SentenceToCamelCase();

            // act 
            string actual = x.ConvertToEnglish(empty);

            // assert 
            Assert.Equal(empty, actual);
        }

        [Fact]
        public void SentenceToEnglish_WhenPassedCamelCaseStr_ShouldReturnNormalStr()
        {
            // arrange
            string original = "ThisBiggerStrangeSentence";
            SentenceToCamelCase x = new SentenceToCamelCase();
            string expectedReturn = "This bigger strange sentence";

            // act
            string actual = x.ConvertToEnglish(original);

            // assert
            Assert.Equal(expectedReturn, actual);
        }
        
        [Fact]
        public void SentenceToEnglish_WhenPassedLowerCamelCaseStr_ShouldReturnNormalStr()
        {
            // arrange
            string original = "thisBiggerStrangeSentence";
            SentenceToCamelCase x = new SentenceToCamelCase();
            string expectedReturn = "This bigger strange sentence";

            // act
            string actual = x.ConvertToEnglish(original);

            // assert
            Assert.Equal(expectedReturn, actual);
        }        
    }
}
