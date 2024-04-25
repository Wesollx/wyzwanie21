namespace wyzwanie21Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        int var1 = 1;
        int var2 = 2;

        int result = var1 + var2;

        Assert.AreEqual(3,result);
    }
}