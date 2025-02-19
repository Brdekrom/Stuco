namespace Stuco.Application.Abstractions;

public interface IDocumentGenerator
{
     public object GenerateWord();
     public object ConvertToPdf();
}