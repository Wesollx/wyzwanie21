
Employee employee1 = new Employee("Anna","Kibol");

employee1.AddGrade(3);
employee1.AddGrade(4);
employee1.AddGrade(-1);
var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

