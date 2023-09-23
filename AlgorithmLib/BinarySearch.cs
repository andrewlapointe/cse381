using System.ComponentModel.DataAnnotations;

namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        int first = 0;
        int last = data.Count - 1;
        int index = last / 2;

        while (first <= last)  // Runs until number is found or list is exhausted
        {
            if (target.CompareTo(data[index]) == 0)  // Found it!
            {
                return index;
            }
            if (target.CompareTo(data[index]) < 0)  // CASE: Target is less than the middle
            {
                last = index - 1; 
                
                index = (first + last) / 2;
            }
            else if (target.CompareTo(data[index]) > 0)   // CASE: Targed is greater than the middle
            {
                first = index + 1;
                index = (first + last) / 2;
            }
        }

        return -1;
    }
}