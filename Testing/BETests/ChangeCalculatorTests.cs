using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class ChangeCalculatorTests
    {
        [Fact]
        public void CalculateChange_WhenPassedNoChange_ShouldReturnEmptyObject()
        {
            // arrange
            double original = 0;
            var expected = new Dictionary<string, double>();

            var x = new ChangeCalculator();

            // act
            var actual = x.CalculateChange(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateChange_WhenPassedValueDivisibleBySingleCoinValue_ShouldReturnObjectWithOneKeyValPair()
        {
            // arrange
            double original = 1;
            var expected = new Dictionary<string, double>()
            {
                { "1", 1 }
            };

            double original2 = 2;
            var expected2 = new Dictionary<string, double>()
            {
                { "2", 1 }
            };

            var x = new ChangeCalculator();

            // act
            var actual = x.CalculateChange(original);
            var actual2 = x.CalculateChange(original2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void CalculateChange_WhenPassedValueNotEqualToAnyKey_ShouldDivideIntoSeveralKeys_AndReturnObject()
        {
            // arrange
            double original = 7;
            var expected = new Dictionary<string, double>()
            {
                { "2", 1 },
                { "5", 1 }
            };

            var x = new ChangeCalculator();

            // act
            var actual = x.CalculateChange(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateChange_WhenPassedDoubleDigitNum_ShouldStillReturnCorrectObject()
        {
            //arrange
            double original = 13;
            var expected = new Dictionary<string, double>()
            {
                { "1", 1 },
                { "2", 1 },
                { "10", 1 }
            };

            var x = new ChangeCalculator();

            // act
            var actual = x.CalculateChange(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateChange_WhenPassedTripleDigitNum_ShouldReturnObjectWithMultipleCoinsWherePossible()
        {
            //arrange
            double original = 229;
            var expected = new Dictionary<string, double>()
            {
                { "2", 2 },
                { "5", 1 },
                { "20", 1 },
                { "50", 4 }
            };

            var x = new ChangeCalculator();

            // act
            var actual = x.CalculateChange(original);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
