using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class CounterSpyTests
    {
        [Fact]
        public void RemoveSpies_ShouldReturnList()
        {
            // arrange
            var list = new List<string>();
            var expected = new List<string>();
            var sut = new CounterSpy();

            // act
            var actual = sut.RemoveSpies(list);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpies_ShouldReturnEmptyList_WhenPassedSpy()
        {
            // arrange
            var list = new List<string>();
            list.Add("Daryl");
            var expected = new List<string>();
            var sut = new CounterSpy();

            // act
            var actual = sut.RemoveSpies(list);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpies_ShouldReturnNonSpies_WhenPassedList()
        {
            // arrange
            var list = new List<string>();
            list.Add("Daryl");
            list.Add("Harriet");
            list.Add("James");

            var list2 = new List<string>();
            list2.Add("Sam");
            list2.Add("Daryl");
            list2.Add("Chris");
            list2.Add("Harriet");
            list2.Add("Mauro");

            var expected = new List<string>();
            expected.Add("Harriet");

            var expected2 = new List<string>();
            expected2.Add("Harriet");
            expected2.Add("Mauro");

            var sut = new CounterSpy();

            // act
            var actual = sut.RemoveSpies(list);
            var actual2 = sut.RemoveSpies(list2);

            // assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void RemoveSpies_ShouldReturnOrderedList()
        {
            // arrange

            // act

            // assert
        }
    }
}
