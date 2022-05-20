using System.Text;

namespace TestApp_VDcom.CustomCircleDoubleLinkedList
{
    public class CircleDoubleLinkedList<T>
    {
        private DoubleNode<T> head;
        private int size = 0;

        public CircleDoubleLinkedList()
        {
        }

        private void init(DoubleNode<T> newNode)
        {
            head = newNode;
            head.Next = head;
            head.Prev = head;
        }

        public DoubleNode<T> Head { get => head; set => head = value; }
        public int Size { get => size; set => size = value; }

        public void add(T value)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(value);
            if (size == 0)
            {
                init(newNode);
            }
            else
            {
                head.Prev.Next = newNode;
                newNode.Prev = head.Prev;
                newNode.Next = head;
                head.Prev = newNode;
            }
            size++;
        }

        public override string ToString()
        {
            if (size == 0)
                return base.ToString();
            StringBuilder sb = new StringBuilder("size: " + size + '\n');
            DoubleNode<T> node = head;
            for (int i = 0; i < size; i++)
            {
                sb.Append(node.ToString() + "->\n");
                node = node.Next;
            }
            return sb.ToString();
        }
    }
}
