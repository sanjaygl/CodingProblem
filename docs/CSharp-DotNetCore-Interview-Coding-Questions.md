# C# / .NET Core – Must-Know Coding Questions ??

## 1?? Collections & LINQ (VERY COMMON)

### Remove duplicates from a list while preserving order

**Problem:** Remove duplicate elements from a list while maintaining the original order of elements.

**Solution:**

```csharp
// Method 1: Using Distinct()
public List<int> RemoveDuplicatesDistinct(List<int> numbers)
{
    return numbers.Distinct().ToList();
}

// Method 2: Using HashSet (preserves order)
public List<int> RemoveDuplicatesHashSet(List<int> numbers)
{
    HashSet<int> seen = new HashSet<int>();
    List<int> result = new List<int>();
    
    foreach (var num in numbers)
    {
        if (seen.Add(num)) // Add returns false if element exists
        {
            result.Add(num);
        }
    }
    
    return result;
}

// Method 3: Using GroupBy (preserves order)
public List<int> RemoveDuplicatesGroupBy(List<int> numbers)
{
    return numbers.GroupBy(x => x)
                  .Select(g => g.First())
                  .ToList();
}

// Example usage
var numbers = new List<int> { 1, 2, 3, 2, 4, 1, 5 };
var result = RemoveDuplicatesDistinct(numbers);
// Result: [1, 2, 3, 4, 5]
```

**Performance Notes:**
- `Distinct()`: O(n), best for simple scenarios
- `HashSet`: O(n), most efficient for large datasets
- `GroupBy`: O(n log n), readable but slower

---

### Find second highest number from an array

**Problem:** Find the second largest number in an array.

**Solution:**

```csharp
// Method 1: Using LINQ (Simple but not optimal)
public int SecondHighestLINQ(int[] numbers)
{
    return numbers.Distinct()
                  .OrderByDescending(x => x)
                  .Skip(1)
                  .First();
}

// Method 2: Single pass (Optimal - O(n))
public int SecondHighestOptimal(int[] numbers)
{
    if (numbers.Length < 2)
        throw new ArgumentException("Array must have at least 2 elements");
    
    int highest = int.MinValue;
    int secondHighest = int.MinValue;
    
    foreach (var num in numbers)
    {
        if (num > highest)
        {
            secondHighest = highest;
            highest = num;
        }
        else if (num > secondHighest && num != highest)
        {
            secondHighest = num;
        }
    }
    
    if (secondHighest == int.MinValue)
        throw new InvalidOperationException("No second highest element found");
    
    return secondHighest;
}

// Method 3: Using Take and Skip
public int SecondHighestTake(int[] numbers)
{
    return numbers.Distinct()
                  .OrderByDescending(x => x)
                  .ElementAt(1);
}

// Example usage
var numbers = new[] { 5, 2, 9, 1, 9, 6 };
var result = SecondHighestOptimal(numbers);
// Result: 6
```

**Edge Cases to Handle:**
- Array with less than 2 elements
- All elements are the same
- Array with duplicates

---

### Group objects using LINQ

**Problem:** Group a collection of objects by one or more properties.

**Solution:**

```csharp
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
    public string City { get; set; }
}

public class LinqGroupingExamples
{
    // Example 1: Simple grouping by single property
    public Dictionary<string, List<Employee>> GroupByDepartment(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Department)
                       .ToDictionary(g => g.Key, g => g.ToList());
    }
    
    // Example 2: Group and get count
    public Dictionary<string, int> GetDepartmentCounts(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Department)
                       .ToDictionary(g => g.Key, g => g.Count());
    }
    
    // Example 3: Group and aggregate
    public Dictionary<string, decimal> GetDepartmentAvgSalary(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Department)
                       .ToDictionary(g => g.Key, g => g.Average(e => e.Salary));
    }
    
    // Example 4: Multiple grouping
    public IEnumerable<IGrouping<string, IGrouping<string, Employee>>> 
        GroupByDepartmentAndCity(List<Employee> employees)
    {
        return employees.GroupBy(e => e.City)
                       .Select(cityGroup => cityGroup.GroupBy(e => e.Department))
                       .SelectMany(x => x);
    }
    
    // Example 5: Anonymous type grouping
    public var GroupByMultipleProperties(List<Employee> employees)
    {
        return employees.GroupBy(e => new { e.Department, e.City })
                       .Select(g => new
                       {
                           Department = g.Key.Department,
                           City = g.Key.City,
                           Count = g.Count(),
                           Employees = g.ToList()
                       });
    }
}

// Example usage
var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "John", Department = "IT", Salary = 75000, City = "NYC" },
    new Employee { Id = 2, Name = "Jane", Department = "HR", Salary = 65000, City = "LA" },
    new Employee { Id = 3, Name = "Bob", Department = "IT", Salary = 80000, City = "NYC" },
    new Employee { Id = 4, Name = "Alice", Department = "HR", Salary = 70000, City = "NYC" }
};

var groupedByDept = employees.GroupBy(e => e.Department)
                             .Select(g => new
                             {
                                 Department = g.Key,
                                 Count = g.Count(),
                                 AvgSalary = g.Average(e => e.Salary),
                                 Employees = g.ToList()
                             });
```

---

### Flatten nested collections

**Problem:** Convert nested collections into a single flat collection.

**Solution:**

```csharp
public class FlattenCollectionExamples
{
    // Example 1: Simple SelectMany
    public List<int> FlattenNestedList(List<List<int>> nestedList)
    {
        return nestedList.SelectMany(list => list).ToList();
    }
    
    // Example 2: Flatten with transformation
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> Items { get; set; }
    }
    
    public class OrderItem
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
    }
    
    public List<OrderItem> GetAllOrderItems(List<Order> orders)
    {
        return orders.SelectMany(o => o.Items).ToList();
    }
    
    // Example 3: Flatten with projection
    public List<string> GetAllProducts(List<Order> orders)
    {
        return orders.SelectMany(o => o.Items)
                    .Select(item => item.Product)
                    .Distinct()
                    .ToList();
    }
    
    // Example 4: Recursive flattening (tree structure)
    public class TreeNode
    {
        public int Value { get; set; }
        public List<TreeNode> Children { get; set; }
    }
    
    public List<int> FlattenTree(TreeNode root)
    {
        if (root == null)
            return new List<int>();
        
        var result = new List<int> { root.Value };
        
        if (root.Children != null)
        {
            foreach (var child in root.Children)
            {
                result.AddRange(FlattenTree(child));
            }
        }
        
        return result;
    }
    
    // Example 5: Flatten jagged array
    public int[] FlattenJaggedArray(int[][] jaggedArray)
    {
        return jaggedArray.SelectMany(arr => arr).ToArray();
    }
}

// Example usage
var nestedList = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5 },
    new List<int> { 6, 7, 8, 9 }
};

var flattened = nestedList.SelectMany(x => x).ToList();
// Result: [1, 2, 3, 4, 5, 6, 7, 8, 9]
```

---

### Convert List to Dictionary with duplicate keys handling

**Problem:** Convert a list to a dictionary while handling duplicate keys appropriately.

**Solution:**

```csharp
public class ListToDictionaryExamples
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
    
    // Method 1: Take first occurrence (using ToDictionary)
    public Dictionary<int, Product> ConvertTakeFirst(List<Product> products)
    {
        return products.GroupBy(p => p.Id)
                      .ToDictionary(g => g.Key, g => g.First());
    }
    
    // Method 2: Take last occurrence
    public Dictionary<int, Product> ConvertTakeLast(List<Product> products)
    {
        return products.GroupBy(p => p.Id)
                      .ToDictionary(g => g.Key, g => g.Last());
    }
    
    // Method 3: Group duplicates into list
    public Dictionary<string, List<Product>> GroupByCategory(List<Product> products)
    {
        return products.GroupBy(p => p.Category)
                      .ToDictionary(g => g.Key, g => g.ToList());
    }
    
    // Method 4: Manual handling with ContainsKey
    public Dictionary<int, Product> ConvertWithManualCheck(List<Product> products)
    {
        var dict = new Dictionary<int, Product>();
        
        foreach (var product in products)
        {
            if (!dict.ContainsKey(product.Id))
            {
                dict[product.Id] = product;
            }
            // Option: You can also overwrite or skip based on logic
            // dict[product.Id] = product; // This overwrites
        }
        
        return dict;
    }
    
    // Method 5: Using DistinctBy (C# 9+)
    public Dictionary<int, Product> ConvertDistinctBy(List<Product> products)
    {
        return products.DistinctBy(p => p.Id)
                      .ToDictionary(p => p.Id);
    }
    
    // Method 6: Aggregate duplicates
    public Dictionary<string, int> CountByCategory(List<Product> products)
    {
        return products.GroupBy(p => p.Category)
                      .ToDictionary(g => g.Key, g => g.Count());
    }
}

// Example usage
var products = new List<Product>
{
    new Product { Id = 1, Name = "Laptop", Category = "Electronics" },
    new Product { Id = 2, Name = "Mouse", Category = "Electronics" },
    new Product { Id = 1, Name = "Laptop Pro", Category = "Electronics" }, // Duplicate ID
    new Product { Id = 3, Name = "Desk", Category = "Furniture" }
};

// Handle duplicates by taking first
var dict = products.GroupBy(p => p.Id)
                  .ToDictionary(g => g.Key, g => g.First());
// Result: { 1: "Laptop", 2: "Mouse", 3: "Desk" }
```

---

## 2?? String Manipulation

### Reverse a string without built-in Reverse()

**Problem:** Reverse a string without using built-in Reverse() method.

**Solution:**

```csharp
public class StringReverseExamples
{
    // Method 1: Using char array and swap
    public string ReverseUsingArray(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
        
        char[] chars = input.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;
        
        while (left < right)
        {
            // Swap characters
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            
            left++;
            right--;
        }
        
        return new string(chars);
    }
    
    // Method 2: Using StringBuilder
    public string ReverseUsingStringBuilder(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
        
        StringBuilder sb = new StringBuilder();
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        
        return sb.ToString();
    }
    
    // Method 3: Using Stack
    public string ReverseUsingStack(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
        
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in input)
        {
            stack.Push(c);
        }
        
        StringBuilder sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }
        
        return sb.ToString();
    }
    
    // Method 4: Recursive approach
    public string ReverseRecursive(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length == 1)
            return input;
        
        return input[input.Length - 1] + ReverseRecursive(input.Substring(0, input.Length - 1));
    }
    
    // Method 5: Using Span<T> (Most efficient for .NET Core)
    public string ReverseUsingSpan(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
        
        Span<char> chars = stackalloc char[input.Length];
        input.AsSpan().CopyTo(chars);
        chars.Reverse();
        
        return new string(chars);
    }
}

// Example usage
var reverser = new StringReverseExamples();
string result = reverser.ReverseUsingArray("Hello World");
// Result: "dlroW olleH"
```

---

### Check palindrome

**Problem:** Check if a string is a palindrome (reads the same forward and backward).

**Solution:**

```csharp
public class PalindromeChecker
{
    // Method 1: Two pointer approach (Most efficient)
    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
        
        int left = 0;
        int right = input.Length - 1;
        
        while (left < right)
        {
            if (input[left] != input[right])
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }
    
    // Method 2: Reverse and compare
    public bool IsPalindromeReverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
        
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);
        
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
    
    // Method 3: LINQ approach
    public bool IsPalindromeLINQ(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
        
        return input.SequenceEqual(input.Reverse());
    }
    
    // Method 4: Ignore spaces and special characters
    public bool IsPalindromeAlphanumeric(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
        
        int left = 0;
        int right = input.Length - 1;
        
        while (left < right)
        {
            // Skip non-alphanumeric characters
            while (left < right && !char.IsLetterOrDigit(input[left]))
                left++;
            
            while (left < right && !char.IsLetterOrDigit(input[right]))
                right--;
            
            if (char.ToLower(input[left]) != char.ToLower(input[right]))
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }
    
    // Method 5: Using Span<T> (Performance optimized)
    public bool IsPalindromeSpan(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
        
        ReadOnlySpan<char> span = input.AsSpan();
        
        for (int i = 0; i < span.Length / 2; i++)
        {
            if (span[i] != span[span.Length - 1 - i])
                return false;
        }
        
        return true;
    }
}

// Example usage
var checker = new PalindromeChecker();
bool result1 = checker.IsPalindrome("racecar"); // true
bool result2 = checker.IsPalindrome("hello"); // false
bool result3 = checker.IsPalindromeAlphanumeric("A man, a plan, a canal: Panama"); // true
```

---

### Find first non-repeating character

**Problem:** Find the first character in a string that does not repeat.

**Solution:**

```csharp
public class FirstNonRepeatingCharFinder
{
    // Method 1: Using Dictionary (Two passes)
    public char? FindFirstNonRepeating(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
        
        // First pass: Count frequency
        var frequency = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }
        
        // Second pass: Find first with count 1
        foreach (char c in input)
        {
            if (frequency[c] == 1)
                return c;
        }
        
        return null;
    }
    
    // Method 2: Using LINQ
    public char? FindFirstNonRepeatingLINQ(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
        
        return input.GroupBy(c => c)
                   .Where(g => g.Count() == 1)
                   .Select(g => (char?)g.Key)
                   .FirstOrDefault();
    }
    
    // Method 3: Using Dictionary with index tracking
    public char? FindFirstNonRepeatingWithIndex(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
        
        var charIndex = new Dictionary<char, int>();
        var charCount = new Dictionary<char, int>();
        
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            
            if (!charIndex.ContainsKey(c))
            {
                charIndex[c] = i;
                charCount[c] = 1;
            }
            else
            {
                charCount[c]++;
            }
        }
        
        int minIndex = int.MaxValue;
        char? result = null;
        
        foreach (var kvp in charCount.Where(x => x.Value == 1))
        {
            if (charIndex[kvp.Key] < minIndex)
            {
                minIndex = charIndex[kvp.Key];
                result = kvp.Key;
            }
        }
        
        return result;
    }
    
    // Method 4: Single pass with ordered dictionary
    public char? FindFirstNonRepeatingOptimized(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
        
        var frequency = new Dictionary<char, int>();
        
        // Count frequencies
        foreach (char c in input)
        {
            frequency[c] = frequency.GetValueOrDefault(c, 0) + 1;
        }
        
        // Find first non-repeating
        foreach (char c in input)
        {
            if (frequency[c] == 1)
                return c;
        }
        
        return null;
    }
}

// Example usage
var finder = new FirstNonRepeatingCharFinder();
char? result1 = finder.FindFirstNonRepeating("leetcode"); // 'l'
char? result2 = finder.FindFirstNonRepeating("loveleetcode"); // 'v'
char? result3 = finder.FindFirstNonRepeating("aabb"); // null
```

---

### Count character frequency

**Problem:** Count the frequency of each character in a string.

**Solution:**

```csharp
public class CharacterFrequencyCounter
{
    // Method 1: Using Dictionary
    public Dictionary<char, int> CountFrequency(string input)
    {
        if (string.IsNullOrEmpty(input))
            return new Dictionary<char, int>();
        
        var frequency = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }
        
        return frequency;
    }
    
    // Method 2: Using LINQ GroupBy
    public Dictionary<char, int> CountFrequencyLINQ(string input)
    {
        if (string.IsNullOrEmpty(input))
            return new Dictionary<char, int>();
        
        return input.GroupBy(c => c)
                   .ToDictionary(g => g.Key, g => g.Count());
    }
    
    // Method 3: Using GetValueOrDefault (C# 9+)
    public Dictionary<char, int> CountFrequencyModern(string input)
    {
        if (string.IsNullOrEmpty(input))
            return new Dictionary<char, int>();
        
        var frequency = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            frequency[c] = frequency.GetValueOrDefault(c, 0) + 1;
        }
        
        return frequency;
    }
    
    // Method 4: Case-insensitive with filtering
    public Dictionary<char, int> CountLettersOnly(string input)
    {
        if (string.IsNullOrEmpty(input))
            return new Dictionary<char, int>();
        
        return input.Where(char.IsLetter)
                   .Select(char.ToLower)
                   .GroupBy(c => c)
                   .ToDictionary(g => g.Key, g => g.Count());
    }
    
    // Method 5: Using array for ASCII characters (Most efficient)
    public Dictionary<char, int> CountFrequencyArray(string input)
    {
        if (string.IsNullOrEmpty(input))
            return new Dictionary<char, int>();
        
        int[] counts = new int[256]; // For extended ASCII
        
        foreach (char c in input)
        {
            counts[c]++;
        }
        
        var result = new Dictionary<char, int>();
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                result[(char)i] = counts[i];
            }
        }
        
        return result;
    }
    
    // Method 6: Sorted by frequency
    public List<(char Character, int Count)> GetSortedFrequency(string input)
    {
        return input.GroupBy(c => c)
                   .Select(g => (Character: g.Key, Count: g.Count()))
                   .OrderByDescending(x => x.Count)
                   .ToList();
    }
}

// Example usage
var counter = new CharacterFrequencyCounter();
var frequency = counter.CountFrequencyLINQ("hello world");
// Result: { 'h':1, 'e':1, 'l':3, 'o':2, ' ':1, 'w':1, 'r':1, 'd':1 }

var sortedFreq = counter.GetSortedFrequency("hello");
// Result: [('l', 3), ('h', 1), ('e', 1), ('o', 1)]
```

---

## 3?? Date & Time

### Calculate age from DOB

**Problem:** Calculate a person's age from their date of birth.

**Solution:**

```csharp
public class AgeCalculator
{
    // Method 1: Accurate age calculation
    public int CalculateAge(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;
        
        // Subtract 1 if birthday hasn't occurred this year
        if (dateOfBirth.Date > today.AddYears(-age))
        {
            age--;
        }
        
        return age;
    }
    
    // Method 2: With validation
    public int CalculateAgeWithValidation(DateTime dateOfBirth)
    {
        if (dateOfBirth > DateTime.Today)
        {
            throw new ArgumentException("Date of birth cannot be in the future");
        }
        
        DateTime today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;
        
        if (today < dateOfBirth.AddYears(age))
        {
            age--;
        }
        
        return age;
    }
    
    // Method 3: Get age with months and days
    public (int Years, int Months, int Days) CalculateDetailedAge(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        
        int years = today.Year - dateOfBirth.Year;
        int months = today.Month - dateOfBirth.Month;
        int days = today.Day - dateOfBirth.Day;
        
        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(today.Year, today.Month == 1 ? 12 : today.Month - 1);
        }
        
        if (months < 0)
        {
            years--;
            months += 12;
        }
        
        return (years, months, days);
    }
    
    // Method 4: Age at specific date
    public int CalculateAgeAt(DateTime dateOfBirth, DateTime targetDate)
    {
        int age = targetDate.Year - dateOfBirth.Year;
        
        if (dateOfBirth.Date > targetDate.AddYears(-age))
        {
            age--;
        }
        
        return age;
    }
    
    // Method 5: Using TimeSpan (approximation)
    public int CalculateAgeApproximate(DateTime dateOfBirth)
    {
        TimeSpan span = DateTime.Today - dateOfBirth;
        return (int)(span.TotalDays / 365.25); // Account for leap years
    }
}

// Example usage
var calculator = new AgeCalculator();
var dob = new DateTime(1990, 5, 15);
int age = calculator.CalculateAge(dob);
// If today is 2024-01-10, age = 33

var detailedAge = calculator.CalculateDetailedAge(dob);
// Result: (33 years, 7 months, 26 days)
```

---

### Find overlapping date ranges

**Problem:** Check if two date ranges overlap.

**Solution:**

```csharp
public class DateRangeOverlap
{
    public class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        
        public DateRange(DateTime start, DateTime end)
        {
            if (start > end)
                throw new ArgumentException("Start date must be before end date");
            
            Start = start;
            End = end;
        }
    }
    
    // Method 1: Simple overlap check
    public bool IsOverlapping(DateRange range1, DateRange range2)
    {
        return range1.Start <= range2.End && range2.Start <= range1.End;
    }
    
    // Method 2: Get overlapping period
    public DateRange? GetOverlappingPeriod(DateRange range1, DateRange range2)
    {
        if (!IsOverlapping(range1, range2))
            return null;
        
        DateTime overlapStart = range1.Start > range2.Start ? range1.Start : range2.Start;
        DateTime overlapEnd = range1.End < range2.End ? range1.End : range2.End;
        
        return new DateRange(overlapStart, overlapEnd);
    }
    
    // Method 3: Find all overlapping ranges from a list
    public List<DateRange> FindAllOverlapping(List<DateRange> ranges, DateRange targetRange)
    {
        return ranges.Where(r => IsOverlapping(r, targetRange)).ToList();
    }
    
    // Method 4: Merge overlapping ranges
    public List<DateRange> MergeOverlappingRanges(List<DateRange> ranges)
    {
        if (ranges == null || ranges.Count == 0)
            return new List<DateRange>();
        
        // Sort by start date
        var sorted = ranges.OrderBy(r => r.Start).ToList();
        var merged = new List<DateRange> { sorted[0] };
        
        for (int i = 1; i < sorted.Count; i++)
        {
            var current = sorted[i];
            var last = merged[merged.Count - 1];
            
            if (current.Start <= last.End)
            {
                // Overlapping - merge
                last.End = current.End > last.End ? current.End : last.End;
            }
            else
            {
                // Not overlapping - add new range
                merged.Add(current);
            }
        }
        
        return merged;
    }
    
    // Method 5: Check if a date falls within range
    public bool IsDateInRange(DateTime date, DateRange range)
    {
        return date >= range.Start && date <= range.End;
    }
    
    // Method 6: Get overlap duration in days
    public int GetOverlapDays(DateRange range1, DateRange range2)
    {
        var overlap = GetOverlappingPeriod(range1, range2);
        
        if (overlap == null)
            return 0;
        
        return (overlap.End - overlap.Start).Days + 1;
    }
}

// Example usage
var checker = new DateRangeOverlap();
var range1 = new DateRangeOverlap.DateRange(
    new DateTime(2024, 1, 1),
    new DateTime(2024, 1, 15)
);
var range2 = new DateRangeOverlap.DateRange(
    new DateTime(2024, 1, 10),
    new DateTime(2024, 1, 20)
);

bool overlaps = checker.IsOverlapping(range1, range2); // true
var overlapPeriod = checker.GetOverlappingPeriod(range1, range2);
// Result: (2024-01-10 to 2024-01-15)
```

---

### Convert UTC to local time safely

**Problem:** Safely convert UTC time to local time and vice versa.

**Solution:**

```csharp
public class TimeZoneConverter
{
    // Method 1: UTC to Local (System timezone)
    public DateTime ConvertUtcToLocal(DateTime utcDateTime)
    {
        if (utcDateTime.Kind != DateTimeKind.Utc)
        {
            throw new ArgumentException("Input must be UTC time");
        }
        
        return utcDateTime.ToLocalTime();
    }
    
    // Method 2: UTC to specific timezone
    public DateTime ConvertUtcToTimeZone(DateTime utcDateTime, string timeZoneId)
    {
        if (utcDateTime.Kind != DateTimeKind.Utc)
        {
            utcDateTime = DateTime.SpecifyKind(utcDateTime, DateTimeKind.Utc);
        }
        
        TimeZoneInfo targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, targetTimeZone);
    }
    
    // Method 3: Local to UTC
    public DateTime ConvertLocalToUtc(DateTime localDateTime)
    {
        if (localDateTime.Kind == DateTimeKind.Utc)
        {
            return localDateTime;
        }
        
        return localDateTime.ToUniversalTime();
    }
    
    // Method 4: Convert between timezones
    public DateTime ConvertBetweenTimeZones(
        DateTime dateTime,
        string sourceTimeZoneId,
        string destinationTimeZoneId)
    {
        TimeZoneInfo sourceTimeZone = TimeZoneInfo.FindSystemTimeZoneById(sourceTimeZoneId);
        TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(destinationTimeZoneId);
        
        return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, destinationTimeZone);
    }
    
    // Method 5: Safe conversion with DateTimeOffset
    public DateTimeOffset ConvertToTimeZoneSafe(DateTimeOffset dateTimeOffset, string timeZoneId)
    {
        TimeZoneInfo targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTime(dateTimeOffset, targetTimeZone);
    }
    
    // Method 6: Get all available timezones
    public List<string> GetAvailableTimeZones()
    {
        return TimeZoneInfo.GetSystemTimeZones()
                          .Select(tz => $"{tz.Id} ({tz.DisplayName})")
                          .ToList();
    }
    
    // Method 7: Handle ambiguous times (DST)
    public DateTime ConvertWithDstHandling(DateTime localDateTime, string timeZoneId)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        
        if (timeZone.IsAmbiguousTime(localDateTime))
        {
            // During DST transition, time is ambiguous
            // Get the first occurrence (before DST ends)
            var offsets = timeZone.GetAmbiguousTimeOffsets(localDateTime);
            return new DateTimeOffset(localDateTime, offsets[0]).UtcDateTime;
        }
        
        if (timeZone.IsInvalidTime(localDateTime))
        {
            // Time doesn't exist (during DST start)
            throw new ArgumentException("Time is invalid due to DST transition");
        }
        
        return TimeZoneInfo.ConvertTimeToUtc(localDateTime, timeZone);
    }
}

// Example usage
var converter = new TimeZoneConverter();

// UTC to EST
DateTime utc = DateTime.UtcNow;
DateTime est = converter.ConvertUtcToTimeZone(utc, "Eastern Standard Time");

// Local to UTC
DateTime local = DateTime.Now;
DateTime utcFromLocal = converter.ConvertLocalToUtc(local);

// Between timezones
DateTime pst = new DateTime(2024, 1, 15, 10, 0, 0);
DateTime gmt = converter.ConvertBetweenTimeZones(
    pst,
    "Pacific Standard Time",
    "GMT Standard Time"
);

// Using DateTimeOffset (recommended for avoiding ambiguity)
DateTimeOffset now = DateTimeOffset.Now;
DateTimeOffset tokyo = converter.ConvertToTimeZoneSafe(now, "Tokyo Standard Time");

// Common TimeZone IDs:
// "Eastern Standard Time" - EST/EDT
// "Pacific Standard Time" - PST/PDT
// "UTC" - Coordinated Universal Time
// "GMT Standard Time" - GMT/BST
// "Tokyo Standard Time" - JST
```

---

## 4?? Multithreading & Async Programming

### Convert sync code to async

**Problem:** Convert synchronous code to asynchronous code properly.

**Solution:**

```csharp
public class SyncToAsyncExamples
{
    // Example 1: Simple conversion
    // BEFORE - Synchronous
    public int GetDataSync()
    {
        Thread.Sleep(1000); // Simulating work
        return 42;
    }
    
    // AFTER - Asynchronous
    public async Task<int> GetDataAsync()
    {
        await Task.Delay(1000); // Non-blocking wait
        return 42;
    }
    
    // Example 2: Database operation
    // BEFORE - Synchronous
    public List<string> GetUsersSync()
    {
        using (var connection = new SqlConnection("connectionString"))
        {
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Users", connection);
            var reader = command.ExecuteReader();
            
            var users = new List<string>();
            while (reader.Read())
            {
                users.Add(reader["Name"].ToString());
            }
            
            return users;
        }
    }
    
    // AFTER - Asynchronous
    public async Task<List<string>> GetUsersAsync()
    {
        using (var connection = new SqlConnection("connectionString"))
        {
            await connection.OpenAsync();
            var command = new SqlCommand("SELECT * FROM Users", connection);
            var reader = await command.ExecuteReaderAsync();
            
            var users = new List<string>();
            while (await reader.ReadAsync())
            {
                users.Add(reader["Name"].ToString());
            }
            
            return users;
        }
    }
    
    // Example 3: HTTP Call
    // BEFORE - Synchronous
    public string GetWebContentSync(string url)
    {
        using (var client = new WebClient())
        {
            return client.DownloadString(url);
        }
    }
    
    // AFTER - Asynchronous
    public async Task<string> GetWebContentAsync(string url)
    {
        using (var client = new HttpClient())
        {
            return await client.GetStringAsync(url);
        }
    }
    
    // Example 4: File I/O
    // BEFORE - Synchronous
    public string ReadFileSync(string path)
    {
        return File.ReadAllText(path);
    }
    
    // AFTER - Asynchronous
    public async Task<string> ReadFileAsync(string path)
    {
        return await File.ReadAllTextAsync(path);
    }
    
    // Example 5: Multiple async operations
    // BEFORE - Sequential synchronous
    public (int result1, int result2, int result3) GetMultipleResultsSync()
    {
        var result1 = GetDataSync();
        var result2 = GetDataSync();
        var result3 = GetDataSync();
        return (result1, result2, result3);
    }
    
    // AFTER - Parallel asynchronous
    public async Task<(int result1, int result2, int result3)> GetMultipleResultsAsync()
    {
        var task1 = GetDataAsync();
        var task2 = GetDataAsync();
        var task3 = GetDataAsync();
        
        await Task.WhenAll(task1, task2, task3);
        
        return (task1.Result, task2.Result, task3.Result);
    }
    
    // Example 6: Error handling
    // AFTER - With proper async error handling
    public async Task<string> GetDataWithErrorHandlingAsync()
    {
        try
        {
            return await GetWebContentAsync("https://api.example.com/data");
        }
        catch (HttpRequestException ex)
        {
            // Log error
            Console.WriteLine($"HTTP Error: {ex.Message}");
            throw;
        }
        catch (TaskCanceledException ex)
        {
            // Handle timeout
            Console.WriteLine($"Request timed out: {ex.Message}");
            throw;
        }
    }
}
```

---

### Difference between Task vs Thread

**Problem:** Understand and demonstrate the difference between Task and Thread.

**Solution:**

```csharp
public class TaskVsThreadExamples
{
    // Thread-based approach (Low-level)
    public void UsingThread()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine("Thread work completed");
        });
        
        thread.Start();
        thread.Join(); // Wait for completion
    }
    
    // Task-based approach (High-level, preferred)
    public async Task UsingTask()
    {
        await Task.Run(() =>
        {
            Console.WriteLine($"Task Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine("Task work completed");
        });
    }
    
    // Key Differences Demonstration
    public class ComparisonExamples
    {
        // 1. Return Values
        // Thread - Cannot return value directly
        public int ResultFromThread()
        {
            int result = 0;
            Thread thread = new Thread(() =>
            {
                result = PerformCalculation();
            });
            thread.Start();
            thread.Join();
            return result;
        }
        
        // Task - Can return value easily
        public async Task<int> ResultFromTask()
        {
            return await Task.Run(() => PerformCalculation());
        }
        
        // 2. Exception Handling
        // Thread - Exceptions need manual handling
        public void ThreadExceptionHandling()
        {
            Thread thread = new Thread(() =>
            {
                try
                {
                    throw new Exception("Thread exception");
                }
                catch (Exception ex)
                {
                    // Must handle here or exception is lost
                    Console.WriteLine(ex.Message);
                }
            });
            thread.Start();
        }
        
        // Task - Exceptions are propagated
        public async Task TaskExceptionHandling()
        {
            try
            {
                await Task.Run(() =>
                {
                    throw new Exception("Task exception");
                });
            }
            catch (Exception ex)
            {
                // Exception is caught here automatically
                Console.WriteLine(ex.Message);
            }
        }
        
        // 3. Cancellation
        // Task - Built-in cancellation support
        public async Task TaskWithCancellation(CancellationToken cancellationToken)
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    await Task.Delay(100);
                    Console.WriteLine($"Iteration {i}");
                }
            }, cancellationToken);
        }
        
        // Thread - Manual cancellation handling
        public void ThreadWithCancellation()
        {
            bool shouldStop = false;
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (shouldStop) break;
                    Thread.Sleep(100);
                    Console.WriteLine($"Iteration {i}");
                }
            });
            thread.Start();
            
            // Later: shouldStop = true;
        }
        
        // 4. Thread Pool Usage
        // Thread - Creates new OS thread (expensive)
        public void CreateNewThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(() => DoWork());
                thread.Start(); // Each creates a new thread
            }
        }
        
        // Task - Uses thread pool (efficient)
        public void CreateTasks()
        {
            var tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() => DoWork())); // Reuses threads from pool
            }
            Task.WaitAll(tasks.ToArray());
        }
        
        // 5. Continuation
        // Task - Easy chaining
        public async Task TaskContinuation()
        {
            var result = await Task.Run(() => PerformCalculation())
                                  .ContinueWith(task => task.Result * 2)
                                  .ContinueWith(task => task.Result + 10);
            
            Console.WriteLine($"Final result: {result}");
        }
        
        // Thread - Complex chaining
        public void ThreadContinuation()
        {
            int result = 0;
            Thread thread1 = new Thread(() => result = PerformCalculation());
            thread1.Start();
            thread1.Join();
            
            Thread thread2 = new Thread(() => result = result * 2);
            thread2.Start();
            thread2.Join();
            
            Console.WriteLine($"Final result: {result}");
        }
        
        private int PerformCalculation() => 42;
        private void DoWork() { Thread.Sleep(100); }
    }
    
    // When to use what?
    public class BestPractices
    {
        // Use Task when:
        // - Doing I/O-bound operations
        // - Need to return values
        // - Want built-in cancellation
        // - Need continuation support
        // - Working with async/await
        
        public async Task<string> IoOperation()
        {
            return await File.ReadAllTextAsync("file.txt");
        }
        
        // Use Thread when:
        // - Need fine-grained control
        // - Long-running CPU-bound operations
        // - Need specific thread priority
        // - Need apartment state (STA/MTA)
        
        public void LongRunningOperation()
        {
            Thread thread = new Thread(() =>
            {
                // Very long running operation
                while (true)
                {
                    // Do work
                }
            });
            
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();
        }
    }
}

// Summary:
// Task: High-level, part of TPL, uses thread pool, better for async/await
// Thread: Low-level, creates OS thread, more control but more overhead
```

---

### What happens if you don't await?

**Problem:** Understand what happens when you don't await an async method.

**Solution:**

```csharp
public class NotAwaitingExamples
{
    // Example 1: Fire and forget (dangerous)
    public void NotAwaiting_FireAndForget()
    {
        // This returns immediately, doesn't wait for completion
        GetDataAsync(); // Warning: CS4014
        
        Console.WriteLine("This runs immediately");
        // GetDataAsync might still be running or might not even start
    }
    
    public async Task<int> GetDataAsync()
    {
        await Task.Delay(1000);
        return 42;
    }
    
    // Example 2: Consequences of not awaiting
    public class NotAwaitingConsequences
    {
        private int result = 0;
        
        // WRONG - Race condition
        public void UpdateResultWrong()
        {
            UpdateDataAsync(); // Not awaited
            Console.WriteLine($"Result: {result}"); // Might print 0
        }
        
        // CORRECT - Properly awaited
        public async Task UpdateResultCorrect()
        {
            await UpdateDataAsync(); // Awaited
            Console.WriteLine($"Result: {result}"); // Will print 100
        }
        
        private async Task UpdateDataAsync()
        {
            await Task.Delay(100);
            result = 100;
        }
    }
    
    // Example 3: Exception handling
    public class ExceptionHandling
    {
        // WRONG - Exception is lost
        public void CallAsyncWithoutAwait()
        {
            try
            {
                ThrowExceptionAsync(); // Not awaited
                Console.WriteLine("No exception caught");
            }
            catch (Exception ex)
            {
                // Never executes!
                Console.WriteLine($"Caught: {ex.Message}");
            }
        }
        
        // CORRECT - Exception is caught
        public async Task CallAsyncWithAwait()
        {
            try
            {
                await ThrowExceptionAsync(); // Awaited
            }
            catch (Exception ex)
            {
                // Executes correctly
                Console.WriteLine($"Caught: {ex.Message}");
            }
        }
        
        private async Task ThrowExceptionAsync()
        {
            await Task.Delay(100);
            throw new Exception("Async exception");
        }
    }
    
    // Example 4: When fire-and-forget is acceptable
    public class ValidFireAndForget
    {
        // Use Task.Run for intentional fire-and-forget
        public void ValidFireAndForget()
        {
            _ = Task.Run(async () =>
            {
                await LogAsync("Background logging");
            });
        }
        
        // Or create explicit method
        public void FireAndForgetWithHandling()
        {
            _ = LogWithErrorHandlingAsync("Important log");
        }
        
        private async Task LogWithErrorHandlingAsync(string message)
        {
            try
            {
                await LogAsync(message);
            }
            catch (Exception ex)
            {
                // Handle error internally
                Console.WriteLine($"Logging failed: {ex.Message}");
            }
        }
        
        private async Task LogAsync(string message)
        {
            await Task.Delay(10);
            Console.WriteLine(message);
        }
    }
    
    // Example 5: Deadlock scenarios
    public class DeadlockExample
    {
        // WRONG - Can cause deadlock in some contexts
        public void PotentialDeadlock()
        {
            var task = GetDataAsync();
            int result = task.Result; // Blocks thread, can deadlock
        }
        
        // CORRECT - Async all the way
        public async Task<int> CorrectAsyncFlow()
        {
            return await GetDataAsync();
        }
        
        // CORRECT - If you must block (not recommended)
        public int BlockCorrectly()
        {
            return Task.Run(async () => await GetDataAsync()).Result;
        }
    }
    
    // Example 6: Proper patterns
    public class ProperPatterns
    {
        // Pattern 1: Async void for event handlers only
        private async void Button_Click(object sender, EventArgs e)
        {
            await ProcessClickAsync();
        }
        
        // Pattern 2: Return Task for other methods
        private async Task ProcessClickAsync()
        {
            await GetDataAsync();
        }
        
        // Pattern 3: ConfigureAwait for library code
        public async Task<string> LibraryMethodAsync()
        {
            var data = await GetDataAsync().ConfigureAwait(false);
            return data.ToString();
        }
        
        // Pattern 4: ValueTask for frequently called methods
        public async ValueTask<int> GetCachedDataAsync()
        {
            if (_cache != null)
                return _cache.Value; // Synchronous path
            
            _cache = await GetDataAsync(); // Asynchronous path
            return _cache.Value;
        }
        
        private int? _cache;
    }
    
    // Summary of consequences:
    public class Consequences
    {
        /*
         * NOT AWAITING CAUSES:
         * 
         * 1. Race Conditions - Code continues before async completes
         * 2. Lost Exceptions - Exceptions thrown in async method are not caught
         * 3. Resource Leaks - Resources may not be disposed properly
         * 4. Unpredictable Behavior - Order of execution is uncertain
         * 5. Debugging Difficulty - Hard to track when/if code executes
         * 
         * BEST PRACTICES:
         * 
         * 1. Always await async methods (unless intentional fire-and-forget)
         * 2. Use async Task, not async void (except event handlers)
         * 3. Don't mix sync and async code (.Result, .Wait())
         * 4. Use ConfigureAwait(false) in library code
         * 5. Use _ = Task.Run() for intentional fire-and-forget
         */
    }
}
```

---

## 5?? Thread Safety

### Singleton thread-safe implementation

**Problem:** Implement a thread-safe Singleton pattern.

**Solution:**

```csharp
// Method 1: Lazy<T> (Recommended - Simple and thread-safe)
public sealed class SingletonLazy
{
    private static readonly Lazy<SingletonLazy> _instance = 
        new Lazy<SingletonLazy>(() => new SingletonLazy());
    
    private SingletonLazy()
    {
        // Private constructor
    }
    
    public static SingletonLazy Instance => _instance.Value;
    
    public void DoSomething()
    {
        Console.WriteLine("Singleton method called");
    }
}

// Method 2: Double-Check Locking (Classic approach)
public sealed class SingletonDoubleCheck
{
    private static SingletonDoubleCheck _instance;
    private static readonly object _lock = new object();
    
    private SingletonDoubleCheck()
    {
    }
    
    public static SingletonDoubleCheck Instance
    {
        get
        {
            if (_instance == null) // First check (no lock)
            {
                lock (_lock)
                {
                    if (_instance == null) // Second check (with lock)
                    {
                        _instance = new SingletonDoubleCheck();
                    }
                }
            }
            return _instance;
        }
    }
}

// Method 3: Static Constructor (Thread-safe by CLR)
public sealed class SingletonStatic
{
    private static readonly SingletonStatic _instance = new SingletonStatic();
    
    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static SingletonStatic()
    {
    }
    
    private SingletonStatic()
    {
    }
    
    public static SingletonStatic Instance => _instance;
}

// Method 4: Nested Class (Lazy initialization)
public sealed class SingletonNested
{
    private SingletonNested()
    {
    }
    
    public static SingletonNested Instance => Nested._instance;
    
    private class Nested
    {
        // Explicit static constructor
        static Nested()
        {
        }
        
        internal static readonly SingletonNested _instance = new SingletonNested();
    }
}

// Method 5: With Dependency Injection (Modern approach)
public class SingletonDI
{
    public void DoWork()
    {
        Console.WriteLine("DI Singleton work");
    }
}

// In Startup.cs or Program.cs
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<SingletonDI>();
    }
}

// Method 6: Thread-safe with state
public sealed class SingletonWithState
{
    private static readonly Lazy<SingletonWithState> _instance = 
        new Lazy<SingletonWithState>(() => new SingletonWithState());
    
    private readonly ConcurrentDictionary<string, int> _cache = new();
    
    private SingletonWithState()
    {
    }
    
    public static SingletonWithState Instance => _instance.Value;
    
    public void AddToCache(string key, int value)
    {
        _cache.TryAdd(key, value);
    }
    
    public int GetFromCache(string key)
    {
        return _cache.TryGetValue(key, out int value) ? value : 0;
    }
}

// Example usage and comparison
public class SingletonComparison
{
    public void CompareSingletons()
    {
        // All these are thread-safe
        var lazy = SingletonLazy.Instance;
        var doubleCheck = SingletonDoubleCheck.Instance;
        var staticCtor = SingletonStatic.Instance;
        var nested = SingletonNested.Instance;
        
        // Test thread safety
        Parallel.For(0, 1000, i =>
        {
            var instance = SingletonLazy.Instance;
            instance.DoSomething();
        });
    }
}

/*
 * COMPARISON:
 * 
 * Lazy<T>: ? Simple, ? Thread-safe, ? Lazy initialization, ? RECOMMENDED
 * Double-Check: ? Thread-safe, ?? Complex, ?? Can be error-prone
 * Static Constructor: ? Thread-safe, ?? Eager initialization, ? Simple
 * Nested Class: ? Thread-safe, ? Lazy initialization, ?? Complex
 * DI: ? Thread-safe, ? Testable, ? Modern, ? BEST for .NET Core
 */
```

---

### Use of lock, SemaphoreSlim, ConcurrentDictionary

**Problem:** Demonstrate thread-safe synchronization mechanisms.

**Solution:**

```csharp
public class ThreadSafetySynchronization
{
    // 1. LOCK - Basic synchronization
    public class LockExample
    {
        private readonly object _lock = new object();
        private int _counter = 0;
        
        // Thread-safe increment
        public void Increment()
        {
            lock (_lock)
            {
                _counter++;
            }
        }
        
        public int GetCounter()
        {
            lock (_lock)
            {
                return _counter;
            }
        }
        
        // Multiple operations in critical section
        public void UpdateMultipleFields()
        {
            lock (_lock)
            {
                // All operations are atomic together
                _counter++;
                ProcessData();
                SaveData();
            }
        }
        
        private void ProcessData() { }
        private void SaveData() { }
    }
    
    // 2. SEMAPHORESLIM - Async-friendly synchronization
    public class SemaphoreSlimExample
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        
        // Async thread-safe method
        public async Task<string> GetDataAsync()
        {
            await _semaphore.WaitAsync();
            try
            {
                // Critical section
                await Task.Delay(100); // Simulate async work
                return "Data";
            }
            finally
            {
                _semaphore.Release();
            }
        }
        
        // Limit concurrent access (e.g., max 3 concurrent)
        private readonly SemaphoreSlim _throttle = new SemaphoreSlim(3, 3);
        
        public async Task ProcessWithThrottlingAsync(int id)
        {
            await _throttle.WaitAsync();
            try
            {
                Console.WriteLine($"Processing {id}");
                await Task.Delay(1000);
                Console.WriteLine($"Completed {id}");
            }
            finally
            {
                _throttle.Release();
            }
        }
        
        // With timeout
        public async Task<bool> TryGetDataWithTimeoutAsync()
        {
            if (await _semaphore.WaitAsync(TimeSpan.FromSeconds(5)))
            {
                try
                {
                    // Got the lock
                    await Task.Delay(100);
                    return true;
                }
                finally
                {
                    _semaphore.Release();
                }
            }
            
            // Timeout occurred
            return false;
        }
    }
    
    // 3. CONCURRENTDICTIONARY - Lock-free thread-safe collection
    public class ConcurrentDictionaryExample
    {
        private readonly ConcurrentDictionary<string, int> _cache = new();
        
        // Add or update
        public void AddOrUpdate(string key, int value)
        {
            _cache.AddOrUpdate(
                key,
                value, // Add value
                (k, oldValue) => oldValue + value // Update function
            );
        }
        
        // Get or add
        public int GetOrAdd(string key)
        {
            return _cache.GetOrAdd(key, k => ComputeValue(k));
        }
        
        // Try add
        public bool TryAdd(string key, int value)
        {
            return _cache.TryAdd(key, value);
        }
        
        // Try get
        public bool TryGet(string key, out int value)
        {
            return _cache.TryGetValue(key, out value);
        }
        
        // Try remove
        public bool TryRemove(string key)
        {
            return _cache.TryRemove(key, out _);
        }
        
        // Try update
        public bool TryUpdate(string key, int newValue, int expectedValue)
        {
            return _cache.TryUpdate(key, newValue, expectedValue);
        }
        
        // Complex operation with GetOrAdd
        public UserData GetOrCreateUser(string userId)
        {
            return _userCache.GetOrAdd(userId, id =>
            {
                // This factory is executed only once per key
                var user = LoadUserFromDatabase(id);
                return user;
            });
        }
        
        private readonly ConcurrentDictionary<string, UserData> _userCache = new();
        
        private int ComputeValue(string key) => key.Length;
        private UserData LoadUserFromDatabase(string id) => new UserData();
    }
    
    public class UserData { }
    
    // 4. Comparison and when to use each
    public class SynchronizationComparison
    {
        private readonly object _lock = new object();
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);
        private readonly ConcurrentDictionary<string, int> _dict = new();
        
        // Use LOCK for:
        // - Simple synchronous operations
        // - Small critical sections
        // - When you don't need async
        public void UseLock()
        {
            lock (_lock)
            {
                // Quick synchronous operation
                var result = ComputeSync();
            }
        }
        
        // Use SEMAPHORESLIM for:
        // - Async operations
        // - Need cancellation support
        // - Throttling (limiting concurrent access)
        public async Task UseSemaphore()
        {
            await _semaphore.WaitAsync();
            try
            {
                // Async operation
                await ComputeAsync();
            }
            finally
            {
                _semaphore.Release();
            }
        }
        
        // Use CONCURRENTDICTIONARY for:
        // - Thread-safe dictionary operations
        // - High-performance scenarios
        // - When you don't need to synchronize multiple operations
        public void UseConcurrentDictionary()
        {
            // Lock-free operations
            _dict.TryAdd("key", 1);
            _dict.TryGetValue("key", out int value);
        }
        
        private int ComputeSync() => 42;
        private async Task<int> ComputeAsync()
        {
            await Task.Delay(10);
            return 42;
        }
    }
    
    // 5. Real-world example combining all three
    public class CacheManager
    {
        private readonly ConcurrentDictionary<string, CacheEntry> _cache = new();
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);
        
        public async Task<string> GetOrAddAsync(string key)
        {
            // Try get from cache (lock-free)
            if (_cache.TryGetValue(key, out var entry))
            {
                return entry.Value;
            }
            
            // Use semaphore to ensure only one thread loads data
            await _semaphore.WaitAsync();
            try
            {
                // Double-check inside lock
                if (_cache.TryGetValue(key, out entry))
                {
                    return entry.Value;
                }
                
                // Load data
                var value = await LoadDataAsync(key);
                
                // Add to cache
                _cache.TryAdd(key, new CacheEntry { Value = value });
                
                return value;
            }
            finally
            {
                _semaphore.Release();
            }
        }
        
        private async Task<string> LoadDataAsync(string key)
        {
            await Task.Delay(100);
            return $"Data for {key}";
        }
    }
    
    public class CacheEntry
    {
        public string Value { get; set; }
    }
}

/*
 * SUMMARY:
 * 
 * lock:
 * ? Simple, synchronous
 * ? Automatic release (no try-finally needed)
 * ? Not async-friendly
 * ? Can cause deadlocks
 * 
 * SemaphoreSlim:
 * ? Async-friendly (WaitAsync)
 * ? Supports cancellation
 * ? Can limit concurrent access (throttling)
 * ?? Must manually release (use try-finally)
 * 
 * ConcurrentDictionary:
 * ? Lock-free (better performance)
 * ? Thread-safe by design
 * ? Atomic operations (AddOrUpdate, GetOrAdd)
 * ? Only for dictionary operations
 * ? Cannot synchronize multiple operations atomically
 */
```

---

## 6?? Object-Oriented Design

### Implement Factory Pattern

**Problem:** Implement the Factory design pattern.

**Solution:**

```csharp
// Factory Pattern Implementation

// 1. SIMPLE FACTORY
public class SimpleFactoryExample
{
    // Product interface
    public interface IPayment
    {
        void Pay(decimal amount);
        string GetPaymentType();
    }
    
    // Concrete products
    public class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} using Credit Card");
        }
        
        public string GetPaymentType() => "Credit Card";
    }
    
    public class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} using PayPal");
        }
        
        public string GetPaymentType() => "PayPal";
    }
    
    public class BitcoinPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} using Bitcoin");
        }
        
        public string GetPaymentType() => "Bitcoin";
    }
    
    // Simple Factory
    public class PaymentFactory
    {
        public IPayment CreatePayment(string type)
        {
            return type.ToLower() switch
            {
                "creditcard" => new CreditCardPayment(),
                "paypal" => new PayPalPayment(),
                "bitcoin" => new BitcoinPayment(),
                _ => throw new ArgumentException($"Unknown payment type: {type}")
            };
        }
    }
}

// 2. FACTORY METHOD PATTERN
public class FactoryMethodExample
{
    // Product interface
    public interface INotification
    {
        void Send(string message);
    }
    
    // Concrete products
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
    
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
    
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push notification sent: {message}");
        }
    }
    
    // Creator abstract class
    public abstract class NotificationService
    {
        // Factory method
        public abstract INotification CreateNotification();
        
        // Template method using factory method
        public void Notify(string message)
        {
            var notification = CreateNotification();
            notification.Send(message);
        }
    }
    
    // Concrete creators
    public class EmailNotificationService : NotificationService
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
    
    public class SmsNotificationService : NotificationService
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}

// 3. ABSTRACT FACTORY PATTERN
public class AbstractFactoryExample
{
    // Abstract products
    public interface IButton
    {
        void Render();
    }
    
    public interface ICheckbox
    {
        void Render();
    }
    
    // Windows products
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows button");
        }
    }
    
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows checkbox");
        }
    }
    
    // Mac products
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac button");
        }
    }
    
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac checkbox");
        }
    }
    
    // Abstract factory
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
    
    // Concrete factories
    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
    
    public class MacFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
    
    // Client code
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;
        
        public Application(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }
        
        public void Render()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
}

// 4. REAL-WORLD EXAMPLE - Database Connection Factory
public class DatabaseFactoryExample
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
        void Disconnect();
    }
    
    public class SqlServerDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connected to SQL Server");
        }
        
        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing on SQL Server: {query}");
        }
        
        public void Disconnect()
        {
            Console.WriteLine("Disconnected from SQL Server");
        }
    }
    
    public class PostgreSqlDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connected to PostgreSQL");
        }
        
        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing on PostgreSQL: {query}");
        }
        
        public void Disconnect()
        {
            Console.WriteLine("Disconnected from PostgreSQL");
        }
    }
    
    public class MongoDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connected to MongoDB");
        }
        
        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing on MongoDB: {query}");
        }
        
        public void Disconnect()
        {
            Console.WriteLine("Disconnected from MongoDB");
        }
    }
    
    public class DatabaseFactory
    {
        public static IDatabase CreateDatabase(string dbType, string connectionString)
        {
            return dbType.ToLower() switch
            {
                "sqlserver" => new SqlServerDatabase(),
                "postgresql" => new PostgreSqlDatabase(),
                "mongodb" => new MongoDatabase(),
                _ => throw new ArgumentException($"Unsupported database type: {dbType}")
            };
        }
    }
}

// Example Usage
public class FactoryPatternUsage
{
    public void DemonstratePatterns()
    {
        // 1. Simple Factory
        var paymentFactory = new SimpleFactoryExample.PaymentFactory();
        var payment = paymentFactory.CreatePayment("creditcard");
        payment.Pay(100.50m);
        
        // 2. Factory Method
        FactoryMethodExample.NotificationService emailService = 
            new FactoryMethodExample.EmailNotificationService();
        emailService.Notify("Hello via Email");
        
        // 3. Abstract Factory
        var windowsFactory = new AbstractFactoryExample.WindowsFactory();
        var app = new AbstractFactoryExample.Application(windowsFactory);
        app.Render();
        
        // 4. Database Factory
        var db = DatabaseFactoryExample.DatabaseFactory.CreateDatabase(
            "sqlserver",
            "connectionString"
        );
        db.Connect();
        db.ExecuteQuery("SELECT * FROM Users");
        db.Disconnect();
    }
}

/*
 * WHEN TO USE:
 * 
 * Simple Factory:
 * - When you have a simple creation logic
 * - Small number of product types
 * - Creation logic won't change frequently
 * 
 * Factory Method:
 * - When subclasses need to decide which class to instantiate
 * - When creation logic is complex
 * - When you want to delegate object creation to subclasses
 * 
 * Abstract Factory:
 * - When you need to create families of related objects
 * - When you want to ensure objects are compatible
 * - When you need to switch between families of products
 */
```

---

### Strategy Pattern use case

**Problem:** Implement the Strategy design pattern.

**Solution:**

```csharp
// Strategy Pattern Implementation

// 1. BASIC STRATEGY PATTERN
public class BasicStrategyExample
{
    // Strategy interface
    public interface ISortStrategy
    {
        void Sort(int[] array);
    }
    
    // Concrete strategies
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting using Bubble Sort");
            // Bubble sort implementation
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
    }
    
    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting using Quick Sort");
            QuickSort(array, 0, array.Length - 1);
        }
        
        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }
        
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
            
            (array[i + 1], array[high]) = (array[high], array[i + 1]);
            return i + 1;
        }
    }
    
    // Context
    public class SortContext
    {
        private ISortStrategy _strategy;
        
        public void SetStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public void Sort(int[] array)
        {
            _strategy?.Sort(array);
        }
    }
}

// 2. PAYMENT PROCESSING STRATEGY
public class PaymentStrategyExample
{
    // Strategy interface
    public interface IPaymentStrategy
    {
        bool ProcessPayment(decimal amount);
        string GetPaymentMethod();
    }
    
    // Concrete strategies
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private readonly string _cardNumber;
        private readonly string _cvv;
        
        public CreditCardPaymentStrategy(string cardNumber, string cvv)
        {
            _cardNumber = cardNumber;
            _cvv = cvv;
        }
        
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");
            Console.WriteLine($"Card: {_cardNumber.Substring(_cardNumber.Length - 4)}");
            // Process payment logic
            return true;
        }
        
        public string GetPaymentMethod() => "Credit Card";
    }
    
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        private readonly string _email;
        
        public PayPalPaymentStrategy(string email)
        {
            _email = email;
        }
        
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
            Console.WriteLine($"Email: {_email}");
            // Process payment logic
            return true;
        }
        
        public string GetPaymentMethod() => "PayPal";
    }
    
    public class BitcoinPaymentStrategy : IPaymentStrategy
    {
        private readonly string _walletAddress;
        
        public BitcoinPaymentStrategy(string walletAddress)
        {
            _walletAddress = walletAddress;
        }
        
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of ${amount}");
            Console.WriteLine($"Wallet: {_walletAddress}");
            // Process payment logic
            return true;
        }
        
        public string GetPaymentMethod() => "Bitcoin";
    }
    
    // Context
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;
        private decimal _total;
        
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }
        
        public void AddItem(decimal price)
        {
            _total += price;
        }
        
        public bool Checkout()
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Please select a payment method");
                return false;
            }
            
            Console.WriteLine($"Total amount: ${_total}");
            return _paymentStrategy.ProcessPayment(_total);
        }
    }
}

// 3. COMPRESSION STRATEGY
public class CompressionStrategyExample
{
    public interface ICompressionStrategy
    {
        byte[] Compress(byte[] data);
        byte[] Decompress(byte[] compressedData);
        string GetCompressionType();
    }
    
    public class ZipCompressionStrategy : ICompressionStrategy
    {
        public byte[] Compress(byte[] data)
        {
            Console.WriteLine("Compressing using ZIP");
            // ZIP compression logic
            return data;
        }
        
        public byte[] Decompress(byte[] compressedData)
        {
            Console.WriteLine("Decompressing ZIP");
            return compressedData;
        }
        
        public string GetCompressionType() => "ZIP";
    }
    
    public class RarCompressionStrategy : ICompressionStrategy
    {
        public byte[] Compress(byte[] data)
        {
            Console.WriteLine("Compressing using RAR");
            return data;
        }
        
        public byte[] Decompress(byte[] compressedData)
        {
            Console.WriteLine("Decompressing RAR");
            return compressedData;
        }
        
        public string GetCompressionType() => "RAR";
    }
    
    public class FileCompressor
    {
        private ICompressionStrategy _strategy;
        
        public void SetCompressionStrategy(ICompressionStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public byte[] CompressFile(byte[] fileData)
        {
            return _strategy.Compress(fileData);
        }
        
        public byte[] DecompressFile(byte[] compressedData)
        {
            return _strategy.Decompress(compressedData);
        }
    }
}

// 4. REAL-WORLD EXAMPLE - Shipping Calculator
public class ShippingStrategyExample
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(decimal weight, decimal distance);
        string GetShippingMethod();
        int GetEstimatedDays();
    }
    
    public class StandardShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(decimal weight, decimal distance)
        {
            return weight * 0.5m + distance * 0.1m;
        }
        
        public string GetShippingMethod() => "Standard Shipping";
        public int GetEstimatedDays() => 7;
    }
    
    public class ExpressShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(decimal weight, decimal distance)
        {
            return weight * 1.5m + distance * 0.3m;
        }
        
        public string GetShippingMethod() => "Express Shipping";
        public int GetEstimatedDays() => 2;
    }
    
    public class OvernightShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(decimal weight, decimal distance)
        {
            return weight * 3.0m + distance * 0.5m + 25m; // Base fee
        }
        
        public string GetShippingMethod() => "Overnight Shipping";
        public int GetEstimatedDays() => 1;
    }
    
    public class ShippingCalculator
    {
        private IShippingStrategy _strategy;
        
        public void SetShippingStrategy(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public decimal GetShippingCost(decimal weight, decimal distance)
        {
            if (_strategy == null)
                throw new InvalidOperationException("Shipping strategy not set");
            
            return _strategy.CalculateShippingCost(weight, distance);
        }
        
        public string GetShippingInfo()
        {
            return $"{_strategy.GetShippingMethod()} - " +
                   $"Estimated delivery: {_strategy.GetEstimatedDays()} days";
        }
    }
}

// 5. VALIDATION STRATEGY
public class ValidationStrategyExample
{
    public interface IValidationStrategy
    {
        bool Validate(string input);
        string GetErrorMessage();
    }
    
    public class EmailValidationStrategy : IValidationStrategy
    {
        public bool Validate(string input)
        {
            return !string.IsNullOrEmpty(input) && 
                   input.Contains("@") && 
                   input.Contains(".");
        }
        
        public string GetErrorMessage() => "Invalid email format";
    }
    
    public class PhoneValidationStrategy : IValidationStrategy
    {
        public bool Validate(string input)
        {
            return !string.IsNullOrEmpty(input) && 
                   input.Length >= 10 && 
                   input.All(char.IsDigit);
        }
        
        public string GetErrorMessage() => "Invalid phone number";
    }
    
    public class PasswordValidationStrategy : IValidationStrategy
    {
        public bool Validate(string input)
        {
            return !string.IsNullOrEmpty(input) &&
                   input.Length >= 8 &&
                   input.Any(char.IsUpper) &&
                   input.Any(char.IsLower) &&
                   input.Any(char.IsDigit);
        }
        
        public string GetErrorMessage() => 
            "Password must be at least 8 characters with uppercase, lowercase, and digit";
    }
    
    public class InputValidator
    {
        private IValidationStrategy _strategy;
        
        public void SetValidationStrategy(IValidationStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public (bool IsValid, string Message) Validate(string input)
        {
            bool isValid = _strategy.Validate(input);
            return (isValid, isValid ? "Valid" : _strategy.GetErrorMessage());
        }
    }
}

// Example Usage
public class StrategyPatternUsage
{
    public void DemonstrateStrategies()
    {
        // 1. Payment Strategy
        var cart = new PaymentStrategyExample.ShoppingCart();
        cart.AddItem(50.00m);
        cart.AddItem(30.00m);
        
        cart.SetPaymentStrategy(new PaymentStrategyExample.CreditCardPaymentStrategy(
            "1234-5678-9012-3456", "123"));
        cart.Checkout();
        
        // 2. Shipping Strategy
        var shippingCalc = new ShippingStrategyExample.ShippingCalculator();
        shippingCalc.SetShippingStrategy(
            new ShippingStrategyExample.ExpressShippingStrategy());
        var cost = shippingCalc.GetShippingCost(10, 100);
        Console.WriteLine($"Shipping cost: ${cost}");
        
        // 3. Validation Strategy
        var validator = new ValidationStrategyExample.InputValidator();
        validator.SetValidationStrategy(
            new ValidationStrategyExample.EmailValidationStrategy());
        var result = validator.Validate("test@example.com");
        Console.WriteLine($"Email validation: {result.Message}");
    }
}

/*
 * BENEFITS:
 * 
 * ? Open/Closed Principle - Open for extension, closed for modification
 * ? Single Responsibility - Each strategy has one job
 * ? Runtime flexibility - Can switch strategies at runtime
 * ? Eliminates conditional logic - No large if/switch statements
 * ? Testability - Each strategy can be tested independently
 * 
 * WHEN TO USE:
 * 
 * - When you have multiple algorithms for a specific task
 * - When you want to avoid conditional statements
 * - When algorithms need to be interchangeable at runtime
 * - When you want to isolate algorithm implementation details
 */
```

---

### SOLID principle coding examples

**Problem:** Demonstrate all SOLID principles with practical examples.

**Solution:**

```csharp
// SOLID PRINCIPLES WITH EXAMPLES

// 1. SINGLE RESPONSIBILITY PRINCIPLE (SRP)
// A class should have only one reason to change

// ? BAD - Multiple responsibilities
public class UserService_Bad
{
    public void CreateUser(string username, string email)
    {
        // Create user
        var user = new User { Username = username, Email = email };
        
        // Save to database (DB responsibility)
        SaveToDatabase(user);
        
        // Send email (Email responsibility)
        SendWelcomeEmail(email);
        
        // Log (Logging responsibility)
        Log($"User {username} created");
    }
    
    private void SaveToDatabase(User user) { }
    private void SendWelcomeEmail(string email) { }
    private void Log(string message) { }
}

// ? GOOD - Single responsibility per class
public class UserService_Good
{
    private readonly IUserRepository _repository;
    private readonly IEmailService _emailService;
    private readonly ILogger _logger;
    
    public UserService_Good(
        IUserRepository repository,
        IEmailService emailService,
        ILogger logger)
    {
        _repository = repository;
        _emailService = emailService;
        _logger = logger;
    }
    
    public void CreateUser(string username, string email)
    {
        var user = new User { Username = username, Email = email };
        _repository.Save(user);
        _emailService.SendWelcomeEmail(email);
        _logger.Log($"User {username} created");
    }
}

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
}

public interface IUserRepository
{
    void Save(User user);
}

public interface IEmailService
{
    void SendWelcomeEmail(string email);
}

public interface ILogger
{
    void Log(string message);
}

// 2. OPEN/CLOSED PRINCIPLE (OCP)
// Open for extension, closed for modification

// ? BAD - Need to modify class for new shapes
public class AreaCalculator_Bad
{
    public double CalculateArea(object shape)
    {
        if (shape is Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
        else if (shape is Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
        // Need to modify this method for each new shape
        
        return 0;
    }
}

// ? GOOD - Can extend without modifying
public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    public double Radius { get; set; }
    
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public double CalculateArea()
    {
        return Width * Height;
    }
}

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    
    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

public class AreaCalculator_Good
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
    
    public double CalculateTotalArea(List<IShape> shapes)
    {
        return shapes.Sum(s => s.CalculateArea());
    }
}

// 3. LISKOV SUBSTITUTION PRINCIPLE (LSP)
// Derived classes must be substitutable for their base classes

// ? BAD - Violates LSP
public class Bird_Bad
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class Penguin_Bad : Bird_Bad
{
    public override void Fly()
    {
        throw new NotSupportedException("Penguins can't fly");
        // Violates LSP - can't substitute Penguin for Bird
    }
}

// ? GOOD - Follows LSP
public abstract class Bird_Good
{
    public abstract void Move();
}

public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

public class Sparrow : Bird_Good, IFlyable
{
    public override void Move()
    {
        Fly();
    }
    
    public void Fly()
    {
        Console.WriteLine("Sparrow is flying");
    }
}

public class Penguin_Good : Bird_Good, ISwimmable
{
    public override void Move()
    {
        Swim();
    }
    
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming");
    }
}

// 4. INTERFACE SEGREGATION PRINCIPLE (ISP)
// Clients should not be forced to depend on interfaces they don't use

// ? BAD - Fat interface
public interface IWorker_Bad
{
    void Work();
    void Eat();
    void Sleep();
}

public class Human_Bad : IWorker_Bad
{
    public void Work() { Console.WriteLine("Working"); }
    public void Eat() { Console.WriteLine("Eating"); }
    public void Sleep() { Console.WriteLine("Sleeping"); }
}

public class Robot_Bad : IWorker_Bad
{
    public void Work() { Console.WriteLine("Working"); }
    public void Eat() { throw new NotImplementedException(); } // Robot doesn't eat
    public void Sleep() { throw new NotImplementedException(); } // Robot doesn't sleep
}

// ? GOOD - Segregated interfaces
public interface IWorkable
{
    void Work();
}

public interface IFeedable
{
    void Eat();
}

public interface ISleepable
{
    void Sleep();
}

public class Human_Good : IWorkable, IFeedable, ISleepable
{
    public void Work() { Console.WriteLine("Working"); }
    public void Eat() { Console.WriteLine("Eating"); }
    public void Sleep() { Console.WriteLine("Sleeping"); }
}

public class Robot_Good : IWorkable
{
    public void Work() { Console.WriteLine("Working"); }
    // Only implements what it needs
}

// 5. DEPENDENCY INVERSION PRINCIPLE (DIP)
// Depend on abstractions, not concretions

// ? BAD - High-level module depends on low-level module
public class EmailNotification_Bad
{
    public void Send(string message)
    {
        // Send email
        Console.WriteLine($"Email sent: {message}");
    }
}

public class NotificationService_Bad
{
    private EmailNotification_Bad _emailNotification = new EmailNotification_Bad();
    
    public void Notify(string message)
    {
        _emailNotification.Send(message);
        // Tightly coupled to EmailNotification
    }
}

// ? GOOD - Both depend on abstraction
public interface INotificationSender
{
    void Send(string message);
}

public class EmailNotification_Good : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class SmsNotification_Good : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

public class PushNotification_Good : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Push notification sent: {message}");
    }
}

public class NotificationService_Good
{
    private readonly INotificationSender _notificationSender;
    
    public NotificationService_Good(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender;
    }
    
    public void Notify(string message)
    {
        _notificationSender.Send(message);
    }
}

// REAL-WORLD EXAMPLE - E-Commerce Order Processing

// All SOLID principles combined
public class OrderProcessingExample
{
    // SRP - Each class has single responsibility
    public interface IOrderRepository
    {
        void Save(Order order);
        Order GetById(int id);
    }
    
    public interface IPaymentProcessor
    {
        bool ProcessPayment(decimal amount, string paymentMethod);
    }
    
    public interface IInventoryService
    {
        bool ReserveItems(List<OrderItem> items);
    }
    
    public interface INotificationService
    {
        void SendOrderConfirmation(string email, int orderId);
    }
    
    // OCP - Can add new payment processors without modifying
    public interface IPaymentStrategy
    {
        bool Process(decimal amount);
    }
    
    public class CreditCardPayment : IPaymentStrategy
    {
        public bool Process(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment: ${amount}");
            return true;
        }
    }
    
    public class PayPalPayment : IPaymentStrategy
    {
        public bool Process(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment: ${amount}");
            return true;
        }
    }
    
    // LSP - All discount strategies are substitutable
    public abstract class DiscountStrategy
    {
        public abstract decimal ApplyDiscount(decimal amount);
    }
    
    public class PercentageDiscount : DiscountStrategy
    {
        private readonly decimal _percentage;
        
        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }
        
        public override decimal ApplyDiscount(decimal amount)
        {
            return amount * (1 - _percentage / 100);
        }
    }
    
    public class FixedAmountDiscount : DiscountStrategy
    {
        private readonly decimal _amount;
        
        public FixedAmountDiscount(decimal amount)
        {
            _amount = amount;
        }
        
        public override decimal ApplyDiscount(decimal amount)
        {
            return amount - _amount;
        }
    }
    
    // ISP - Segregated interfaces
    public interface IOrderValidator
    {
        bool ValidateOrder(Order order);
    }
    
    public interface IOrderPriceCalculator
    {
        decimal CalculateTotal(Order order);
    }
    
    // DIP - Depends on abstractions
    public class OrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IInventoryService _inventoryService;
        private readonly INotificationService _notificationService;
        private readonly IOrderValidator _validator;
        private readonly IOrderPriceCalculator _priceCalculator;
        
        public OrderService(
            IOrderRepository repository,
            IPaymentProcessor paymentProcessor,
            IInventoryService inventoryService,
            INotificationService notificationService,
            IOrderValidator validator,
            IOrderPriceCalculator priceCalculator)
        {
            _repository = repository;
            _paymentProcessor = paymentProcessor;
            _inventoryService = inventoryService;
            _notificationService = notificationService;
            _validator = validator;
            _priceCalculator = priceCalculator;
        }
        
        public bool ProcessOrder(Order order)
        {
            // Validate
            if (!_validator.ValidateOrder(order))
                return false;
            
            // Calculate total
            var total = _priceCalculator.CalculateTotal(order);
            
            // Reserve inventory
            if (!_inventoryService.ReserveItems(order.Items))
                return false;
            
            // Process payment
            if (!_paymentProcessor.ProcessPayment(total, order.PaymentMethod))
                return false;
            
            // Save order
            _repository.Save(order);
            
            // Send notification
            _notificationService.SendOrderConfirmation(order.CustomerEmail, order.Id);
            
            return true;
        }
    }
    
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public string PaymentMethod { get; set; }
        public string CustomerEmail { get; set; }
    }
    
    public class OrderItem
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

/*
 * SOLID SUMMARY:
 * 
 * S - Single Responsibility: One class, one job
 * O - Open/Closed: Extend behavior without modifying existing code
 * L - Liskov Substitution: Subtypes must be substitutable for their base types
 * I - Interface Segregation: Many specific interfaces > one general interface
 * D - Dependency Inversion: Depend on abstractions, not implementations
 * 
 * Benefits:
 * ? Maintainability
 * ? Testability
 * ? Flexibility
 * ? Reusability
 * ? Scalability
 */
```

This comprehensive markdown file covers all the major topics requested. Would you like me to continue with the remaining sections (Data Structures & Algorithms, .NET Core/ASP.NET Core, Database & SQL, Microservices, and Real-World Scenarios)?