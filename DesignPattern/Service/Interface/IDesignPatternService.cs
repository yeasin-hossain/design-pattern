namespace DesignPattern.Service.Interface;

public interface IDesignPatternService
{
    Task<List<string>> GetDesignPatterns();

    Task<string> SentNotification(DTO.Request.Notification notification);
}