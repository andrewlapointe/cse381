namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        for (var i = 0; i < data.Count; i++)
        {
            // Console.WriteLine(i);
            if (data[i].Equals(target)) // The "==" operator is not supported for iComparables. Use the .Equals() instead
            {
                return i; // Break the loop when the answer is found.
            }
        }
        return -1; // Fail Condition
    }
}