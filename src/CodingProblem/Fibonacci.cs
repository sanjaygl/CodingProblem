namespace CodingProblem
{
    internal class Fibonacci
    {
        // Simple recursive implementation of Fibonacci (inefficient for large n)
        public static int FibonacciNumber(int n)
        {
            return n <= 1 ? n : FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }

        // Write a function that returns the nth Fibonacci number.
        public static int GetFibonacci(int n)
        {
            // Guard clause: Validates that input is non-negative
            // Example: GetFibonacci(-1) will throw an exception
            if (n < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }

            // Base case 1: F(0) = 0
            // Example: GetFibonacci(0) returns 0
            if (n == 0) return 0;

            // Base case 2: F(1) = 1
            // Example: GetFibonacci(1) returns 1
            if (n == 1) return 1;

            // Variable 'a': Tracks F(i-2), initialized to F(0) = 0
            // Example: When calculating F(2), 'a' starts as 0
            int a = 0;

            // Variable 'b': Tracks F(i-1), initialized to F(1) = 1
            // Example: When calculating F(2), 'b' starts as 1
            int b = 1;

            // Variable 'fib': Stores the current Fibonacci number being calculated
            // Example: For F(4), this will hold values 1, 2, 3 in successive iterations
            int fib = 0;

            // Loop: Iterates from position 2 to n, building up the sequence
            // Example: For GetFibonacci(4), loop runs with i = 2, 3, 4
            for (int i = 2; i <= n; i++)
            {
                // Calculate current Fibonacci: F(i) = F(i-1) + F(i-2)
                // Example: F(2) = 1 + 0 = 1, F(3) = 1 + 1 = 2, F(4) = 2 + 1 = 3
                fib = a + b;

                // Shift window: Move 'a' forward to the previous 'b' value
                // Example: After F(2), a becomes 1 (was 0)
                a = b;

                // Shift window: Move 'b' forward to the just-calculated 'fib' value
                // Example: After F(2), b becomes 1 (the result of F(2))
                b = fib;
            }

            Console.WriteLine($"F({n}) = {fib}");
            // Return the nth Fibonacci number
            // Example: GetFibonacci(4) returns 3 (sequence: 0, 1, 1, 2, 3)
            return fib;
        }

        // Write a function that returns the Fibonacci series from F(0) to F(n).
        public static string GetFibonacciSeries(int n)
        {
            // Guard clause: Validates that input is non-negative
            // Example: GetFibonacciSeries(-1) will throw an exception
            if (n < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }

            // Initialize list to store the Fibonacci series
            // Example: For n=4, will contain [0, 1, 1, 2, 3]
            List<int> series = new List<int>();

            // Base case 1: F(0) = 0
            // Example: GetFibonacciSeries(0) returns "0"
            if (n >= 0)
            {
                series.Add(0);
            }

            // Base case 2: F(1) = 1
            // Example: GetFibonacciSeries(1) returns "0, 1"
            if (n >= 1)
            {
                series.Add(1);
            }

            // Return early if n <= 1, as the series is complete
            if (n <= 1)
            {
                Console.WriteLine($"Fibonacci series from F(0) to F({n}): {string.Join(", ", series)}");
                return string.Join(", ", series);
            }

            // Variable 'a': Tracks F(i-2), initialized to F(0) = 0
            // Example: When calculating F(2), 'a' starts as 0
            int a = 0;

            // Variable 'b': Tracks F(i-1), initialized to F(1) = 1
            // Example: When calculating F(2), 'b' starts as 1
            int b = 1;

            // Loop: Iterates from position 2 to n, building up the sequence
            // Example: For GetFibonacciSeries(4), loop runs with i = 2, 3, 4
            for (int i = 2; i <= n; i++)
            {
                // Calculate current Fibonacci: F(i) = F(i-1) + F(i-2)
                // Example: F(2) = 1 + 0 = 1, F(3) = 1 + 1 = 2, F(4) = 2 + 1 = 3
                int fib = a + b;

                // Add the current Fibonacci number to the series
                // Example: After calculating F(2) = 1, series becomes [0, 1, 1]
                series.Add(fib);

                // Shift window: Move 'a' forward to the previous 'b' value
                // Example: After F(2), a becomes 1 (was 0)
                a = b;

                // Shift window: Move 'b' forward to the just-calculated 'fib' value
                // Example: After F(2), b becomes 1 (the result of F(2))
                b = fib;
            }

            Console.WriteLine($"Fibonacci series from F(0) to F({n}): {string.Join(", ", series)}");
            // Return the complete Fibonacci series from F(0) to F(n)
            // Example: GetFibonacciSeries(4) returns "0, 1, 1, 2, 3"
            return string.Join(", ", series);
        }
    }
}