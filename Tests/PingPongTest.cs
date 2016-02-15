using Xunit;
using PingPongProgram;

namespace PingPongProgram
{
  public class PingPongTest
  {
    [Fact]
    public void IsNumber_DivisibleByThree_true()
    {
      PingPong newPingPong = new PingPong();
      Assert.Equal(true, newPingPong.IsNumber(6));
    }
    [Fact]
    public void IsNumber_NotDivisibleByThreeFiveFifteen_false()
    {
      PingPong newPingPong = new PingPong();
      Assert.Equal(false, newPingPong.IsNumber(4));
    }
  }
}
