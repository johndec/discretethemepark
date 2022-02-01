using Xunit;

namespace DiscreteThemePark.Tests
{
    public class Guest_Name
    {
        [Fact]
        public void Guest_Name_ShouldBeSettable()
        {
            var myGuest = new Guest("Bob");

            Assert.True(myGuest.Name == "Bob");
        }
    }
}