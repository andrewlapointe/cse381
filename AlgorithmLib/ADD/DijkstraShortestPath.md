# Algorithm Description Document

Author: Andrew LaPointe

Date: 2023/10/21

## 1. Name
Dijkstra Shortest Path Algorithm

## 2. Abstract
The Dijkstra Shortest Path algorithm is a graph search algorithm that solves the shortest path 
problem for a graph with non-negative edge weights, producing a shortest path tree. 
This algorithm is often used in routing and is similar to the algorithm used by google maps. 
It works by building up a set of nodes that have minimum distance from the start node.

## 3. Methodology
Dijkstra’s algorithm sets the distance to the starting vertex to zero and all other vertices to infinity (INF). 
As the algorithm progresses, it updates the shortest distance to each vertex by considering all of its 
neighboring vertices. If a new shortest path is found it overwrites the old path, only leaving the shortest.

## 4. Pseudocode
```pseudocode
function DIJKSTRA-SHORTEST-PATH(Graph, startVertex):
    create a list of size Graph.Size() with all values as INF
    create a list of size Graph.Size() with all values as INF
    distance[startVertex] = 0

    Initialize a priority queue as queue
    
    FOR index from 0 to Graph.Size() - 1:
        queue.Insert(index, distance[index])

    WHILE queue.Size() > 0:
        smallestId = queue.Dequeue()
        FOR EACH edge in Graph.Edges(smallestId):
            IF distance[smallestId] + edge.Weight < distance[edge.DestId]:
                distance[edge.DestId] = distance[smallestId] + edge.Weight
                pred[edge.DestId] = smallestId
                queue.DecreaseKey(edge.DestId, distance[edge.DestId])

    RETURN (distance, pred)
```

## 5. Inputs & Outputs

**Inputs:**
- `graph`: A representation of the graph where each vertex is connected to its neighbors with associated weights.
- `start_vertex`: The starting vertex for which the shortest distances to all other vertices will be calculated.

**Outputs:**
- `distance`: A list where the indexes are vertices and the values are the shortest distances from the `start_vertex` to that vertex.
- `pred`: A list representing the shortest path tree. The index is the vertex and the value at that index is the preceding vertex on the shortest path from the startVertex. If the value at an index is Graph.INF, it means there's no known predecessor for that vertex.

`Did you know you could highlight text with these ticks? The more you know.`
## 6. Analysis Results

* **Worst Case:** ( O(E + V logV) ) where ( E ) is the number of edges and ( V ) is the number of vertices. This is the case when using a priority queue or binary heap for the unvisited set.
* **Best Case:** ( \Omega(E + V) )

