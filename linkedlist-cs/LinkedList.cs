namespace Links
{
    public class LinkedList
    {
        private Node _head;
        public void AddFirst(object data)
        {
            var node = new Node(data, _head);
            _head = node;
        }

        public void AddLast(object data)
        {
            if (_head == null)
                _head = new Node(data, null);
            else
            {
                var node = new Node(data);
                Node current = _head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = node;
            }
        }

        public void GetData()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine("Current Data: " + current.Data);
                current = current.Next;
            }
        }
    }
}