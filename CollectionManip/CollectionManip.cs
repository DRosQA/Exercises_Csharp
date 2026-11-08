namespace Exercises_CSharp.CollectionManip;

static class ListHelpers
{
    public static void LogNumbers(int[] list)
    {
        Console.WriteLine($"List of numbers is: {string.Join(", ", list)}");
    }

    public static void LogDictionary(Dictionary<string, List<string>> dict)
    {
        foreach (var item in dict)
        {
            Console.Write(
                $"Dictionary key '{item.Key}' has the following items: {string.Join(", ", item.Value)}. "
            );
        }
        Console.WriteLine("\n");
    }

    public static void LogList(List<string> list)
    {
        Console.WriteLine($"List of words is: {string.Join(", ", list)}");
    }

    public static void LogDictionary(Dictionary<string, string> dict)
    {
        foreach (KeyValuePair<string, string> item in dict)
        {
            Console.Write($"Dictionary key '{item.Key}' has the following value: {item.Value}. ");
        }
        Console.WriteLine("\n");
    }
}
