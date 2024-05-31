
Employee employee1 = new Employee("Anna","Kibol");

employee1.AddGrade(3);
employee1.AddGrade(4);
employee1.AddGrade("20");
var statistics1 = employee1.GetStatistics();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithDoWhile();
var statistics4 = employee1.GetStatisticsWithWhile();

Console.WriteLine("ForEach:");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");

Console.WriteLine("For:");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}");

Console.WriteLine("Do While:");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}");

Console.WriteLine("While:");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Min: {statistics4.Min}");



