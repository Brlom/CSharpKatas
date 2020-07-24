using Katas.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class HerdTheBabiesTests
    {
        [Fact]
        public void SortTheBabies_WhenPassedAnEmptyStr_ShouldReturnEmptyStr()
        {
            // arrange
            string original = String.Empty;
            HerdTheBabies x = new HerdTheBabies();

            // act
            string actual = x.SortTheBabies(original);

            // assert
            Assert.Equal(original, actual);
        }

    }
}
