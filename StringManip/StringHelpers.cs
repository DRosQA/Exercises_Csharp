namespace Exercises_CSharp.StringManip;

static class StringHelpers
{
    public static string GetReversedString(string s)
    {
        return new string([.. s.Reverse()]);
    }
}
