using DesignPattern.Enum;
using DesignPattern.Service.Interface;
using DesignPattern.Service.Notification.Phone;

namespace DesignPattern.Service.DesignPatterns.Factory;

public class PhoneNotificationService
{
    private readonly INotificationService _gpNotificationService;
    private readonly INotificationService _robiNotificationService;

    public PhoneNotificationService()
    {
        this._gpNotificationService = new GpNotificationService();
        this._robiNotificationService = new RobiNotificationService();
    }

    public async Task<string> SentSmsNotification(NotificationEnum providerType)
    {
        return providerType switch
        {
            NotificationEnum.GP => await _gpNotificationService.SentNotificationAsync(),
            NotificationEnum.ROBI => await _robiNotificationService.SentNotificationAsync(),
            _ => "Notification sent failed"
        };
    }
}