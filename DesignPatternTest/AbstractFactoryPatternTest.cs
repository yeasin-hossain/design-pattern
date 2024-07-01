using DesignPattern.Enum;
using DesignPattern.Service.DesignPatterns.AbstractFactory;
using DesignPattern.Service.Interface;

namespace DesignPatternTest;

[TestFixture]
public class AbstractFactoryPatternTest
{
    private INotification _notificationService;
    
    [SetUp]
    public void Setup()
    {
        _notificationService = new NotificationService();
    }

    [Test]
    public async Task Sent_Phone_Notification_ReturnsExpectedResult()
    {
        var result = await _notificationService.Sent(NotificationMediumEnum.PHONE, NotificationEnum.GP);
        Assert.That(result, Is.EqualTo("Successfully sent notification to GP Service"));
    }
    
    [Test]
    public async Task Email_Medium_And_Wrong_Provider_ReturnsExpectedFailResult()
    {
        var result = await _notificationService.Sent(NotificationMediumEnum.EMAIL,NotificationEnum.GP);
        Assert.That(result, Is.EqualTo("Notification sent failed email"));
    }
}