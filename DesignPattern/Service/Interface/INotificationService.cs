namespace DesignPattern.Service.Interface;

public interface INotificationService
{
    Task<string> SentNotificationAsync();
}