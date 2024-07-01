using DesignPattern.Service.Interface;

namespace DesignPattern.Service.Notification.Phone;

public class RobiNotificationService: INotificationService
{
    public Task<string> SentNotificationAsync()
    {
        return Task.FromResult("Successfully sent notification to Robi Service");
    }
}