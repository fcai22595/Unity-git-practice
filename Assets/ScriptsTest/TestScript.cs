

using NUnit.Framework;
using NUnit.Framework.Internal;


public class TestScript
{
  [Test(Description = "測試兩個數字相加")]
  [TestCase(2, 2, 4)]
  [TestCase(-1, 3, 2)]
  [TestCase(-1, -3, -4)]
  
  public void Add_Tow_Number(int a , int b , int expected)
  {
    TimeConventer timeConventer = new TimeConventer();

    int result = timeConventer.Add(a, b);
    
    Assert.AreEqual(expected,actual:result);

  }
}
