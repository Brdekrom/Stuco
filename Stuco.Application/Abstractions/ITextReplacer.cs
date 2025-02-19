namespace Stuco.Application.Abstractions;

public interface ITextReplacer
{
    public Task ReplaceText(object documentModel);
}