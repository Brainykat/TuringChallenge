namespace TuringChallenge.Test
{
  public class QuestionOne
  {
    [Theory()]
    [InlineData(new string[] { "5", "2", "c", "d", "+" },30)]
    [InlineData(new string[] { "5", "-2", "4", "c", "d", "9", "+", "+" }, 27)]
    [InlineData(new string[] { "1" }, 1)]
    //[InlineData(new string[] { "5", "2", "c", "d", "+" }, 30)]
    //[InlineData(new string[] { "5", "2", "c", "d", "+" }, 30)]
    public void CalPoints_Theory(string[] ops, int expected)
    {
      //Arrange
      var t = new test();
      //Act 
      var result = t.CalPoints(ops);
      //Assert
      Assert.Equal(expected, result);

    }
  }
}