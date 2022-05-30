namespace Scratchpad.LeetcodeSolutions;

public class NumberOfArithmeticSlices
{
    public static int[] IntegerArray = new int[] {1, 2, 3, 4, 5, 6};

    public int CalculateNumberOfArithmeticSlices()
    {
        int count = 0;
        int[] dp = new int[IntegerArray.Length];
        
        for (int i = 2; i < IntegerArray.Length; i++)
        {
            var differenceBetweenFirst = IntegerArray[i] - IntegerArray[i - 1];
            var differenceBetweenSecond = IntegerArray[i - 1] - IntegerArray[i - 2];

            if (differenceBetweenFirst == differenceBetweenSecond)
            {
                dp[i] = 1 + dp[i - 1];
                count += dp[i];
            }
        }


        return count;
    }

}