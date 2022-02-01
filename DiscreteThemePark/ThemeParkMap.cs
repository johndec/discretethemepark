public class ThemeParkMap
{
    public Location entrance;

    public ThemeParkMap()
    {
            var attractions = new[] { new Attraction("Jungle Cruise"), new Attraction("Big Thunder"), new Attraction("Small World"),
                new Attraction("Autopia"), new Attraction("Space Mountain") };
            var hub = new Location("Hub");
            var ent = new Location("Entrance");

            foreach (var att in attractions)
            {
                att.myLocation.neighbors.Add(hub);
                hub.neighbors.Add(att.myLocation);
            }
            ent.neighbors.Add(hub);
            hub.neighbors.Add(ent);

            entrance = ent;
    }

    public HashSet<Location> AllLocations()
    {
        var allLocs = new HashSet<Location>();

        allLocs.Add(entrance);
        for (int i=0; i<10; i++)
        {
            foreach (var loc in allLocs.ToArray())
            {
                foreach (var neigh in loc.neighbors)
                {
                    allLocs.Add(neigh);
                }
            }
        }

        return allLocs;
    }

    public HashSet<Guest> AllGuests()
    {
        var allLocs = AllLocations();
        var allGuests = new HashSet<Guest>();

        foreach (var loc in allLocs)
        {
            allGuests.UnionWith(loc.guestsHere);
            foreach (var att in loc.attractionsHere)
            {
                allGuests.UnionWith(att.guestsHere);
            }
        }

        return allGuests;
    }
}