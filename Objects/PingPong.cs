namespace PingPongProgram
{
  public class PingPong
  {
    public bool IsNumber(int number)
    {
      if (number % 15 ==0)
      {
        return true;
      }
      if (number % 3 == 0)
      {
        return true;
      }
      else if (number % 5 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
