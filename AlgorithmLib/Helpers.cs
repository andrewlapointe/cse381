namespace AlgorithmLib;

public class Helpers
{
    public static TElement Pop<TElement>(List<TElement> list)
        // Helper function which pops the last Item in a list and returns the popped item
    {
        var last = list.Count - 1;
        var r = list[last];
        list.RemoveAt(last);
        return r;
    }
}