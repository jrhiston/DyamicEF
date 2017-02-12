namespace efexample
{
    public interface IDataElement<T> where T : struct
    {
        T Value { get; }
    }
}