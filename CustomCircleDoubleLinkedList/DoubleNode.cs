using System;

namespace TestApp_VDcom.CustomCircleDoubleLinkedList
{
    public class DoubleNode<T>
    {
        private T value;
        private DoubleNode<T> prev;
        private DoubleNode<T> next;

        public DoubleNode(T value, DoubleNode<T> prev, DoubleNode<T> next)
        {
            this.value = value;
            this.prev = prev ?? throw new ArgumentNullException(nameof(prev));
            this.next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public DoubleNode(T value)
        {
            this.value = value;
        }

        public DoubleNode()
        {
        }

        public T Value { get => value; set => this.value = value; }
        public DoubleNode<T> Prev { get => prev; set => prev = value; }
        public DoubleNode<T> Next { get => next; set => next = value; }

        public override string? ToString()
        {
            if (string.IsNullOrEmpty(value.ToString()))
                return base.ToString();
            return value.ToString();
        }
    }
}
