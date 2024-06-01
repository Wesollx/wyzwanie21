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
        employee.AddGrade(70);

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual(70, statistics.Max);
    }

    [Test]
    public void WhenEmployeeGetGrades_ShouldReturnMin()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak");
        employee.AddGrade(12);
        employee.AddGrade(10);
        employee.AddGrade(2);

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual(2, statistics.Min);
    }

    [Test]
    public void WhenEmployeeGetGrades_ShouldReturnAverageOfGrades()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak");
        employee.AddGrade(5);
        employee.AddGrade(3);
        employee.AddGrade(4);

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual(4, statistics.Average);
    }

    [Test]
    public void WhenEmployeeGetGrades_ShouldReturnAverageLetter()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak");
        employee.AddGrade(30);
        employee.AddGrade(70);
        employee.AddGrade(50);

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual('C', statistics.AverageLetter);
    }

    [Test]
    public void WhenEmployeeGetGradesAsLetters_ShouldReturnAverage()
    {
        //arrange
        Employee employee = new Employee("Aleks","Kozak");
        employee.AddGrade('A');
        employee.AddGrade('b');
        employee.AddGrade('C');

        //act
        var statistics = employee.GetStatistics();
        
        //assert
        Assert.AreEqual(80, statistics.Average);
    }


}