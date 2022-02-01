public record Guest(string Name)
{
    public Guid id { get; init; } = new Guid();
    public Guest() : this(String.Empty)
    {
    }
}
