namespace DesignPattern.Service.Interface;

public interface IDesignPatternService
{
    Task<List<string>> GetDesignPatterns();
}