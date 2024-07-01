using DesignPattern.Enum;
using DesignPattern.Service.Interface;

namespace DesignPattern.Service.DesignPatterns.Factory;

public class SmsNotificationService
{
    private readonly INotificationService _gpNotificationService;
    private readonly INotificationService _robiNotificationService;

    public SmsNotificationService(INotificationService gpNotificationService, 
        INotificationService robiNotificationService)
    {
        this._gpNotificationService = gpNotificationService;
        this._robiNotificationService = robiNotificationService;
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