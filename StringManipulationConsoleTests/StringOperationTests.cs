using StringManipulationConsole;

namespace StringManipulationConsoleTests;

public class StringOperationTests
{
    [Fact]
    public void ConcatenateStringsTest()
    {
        // Arrange
        const string expected = "Hello World";
        var stringOperations = new StringOperations();

        // Act
        var result = stringOperations.ConcatenateStrings("Hello", "World");

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IsPalindromeTest_True()
    {
        // Arrange
        const string palindrome = "ama";
        var stringOperations = new StringOperations();

        // Act
        var result = stringOperations.IsPalindrome(palindrome);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindromeTest_False()
    {
        // Arrange
        const string notPalindrome = "hello";
        var stringOperations = new StringOperations();

        // Act
        var result = stringOperations.IsPalindrome(notPalindrome);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void RemoveWhitespaceTest()
    {
        // Arrange
        const string input = "Hello World";
        const string expected = "HelloWorld";
        var stringOperations = new StringOperations();

        // Act
        var result = stringOperations.RemoveWhitespace(input);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void QuantityInWordsTest()
    {
        // Arrange
        const string input = "City";
        const int quantity = 3;
        var stringOperations = new StringOperations();

        // Act
        var result = stringOperations.QuantityInWords(input, quantity);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.StartsWith("three", result);
        Assert.EndsWith("Cities", result);
        Assert.Contains("Cit", result);
        Assert.Equal("three Cities", result);
    }

    [Fact]
    public void GetStringLengthTest_Exception()
    {
        var stringOperations = new StringOperations();

        Assert.ThrowsAny<ArgumentNullException>(() => stringOperations.GetStringLength(null));
    }

    [Theory]
    [InlineData("V", 5)]
    [InlineData("III", 3)]
    [InlineData("IX", 9)]
    public void FromRomanToNumber(string romanNumber, int expected)
    {
        // Arrange
        var stringOperations = new StringOperations();
        var result = stringOperations.FromRomanToNumber(romanNumber);
        Assert.Equal(expected, result);
    }
}