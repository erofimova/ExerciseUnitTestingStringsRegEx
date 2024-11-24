using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
   
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] words = {"blue", "green", "red"};
        string text = "Colors: yellow, white, black";
        string expected = "Colors: yellow, white, black";
        // Act
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] words = {"red","blue"};
        string text = "Colors: yellow, red, white, black";
        string expected = "Colors: yellow, ***, white, black";
        // Act   
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string [] words = Array.Empty<string>();
        string text = "Colors: yellow, red, white, black";
        string expected = "Colors: yellow, red, white, black";
        // Act
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] words = {" "};
        string text = "Colors: yellow, red, white, black";
        string expected = "Colors:*yellow,*red,*white,*black";
        // Act
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
