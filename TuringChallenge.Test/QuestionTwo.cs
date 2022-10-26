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

    [Theory()]
    [InlineData("ab-cd", "dc-ba")]
    [InlineData("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
    [InlineData("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
    public void StringReverse_Theory(string s, string expected)
    {
      //Arrange
      var t = new test();
      //Act 
      var result = t.Reverse(s);
      //Assert
      Assert.Equal(expected, result);

    }
  }
}