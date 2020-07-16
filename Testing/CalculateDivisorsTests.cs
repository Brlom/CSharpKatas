using Katas.Core;
using Xunit;

namespace Testing
{
    public class CalculateDivisorsTests
    {
        [Fact]
        public void CalculateDivisors_WhenStartingNumIsZero_ReturnsStartingNum()
        {
            // arrange
            int startingNum = 0;
            CalculateDivisors x = new CalculateDivisors();

            // act
            int newVal = x.CalculateDivisor(startingNum);

            // assert
            Assert.Equal(startingNum, newVal);
        }

        [Fact]
        public void CalculateDivisors_WhenStartingNumIsOne_ReturnsZero()
        {
            // arrange
            int startingNum = 1;
            CalculateDivisors x = new CalculateDivisors();

            // act
            int newVal = x.CalculateDivisor(startingNum);

            // assert
            Assert.Equal(0, newVal);
        }

        [Fact]
        public void CalculateDivisors_WhenStartingNumIsFive_ReturnsThree()
        {
            // arrange
            int startingNum = 5;
            CalculateDivisors x = new CalculateDivisors();

            // act
            int newVal = x.CalculateDivisor(startingNum);

            // assert
            Assert.Equal(3, newVal);
        }

        [Fact]
        public void CalculateDivisors_WhenStartingNumIsSix_ReturnsFivePlusThree()
        {
            // arrange
            int startingNum = 6;
            int sumDivisibleNums = 5 + 3;
            CalculateDivisors x = new CalculateDivisors();

            // act 
            int newVal = x.CalculateDivisor(startingNum);

            // assert
            Assert.Equal(sumDivisibleNums, newVal);
        }

        [Fact]
        public void CalculateDivisors_WhenStartingNumIsTen_ReturnsAddedDivisibleNums()
        {
            // arrange
            int startingNum = 10;
            int sumDivisibleNums = 9 + 6 + 5 + 3;
            CalculateDivisors x = new CalculateDivisors();

            // act
            int newVal = x.CalculateDivisor(startingNum);

            // assert
            Assert.Equal(sumDivisibleNums, newVal);
        }

        [Fact]
        public void CalculateDivisors_WhenStartingNumIsLargerThanTen_ReturnsAddedDivisibleNums()
        {
            // arrange
            int startingNum = 12;
            int sumDivisibleNums = 10 + 9 + 6 + 5 + 3;

            CalculateDivisors x = new CalculateDivisors();

            // act
            int newVal = x.CalculateDivisor(startingNum);

            // assert
            Assert.Equal(sumDivisibleNums, newVal);
        }
    }
}
