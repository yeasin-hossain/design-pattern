using DesignPattern.Enum;
using DesignPattern.Service.DesignPatterns.Factory;
using DesignPattern.Service.Interface;
using DesignPattern.Service.Notification.Email;

namespace DesignPattern.Service.DesignPatterns.AbstractFactory;

public class NotificationService
{
    private readonly EmailNotificationService _emailNotificationService;
    private readonly PhoneNotificationService _phoneNotificationService;

    public NotificationService()
    {
        this._emailNotificationService = new EmailNotificationService();
        this._phoneNotificationService = new PhoneNotificationService();
    }

    public async Task<string> SentNotification(NotificationMediumEnum mediumType, NotificationEnum providerType)
    {
        return mediumType switch
        {
            NotificationMediumEnum.PHONE => await _emailNotificationService.SentEmailNotification(providerType),
            NotificationMediumEnum.EMAIL => await _phoneNotificationService.SentSmsNotification(providerType),
            _ => "Notification sent failed"
        };
    }
}