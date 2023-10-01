namespace AlgorithmLib;

public static class MergeSort
{
    public static void Sort(IList<IComparable> data)
    {
        _Sort(data, 0, data.Count - 1);
    }

    private static void _Sort(IList<IComparable> data, int first, int last)
    {
        if (first >= last)
            return;

        var mid = (first + last) / 2;
        _Sort(data, first, mid);
        _Sort(data, mid + 1, last);
        Merge(data, first, mid, last);
    }

    private static void Merge(IList<IComparable> data, int first, int mid, int last)
    {
        IList<IComparable> sa1 = new List<IComparable>(data).GetRange(first, mid - first + 1);
        IList<IComparable> sa2 = new List<IComparable>(data).GetRange(mid + 1, last - mid);

        var sa1Index = 0;
        var sa2Index = 0;
            
        for (var mIndex = first; mIndex <= last; mIndex++)
        {
            if (sa1Index >= sa1.Count)
            {
                data[mIndex] = sa2[sa2Index];
                sa2Index++;
            }
            else if (sa2Index >= sa2.Count)
            {
                data[mIndex] = sa1[sa1Index];
                sa1Index++;
            }
            else if (sa1[sa1Index].CompareTo(sa2[sa2Index]) < 0)
            {
                data[mIndex] = sa1[sa1Index];
                sa1Index++;
            }
            else
            {
                data[mIndex] = sa2[sa2Index];
                sa2Index++;
            }
        }
    }
    
}

