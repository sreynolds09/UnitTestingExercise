using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 0, 1, 2)]
        [InlineData(1, 2, 3, 6)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
            {
                var c = new Calculator();
                var actual = c.Add(num1, num2, num3);
                Assert.Equal(expected, actual);
        
            }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 0, -1)]
        [InlineData(1, 3, -2)]
            //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            var s = new Calculator();
            var actual = s.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(-1, 2, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(1, -2, -2)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var m = new Calculator();
            var actual = m.Multiply(num1, num2);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(1, 1, 1)]
        [InlineData(1, 1, 1)]
        [InlineData(12, 2, 6)]
        public void DivideTest(int num1, int num2, int expected)
        {
            var d = new Calculator();
            var actual = d.Divide(num1, num2);
            Assert.Equal(expected, actual);

        }

    }
}
