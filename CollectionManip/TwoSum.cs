namespace Exercises_CSharp.CollectionManip;

static class TwoSum
{
    private static bool BinarySearch(int[] list, int targetNumber)
    {
        int left = 0;
        int right = list.Length - 1;
        int mid;

        while (left <= right)
        {
            mid = left + ((right - left) / 2);

            if (list[mid] == targetNumber) // target found
            {
                return true;
            }
            else if (list[mid] < targetNumber) //target bigger than mid -> go right
            {
                left = mid + 1;
            }
            else if (list[mid] > targetNumber) //target smaller than mid -> go left
            {
                right = mid - 1;
            }
        }
        return false; //target not found in array
    }

    public static int[]? FindTwoSum(int[] numbersList, int targetSum)
    {
        ListHelpers.LogNumbers(numbersList);

        Console.WriteLine($"Looking for numbers that add up to {targetSum}.");
        numbersList.Sort();
        int[]? result = null;
        foreach (int number in numbersList)
        {
            int targetNumber = targetSum - number;

            if (BinarySearch(numbersList, targetNumber))
            {
                result = [number, targetNumber];
            }
        }
        string message =
            result != null
                ? $"Found numbers adding up to {targetSum}: {result[0]} and {result[1]}"
                : $"Could not find any numbers adding to {targetSum} in the given array.";
        Console.WriteLine(message + "\n");

        return result;
    }
}
