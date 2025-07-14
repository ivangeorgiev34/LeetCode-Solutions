namespace _0020.ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsValid("()");
        }

        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();

            var dictionary = new Dictionary<char, char>()
            {
                { ')','(' },
                { ']','[' },
                { '}','{' },
            };

            foreach (var item in s)
            {
                if (dictionary.ContainsKey(item))
                {
                    if (stack.Count > 0 && stack.Peek() == dictionary[item])
                    {
                        stack.Pop();
                    }
                    else return false;
                }
                else stack.Push(item);
            }

            return stack.Count == 0;
        }
    }
}
