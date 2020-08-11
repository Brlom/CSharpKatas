using Katas.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class FoldStringTests
    {
        [Fact]
        public void FoldString_WhenPassedEmptyStr_ShouldReturnEmptyStr()
        {
            // arrange
            string empty = String.Empty;
            FoldString x = new FoldString();

            // act
            string actual = x.StringFolder(empty);

            // assert
            Assert.Equal(empty, actual);
        }

        [Fact]
        public void FoldString_WhenPassedEvenStr_ShouldReturnFoldedStr()
        {
            // arrange
            string original = "code";
            string original2 = "abcdef";
            string original3 = "javascript";
            FoldString x = new FoldString();
            string expected = "oced";
            string expected2 = "cbafed";
            string expected3 = "savajtpirc";

            // act
            string actual = x.StringFolder(original);
            string actual2 = x.StringFolder(original2);
            string actual3 = x.StringFolder(original3);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
        }

        [Fact]
        public void FoldString_WhenPassedOddStr_ShouldReturnFoldeStr()
        {
            // arrange
            string original = "Northcoders";
            FoldString x = new FoldString();
            string expected = "htroNcsredo";

            // act
            string actual = x.StringFolder(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FoldString_WhenPassedStrWithSpaces_ShouldReturnFoldedStrWithSpaces()
        {
            // arrange
            string original = "javascript is cool";
            FoldString x = new FoldString();
            string expected = "savajtpirc is oclo";

            // act
            string actual = x.StringFolder(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FoldString_WhenPassedStrWithPunctuation_ShouldReturnFoldedStrWithPunct()
        {
            // arrange
            string original = "javascript is cool.";
            string original2 = "To javascript, or not to javascript? That is the question.";
            FoldString x = new FoldString();
            string expected = "savajtpirc is oclo.";
            string expected2 = "To savajtpirc, or not to savajtpirc? hTta is the seuqnoit.";

            // act
            string actual = x.StringFolder(original);
            string actual2 = x.StringFolder(original2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }
    }
}
