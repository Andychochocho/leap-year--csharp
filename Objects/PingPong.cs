using System;
namespace PingPongProgram.Objects
{
  public class PingPong
  {
    public string IsNumber(string userInput)
    {
      int userInputInt = int.Parse(userInput);
      string ChangedValues;
      string pingPongString = "";

      for (var i = 0; i < userInputInt ; i++)
      {
        if ((i + 1) % 15 == 0)
        {
          ChangedValues = "ping-pong";
        }
        else if ((i + 1) % 3 == 0)
        {
          ChangedValues = "ping";
        }
        else if ((i + 1) % 5 == 0)
        {
          ChangedValues = "pong";
        }
        else
        {
        int notChangedInt = i + 1;
        ChangedValues = notChangedInt.ToString();
        }
        pingPongString = pingPongString + ChangedValues + ", ";
      }
      return pingPongString;
    }
  }
}
