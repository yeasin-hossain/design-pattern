using DesignPattern.Service.Interface;

namespace DesignPattern.Service.Notification.Email;

public class GmailNotificationService: INotificationService
{
    public Task<string> SentNotificationAsync()
    {
        return Task.FromResult("Successfully sent notification to Gmail Service");
    }
}