using Xunit;
using PingPongProgram.Objects;

namespace PingPongProgram
{
  public class PingPongTest
  {
    [Fact]
    public void IsNumber_NotDivisibleByThreeFiveFifteen_false()
    {
      PingPong newPingPong = new PingPong();
      string newChangedValues = newPingPong.IsNumber("2");
      Assert.Equal("12", newChangedValues);
    }
    [Fact]
    public void IsNumber_DivisibleByThree_true()
    {
      PingPong newPingPong = new PingPong();
      string newChangedValues = newPingPong.IsNumber("4");
      Assert.Equal("12ping4", newChangedValues);
    }

    [Fact]
    public void IsNumber_DivisibleByFive_true()
    {
      PingPong newPingPong = new PingPong();
      string newChangedValues = newPingPong.IsNumber("5");
      Assert.Equal("12ping4pong", newChangedValues);
    }

    [Fact]
    public void IsNumber_DivisibleByFifteen_true()
    {
      PingPong newPingPong = new PingPong();
      string newChangedValues = newPingPong.IsNumber("15");
      Assert.Equal("12ping4pongping78pingpong11ping1314ping-pong", newChangedValues);
    }
  }
}
