namespace Exercises_CSharp.CollectionManip;

static class MissingNumber
{
    private static int GetMissingNumber(int[] list)
    {
        int xorOfArray = 0,
            xorOfNumbers = 0;

        //  xor -> convert to binary and compare, so n xor x = is n and x different?
        // then write back to binary and convert to integer
        // 2 xor 3 = 10 (binary 2) compared to 11 (binary 3), which results in 01 (binary 1)
        // letting us know they're not the same
        // xor is associative and commutative -> order of operations doesn't matter, (x ^ z) ^ c = (c ^ x) ^ z
        // as such, if two arrays are identical, their cumulative xor will be the same
        // as such, the difference between those xors will be the bits that are different, i.e. the missing number

        // XOR all array elements - will tell us what numbers ARE in the array
        foreach (int number in list)
        {
            xorOfArray ^= number;
        }
        //  XOR all numbers from 1 to n - will tell us what numbers SHOULD be in the array
        for (int i = 1; i <= list.Length + 1; i++) //Important that it goes 1 above array length
        {
            xorOfNumbers ^= i;
        }
        // Missing number is the xor of xor_numbers and xor_array
        return xorOfNumbers ^ xorOfArray;
    }

    public static int FindMissingNumber(int[] numbersList)
    {
        ListHelpers.LogNumbers(numbersList);
        Console.WriteLine("Looking for numbers missing in the sequence.");
        int length = numbersList.Length;
        int number = GetMissingNumber(numbersList);
        string message =
            number >= length + 1
                ? $"The given list has all numbers up to {length + 1}."
                : $"The missing number is {number}.";

        Console.WriteLine(message + "\n");
        return number;
    }
}
