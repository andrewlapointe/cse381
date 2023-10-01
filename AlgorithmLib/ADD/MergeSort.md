# Algorithm Description Document

Author: 

Date: 

## 1. Name
Merge Sort

## 2. Abstract
Merge sort is an sorting algorithm which has an average complexity of O(n logn).
This is achieved by dividing the data into halves and sorting the smaller lists and
mergeing together. The reduces the comparisons needed thus making the sort faster.

Drawbacks of the merge sort are found in implementations in functional languages.
In languages with immutable data the list must be duplicated many times. This 
makes the algorithm more memory intensive than some others.

## 3. Methodology

Merge sort works by breaking the data down into smaller lists by halving the original. 
This continues until the lists are length 1.

```
[3,6,9,5] -> 
[3,6] [9,5] ->
[3] [6] [9] [5]
```

Then the small lists are joined back together in sorted order.

```
[3] [6] [9] [5] ->
[3,6] [5,9] ->
[3,5,6,9]
```
This is accomplished by making recursive calls to a splitting function and merging function.
In object oriented languages, like Python and c#, the sort can be done in place
by referencing the original data making it fast and memory efficient.
## 4. Pseudocode

```
MERGE(data, first, mid, last)
    sa1 = SUB-LIST OF data FROM first TO mid
        sa2 = SUB-LIST OF data FROM mid+1 TO last
    
        sa1Index = 0
        sa2Index = 0
        
        FOR mIndex = first TO last
            IF sa1Index IS GREATER THAN OR EQUAL TO LENGTH(sa1) THEN
                SET data[mIndex] TO sa2[sa2Index]
                INCREMENT sa2Index
            ELSE IF sa2Index IS GREATER THAN OR EQUAL TO LENGTH(sa2) THEN
                SET data[mIndex] TO sa1[sa1Index]
                INCREMENT sa1Index
            ELSE IF sa1[sa1Index] IS LESS THAN sa2[sa2Index] THEN
                SET data[mIndex] TO sa1[sa1Index]
                INCREMENT sa1Index
            ELSE
                SET data[mIndex] TO sa2[sa2Index]
                INCREMENT sa2Index
            END IF

SORT(data, first, last)
    IF first >= last THEN
            RETURN
    
    mid = (first + last) DIVIDED BY 2
    _Sort(data, first, mid)
    _Sort(data, mid + 1, last)
    Merge(data, first, mid, last)
```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

Inputs: data (list)

Outputs: None

## 6. Analysis Results

* Worst Case: $O(?)$

* Best Case: $\Omega(?)$

