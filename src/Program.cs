
Employee employee1 = new Employee("Anna","Kibol","32");
Employee employee2 = new Employee("Jan","Zaraza","20");
Employee employee3 = new Employee("Ola","Molenda","56");

employee1.AddGrade(10);
employee1.AddGrade(10);
employee1.AddGrade(8);
employee1.AddGrade(10);
employee1.AddGrade(2);

employee2.AddGrade(3);
employee2.AddGrade(10);
employee2.AddGrade(9);
employee2.AddGrade(7);
employee2.AddGrade(2);

employee3.AddGrade(1);
employee3.AddGrade(1);
employee3.AddGrade(3);
employee3.AddGrade(5);
employee3.AddGrade(10);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

var MaxScore = -1;
Employee BestEmployee = null;

foreach (var employee in employees)
{
    if (employee.FinalScore() > MaxScore)
    {
        MaxScore = employee.FinalScore();
        BestEmployee = employee;
    }

}

Console.WriteLine("Najlepszy wynik uzyskał/a " + BestEmployee.Name + " " + BestEmployee.Surname + ", lat " + BestEmployee.Age + ". Zdobył on az "+ MaxScore + " punktów!!!");