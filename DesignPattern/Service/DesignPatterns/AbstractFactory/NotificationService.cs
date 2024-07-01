using DesignPattern.Enum;
using DesignPattern.Service.DesignPatterns.Factory;
using DesignPattern.Service.Interface;
using DesignPattern.Service.Notification.Email;

namespace DesignPattern.Service.DesignPatterns.AbstractFactory;

public class NotificationService: INotification
{
    private readonly EmailNotificationService _emailNotificationService;
    private readonly PhoneNotificationService _phoneNotificationService;

    public NotificationService()
    {
        this._emailNotificationService = new EmailNotificationService();
        this._phoneNotificationService = new PhoneNotificationService();
    }
    
    public async Task<string> Sent(NotificationMediumEnum mediumType, NotificationEnum providerType)
    {
        // TODO i know it has bug on provider type, if select phone medium and email provider it will break. 
        return mediumType switch
        {
            NotificationMediumEnum.PHONE => await _phoneNotificationService.SentPhoneNotification(providerType),
            NotificationMediumEnum.EMAIL => await _emailNotificationService.SentEmailNotification(providerType),
            _ => "Notification sent failed from service"
        };
    }
}