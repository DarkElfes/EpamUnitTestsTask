namespace ConsoleSomeCalc.UnitTests.SomeCalcTests;

public class SomeCalcTests
{
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("a", 1)]
    [InlineData("aaaa", 1)]
    [InlineData("abab", 4)]
    [InlineData("aabba", 2)]
    [InlineData("abcba", 5)]
    public void CountMaxUnequalConsecutiveCharacters_Should_ReturnExpectedCount(string? input, int expected)
    {
        // Act
        var actual = SomeCalc.CountMaxUnequalConsecutiveCharacters(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("a", 1)]
    [InlineData("aaa", 3)]
    [InlineData("aaabbb", 3)]
    [InlineData("abcabc", 1)]
    [InlineData("aA", 1)]
    [InlineData("aa11aa", 2)]
    [InlineData("aa1aaaa", 4)]
    [InlineData("12345", 0)]
    public void CountMaxConsecutiveEqualLetters_Should_ReturnExpectedCount(string? input, int expected)
    {
        // Act
        var actual = SomeCalc.CountMaxConsecutiveEqualLetters(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("1", 1)]
    [InlineData("111", 3)]
    [InlineData("111222", 3)]
    [InlineData("123123", 1)]
    [InlineData("11a11", 2)]
    [InlineData("11a1111", 4)]
    [InlineData("abcde", 0)]
    public void CountMaxConsecutiveEqualDigits_Should_ReturnExpectedCount(string? input, int expected)
    {
        // Act
        var actual = SomeCalc.CountMaxConsecutiveEqualDigits(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
