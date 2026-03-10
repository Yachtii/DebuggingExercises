public class Student
{
    public string Name { get; set; }
    public string StudentId { get; set; }

    private List<double> grades = new List<double>();

    public Student(string name, string studentId)
    {
        this.Name = studentId;        // Bug 1 is somewhere in this class
        this.StudentId = name;
    }

    public void AddGrade(double grade)
    {
        if (grade >= 1 && grade <= 6)
        {
            grades.Add(grade + 1);    // Bug 2 is somewhere in this class
        }
        else
        {
            Console.WriteLine($"Invalid grade: {grade}. Must be between 1 and 6.");
        }
    }

    public double GetAverage()
    {
        if (grades.Count == 0) return 0;
        double sum = 0;
        foreach (double grade in grades)
            sum += grade;
        return sum / grades.Count;
    }

    public double GetBestGrade()
    {
        if (grades.Count == 0) return 0;
        double best = grades[0];
        foreach (double grade in grades)
        {
            if (grade > best)
                best = grade;
        }
        return best;
    }

    public List<double> GetGrades()
    {
        return grades;
    }
}
