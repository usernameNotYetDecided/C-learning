public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        char[] opens = ['(', '[', '{'], closes = [')', ']', '}'];
        List<char> Bracketeer = [];
        for (int i = 0; i < input.Length; i++)
        {
            if (opens.Contains(input[i]))   Bracketeer.Add(input[i]);
            else if (closes.Contains(input[i])) {
                if (Bracketeer.Count == 0) return false;
                if (closes.IndexOf(input[i]) == opens.IndexOf(Bracketeer[^1])) 
                    Bracketeer.RemoveAt(Bracketeer.Count - 1);
                else
                    return false;
            }
        }
        if (Bracketeer.Count != 0) return false;
        return true;
    }
}
