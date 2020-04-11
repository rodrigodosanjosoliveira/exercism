using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var result = from char v in "abcdefghijklmnopqrstuvxyz"
                     where !input.ToLower().Contains(v)
                     select v;

        return !result.Any();
    }
}
