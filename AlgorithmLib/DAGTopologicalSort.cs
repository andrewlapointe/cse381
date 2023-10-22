using System.Collections;

namespace AlgorithmLib;

public static class DAGTopologicalSort
{
    public static List<int> Sort(Graph g)
    {
        var inDegree = new List<int>(Enumerable.Repeat(0, g.Size()));
        var linearOrder = new List<int>();

        for (var vertex = 0; vertex < g.Size(); vertex++)
        {
            foreach (var edge in g.Edges(vertex))
            {
                inDegree[edge.DestId]++;
            }
        }
        
        var next = new List<int>();
        
        for (var vertex = 0; vertex < g.Size(); vertex++)
        {
            if (inDegree[vertex] == 0)
            {
                next.Add(vertex);
            }
        }
        
        while (next.Any())
        {
            var vertex = Helpers.Pop(next);
            linearOrder.Add(vertex);

            foreach (var edge in g.Edges(vertex))
            {
                inDegree[edge.DestId] -= 1;
                if (inDegree[edge.DestId] == 0)
                {
                    next.Add(edge.DestId);
                }
            }
        }
        
        return linearOrder;
    } 
}