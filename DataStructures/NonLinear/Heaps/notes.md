## Notes

- `Heap` is a complete `Binary Tree`, that means every level - except potentially in the last level - is filled with nodes. And all level is filled from left to the right.
- We have two types of `heap`:
  - `MaxHeap`: The value of every node is greater than or equal to his children
  - `MinHeap`: Opposite of `MaxHeap`
- Adding or removing an item of a `Heap` runs in `o(log n)`, because we have to bubble up or down an item
- `Heap` just have a `Get` method thats return the root of the tree. If you want lookup, `AVLTree` is a better option
- Usage
  - Sorting (HeapSort)
  - GPS: Find the shorter path between two node in the graph
  - Priority Queues 
  - Finding the Kth smallest/largest value
