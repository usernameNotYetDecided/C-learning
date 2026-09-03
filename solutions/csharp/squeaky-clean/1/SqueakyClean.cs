using System.Runtime.ExceptionServices;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var a = new StringBuilder(identifier);
        a.Replace(' ', '_');
        int i;
        i = a.ToString().IndexOf('\0');
        while (i != -1)
        {
            a.Remove(i, 1);
            a.Insert(i, "CTRL");
            i = a.ToString().IndexOf('\0');
        }
        i = a.ToString().IndexOf("-");
        while (i != -1)
        {
            a.Remove(i, 1);
            a[i] = char.ToUpper(a[i]);
            i = a.ToString().IndexOf("-");
        }
        char[] g = {'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'ο', 'π', 'ρ', 'σ', 'ς', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω'};
        for (int j = a.Length-1; j >= 0; j--)
            if (!(char.IsLetter(a[j]) | (a[j] == '_')) | g.Contains(a[j]))
                a.Remove(j, 1);
        return a.ToString();
    }
}
