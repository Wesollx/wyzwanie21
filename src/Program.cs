
Console.WriteLine("Witam w programie do oceny pracowników");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Jan", "Dzban");
employee.AddGrade("3.5f");
//employee.AddGrade("55.5");
employee.AddGrade('B');
var statistics = employee.GetStatistics();

// while(true)
// {
//     Console.WriteLine("Podaj kolejną ocenę pracownika:");
//     var input = Console.ReadLine();
//     if (input == "q")
//     {
//         break;
//     }

//     try
//     {
//     employee.AddGrade(input);
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }

// var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");





