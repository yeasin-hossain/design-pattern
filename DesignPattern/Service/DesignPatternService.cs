using DesignPattern.Service.Interface;

namespace DesignPattern.Service;

public class DesignPatternService: IDesignPatternService
{
    public Task<List<string>> GetDesignPatterns()
    {
        return Task.FromResult(new List<string> {
            // Creational Patterns
            "Singleton", "Factory Method", "Abstract Factory", "Builder", "Prototype",
            // Structural Patterns
            "Adapter", "Bridge", "Composite", "Decorator", "Facade", "Flyweight", "Proxy",
            // Behavioral Patterns
            "Chain of Responsibility", "Command", "Interpreter", "Iterator", "Mediator", 
            "Memento", "Observer", "State", "Strategy", "Template Method", "Visitor"
        });
    }
}