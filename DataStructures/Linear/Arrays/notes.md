## Notes

- Arrays are the most simplest data-structure.
- If your data is fixed size and you don't remove or insert any other item, array is perfect! 
- An ArrayList is a wrapper of an array.
- Arrays are super fast to get data by their index, is `o(1)` operation. But if we want to search, it is `o(n)` operation because we must to match all the exist items
- To deleting data is `o(n)` because you can delete the first item `[0]` and we must to reallocate all the values to the previous index
- Insert data is `o(n)` because if the array is getting full, we must to create another one with more capacity and reallocate all the exist items to the new one.
- If you want to dynamic insert and removing data, LinkedList maybe is a better option
