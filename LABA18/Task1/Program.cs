namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            string s = "abc#d##c";
            Console.WriteLine(ProcessString(s));  
        }

        public static string ProcessString(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c != '#')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            return string.Join("", stack.Reverse().ToArray());
        }
    }
}