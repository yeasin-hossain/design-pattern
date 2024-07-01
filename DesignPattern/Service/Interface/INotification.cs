using DesignPattern.Enum;

namespace DesignPattern.Service.Interface;

public interface INotification
{
    Task<string> Sent(NotificationMediumEnum mediumType, NotificationEnum providerType);
}