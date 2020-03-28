using DataStructures.LinkedLists;

namespace DataStructures.Tests.LinkedLists
{
    public abstract class Base
    {
        public static MyLinkedList<int> CreateSequentialIntList(int quantity = 0, int multiply = 1)
        {
            var list = new MyLinkedList<int>();
            for (int i = 0; i < quantity; i++)
            {
                list.AddLast((i + 1) * multiply);
            }

            return list;
        }
    }
}
