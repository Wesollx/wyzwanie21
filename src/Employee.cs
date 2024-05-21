
public class Employee
{
    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public string Name { get; }
    public string Surname { get; }

    private List<int> grades = new List<int>();

    public void AddGrade(int grade)
    {
        if (grade > -11 && grade < 11)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Wpisz ocenę z zakresu od -10 do 10!");
        }
    }

    public int FinalScore()
    {
        return grades.Sum();
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.grades.Count;
        return statistics;
    }


}
