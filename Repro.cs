using NUnit.Framework;

namespace Repro
{
  public class TestClass
  {
    [Test]
    public void Test()
    {
      var x = 1;
      Assert.True(2 * x == 2);
    }
  }
}
