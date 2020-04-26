## Notes

- LinkedList is second most used data-structures
- A LinkedList consists of a group of node in sequence
- Each node have a value and a reference to the next node
- Is dynamic, LinkedList can grow and shrink very easy
- Each node have a reference to the next, or previous node in case of DoubleLinkedList
- Getting is `o(n)` because we must lookup for all exist item first
- Insert an item in the beginning or in the end is `o(1)` operation, but if we want to insert on the middle is `o(n)`
- Removing an item in the beginning is `o(1)`, in the middle or the end is `o(n)` because we must find the previous node before. If is a DoubleLinkedList is `o(1)`

