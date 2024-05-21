namespace wyzwanie21Tests;

public class Tests
{
    [Test]
    public void WhenEmployeeGetGrades_ShouldReturnMaxGrade()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak");
        employee.AddGrade(5);
        employee.AddGrade(6);
        employee.AddGrade(-7);

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual(6, statistics.Max);
    }

    [Test]
    public void WhenEmployeeGetGrades_ShouldReturnMin()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak");
        employee.AddGrade(-2);
        employee.AddGrade(-10);
        employee.AddGrade(2);

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual(-10, statistics.Min);
    }

    [Test]
    public void WhenEmployeeGetGrades_ShouldReturnAverageOfGrades()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak");
        employee.AddGrade(5);
        employee.AddGrade(-3);
        employee.AddGrade(4);

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual(2, statistics.Average);
    }
}