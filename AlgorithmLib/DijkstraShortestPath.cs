namespace AlgorithmLib;

public static class DijkstraShortestPath
{
    public static (int[], int[]) ShortestPath(Graph graph, int startVertex) {
        // Initialize distance array. distance[i] will hold the shortest distance from startVertex to i.
        int[] distance = new int[graph.Size()];
        int[] pred = new int[graph.Size()];
        for (int i = 0; i < graph.Size(); i++) {
            distance[i] = Graph.INF;
            pred[i] = Graph.INF;
        }
        distance[startVertex] = 0;
        
        // Priority Queue used on sparce graphs like maps for efficiency
        PriorityQueue<int> queue = new PriorityQueue<int>();
        for (int index = 0; index < graph.Size(); index++) {
            queue.Insert(index, distance[index]);
        }

        while (queue.Size() > 0) {
            // Vertex with the shortest known distance is dequeued first.
            int smallesId = queue.Dequeue();
            foreach (var edge in graph.Edges(smallesId)) {
                // Check if there's a shorter path through smallestId to this neighboring vertex.
                if ((long)distance[smallesId] + edge.Weight < distance[edge.DestId]) {
                    distance[edge.DestId] = distance[smallesId] + edge.Weight;
                    pred[edge.DestId] = smallesId;
                    queue.DecreaseKey(edge.DestId, distance[edge.DestId]);
                }
            }
        }

        return (distance, pred);
    }
}