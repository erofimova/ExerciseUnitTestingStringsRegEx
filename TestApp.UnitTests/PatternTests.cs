using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
  
    [TestCase("hello", 3, "hElLohElLohElLo")]
    [TestCase("ABCdef", 5, "aBcDeFaBcDeFaBcDeFaBcDeFaBcDeF")]
    [TestCase("Evgeniya", 2, "eVgEnIyAeVgEnIyA")]

    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange and Act

        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 3;  

        // Act and Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));

    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "Dark place";
        int repetitionFactor = -2;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "Dark place";
        int repetitionFactor = 0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}
