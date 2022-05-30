namespace Scratchpad.LeetcodeSolutions;

public class TwoSum
{
    public static int[] IntegerArray = new int[] {11, 2, 15, 7};
    public static int target = 9;
    public int[] CalculateTwoSum()
    {
        for (int i = 0; i < IntegerArray.Length; i++)
        {
            for (int j = i+1; j < IntegerArray.Length; j++)
            {
            
                if (IntegerArray[i] + IntegerArray[j] == target)
                {
                    return new int[] {i, j};
                }
            
            }
        }

        throw new ArgumentException("There are no two values in the array that add up to the target.");
    }
}