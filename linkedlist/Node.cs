namespace linkedlist
{
    internal class Node<T>
    {
        public Node<T>? Next { get; set; }

        public T Value { get; set; }
        public Node(Node<T> next, T value)
        {
            Next = next;
            Value = value;
        }

    }

    class LinkedList<T>
    {
        private Node<T>? First { get; set; }
        private Node<T>? Last { get; set; }

        public LinkedList()
        {
            First = null;
            Last = null;
        }

        public bool IsEmpty()
        {
            return First == null && Last == null;
        }

        public void Add(T value)
        {
            if (IsEmpty())
            {
                First = new Node<T>(null, value);
                Last = First;
            }
            else
            {
                Last.Next = new Node<T>(null, value);
                Last = Last.Next;
            }
        }

        public int GetSize()
        {
            int i = 0;
            for (Node<T> node = First; node != Last.Next; node = node.Next)
            {
                i++;
            }
            return i;
        }

        public T Get(int index)
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            int i = 0;
            for (Node<T> node = First; node != Last.Next; node = node.Next)
            {
                if (i == index)
                {
                    return node.Value;
                }
                else if (node == Last.Next)
                {
                    throw new IndexOutOfRangeException();
                }
                i++;
            }

            throw new IndexOutOfRangeException();
        }


    }
}
