namespace TuringChallenge.Test
{
  public class UnitTest1
  {
    [Theory()]
    [InlineData("{}(){[]}",true)]
    [InlineData("[]",true)]
    [InlineData("([)]", false)]
    [InlineData("[[[]][", false)]
    [InlineData("[[[]]]", true)]
    public void CalPoints_Theory(string s, bool expected)
    {
      //Arrange
      var t = new test();
      //Act 
      var result = t.Valid(s);
      //Assert
      Assert.Equal(expected, result);

    }
  }
}