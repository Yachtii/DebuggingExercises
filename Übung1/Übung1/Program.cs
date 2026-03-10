class Übung1
{
    static void Main()
    {
        // Goal: Calculate the sum, average, highest and lowest temperature
        // Expected results for this dataset:
        //   Sum     : 243
        //   Average : 27.0
        //   Highest : 35
        //   Lowest  : 18

        int[] temperatures = { 22, 35, 18, 30, 28, 25, 31, 19, 21, 14 };

        int sum = 0;
        int highest = temperatures[0];
        int lowest = temperatures[0];

        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            sum += temperatures[i];

            if (temperatures[i] > highest)
                highest = temperatures[i];

            if (temperatures[i] < lowest)
                lowest = temperatures[i];
        }

        double average = sum / temperatures.Length;

        Console.WriteLine($"Sum     : {sum}");
        Console.WriteLine($"Average : {average}");
        Console.WriteLine($"Highest : {highest}");
        Console.WriteLine($"Lowest  : {lowest}");
    }
}