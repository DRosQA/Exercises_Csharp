using System.Runtime.Intrinsics.X86;

namespace Exercises_CSharp.StringManip;

static class Palindrome
{
    private static string StripString(string s)
    {
        string? stripped = string.Concat(s.Replace(" ", "").Where(c => !char.IsPunctuation(c)));
        return !string.IsNullOrWhiteSpace(stripped) ? stripped : string.Empty;
    }

    public static bool CheckIfPalindrome(string s)
    {
        Console.WriteLine(
            $"Checking if '{s}' is a palindrome."
        );
        if (string.IsNullOrWhiteSpace(s) || StripString(s)?.Length < 2)
        {
            Console.WriteLine(
                "String inherently cannot be a palindrome; check if it has more than 2 characters that are not spaces or punctuation.\n"
            );
            return false;
        }

        string reversed = StringHelpers.GetReversedString(StripString(s));
        bool isPalindrome = StripString(s)
            .Equals(StringHelpers.GetReversedString(StripString(s)), StringComparison.OrdinalIgnoreCase);
        string message = isPalindrome
            ? $"The given string '{s}' is a palindrome."
            : $"The given string '{s}' is NOT a palindrome, as it reverses to '{reversed}.";

        Console.WriteLine(message + "\n");
        return isPalindrome;
    }
}
