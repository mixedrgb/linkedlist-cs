namespace Links
{
    public class Node
    {
        public object Data { get; private set; }
        public Node Next { get; set; }

        public Node(object data)
        {
            Data = data;
        }
        public Node(object data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}