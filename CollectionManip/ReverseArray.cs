namespace Exercises_CSharp.CollectionManip;

static class ReverseArray
{
    private static void GetReversedArray<T>(T[] arr)
    {
        int i = 0;
        int j = arr.Length - 1;
        while (i < j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]); //swap first and last value
            i++;
            j--; //iterate index up/down
        }
    }

    public static T[]? ArrayReverse<T>(T[] arr, bool fancy = false)
    {
        if (arr.Length == 0 || arr == null)
        {
            Console.WriteLine("Provided array is invalid.\n");
            return arr;
        }
        Console.WriteLine($"Reversing array: {string.Join(", ", arr)}.");
        if (fancy)
        {
            Console.WriteLine("Doing it the fancy way.");
            GetReversedArray(arr);
        }
        else
        {
            Array.Reverse(arr);
        }
        Console.WriteLine($"Reversed array is: {string.Join(", ", arr)}.\n");
        return arr;
    }
}
