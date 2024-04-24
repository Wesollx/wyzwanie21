
Employee e1 = new Employee("Anna","Kibol","32");
Employee e2 = new Employee("Jan","Zaraza","20");
Employee e3 = new Employee("Ola","Molenda","56");

e1.AddGrade(10);
e1.AddGrade(10);
e1.AddGrade(8);
e1.AddGrade(10);
e1.AddGrade(2);

e2.AddGrade(3);
e2.AddGrade(10);
e2.AddGrade(9);
e2.AddGrade(7);
e2.AddGrade(2);

e3.AddGrade(1);
e3.AddGrade(1);
e3.AddGrade(3);
e3.AddGrade(5);
e3.AddGrade(10);

List<Employee> employees = new List<Employee>()
{
    e1, e2, e3
};

var MaxScore = -1;
Employee BestEmployee = null;

foreach (var e in employees)
{
    if (e.FinalScore() > MaxScore)
    {
        MaxScore = e.FinalScore();
        BestEmployee = e;
    }

}

Console.WriteLine("Najlepszy wynik uzyskał/a " + BestEmployee.Name + " " + BestEmployee.Surname + ", lat " + BestEmployee.Age + ". Zdobył on az "+ MaxScore + " punktów!!!");