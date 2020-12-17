using Katas.BE;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.BETests
{
    public class ValidateTriangleTests
    {
        [Fact]
        public void FindValidTriangles_ShouldReturnZero_WhenPassedEmptyList()
        {
            // arrange
            var empty = new List<int>();
            var triangles = new List<List<int>>();
            triangles.Add(empty);

            int expected = 0;

            var sut = new ValidateTriangle();

            // act
            var actual = sut.FindValidTriangles(triangles);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindValidTriangles_ShouldReturnZero_WhenPassedListContainingNoTriangles()
        {
            // arrange
            int[] fakeTriangle = { 5, 10, 25 };
            var noTriangles = new List<int>(fakeTriangle);

            var triangles = new List<List<int>>();
            triangles.Add(noTriangles);

            int expected = 0;

            var sut = new ValidateTriangle();

            // act
            var actual = sut.FindValidTriangles(triangles);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindValidTriangles_ShouldReturnNumTriangles_WhenPassedListContainingValidTriangle()
        {
            // arrange
            int[] validTriangle = { 5, 4, 5 };
            var triangle = new List<int>(validTriangle);

            var triangles = new List<List<int>>();
            triangles.Add(triangle);

            int expected = 1;

            var sut = new ValidateTriangle();

            // act
            var actual = sut.FindValidTriangles(triangles);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindValidTriangles_ShouldReturnNumValidTrianglesInList()
        {
            // arrange
            int[] validTriangle = { 542, 586, 419 };
            var triangle = new List<int>(validTriangle);

            int[] invalidTriangle = { 829, 272, 126 };
            var triangle2 = new List<int>(invalidTriangle);

            int[] validTriangle2 = { 660, 514, 367 };
            var triangle3 = new List<int>(validTriangle2);

            int[] invalidTriangle2 = { 39, 703, 839 };
            var triangle4 = new List<int>(invalidTriangle2);

            int[] invalidTriangle3 = { 229, 861, 2 };
            var triangle5 = new List<int>(invalidTriangle3);

            int[] validTriangle3 = { 235, 952, 840 };
            var triangle6 = new List<int>(validTriangle3);

            int[] invalidTriangle4 = { 892, 533, 108 };
            var triangle7 = new List<int>(invalidTriangle4);

            int[] invalidTriangle5 = { };
            var triangle8 = new List<int>(invalidTriangle5);

            var triangles = new List<List<int>>();
            triangles.Add(triangle);
            triangles.Add(triangle2);
            triangles.Add(triangle3);
            triangles.Add(triangle4);
            triangles.Add(triangle5);
            triangles.Add(triangle6);
            triangles.Add(triangle7);
            triangles.Add(triangle8);

            int expected = 3;

            var sut = new ValidateTriangle();

            // act
            var actual = sut.FindValidTriangles(triangles);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
