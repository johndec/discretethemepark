public record Attraction
{
    public string Name { get; init; }

    // Every attraction has a location associated with it
    public Location myLocation { get; init; }

    public List<Guest> guestsHere { get; set; } = new List<Guest>();

    public Attraction(string myName)
    {
        Name = myName;
        myLocation = new Location(Name);
        myLocation.attractionsHere.Add(this);
    }
}
