using Nancy;
using System;
using System.Collections.Generic;
using ClockObject;

namespace ClockFace //replace with your desired namespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/submit"] = _ => {
        string TestTime = Request.Form["UserInput"];
        Clock myClock = new Clock(TestTime);
        myClock.HoursToDegrees();
        myClock.MinutesToDegrees();
        return View["index.cshtml", myClock.DegreeDifference()];
      };
    }
  }
}
