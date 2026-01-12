namespace CodingProblem
{
    internal class Factorial
    {
        // Write a function that returns the factorial of a given non-negative integer n.
        // Formula: n! = n × (n-1) × (n-2) × ... × 2 × 1
        // Example: 5! = 5 × 4 × 3 × 2 × 1 = 120
        // Special case: 0! = 1
        public static long GetFactorial(int n)
        {
            // Guard clause: Validates that input is non-negative
            // Example: GetFactorial(-1) will throw an exception
            if (n < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }
            // Base case: 0! = 1
            // Example: GetFactorial(0) returns 1
            if (n == 0)
            {
                Console.WriteLine($"{n}! = 1");
                return 1;
            }

            long result = 1;
            List<int> factors = new List<int>();

            // Loop: Iterates from 1 to n, multiplying to get factorial
            // Example: For GetFactorial(5), loop runs with i = 1, 2, 3, 4, 5
            for (int i = 1; i <= n; i++)
            {
                result *= i; // Multiply current result by i
                factors.Add(i);
            }

            string formula = string.Join(" × ", factors);
            Console.WriteLine($"{n}! = {formula} = {result}");

            // Return the factorial of n
            // Example: GetFactorial(5) returns 120 (5! = 120)
            return result;
        }
    }
}
