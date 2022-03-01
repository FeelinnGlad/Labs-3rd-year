using System.Text.RegularExpressions;

namespace Task1;

internal static class Program2
{
    internal static void Task2()
    {        
        const string baseText = "У меня 10 долларов, 3 яблокa, 5 апельсинов.";
        Console.WriteLine("Original text:\n" + baseText);
        var output = Regex.Replace(baseText, @"\d+", (value) => Convert.ToString(int.Parse(value.Value), 2) );
        Console.WriteLine("New text:\n" + output);
    }
}
