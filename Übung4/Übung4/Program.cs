// ============================================================
//  Debugging Exercise – Student Grade Tracker
// ============================================================
//
//  This program manages students and their grades (scale 1–6).
//  It should produce the following output when all bugs are fixed:
//
//  --- Report Card ---
//  Name:       Alice Meier
//  Student ID: S001
//  Grades:
//    Grade 1: 5.5
//    Grade 2: 4.0
//    Grade 3: 5.0
//  Average:    4.83
//  Best Grade: 5.5
//  Status:     Passed
//
//  --- Report Card ---
//  Name:       Bob Müller
//  Student ID: S002
//  Grades:
//    Grade 1: 3.5
//    Grade 2: 4.5
//  Average:    4.00
//  Best Grade: 4.5
//  Status:     Passed
//
//  --- Report Card ---
//  Name:       Carol Schmidt
//  Student ID: S003
//  Grades:
//    Grade 1: 2.5
//    Grade 2: 3.0
//    Grade 3: 2.0
//  Average:    2.50
//  Best Grade: 3.0
//  Status:     Failed
//
//  === Class Report: Software Development Year 1 ===
//    Alice Meier (ID: S001) - Average: 4.83
//    Bob Müller (ID: S002) - Average: 4.00
//    Carol Schmidt (ID: S003) - Average: 2.50
//
//  Top Student: Alice Meier with average 4.83
//
//  Passing Students (2/3):
//    - Alice Meier
//    - Bob Müller
//
//  There are 6 bugs hidden across Student.cs, GradeBook.cs and ReportCard.cs.
//  Each file contains exactly 2 bugs. Find and fix all of them!
// ============================================================

GradeBook gradeBook = new GradeBook("Software Development Year 1");

Student alice = new Student("Alice Meier", "S001");
Student bob   = new Student("Bob Müller",  "S002");
Student carol = new Student("Carol Schmidt", "S003");

alice.AddGrade(5.5);
alice.AddGrade(4.0);
alice.AddGrade(5.0);

bob.AddGrade(3.5);
bob.AddGrade(4.5);

carol.AddGrade(2.5);
carol.AddGrade(3.0);
carol.AddGrade(2.0);

gradeBook.AddStudent(alice);
gradeBook.AddStudent(bob);
gradeBook.AddStudent(carol);

ReportCard.PrintReport(alice);
ReportCard.PrintReport(bob);
ReportCard.PrintReport(carol);

gradeBook.PrintClassReport();

Student? top = gradeBook.GetTopStudent();
if (top != null)
    Console.WriteLine($"\nTop Student: {top.Name} with average {top.GetAverage():F2}");

List<Student> passing = gradeBook.GetPassingStudents();
Console.WriteLine($"\nPassing Students ({passing.Count}/{gradeBook.GetStudentCount()}):");
foreach (Student s in passing)
    Console.WriteLine($"  - {s.Name}");
