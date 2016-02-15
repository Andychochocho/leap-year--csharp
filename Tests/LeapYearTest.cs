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
      Assert.Equal(true, newLeapYear.IfLeapYear(2012));
    }
    [Fact]
    public void IfLeapYear_YearNotDivisibleByFour_false()
    {
      LeapYear newLeapYear = new LeapYear();
      Assert.Equal(false, newLeapYear.IfLeapYear(2011));
    }
    [Fact]
    public void IfLeapYear_YearDivisibleByHundred_false()
    {
      LeapYear newLeapYear = new LeapYear();
      Assert.Equal(false, newLeapYear.IfLeapYear(1900));
    }
  }
}
