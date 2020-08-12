using Katas.BE;
using System.Collections.Generic;
using Xunit;

namespace Testing.BETests
{
    public class TillAdditionTests
    {
        [Fact]
        public void GetSumOfCashInTill_WhenPassedEmptyDict_ShouldReturnZero()
        {
            // arrange
            var original = new Dictionary<string, int>();
            string expected = "£0.00";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumOfCashInTill_WhenPassedDict_ShouldReturnSum()
        {
            // arrange
            var original = new Dictionary<string, int>()
            {
                { "1p", 1 },
                { "2p", 1 }
            };
            string expected = "£0.03";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumOfCashInTill_WhenPassedDictWithFiveCoins_ShouldReturnSum()
        {
            // arrange
            var original = new Dictionary<string, int>()
            {
                { "1p", 1 },
                { "2p", 1 },
                { "5p", 1 },
                { "10p", 1 },
                { "20p", 1 }
            };
            string expected = "£0.38";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumOfCashInTill_WhenPassedDictWithSixCoins_ShouldReturnSum()
        {
            // arrange
            var original = new Dictionary<string, int>()
            {
                { "1p", 1 },
                { "2p", 1 },
                { "5p", 1 },
                { "10p", 1 },
                { "20p", 1 },
                { "50p", 1 },
                { "£1", 1 }
            };
            string expected = "£1.88";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumOfCashInTill_WhenPassedDictWithCoinAndBills_ShouldReturnSum()
        {
            // arrange
            var original = new Dictionary<string, int>()
            {
                { "1p", 1 },
                { "2p", 1 },
                { "5p", 1 },
                { "10p", 1 },
                { "20p", 1 },
                { "50p", 1 },
                { "£1", 1 },
                { "£2", 1 },
                { "£5", 1 },
                { "£10", 1 },
                { "£20", 1 },
                { "£50", 1 }
            };
            string expected = "£88.88";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumOfCashInTill_WhenPassedSeveralOfEachEntity_ShouldReturnSum()
        {
            // arrange
            var original = new Dictionary<string, int>()
            {
                { "1p", 10 },
                { "2p", 3 },
                { "5p", 1 },
                { "10p", 6 },
                { "20p", 1 },
                { "50p", 1 }, 
                { "£1", 5 },
                { "£2", 1 },
                { "£5", 1 },
                { "£10", 1 },
                { "£20", 1 },
                { "£50", 4 } 
            };
            string expected = "£243.51";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumOfCashInTill_WhenPennySumValIsEqualOrMoreThanHundred_ShouldAddAsPound()
        {
            // arrange
            var original = new Dictionary<string, int>()
            {
                { "1p", 100 }, 
                { "2p", 3 },
                { "5p", 1 },
                { "10p", 6 },
                { "20p", 1 }, 
                { "50p", 4 },  
                { "£1", 5 },
                { "£2", 1 },
                { "£5", 1 },
                { "£10", 1 },
                { "£20", 1 },
                { "£50", 4 } 
            };
            string expected = "£245.91";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumOfCashInTill_WhenPennyValueIsDoubleDigitPoundValue_ShouldAddAsPounds()
        {
            // arrange
            var original = new Dictionary<string, int>()
            {
                { "1p", 100 }, 
                { "2p", 3 },
                { "5p", 1 },
                { "10p", 6 },
                { "20p", 1 }, 
                { "50p", 20 },  
                { "£1", 5 },
                { "£2", 1 },
                { "£5", 1 },
                { "£10", 1 },
                { "£20", 1 },
                { "£50", 4 } 
            };
            string expected = "£253.91";

            var x = new TillAddition();

            // act
            var actual = x.GetSumOfCashInTill(original);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}