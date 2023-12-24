namespace Zadanie6
{
    class MyList<T>
    {
        private class Node
        {
            public Node next;
            public T value { get; set; }

            public Node(T value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;

        public T this[int i]
        {
            get
            {
                return Get(i).value;
            }
            set
            {
                Get(i).value = value;
            }
        }

        private Node Get(int i)
        {
            if (i < 0 || i >= Count)
                throw new IndexOutOfRangeException();

            Node current = first;
            for (int j = 0; j < i; j++)
            {
                current = current.next;
            }
            return current;
        }

        public int Count
        {
            get
            {
                int count = 0;
                Node current = first;
                while (current != null)
                {
                    count++;
                    current = current.next;
                }
                return count;
            }
        }

        public void Add(T element)
        {
            Node newNode = new(element);
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
        }

        public void Insert(int i, T element)
        {
            if (i < 0 || i > Count)
                throw new IndexOutOfRangeException();

            Node newNode = new(element);

            if (i == 0) 
            {
                newNode.next = first;
                first = newNode;
            }
            else
            {
                Node previous = Get(i - 1);
                newNode.next = previous.next;
                previous.next = newNode;
            }
        }

        public bool Remove(T element)
        {
            Node current = first;
            Node previous = null;

            while (current != null)
            {
                if (current.value.Equals(element))
                {
                    if (previous == null)
                    {
                        first = current.next;
                        if (first == null)
                            last = null;
                    }
                    else
                    {
                        previous.next = current.next;
                        if (previous.next == null)
                            last = previous;
                    }
                    return true;
                }
                previous = current;
                current = current.next;
            }
            return false;
        }

        public bool RemoveAt(int i)
        {
            if (i < 0 || i >= Count)
                throw new IndexOutOfRangeException();

            if (i == 0)
            {
                first = first.next;
                if (first == null)
                    last = null;
            }
            else
            {
                Node previous = Get(i - 1);
                previous.next = previous.next.next;
                if (previous.next == null)
                    last = previous;
            }
            return true;
        }
    }
}
