namespace wyzwanie21Tests;

public class TypeTests
{

    [Test]
    public void GetEmployeeShouldReturnDifferentObjects()
    {
        //arrange
        var employee1 = GetEmployee("Adam","Zachwieja","20");
        var employee2 = GetEmployee("Adam","Zachwieja","20");

        //act
        
        //assert
        Assert.AreNotEqual(employee1, employee2);
    }

    [Test]
    public void TwoIntShouldBeEqual()
    {
        //arrange
       int a = 1;
       int b = 1;

        //act
        
        //assert
        Assert.AreEqual(a, b);
    }

        [Test]
    public void TwoFloatShouldBeEqual()
    {
        //arrange
       float a = 4.5f;
       float b = 4.5f;

        //act
        
        //assert
        Assert.AreEqual(a, b);
    }

        [Test]
    public void TwoStringShouldBeEqual()
    {
        //arrange
       string a = "koczkodan";
       string b = "koczkodan";

        //act
        
        //assert
        Assert.AreEqual(a, b);
    }



    
    private Employee GetEmployee(string name, string surname, string age)
    {
        return new Employee(name, surname, age);
    }
}