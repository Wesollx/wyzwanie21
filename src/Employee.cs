
public class Employee
{
    public Employee(string name, string surname, string age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public string Name { get; }
    public string Surname { get; }
    public string Age { get; }

    private List<int> grade = new List<int>();

    public void AddGrade(int grade)
    {
        if (grade > -11 && grade < 11)
        {
            this.grade.Add(grade);
        }
        else
        {
            Console.WriteLine("Wpisz ocenę z zakresu od -10 do 10!");
        }
    }

    public int FinalScore()
    {
        return grade.Sum();
    }


}
