
public class Employee
{
    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public string Name { get; }
    public string Surname { get; }

    private List<float> grades = new List<float>();

    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Grade out of range");
        }
    }
    
    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            Console.WriteLine("String is not float");
        }
    }

    public void AddGrade(long grade)
    {
        var result = (float)grade;
        this.AddGrade(result);
    }

    public void AddGrade(double grade)
    {
       var result = (float)grade;
       this.AddGrade(result);
    }

    public float FinalScore()
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
