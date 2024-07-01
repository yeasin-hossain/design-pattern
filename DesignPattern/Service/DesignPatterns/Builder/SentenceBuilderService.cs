using System.Text;

namespace DesignPattern.Service.DesignPatterns.Builder;

public class SentenceBuilderService
{
    private StringBuilder sentence = new StringBuilder();
    
    public SentenceBuilderService(string name)
    {
        sentence.Append(string.Join(" ", name) + " ");
    }

    public SentenceBuilderService AddSubject(string subject)
    {
        sentence.Append(string.Join(" ", subject) + " ");
        return this;
    }

    public SentenceBuilderService AddVerb(string verb)
    {
        sentence.Append(string.Join(" ", verb) + " ");
        return this;
    }

    public SentenceBuilderService AddObject(string obj)
    {
        sentence.Append(string.Join(" ", obj) + " ");
        return this;
    }

    public SentenceBuilderService AddAdjective(string adjective)
    {
        sentence.Append(string.Join(" ", adjective) + " ");
        return this;
    }

    public SentenceBuilderService AddAdverb(string adverb)
    {
        sentence.Append(string.Join(" ", adverb) + " ");
        return this;
    }

    public SentenceBuilderService AddOther(string other)
    {
        sentence.Append(string.Join(" ", other) + " ");
        return this;
    }

    public SentenceBuilderService NewLine()
    {
        sentence.AppendLine();
        return this;
    }
    
    public string Build()
    { 
        return sentence.ToString() + ".";
    }
}