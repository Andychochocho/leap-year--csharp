using Nancy;
using PingPongProgram.Objects;

namespace PingPongProgram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/PPform"] = _ => {
        PingPong newPingPong = new PingPong();

        string newChangedValues = newPingPong.IsNumber(Request.Form["userInput"]);
        return View["results.cshtml", newChangedValues];
      };
    }
  }
}
