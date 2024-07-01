using DesignPattern.Service.Interface;

namespace DesignPattern.Service;

public class DesignPatternService: IDesignPatternService
{
    public Task<List<string>> GetDesignPatterns()
    {
        return Task.FromResult(new List<string> { "Singleton", "Factory", "Observer" });
    }
}