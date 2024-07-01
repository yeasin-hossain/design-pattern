using DesignPattern.Enum;
using DesignPattern.Service.Interface;
using DesignPattern.Service.Notification.Email;

namespace DesignPattern.Service.DesignPatterns.Factory;

public class EmailNotificationService
{
    private readonly INotificationService _gmailNotificationService;
    private readonly INotificationService _brevoNotificationService;

    public EmailNotificationService()
    {
        this._gmailNotificationService = new GmailNotificationService();
        this._brevoNotificationService = new BrevoNotificationService();
    }

    public async Task<string> SentEmailNotification(NotificationEnum providerType)
    {
        return providerType switch
        {
            NotificationEnum.GMAIL => await _gmailNotificationService.SentNotificationAsync(),
            NotificationEnum.BREVO => await _brevoNotificationService.SentNotificationAsync(),
            _ => "Notification sent failed"
        };
    }
}