namespace Task1;

internal static class Program1
{
    private static void Task1()
    {        
        var baseText = "У меня 10 долларов, 3 яблокa, 5 апельсинов.";
        Console.WriteLine("Original text:\n" + baseText);

        var start = 0;
        var length = 0;
        for (var i = 0; i < baseText.Length; i++)
        {
            if (char.IsDigit(baseText[i]))
            {
                if (length == 0)
                {
                    start = i;
                    length++;
                }
                else length++;
            } else if (length != 0)
            {
                var num = baseText.Substring(start, length);
                baseText = baseText.Remove(start, length).Insert(start, Convert.ToString(int.Parse(num), 2));
                length = 0;
            }
        }
        Console.WriteLine("New text:\n" + baseText);
    }
}
