/*
This algorithm is O(n) time complexity and O(n) space complexity.

The solution involves using a hash set to store the numbers that we have seen so far. 
We iterate through the array and for each number, we calculate the difference between the target sum and the current number.
If the difference is in the hash set, then we have found the two numbers that add up to the target sum and we return them.
If the difference is not in the hash set, we add the current number to the hash set and continue iterating through the array.
If we reach the end of the array without finding the two numbers that add up to the target sum, we return an empty array.

*/

namespace TwoNumberSum
{
    public class SolutionTwo
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            HashSet<int> numbers = [];

            foreach (int num in array)
            {
                int difference = targetSum - num;
                if (numbers.Contains(difference))
                {
                    return [num, difference];
                }
                else
                {
                    numbers.Add(num);
                }
            }

            return [];
        }
    }
}