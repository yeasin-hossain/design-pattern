using DesignPattern.Enum;
using DesignPattern.Service.DesignPatterns.Factory;

namespace DesignPatternTest;

public class FactoryPatternTest
{
    private EmailNotificationService _emailNotificationService;
    [SetUp]
    public void Setup()
    {
        _emailNotificationService = new EmailNotificationService();
    }

    [Test]
    public async Task SentEmailNotification_ReturnsExpectedResult()
    {
        var result = await _emailNotificationService.SentEmailNotification(NotificationEnum.GMAIL);
        Assert.That(result, Is.EqualTo("Successfully sent notification to Gmail Service"));
    }
    
    [Test]
    public async Task SentEmailNotification_ReturnsExpectedFailResult()
    {
        var result = await _emailNotificationService.SentEmailNotification(NotificationEnum.GP);
        Assert.That(result, Is.EqualTo("Notification sent failed email"));
    }
}