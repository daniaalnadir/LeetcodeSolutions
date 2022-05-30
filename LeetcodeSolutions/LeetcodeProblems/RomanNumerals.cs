namespace LeetcodeSolutions.LeetcodeProblems;

public class RomanNumerals
{
    public static string RomanNumeral = "III";
    public int CalculateRomanNumeralToInteger()
    {
        var dictionary = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int total = 0;

        for (int i = 0; i < RomanNumeral.Length; i++)
        {
            if (i + 1 < RomanNumeral.Length && dictionary[RomanNumeral[i]] < dictionary[RomanNumeral[i + 1]])
            {
                total -= dictionary[RomanNumeral[i]];
            }


            else
            {
                total += dictionary[RomanNumeral[i]];
            }
        }

        return total;
    }
}