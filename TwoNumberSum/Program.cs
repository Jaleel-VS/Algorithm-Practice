

namespace  TwoNumberSum
{
    class Program {
        static void Main(string[] args)
        {
            int[] array = {3, 5, -4, 8, 11, 1, -1, 6};
            int targetSum = 10;

            // SolutionOne
            int[] resultOne = SolutionOne.TwoNumberSum(array, targetSum);
            if (resultOne.Length == 0)
            {
                Console.WriteLine("SolutionOne: No two numbers add up to the target sum.");
            }
            else
            {
                Console.WriteLine("SolutionOne: Two numbers that add up to the target sum are: " + resultOne[0] + " and " + resultOne[1]);
            }

            // SolutionTwo
            int[] resultTwo = SolutionTwo.TwoNumberSum(array, targetSum);
            if (resultTwo.Length == 0)
            {
                Console.WriteLine("SolutionTwo: No two numbers add up to the target sum.");
            }
            else
            {
                Console.WriteLine("SolutionTwo: Two numbers that add up to the target sum are: " + resultTwo[0] + " and " + resultTwo[1]);
            }
        }

    }
}