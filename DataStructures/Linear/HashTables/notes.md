## Notes

- HashTables are store `key/value` pairs
- HashTable uses a HashFunction to map a key to index value
- Insert, remove, lookup run in `o(1)`
- Theres some implementations in many languages
  - Java: HashMap
  - JavaScript: Object
  - Python: Dictionary
  - C#: Dictionary
- Similar to `HashTables`, we have `Sets`. `Sets` just have keys and they don't allow repetitive items. 
- We shouldn't store their values direct in an index because different keys maybe point to same index, we call this `collision`
- `Chaining` is a technique to handler `collision`. We create a LinkedList in each array cell and store their values there
- Also we can search for the next `open address`. We have three probing algorithms
  - **Linear**: (hash1 + i) % table_size
  - **Quadratic**: (has1 + i2) % table_size
  - **Double Hash**: (hash1 + i \* hash2) % table_size
