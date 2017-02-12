namespace efexample
{
    public interface IDocumentElement
    {
        IDocumentVisitor Accept(IDocumentVisitor visitor);
    }
}