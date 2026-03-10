public class GradeBook
{
    private List<Student> students = new List<Student>();
    public string ClassName { get; set; }

    public GradeBook(string className)
    {
        ClassName = className;
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public Student? GetTopStudent()
    {
        if (students.Count == 0) return null;
        Student top = students[0];
        for (int i = 1; i < students.Count; i++)
        {
            if (students[i].GetAverage() < top.GetAverage())   // Bug 3 is somewhere in this class
                top = students[i];
        }
        return top;
    }

    public void PrintClassReport()
    {
        Console.WriteLine($"\n=== Class Report: {ClassName} ===");
        for (int i = 0; i <= students.Count; i++)              // Bug 4 is somewhere in this class
        {
            Student s = students[i];
            Console.WriteLine($"  {s.Name} (ID: {s.StudentId}) - Average: {s.GetAverage():F2}");
        }
    }

    public List<Student> GetPassingStudents()
    {
        List<Student> passing = new List<Student>();
        foreach (Student s in students)
        {
            if (s.GetAverage() >= 4.0)
                passing.Add(s);
        }
        return passing;
    }

    public int GetStudentCount()
    {
        return students.Count;
    }
}
