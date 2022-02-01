public record Location(string Name)
{
    public List<Attraction> attractionsHere { set; get; } = new List<Attraction>();

    public List<Location> neighbors { get; set; } = new List<Location>();

    public List<Guest> guestsHere { get; set; } = new List<Guest>();
}
