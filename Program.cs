using Exercises_CSharp.CollectionManip;
using Exercises_CSharp.StringManip;

namespace Exercises_Csharp;

internal static class Program
{
    public static void Main()
    {
        Console.WriteLine("Running exercises...\n");

        List<string> exampleWordsList = ["text", "xtte", "ttex"];

        Anagram.CheckIfAnagram(exampleWordsList);

        Dictionary<string, string> exampleDict = new()
        {
            { "test", "a" },
            { "text", "b" },
            { "something", "b" },
        };
        ReverseDict.ReverseAndGroupDictionary(exampleDict);

        int[] exampleNumbers = [1, 2, 5, 8];
        const int targetNumber = 20;
        TwoSum.FindTwoSum(exampleNumbers, targetNumber);

        int[] exampleNumbersMissing = [1, 2, 4, 5];
        MissingNumber.FindMissingNumber(exampleNumbersMissing);

        const string exampleString = "This is a test String.";
        ReverseString.StringReverse(exampleString);

        const string examplePalindrome = "    ";
        Palindrome.CheckIfPalindrome(examplePalindrome);

        ReverseArray.ArrayReverse(exampleNumbersMissing);

        Console.WriteLine("\nExercises completed.");
    }
}
