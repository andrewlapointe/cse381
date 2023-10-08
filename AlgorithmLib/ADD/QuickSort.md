# Algorithm Description Document

Author: Andrew LaPointe

Date: 2023/10/07

## 1. Name

Quick Sort

## 2. Abstract
Quick sort is yet another sorting algorithm which quickly breaks down large datasets
by deconstruction. Quick sort is best implemented as a sort in place algorithm to 
save on memory.

## 3. Methodology
The first step in every itteration of quick sort is to check the length of the list.
If the list is empty, then it will be returned as is. If the length is one then it 
is already sorted by default and can also be returned.

In cases of lists greater than length one, the algorithm will select a random point in the list
and move it to the end. This has become the pivot around which the list will be sorted.

Now each element of the list, save the last, will be compared to the pivot. All less
than the pivot will be moved to the front of the list, while all greater will be put in
the second half. Then the pivot is placed in its sorted position in the "center" of the 
list. Although this may not be the actual center.

From here each side of the pivot will be recursively sorted untill the base case of list 
lenght one is reached.

## 4. Pseudocode

```
function Sort(data): # This is the public function which sets up the initial first and last values
    _Sort(data, 0, len(data)-1)

function _Sort(data, first, last):
    if first >= last:
        return
    pivotIndex = Partition(data, first, last) # gets the pivot index from the partition function
    _Sort(data, first, pivotIndex - 1) # recursive call on the first half of the list
    _Sort(data, pivotIndex + 1, last) # recursive call on the second half

function Partition(data, first, last):
    pivot = random.randint(first, last); # Picks random pivot
    Swap(data[pivot], data[last] # Move the pivot to the end
    
    leftMostGreaterPivot = first;

    for index in range(first, last):
        if data[index] <= data[last]:
            Swap(data[leftMostGreaterPivot], data[index])
            leftMostGreaterPivot++

    Swap(data[leftMostGreaterPivot], data[last])
    return leftMostGreaterPivot # new pivot

```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

Inputs: Data, a list of integers.

Outputs: None. This is a sort in place function. The original list is modified.

## 6. Analysis Results

* Worst Case: $O(n^2)$

* Best Case: $\Omega (n logn)$

