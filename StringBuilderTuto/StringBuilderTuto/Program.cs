using System.Diagnostics;
using System.Text;

Console.WriteLine("\nString vs StringBuilder in C#! \n");

int numberOfIterations = 200000;

RunStringOptions();
RunStringBuilderOptions();

void RunStringBuilderOptions()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    StringBuilder numbers = new StringBuilder("1");
    for (int i = 0; i <= numberOfIterations; i++)
    {
        numbers.Append($", {i + 2}");
        if (i % 50000 == 0)
        {
            Console.WriteLine($"StringBuilderOptions result at iteration {i}: {numbers.ToString(0, Math.Min(numbers.Length, 50))}...");
        }
    }

    stopwatch.Stop();
    Console.WriteLine($"\nTime taken for StringBuilderOptions: {stopwatch.ElapsedMilliseconds} ms \n");
}
void RunStringOptions()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    string numbers = "1";
    for (int i = 0; i <= numberOfIterations; i++)
    {
        numbers += $", {i + 2}";
        if (i % 50000 == 0)
        {
            Console.WriteLine($"StringOptions result at iteration {i}: {numbers.Substring(0, Math.Min(numbers.Length, 50))}...");
        }
    }

    stopwatch.Stop();
    Console.WriteLine($"\nTime taken for StringOptions: {stopwatch.ElapsedMilliseconds} ms \n");
}



