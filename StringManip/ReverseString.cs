namespace Exercises_CSharp.StringManip;

static class ReverseString
{
    public static string StringReverse(string s)
    {
        Console.WriteLine($"Reversing string '{s}'.");
        string reversed = StringHelpers.GetReversedString(s);
        Console.WriteLine($"Reversed string is: '{reversed}'.\n");
        return reversed;
    }
}
