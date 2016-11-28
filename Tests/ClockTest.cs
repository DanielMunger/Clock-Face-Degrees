using Xunit;
using ClockObject;

namespace ClockTest
{
  public class Test
  {
    string testTime = "09:47";
    [Fact]
    public void Test1_GetHours_ReturnHours()
    {
      Clock myClock = new Clock();
      Assert.Equal(true, myClock.GetHours(testTime) == 9);
    }
    [Fact]
    public void Test1_GetMinutes_ReturnMinutes()
    {
      Clock myClock = new Clock();
      Assert.Equal(true, myClock.GetMinutes(testTime) == 47);
    }
  }
}
