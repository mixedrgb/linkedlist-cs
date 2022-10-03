namespace Links
{
    public class Program
    {
        internal static void Main()
        {
            var list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddFirst(10000);
            list.GetData();
        }
    }
}