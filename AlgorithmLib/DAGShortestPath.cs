using System.Runtime.CompilerServices;

namespace AlgorithmLib;


public static class DAGShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {   
        //Setup. Instantiates all variables and lists.
        var inf = Graph.INF;  // Largest integer possible. "Functionally Infinite"
        var sorted = DAGTopologicalSort.Sort(g);
        var distance = new List<int>();
        var pred = new List<int>();
        for (var i = 0; i < g.Size(); i++)
        {
            distance.Add(inf);
            pred.Add(inf);
        }
        distance[startVertex] = 0;

        foreach (var vertex in sorted)
        {
            if (distance[vertex] == inf)
            {
                continue;
            }
            foreach (var edge in g.Edges(vertex))
            {
                if (distance[vertex] + edge.Weight < distance[edge.DestId])
                {
                    distance[edge.DestId] = distance[vertex] + edge.Weight;
                    pred[edge.DestId] = vertex;
                }
            }
        }
        return (distance, pred);
    } 
    
}