using System;
using System.Threading;

namespace LockFree
{
    public class Stack<T>
    {
        private StackNode<T> _head;

        private StackNode<T> Head => _head;

        public void Push(T value)
        {
            var newHead = new StackNode<T>
            {
                Value = value
            };

            int attempts = 1;
            while (true)
            {
                var head = Interlocked.CompareExchange(ref _head, null, null);
                newHead.Next = head;

                var oldHead = Interlocked.CompareExchange(ref _head, newHead, head);

                if (oldHead == head)
                {
                    break;
                }

                ++attempts;
            }

            if (attempts > 1)
            {
                Console.WriteLine("Write Attempts: {0}", attempts);
            }
        }

        public bool TryPop(out T value)
        {
            StackNode<T> node = null;

            int attempts = 1;
            while (true)
            {
                var head = Interlocked.CompareExchange(ref _head, null, null);
                if (head != null)
                {
                    var oldHead = Interlocked.CompareExchange(ref _head, head.Next, head);

                    if (oldHead == head)
                    {
                        node = head;
                        break;
                    }
                }
                else
                {
                    break;
                }

                ++attempts;
            }

            if (attempts > 1)
            {
                Console.WriteLine("Read Attempts: {0}", attempts);
            }

            if (node != null)
            {
                value = node.Value;
                return true;
            }

            value = default;
            return false;
        }
    }

    public class StackNode<T>
    {
        public T Value { get; set; }

        public StackNode<T> Next { get; set; }
    }
}