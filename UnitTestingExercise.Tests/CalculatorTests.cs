using Xunit;
using System;
using System.Collections.Generic;


namespace UnitTestingExercise.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1, 2, 3, 4)]
    [InlineData(0, 0, 0, 0)]
    [InlineData(1, 0, 1, 0)]
    [InlineData(1, 2, 3, 5)]

    public void AddTest(int num1, int num2, int num3, int expected)
    {
        var c = new Calculator();
        var actual = c.Add(num1, num2, num3);
        Assert.Equal(expected, actual);
        
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 0, -1)]
    [InlineData(1, 2, 3)]

    public void SubtractTest(int num1, int num2, int expected)
    {
        var s = new Calculator();
        var actual = s.Subtract(num1, num2);
        Assert.Equal(expected, actual);
        
    }
}

