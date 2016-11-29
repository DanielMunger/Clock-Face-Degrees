using Xunit;
using ClockObject;

namespace ClockTest
{
  public class Test
  {
    string testTime = "12:30";
    // [Fact]
    // public void Test1_GetHours_ReturnHours()
    // {
    //   Clock myClock = new Clock(testTime);
    //   Assert.Equal(true, myClock.GetHours(testTime) == 9);
    // }
    // [Fact]
    // public void Test1_GetMinutes_ReturnMinutes()
    // {
    //   Clock myClock = new Clock(testTime);
    //   Assert.Equal(true, myClock.GetMinutes(testTime) == 47);
    // }
    //
    // [Fact]
    // public void Test2_GetHourDegrees_Time()
    // {
    //   Clock myClock = new Clock(testTime);
    //   Assert.Equal(true, myClock.HoursToDegrees() == 270);
    // }
    // [Fact]
    // public void Test2_GetMinuteDegrees_Time()
    // {
    //   Clock myClock = new Clock(testTime);
    //   Assert.Equal(true, myClock.MinutesToDegrees() == 180);
    // }
    [Fact]
    public void Test3_GetDegreeDifference_Time()
    {
      Clock myClock = new Clock(testTime);
      myClock.HoursToDegrees();
      myClock.MinutesToDegrees();
      Assert.Equal(true, myClock.DegreeDifference() == 180);
    }
  }
}
