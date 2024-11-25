using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("abv%_123AA@abv.bg")]
    [TestCase("abv12QQ@abv.bg")]
    [TestCase("abvAA@abv.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // A&A
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("abv123AA@%%.%")]
    [TestCase("AB&123AA@ABV.BG")]
    [TestCase("abv_-+^123AA@abvbg")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
