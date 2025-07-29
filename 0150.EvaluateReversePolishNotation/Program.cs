namespace _0150.EvaluateReversePolishNotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvalRPN(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }));
        }

        public static int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                switch (token)
                {
                    case "+": stack.Push(stack.Pop() + stack.Pop()); break;
                    case "-": stack.Push(-stack.Pop() + stack.Pop()); break;
                    case "*": stack.Push(stack.Pop() * stack.Pop()); break;
                    case "/":
                        var firstNum = (decimal)stack.Pop();
                        var secondNum = (decimal)stack.Pop();
                        stack.Push((int)Math.Truncate(secondNum / firstNum));
                        break;
                    default: stack.Push(int.Parse(token)); break;
                }
            }

            return stack.Pop();
        }
    }
}
