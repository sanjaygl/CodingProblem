namespace CodingProblem
{
    internal class SecondHighestInArray
    {
        public static void FindSecondHighest(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }

            int first = int.MinValue;
            int second = int.MinValue;

            foreach (int num in nums)
            {
                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    second = num;
                }
            }

            if (second == int.MinValue)
            {
                throw new InvalidOperationException("There is no second highest number in the array.");
            }

            Console.WriteLine("Second highest number is: " + second);
        }
    }
}
