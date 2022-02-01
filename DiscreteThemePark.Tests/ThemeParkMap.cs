using Xunit;

namespace DiscreteThemePark.Tests
{
    public class ThemeParkMap_Consistent
    {
        [Fact]
        public void ThemeParkMap_ShouldBeConsistent()
        {
            var m = new ThemeParkMap();

            Assert.True(m.entrance.attractionsHere.Count == 0);
            Assert.True(m.entrance.neighbors.Count == 1);
            Assert.True(m.entrance.neighbors[0].Name == "Hub");
            Assert.True(m.entrance.neighbors[0].neighbors[0].attractionsHere.Count == 1);
        }

        [Fact]
        public void ThemeParkMap_Deposit1000Guests()
        {
            var m = new ThemeParkMap();

            for (int i=0; i<1000; i++)
            {
                m.entrance.guestsHere.Add(new Guest());
            }

            Assert.True(m.entrance.guestsHere.Count == 1000);
        }

        [Fact]
        public void ThemeParkMap_FindsAllLocations()
        {
            var m = new ThemeParkMap();

            Assert.Equal(7, m.AllLocations().Count);
        }

        public void ThemeParkMap_FindsAllGuests()
        {
            var m = new ThemeParkMap();
            
            for (int i=0; i<1000; i++)
            {
                m.entrance.guestsHere.Add(new Guest());
            }
            for (int i=0; i<500; i++)
            {
                m.entrance.neighbors[0].guestsHere.Add(new Guest());
            }

            Assert.Equal(1500, m.AllGuests().Count);
        }
    }
}