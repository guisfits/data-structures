## Notes

- `AVLTree` is a `Binary Search Tree` thats rebalanced itself very time that a value is inserted
- Search for a value is always `o(log n)` complexity, because the tree is always balanced
- When a new value is inserted we calculate the highest of the right and left and if is greater than 1 with must to rotate to rebalance
- There four times of rotation the balance a tree
    - Left
    - Right
    - Left-Right
    - Right-Left
