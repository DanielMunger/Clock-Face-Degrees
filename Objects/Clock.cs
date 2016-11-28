using System;

namespace ClockObject
{
  public class Clock
  {
    private int _minutes;
    private int _hours;
    private int _degrees;

    public Clock()
    {
      //Clock constructor here
    }

    public int GetHours(string time)
    {
      string Hours = string.Concat(time[0], time[1]);
      return int.Parse(Hours);
    }
    public int GetMinutes(string time)
    {
      string Minutes = string.Concat(time[3], time[4]);
      return int.Parse(Minutes);
    }
  }
}
