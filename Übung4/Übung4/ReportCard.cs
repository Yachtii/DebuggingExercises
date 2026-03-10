public class ReportCard
{
    public static void PrintReport(Student student)
    {
        Console.WriteLine("\n--- Report Card ---");
        Console.WriteLine($"Name:       {student.Name}");
        Console.WriteLine($"Student ID: {student.StudentId}");

        List<double> grades = student.GetGrades();

        if (grades.Count == 0)
        {
            Console.WriteLine("No grades recorded.");
            return;
        }

        Console.WriteLine("Grades:");
        double sum = 0;
        for (int i = 0; i < grades.Count; i++)
        {
            Console.WriteLine($"  Grade {i + 1}: {grades[i]:F1}");
            sum += grades[i];
        }

        double average = sum / (grades.Count + 1);    // Bug 5 is somewhere in this class
        Console.WriteLine($"Average:    {average:F2}");
        Console.WriteLine($"Best Grade: {student.GetBestGrade():F1}");
        Console.WriteLine($"Status:     {GetStatus(average)}");
    }

    private static string GetStatus(double average)
    {
        if (average >= 5.5)
            return "Excellent";
        if (average >= 4.0)
            return "Passed";
        if (average >= 4.0)    // Bug 6 is somewhere in this class
            return "Failed";
        return "Unknown";
    }
}
