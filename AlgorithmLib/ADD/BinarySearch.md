# Algorithm Description Document

Author: Andrew LaPointe

Date: 23/09/2023

## 1. Name
Binary Search

## 2. Abstract
This is a algorithm which finds a given target in a sorted list.
## 3. Methodology
This search is accomplished by choosing a middle point, and dropping half of
the values if the fall above or below the given target.
## 4. Pseudocode

```
BINARY-SEARCH(list, target)


Check the middle value of the list

If it equals the target, return the index of the middle

If the middle is less than the target, drop the bottom half of the list and start over from the new middle value

If the middle is greater than the target then drop the top half of the list and star over from the new middle value

```

## 5. Inputs & Outputs

Inputs: target value and data to search through

Outputs: index of the found target in the data, or a "not found" value

## 6. Analysis Results

* Worst Case: O(n log(n))

* Best Case: Omega(1)

