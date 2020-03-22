using DataStructures.LinkedLists;

namespace DataStructure.Tests.LinkedLists
{
    public abstract class Base
    {
        public static MyLinkedList<int> CreateSequentialIntList(int quantity = 0)
        {
            var list = new MyLinkedList<int>();
            for (int i = 0; i < quantity; i++)
            {
                list.AddLast(i + 1);
            }

            return list;
        }
    }
}
