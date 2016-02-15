using Xunit;
using PingPongProgram;

namespace PingPongProgram
{
  public class PingPongTest
  {
    [Fact]
    public void IsPingPong_IsNumber_true()
    {
      PingPong newPingPong = new PingPong();
      Assert.Equal(true, newPingPong.IsNumber(2));
    }
  }
}
