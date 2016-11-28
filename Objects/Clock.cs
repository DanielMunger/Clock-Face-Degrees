using System;

namespace ClockObject
{
  public class Clock
  {
    private int _minutes;
    private int _hours;
    private int _minuteDegrees;
    private int _hourDegrees;
    private int _degreeDifference;

    public Clock(string Time)
    {
      _minutes = GetMinutes(Time);
      _hours = GetHours(Time);
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
    public int HoursToDegrees()
    {
      _hourDegrees = _hours * 30;
      return _hourDegrees;
    }
    public int MinutesToDegrees()
    {
      _minuteDegrees = _minutes * 6;
      return _minuteDegrees;
    }
    public int DegreeDifference()
    {
      _degreeDifference = Math.Abs(_minuteDegrees - _hourDegrees);
      return _degreeDifference;
    }
  }
}
