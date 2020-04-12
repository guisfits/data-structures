## Notes

- In `Tries`, each node can have several of nodes
- `Trie` name comes from `Retrieval`, others names are `Digital`, `Radix` and `Prefix`
- We can use `Trie` to autocompletion

```
          []
        /    \
     [b]      [c]
    /   \      |
  [a]   [o]   [a]
   |     |     |
  [g]   [y]   [t]
  ```

- In this tree, we can lookup for _bag_, _boy_ and _cat_
- Lookup run `o(L)`, where `L` is the length of thoe word we're searching for
- Insert and Removing a word also run in `o(L)`
