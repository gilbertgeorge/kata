namespace codewars.kyu5;

public static class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        var stack = new Stack<char>();
        foreach (var c in input)
        {
            switch (c)
            {
                case '(':
                    stack.Push(c);
                    break;
                case ')' when stack.Count == 0:
                    return false;
                case ')':
                    stack.Pop();
                    break;
            }
        }
        return stack.Count <= 0;
    }
}