using System.Diagnostics.Metrics;

public class EmployeeInFile : EmployeeBase
{

    private const string fileName = "grades.txt";
    public EmployeeInFile(string name, string surname) : base(name, surname)
    {
    }

    public override void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            throw new Exception("String is not float");
        }
    }

    public override void AddGrade(int grade)
    {
        float result = grade;
        this.AddGrade(result);
    }

    public override void AddGrade(long grade)
    {
        var result = (float)grade;
        this.AddGrade(result);
    }

    public override void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
        using (var writer = File.AppendText(fileName))
        {
            writer.WriteLine(grade);
        }
        }
        else
        {
            throw new Exception("String is not float");
        }
    }

    public override void AddGrade(double grade)
    {
        var result = (float)grade;
        this.AddGrade(result);
    }

    public override void AddGrade(char grade)
    {
        switch (grade)
        {
            case 'A':
            case 'a':
                this.AddGrade(100);
                break;
            case 'B':
            case 'b':
                this.AddGrade(80);
                break;
            case 'C':
            case 'c':
                this.AddGrade(60);
                break;
            case 'D':
            case 'd':
                this.AddGrade(40);
                break;
            case 'E':
            case 'e':
                this.AddGrade(20);
                break;
            default:
                throw new Exception("Wrong Letter");
        }
    }

    public override float FinalScore()
    {
        throw new NotImplementedException();
    }

    public override Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        var counter = 0;

        if (File.Exists(fileName))
        {
            using (var reader = File.OpenText(fileName))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var grade = float.Parse(line);
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                    counter++;

                    line = reader.ReadLine();
                }
            }
            statistics.Average /= counter;


            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
        }
        return statistics;
    }
}
