# Algorithm Description Document

Author: Andrew LaPointe

Date: 2023/10/14

## 1. Name
Directed Acyclic Graph (DAG) Shortest Path

## 2. Abstract
The DAG shortest path algorithm is a method of finding the shortest path between two arbitrary
nodes on a directed graph with weighted edges and no cycles. Because of its spceificity it is able
to outperform more generic shortest path algorithms.

## 3. Methodology
The largest constraint to this algorithm is that it relies on the graph nodes being sorted
in topological order. Without this sort, the algorithm will fail.

Once the DAG is sorted we set the distance of the first node to 0 and all other nodes to infinity or
otherwise mark them as far away.

From here we can check the distance from the start node to each connecting node and change their
distance values to match the weight of the path taken via the edges.

This process is then looped for each node with a non infinite distance value.

## 4. Pseudocode

```
FUNCTION DAG_Shortest_Path(graph, start_vertex):

    // DAG must be SORTED!!!
    sorted = topological_sort(graph) 
    
    // Set all initial distances (other than the start) to infinity
    distance = [i for i in graph.size(): x = ∞]
    pred = [i for i in graph.size(): x = ∞]
    distance[start_vertex] = 0
    

    // Main loop.
    for vertex in sorted:
        if distance[vertex] == ∞:
            skip
        foreach edge in graph.edges(vertex):
            if distance[vertex] + edge.weight < distance[edge.destId]:
                distance[edge.destId] = distance[vertex] + edge.weight
                pred[edge.destId] = vertex

    return (distance, pred)
```

## 5. Inputs & Outputs

Inputs: graph, start node

Outputs: distance, pred (lists which will show the shortest path to any given node to the start)

## 6. Analysis Results

* Worst Case: $O(V + E)$

* Best Case: $\Omega(V + E)$

