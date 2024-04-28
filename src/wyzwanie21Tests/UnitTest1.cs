namespace wyzwanie21Tests;

public class Tests
{
    [Test]
    public void WhenEmployeeGetOnlyPositiveGrades_ShouldGetSum()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak","30");
        employee.AddGrade(5);
        employee.AddGrade(6);

        //act
        var result = employee.FinalScore();
        
        //assert
        Assert.AreEqual(11,result);
    }

    [Test]
    public void WhenEmployeeGetOnlyNegativeGrades_ShouldGetSum()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak","30");
        employee.AddGrade(-2);
        employee.AddGrade(-10);

        //act
        var result = employee.FinalScore();
        
        //assert
        Assert.AreEqual(-12,result);
    }

    [Test]
    public void WhenEmployeeGetDifferentGrades_ShouldGetSum()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak","30");
        employee.AddGrade(5);
        employee.AddGrade(-3);

        //act
        var result = employee.FinalScore();
        
        //assert
        Assert.AreEqual(2,result);
    }
}