namespace Scratchpad.LeetcodeSolutions;

public class ThirdDistinctMaximum
{
    public static int[] ThirdDistinctMaximumArray = new int[] {2, 2, 3, 1, 9, 8, 7, 13};


    public int CalculateThirdDistinctMaximum(int[] thirdDistinctMaximum)
    {
        int? firstMax = null;
        int? secondMax = null;
        int? thirdMax = null;

        foreach (var num in thirdDistinctMaximum)
        {
            if (num == firstMax || num == secondMax || num == thirdMax)
            {
                continue;
            }
        
            if (firstMax == null || num > firstMax)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = num;
            }
            else if (secondMax == null || num > secondMax)
            {
                thirdMax = secondMax;
                secondMax = num;
            }
            else if (thirdMax == null || num > thirdMax)
            {
                thirdMax = num;
            }
        }

        if (thirdMax == null)
        {
            // This would be the highest number
            return (int)firstMax;
        }
        return (int)thirdMax;
    }
}