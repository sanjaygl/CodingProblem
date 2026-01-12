using System.Text.RegularExpressions;

namespace CodingProblem
{
    internal class Palindrome
    {
        //A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
        public static bool IsPalindrome(string s)
        {
            string input = Regex
                .Replace(s, "[^a-zA-Z0-9]", "")
                .ToLower();

            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;

                }
                left++;
                right--;
            }
            return true;
        }

        // Given a string s, return true if the s can be palindrome after deleting at most one character from it.
        public static bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return IsPalindromeRange(s, left + 1, right) || IsPalindromeRange(s, left, right - 1);
                }
                left++;
                right--;
            }
            return true;
        }

        private static bool IsPalindromeRange(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        // Using built-in functions
        public static bool IsPalindromeBuiltIn(string s)
        {
            string input = Regex
                .Replace(s, "[^a-zA-Z0-9]", "")
                .ToLower();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return input == reversed;
        }

        // Using LINQ
        public static bool IsPalindromeLinq(string s)
        {
            string reversed = new string(s.Reverse().ToArray());
            return s.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}