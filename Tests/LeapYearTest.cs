using Xunit;
using LeapYears;

namespace LeapYears
{
  public class LeapYearTest
  {
    [Fact]
    public void IfLeapYear_YearDivisibleByFour_true()
    {
      LeapYear newLeapYear = new LeapYear();
      Assert.Equal(true, newLeapYear.IfLeapYear(4));
    }
  }
}
