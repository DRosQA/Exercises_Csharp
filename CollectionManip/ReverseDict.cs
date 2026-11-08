namespace Exercises_CSharp.CollectionManip;

static class ReverseDict
{
    private static Dictionary<string, List<string>> GetReversedDict(
        Dictionary<string, string> incoming
    )
    {
        Dictionary<string, List<string>> result = [];
        foreach (KeyValuePair<string, string> item in incoming)
        {
            result[item.Value] = result.TryGetValue(item.Value, out _) ? result[item.Value] : [];
            result[item.Value].Add(item.Key);
        }
        return result;
    }

    public static Dictionary<string, List<string>>? ReverseAndGroupDictionary(
        Dictionary<string, string> incomingDictionary
    )
    {
        ListHelpers.LogDictionary(incomingDictionary);

        if (incomingDictionary.Count == 0)
        {
            Console.WriteLine("Dictionary must not be empty.\n");
            return null;
        }
        Dictionary<string, List<string>> resultDict = GetReversedDict(incomingDictionary);
        Console.WriteLine("Dictionary reversed.");
        ListHelpers.LogDictionary(resultDict);

        return resultDict;
    }
}
