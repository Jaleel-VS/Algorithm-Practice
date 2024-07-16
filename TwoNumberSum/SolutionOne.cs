/*
This algorithm is O(nlog(n)) time complexity and O(1) space complexity.

The solution involves sorting the array and then using two pointers to traverse the array. 
The left pointer starts at the beginning of the array and the right pointer starts at the end of the array. 
If the sum of the two numbers at the left and right pointers is equal to the target sum, then we return those two numbers. 
If the sum is less than the target sum, we move the left pointer to the right. If the sum is greater than the target sum, 
we move the right pointer to the left. We continue this process until we find the two numbers that add up to the target sum 
or until the left pointer is greater than the right pointer, in which case we return an empty array.
*/

namespace TwoNumberSum
{
    public class SolutionOne
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int currentSum = array[left] + array[right];
                if (currentSum == targetSum)
                {
                    return [array[left], array[right]];
                }
                else if (currentSum < targetSum)
                {
                    left++;
                }
                else if (currentSum > targetSum)
                {
                    right--;
                }
            }

            return [];
        }
    }
}