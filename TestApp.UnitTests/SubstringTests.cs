using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input); 

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "One";
        string input = "One quick brown fox jumps over the lazy dog";
        string expected = "quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "One quick brown fox jumps over the lazy dog";
        string expected = "One quick brown fox jumps over the lazy";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "I love you";
        string input = "I love you";
        string expected = "";
        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
