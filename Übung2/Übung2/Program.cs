// =============================================================
// Debugging Exercise – Übung 2
// =============================================================
// This program calculates statistics for a list of student scores.
// Run the program and compare the output with the expected values below.
// Use the debugger (breakpoints + step-over / step-into) to find
// and fix all 4 bugs.
//
// Expected output:
//   Average Score:    84.7
//   Highest Score:    95
//   Students passing: 7
//   Class is passing: True
// =============================================================

int[] scores = { 85, 92, 78, 90, 88, 76, 95, 83, 71, 89 };

Console.WriteLine("=== Student Score Statistics ===");
Console.WriteLine($"Scores: {string.Join(", ", scores)}");
Console.WriteLine();

double average = CalculateAverage(scores);
Console.WriteLine($"Average Score:    {average}");

int highest = FindHighestScore(scores);
Console.WriteLine($"Highest Score:    {highest}");

int passing = CountPassingStudents(scores, 80);
Console.WriteLine($"Students passing: {passing}");

bool isPassing = IsClassPassing(average, 70.0);
Console.WriteLine($"Class is passing: {isPassing}");

// -----------------------------------------------------------------
// Bug 1 – CalculateAverage
// The sum is correct, but the divisor is wrong.
// Set a breakpoint on the return statement and inspect 'sum' and
// 'numbers.Length' to find the mistake.
// -----------------------------------------------------------------
static double CalculateAverage(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return (double)sum / (numbers.Length + 1); // Bug 1
}

// -----------------------------------------------------------------
// Bug 2 – FindHighestScore
// The method is supposed to find the highest score,
// but it returns the wrong value.
// Step through the loop and watch what happens to 'highest'.
// -----------------------------------------------------------------
static int FindHighestScore(int[] numbers)
{
    int highest = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < highest) // Bug 2
        {
            highest = numbers[i];
        }
    }
    return highest;
}

// -----------------------------------------------------------------
// Bug 3 – CountPassingStudents
// The method counts students with a score >= passingScore.
// One student is always skipped.
// Add a breakpoint at the loop and check which index it starts at.
// -----------------------------------------------------------------
static int CountPassingStudents(int[] numbers, int passingScore)
{
    int count = 0;
    for (int i = 1; i < numbers.Length; i++) // Bug 3
    {
        if (numbers[i] >= passingScore)
        {
            count++;
        }
    }
    return count;
}

// -----------------------------------------------------------------
// Bug 4 – IsClassPassing
// The method should return true when the average is above the
// minimum, but it always returns the opposite.
// Inspect the return value in the debugger.
// -----------------------------------------------------------------
static bool IsClassPassing(double average, double minimumAverage)
{
    return average <= minimumAverage; // Bug 4
}
