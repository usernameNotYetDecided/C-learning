public static class LineUp
{
    public static string Format(string name, int number)
    {
        string n = number.ToString(), j;
        if (n[^1] == '1' && (n.Length == 1 || n[^2] != '1'))
            j = "st";
        else if (n[^1] == '2' && (n.Length == 1 || n[^2] != '1'))
            j = "nd";
        else if (n[^1] == '3' && (n.Length == 1 || n[^2] != '1'))
            j = "rd";
        else 
            j = "th";
        return $"{name}, you are the {n}{j} customer we serve today. Thank you!";
    }
}
