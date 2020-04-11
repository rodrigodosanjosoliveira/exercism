using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        int ocurrences = 0;
        var lowerWord = word.ToLowerInvariant();

        foreach (var letter in lowerWord)
        {
            ocurrences += (from char l in lowerWord
                           where letter == l && letter != '-' && letter != ' '
                           select l).Count();
            if (ocurrences > 1) return false;
            ocurrences = 0;
        }
        return ocurrences == 0;
    }
}
