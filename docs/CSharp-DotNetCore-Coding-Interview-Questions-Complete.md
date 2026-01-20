# C# / .NET Core – Must-Know Coding Questions (7+ Years Experience)

## Table of Contents

### 1. Collections & LINQ
- [1.1 Remove Duplicates from a List While Preserving Order](#11-remove-duplicates-from-a-list-while-preserving-order)
- [1.2 Find Second Highest Number from an Array](#12-find-second-highest-number-from-an-array)
- [1.3 Group Objects Using LINQ](#13-group-objects-using-linq)
- [1.4 Flatten Nested Collections](#14-flatten-nested-collections)
- [1.5 Convert List to Dictionary with Duplicate Keys Handling](#15-convert-list-to-dictionary-with-duplicate-keys-handling)

### 2. String Manipulation
- [2.1 Reverse a String Without Built-in Reverse()](#21-reverse-a-string-without-built-in-reverse)
- [2.2 Check Palindrome](#22-check-palindrome)
- [2.3 Find First Non-Repeating Character](#23-find-first-non-repeating-character)
- [2.4 Count Character Frequency](#24-count-character-frequency)

### 3. Date & Time
- [3.1 Calculate Age from Date of Birth](#31-calculate-age-from-date-of-birth)
- [3.2 Find Overlapping Date Ranges](#32-find-overlapping-date-ranges)
- [3.3 Convert UTC to Local Time Safely](#33-convert-utc-to-local-time-safely)

### 4. Multithreading & Async Programming
- [4.1 Convert Sync Code to Async](#41-convert-sync-code-to-async)
- [4.2 Difference Between Task vs Thread](#42-difference-between-task-vs-thread)
- [4.3 What Happens If You Don't Await?](#43-what-happens-if-you-dont-await)

### 5. Thread Safety
- [5.1 Singleton Thread-Safe Implementation](#51-singleton-thread-safe-implementation)
- [5.2 Use of Lock, SemaphoreSlim, ConcurrentDictionary](#52-use-of-lock-semaphoreslim-concurrentdictionary)

### 6. Object-Oriented Design
- [6.1 Implement Factory Pattern](#61-implement-factory-pattern)
- [6.2 Strategy Pattern Use Case](#62-strategy-pattern-use-case)
- [6.3 SOLID Principle Coding Examples](#63-solid-principle-coding-examples)
- [6.4 Create Immutable Class](#64-create-immutable-class)
- [6.5 Benefits of Immutability in Multithreaded Apps](#65-benefits-of-immutability-in-multithreaded-apps)

### 7. Data Structures & Algorithms
- [7.1 Find Missing Number](#71-find-missing-number)
- [7.2 Rotate Array](#72-rotate-array)
- [7.3 Merge Two Sorted Arrays](#73-merge-two-sorted-arrays)
- [7.4 Find Duplicate Elements](#74-find-duplicate-elements)
- [7.5 Two-Sum Problem](#75-two-sum-problem)
- [7.6 Valid Parentheses](#76-valid-parentheses)
- [7.7 Implement LRU Cache](#77-implement-lru-cache)

### 8. .NET Core / ASP.NET Core Coding
- [8.1 Create REST API with Proper HTTP Status Codes](#81-create-rest-api-with-proper-http-status-codes)
- [8.2 Implement Global Exception Handling](#82-implement-global-exception-handling)
- [8.3 Pagination & Filtering](#83-pagination--filtering)
- [8.4 Custom Middleware Example](#84-custom-middleware-example)
- [8.5 Logging / Exception Middleware](#85-logging--exception-middleware)

### 9. Dependency Injection
- [9.1 Scoped vs Singleton vs Transient](#91-scoped-vs-singleton-vs-transient)
- [9.2 Coding Custom Service Registration](#92-coding-custom-service-registration)

### 10. Database & SQL
- [10.1 Find 2nd Highest Salary](#101-find-2nd-highest-salary)
- [10.2 Remove Duplicate Records](#102-remove-duplicate-records)
- [10.3 Join Multiple Tables](#103-join-multiple-tables)
- [10.4 Write Pagination Query](#104-write-pagination-query)
- [10.5 Lazy vs Eager Loading (EF Core)](#105-lazy-vs-eager-loading-ef-core)
- [10.6 Writing Optimized LINQ Queries](#106-writing-optimized-linq-queries)
- [10.7 Handling N+1 Problem](#107-handling-n1-problem)

### 11. Microservices & Distributed Systems
- [11.1 Implement Retry with Polly](#111-implement-retry-with-polly)
- [11.2 Circuit Breaker Example](#112-circuit-breaker-example)
- [11.3 Saga Pattern Flow](#113-saga-pattern-flow)

### 12. Real-World Coding Scenarios
- [12.1 Design Order Processing System](#121-design-order-processing-system)
- [12.2 Handle Concurrent API Requests](#122-handle-concurrent-api-requests)
- [12.3 Idempotent API Implementation](#123-idempotent-api-implementation)
- [12.4 Rate-Limiting Logic](#124-rate-limiting-logic)
- [12.5 Refactoring Task - Improve Poorly Written Code](#125-refactoring-task---improve-poorly-written-code)
- [12.6 Add Caching](#126-add-caching)
- [12.7 Improve Performance](#127-improve-performance)

### 13. System Design
- [13.1 Design URL Shortener](#131-design-url-shortener)
- [13.2 Design Order Management System](#132-design-order-management-system)
- [13.3 Design Payment Processing System](#133-design-payment-processing-system)

---

## 1. Collections & LINQ

### 1.1 Remove Duplicates from a List While Preserving Order

**Description:**
Removing duplicates while maintaining the original order is a common requirement. The `Distinct()` method in LINQ preserves the order of first occurrence.

**Solution 1: Using LINQ Distinct()**
```csharp
public class RemoveDuplicatesExample
{
    public static List<int> RemoveDuplicates(List<int> numbers)
    {
        return numbers.Distinct().ToList();
    }
    
    // For custom objects
    public static List<Person> RemoveDuplicatePersons(List<Person> persons)
    {
        return persons.Distinct(new PersonComparer()).ToList();
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class PersonComparer : IEqualityComparer<Person>
{
    public bool Equals(Person x, Person y)
    {
        return x.Id == y.Id;
    }
    
    public int GetHashCode(Person obj)
    {
        return obj.Id.GetHashCode();
    }
}
```

**Solution 2: Using HashSet (Better Performance)**
```csharp
public static List<int> RemoveDuplicatesUsingHashSet(List<int> numbers)
{
    var seen = new HashSet<int>();
    var result = new List<int>();
    
    foreach (var num in numbers)
    {
        if (seen.Add(num)) // Add returns false if already exists
        {
            result.Add(num);
        }
    }
    
    return result;
}
```

**Example Usage:**
```csharp
var numbers = new List<int> { 1, 2, 3, 2, 4, 1, 5 };
var unique = RemoveDuplicates(numbers);
// Output: [1, 2, 3, 4, 5]
```

**Performance Considerations:**
- `Distinct()`: O(n) time complexity, cleaner code
- `HashSet`: O(n) time complexity, slightly better performance for large datasets
- Both preserve order of first occurrence

---

### 1.2 Find Second Highest Number from an Array

**Description:**
Finding the second highest number is a classic interview question that tests array manipulation and edge case handling.

**Solution 1: Using LINQ (Simple)**
```csharp
public class SecondHighestExample
{
    public static int? FindSecondHighest(int[] numbers)
    {
        if (numbers == null || numbers.Length < 2)
            return null;
            
        return numbers.Distinct()
                     .OrderByDescending(x => x)
                     .Skip(1)
                     .FirstOrDefault();
    }
}
```

**Solution 2: Single Pass (Optimal - O(n))**
```csharp
public static int? FindSecondHighestOptimal(int[] numbers)
{
    if (numbers == null || numbers.Length < 2)
        return null;
        
    int first = int.MinValue;
    int second = int.MinValue;
    
    foreach (int num in numbers)
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
    
    return second == int.MinValue ? null : second;
}
```

**Solution 3: Using HashSet to Handle Duplicates**
```csharp
public static int? FindSecondHighestWithDuplicates(int[] numbers)
{
    if (numbers == null || numbers.Length < 2)
        return null;
        
    var uniqueNumbers = new HashSet<int>(numbers);
    
    if (uniqueNumbers.Count < 2)
        return null;
        
    int first = int.MinValue;
    int second = int.MinValue;
    
    foreach (int num in uniqueNumbers)
    {
        if (num > first)
        {
            second = first;
            first = num;
        }
        else if (num > second)
        {
            second = num;
        }
    }
    
    return second;
}
```

**Example Usage:**
```csharp
int[] numbers = { 10, 5, 20, 20, 4, 1, 8 };
var secondHighest = FindSecondHighest(numbers);
Console.WriteLine(secondHighest); // Output: 10

int[] numbersWithDuplicates = { 20, 20, 20 };
var result = FindSecondHighestWithDuplicates(numbersWithDuplicates);
Console.WriteLine(result ?? "No second highest"); // Output: No second highest
```

**Edge Cases to Handle:**
- Array with less than 2 elements
- All elements are the same
- Array with duplicates
- Null array

---

### 1.3 Group Objects Using LINQ

**Description:**
Grouping is essential for data aggregation and reporting. LINQ's `GroupBy` provides powerful grouping capabilities.

**Example Scenario:**
```csharp
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
    public int Age { get; set; }
}

public class GroupingExamples
{
    // Example 1: Simple Grouping by Department
    public static void GroupByDepartment(List<Employee> employees)
    {
        var groupedByDept = employees.GroupBy(e => e.Department);
        
        foreach (var group in groupedByDept)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($"  - {emp.Name} ({emp.Salary:C})");
            }
        }
    }
    
    // Example 2: Grouping with Aggregation
    public static Dictionary<string, decimal> GetAverageSalaryByDepartment(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Department)
                       .ToDictionary(g => g.Key, g => g.Average(e => e.Salary));
    }
    
    // Example 3: Multiple Aggregations
    public static List<DepartmentStats> GetDepartmentStatistics(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Department)
                       .Select(g => new DepartmentStats
                       {
                           Department = g.Key,
                           EmployeeCount = g.Count(),
                           AverageSalary = g.Average(e => e.Salary),
                           TotalSalary = g.Sum(e => e.Salary),
                           MinSalary = g.Min(e => e.Salary),
                           MaxSalary = g.Max(e => e.Salary)
                       })
                       .ToList();
    }
    
    // Example 4: Grouping by Multiple Keys
    public static void GroupByDepartmentAndAgeRange(List<Employee> employees)
    {
        var grouped = employees.GroupBy(e => new 
        { 
            e.Department, 
            AgeGroup = e.Age < 30 ? "Young" : e.Age < 50 ? "Middle" : "Senior" 
        });
        
        foreach (var group in grouped)
        {
            Console.WriteLine($"{group.Key.Department} - {group.Key.AgeGroup}: {group.Count()} employees");
        }
    }
    
    // Example 5: Nested Grouping
    public static void NestedGrouping(List<Employee> employees)
    {
        var nested = employees.GroupBy(e => e.Department)
                             .Select(deptGroup => new
                             {
                                 Department = deptGroup.Key,
                                 AgeGroups = deptGroup.GroupBy(e => e.Age / 10 * 10) // Group by decade
                             });
                             
        foreach (var dept in nested)
        {
            Console.WriteLine($"Department: {dept.Department}");
            foreach (var ageGroup in dept.AgeGroups)
            {
                Console.WriteLine($"  Age {ageGroup.Key}s: {ageGroup.Count()} employees");
            }
        }
    }
}

public class DepartmentStats
{
    public string Department { get; set; }
    public int EmployeeCount { get; set; }
    public decimal AverageSalary { get; set; }
    public decimal TotalSalary { get; set; }
    public decimal MinSalary { get; set; }
    public decimal MaxSalary { get; set; }
}
```

**Example Usage:**
```csharp
var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "John", Department = "IT", Salary = 80000, Age = 30 },
    new Employee { Id = 2, Name = "Jane", Department = "IT", Salary = 90000, Age = 35 },
    new Employee { Id = 3, Name = "Bob", Department = "HR", Salary = 60000, Age = 28 },
    new Employee { Id = 4, Name = "Alice", Department = "HR", Salary = 65000, Age = 32 }
};

var avgSalaries = GetAverageSalaryByDepartment(employees);
// Output: IT: 85000, HR: 62500
```

---

### 1.4 Flatten Nested Collections

**Description:**
Flattening nested collections is common when dealing with hierarchical data structures.

**Example Scenarios:**
```csharp
public class Department
{
    public string Name { get; set; }
    public List<Team> Teams { get; set; }
}

public class Team
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }
}

public class FlattenExamples
{
    // Example 1: Simple Flattening with SelectMany
    public static List<Employee> GetAllEmployees(List<Department> departments)
    {
        return departments.SelectMany(d => d.Teams)
                         .SelectMany(t => t.Employees)
                         .ToList();
    }
    
    // Example 2: Flatten with Additional Data
    public static List<EmployeeInfo> GetEmployeesWithContext(List<Department> departments)
    {
        return departments.SelectMany(d => d.Teams, (dept, team) => new { dept, team })
                         .SelectMany(x => x.team.Employees, (x, emp) => new EmployeeInfo
                         {
                             EmployeeName = emp.Name,
                             TeamName = x.team.Name,
                             DepartmentName = x.dept.Name
                         })
                         .ToList();
    }
    
    // Example 3: Flatten Nested Arrays
    public static List<int> FlattenNestedArray(List<List<int>> nestedList)
    {
        return nestedList.SelectMany(x => x).ToList();
    }
    
    // Example 4: Flatten with Filtering
    public static List<Employee> GetITEmployeesOnly(List<Department> departments)
    {
        return departments.Where(d => d.Name == "IT")
                         .SelectMany(d => d.Teams)
                         .SelectMany(t => t.Employees)
                         .ToList();
    }
    
    // Example 5: Flatten Jagged Arrays
    public static List<string> FlattenJaggedArray(string[][] jaggedArray)
    {
        return jaggedArray.SelectMany(arr => arr).ToList();
    }
    
    // Example 6: Recursive Flattening (Tree Structure)
    public static List<Node> FlattenTree(Node root)
    {
        if (root == null) return new List<Node>();
        
        var result = new List<Node> { root };
        
        if (root.Children != null && root.Children.Any())
        {
            result.AddRange(root.Children.SelectMany(child => FlattenTree(child)));
        }
        
        return result;
    }
}

public class EmployeeInfo
{
    public string EmployeeName { get; set; }
    public string TeamName { get; set; }
    public string DepartmentName { get; set; }
}

public class Node
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Node> Children { get; set; }
}
```

**Example Usage:**
```csharp
var nestedNumbers = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5 },
    new List<int> { 6, 7, 8, 9 }
};

var flattened = FlattenNestedArray(nestedNumbers);
// Output: [1, 2, 3, 4, 5, 6, 7, 8, 9]
```

---

### 1.5 Convert List to Dictionary with Duplicate Keys Handling

**Description:**
Converting lists to dictionaries is common, but handling duplicate keys requires careful consideration.

**Solutions:**
```csharp
public class ListToDictionaryExamples
{
    // Example 1: Simple Conversion (No Duplicates Expected)
    public static Dictionary<int, Employee> SimpleToDictionary(List<Employee> employees)
    {
        return employees.ToDictionary(e => e.Id, e => e);
    }
    
    // Example 2: Handle Duplicates - Take First
    public static Dictionary<int, Employee> TakeFirst(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Id)
                       .ToDictionary(g => g.Key, g => g.First());
    }
    
    // Example 3: Handle Duplicates - Take Last
    public static Dictionary<int, Employee> TakeLast(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Id)
                       .ToDictionary(g => g.Key, g => g.Last());
    }
    
    // Example 4: Handle Duplicates - Store as List
    public static Dictionary<int, List<Employee>> GroupDuplicates(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Id)
                       .ToDictionary(g => g.Key, g => g.ToList());
    }
    
    // Example 5: Handle Duplicates - Aggregate
    public static Dictionary<string, decimal> AggregateSalaryByDepartment(List<Employee> employees)
    {
        return employees.GroupBy(e => e.Department)
                       .ToDictionary(g => g.Key, g => g.Sum(e => e.Salary));
    }
    
    // Example 6: Using Distinct Before Conversion
    public static Dictionary<int, Employee> UseDistinct(List<Employee> employees)
    {
        return employees.Distinct(new EmployeeIdComparer())
                       .ToDictionary(e => e.Id, e => e);
    }
    
    // Example 7: Try-Catch Pattern for Manual Handling
    public static Dictionary<int, Employee> ManualHandling(List<Employee> employees)
    {
        var dictionary = new Dictionary<int, Employee>();
        
        foreach (var emp in employees)
        {
            if (!dictionary.ContainsKey(emp.Id))
            {
                dictionary.Add(emp.Id, emp);
            }
            else
            {
                // Custom logic: e.g., keep higher salary
                if (emp.Salary > dictionary[emp.Id].Salary)
                {
                    dictionary[emp.Id] = emp;
                }
            }
        }
        
        return dictionary;
    }
    
    // Example 8: Using TryAdd (C# 8.0+)
    public static Dictionary<int, Employee> UseTryAdd(List<Employee> employees)
    {
        var dictionary = new Dictionary<int, Employee>();
        
        foreach (var emp in employees)
        {
            dictionary.TryAdd(emp.Id, emp); // Ignores if key exists
        }
        
        return dictionary;
    }
}

public class EmployeeIdComparer : IEqualityComparer<Employee>
{
    public bool Equals(Employee x, Employee y)
    {
        return x.Id == y.Id;
    }
    
    public int GetHashCode(Employee obj)
    {
        return obj.Id.GetHashCode();
    }
}
```

**Example Usage:**
```csharp
var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "John", Department = "IT", Salary = 80000 },
    new Employee { Id = 2, Name = "Jane", Department = "IT", Salary = 90000 },
    new Employee { Id = 1, Name = "John Updated", Department = "IT", Salary = 85000 } // Duplicate
};

// Take first occurrence
var dictFirst = TakeFirst(employees);

// Take last occurrence
var dictLast = TakeLast(employees);

// Group duplicates
var grouped = GroupDuplicates(employees);
```

---

## 2. String Manipulation

### 2.1 Reverse a String Without Built-in Reverse()

**Description:**
Reversing a string is a fundamental operation. Implementing it without built-in methods demonstrates understanding of string manipulation and algorithms.

**Solutions:**
```csharp
public class StringReverseExamples
{
    // Method 1: Using Array Reverse
    public static string ReverseUsingArray(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
            
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
    // Method 2: Using Loop (Two Pointers)
    public static string ReverseUsingLoop(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
            
        char[] charArray = input.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;
        
        while (left < right)
        {
            // Swap characters
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            
            left++;
            right--;
        }
        
        return new string(charArray);
    }
    
    // Method 3: Using StringBuilder
    public static string ReverseUsingStringBuilder(string input)
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
    
    // Method 4: Using Recursion
    public static string ReverseUsingRecursion(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length == 1)
            return input;
            
        return ReverseUsingRecursion(input.Substring(1)) + input[0];
    }
    
    // Method 5: Using Stack
    public static string ReverseUsingStack(string input)
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
    
    // Method 6: Using XOR (In-place swap without temp variable)
    public static string ReverseUsingXOR(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
            
        char[] charArray = input.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;
        
        while (left < right)
        {
            charArray[left] ^= charArray[right];
            charArray[right] ^= charArray[left];
            charArray[left] ^= charArray[right];
            
            left++;
            right--;
        }
        
        return new string(charArray);
    }
}
```

**Example Usage:**
```csharp
string input = "Hello World";
string reversed = ReverseUsingLoop(input);
Console.WriteLine(reversed); // Output: "dlroW olleH"
```

**Performance Comparison:**
- **Array.Reverse**: O(n) - Most efficient
- **Two Pointers**: O(n) - Good performance, clear logic
- **StringBuilder**: O(n) - Good for concatenation-heavy operations
- **Recursion**: O(n) but uses stack space - Not recommended for large strings
- **Stack**: O(n) - Extra space, but demonstrates data structure knowledge

---

### 2.2 Check Palindrome

**Description:**
A palindrome reads the same forwards and backwards. This tests string comparison and algorithm efficiency.

**Solutions:**
```csharp
public class PalindromeExamples
{
    // Method 1: Using Two Pointers (Most Efficient)
    public static bool IsPalindrome(string input)
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
    
    // Method 2: Using Reverse Comparison
    public static bool IsPalindromeReverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
            
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        
        return input.Equals(reversed, StringComparison.Ordinal);
    }
    
    // Method 3: Using LINQ
    public static bool IsPalindromeLinq(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
            
        return input.SequenceEqual(input.Reverse());
    }
    
    // Method 4: Ignoring Spaces and Case
    public static bool IsPalindromeIgnoreCaseAndSpaces(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;
            
        // Remove spaces and convert to lowercase
        string cleaned = new string(input.Where(char.IsLetterOrDigit)
                                         .Select(char.ToLower)
                                         .ToArray());
        
        int left = 0;
        int right = cleaned.Length - 1;
        
        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
                return false;
                
            left++;
            right--;
        }
        
        return true;
    }
    
    // Method 5: Alphanumeric Palindrome (LeetCode style)
    public static bool IsValidPalindrome(string input)
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
    
    // Method 6: Check if Number is Palindrome
    public static bool IsNumberPalindrome(int number)
    {
        // Negative numbers are not palindromes
        if (number < 0)
            return false;
            
        int original = number;
        int reversed = 0;
        
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        
        return original == reversed;
    }
}
```

**Example Usage:**
```csharp
Console.WriteLine(IsPalindrome("racecar"));        // True
Console.WriteLine(IsPalindrome("hello"));          // False
Console.WriteLine(IsPalindromeIgnoreCaseAndSpaces("A man a plan a canal Panama")); // True
Console.WriteLine(IsValidPalindrome("A man, a plan, a canal: Panama")); // True
Console.WriteLine(IsNumberPalindrome(12321));      // True
```

**Edge Cases:**
- Empty string (typically considered palindrome)
- Single character
- Even vs odd length
- Special characters and spaces
- Case sensitivity

---

### 2.3 Find First Non-Repeating Character

**Description:**
Finding the first non-repeating character tests hash map usage and efficient string traversal.

**Solutions:**
```csharp
public class FirstNonRepeatingCharExamples
{
    // Method 1: Using Dictionary (Two Pass)
    public static char? FindFirstNonRepeating(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
            
        // First pass: Count frequencies
        var charCount = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }
        
        // Second pass: Find first non-repeating
        foreach (char c in input)
        {
            if (charCount[c] == 1)
                return c;
        }
        
        return null;
    }
    
    // Method 2: Using LINQ GroupBy
    public static char? FindFirstNonRepeatingLinq(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
            
        return input.GroupBy(c => c)
                   .Where(g => g.Count() == 1)
                   .Select(g => g.Key)
                   .FirstOrDefault();
    }
    
    // Method 3: Using Array for ASCII Characters (Fastest)
    public static char? FindFirstNonRepeatingArray(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
            
        int[] charCount = new int[256]; // Assuming ASCII
        
        // Count frequencies
        foreach (char c in input)
        {
            charCount[c]++;
        }
        
        // Find first non-repeating
        foreach (char c in input)
        {
            if (charCount[c] == 1)
                return c;
        }
        
        return null;
    }
    
    // Method 4: Return Index of First Non-Repeating Character
    public static int FindFirstNonRepeatingIndex(string input)
    {
        if (string.IsNullOrEmpty(input))
            return -1;
            
        var charCount = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }
        
        for (int i = 0; i < input.Length; i++)
        {
            if (charCount[input[i]] == 1)
                return i;
        }
        
        return -1;
    }
    
    // Method 5: Case Insensitive
    public static char? FindFirstNonRepeatingCaseInsensitive(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;
            
        string lower = input.ToLower();
        var charCount = new Dictionary<char, int>();
        
        foreach (char c in lower)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }
        
        for (int i = 0; i < lower.Length; i++)
        {
            if (charCount[lower[i]] == 1)
                return input[i]; // Return original case
        }
        
        return null;
    }
}
```

**Example Usage:**
```csharp
string input1 = "leetcode";
Console.WriteLine(FindFirstNonRepeating(input1)); // Output: 'l'

string input2 = "loveleetcode";
Console.WriteLine(FindFirstNonRepeating(input2)); // Output: 'v'

string input3 = "aabb";
Console.WriteLine(FindFirstNonRepeating(input3) ?? "None"); // Output: "None"
```

**Time Complexity:**
- All methods: O(n) where n is the length of the string
- Dictionary method: Uses O(k) space where k is the number of unique characters
- Array method: Uses O(1) space for ASCII (fixed 256 size)

---

### 2.4 Count Character Frequency

**Description:**
Counting character frequency is fundamental for many string algorithms and text processing tasks.

**Solutions:**
```csharp
public class CharacterFrequencyExamples
{
    // Method 1: Using Dictionary
    public static Dictionary<char, int> CountFrequency(string input)
    {
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
    public static Dictionary<char, int> CountFrequencyLinq(string input)
    {
        return input.GroupBy(c => c)
                   .ToDictionary(g => g.Key, g => g.Count());
    }
    
    // Method 3: Using TryGetValue (Efficient)
    public static Dictionary<char, int> CountFrequencyEfficient(string input)
    {
        var frequency = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            if (frequency.TryGetValue(c, out int count))
                frequency[c] = count + 1;
            else
                frequency[c] = 1;
        }
        
        return frequency;
    }
    
    // Method 4: Using Array for ASCII
    public static int[] CountFrequencyArray(string input)
    {
        int[] frequency = new int[256];
        
        foreach (char c in input)
        {
            frequency[c]++;
        }
        
        return frequency;
    }
    
    // Method 5: Case Insensitive
    public static Dictionary<char, int> CountFrequencyCaseInsensitive(string input)
    {
        var frequency = new Dictionary<char, int>();
        
        foreach (char c in input.ToLower())
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }
        
        return frequency;
    }
    
    // Method 6: Count Only Letters
    public static Dictionary<char, int> CountLettersOnly(string input)
    {
        var frequency = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char lower = char.ToLower(c);
                if (frequency.ContainsKey(lower))
                    frequency[lower]++;
                else
                    frequency[lower] = 1;
            }
        }
        
        return frequency;
    }
    
    // Method 7: Get Most Frequent Character
    public static char GetMostFrequentChar(string input)
    {
        var frequency = CountFrequency(input);
        return frequency.OrderByDescending(kvp => kvp.Value).First().Key;
    }
    
    // Method 8: Get Characters Sorted by Frequency
    public static List<KeyValuePair<char, int>> GetSortedByFrequency(string input)
    {
        var frequency = CountFrequency(input);
        return frequency.OrderByDescending(kvp => kvp.Value)
                       .ThenBy(kvp => kvp.Key)
                       .ToList();
    }
    
    // Method 9: Display Frequency
    public static void DisplayFrequency(string input)
    {
        var frequency = CountFrequency(input);
        
        Console.WriteLine("Character Frequencies:");
        foreach (var kvp in frequency.OrderBy(x => x.Key))
        {
            Console.WriteLine($"'{kvp.Key}': {kvp.Value}");
        }
    }
}
```

**Example Usage:**
```csharp
string input = "programming";
var freq = CountFrequency(input);

foreach (var kvp in freq)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// Output:
// p: 1
// r: 2
// o: 1
// g: 2
// a: 1
// m: 2
// i: 1
// n: 1

// Get most frequent character
char mostFrequent = GetMostFrequentChar(input);
Console.WriteLine($"Most frequent: {mostFrequent}"); // Output: r (or g or m - first one found)
```

**Advanced Applications:**
```csharp
public class AdvancedFrequencyExamples
{
    // Check if two strings are anagrams
    public static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;
            
        var freq1 = CountFrequency(str1.ToLower());
        var freq2 = CountFrequency(str2.ToLower());
        
        return freq1.Count == freq2.Count && 
               freq1.All(kvp => freq2.TryGetValue(kvp.Key, out int value) && value == kvp.Value);
    }
    
    // Find characters that appear more than once
    public static List<char> FindDuplicateCharacters(string input)
    {
        var frequency = CountFrequency(input);
        return frequency.Where(kvp => kvp.Value > 1)
                       .Select(kvp => kvp.Key)
                       .ToList();
    }
}
```

---

## 3. Date & Time

### 3.1 Calculate Age from Date of Birth

**Description:**
Calculating age correctly requires handling leap years, month boundaries, and edge cases.

**Solutions:**
```csharp
public class AgeCalculationExamples
{
    // Method 1: Accurate Age Calculation
    public static int CalculateAge(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;
        
        // Adjust if birthday hasn't occurred this year
        if (dateOfBirth.Date > today.AddYears(-age))
            age--;
            
        return age;
    }
    
    // Method 2: Alternative Method
    public static int CalculateAgeAlternative(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;
        
        // Check if birthday has occurred this year
        if (today.Month < dateOfBirth.Month || 
            (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
        {
            age--;
        }
        
        return age;
    }
    
    // Method 3: Detailed Age (Years, Months, Days)
    public static AgeDetail CalculateDetailedAge(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        
        int years = today.Year - dateOfBirth.Year;
        int months = today.Month - dateOfBirth.Month;
        int days = today.Day - dateOfBirth.Day;
        
        // Adjust for negative days
        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(today.Year, today.Month == 1 ? 12 : today.Month - 1);
        }
        
        // Adjust for negative months
        if (months < 0)
        {
            years--;
            months += 12;
        }
        
        return new AgeDetail
        {
            Years = years,
            Months = months,
            Days = days
        };
    }
    
    // Method 4: Calculate Age at Specific Date
    public static int CalculateAgeAt(DateTime dateOfBirth, DateTime targetDate)
    {
        int age = targetDate.Year - dateOfBirth.Year;
        
        if (dateOfBirth.Date > targetDate.AddYears(-age))
            age--;
            
        return age;
    }
    
    // Method 5: Validate Age Range
    public static bool IsAgeInRange(DateTime dateOfBirth, int minAge, int maxAge)
    {
        int age = CalculateAge(dateOfBirth);
        return age >= minAge && age <= maxAge;
    }
    
    // Method 6: Calculate Age in Months
    public static int CalculateAgeInMonths(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        int months = (today.Year - dateOfBirth.Year) * 12 + today.Month - dateOfBirth.Month;
        
        if (today.Day < dateOfBirth.Day)
            months--;
            
        return months;
    }
    
    // Method 7: Calculate Age in Days
    public static int CalculateAgeInDays(DateTime dateOfBirth)
    {
        return (DateTime.Today - dateOfBirth.Date).Days;
    }
    
    // Method 8: Get Next Birthday
    public static DateTime GetNextBirthday(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, dateOfBirth.Month, dateOfBirth.Day);
        
        if (nextBirthday < today)
            nextBirthday = nextBirthday.AddYears(1);
            
        return nextBirthday;
    }
    
    // Method 9: Days Until Next Birthday
    public static int DaysUntilNextBirthday(DateTime dateOfBirth)
    {
        DateTime nextBirthday = GetNextBirthday(dateOfBirth);
        return (nextBirthday - DateTime.Today).Days;
    }
}

public class AgeDetail
{
    public int Years { get; set; }
    public int Months { get; set; }
    public int Days { get; set; }
    
    public override string ToString()
    {
        return $"{Years} years, {Months} months, {Days} days";
    }
}
```

**Example Usage:**
```csharp
DateTime dob = new DateTime(1990, 5, 15);

int age = CalculateAge(dob);
Console.WriteLine($"Age: {age} years");

var detailedAge = CalculateDetailedAge(dob);
Console.WriteLine($"Detailed Age: {detailedAge}");

int months = CalculateAgeInMonths(dob);
Console.WriteLine($"Age in months: {months}");

int daysUntilBirthday = DaysUntilNextBirthday(dob);
Console.WriteLine($"Days until next birthday: {daysUntilBirthday}");
```

**Edge Cases to Consider:**
- Leap year birthdays (Feb 29)
- Today is the birthday
- Future dates (should handle gracefully)
- Different time zones

---

### 3.2 Find Overlapping Date Ranges

**Description:**
Finding overlapping date ranges is crucial for booking systems, scheduling, and resource management.

**Solutions:**
```csharp
public class DateRange
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public DateRange(DateTime start, DateTime end)
    {
        if (start > end)
            throw new ArgumentException("Start date must be before end date");
            
        StartDate = start;
        EndDate = end;
    }
}

public class DateRangeOverlapExamples
{
    // Method 1: Check if Two Ranges Overlap
    public static bool DoRangesOverlap(DateRange range1, DateRange range2)
    {
        return range1.StartDate <= range2.EndDate && range2.StartDate <= range1.EndDate;
    }
    
    // Method 2: Alternative Overlap Check
    public static bool DoRangesOverlapAlternative(DateRange range1, DateRange range2)
    {
        return !(range1.EndDate < range2.StartDate || range2.EndDate < range1.StartDate);
    }
    
    // Method 3: Get Overlapping Period
    public static DateRange? GetOverlappingPeriod(DateRange range1, DateRange range2)
    {
        if (!DoRangesOverlap(range1, range2))
            return null;
            
        DateTime overlapStart = range1.StartDate > range2.StartDate ? range1.StartDate : range2.StartDate;
        DateTime overlapEnd = range1.EndDate < range2.EndDate ? range1.EndDate : range2.EndDate;
        
        return new DateRange(overlapStart, overlapEnd);
    }
    
    // Method 4: Find All Overlapping Ranges
    public static List<DateRange> FindAllOverlappingRanges(List<DateRange> ranges)
    {
        var overlaps = new List<DateRange>();
        
        for (int i = 0; i < ranges.Count; i++)
        {
            for (int j = i + 1; j < ranges.Count; j++)
            {
                if (DoRangesOverlap(ranges[i], ranges[j]))
                {
                    var overlap = GetOverlappingPeriod(ranges[i], ranges[j]);
                    if (overlap != null)
                        overlaps.Add(overlap);
                }
            }
        }
        
        return overlaps;
    }
    
    // Method 5: Merge Overlapping Ranges
    public static List<DateRange> MergeOverlappingRanges(List<DateRange> ranges)
    {
        if (ranges == null || ranges.Count == 0)
            return new List<DateRange>();
            
        // Sort by start date
        var sorted = ranges.OrderBy(r => r.StartDate).ToList();
        var merged = new List<DateRange>();
        
        DateRange current = sorted[0];
        
        for (int i = 1; i < sorted.Count; i++)
        {
            if (DoRangesOverlap(current, sorted[i]))
            {
                // Merge ranges
                current = new DateRange(
                    current.StartDate,
                    current.EndDate > sorted[i].EndDate ? current.EndDate : sorted[i].EndDate
                );
            }
            else
            {
                merged.Add(current);
                current = sorted[i];
            }
        }
        
        merged.Add(current);
        return merged;
    }
    
    // Method 6: Check if Date Falls Within Range
    public static bool IsDateInRange(DateTime date, DateRange range)
    {
        return date >= range.StartDate && date <= range.EndDate;
    }
    
    // Method 7: Get Overlap Duration in Days
    public static int GetOverlapDurationInDays(DateRange range1, DateRange range2)
    {
        var overlap = GetOverlappingPeriod(range1, range2);
        
        if (overlap == null)
            return 0;
            
        return (overlap.EndDate - overlap.StartDate).Days + 1;
    }
    
    // Method 8: Find Gaps Between Ranges
    public static List<DateRange> FindGapsBetweenRanges(List<DateRange> ranges)
    {
        if (ranges == null || ranges.Count < 2)
            return new List<DateRange>();
            
        var sorted = ranges.OrderBy(r => r.StartDate).ToList();
        var gaps = new List<DateRange>();
        
        for (int i = 0; i < sorted.Count - 1; i++)
        {
            if (sorted[i].EndDate < sorted[i + 1].StartDate.AddDays(-1))
            {
                gaps.Add(new DateRange(
                    sorted[i].EndDate.AddDays(1),
                    sorted[i + 1].StartDate.AddDays(-1)
                ));
            }
        }
        
        return gaps;
    }
    
    // Method 9: Check if One Range Contains Another
    public static bool DoesRangeContain(DateRange outer, DateRange inner)
    {
        return outer.StartDate <= inner.StartDate && outer.EndDate >= inner.EndDate;
    }
}

// Practical Example: Hotel Booking System
public class HotelBooking
{
    public int RoomId { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public string GuestName { get; set; }
}

public class HotelBookingSystem
{
    private List<HotelBooking> bookings = new List<HotelBooking>();
    
    public bool IsRoomAvailable(int roomId, DateTime checkIn, DateTime checkOut)
    {
        var requestedRange = new DateRange(checkIn, checkOut);
        
        var roomBookings = bookings.Where(b => b.RoomId == roomId);
        
        foreach (var booking in roomBookings)
        {
            var bookingRange = new DateRange(booking.CheckIn, booking.CheckOut);
            
            if (DateRangeOverlapExamples.DoRangesOverlap(requestedRange, bookingRange))
                return false;
        }
        
        return true;
    }
    
    public List<HotelBooking> GetConflictingBookings(int roomId, DateTime checkIn, DateTime checkOut)
    {
        var requestedRange = new DateRange(checkIn, checkOut);
        var conflicts = new List<HotelBooking>();
        
        foreach (var booking in bookings.Where(b => b.RoomId == roomId))
        {
            var bookingRange = new DateRange(booking.CheckIn, booking.CheckOut);
            
            if (DateRangeOverlapExamples.DoRangesOverlap(requestedRange, bookingRange))
                conflicts.Add(booking);
        }
        
        return conflicts;
    }
}
```

**Example Usage:**
```csharp
var range1 = new DateRange(new DateTime(2026, 1, 1), new DateTime(2026, 1, 10));
var range2 = new DateRange(new DateTime(2026, 1, 5), new DateTime(2026, 1, 15));

bool overlaps = DoRangesOverlap(range1, range2);
Console.WriteLine($"Ranges overlap: {overlaps}"); // True

var overlapPeriod = GetOverlappingPeriod(range1, range2);
Console.WriteLine($"Overlap: {overlapPeriod.StartDate:d} to {overlapPeriod.EndDate:d}");
// Output: 1/5/2026 to 1/10/2026

int overlapDays = GetOverlapDurationInDays(range1, range2);
Console.WriteLine($"Overlap duration: {overlapDays} days"); // 6 days
```

---

### 3.3 Convert UTC to Local Time Safely

**Description:**
Time zone conversion is critical for global applications. Proper handling prevents data loss and user confusion.

**Solutions:**
```csharp
public class TimeZoneConversionExamples
{
    // Method 1: Convert UTC to Local Time
    public static DateTime ConvertUtcToLocal(DateTime utcDateTime)
    {
        if (utcDateTime.Kind != DateTimeKind.Utc)
            throw new ArgumentException("DateTime must be UTC");
            
        return utcDateTime.ToLocalTime();
    }
    
    // Method 2: Convert to Specific Time Zone
    public static DateTime ConvertUtcToTimeZone(DateTime utcDateTime, string timeZoneId)
    {
        if (utcDateTime.Kind != DateTimeKind.Utc)
            utcDateTime = DateTime.SpecifyKind(utcDateTime, DateTimeKind.Utc);
            
        TimeZoneInfo targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, targetTimeZone);
    }
    
    // Method 3: Convert Between Any Two Time Zones
    public static DateTime ConvertBetweenTimeZones(
        DateTime dateTime, 
        string sourceTimeZoneId, 
        string targetTimeZoneId)
    {
        TimeZoneInfo sourceTimeZone = TimeZoneInfo.FindSystemTimeZoneById(sourceTimeZoneId);
        TimeZoneInfo targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(targetTimeZoneId);
        
        return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, targetTimeZone);
    }
    
    // Method 4: Safe UTC Conversion with DateTimeOffset
    public static DateTimeOffset ConvertToUtcOffset(DateTime localDateTime, string timeZoneId)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTimeOffset dto = new DateTimeOffset(localDateTime, timeZone.GetUtcOffset(localDateTime));
        return dto.ToUniversalTime();
    }
    
    // Method 5: Handle Ambiguous Times (DST)
    public static DateTime ConvertAmbiguousTime(
        DateTime dateTime, 
        string timeZoneId, 
        bool isDaylightSaving)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        
        if (timeZone.IsAmbiguousTime(dateTime))
        {
            TimeSpan[] offsets = timeZone.GetAmbiguousTimeOffsets(dateTime);
            TimeSpan offset = isDaylightSaving ? offsets[0] : offsets[1];
            
            return new DateTimeOffset(dateTime, offset).UtcDateTime;
        }
        
        return TimeZoneInfo.ConvertTimeToUtc(dateTime, timeZone);
    }
    
    // Method 6: Get All Available Time Zones
    public static List<TimeZoneInfo> GetAllTimeZones()
    {
        return TimeZoneInfo.GetSystemTimeZones().ToList();
    }
    
    // Method 7: Display Time in Multiple Zones
    public static Dictionary<string, DateTime> GetTimeInMultipleZones(DateTime utcDateTime)
    {
        var times = new Dictionary<string, DateTime>();
        
        var importantZones = new[]
        {
            "UTC",
            "Eastern Standard Time",      // EST
            "Pacific Standard Time",       // PST
            "Central European Standard Time", // CET
            "India Standard Time",         // IST
            "AUS Eastern Standard Time"    // AEST
        };
        
        foreach (var zoneId in importantZones)
        {
            try
            {
                var timeZone = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
                var convertedTime = TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZone);
                times[timeZone.DisplayName] = convertedTime;
            }
            catch (TimeZoneNotFoundException)
            {
                // Handle missing time zone
            }
        }
        
        return times;
    }
    
    // Method 8: Check if Time Zone Observes DST
    public static bool ObservesDaylightSaving(string timeZoneId)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return timeZone.SupportsDaylightSavingTime;
    }
    
    // Method 9: Store and Retrieve Dates Safely
    public static class SafeDateStorage
    {
        // Always store in UTC
        public static DateTime StoreDate(DateTime localDateTime, string userTimeZoneId)
        {
            TimeZoneInfo userTimeZone = TimeZoneInfo.FindSystemTimeZoneById(userTimeZoneId);
            return TimeZoneInfo.ConvertTimeToUtc(localDateTime, userTimeZone);
        }
        
        // Convert back to user's time zone
        public static DateTime RetrieveDate(DateTime utcDateTime, string userTimeZoneId)
        {
            TimeZoneInfo userTimeZone = TimeZoneInfo.FindSystemTimeZoneById(userTimeZoneId);
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, userTimeZone);
        }
    }
}

// Best Practices Class
public class TimeZoneBestPractices
{
    // Example: API Response with Time Zone Info
    public class ApiResponse
    {
        public DateTime Timestamp { get; set; }
        public string TimeZone { get; set; }
        public string FormattedTime { get; set; }
    }
    
    public static ApiResponse CreateResponse(DateTime utcTime, string userTimeZoneId)
    {
        TimeZoneInfo userTimeZone = TimeZoneInfo.FindSystemTimeZoneById(userTimeZoneId);
        DateTime userTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, userTimeZone);
        
        return new ApiResponse
        {
            Timestamp = utcTime,
            TimeZone = userTimeZoneId,
            FormattedTime = userTime.ToString("yyyy-MM-dd HH:mm:ss")
        };
    }
    
    // Example: Scheduling System
    public class ScheduledEvent
    {
        public DateTime UtcStartTime { get; set; }
        public string TimeZoneId { get; set; }
        
        public DateTime GetLocalStartTime()
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId);
            return TimeZoneInfo.ConvertTimeFromUtc(UtcStartTime, timeZone);
        }
    }
}
```

**Example Usage:**
```csharp
// Current UTC time
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine($"UTC: {utcNow}");

// Convert to Eastern Time
DateTime eastTime = ConvertUtcToTimeZone(utcNow, "Eastern Standard Time");
Console.WriteLine($"Eastern: {eastTime}");

// Convert to India Time
DateTime indiaTime = ConvertUtcToTimeZone(utcNow, "India Standard Time");
Console.WriteLine($"India: {indiaTime}");

// Display in multiple zones
var times = GetTimeInMultipleZones(utcNow);
foreach (var kvp in times)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value:yyyy-MM-dd HH:mm:ss}");
}
```

**Common Time Zone IDs:**
- **UTC**: "UTC"
- **EST**: "Eastern Standard Time"
- **PST**: "Pacific Standard Time"
- **CST**: "Central Standard Time"
- **IST**: "India Standard Time"
- **GMT**: "GMT Standard Time"
- **CET**: "Central European Standard Time"

**Best Practices:**
1. Always store dates in UTC in database
2. Convert to user's time zone for display only
3. Use `DateTimeOffset` for precise time zone handling
4. Handle DST transitions carefully
5. Always specify `DateTimeKind` when creating DateTime objects

---

## 4. Multithreading & Async Programming

### 4.1 Convert Sync Code to Async

**Description:**
Converting synchronous code to asynchronous improves application responsiveness and scalability, especially for I/O-bound operations.

**Examples:**

**Scenario 1: Database Operations**
```csharp
// Before: Synchronous
public class UserRepository
{
    private readonly DbContext _context;
    
    public User GetUserById(int id)
    {
        return _context.Users.Find(id);
    }
    
    public List<User> GetAllUsers()
    {
        return _context.Users.ToList();
    }
    
    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}

// After: Asynchronous
public class UserRepositoryAsync
{
    private readonly DbContext _context;
    
    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }
    
    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
    
    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}
```

**Scenario 2: HTTP Calls**
```csharp
// Before: Synchronous
public class WeatherService
{
    private readonly HttpClient _httpClient;
    
    public string GetWeather(string city)
    {
        var response = _httpClient.GetAsync($"api/weather/{city}").Result;
        return response.Content.ReadAsStringAsync().Result;
    }
}

// After: Asynchronous
public class WeatherServiceAsync
{
    private readonly HttpClient _httpClient;
    
    public async Task<string> GetWeatherAsync(string city)
    {
        var response = await _httpClient.GetAsync($"api/weather/{city}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
```

**Scenario 3: File Operations**
```csharp
// Before: Synchronous
public class FileService
{
    public string ReadFile(string path)
    {
        return File.ReadAllText(path);
    }
    
    public void WriteFile(string path, string content)
    {
        File.WriteAllText(path, content);
    }
    
    public byte[] ReadBinaryFile(string path)
    {
        return File.ReadAllBytes(path);
    }
}

// After: Asynchronous
public class FileServiceAsync
{
    public async Task<string> ReadFileAsync(string path)
    {
        return await File.ReadAllTextAsync(path);
    }
    
    public async Task WriteFileAsync(string path, string content)
    {
        await File.WriteAllTextAsync(path, content);
    }
    
    public async Task<byte[]> ReadBinaryFileAsync(string path)
    {
        return await File.ReadAllBytesAsync(path);
    }
}
```

**Scenario 4: Multiple Async Operations**
```csharp
public class DataAggregationService
{
    private readonly IUserService _userService;
    private readonly IOrderService _orderService;
    private readonly IProductService _productService;
    
    // Before: Sequential Synchronous (Slow)
    public DashboardData GetDashboardDataSync(int userId)
    {
        var user = _userService.GetUser(userId);           // 100ms
        var orders = _orderService.GetUserOrders(userId);  // 150ms
        var products = _productService.GetProducts();      // 200ms
        
        // Total: ~450ms
        return new DashboardData { User = user, Orders = orders, Products = products };
    }
    
    // After: Parallel Asynchronous (Fast)
    public async Task<DashboardData> GetDashboardDataAsync(int userId)
    {
        // All three calls run in parallel
        var userTask = _userService.GetUserAsync(userId);         // 100ms
        var ordersTask = _orderService.GetUserOrdersAsync(userId); // 150ms
        var productsTask = _productService.GetProductsAsync();    // 200ms
        
        await Task.WhenAll(userTask, ordersTask, productsTask);
        
        // Total: ~200ms (time of slowest operation)
        return new DashboardData 
        { 
            User = await userTask, 
            Orders = await ordersTask, 
            Products = await productsTask 
        };
    }
}
```

**Scenario 5: Error Handling in Async Code**
```csharp
public class AsyncErrorHandling
{
    // Synchronous
    public string ProcessDataSync(string input)
    {
        try
        {
            // Some processing
            return "Success";
        }
        catch (Exception ex)
        {
            // Handle error
            return "Error";
        }
    }
    
    // Asynchronous - Same pattern
    public async Task<string> ProcessDataAsync(string input)
    {
        try
        {
            await Task.Delay(100); // Simulate async work
            // Some processing
            return "Success";
        }
        catch (Exception ex)
        {
            // Handle error
            return "Error";
        }
    }
    
    // Multiple operations with individual error handling
    public async Task<Result> ProcessMultipleOperationsAsync()
    {
        var result = new Result();
        
        try
        {
            result.Data1 = await Operation1Async();
        }
        catch (Exception ex)
        {
            result.Errors.Add($"Operation1 failed: {ex.Message}");
        }
        
        try
        {
            result.Data2 = await Operation2Async();
        }
        catch (Exception ex)
        {
            result.Errors.Add($"Operation2 failed: {ex.Message}");
        }
        
        return result;
    }
    
    private async Task<string> Operation1Async() => await Task.FromResult("Data1");
    private async Task<string> Operation2Async() => await Task.FromResult("Data2");
}

public class Result
{
    public string Data1 { get; set; }
    public string Data2 { get; set; }
    public List<string> Errors { get; set; } = new List<string>();
}
```

**Key Conversion Rules:**
1. Add `async` keyword to method signature
2. Change return type: `T` → `Task<T>`, `void` → `Task`
3. Add `Async` suffix to method name (convention)
4. Use `await` for async operations
5. Replace `.Result` or `.Wait()` with `await`

---

### 4.2 Difference Between Task vs Thread

**Description:**
Understanding the difference between Task and Thread is crucial for effective concurrent programming in .NET.

**Comparison Table:**

| Aspect | Thread | Task |
|--------|--------|------|
| **Abstraction Level** | Low-level | High-level |
| **Resource Usage** | Each thread = 1 OS thread | Uses ThreadPool, more efficient |
| **Creation Cost** | Expensive (~1MB stack) | Lightweight |
| **Return Values** | No direct support | Built-in support with `Task<T>` |
| **Cancellation** | Manual implementation | Built-in `CancellationToken` |
| **Continuation** | Manual | Easy with `ContinueWith` and `await` |
| **Exception Handling** | Try-catch in thread | Propagates to caller |
| **Recommended Use** | Rare, low-level scenarios | Default choice for async operations |

**Code Examples:**

```csharp
public class TaskVsThreadExamples
{
    // Thread Example
    public void ThreadExample()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine("Thread completed");
        });
        
        thread.Start();
        thread.Join(); // Wait for completion
    }
    
    // Task Example
    public async Task TaskExample()
    {
        await Task.Run(() =>
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Task.Delay(1000).Wait();
            Console.WriteLine("Task completed");
        });
    }
    
    // Thread - Cannot return value directly
    public int ThreadWithReturnValue()
    {
        int result = 0;
        Thread thread = new Thread(() =>
        {
            Thread.Sleep(1000);
            result = 42; // Must use shared variable
        });
        
        thread.Start();
        thread.Join();
        return result;
    }
    
    // Task - Clean return value
    public async Task<int> TaskWithReturnValue()
    {
        return await Task.Run(() =>
        {
            Task.Delay(1000).Wait();
            return 42;
        });
    }
    
    // Thread - Manual cancellation
    public void ThreadWithCancellation()
    {
        bool shouldStop = false;
        
        Thread thread = new Thread(() =>
        {
            while (!shouldStop)
            {
                Console.WriteLine("Working...");
                Thread.Sleep(100);
            }
            Console.WriteLine("Thread stopped");
        });
        
        thread.Start();
        Thread.Sleep(500);
        shouldStop = true; // Signal to stop
        thread.Join();
    }
    
    // Task - Built-in cancellation
    public async Task TaskWithCancellationAsync(CancellationToken cancellationToken)
    {
        await Task.Run(async () =>
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("Working...");
                await Task.Delay(100, cancellationToken);
            }
            Console.WriteLine("Task cancelled");
        }, cancellationToken);
    }
    
    // Thread - Manual exception handling
    public void ThreadWithException()
    {
        Exception threadException = null;
        
        Thread thread = new Thread(() =>
        {
            try
            {
                throw new InvalidOperationException("Thread error");
            }
            catch (Exception ex)
            {
                threadException = ex; // Must capture manually
            }
        });
        
        thread.Start();
        thread.Join();
        
        if (threadException != null)
        {
            Console.WriteLine($"Thread threw: {threadException.Message}");
        }
    }
    
    // Task - Automatic exception propagation
    public async Task TaskWithExceptionAsync()
    {
        try
        {
            await Task.Run(() =>
            {
                throw new InvalidOperationException("Task error");
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Task threw: {ex.Message}");
        }
    }
    
    // Thread - Multiple threads
    public void MultipleThreads()
    {
        var threads = new List<Thread>();
        
        for (int i = 0; i < 5; i++)
        {
            int taskNum = i;
            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"Thread {taskNum} on {Thread.CurrentThread.ManagedThreadId}");
            });
            threads.Add(thread);
            thread.Start();
        }
        
        // Wait for all
        foreach (var thread in threads)
        {
            thread.Join();
        }
    }
    
    // Task - Multiple tasks (more efficient)
    public async Task MultipleTasksAsync()
    {
        var tasks = new List<Task>();
        
        for (int i = 0; i < 5; i++)
        {
            int taskNum = i;
            tasks.Add(Task.Run(() =>
            {
                Console.WriteLine($"Task {taskNum} on {Thread.CurrentThread.ManagedThreadId}");
            }));
        }
        
        await Task.WhenAll(tasks);
    }
    
    // Performance Comparison
    public void PerformanceComparison()
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        
        // Create 1000 threads (very expensive!)
        // DON'T DO THIS IN PRODUCTION
        /*
        var threads = new List<Thread>();
        for (int i = 0; i < 1000; i++)
        {
            var thread = new Thread(() => Thread.Sleep(100));
            threads.Add(thread);
            thread.Start();
        }
        foreach (var t in threads) t.Join();
        */
        
        Console.WriteLine($"Threads: {sw.ElapsedMilliseconds}ms");
        sw.Restart();
        
        // Create 1000 tasks (efficient, uses ThreadPool)
        var tasks = new List<Task>();
        for (int i = 0; i < 1000; i++)
        {
            tasks.Add(Task.Run(() => Task.Delay(100).Wait()));
        }
        Task.WaitAll(tasks.ToArray());
        
        Console.WriteLine($"Tasks: {sw.ElapsedMilliseconds}ms");
    }
}
```

**When to Use Thread:**
- Need precise control over thread priority
- Long-running operations that shouldn't use ThreadPool
- Need to set apartment state (COM interop, old UI frameworks)
- Very rare scenarios

**When to Use Task (95% of cases):**
- Async I/O operations
- Parallel processing
- Web APIs and services
- Any modern asynchronous code

**Best Practices:**
```csharp
public class BestPractices
{
    // ✅ Good: Use Task for async operations
    public async Task<string> GoodExampleAsync()
    {
        return await Task.Run(() => "Result");
    }
    
    // ❌ Bad: Don't use Thread for simple async work
    public string BadExample()
    {
        string result = null;
        Thread thread = new Thread(() => result = "Result");
        thread.Start();
        thread.Join();
        return result;
    }
    
    // ✅ Good: Parallel operations with Task
    public async Task<int[]> ParallelProcessingAsync(int[] data)
    {
        var tasks = data.Select(item => Task.Run(() => Process(item)));
        return await Task.WhenAll(tasks);
    }
    
    private int Process(int item) => item * 2;
}
```

---

### 4.3 What Happens If You Don't Await?

**Description:**
Not awaiting async operations leads to "fire and forget" behavior, which can cause subtle bugs, exceptions being swallowed, and unexpected application behavior.

**Examples and Consequences:**

```csharp
public class AwaitExamples
{
    // Example 1: Fire and Forget (Dangerous!)
    public async Task BadExample()
    {
        DoSomethingAsync(); // ⚠️ Not awaited - fires and forgets!
        Console.WriteLine("This runs immediately");
    }
    
    // Example 2: Proper Await
    public async Task GoodExample()
    {
        await DoSomethingAsync(); // ✅ Waits for completion
        Console.WriteLine("This runs after DoSomethingAsync completes");
    }
    
    private async Task DoSomethingAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("Async operation completed");
    }
    
    // Example 3: Exception Swallowing
    public async Task ExceptionSwallowingExample()
    {
        // ❌ Exception is never observed!
        ThrowExceptionAsync();
        
        Console.WriteLine("Exception was thrown but we don't know about it!");
        await Task.Delay(2000); // Give time for exception to occur
    }
    
    public async Task ProperExceptionHandling()
    {
        try
        {
            // ✅ Exception is caught and handled
            await ThrowExceptionAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught exception: {ex.Message}");
        }
    }
    
    private async Task ThrowExceptionAsync()
    {
        await Task.Delay(100);
        throw new InvalidOperationException("Something went wrong!");
    }
    
    // Example 4: Return Value Lost
    public async Task LostReturnValueExample()
    {
        // ❌ Return value is lost!
        GetDataAsync();
        
        // Can't access the result
        Console.WriteLine("We can't get the data!");
    }
    
    public async Task ProperReturnValueExample()
    {
        // ✅ Can access return value
        var data = await GetDataAsync();
        Console.WriteLine($"Got data: {data}");
    }
    
    private async Task<string> GetDataAsync()
    {
        await Task.Delay(100);
        return "Important Data";
    }
    
    // Example 5: Race Conditions
    public class DataService
    {
        private List<string> _data = new List<string>();
        
        // ❌ Race condition!
        public async Task BadDataLoadingAsync()
        {
            LoadDataAsync(); // Not awaited
            
            // This might run before data is loaded!
            Console.WriteLine($"Data count: {_data.Count}");
        }
        
        // ✅ Proper synchronization
        public async Task GoodDataLoadingAsync()
        {
            await LoadDataAsync();
            
            // This runs after data is loaded
            Console.WriteLine($"Data count: {_data.Count}");
        }
        
        private async Task LoadDataAsync()
        {
            await Task.Delay(500);
            _data.AddRange(new[] { "Item1", "Item2", "Item3" });
        }
    }
    
    // Example 6: Memory Leaks with Unobserved Tasks
    public void MemoryLeakExample()
    {
        for (int i = 0; i < 1000; i++)
        {
            // ❌ These tasks keep running and holding resources
            LeakingTaskAsync(i);
        }
    }
    
    private async Task LeakingTaskAsync(int id)
    {
        await Task.Delay(10000); // Long running
        Console.WriteLine($"Task {id} completed");
    }
    
    // Example 7: Proper Fire-and-Forget (When Actually Needed)
    public async Task ProperFireAndForgetAsync()
    {
        // When you really need fire-and-forget, be explicit:
        _ = Task.Run(async () =>
        {
            try
            {
                await BackgroundOperationAsync();
            }
            catch (Exception ex)
            {
                // Log exception
                Console.WriteLine($"Background operation failed: {ex.Message}");
            }
        });
        
        Console.WriteLine("Continues immediately");
    }
    
    private async Task BackgroundOperationAsync()
    {
        await Task.Delay(5000);
        Console.WriteLine("Background operation completed");
    }
    
    // Example 8: Async void (Only for Event Handlers)
    public class AsyncVoidExample
    {
        // ❌ Never do this for regular methods
        public async void BadAsyncVoid()
        {
            await Task.Delay(100);
            throw new Exception("This exception can crash the app!");
        }
        
        // ✅ Return Task instead
        public async Task GoodAsyncTask()
        {
            await Task.Delay(100);
            // Exceptions can be caught by caller
        }
        
        // ✅ Only acceptable use: Event handlers
        public async void Button_Click(object sender, EventArgs e)
        {
            try
            {
                await ProcessClickAsync();
            }
            catch (Exception ex)
            {
                // Handle exception in event handler
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        private async Task ProcessClickAsync()
        {
            await Task.Delay(100);
        }
    }
    
    // Example 9: Comparing Behaviors
    public async Task CompareAwaitBehaviors()
    {
        Console.WriteLine("Starting comparisons...\n");
        
        // Without await
        var sw = System.Diagnostics.Stopwatch.StartNew();
        WithoutAwait();
        Console.WriteLine($"WithoutAwait returned in: {sw.ElapsedMilliseconds}ms\n");
        
        // With await
        sw.Restart();
        await WithAwait();
        Console.WriteLine($"WithAwait returned in: {sw.ElapsedMilliseconds}ms\n");
        
        await Task.Delay(2000); // Let fire-and-forget complete
    }
    
    private async Task WithoutAwait()
    {
        Task.Delay(1000); // Not awaited - method returns immediately
        Console.WriteLine("WithoutAwait method body complete");
    }
    
    private async Task WithAwait()
    {
        await Task.Delay(1000); // Awaited - method waits
        Console.WriteLine("WithAwait method body complete");
    }
}

// Example 10: Real-World Scenario - Web API
public class UserController
{
    private readonly IUserService _userService;
    private readonly IEmailService _emailService;
    
    // ❌ Bad: Not awaiting in API controller
    [HttpPost]
    public async Task<IActionResult> RegisterUserBad(UserDto userDto)
    {
        var user = await _userService.CreateUserAsync(userDto);
        
        // ❌ Email might not be sent before response returns!
        _emailService.SendWelcomeEmailAsync(user.Email);
        
        return Ok(user);
    }
    
    // ✅ Good: Await everything
    [HttpPost]
    public async Task<IActionResult> RegisterUserGood(UserDto userDto)
    {
        var user = await _userService.CreateUserAsync(userDto);
        
        // ✅ Ensures email is sent
        await _emailService.SendWelcomeEmailAsync(user.Email);
        
        return Ok(user);
    }
    
    // ✅ Good: Intentional background task
    [HttpPost]
    public async Task<IActionResult> RegisterUserWithBackgroundEmail(UserDto userDto)
    {
        var user = await _userService.CreateUserAsync(userDto);
        
        // Explicitly fire-and-forget with error handling
        _ = SendEmailInBackground(user.Email);
        
        return Ok(user);
    }
    
    private async Task SendEmailInBackground(string email)
    {
        try
        {
            await _emailService.SendWelcomeEmailAsync(email);
        }
        catch (Exception ex)
        {
            // Log error but don't fail the request
            Console.WriteLine($"Background email failed: {ex.Message}");
        }
    }
}
```

**What Actually Happens Without Await:**

1. **Method Returns Immediately**: The async method returns a `Task` but doesn't wait for it
2. **Exceptions Are Swallowed**: Unobserved exceptions may not be seen
3. **No Return Value**: Can't access the result
4. **Race Conditions**: Code continues before async operation completes
5. **Resource Issues**: Tasks may keep running after method exits

**Key Rules:**
- ✅ **Always await** async methods unless you have a specific reason not to
- ✅ Use `Task` instead of `async void` (except event handlers)
- ✅ If you must fire-and-forget, use `_ = Task.Run()` with try-catch
- ✅ Never ignore exceptions in async code
- ✅ In ASP.NET Core, always await async operations

---

## 5. Thread Safety

### 5.1 Singleton Thread-Safe Implementation

**Description:**
Thread-safe Singleton ensures only one instance exists even under concurrent access. Critical for caching, configuration, and resource management.

**Implementation Patterns:**

```csharp
// Pattern 1: Lazy<T> (Recommended - Simplest)
public class Singleton1
{
    private static readonly Lazy<Singleton1> _instance = 
        new Lazy<Singleton1>(() => new Singleton1());
    
    private Singleton1()
    {
        // Private constructor
        Console.WriteLine("Singleton1 instance created");
    }
    
    public static Singleton1 Instance => _instance.Value;
    
    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}

// Pattern 2: Double-Check Locking (Classic)
public class Singleton2
{
    private static Singleton2 _instance;
    private static readonly object _lock = new object();
    
    private Singleton2()
    {
        Console.WriteLine("Singleton2 instance created");
    }
    
    public static Singleton2 Instance
    {
        get
        {
            if (_instance == null) // First check (no lock)
            {
                lock (_lock)
                {
                    if (_instance == null) // Second check (with lock)
                    {
                        _instance = new Singleton2();
                    }
                }
            }
            return _instance;
        }
    }
}

// Pattern 3: Static Constructor (Thread-Safe by CLR)
public class Singleton3
{
    private static readonly Singleton3 _instance = new Singleton3();
    
    // Explicit static constructor tells C# not to mark type as beforefieldinit
    static Singleton3()
    {
    }
    
    private Singleton3()
    {
        Console.WriteLine("Singleton3 instance created");
    }
    
    public static Singleton3 Instance => _instance;
}

// Pattern 4: Nested Class (Lazy Initialization)
public class Singleton4
{
    private Singleton4()
    {
        Console.WriteLine("Singleton4 instance created");
    }
    
    private class Nested
    {
        // Explicit static constructor for lazy initialization
        static Nested()
        {
        }
        
        internal static readonly Singleton4 instance = new Singleton4();
    }
    
    public static Singleton4 Instance => Nested.instance;
}

// Pattern 5: Thread-Safe with Parameters
public class ConfigurationManager
{
    private static ConfigurationManager _instance;
    private static readonly object _lock = new object();
    
    public string Environment { get; private set; }
    public Dictionary<string, string> Settings { get; private set; }
    
    private ConfigurationManager(string environment)
    {
        Environment = environment;
        Settings = new Dictionary<string, string>();
        LoadConfiguration();
    }
    
    public static ConfigurationManager Initialize(string environment)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager(environment);
                }
            }
        }
        return _instance;
    }
    
    public static ConfigurationManager Instance
    {
        get
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("ConfigurationManager not initialized");
            }
            return _instance;
        }
    }
    
    private void LoadConfiguration()
    {
        // Load configuration based on environment
        Settings["DatabaseConnection"] = $"Server=db-{Environment}.example.com";
        Settings["ApiKey"] = $"key-{Environment}";
    }
}

// Pattern 6: Generic Singleton Base Class
public abstract class SingletonBase<T> where T : class
{
    private static readonly Lazy<T> _instance = new Lazy<T>(() =>
    {
        // Use reflection to create instance of derived type
        var constructor = typeof(T).GetConstructor(
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
            null, Type.EmptyTypes, null);
            
        if (constructor == null)
        {
            throw new InvalidOperationException(
                $"Type {typeof(T).Name} must have a private parameterless constructor");
        }
        
        return (T)constructor.Invoke(null);
    });
    
    public static T Instance => _instance.Value;
}

// Usage of Generic Singleton
public class Logger : SingletonBase<Logger>
{
    private Logger()
    {
        Console.WriteLine("Logger instance created");
    }
    
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }
}

// Pattern 7: Singleton with Dispose Support
public class DatabaseConnection : IDisposable
{
    private static readonly Lazy<DatabaseConnection> _instance = 
        new Lazy<DatabaseConnection>(() => new DatabaseConnection());
    
    private bool _disposed = false;
    
    private DatabaseConnection()
    {
        Console.WriteLine("Database connection established");
        // Initialize connection
    }
    
    public static DatabaseConnection Instance => _instance.Value;
    
    public void ExecuteQuery(string query)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(DatabaseConnection));
            
        Console.WriteLine($"Executing: {query}");
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose managed resources
                Console.WriteLine("Database connection closed");
            }
            _disposed = true;
        }
    }
}

// Pattern 8: Testing-Friendly Singleton
public interface ICache
{
    void Set(string key, object value);
    object Get(string key);
}

public class CacheManager : ICache
{
    private static readonly Lazy<CacheManager> _instance = 
        new Lazy<CacheManager>(() => new CacheManager());
    
    private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();
    private readonly object _lock = new object();
    
    private CacheManager() { }
    
    public static CacheManager Instance => _instance.Value;
    
    // Allow injection for testing
    public static ICache CreateTestInstance() => new CacheManager();
    
    public void Set(string key, object value)
    {
        lock (_lock)
        {
            _cache[key] = value;
        }
    }
    
    public object Get(string key)
    {
        lock (_lock)
        {
            return _cache.TryGetValue(key, out var value) ? value : null;
        }
    }
}
```

**Testing Thread Safety:**
```csharp
public class SingletonThreadSafetyTest
{
    public static void TestThreadSafety()
    {
        const int threadCount = 10;
        var instances = new System.Collections.Concurrent.ConcurrentBag<Singleton1>();
        var threads = new List<Thread>();
        
        for (int i = 0; i < threadCount; i++)
        {
            var thread = new Thread(() =>
            {
                var instance = Singleton1.Instance;
                instances.Add(instance);
            });
            threads.Add(thread);
        }
        
        // Start all threads simultaneously
        foreach (var thread in threads)
            thread.Start();
            
        // Wait for completion
        foreach (var thread in threads)
            thread.Join();
        
        // Verify all instances are the same
        var first = instances.First();
        bool allSame = instances.All(x => ReferenceEquals(x, first));
        
        Console.WriteLine($"Created {instances.Distinct().Count()} unique instance(s)");
        Console.WriteLine($"Thread-safe: {allSame}");
    }
}
```

**Example Usage:**
```csharp
// Simple usage
var logger = Logger.Instance;
logger.Log("Application started");

// Configuration with initialization
var config = ConfigurationManager.Initialize("Production");
Console.WriteLine(config.Settings["DatabaseConnection"]);

// Cache usage
CacheManager.Instance.Set("user:1", new { Name = "John", Age = 30 });
var user = CacheManager.Instance.Get("user:1");
```

**Comparison of Patterns:**

| Pattern | Lazy? | Thread-Safe? | Performance | Complexity |
|---------|-------|--------------|-------------|------------|
| Lazy<T> | Yes | Yes | Excellent | Low (Recommended) |
| Double-Check Lock | Yes | Yes | Excellent | Medium |
| Static Constructor | No | Yes | Excellent | Low |
| Nested Class | Yes | Yes | Excellent | Medium |

**Best Practices:**
- ✅ Use `Lazy<T>` for simplicity and performance
- ✅ Make constructor private
- ✅ Consider thread safety from the start
- ✅ Document why you need a Singleton
- ⚠️ Be cautious with Singletons in web applications (consider Dependency Injection instead)

---

### 5.2 Use of Lock, SemaphoreSlim, ConcurrentDictionary

**Description:**
Thread synchronization primitives protect shared resources from concurrent access. Each has specific use cases and performance characteristics.

**1. Lock (Monitor) - Basic Synchronization:**
```csharp
public class LockExamples
{
    private readonly object _lock = new object();
    private int _counter = 0;
    private List<string> _items = new List<string>();
    
    // Example 1: Protect shared counter
    public void IncrementCounter()
    {
        lock (_lock)
        {
            _counter++;
            Console.WriteLine($"Counter: {_counter}");
        }
    }
    
    // Example 2: Protect collection operations
    public void AddItem(string item)
    {
        lock (_lock)
        {
            _items.Add(item);
        }
    }
    
    public int GetCount()
    {
        lock (_lock)
        {
            return _items.Count;
        }
    }
    
    // Example 3: Multiple operations in critical section
    public void TransferFunds(Account from, Account to, decimal amount)
    {
        // Lock both accounts to prevent deadlock (always lock in same order)
        object lock1 = from.Id < to.Id ? from.Lock : to.Lock;
        object lock2 = from.Id < to.Id ? to.Lock : from.Lock;
        
        lock (lock1)
        {
            lock (lock2)
            {
                if (from.Balance >= amount)
                {
                    from.Balance -= amount;
                    to.Balance += amount;
                    Console.WriteLine($"Transferred {amount:C} from {from.Id} to {to.Id}");
                }
            }
        }
    }
    
    // Example 4: Lock with timeout (using Monitor)
    public bool TryAddItemWithTimeout(string item, int timeoutMs)
    {
        if (Monitor.TryEnter(_lock, timeoutMs))
        {
            try
            {
                _items.Add(item);
                return true;
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
        return false;
    }
}

public class Account
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public object Lock { get; } = new object();
}
```

**2. SemaphoreSlim - Limited Concurrency:**
```csharp
public class SemaphoreSlimExamples
{
    // Example 1: Limit concurrent access (e.g., API rate limiting)
    private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(3, 3); // Max 3 concurrent
    
    public async Task ProcessRequestAsync(int requestId)
    {
        Console.WriteLine($"Request {requestId} waiting...");
        
        await _semaphore.WaitAsync();
        try
        {
            Console.WriteLine($"Request {requestId} processing...");
            await Task.Delay(2000); // Simulate work
            Console.WriteLine($"Request {requestId} completed");
        }
        finally
        {
            _semaphore.Release();
        }
    }
    
    // Example 2: Database connection pool
    public class DatabaseConnectionPool
    {
        private readonly SemaphoreSlim _semaphore;
        private readonly List<DatabaseConnection> _connections;
        
        public DatabaseConnectionPool(int maxConnections)
        {
            _semaphore = new SemaphoreSlim(maxConnections, maxConnections);
            _connections = new List<DatabaseConnection>();
            
            for (int i = 0; i < maxConnections; i++)
            {
                _connections.Add(new DatabaseConnection { Id = i });
            }
        }
        
        public async Task<DatabaseConnection> AcquireConnectionAsync()
        {
            await _semaphore.WaitAsync();
            
            lock (_connections)
            {
                var connection = _connections.FirstOrDefault(c => !c.InUse);
                if (connection != null)
                {
                    connection.InUse = true;
                    return connection;
                }
            }
            
            throw new InvalidOperationException("No available connections");
        }
        
        public void ReleaseConnection(DatabaseConnection connection)
        {
            lock (_connections)
            {
                connection.InUse = false;
            }
            _semaphore.Release();
        }
    }
    
    public class DatabaseConnection
    {
        public int Id { get; set; }
        public bool InUse { get; set; }
    }
    
    // Example 3: Throttling parallel operations
    public async Task<List<string>> ProcessItemsWithThrottlingAsync(List<string> items)
    {
        var semaphore = new SemaphoreSlim(5); // Max 5 parallel operations
        var results = new System.Collections.Concurrent.ConcurrentBag<string>();
        
        var tasks = items.Select(async item =>
        {
            await semaphore.WaitAsync();
            try
            {
                var result = await ProcessItemAsync(item);
                results.Add(result);
            }
            finally
            {
                semaphore.Release();
            }
        });
        
        await Task.WhenAll(tasks);
        return results.ToList();
    }
    
    private async Task<string> ProcessItemAsync(string item)
    {
        await Task.Delay(100);
        return $"Processed: {item}";
    }
    
    // Example 4: Async lock alternative
    public class AsyncLock
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        
        public async Task<IDisposable> LockAsync()
        {
            await _semaphore.WaitAsync();
            return new ReleaseWrapper(_semaphore);
        }
        
        private class ReleaseWrapper : IDisposable
        {
            private readonly SemaphoreSlim _semaphore;
            
            public ReleaseWrapper(SemaphoreSlim semaphore)
            {
                _semaphore = semaphore;
            }
            
            public void Dispose()
            {
                _semaphore.Release();
            }
        }
    }
    
    // Usage of AsyncLock
    public async Task UseAsyncLockAsync()
    {
        var asyncLock = new AsyncLock();
        
        using (await asyncLock.LockAsync())
        {
            // Critical section
            await Task.Delay(100);
            Console.WriteLine("Protected operation completed");
        }
    }
}
```

**3. ConcurrentDictionary - Thread-Safe Collections:**
```csharp
public class ConcurrentDictionaryExamples
{
    // Example 1: Thread-safe cache
    private readonly ConcurrentDictionary<string, object> _cache = 
        new ConcurrentDictionary<string, object>();
    
    public void AddToCache(string key, object value)
    {
        _cache.TryAdd(key, value);
    }
    
    public object GetFromCache(string key)
    {
        _cache.TryGetValue(key, out var value);
        return value;
    }
    
    public object GetOrAddToCache(string key, Func<string, object> valueFactory)
    {
        return _cache.GetOrAdd(key, valueFactory);
    }
    
    // Example 2: AddOrUpdate with logic
    public void IncrementCounter(string key)
    {
        _cache.AddOrUpdate(
            key,
            1, // Add value if key doesn't exist
            (k, oldValue) => (int)oldValue + 1 // Update function
        );
    }
    
    // Example 3: Safe removal
    public bool RemoveFromCache(string key)
    {
        return _cache.TryRemove(key, out _);
    }
    
    // Example 4: User session management
    public class SessionManager
    {
        private readonly ConcurrentDictionary<string, UserSession> _sessions = 
            new ConcurrentDictionary<string, UserSession>();
        
        public UserSession CreateSession(string userId)
        {
            var session = new UserSession
            {
                SessionId = Guid.NewGuid().ToString(),
                UserId = userId,
                CreatedAt = DateTime.UtcNow,
                LastAccessedAt = DateTime.UtcNow
            };
            
            _sessions.TryAdd(session.SessionId, session);
            return session;
        }
        
        public UserSession GetSession(string sessionId)
        {
            if (_sessions.TryGetValue(sessionId, out var session))
            {
                session.LastAccessedAt = DateTime.UtcNow;
                return session;
            }
            return null;
        }
        
        public void RemoveExpiredSessions(TimeSpan timeout)
        {
            var expiredKeys = _sessions
                .Where(kvp => DateTime.UtcNow - kvp.Value.LastAccessedAt > timeout)
                .Select(kvp => kvp.Key)
                .ToList();
            
            foreach (var key in expiredKeys)
            {
                _sessions.TryRemove(key, out _);
            }
        }
    }
    
    public class UserSession
    {
        public string SessionId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastAccessedAt { get; set; }
    }
    
    // Example 5: Request counting
    public class RequestCounter
    {
        private readonly ConcurrentDictionary<string, int> _requestCounts = 
            new ConcurrentDictionary<string, int>();
        
        public void RecordRequest(string endpoint)
        {
            _requestCounts.AddOrUpdate(endpoint, 1, (key, count) => count + 1);
        }
        
        public Dictionary<string, int> GetStatistics()
        {
            return new Dictionary<string, int>(_requestCounts);
        }
        
        public void ResetCounter(string endpoint)
        {
            _requestCounts.TryRemove(endpoint, out _);
        }
    }
    
    // Example 6: TryUpdate with condition
    public bool UpdateIfMatches(string key, object newValue, object expectedValue)
    {
        return _cache.TryUpdate(key, newValue, expectedValue);
    }
    
    // Example 7: Batch operations
    public void AddMultiple(Dictionary<string, object> items)
    {
        foreach (var item in items)
        {
            _cache.TryAdd(item.Key, item.Value);
        }
    }
    
    // Example 8: Clear all (no direct Clear in some scenarios)
    public void ClearCache()
    {
        _cache.Clear();
    }
}

// Additional Concurrent Collections
public class OtherConcurrentCollections
{
    // ConcurrentBag - Unordered collection
    private readonly System.Collections.Concurrent.ConcurrentBag<string> _bag = 
        new System.Collections.Concurrent.ConcurrentBag<string>();
    
    public void AddToBag(string item)
    {
        _bag.Add(item);
    }
    
    public bool TryTakeFromBag(out string item)
    {
        return _bag.TryTake(out item);
    }
    
    // ConcurrentQueue - FIFO
    private readonly System.Collections.Concurrent.ConcurrentQueue<string> _queue = 
        new System.Collections.Concurrent.ConcurrentQueue<string>();
    
    public void Enqueue(string item)
    {
        _queue.Enqueue(item);
    }
    
    public bool TryDequeue(out string item)
    {
        return _queue.TryDequeue(out item);
    }
    
    // ConcurrentStack - LIFO
    private readonly System.Collections.Concurrent.ConcurrentStack<string> _stack = 
        new System.Collections.Concurrent.ConcurrentStack<string>();
    
    public void Push(string item)
    {
        _stack.Push(item);
    }
    
    public bool TryPop(out string item)
    {
        return _stack.TryPop(out item);
    }
}
```

**Comparison Table:**

| Mechanism | Use Case | Performance | Async Support | Complexity |
|-----------|----------|-------------|---------------|------------|
| **lock** | Simple mutual exclusion | Fast | No (blocks thread) | Low |
| **SemaphoreSlim** | Limited concurrency, async | Medium | Yes | Medium |
| **ConcurrentDictionary** | Thread-safe collections | Fast | N/A (lock-free) | Low |
| **Monitor** | lock with timeout/wait | Fast | No | Medium |
| **Mutex** | Cross-process sync | Slow | No | High |
| **ReaderWriterLockSlim** | Many readers, few writers | Medium | No | Medium |

**Best Practices:**
```csharp
public class BestPractices
{
    // ✅ Keep critical sections small
    private readonly object _lock = new object();
    private int _counter;
    
    public void GoodLock()
    {
        lock (_lock)
        {
            _counter++; // Fast operation only
        }
    }
    
    // ❌ Don't lock for long operations
    public void BadLock()
    {
        lock (_lock)
        {
            Thread.Sleep(5000); // Don't do this!
            _counter++;
        }
    }
    
    // ✅ Use SemaphoreSlim for async
    private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);
    
    public async Task GoodAsyncLock()
    {
        await _semaphore.WaitAsync();
        try
        {
            await Task.Delay(100); // Async operation
        }
        finally
        {
            _semaphore.Release();
        }
    }
    
    // ✅ Use ConcurrentDictionary instead of lock + Dictionary
    private readonly ConcurrentDictionary<string, int> _dict = 
        new ConcurrentDictionary<string, int>();
    
    public void GoodConcurrentAccess()
    {
        _dict.AddOrUpdate("key", 1, (k, v) => v + 1);
    }
}
```

---

## 6. Object-Oriented Design

### 6.1 Implement Factory Pattern

**Description:**
Factory Pattern provides an interface for creating objects without specifying their exact classes. Essential for loosely coupled, maintainable code.

**Implementation:**

```csharp
// Simple Factory Pattern
public interface IPayment
{
    void Pay(decimal amount);
    string GetPaymentMethod();
}

public class CreditCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
        // Credit card specific logic
    }
    
    public string GetPaymentMethod() => "Credit Card";
}

public class PayPalPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
        // PayPal specific logic
    }
    
    public string GetPaymentMethod() => "PayPal";
}

public class CryptoPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Processing cryptocurrency payment of {amount:C}");
        // Crypto specific logic
    }
    
    public string GetPaymentMethod() => "Cryptocurrency";
}

// Simple Factory
public class PaymentFactory
{
    public static IPayment CreatePayment(string paymentType)
    {
        return paymentType.ToLower() switch
        {
            "creditcard" => new CreditCardPayment(),
            "paypal" => new PayPalPayment(),
            "crypto" => new CryptoPayment(),
            _ => throw new ArgumentException($"Unknown payment type: {paymentType}")
        };
    }
}

// Factory Method Pattern (More flexible)
public abstract class PaymentProcessor
{
    // Factory method
    public abstract IPayment CreatePayment();
    
    // Template method using factory method
    public void ProcessOrder(decimal amount)
    {
        var payment = CreatePayment();
        Console.WriteLine($"Using {payment.GetPaymentMethod()}");
        payment.Pay(amount);
        Console.WriteLine("Payment processed successfully");
    }
}

public class CreditCardProcessor : PaymentProcessor
{
    public override IPayment CreatePayment()
    {
        return new CreditCardPayment();
    }
}

public class PayPalProcessor : PaymentProcessor
{
    public override IPayment CreatePayment()
    {
        return new PayPalPayment();
    }
}

// Abstract Factory Pattern (Family of related objects)
public interface IUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
    ICheckBox CreateCheckBox();
}

public interface IButton
{
    void Render();
}

public interface ITextBox
{
    void Render();
}

public interface ICheckBox
{
    void Render();
}

// Windows implementation
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Windows-style button");
}

public class WindowsTextBox : ITextBox
{
    public void Render() => Console.WriteLine("Rendering Windows-style textbox");
}

public class WindowsCheckBox : ICheckBox
{
    public void Render() => Console.WriteLine("Rendering Windows-style checkbox");
}

// Mac implementation
public class MacButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Mac-style button");
}

public class MacTextBox : ITextBox
{
    public void Render() => Console.WriteLine("Rendering Mac-style textbox");
}

public class MacCheckBox : ICheckBox
{
    public void Render() => Console.WriteLine("Rendering Mac-style checkbox");
}

// Factories
public class WindowsUIFactory : IUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ITextBox CreateTextBox() => new WindowsTextBox();
    public ICheckBox CreateCheckBox() => new WindowsCheckBox();
}

public class MacUIFactory : IUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ITextBox CreateTextBox() => new MacTextBox();
    public ICheckBox CreateCheckBox() => new MacCheckBox();
}

// Client code
public class Application
{
    private readonly IUIFactory _uiFactory;
    
    public Application(IUIFactory uiFactory)
    {
        _uiFactory = uiFactory;
    }
    
    public void CreateUI()
    {
        var button = _uiFactory.CreateButton();
        var textBox = _uiFactory.CreateTextBox();
        var checkBox = _uiFactory.CreateCheckBox();
        
        button.Render();
        textBox.Render();
        checkBox.Render();
    }
}

// Real-world example: Database Connection Factory
public interface IDatabase
{
    void Connect();
    void ExecuteQuery(string query);
    void Disconnect();
}

public class SqlServerDatabase : IDatabase
{
    public void Connect() => Console.WriteLine("Connected to SQL Server");
    public void ExecuteQuery(string query) => Console.WriteLine($"SQL Server executing: {query}");
    public void Disconnect() => Console.WriteLine("Disconnected from SQL Server");
}

public class PostgreSqlDatabase : IDatabase
{
    public void Connect() => Console.WriteLine("Connected to PostgreSQL");
    public void ExecuteQuery(string query) => Console.WriteLine($"PostgreSQL executing: {query}");
    public void Disconnect() => Console.WriteLine("Disconnected from PostgreSQL");
}

public class MongoDatabase : IDatabase
{
    public void Connect() => Console.WriteLine("Connected to MongoDB");
    public void ExecuteQuery(string query) => Console.WriteLine($"MongoDB executing: {query}");
    public void Disconnect() => Console.WriteLine("Disconnected from MongoDB");
}

public class DatabaseFactory
{
    public static IDatabase CreateDatabase(string connectionString)
    {
        if (connectionString.Contains("sqlserver", StringComparison.OrdinalIgnoreCase))
            return new SqlServerDatabase();
        if (connectionString.Contains("postgresql", StringComparison.OrdinalIgnoreCase))
            return new PostgreSqlDatabase();
        if (connectionString.Contains("mongodb", StringComparison.OrdinalIgnoreCase))
            return new MongoDatabase();
            
        throw new ArgumentException("Unknown database type");
    }
}
```

**Example Usage:**
```csharp
// Simple Factory
var payment = PaymentFactory.CreatePayment("creditcard");
payment.Pay(100.50m);

// Factory Method
PaymentProcessor processor = new CreditCardProcessor();
processor.ProcessOrder(250.00m);

// Abstract Factory
IUIFactory factory = new WindowsUIFactory();
var app = new Application(factory);
app.CreateUI();

// Database Factory
var db = DatabaseFactory.CreateDatabase("Server=localhost;Database=mydb;Provider=sqlserver");
db.Connect();
db.ExecuteQuery("SELECT * FROM Users");
db.Disconnect();
```

**Benefits:**
- Loose coupling between client and concrete classes
- Easy to extend with new types
- Single Responsibility Principle
- Open/Closed Principle

---

### 6.2 Strategy Pattern Use Case

**Description:**
Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Perfect for when behavior needs to change at runtime.

**Implementation:**

```csharp
// Strategy Interface
public interface IShippingStrategy
{
    decimal CalculateShippingCost(decimal orderTotal, decimal weight);
    string GetShippingMethod();
}

// Concrete Strategies
public class StandardShipping : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderTotal, decimal weight)
    {
        return weight * 5m; // $5 per kg
    }
    
    public string GetShippingMethod() => "Standard Shipping (5-7 days)";
}

public class ExpressShipping : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderTotal, decimal weight)
    {
        return weight * 10m + 15m; // $10 per kg + $15 handling
    }
    
    public string GetShippingMethod() => "Express Shipping (2-3 days)";
}

public class OvernightShipping : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderTotal, decimal weight)
    {
        return weight * 20m + 25m; // $20 per kg + $25 handling
    }
    
    public string GetShippingMethod() => "Overnight Shipping (Next day)";
}

public class FreeShipping : IShippingStrategy
{
    private readonly decimal _minimumOrder;
    
    public FreeShipping(decimal minimumOrder = 100m)
    {
        _minimumOrder = minimumOrder;
    }
    
    public decimal CalculateShippingCost(decimal orderTotal, decimal weight)
    {
        return orderTotal >= _minimumOrder ? 0 : weight * 5m;
    }
    
    public string GetShippingMethod() => $"Free Shipping (Orders over ${_minimumOrder})";
}

// Context
public class ShoppingCart
{
    private IShippingStrategy _shippingStrategy;
    private List<CartItem> _items = new List<CartItem>();
    
    public void AddItem(string name, decimal price, decimal weight)
    {
        _items.Add(new CartItem { Name = name, Price = price, Weight = weight });
    }
    
    public void SetShippingStrategy(IShippingStrategy strategy)
    {
        _shippingStrategy = strategy;
    }
    
    public decimal GetTotal()
    {
        return _items.Sum(i => i.Price);
    }
    
    public decimal GetTotalWeight()
    {
        return _items.Sum(i => i.Weight);
    }
    
    public void Checkout()
    {
        if (_shippingStrategy == null)
        {
            Console.WriteLine("Please select a shipping method");
            return;
        }
        
        decimal subtotal = GetTotal();
        decimal weight = GetTotalWeight();
        decimal shippingCost = _shippingStrategy.CalculateShippingCost(subtotal, weight);
        decimal total = subtotal + shippingCost;
        
        Console.WriteLine("===== Order Summary =====");
        Console.WriteLine($"Subtotal: {subtotal:C}");
        Console.WriteLine($"Shipping ({_shippingStrategy.GetShippingMethod()}): {shippingCost:C}");
        Console.WriteLine($"Total: {total:C}");
    }
}

public class CartItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Weight { get; set; }
}

// Real-world example: Payment processing
public interface IPaymentStrategy
{
    bool ProcessPayment(decimal amount);
    string GetPaymentType();
}

public class CreditCardStrategy : IPaymentStrategy
{
    private readonly string _cardNumber;
    
    public CreditCardStrategy(string cardNumber)
    {
        _cardNumber = cardNumber;
    }
    
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount:C} via Credit Card ending in {_cardNumber.Substring(_cardNumber.Length - 4)}");
        // Actual payment processing logic
        return true;
    }
    
    public string GetPaymentType() => "Credit Card";
}

public class PayPalStrategy : IPaymentStrategy
{
    private readonly string _email;
    
    public PayPalStrategy(string email)
    {
        _email = email;
    }
    
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount:C} via PayPal account {_email}");
        // PayPal API integration
        return true;
    }
    
    public string GetPaymentType() => "PayPal";
}

// Compression Strategy Example
public interface ICompressionStrategy
{
    byte[] Compress(byte[] data);
    byte[] Decompress(byte[] data);
    string GetCompressionType();
}

public class ZipCompression : ICompressionStrategy
{
    public byte[] Compress(byte[] data)
    {
        Console.WriteLine("Compressing with ZIP algorithm");
        // Actual ZIP compression
        return data;
    }
    
    public byte[] Decompress(byte[] data)
    {
        Console.WriteLine("Decompressing ZIP data");
        return data;
    }
    
    public string GetCompressionType() => "ZIP";
}

public class GzipCompression : ICompressionStrategy
{
    public byte[] Compress(byte[] data)
    {
        Console.WriteLine("Compressing with GZIP algorithm");
        // Actual GZIP compression
        return data;
    }
    
    public byte[] Decompress(byte[] data)
    {
        Console.WriteLine("Decompressing GZIP data");
        return data;
    }
    
    public string GetCompressionType() => "GZIP";
}

public class FileCompressor
{
    private ICompressionStrategy _strategy;
    
    public void SetCompressionStrategy(ICompressionStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public void CompressFile(string filePath)
    {
        if (_strategy == null)
            throw new InvalidOperationException("Compression strategy not set");
            
        // Read file
        byte[] fileData = new byte[] { }; // Simulated
        
        Console.WriteLine($"Compressing {filePath} using {_strategy.GetCompressionType()}");
        byte[] compressed = _strategy.Compress(fileData);
        Console.WriteLine("File compressed successfully");
    }
}

// Sorting Strategy Example
public interface ISortStrategy<T>
{
    void Sort(List<T> list);
    string GetSortAlgorithm();
}

public class QuickSort<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(List<T> list)
    {
        Console.WriteLine("Sorting using QuickSort");
        list.Sort(); // Simplified
    }
    
    public string GetSortAlgorithm() => "QuickSort";
}

public class MergeSort<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(List<T> list)
    {
        Console.WriteLine("Sorting using MergeSort");
        list.Sort(); // Simplified
    }
    
    public string GetSortAlgorithm() => "MergeSort";
}

public class DataSorter<T> where T : IComparable<T>
{
    private ISortStrategy<T> _strategy;
    
    public void SetStrategy(ISortStrategy<T> strategy)
    {
        _strategy = strategy;
    }
    
    public void SortData(List<T> data)
    {
        Console.WriteLine($"Using {_strategy.GetSortAlgorithm()} to sort {data.Count} items");
        _strategy.Sort(data);
    }
}
```

**Example Usage:**
```csharp
// Shipping example
var cart = new ShoppingCart();
cart.AddItem("Laptop", 1200m, 2.5m);
cart.AddItem("Mouse", 25m, 0.2m);

// Try different shipping strategies
cart.SetShippingStrategy(new StandardShipping());
cart.Checkout();

Console.WriteLine();

cart.SetShippingStrategy(new ExpressShipping());
cart.Checkout();

Console.WriteLine();

cart.SetShippingStrategy(new FreeShipping(100m));
cart.Checkout();

// Payment example
IPaymentStrategy payment = new CreditCardStrategy("1234567890123456");
payment.ProcessPayment(500m);

// Compression example
var compressor = new FileCompressor();
compressor.SetCompressionStrategy(new ZipCompression());
compressor.CompressFile("document.pdf");

compressor.SetCompressionStrategy(new GzipCompression());
compressor.CompressFile("archive.tar");
```

**When to Use Strategy Pattern:**
- Multiple algorithms for a specific task
- Need to switch algorithms at runtime
- Want to isolate algorithm implementation details
- Avoid conditional statements for selecting behavior

**Benefits:**
- Open/Closed Principle
- Single Responsibility Principle
- Eliminates conditional statements
- Easy to add new strategies

---

### 6.3 SOLID Principle Coding Examples

**Description:**
SOLID principles are fundamental to writing maintainable, scalable object-oriented code.

**1. Single Responsibility Principle (SRP)**
```csharp
// ❌ Bad: Multiple responsibilities
public class UserService
{
    public void CreateUser(string name, string email)
    {
        // Validate user
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name is required");
            
        // Save to database
        Console.WriteLine($"Saving user {name} to database");
        
        // Send email
        Console.WriteLine($"Sending welcome email to {email}");
        
        // Log activity
        Console.WriteLine($"User {name} created at {DateTime.Now}");
    }
}

// ✅ Good: Single responsibility per class
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class UserValidator
{
    public void Validate(User user)
    {
        if (string.IsNullOrEmpty(user.Name))
            throw new ArgumentException("Name is required");
        if (string.IsNullOrEmpty(user.Email))
            throw new ArgumentException("Email is required");
    }
}

public class UserRepository
{
    public void Save(User user)
    {
        Console.WriteLine($"Saving user {user.Name} to database");
    }
}

public class EmailService
{
    public void SendWelcomeEmail(string email)
    {
        Console.WriteLine($"Sending welcome email to {email}");
    }
}

public class ActivityLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}

public class UserServiceGood
{
    private readonly UserValidator _validator;
    private readonly UserRepository _repository;
    private readonly EmailService _emailService;
    private readonly ActivityLogger _logger;
    
    public UserServiceGood(
        UserValidator validator,
        UserRepository repository,
        EmailService emailService,
        ActivityLogger logger)
    {
        _validator = validator;
        _repository = repository;
        _emailService = emailService;
        _logger = logger;
    }
    
    public void CreateUser(User user)
    {
        _validator.Validate(user);
        _repository.Save(user);
        _emailService.SendWelcomeEmail(user.Email);
        _logger.Log($"User {user.Name} created");
    }
}
```

**2. Open/Closed Principle (OCP)**
```csharp
// ❌ Bad: Modified for each new shape
public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
        // Need to modify class to add new shape
        else if (shape is Triangle triangle)
        {
            return 0.5 * triangle.Base * triangle.Height;
        }
        
        throw new ArgumentException("Unknown shape");
    }
}

// ✅ Good: Open for extension, closed for modification
public interface IShape
{
    double CalculateArea();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public double CalculateArea() => Width * Height;
}

public class Circle : IShape
{
    public double Radius { get; set; }
    
    public double CalculateArea() => Math.PI * Radius * Radius;
}

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    
    public double CalculateArea() => 0.5 * Base * Height;
}

public class AreaCalculatorGood
{
    public double CalculateTotalArea(List<IShape> shapes)
    {
        return shapes.Sum(shape => shape.CalculateArea());
    }
}
```

**3. Liskov Substitution Principle (LSP)**
```csharp
// ❌ Bad: Violates LSP
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Penguins can't fly!"); // Breaks LSP
    }
}

// ✅ Good: Follows LSP
public abstract class Bird
{
    public abstract void Move();
}

public interface IFlyable
{
    void Fly();
}

public class Sparrow : Bird, IFlyable
{
    public override void Move()
    {
        Fly();
    }
    
    public void Fly()
    {
        Console.WriteLine("Sparrow flying...");
    }
}

public class Penguin : Bird
{
    public override void Move()
    {
        Swim();
    }
    
    public void Swim()
    {
        Console.WriteLine("Penguin swimming...");
    }
}

// Real-world example: Payment processing
public abstract class PaymentProcessor
{
    public abstract bool ProcessPayment(decimal amount);
    public abstract bool CanRefund();
}

public class CreditCardProcessor : PaymentProcessor
{
    public override bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment: {amount:C}");
        return true;
    }
    
    public override bool CanRefund() => true;
}

public class GiftCardProcessor : PaymentProcessor
{
    public override bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing gift card payment: {amount:C}");
        return true;
    }
    
    public override bool CanRefund() => false; // Gift cards can't be refunded
}
```

**4. Interface Segregation Principle (ISP)**
```csharp
// ❌ Bad: Fat interface
public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Human : IWorker
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat() => Console.WriteLine("Eating...");
    public void Sleep() => Console.WriteLine("Sleeping...");
}

public class Robot : IWorker
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat() => throw new NotImplementedException(); // Doesn't eat!
    public void Sleep() => throw new NotImplementedException(); // Doesn't sleep!
}

// ✅ Good: Segregated interfaces
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

public class Human : IWorkable, IFeedable, ISleepable
{
    public void Work() => Console.WriteLine("Human working...");
    public void Eat() => Console.WriteLine("Human eating...");
    public void Sleep() => Console.WriteLine("Human sleeping...");
}

public class Robot : IWorkable
{
    public void Work() => Console.WriteLine("Robot working...");
}

// Real-world example: Document management
public interface IReadable
{
    string Read();
}

public interface IWritable
{
    void Write(string content);
}

public interface IPrintable
{
    void Print();
}

public class Document : IReadable, IWritable, IPrintable
{
    public string Content { get; set; }
    
    public string Read() => Content;
    public void Write(string content) => Content = content;
    public void Print() => Console.WriteLine($"Printing: {Content}");
}

public class ReadOnlyDocument : IReadable
{
    public string Content { get; set; }
    
    public string Read() => Content;
}
```

**5. Dependency Inversion Principle (DIP)**
```csharp
// ❌ Bad: High-level depends on low-level
public class EmailSender
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending email to {to}");
    }
}

public class NotificationService
{
    private EmailSender _emailSender = new EmailSender(); // Tight coupling
    
    public void Notify(string message)
    {
        _emailSender.SendEmail("user@example.com", "Notification", message);
    }
}

// ✅ Good: Both depend on abstraction
public interface IMessageSender
{
    void Send(string to, string subject, string body);
}

public class EmailSender : IMessageSender
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"Sending email to {to}: {subject}");
    }
}

public class SmsSender : IMessageSender
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"Sending SMS to {to}: {body}");
    }
}

public class PushNotificationSender : IMessageSender
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"Sending push notification to {to}: {body}");
    }
}

public class NotificationServiceGood
{
    private readonly IMessageSender _messageSender;
    
    public NotificationServiceGood(IMessageSender messageSender)
    {
        _messageSender = messageSender; // Dependency injection
    }
    
    public void Notify(string to, string message)
    {
        _messageSender.Send(to, "Notification", message);
    }
}

// Real-world example: Data access
public interface IRepository<T>
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}

public class SqlRepository<T> : IRepository<T>
{
    public async Task<T> GetByIdAsync(int id)
    {
        Console.WriteLine($"Getting {typeof(T).Name} from SQL database");
        await Task.Delay(10);
        return default(T);
    }
    
    public async Task<List<T>> GetAllAsync()
    {
        Console.WriteLine($"Getting all {typeof(T).Name} from SQL database");
        await Task.Delay(10);
        return new List<T>();
    }
    
    public async Task AddAsync(T entity)
    {
        Console.WriteLine($"Adding {typeof(T).Name} to SQL database");
        await Task.Delay(10);
    }
    
    public async Task UpdateAsync(T entity)
    {
        Console.WriteLine($"Updating {typeof(T).Name} in SQL database");
        await Task.Delay(10);
    }
    
    public async Task DeleteAsync(int id)
    {
        Console.WriteLine($"Deleting {typeof(T).Name} from SQL database");
        await Task.Delay(10);
    }
}

public class ProductService
{
    private readonly IRepository<Product> _repository;
    
    public ProductService(IRepository<Product> repository)
    {
        _repository = repository;
    }
    
    public async Task<Product> GetProductAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

**Example Usage:**
```csharp
// SRP
var validator = new UserValidator();
var repository = new UserRepository();
var emailService = new EmailService();
var logger = new ActivityLogger();
var userService = new UserServiceGood(validator, repository, emailService, logger);

var user = new User { Name = "John Doe", Email = "john@example.com" };
userService.CreateUser(user);

// OCP
var shapes = new List<IShape>
{
    new Rectangle { Width = 5, Height = 10 },
    new Circle { Radius = 7 },
    new Triangle { Base = 6, Height = 8 }
};

var calculator = new AreaCalculatorGood();
double totalArea = calculator.CalculateTotalArea(shapes);

// DIP
IMessageSender emailSender = new EmailSender();
var notificationService = new NotificationServiceGood(emailSender);
notificationService.Notify("user@example.com", "Hello from SOLID!");
```

---

### 6.4 Create Immutable Class

**Description:**
Immutable classes cannot be modified after creation. Essential for thread safety, caching, and functional programming.

**Implementation:**

```csharp
// Basic Immutable Class
public class ImmutablePerson
{
    public string FirstName { get; }
    public string LastName { get; }
    public DateTime DateOfBirth { get; }
    
    public ImmutablePerson(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        DateOfBirth = dateOfBirth;
    }
    
    // Return new instance for modifications
    public ImmutablePerson WithFirstName(string firstName)
    {
        return new ImmutablePerson(firstName, LastName, DateOfBirth);
    }
    
    public ImmutablePerson WithLastName(string lastName)
    {
        return new ImmutablePerson(FirstName, lastName, DateOfBirth);
    }
}

// Immutable with Collection
public class ImmutableOrder
{
    public int OrderId { get; }
    public DateTime OrderDate { get; }
    public IReadOnlyList<OrderItem> Items { get; }
    public decimal TotalAmount { get; }
    
    public ImmutableOrder(int orderId, DateTime orderDate, IEnumerable<OrderItem> items)
    {
        OrderId = orderId;
        OrderDate = orderDate;
        // Create defensive copy
        Items = new List<OrderItem>(items).AsReadOnly();
        TotalAmount = Items.Sum(i => i.Price * i.Quantity);
    }
    
    public ImmutableOrder AddItem(OrderItem item)
    {
        var newItems = Items.ToList();
        newItems.Add(item);
        return new ImmutableOrder(OrderId, OrderDate, newItems);
    }
}

public class OrderItem
{
    public string ProductName { get; }
    public decimal Price { get; }
    public int Quantity { get; }
    
    public OrderItem(string productName, decimal price, int quantity)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }
}

// Using C# 9+ Records (Best approach for immutability)
public record PersonRecord(string FirstName, string LastName, DateTime DateOfBirth)
{
    public int Age => DateTime.Now.Year - DateOfBirth.Year;
}

// Record with additional logic
public record BankAccount(string AccountNumber, decimal Balance, string Owner)
{
    // Derived property
    public string AccountType => Balance >= 10000 ? "Premium" : "Standard";
    
    // With expressions for creating modified copies
    public BankAccount Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be positive");
            
        return this with { Balance = Balance + amount };
    }
    
    public BankAccount Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be positive");
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds");
            
        return this with { Balance = Balance - amount };
    }
}

// Immutable Complex Object
public sealed class ImmutableAddress
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string ZipCode { get; }
    public string Country { get; }
    
    public ImmutableAddress(
        string street,
        string city,
        string state,
        string zipCode,
        string country)
    {
        Street = street ?? throw new ArgumentNullException(nameof(street));
        City = city ?? throw new ArgumentNullException(nameof(city));
        State = state ?? throw new ArgumentNullException(nameof(state));
        ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
        Country = country ?? throw new ArgumentNullException(nameof(country));
    }
    
    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}, {Country}";
    }
    
    public override bool Equals(object obj)
    {
        if (obj is not ImmutableAddress other)
            return false;
            
        return Street == other.Street &&
               City == other.City &&
               State == other.State &&
               ZipCode == other.ZipCode &&
               Country == other.Country;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Street, City, State, ZipCode, Country);
    }
}

// Immutable with Builder Pattern
public class ImmutableUser
{
    public int Id { get; }
    public string Username { get; }
    public string Email { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public DateTime CreatedAt { get; }
    public IReadOnlyList<string> Roles { get; }
    
    private ImmutableUser(Builder builder)
    {
        Id = builder.Id;
        Username = builder.Username;
        Email = builder.Email;
        FirstName = builder.FirstName;
        LastName = builder.LastName;
        CreatedAt = builder.CreatedAt;
        Roles = new List<string>(builder.Roles).AsReadOnly();
    }
    
    public class Builder
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<string> Roles { get; set; } = new List<string>();
        
        public Builder WithId(int id)
        {
            Id = id;
            return this;
        }
        
        public Builder WithUsername(string username)
        {
            Username = username;
            return this;
        }
        
        public Builder WithEmail(string email)
        {
            Email = email;
            return this;
        }
        
        public Builder WithName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            return this;
        }
        
        public Builder WithRole(string role)
        {
            Roles.Add(role);
            return this;
        }
        
        public ImmutableUser Build()
        {
            // Validation
            if (string.IsNullOrEmpty(Username))
                throw new InvalidOperationException("Username is required");
            if (string.IsNullOrEmpty(Email))
                throw new InvalidOperationException("Email is required");
                
            return new ImmutableUser(this);
        }
    }
}

// Thread-safe Singleton with Immutable Configuration
public sealed class AppConfiguration
{
    private static readonly Lazy<AppConfiguration> _instance = 
        new Lazy<AppConfiguration>(() => new AppConfiguration());
    
    public string DatabaseConnection { get; }
    public string ApiKey { get; }
    public int MaxRetries { get; }
    public TimeSpan Timeout { get; }
    
    private AppConfiguration()
    {
        // Load from config file
        DatabaseConnection = "Server=localhost;Database=myapp";
        ApiKey = "api-key-12345";
        MaxRetries = 3;
        Timeout = TimeSpan.FromSeconds(30);
    }
    
    public static AppConfiguration Instance => _instance.Value;
}
```

**Example Usage:**
```csharp
// Basic immutable class
var person = new ImmutablePerson("John", "Doe", new DateTime(1990, 1, 1));
var updatedPerson = person.WithFirstName("Jane"); // Creates new instance

// Record (C# 9+)
var personRecord = new PersonRecord("John", "Doe", new DateTime(1990, 1, 1));
var updated = personRecord with { FirstName = "Jane" }; // Non-destructive mutation

// Bank account
var account = new BankAccount("123456", 1000m, "John Doe");
var afterDeposit = account.Deposit(500m);
Console.WriteLine($"Original: {account.Balance:C}"); // $1,000.00
Console.WriteLine($"After deposit: {afterDeposit.Balance:C}"); // $1,500.00

// Immutable collection
var items = new List<OrderItem>
{
    new OrderItem("Product A", 10m, 2),
    new OrderItem("Product B", 20m, 1)
};

var order = new ImmutableOrder(1, DateTime.Now, items);
var orderWithNewItem = order.AddItem(new OrderItem("Product C", 15m, 3));

// Builder pattern
var user = new ImmutableUser.Builder()
    .WithId(1)
    .WithUsername("johndoe")
    .WithEmail("john@example.com")
    .WithName("John", "Doe")
    .WithRole("Admin")
    .WithRole("User")
    .Build();
```

**Key Principles:**
1. All fields are `readonly` or have only getters
2. Initialize all fields in constructor
3. No setters or mutating methods
4. Return new instances for modifications
5. Make defensive copies of collections
6. Mark class as `sealed` if possible

---

### 6.5 Benefits of Immutability in Multithreaded Apps

**Description:**
Immutability eliminates race conditions, simplifies concurrent code, and improves application reliability.

**Benefits and Examples:**

```csharp
// 1. Thread Safety Without Locks
public class ThreadSafetyDemo
{
    // ❌ Mutable (requires locks)
    public class MutableCounter
    {
        private int _count;
        private readonly object _lock = new object();
        
        public void Increment()
        {
            lock (_lock) // Need lock!
            {
                _count++;
            }
        }
        
        public int GetCount()
        {
            lock (_lock) // Need lock!
            {
                return _count;
            }
        }
    }
    
    // ✅ Immutable (no locks needed)
    public record ImmutableCounter(int Count)
    {
        public ImmutableCounter Increment()
        {
            return this with { Count = Count + 1 };
        }
    }
}

// 2. Safe Sharing Across Threads
public class DataSharingDemo
{
    // ✅ Safe to share immutable data
    public record UserData(int Id, string Name, string Email);
    
    public void ProcessUserDataSafely(UserData userData)
    {
        // Can safely pass to multiple threads
        var tasks = new List<Task>();
        
        for (int i = 0; i < 10; i++)
        {
            tasks.Add(Task.Run(() =>
            {
                // No race conditions - userData can't change
                Console.WriteLine($"Processing user: {userData.Name}");
                Task.Delay(100).Wait();
                Console.WriteLine($"Completed for: {userData.Name}");
            }));
        }
        
        Task.WaitAll(tasks.ToArray());
    }
}

// 3. Cache Safely
public class CachingDemo
{
    private readonly ConcurrentDictionary<int, UserProfile> _cache = 
        new ConcurrentDictionary<int, UserProfile>();
    
    // ✅ Immutable - safe to cache
    public record UserProfile(
        int Id,
        string Name,
        string Email,
        DateTime LastLoginDate,
        IReadOnlyList<string> Permissions);
    
    public UserProfile GetUserProfile(int userId)
    {
        return _cache.GetOrAdd(userId, id =>
        {
            // Load from database
            var permissions = new List<string> { "Read", "Write" }.AsReadOnly();
            return new UserProfile(
                id,
                $"User{id}",
                $"user{id}@example.com",
                DateTime.UtcNow,
                permissions);
        });
        
        // Safe to return cached instance - it can't be modified
    }
}

// 4. Easier Reasoning About Code
public class StateManagementDemo
{
    // ✅ Clear state transitions with immutable objects
    public record GameState(
        int Level,
        int Score,
        int Lives,
        IReadOnlyList<string> Inventory)
    {
        public GameState LevelUp()
        {
            return this with { Level = Level + 1, Score = Score + 1000 };
        }
        
        public GameState AddScore(int points)
        {
            return this with { Score = Score + points };
        }
        
        public GameState LoseLife()
        {
            return this with { Lives = Lives - 1 };
        }
        
        public GameState AddItem(string item)
        {
            var newInventory = Inventory.ToList();
            newInventory.Add(item);
            return this with { Inventory = newInventory.AsReadOnly() };
        }
    }
    
    public void PlayGame()
    {
        GameState state = new GameState(
            Level: 1,
            Score: 0,
            Lives: 3,
            Inventory: new List<string>().AsReadOnly());
        
        // Each operation creates new state - easy to track changes
        state = state.AddScore(100);
        state = state.AddItem("Sword");
        state = state.LevelUp();
        state = state.LoseLife();
        
        Console.WriteLine($"Level: {state.Level}, Score: {state.Score}, Lives: {state.Lives}");
    }
}

// 5. Undo/Redo Functionality
public class UndoRedoDemo
{
    private Stack<DocumentState> _undoStack = new Stack<DocumentState>();
    private Stack<DocumentState> _redoStack = new Stack<DocumentState>();
    private DocumentState _currentState;
    
    public record DocumentState(string Content, int CursorPosition);
    
    public UndoRedoDemo()
    {
        _currentState = new DocumentState("", 0);
    }
    
    public void EditDocument(string newContent, int cursorPosition)
    {
        _undoStack.Push(_currentState);
        _currentState = new DocumentState(newContent, cursorPosition);
        _redoStack.Clear(); // Clear redo stack on new edit
    }
    
    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            _redoStack.Push(_currentState);
            _currentState = _undoStack.Pop();
        }
    }
    
    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            _undoStack.Push(_currentState);
            _currentState = _redoStack.Pop();
        }
    }
    
    public string GetContent() => _currentState.Content;
}

// 6. Event Sourcing Pattern
public class EventSourcingDemo
{
    public record OrderCreatedEvent(int OrderId, DateTime CreatedAt);
    public record ItemAddedEvent(int OrderId, string ProductId, int Quantity);
    public record OrderShippedEvent(int OrderId, string TrackingNumber);
    
    public record OrderState(
        int OrderId,
        DateTime CreatedAt,
        IReadOnlyList<OrderLineItem> Items,
        OrderStatus Status,
        string TrackingNumber)
    {
        public static OrderState Apply(OrderState state, object @event)
        {
            return @event switch
            {
                OrderCreatedEvent e => new OrderState(
                    e.OrderId,
                    e.CreatedAt,
                    new List<OrderLineItem>().AsReadOnly(),
                    OrderStatus.Created,
                    null),
                    
                ItemAddedEvent e => state with
                {
                    Items = state.Items
                        .Append(new OrderLineItem(e.ProductId, e.Quantity))
                        .ToList()
                        .AsReadOnly()
                },
                
                OrderShippedEvent e => state with
                {
                    Status = OrderStatus.Shipped,
                    TrackingNumber = e.TrackingNumber
                },
                
                _ => state
            };
        }
    }
    
    public record OrderLineItem(string ProductId, int Quantity);
    
    public enum OrderStatus
    {
        Created,
        Processing,
        Shipped,
        Delivered
    }
}

// 7. Parallel Processing Safety
public class ParallelProcessingDemo
{
    public record Product(int Id, string Name, decimal Price, int Stock);
    
    public List<Product> ApplyDiscountParallel(List<Product> products, decimal discountPercent)
    {
        // ✅ Safe to process in parallel - no shared mutable state
        return products
            .AsParallel()
            .Select(p => p with { Price = p.Price * (1 - discountPercent / 100) })
            .ToList();
    }
    
    public record OrderSummary(int OrderId, decimal Total, int ItemCount);
    
    public List<OrderSummary> ProcessOrdersParallel(List<ImmutableOrder> orders)
    {
        // ✅ Safe parallel processing
        return orders
            .AsParallel()
            .Select(order => new OrderSummary(
                order.OrderId,
                order.TotalAmount,
                order.Items.Count))
            .ToList();
    }
}

// 8. Hash Code Stability
public class HashCodeStabilityDemo
{
    // ✅ Immutable - hash code never changes
    public record CacheKey(string UserId, string ResourceType, DateTime Date);
    
    private Dictionary<CacheKey, object> _cache = new Dictionary<CacheKey, object>();
    
    public void DemoHashCodeStability()
    {
        var key = new CacheKey("user123", "Profile", DateTime.Today);
        
        _cache[key] = "Profile Data";
        
        // ✅ Can always find the data because hash code is stable
        var data = _cache[key];
        Console.WriteLine($"Found: {data}");
    }
}

// 9. Functional Programming Style
public class FunctionalStyleDemo
{
    public record Money(decimal Amount, string Currency)
    {
        public Money Add(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Currency mismatch");
                
            return this with { Amount = Amount + other.Amount };
        }
        
        public Money Subtract(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Currency mismatch");
                
            return this with { Amount = Amount - other.Amount };
        }
        
        public Money Multiply(decimal factor)
        {
            return this with { Amount = Amount * factor };
        }
    }
    
    public Money CalculateTotalWithTax(Money subtotal, decimal taxRate)
    {
        var tax = subtotal.Multiply(taxRate);
        return subtotal.Add(tax);
    }
}
```

**Key Benefits Summary:**

| Benefit | Description | Impact |
|---------|-------------|---------|
| **Thread Safety** | No race conditions, no locks needed | High performance |
| **Simplified Debugging** | State doesn't change unexpectedly | Easier troubleshooting |
| **Safe Caching** | Objects can be cached without concerns | Better performance |
| **Predictable Behavior** | Functions are deterministic | Fewer bugs |
| **Easy Testing** | No side effects to worry about | Simpler tests |
| **Temporal Queries** | Can keep old states | History tracking |
| **Hash Code Stability** | Safe to use as dictionary keys | Reliable collections |
| **Parallel Processing** | No synchronization needed | Scales better |

**When to Use Immutability:**
- ✅ Configuration objects
- ✅ Domain entities
- ✅ DTOs (Data Transfer Objects)
- ✅ Cache keys and values
- ✅ Shared state across threads
- ✅ Event sourcing
- ✅ Value objects

**When Mutability Might Be Better:**
- ⚠️ Large collections with frequent updates (performance)
- ⚠️ Builder patterns (during construction)
- ⚠️ Game engines with frequent state updates
- ⚠️ Real-time systems with tight performance constraints

---

I'll continue with the remaining sections in the next part. Would you like me to continue now?

Due to the length of this document, I'll continue with the remaining sections. Let me create the file and continue...

