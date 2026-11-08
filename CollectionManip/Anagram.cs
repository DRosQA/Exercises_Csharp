using static Exercises_CSharp.CollectionManip.ListHelpers;
namespace Exercises_CSharp.CollectionManip;

static class Anagram
{
    private static bool IsAnagram(List<string> wordsList)
    { 
        //check if all strings are equal to first one after sorting
        return wordsList.All(x => x.Order().SequenceEqual(wordsList[0].Order()));
    }

    public static bool CheckIfAnagram(List<string> wordsList)
    {
        LogList(wordsList);
        Console.WriteLine("Checking list of words for anagrams.");
        if (wordsList.Count <= 1)
        {
            Console.WriteLine("Words list must have at least 2 elements.\n");
            return false;
        }
        if (!wordsList.All(s => s.Length == wordsList[0].Length))
        {
            Console.WriteLine(
                "Not all words in the list are the same lenght, thus can't be all anagrams of each other.\n"
            );
            return false;
        }
        bool allAnagrams = IsAnagram(wordsList);
        string message = allAnagrams
            ? "All words in list are anagrams of each other."
            : "Not all words in list are anagrams of each other.";
        Console.WriteLine(message + "\n");
        return allAnagrams;
    }
}
