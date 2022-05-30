namespace LeetcodeSolutions.Algorithms;

public class BinarySearch
{
    public bool BinarySearchIterative(int[] array, int valueToFind)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + right / 2;

            if (array[mid] == valueToFind)
            {
                return true;
            }
            else if (valueToFind < array[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return false;
    }

    public bool BinarySearchRecursive(int[] array, int valueToFind, int left, int right)
    {
        if (left > right)
        {
            return false;
        }


        int mid = left + ((right - left) / 2);

        if (array[mid] == valueToFind)
        {
            return true;
        }
        else if (valueToFind < array[mid])
        {
            return BinarySearchRecursive(array, valueToFind, left, mid - 1);
        }
        else
        {
            return BinarySearchRecursive(array, valueToFind, mid + 1, right);
        }
    }
}