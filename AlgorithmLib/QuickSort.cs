namespace AlgorithmLib;

public static class QuickSort
{
    private static Random rnd = new Random();
    private static int Partition(List<IComparable> data, int first, int last)
    {
        var pivot = rnd.Next(first, last+1);
        var temp = data[pivot];
        data[pivot] = data[last];
        data[last] = temp;
        // Current pivot is at index 'last'
        var leftMostGreaterPivot = first;
        for (var index = first; index < last; index++)
        {
            if (data[index].CompareTo(data[last]) <= 0)
            {
                var temp2 = data[leftMostGreaterPivot];
                data[leftMostGreaterPivot] = data[index];
                data[index] = temp2;
                leftMostGreaterPivot++;
            }
        }
        var temp3 = data[leftMostGreaterPivot];
        data[leftMostGreaterPivot] = data[last];
        data[last] = temp3;
        return leftMostGreaterPivot;
    }

    private static void _Sort(List<IComparable> data, int first, int last)
    {
        if (first >= last) // Item of size 1 is sorted
        {
            return;
        }

        var pivotIndex = Partition(data, first, last);  // PivotIndex is sorted
        _Sort(data, first, pivotIndex - 1);
        _Sort(data, pivotIndex + 1, last);
    }

    public static void Sort(List<IComparable> data)
    {
        _Sort(data, 0, data.Count - 1);
    }

}