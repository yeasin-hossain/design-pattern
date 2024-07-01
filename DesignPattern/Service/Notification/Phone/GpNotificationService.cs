using DesignPattern.Service.Interface;

namespace DesignPattern.Service.Notification.Phone;

public class GpNotificationService: INotificationService
{
    public Task<string> SentNotificationAsync()
    {
        return Task.FromResult("Successfully sent notification to GP Service");
    }
}