namespace _0155.MinStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.Pop();

            var top = minStack.Top();
            var min = minStack.GetMin();
        }
    }

    public class MinStack
    {
        private readonly Stack<int> stack;
        private readonly Stack<int> minStack;

        public MinStack()
        {
            this.stack = new Stack<int>();
            this.minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (this.minStack.Count == 0)
            {
                this.minStack.Push(val);
                this.stack.Push(val);
                return;
            }

            var currMin = this.minStack.Peek();

            this.minStack.Push(currMin > val ? val : currMin);
            this.stack.Push(val);
        }

        public void Pop()
        {
            this.stack.Pop();
            this.minStack.Pop();
        }

        public int Top()
        {
            return this.stack.Peek();
        }

        public int GetMin()
        {
            return this.minStack.Peek();
        }
    }
}
