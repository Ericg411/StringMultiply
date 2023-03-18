namespace StringMultiply.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        string num1 = "2";
        string num2 = "3";  
        string result = _test.Multiply(num1, num2);
        Assert.AreEqual("6", result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        string num1 = "123";
        string num2 = "456";  
        string result = _test.Multiply(num1, num2);
        Assert.AreEqual("56088", result);
    } 
    
    [TestMethod]
    public void TestMethod3()
    {
        string num1 = "123456789";
        string num2 = "987654321";  
        string result = _test.Multiply(num1, num2);
        Assert.AreEqual("121932631112635269", result);
    }
}