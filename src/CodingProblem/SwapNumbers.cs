namespace CodingProblem
{
    internal class SwapNumbers
    {
        // Write a function that swaps two numbers without using a temporary variable.
        public static void SwapNumbersDemo()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }

        // The 'ref' keyword means we're passing by reference - changes to 'a' and 'b' 
        // will directly modify the original variables passed from the caller
        public static void Swap(ref int a, ref int b)
        {
            // Example: if a = 5 and b = 10
    
            // Step 1: Store the sum of both numbers in 'a'
            // a becomes 15 (5 + 10)
            // This preserves information about both original values in a single variable
            a = a + b;  // a = 15, b = 10
    
            // Step 2: Extract the original value of 'a' and store it in 'b'
            // We subtract the original 'b' from the sum stored in 'a'
            // b becomes 5 (15 - 10 = original a)
            b = a - b;  // a = 15, b = 5
    
            // Step 3: Extract the original value of 'b' and store it in 'a'
            // We subtract the new 'b' (which is original 'a') from the sum
            // a becomes 10 (15 - 5 = original b)
            a = a - b;  // a = 10, b = 5
    
            // Result: Values are swapped! a = 10, b = 5
            // No temporary variable was used, but this approach can cause integer overflow
            // if a + b exceeds int.MaxValue (2,147,483,647)
        }
    }
}
