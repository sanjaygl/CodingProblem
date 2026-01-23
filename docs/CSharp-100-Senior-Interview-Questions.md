# C# Interview Questions - 100 Senior/Principal Level Questions

> **Target Audience**: Senior Software Engineers, Architects, Technical Leads (11+ years experience)  
> **Focus**: Real-world scenarios, decision-making, trade-offs, and production-level considerations

---

## 📑 Table of Contents - All 100 Questions

### Batch 1: CLR, Memory Management & Fundamentals (Questions 1-10)
1. [CLR execution process and JIT compilation](#question-1-explain-the-clr-execution-process-from-compilation-to-runtime-how-does-jit-compilation-work)
2. [Stack vs Heap memory allocation](#question-2-explain-stack-vs-heap-memory-allocation-when-does-a-reference-type-get-allocated-on-the-stack)
3. [Garbage Collection - Generations, LOH, and tuning](#question-3-explain-garbage-collection-in-net-what-are-generations-and-loh)
4. [Value types vs Reference types - Boxing/Unboxing](#question-4-explain-value-types-vs-reference-types-what-is-boxingunboxing-and-performance-impact)
5. [async/await internals and state machine](#question-5-explain-asyncawait-how-does-the-compiler-transform-async-methods)
6. [Task vs Thread - When to use each](#question-6-explain-task-vs-thread-when-should-you-use-each)
7. [LINQ deferred execution and query optimization](#question-7-explain-linq-deferred-execution-how-to-optimize-linq-queries)
8. [Delegates, Events, and multicast delegates](#question-8-explain-delegates-events-and-multicast-delegates-when-to-use-each)
9. [ref, out, in parameters - Use cases](#question-9-explain-ref-out-and-in-parameters-when-to-use-each)
10. [Expression Trees - How LINQ to SQL/EF works](#question-10-explain-expression-trees-how-does-linq-to-sqlef-work-internally)

### Batch 2: Advanced Language Features (Questions 11-20)
11. [IEnumerable vs IQueryable - Database query differences](#question-11-explain-ienumerable-vs-iqueryable-when-to-use-each-for-database-queries)
12. [Extension methods - Design and limitations](#question-12-explain-extension-methods-how-to-design-fluent-apis)
13. [Covariance and Contravariance in generics](#question-13-explain-covariance-and-contravariance-in-c-generics)
14. [Reflection and Attributes - Use cases and performance](#question-14-explain-reflection-and-attributes-use-cases-and-performance-concerns)
15. [Dynamic keyword vs Reflection - Trade-offs](#question-15-explain-dynamic-keyword-vs-reflection-when-to-use-each)
16. [yield return and IEnumerable - State machine](#question-16-explain-yield-return-and-ienumerable-how-does-state-machine-work)
17. [Tuples, Deconstruction, Pattern Matching](#question-17-explain-tuples-deconstruction-and-pattern-matching-in-modern-c)
18. [Records vs Classes - Immutability and value equality](#question-18-explain-records-vs-classes-when-to-use-records)
19. [Span<T> and Memory<T> - Zero-copy operations](#question-19-explain-spant-and-memoryt-when-to-use-for-performance)
20. [Nullable reference types - Null safety](#question-20-explain-nullable-reference-types-how-to-enable-null-safety)

### Batch 3: Design Patterns & SOLID (Questions 21-30)
21. [SOLID principles with real-world examples](#question-21-explain-solid-principles-with-real-world-examples)
22. [Dependency Injection - Scopes and lifetimes](#question-22-explain-dependency-injection-in-aspnet-core-scopes-and-lifetimes)
23. [Singleton pattern - Thread-safe implementation](#question-23-explain-singleton-pattern-how-to-implement-thread-safe-singleton)
24. [Factory pattern vs Abstract Factory](#question-24-explain-factory-pattern-vs-abstract-factory-when-to-use-each)
25. [Repository pattern with EF Core](#question-25-explain-repository-pattern-with-ef-core-pros-and-cons)
26. [Strategy pattern - Behavior composition](#question-26-explain-strategy-pattern-how-to-implement-in-c)
27. [Decorator pattern - Adding behavior dynamically](#question-27-explain-decorator-pattern-how-to-use-with-aspnet-core)
28. [Observer pattern - Event-driven systems](#question-28-explain-observer-pattern-how-does-it-relate-to-c-events)
29. [Chain of Responsibility - Request processing](#question-29-explain-chain-of-responsibility-pattern-with-aspnet-core-middleware)
30. [Command pattern - CQRS foundation](#question-30-explain-command-pattern-how-does-it-relate-to-cqrs)

### Batch 4: ASP.NET Core & Web APIs (Questions 31-40)
31. [ASP.NET Core middleware pipeline](#question-31-explain-aspnet-core-middleware-pipeline-how-to-create-custom-middleware)
32. [Dependency Injection - AddScoped vs AddSingleton vs AddTransient](#question-32-explain-di-container-in-aspnet-core-addscoped-vs-addsingleton-vs-addtransient)
33. [Model binding and validation](#question-33-explain-model-binding-and-validation-in-aspnet-core)
34. [Filters - Authorization, Action, Exception filters](#question-34-explain-filters-in-aspnet-core-types-and-execution-order)
35. [JWT authentication and authorization](#question-35-explain-jwt-authentication-in-aspnet-core-how-to-implement)
36. [Advanced LINQ operators and performance](#question-36-explain-advanced-linq-operators-selectmany-groupby-join)
37. [EF Core change tracking and performance](#question-37-explain-ef-core-change-tracking-how-to-optimize-for-performance)
38. [Unit testing with xUnit, Moq, and FluentAssertions](#question-38-explain-unit-testing-best-practices-with-xunit-moq-fluentassertions)
39. [TDD approach and benefits](#question-39-explain-test-driven-development-tdd-how-to-practice-in-real-projects)
40. [ConfigureAwait(false) - When and why](#question-40-explain-configureavaitfalse-when-and-why-to-use-it)

### Batch 5: Microservices & Distributed Systems (Questions 41-50)
41. [gRPC vs REST - When to use each](#question-41-explain-grpc-vs-rest-when-to-use-each-for-microservices)
42. [Message queues - RabbitMQ patterns](#question-42-explain-message-queues-rabbitmq-patterns-and-use-cases)
43. [CQRS pattern - Command/Query separation](#question-43-explain-cqrs-pattern-when-to-use-command-query-separation)
44. [Event Sourcing - Event store implementation](#question-44-explain-event-sourcing-how-to-implement-event-store)
45. [Distributed caching with Redis](#question-45-explain-distributed-caching-with-redis-use-cases-and-patterns)
46. [Circuit Breaker pattern with Polly](#question-46-explain-circuit-breaker-pattern-how-to-implement-with-polly)
47. [API Gateway pattern - Routing and aggregation](#question-47-explain-api-gateway-pattern-benefits-and-implementation)
48. [Service discovery and load balancing](#question-48-explain-service-discovery-and-load-balancing-in-microservices)
49. [Distributed transactions - Saga pattern](#question-49-explain-distributed-transactions-saga-pattern-implementation)
50. [Message idempotency in distributed systems](#question-50-explain-message-idempotency-how-to-handle-duplicate-messages)

### Batch 6: Performance & Optimization (Questions 51-60)
51. [Async best practices - Avoiding deadlocks](#question-51-explain-async-best-practices-how-to-avoid-deadlocks)
52. [Memory leaks - Detection and prevention](#question-52-explain-memory-leaks-in-c-how-to-detect-and-prevent)
53. [String optimization - StringBuilder vs String](#question-53-explain-string-optimization-stringbuilder-vs-string-interpolation)
54. [Collection performance - List vs HashSet vs Dictionary](#question-54-explain-collection-performance-list-vs-hashset-vs-dictionary)
55. [Lazy loading vs Eager loading in EF Core](#question-55-explain-lazy-loading-vs-eager-loading-in-ef-core)
56. [Caching strategies - Cache-aside, Write-through](#question-56-explain-caching-strategies-cache-aside-write-through-write-behind)
57. [Profiling and benchmarking with BenchmarkDotNet](#question-57-explain-profiling-and-benchmarking-with-benchmarkdotnet)
58. [ThreadPool and Task Parallel Library](#question-58-explain-threadpool-and-task-parallel-library-tpl)
59. [Lock-free programming with Interlocked](#question-59-explain-lock-free-programming-with-interlocked-operations)
60. [Source Generators - Compile-time code generation](#question-60-explain-source-generators-how-to-generate-code-at-compile-time)

### Batch 7: Testing & Quality (Questions 61-65)
61. [Integration testing with WebApplicationFactory](#question-61-explain-integration-testing-with-webapplicationfactory-in-aspnet-core)
62. [Mocking external dependencies](#question-62-explain-mocking-external-dependencies-best-practices)
63. [Test data builders pattern](#question-63-explain-test-data-builders-pattern-for-readable-tests)
64. [Mutation testing for test quality](#question-64-explain-mutation-testing-how-to-verify-test-quality)
65. [Contract testing for microservices](#question-65-explain-contract-testing-for-microservices-with-pact)

### Batch 8: Modern .NET Features (Questions 66-70)
66. [GraphQL vs REST - Trade-offs](#question-66-explain-graphql-vs-rest-when-to-use-graphql)
67. [SignalR for real-time communication](#question-67-explain-signalr-how-to-implement-real-time-communication)
68. [Background services with IHostedService](#question-68-explain-background-services-with-ihostedservice-in-aspnet-core)
69. [Docker containerization for .NET apps](#question-69-explain-docker-containerization-for-net-applications)
70. [Kubernetes deployment for .NET microservices](#question-70-explain-kubernetes-deployment-for-net-microservices)

### Batch 9: Cloud & DevOps (Questions 71-75)
71. [Minimal APIs in .NET 6+](#question-71-explain-minimal-apis-in-net-6-when-to-use-vs-controllers)
72. [Azure Service Bus vs Azure Event Grid](#question-72-explain-azure-service-bus-vs-azure-event-grid-when-to-use-each)
73. [Azure Functions - Serverless patterns](#question-73-explain-azure-functions-serverless-patterns-and-use-cases)
74. [Blazor - Server vs WebAssembly](#question-74-explain-blazor-server-vs-webassembly-when-to-use-each)
75. [Performance optimization with BenchmarkDotNet](#question-75-explain-performance-optimization-with-benchmarkdotnet-example)

### Batch 10: Advanced Patterns (Questions 76-80)
76. [Strategy pattern for algorithm selection](#question-76-explain-strategy-pattern-for-algorithm-selection)
77. [Logging with Serilog and structured logging](#question-77-explain-logging-with-serilog-structured-logging-best-practices)
78. [Application Insights for monitoring](#question-78-explain-application-insights-for-monitoring-net-applications)
79. [Saga pattern for distributed transactions](#question-79-explain-saga-pattern-for-distributed-transactions)
80. [Observer pattern and reactive programming](#question-80-explain-observer-pattern-and-reactive-programming-with-rx)

### Batch 11: Architectural Patterns (Questions 81-85)
81. [ValueTask vs Task - Performance optimization](#question-81-explain-valuetask-vs-task-when-to-use-valuetask)
82. [System.Threading.Channels - Producer/consumer](#question-82-explain-systemthreadingchannels-producer-consumer-pattern)
83. [Outbox pattern - Reliable messaging](#question-83-explain-outbox-pattern-for-reliable-messaging)
84. [Proxy pattern - Virtual, protection, smart proxies](#question-84-explain-proxy-pattern-virtual-protection-and-smart-proxies)
85. [Global error handling in ASP.NET Core](#question-85-explain-global-error-handling-in-aspnet-core)

### Batch 12: Data Access & Architecture (Questions 86-90)
86. [Code-First vs Database-First in EF Core](#question-86-explain-code-first-vs-database-first-in-ef-core-when-to-use-each)
87. [Template Method pattern - Algorithm skeleton](#question-87-explain-the-template-method-pattern-how-is-it-used-in-aspnet-core)
88. [Rate limiting and throttling in APIs](#question-88-explain-rate-limiting-and-throttling-in-apis-how-to-implement-with-aspnetcoreratelimit)
89. [Builder pattern with Fluent APIs](#question-89-explain-the-builder-pattern-how-is-it-used-with-fluent-apis)
90. [Database connection pooling](#question-90-explain-database-connection-pooling-how-does-it-work-in-adonet-and-ef-core)

### Batch 13: Caching & Performance (Questions 91-95)
91. [IMemoryCache vs IDistributedCache](#question-91-explain-imemorycache-vs-idistributedcache-when-to-use-each)
92. [Mediator pattern and MediatR library](#question-92-explain-the-mediator-pattern-and-mediatr-library-when-to-use-it)
93. [API versioning strategies](#question-93-explain-versioning-strategies-for-apis-how-to-implement-in-aspnet-core)
94. [Specification pattern with EF Core](#question-94-explain-the-specification-pattern-how-to-use-it-with-ef-core)
95. [Health checks in ASP.NET Core](#question-95-explain-health-checks-in-aspnet-core-how-to-implement-custom-health-checks)

### Batch 14: Final Advanced Topics (Questions 96-100)
96. [Unit of Work pattern - EF Core implementation](#question-96-explain-the-unit-of-work-pattern-how-does-ef-core-implement-it)
97. [Feature flags/toggles - Runtime feature control](#question-97-explain-feature-flagstoggles-how-to-implement-in-net)
98. [Background tasks with IHostedService and BackgroundService](#question-98-explain-background-tasks-with-ihostedservice-and-backgroundservice-when-to-use-each)
99. [Message idempotency in distributed systems](#question-99-explain-message-idempotency-how-to-implement-in-distributed-systems)
100. [Eventual consistency in distributed systems](#question-100-explain-eventual-consistency-in-distributed-systems-how-to-handle-in-net)

---

## Batch 1: CLR, Memory Management & Fundamentals (Questions 1-10)

### Question 1: Explain the CLR execution process from compilation to runtime. How does JIT compilation work?

**Short Theory:**  
The Common Language Runtime (CLR) is the execution engine for .NET applications. C# code compiles to Intermediate Language (IL/MSIL), which is platform-agnostic bytecode. At runtime, the JIT (Just-In-Time) compiler converts IL to native machine code specific to the CPU architecture. The compiled native code is cached, so methods are only JIT-compiled once per application run.

**Why do we use it?**  
JIT compilation provides platform independence while maintaining performance. It enables write-once-run-anywhere capability across different operating systems and architectures. Modern JIT includes optimizations like inlining, dead code elimination, and CPU-specific instruction sets, often matching or exceeding ahead-of-time compiled performance for long-running applications.

**Key Interview Points:**
- IL code is metadata-rich, enabling reflection and runtime analysis
- JIT compilation happens on first method call; subsequent calls use cached native code
- Tiered compilation in .NET Core+ balances startup time vs. peak performance
- Pre-compilation options: AOT (Ahead-of-Time), ReadyToRun for faster startup
- Trade-off: JIT warmup time vs. runtime optimization opportunities

---

### Question 2: Explain Stack vs Heap memory allocation. When does a reference type get allocated on the stack?

**Short Theory:**  
Stack memory stores value types, method parameters, and local variables with automatic LIFO cleanup. Heap stores reference type instances with GC-managed cleanup. However, compiler optimizations and certain scenarios can allocate reference types on the stack. With modern .NET, escape analysis and stack allocation optimizations can place small objects on the stack if they don't escape method scope.

**Why do we use it?**  
Stack allocation is extremely fast (pointer increment) and automatically deallocated when method returns. Heap allocation is slower but necessary for objects that outlive method scope. Understanding this helps optimize hot paths in performance-critical code and avoid unnecessary heap allocations.

**Key Interview Points:**
- Value types on stack: primitives, structs, enums (unless boxed or part of reference type)
- Reference types on heap: classes, arrays, delegates (with stack-stored references)
- `ref struct` (Span<T>, stackalloc) forces stack allocation, cannot escape to heap
- Closures and lambdas capturing variables can cause unexpected heap allocations
- Large structs (>16 bytes) might be better as classes due to copy overhead

**Coding Example:**
```csharp
public class MemoryAllocationDemo
{
    // Stack: value type local variable
    public void StackAllocation()
    {
        int x = 10; // Allocated on stack
        DateTime dt = DateTime.Now; // Struct on stack
    }
    
    // Heap: reference type
    public void HeapAllocation()
    {
        var person = new Person(); // Object on heap, reference on stack
        int[] numbers = new int[10]; // Array on heap
    }
    
    // Stack-only with ref struct
    public void StackOnlyAllocation()
    {
        Span<int> span = stackalloc int[100]; // Stack allocation
        // span cannot be stored in field or returned
    }
    
    // Closure causing heap allocation
    public Action UnexpectedHeapAllocation()
    {
        int capturedValue = 42;
        return () => Console.WriteLine(capturedValue); // Heap-allocated closure
    }
}

public class Person { public string Name { get; set; } }
```

---

### Question 3: What is boxing and unboxing? What are the performance implications in production code?

**Short Theory:**  
Boxing converts a value type to a reference type (object) by allocating heap memory and copying the value. Unboxing extracts the value type from the boxed object with type checking. This involves heap allocation, copying, and potential cast exceptions. Hidden boxing occurs in string concatenation, non-generic collections, and interface casting of value types.

**Why do we use it?**  
Boxing enables value types to be treated as objects for polymorphism, collections, and reflection scenarios. However, it should be avoided in hot paths due to heap allocation overhead and GC pressure. Generic collections (List<T>) and constrained generics eliminate most boxing needs.

**Key Interview Points:**
- Each boxing operation allocates a new heap object, increasing GC pressure
- Hidden boxing: `object o = 42;`, `ArrayList.Add(struct)`, `string.Format("{0}", struct)`
- Unboxing requires exact type match; `(int)(object)42` works, `(long)(object)42` throws
- Use generic collections and `ToString()` overrides to avoid boxing
- Interfaces on structs cause boxing unless using constrained generics

**Coding Example:**
```csharp
public class BoxingUnboxingDemo
{
    // Explicit boxing and unboxing
    public void ExplicitBoxing()
    {
        int value = 123;
        object boxed = value; // Boxing: heap allocation
        int unboxed = (int)boxed; // Unboxing: type check + copy
    }
    
    // Hidden boxing - AVOID in production
    public void HiddenBoxingProblems()
    {
        int count = 1000;
        
        // Bad: Boxing on every iteration
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Value: {0}", i); // Boxing of i
        }
        
        // Better: Use interpolation or ToString
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Value: {i}"); // No boxing
        }
    }
    
    // Interface boxing on struct
    public void InterfaceBoxing()
    {
        var point = new Point { X = 10, Y = 20 };
        IComparable comparable = point; // Boxing occurs
        
        // Better: Use generic constraint
        ProcessWithGeneric(point); // No boxing
    }
    
    private void ProcessWithGeneric<T>(T value) where T : IComparable<T>
    {
        // T remains value type, no boxing
    }
    
    // Non-generic vs generic collections
    public void CollectionBoxing()
    {
        // Bad: Boxing on Add, unboxing on retrieve
        ArrayList oldList = new ArrayList();
        oldList.Add(42); // Boxing
        
        // Good: No boxing
        List<int> newList = new List<int>();
        newList.Add(42); // No boxing
    }
}

public struct Point : IComparable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }
    public int CompareTo(Point other) => X.CompareTo(other.X);
}
```

---

### Question 4: Explain Garbage Collection in .NET. What are the three generations and when does promotion occur?

**Short Theory:**  
The .NET Garbage Collector automatically manages heap memory using a generational algorithm. Objects start in Generation 0 (Gen0). Objects surviving a Gen0 collection promote to Gen1, and Gen1 survivors promote to Gen2. Gen0 collects frequently (fast), Gen1 occasionally, and Gen2 rarely (expensive). Large objects (>85KB) go directly to Large Object Heap (LOH), which is collected with Gen2.

**Why do we use it?**  
Generational GC exploits the "weak generational hypothesis"—most objects die young. By collecting short-lived objects frequently and long-lived objects rarely, GC minimizes pause times. This automatic memory management prevents memory leaks and use-after-free bugs common in manual memory management, while maintaining good performance for most applications.

**Key Interview Points:**
- Gen0 collections are very fast (~1ms); Gen2 can pause application significantly (10ms-1s+)
- Avoid frequent Gen2 collections by reducing long-lived object allocations
- LOH fragmentation can cause OutOfMemoryException even with available memory
- Server GC (multi-threaded) vs. Workstation GC (lower latency) configuration matters
- `GC.Collect()` should almost never be called manually in production

**Coding Example:**
```csharp
public class GarbageCollectionDemo
{
    // Monitor GC statistics
    public void MonitorGCBehavior()
    {
        Console.WriteLine($"Gen0: {GC.CollectionCount(0)}");
        Console.WriteLine($"Gen1: {GC.CollectionCount(1)}");
        Console.WriteLine($"Gen2: {GC.CollectionCount(2)}");
        Console.WriteLine($"Total Memory: {GC.GetTotalMemory(false)} bytes");
    }
    
    // Short-lived objects (Gen0 only)
    public void ShortLivedObjects()
    {
        for (int i = 0; i < 10000; i++)
        {
            var temp = new byte[100]; // Allocated and collected in Gen0
            // temp goes out of scope immediately
        }
    }
    
    // Long-lived objects (promote to Gen2)
    private static List<byte[]> _cache = new List<byte[]>();
    
    public void LongLivedObjects()
    {
        for (int i = 0; i < 100; i++)
        {
            _cache.Add(new byte[1000]); // Survives collections, promotes to Gen2
        }
    }
    
    // Large Object Heap (LOH) allocation
    public void LargeObjectAllocation()
    {
        // Objects > 85,000 bytes go to LOH
        byte[] largeArray = new byte[100000]; // Directly to LOH (Gen2)
        
        // LOH is not compacted by default (until .NET Core 2.1+)
        // Can cause fragmentation issues
    }
    
    // Check object generation
    public void CheckGeneration()
    {
        object obj = new object();
        Console.WriteLine($"Initial Gen: {GC.GetGeneration(obj)}"); // 0
        
        GC.Collect(0);
        Console.WriteLine($"After Gen0 GC: {GC.GetGeneration(obj)}"); // 1
        
        GC.Collect(1);
        Console.WriteLine($"After Gen1 GC: {GC.GetGeneration(obj)}"); // 2
    }
    
    // Finalizer can keep objects alive longer
    private class DisposableResource
    {
        ~DisposableResource() // Finalizer
        {
            // Object moved to finalization queue, collected in next GC cycle
            Console.WriteLine("Finalized");
        }
    }
}
```

---

### Question 5: When and why should you implement IDisposable? Explain the dispose pattern.

**Short Theory:**  
IDisposable provides deterministic cleanup of unmanaged resources (file handles, database connections, sockets) that GC doesn't automatically release. The dispose pattern includes a public `Dispose()` method, a protected virtual `Dispose(bool)` method, and optionally a finalizer. The `using` statement ensures automatic disposal even if exceptions occur, calling `Dispose()` at scope exit.

**Why do we use it?**  
Unmanaged resources aren't tracked by GC and can cause resource exhaustion (file handle limits, connection pool depletion). IDisposable ensures timely cleanup, preventing resource leaks. It's critical for database connections, file streams, graphics handles, and COM objects. Proper implementation prevents finalizer overhead and reduces Gen2 GC pressure.

**Key Interview Points:**
- Dispose unmanaged resources and suppress finalization with `GC.SuppressFinalize(this)`
- Use `using` statements or `using` declarations for automatic disposal
- Dispose pattern prevents double-disposal and handles inheritance scenarios
- Async disposal with `IAsyncDisposable` for async cleanup operations (EF contexts, streams)
- Not disposing can cause connection pool exhaustion and file lock issues

**Coding Example:**
```csharp
// Full dispose pattern implementation
public class ManagedResource : IDisposable
{
    private IntPtr _unmanagedHandle; // Unmanaged resource
    private StreamWriter _managedStream; // Managed disposable resource
    private bool _disposed = false;
    
    public ManagedResource()
    {
        _unmanagedHandle = AllocateUnmanagedResource();
        _managedStream = new StreamWriter("file.txt");
    }
    
    // Public dispose method
    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this); // Prevent finalizer execution
    }
    
    // Protected virtual method for inheritance
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;
        
        if (disposing)
        {
            // Dispose managed resources
            _managedStream?.Dispose();
        }
        
        // Free unmanaged resources (always)
        if (_unmanagedHandle != IntPtr.Zero)
        {
            FreeUnmanagedResource(_unmanagedHandle);
            _unmanagedHandle = IntPtr.Zero;
        }
        
        _disposed = true;
    }
    
    // Finalizer (only if you have unmanaged resources)
    ~ManagedResource()
    {
        Dispose(disposing: false);
    }
    
    // Helper methods (simulated)
    private IntPtr AllocateUnmanagedResource() => IntPtr.Zero;
    private void FreeUnmanagedResource(IntPtr handle) { }
    
    // Ensure not used after disposal
    private void ThrowIfDisposed()
    {
        if (_disposed)
            throw new ObjectDisposedException(GetType().Name);
    }
}

// Usage patterns
public class DisposableUsageDemo
{
    // Using statement (automatic disposal)
    public void UsingStatement()
    {
        using (var resource = new ManagedResource())
        {
            // Use resource
        } // Dispose() called automatically, even if exception occurs
    }
    
    // Using declaration (C# 8.0+)
    public void UsingDeclaration()
    {
        using var resource = new ManagedResource();
        // Use resource
        // Dispose() called at end of method scope
    }
    
    // Async disposal (IAsyncDisposable)
    public async Task AsyncDisposal()
    {
        await using var context = new MyDbContext();
        // Async operations
        // DisposeAsync() called automatically
    }
    
    // Manual disposal (less preferred)
    public void ManualDisposal()
    {
        ManagedResource resource = null;
        try
        {
            resource = new ManagedResource();
            // Use resource
        }
        finally
        {
            resource?.Dispose();
        }
    }
}

// Simple IAsyncDisposable example
public class AsyncDisposableResource : IAsyncDisposable
{
    private HttpClient _httpClient = new HttpClient();
    
    public async ValueTask DisposeAsync()
    {
        if (_httpClient != null)
        {
            // Perform async cleanup
            await Task.Delay(10); // Simulate async work
            _httpClient.Dispose();
            _httpClient = null;
        }
    }
}
```

---

### Question 6: Explain value types vs reference types. When would you choose a struct over a class?

**Short Theory:**  
Value types (structs, primitives, enums) store data directly and are copied by value. Reference types (classes) store a reference to heap-allocated data and are copied by reference. Value types have no inheritance, are sealed by default, and use `==` for value equality unless overridden. Reference types support inheritance, can be null, and use `==` for reference equality unless overridden.

**Why do we use it?**  
Structs avoid heap allocation overhead for small, immutable data types, reducing GC pressure. They're ideal for DTOs, coordinates, points, and high-performance scenarios with millions of instances. Classes provide polymorphism, inheritance, and reference semantics necessary for complex object graphs and entity modeling.

**Key Interview Points:**
- Use struct when: small (<16 bytes), immutable, logically represents a single value
- Use class when: larger data, requires inheritance, needs reference semantics
- Structs passed by value cause copying overhead; large structs hurt performance
- `readonly struct` prevents accidental mutations and enables compiler optimizations
- `ref struct` (Span<T>) is stack-only, cannot be boxed or used in async methods

**Coding Example:**
```csharp
// Value type - struct (small, immutable)
public readonly struct Point2D
{
    public double X { get; }
    public double Y { get; }
    
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    // Value equality
    public override bool Equals(object obj) =>
        obj is Point2D other && X == other.X && Y == other.Y;
    
    public override int GetHashCode() => HashCode.Combine(X, Y);
}

// Reference type - class (complex entity)
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Address HomeAddress { get; set; } // Reference
    
    public int CalculateAge() => DateTime.Now.Year - DateOfBirth.Year;
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
}

// Performance comparison
public class ValueVsReferenceDemo
{
    // Struct: value copy
    public void StructCopyBehavior()
    {
        Point2D p1 = new Point2D(10, 20);
        Point2D p2 = p1; // Entire value copied
        
        // p1 and p2 are independent
        Console.WriteLine(p1.Equals(p2)); // True (value equality)
        Console.WriteLine(ReferenceEquals(p1, p2)); // False (different values)
    }
    
    // Class: reference copy
    public void ClassReferenceBehavior()
    {
        Person person1 = new Person { FirstName = "John" };
        Person person2 = person1; // Reference copied
        
        person2.FirstName = "Jane";
        Console.WriteLine(person1.FirstName); // "Jane" (same object)
        Console.WriteLine(ReferenceEquals(person1, person2)); // True
    }
    
    // Performance: struct array (cache-friendly)
    public void StructArrayPerformance()
    {
        Point2D[] points = new Point2D[1000000];
        // Contiguous memory, no indirection, cache-friendly
        
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = new Point2D(i, i * 2);
        }
    }
    
    // Performance: class array (pointer indirection)
    public void ClassArrayPerformance()
    {
        Person[] people = new Person[1000000];
        // Array of references, actual objects scattered on heap
        
        for (int i = 0; i < people.Length; i++)
        {
            people[i] = new Person(); // Heap allocation per instance
        }
    }
    
    // Large struct - BAD PRACTICE
    public struct LargeStruct // AVOID
    {
        public long Field1, Field2, Field3, Field4, Field5;
        // 40 bytes - copied on every assignment/pass
    }
    
    // Ref struct - stack-only
    public ref struct StackOnlyStruct
    {
        public Span<byte> Buffer;
        
        // Cannot be used as field in class
        // Cannot be used in async methods
        // Cannot implement interfaces
    }
}

// When to choose struct vs class
public class StructVsClassGuidelines
{
    // GOOD: Struct for small immutable value
    public readonly struct Money
    {
        public decimal Amount { get; }
        public string Currency { get; }
        
        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
    
    // GOOD: Class for entity with behavior
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public Money Balance { get; set; } // Contains struct
        
        public void Deposit(Money amount)
        {
            if (amount.Currency != Balance.Currency)
                throw new InvalidOperationException("Currency mismatch");
            
            Balance = new Money(Balance.Amount + amount.Amount, Balance.Currency);
        }
    }
}
```

---

### Question 7: What are records in C#? When would you use record vs class vs struct?

**Short Theory:**  
Records (C# 9+) are reference types with value-based equality semantics and immutability by default. They provide concise syntax for data-centric types with automatic `Equals`, `GetHashCode`, and `ToString` implementations based on property values. `record struct` (C# 10+) combines struct benefits with record features. Records support non-destructive mutation with `with` expressions and deconstruction.

**Why do we use it?**  
Records eliminate boilerplate code for DTOs, API models, and immutable data containers. Value-based equality makes them ideal for comparisons in tests, collections, and domain models. Immutability prevents bugs in concurrent scenarios and enables safer data sharing. The `with` syntax provides functional-style updates without modifying original instances.

**Key Interview Points:**
- `record class` (default): reference type with value equality
- `record struct`: value type with value equality and better performance for small data
- Immutability by default with `init` properties prevents accidental mutations
- `with` expressions create shallow copies with modified properties
- Positional records enable concise syntax and deconstruction

**Coding Example:**
```csharp
// Traditional class - verbose
public class PersonClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public override bool Equals(object obj)
    {
        if (obj is PersonClass other)
            return FirstName == other.FirstName && LastName == other.LastName;
        return false;
    }
    
    public override int GetHashCode() => HashCode.Combine(FirstName, LastName);
    public override string ToString() => $"{FirstName} {LastName}";
}

// Record - concise with auto-generated members
public record PersonRecord(string FirstName, string LastName);

// Record with additional properties
public record Employee(string FirstName, string LastName, string EmployeeId)
{
    public decimal Salary { get; init; }
    public DateTime HireDate { get; init; }
    
    // Custom method
    public int YearsOfService() => DateTime.Now.Year - HireDate.Year;
}

// Record struct (value type)
public record struct Point3D(double X, double Y, double Z);

// Mutable record (not recommended)
public record MutablePerson
{
    public string FirstName { get; set; } // Can be changed
    public string LastName { get; set; }
}

// Record usage examples
public class RecordUsageDemo
{
    public void ValueBasedEquality()
    {
        var person1 = new PersonRecord("John", "Doe");
        var person2 = new PersonRecord("John", "Doe");
        
        // Value equality (unlike classes)
        Console.WriteLine(person1 == person2); // True
        Console.WriteLine(person1.Equals(person2)); // True
        Console.WriteLine(ReferenceEquals(person1, person2)); // False
        
        // Class comparison
        var class1 = new PersonClass { FirstName = "John", LastName = "Doe" };
        var class2 = new PersonClass { FirstName = "John", LastName = "Doe" };
        Console.WriteLine(class1 == class2); // False (reference equality)
    }
    
    public void NonDestructiveMutation()
    {
        var employee = new Employee("Jane", "Smith", "E123")
        {
            Salary = 100000,
            HireDate = new DateTime(2020, 1, 1)
        };
        
        // Create modified copy with 'with' expression
        var promoted = employee with { Salary = 120000 };
        
        Console.WriteLine(employee.Salary); // 100000 (unchanged)
        Console.WriteLine(promoted.Salary); // 120000
        Console.WriteLine(employee.FirstName == promoted.FirstName); // True (shared data)
    }
    
    public void Deconstruction()
    {
        var person = new PersonRecord("John", "Doe");
        
        // Deconstruct into variables
        var (firstName, lastName) = person;
        Console.WriteLine($"{firstName} {lastName}");
    }
    
    public void RecordInheritance()
    {
        // Records support inheritance
        var manager = new Manager("Bob", "Johnson", "M456", "Engineering");
        Console.WriteLine(manager);
    }
    
    public void RecordStructPerformance()
    {
        // Value type with value equality
        var point1 = new Point3D(1.0, 2.0, 3.0);
        var point2 = new Point3D(1.0, 2.0, 3.0);
        
        Console.WriteLine(point1 == point2); // True (value equality)
        // No heap allocation, stack-allocated
    }
    
    public void UseInCollections()
    {
        var person1 = new PersonRecord("Alice", "Brown");
        var person2 = new PersonRecord("Alice", "Brown");
        
        // Value equality works in collections
        var set = new HashSet<PersonRecord> { person1 };
        Console.WriteLine(set.Contains(person2)); // True
        
        var dict = new Dictionary<PersonRecord, string>
        {
            [person1] = "Developer"
        };
        Console.WriteLine(dict[person2]); // "Developer"
    }
}

// Record inheritance
public record Manager(string FirstName, string LastName, string EmployeeId, string Department)
    : Employee(FirstName, LastName, EmployeeId);

// When to use each type
public class TypeSelectionGuide
{
    /*
     * Use RECORD CLASS when:
     * - DTOs, API models, configuration objects
     * - Immutable data with value semantics
     * - Need deconstruction and 'with' expressions
     * - Equality based on data, not identity
     * 
     * Use RECORD STRUCT when:
     * - Small immutable value types (<16 bytes)
     * - High-performance scenarios with millions of instances
     * - Need value equality without heap allocation
     * 
     * Use CLASS when:
     * - Entities with identity (User, Order, Product)
     * - Mutable state is necessary
     * - Need complex inheritance hierarchies
     * - Large objects (>16 bytes)
     * 
     * Use STRUCT when:
     * - Small (<16 bytes), immutable value types
     * - Performance-critical paths with allocation concerns
     * - Numeric types, coordinates, ranges
     */
}
```

---

### Question 8: Explain the difference between String and StringBuilder. When should you use each?

**Short Theory:**  
String is an immutable reference type where every modification creates a new string object on the heap. StringBuilder is a mutable class that uses a character buffer, allowing in-place modifications without allocating new objects. String operations in loops cause significant memory allocations and GC pressure. StringBuilder amortizes allocation costs by resizing its internal buffer when needed.

**Why do we use it?**  
Immutable strings are thread-safe and can be safely shared across threads. They're perfect for constant values and single operations. StringBuilder is essential for performance in loops, concatenations, and string-building scenarios, reducing heap allocations from thousands to single-digit allocations. This dramatically improves performance and reduces Gen0 GC collections.

**Key Interview Points:**
- String concatenation in loops creates O(n²) allocations; StringBuilder is O(n)
- StringBuilder capacity matters: set initial capacity to avoid resizing
- Use string for: literals, small concatenations, thread-safe scenarios
- Use StringBuilder for: loops, repeated modifications, large string construction
- String interning optimizes memory for duplicate literal strings

**Coding Example:**
```csharp
public class StringVsStringBuilderDemo
{
    // BAD: String concatenation in loop (O(n²) allocations)
    public string StringConcatenationBad(int count)
    {
        string result = "";
        
        for (int i = 0; i < count; i++)
        {
            result += i.ToString(); // Creates new string every iteration
            // For count=1000: 1000 string allocations
        }
        
        return result;
    }
    
    // GOOD: StringBuilder (O(n) allocations)
    public string StringBuilderGood(int count)
    {
        var sb = new StringBuilder(count * 10); // Pre-allocate capacity
        
        for (int i = 0; i < count; i++)
        {
            sb.Append(i); // Modifies internal buffer
            // Minimal allocations, even for count=1000
        }
        
        return sb.ToString();
    }
    
    // Performance comparison
    public void PerformanceComparison()
    {
        int iterations = 10000;
        
        // String: ~2000ms, millions of bytes allocated
        var sw = System.Diagnostics.Stopwatch.StartNew();
        string strResult = StringConcatenationBad(iterations);
        sw.Stop();
        Console.WriteLine($"String: {sw.ElapsedMilliseconds}ms");
        
        // StringBuilder: ~5ms, minimal allocations
        sw.Restart();
        string sbResult = StringBuilderGood(iterations);
        sw.Stop();
        Console.WriteLine($"StringBuilder: {sw.ElapsedMilliseconds}ms");
    }
    
    // When to use string
    public void WhenToUseString()
    {
        // Simple concatenation
        string name = "John" + " " + "Doe"; // Fine, compile-time optimization
        
        // String interpolation (single operation)
        string greeting = $"Hello, {name}!"; // Efficient
        
        // String.Concat (small number of strings)
        string path = string.Concat("C:\\", "Users\\", "Documents"); // Efficient
        
        // String.Join (known array)
        string csv = string.Join(",", new[] { "A", "B", "C" }); // Efficient
    }
    
    // When to use StringBuilder
    public void WhenToUseStringBuilder()
    {
        // Multiple operations in loop
        var sb = new StringBuilder(1000);
        for (int i = 0; i < 100; i++)
        {
            sb.Append("Value: ");
            sb.Append(i);
            sb.AppendLine();
        }
        
        // Conditional building
        sb.Clear();
        sb.Append("Base");
        if (DateTime.Now.Hour > 12)
            sb.Append(" - Afternoon");
        sb.Append(" - ");
        sb.Append(DateTime.Now.ToString("yyyy-MM-dd"));
        
        string result = sb.ToString();
    }
    
    // StringBuilder capacity management
    public void CapacityManagement()
    {
        // Default capacity: 16 characters
        var sb1 = new StringBuilder();
        
        // Pre-allocate capacity (best practice)
        var sb2 = new StringBuilder(1000); // Avoids resizing
        
        // Capacity and Length
        Console.WriteLine($"Capacity: {sb2.Capacity}, Length: {sb2.Length}");
        
        // EnsureCapacity
        sb2.EnsureCapacity(2000); // Prevents reallocation if you know final size
    }
    
    // String interning
    public void StringInterning()
    {
        // Literals are automatically interned
        string s1 = "hello";
        string s2 = "hello";
        Console.WriteLine(ReferenceEquals(s1, s2)); // True (same reference)
        
        // Runtime strings not interned by default
        string s3 = new string("hello".ToCharArray());
        Console.WriteLine(ReferenceEquals(s1, s3)); // False
        
        // Manual interning
        string s4 = string.Intern(s3);
        Console.WriteLine(ReferenceEquals(s1, s4)); // True
    }
    
    // Real-world example: Building SQL query
    public string BuildDynamicQuery(string tableName, Dictionary<string, object> filters)
    {
        var sb = new StringBuilder(200);
        sb.Append("SELECT * FROM ");
        sb.Append(tableName);
        
        if (filters.Count > 0)
        {
            sb.Append(" WHERE ");
            int index = 0;
            foreach (var filter in filters)
            {
                if (index > 0) sb.Append(" AND ");
                sb.Append(filter.Key);
                sb.Append(" = @");
                sb.Append(filter.Key);
                index++;
            }
        }
        
        return sb.ToString();
    }
    
    // String vs StringBuilder: Rule of thumb
    public void RuleOfThumb()
    {
        /*
         * Use STRING when:
         * - Fewer than 3-4 concatenations
         * - Working with literals or constant values
         * - Need thread-safety (immutability)
         * - Using string interpolation or String.Format once
         * 
         * Use STRINGBUILDER when:
         * - More than 4-5 concatenations
         * - Building strings in loops
         * - Conditional string building with many branches
         * - Constructing large strings (>1KB)
         * - Performance-critical code paths
         */
    }
}
```

---

### Question 9: What is the difference between const and readonly? When would you use each?

**Short Theory:**  
`const` fields are compile-time constants embedded directly into the IL code at compile time. They must be initialized at declaration with a constant expression and are implicitly static. `readonly` fields are runtime constants that can be initialized at declaration or in the constructor. They can hold reference types and complex expressions evaluated at runtime.

**Why do we use it?**  
`const` provides slightly better performance (no memory allocation, direct IL substitution) for true constants like mathematical values or configuration keys that never change. `readonly` is safer for values that might change between builds (versioning), reference types, or values requiring runtime computation. Changing a `const` requires recompiling all assemblies that reference it.

**Key Interview Points:**
- `const` must be known at compile time; `readonly` can be set at runtime in constructor
- `const` is implicitly static; `readonly` can be instance or static
- Changing `const` requires recompiling dependent assemblies (DLL hell risk)
- `readonly` collections are not immutable—contents can still be modified
- Use `readonly struct` and `readonly` methods to prevent defensive copies

**Coding Example:**
```csharp
public class ConstVsReadonlyDemo
{
    // const: compile-time constant
    public const double Pi = 3.14159; // Embedded in IL
    public const string ApplicationName = "MyApp"; // Compile-time
    
    // readonly: runtime constant
    public readonly DateTime StartTime = DateTime.Now; // Set at construction
    public readonly string MachineName = Environment.MachineName; // Runtime value
    
    // readonly can be set in constructor
    public readonly int MaxConnections;
    
    // static readonly (common pattern)
    public static readonly string ConnectionString;
    
    static ConstVsReadonlyDemo()
    {
        // Static constructor can initialize static readonly
        ConnectionString = LoadFromConfig();
    }
    
    public ConstVsReadonlyDemo(int maxConn)
    {
        MaxConnections = maxConn; // OK in constructor
    }
    
    private static string LoadFromConfig() => "Server=.;Database=Test";
    
    // Compilation difference
    public void UseConstants()
    {
        double area = Pi * 5 * 5; // Pi value embedded in IL (3.14159 * 5 * 5)
        DateTime start = StartTime; // Actual field access
    }
}

// const limitations
public class ConstLimitations
{
    // OK: primitive types and string
    public const int MaxRetries = 3;
    public const string DefaultName = "Unknown";
    
    // ERROR: const cannot be reference types (except string)
    // public const DateTime Today = DateTime.Now; // Won't compile
    // public const List<int> Numbers = new List<int>(); // Won't compile
    
    // OK: readonly reference types
    public readonly DateTime Today = DateTime.Now;
    public readonly List<int> Numbers = new List<int>();
}

// readonly doesn't prevent modification of contents
public class ReadonlyMutability
{
    public readonly List<int> Numbers = new List<int> { 1, 2, 3 };
    
    public void DemonstrateReadonlyMutability()
    {
        // ERROR: Cannot reassign readonly field
        // Numbers = new List<int>(); // Won't compile
        
        // OK: Contents can be modified
        Numbers.Add(4); // Allowed! readonly applies to reference, not contents
        Numbers.Clear(); // Also allowed
        
        // To prevent this, use ImmutableList
        // public readonly ImmutableList<int> Numbers = ImmutableList.Create(1, 2, 3);
    }
}

// Versioning concerns with const
public class Library_v1
{
    public const string Version = "1.0.0"; // Embedded in consumer DLLs
}

public class Library_v2
{
    // Better: use readonly for version strings
    public static readonly string Version = "2.0.0";
    
    // Consumer DLLs don't need recompilation
}

// readonly struct (C# 7.2+)
public readonly struct ImmutablePoint
{
    public double X { get; }
    public double Y { get; }
    
    public ImmutablePoint(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    // All methods implicitly readonly
    public double DistanceFromOrigin() => Math.Sqrt(X * X + Y * Y);
}

// readonly methods (C# 8.0+)
public struct MutablePoint
{
    public double X { get; set; }
    public double Y { get; set; }
    
    // readonly method: doesn't modify instance
    public readonly double DistanceFromOrigin()
    {
        // Compiler ensures no mutations
        // X = 10; // ERROR: Cannot modify in readonly method
        return Math.Sqrt(X * X + Y * Y);
    }
    
    // Non-readonly method: can modify
    public void Reset()
    {
        X = 0;
        Y = 0;
    }
}

// Real-world usage patterns
public class RealWorldUsage
{
    // const: true constants that never change
    public const int MaxUsernameLength = 50;
    public const int MinPasswordLength = 8;
    public const string DateFormat = "yyyy-MM-dd";
    
    // readonly: configuration, runtime values
    public readonly string InstanceId = Guid.NewGuid().ToString();
    public readonly ILogger Logger;
    public static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(30);
    
    public RealWorldUsage(ILogger logger)
    {
        Logger = logger; // Dependency injection
    }
    
    // Defensive copy issue with non-readonly struct
    public void DefensiveCopyDemo()
    {
        var point = new MutablePoint { X = 10, Y = 20 };
        
        // Non-readonly method on readonly variable causes defensive copy
        double distance = point.DistanceFromOrigin(); // Defensive copy made
        
        // readonly method doesn't cause defensive copy
        var immutablePoint = new ImmutablePoint(10, 20);
        double dist2 = immutablePoint.DistanceFromOrigin(); // No copy
    }
}

// Guidelines summary
public class ConstReadonlyGuidelines
{
    /*
     * Use CONST when:
     * - Value is a true constant (Pi, MaxInt, magic numbers)
     * - Primitive types or string only
     * - Value will NEVER change across versions
     * - Need maximum performance (compile-time embedding)
     * 
     * Use READONLY when:
     * - Value set at runtime (DateTime.Now, config values)
     * - Reference types or complex expressions
     * - Value might change between application versions
     * - Dependency injection scenarios
     * - Want to avoid forcing consumer recompilation
     * 
     * Use STATIC READONLY when:
     * - Shared constant across all instances
     * - Complex initialization logic needed
     * - Configuration or connection strings
     */
}
```

---

### Question 10: Explain the different types of method parameters: ref, out, in, params. When should each be used?

**Short Theory:**  
`ref` passes variables by reference, requiring initialization before calling and allowing modifications. `out` is similar but doesn't require prior initialization and must be assigned before method returns. `in` passes by reference for read-only access, preventing copies of large structs while disallowing modifications. `params` allows variable-length argument lists as an array, providing convenience for callers.

**Why do we use it?**  
These modifiers optimize performance and enable specific patterns. `ref` and `out` avoid copying large structs and enable multiple return values. `in` prevents defensive copies of large readonly structs while keeping semantics clear. `params` simplifies APIs by avoiding explicit array creation. Understanding these is critical for high-performance scenarios and clean API design.

**Key Interview Points:**
- `ref`: two-way communication, must initialize before call
- `out`: output-only, must assign before return, no pre-initialization needed
- `in`: input-only reference, prevents copying large structs, immutable semantics
- `params`: convenience for variable arguments, creates array allocation (use sparingly in hot paths)
- `ref readonly return` enables returning large structs without copying

**Coding Example:**
```csharp
public class MethodParametersDemo
{
    // ref: bidirectional parameter passing
    public void RefExample()
    {
        int value = 10;
        ModifyWithRef(ref value); // Must pass with 'ref' keyword
        Console.WriteLine(value); // 20 (modified)
    }
    
    private void ModifyWithRef(ref int number)
    {
        Console.WriteLine(number); // Can read existing value
        number *= 2; // Can modify
    }
    
    // out: output parameter (return multiple values)
    public void OutExample()
    {
        // No need to initialize before call
        int quotient, remainder;
        Divide(10, 3, out quotient, out remainder);
        Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
        
        // C# 7.0+: inline out declaration
        Divide(20, 6, out int q, out int r);
        Console.WriteLine($"Quotient: {q}, Remainder: {r}");
        
        // Discard unwanted out parameters
        Divide(15, 4, out int result, out _);
    }
    
    private void Divide(int dividend, int divisor, out int quotient, out int remainder)
    {
        // Must assign before returning
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }
    
    // in: read-only reference (performance optimization)
    public void InExample()
    {
        var largeStruct = new LargeStruct(1, 2, 3, 4, 5);
        
        // Without 'in': struct copied (40 bytes)
        ProcessNormal(largeStruct); // Copy
        
        // With 'in': pass by reference, no copy
        ProcessWithIn(in largeStruct); // No copy, read-only
    }
    
    private void ProcessNormal(LargeStruct data)
    {
        // Struct is copied
        Console.WriteLine(data.Field1);
    }
    
    private void ProcessWithIn(in LargeStruct data)
    {
        // data.Field1 = 100; // ERROR: Cannot modify 'in' parameter
        Console.WriteLine(data.Field1); // Read-only access
    }
    
    // params: variable-length arguments
    public void ParamsExample()
    {
        // Clean caller syntax
        int sum1 = Sum(1, 2, 3);
        int sum2 = Sum(1, 2, 3, 4, 5, 6);
        int sum3 = Sum(); // Empty array
        
        // Explicit array also works
        int[] numbers = { 1, 2, 3, 4 };
        int sum4 = Sum(numbers);
    }
    
    private int Sum(params int[] numbers)
    {
        // params creates array allocation
        int total = 0;
        foreach (int num in numbers)
            total += num;
        return total;
    }
    
    // ref return: return large struct by reference
    public void RefReturnExample()
    {
        var matrix = new Matrix3x3();
        
        // Get reference to internal element
        ref double element = ref matrix.GetElement(1, 1);
        
        // Modify through reference
        element = 99.0;
        
        Console.WriteLine(matrix.GetElement(1, 1)); // 99.0
    }
    
    // ref readonly return: return immutable reference
    public void RefReadonlyReturnExample()
    {
        var cache = new StructCache();
        
        // Get readonly reference (no copy)
        ref readonly LargeStruct data = ref cache.GetData(0);
        
        // data.Field1 = 100; // ERROR: Cannot modify readonly reference
        Console.WriteLine(data.Field1);
    }
    
    // Performance comparison: in vs normal parameter
    public void PerformanceComparison()
    {
        var largeStruct = new LargeStruct(1, 2, 3, 4, 5);
        int iterations = 10_000_000;
        
        // Normal (copy): slower
        var sw = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            ProcessNormal(largeStruct); // 40 bytes copied each time
        }
        sw.Stop();
        Console.WriteLine($"Normal: {sw.ElapsedMilliseconds}ms");
        
        // in (reference): faster
        sw.Restart();
        for (int i = 0; i < iterations; i++)
        {
            ProcessWithIn(in largeStruct); // No copy
        }
        sw.Stop();
        Console.WriteLine($"In: {sw.ElapsedMilliseconds}ms");
    }
    
    // TryParse pattern (common out usage)
    public void TryParsePattern()
    {
        string input = "12345";
        
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine($"Parsed: {result}");
        }
        else
        {
            Console.WriteLine("Parse failed");
        }
    }
    
    // Ref vs out: swap example
    public void Swap(ref int a, ref int b)
    {
        int temp = a; // Can read existing values
        a = b;
        b = temp;
    }
    
    // Complex out example: multiple return values
    public bool TryGetUserInfo(int userId, out string name, out int age)
    {
        if (userId > 0)
        {
            name = "John Doe";
            age = 30;
            return true;
        }
        
        // Must assign even on failure path
        name = null;
        age = 0;
        return false;
    }
}

// Supporting types
public struct LargeStruct
{
    public double Field1, Field2, Field3, Field4, Field5; // 40 bytes
    
    public LargeStruct(double f1, double f2, double f3, double f4, double f5)
    {
        Field1 = f1;
        Field2 = f2;
        Field3 = f3;
        Field4 = f4;
        Field5 = f5;
    }
}

public struct Matrix3x3
{
    private double[,] _data;
    
    public Matrix3x3()
    {
        _data = new double[3, 3];
    }
    
    // ref return: return reference to internal data
    public ref double GetElement(int row, int col)
    {
        return ref _data[row, col];
    }
}

public class StructCache
{
    private LargeStruct[] _cache = new LargeStruct[100];
    
    // ref readonly return: return without copying
    public ref readonly LargeStruct GetData(int index)
    {
        return ref _cache[index];
    }
}

// Usage guidelines
public class ParameterGuidelines
{
    /*
     * Use REF when:
     * - Need to modify input parameter and return it
     * - Swapping values
     * - Large structs that need modification
     * 
     * Use OUT when:
     * - Returning multiple values
     * - TryParse pattern
     * - Output-only parameters
     * - Caller doesn't need to initialize
     * 
     * Use IN when:
     * - Large readonly structs (>16 bytes)
     * - Performance-critical paths
     * - Method doesn't modify parameter
     * - Prevent defensive copies
     * 
     * Use PARAMS when:
     * - Variable number of arguments
     * - Convenience APIs (logging, string.Format)
     * - Not in performance-critical loops (array allocation)
     * 
     * Use REF RETURN when:
     * - Return large struct without copy
     * - Enable modification of internal data
     * - High-performance scenarios
     */
}
```

---

**Batch 1 completed. Continue with next batch.**

---

## Batch 2: Async/Await, Threading & Concurrency (Questions 11-20)

### Question 11: Explain async/await at a high level. What happens under the hood when you await a Task?

**Short Theory:**  
`async/await` enables asynchronous programming without blocking threads. When you `await` a Task, the compiler generates a state machine that captures the execution context and returns control to the caller. If the Task is incomplete, the method yields; when complete, the continuation resumes from where it left off. This prevents thread blocking, enabling scalable server applications by freeing threads to handle other requests.

**Why do we use it?**  
Async/await dramatically improves scalability in I/O-bound operations (database calls, HTTP requests, file I/O) by not blocking threads during waits. A single server can handle thousands of concurrent requests instead of hundreds. It maintains readable, sequential code flow while achieving the performance benefits of callbacks without callback hell.

**Key Interview Points:**
- Compiler generates state machine (IAsyncStateMachine) for async methods
- `await` checks if Task is complete; if yes, continues synchronously
- If incomplete, captures SynchronizationContext and registers continuation
- Async is contagious—async methods should be async all the way up
- `ConfigureAwait(false)` avoids capturing SynchronizationContext for libraries

**Coding Example:**
```csharp
public class AsyncAwaitDemo
{
    // Synchronous I/O - BLOCKS thread
    public string FetchDataSync(string url)
    {
        using var client = new HttpClient();
        // Thread blocked for entire network call (100ms-5s)
        var response = client.GetStringAsync(url).Result; // BLOCKING
        return response;
    }
    
    // Asynchronous I/O - NON-BLOCKING
    public async Task<string> FetchDataAsync(string url)
    {
        using var client = new HttpClient();
        // Thread returns to pool while waiting for network
        var response = await client.GetStringAsync(url); // NON-BLOCKING
        return response;
    }
    
    // What compiler generates (simplified)
    public Task<string> FetchDataAsync_Generated(string url)
    {
        var stateMachine = new FetchDataStateMachine
        {
            _url = url,
            _builder = AsyncTaskMethodBuilder<string>.Create(),
            _state = -1
        };
        
        stateMachine._builder.Start(ref stateMachine);
        return stateMachine._builder.Task;
    }
    
    // Compiler-generated state machine (conceptual)
    private struct FetchDataStateMachine : IAsyncStateMachine
    {
        public int _state;
        public AsyncTaskMethodBuilder<string> _builder;
        public string _url;
        private TaskAwaiter<string> _awaiter;
        
        public void MoveNext()
        {
            try
            {
                if (_state == 0)
                {
                    // Resume from await
                    var result = _awaiter.GetResult();
                    _builder.SetResult(result);
                    return;
                }
                
                // Initial call
                var client = new HttpClient();
                _awaiter = client.GetStringAsync(_url).GetAwaiter();
                
                if (_awaiter.IsCompleted)
                {
                    // Fast path: already complete
                    var result = _awaiter.GetResult();
                    _builder.SetResult(result);
                }
                else
                {
                    // Slow path: not complete, register continuation
                    _state = 0;
                    _builder.AwaitUnsafeOnCompleted(ref _awaiter, ref this);
                }
            }
            catch (Exception ex)
            {
                _builder.SetException(ex);
            }
        }
        
        public void SetStateMachine(IAsyncStateMachine stateMachine) { }
    }
    
    // Multiple awaits in sequence
    public async Task<string> MultipleAwaitsAsync()
    {
        // Each await is a suspension point
        var data1 = await FetchDataAsync("url1"); // State 0
        var data2 = await FetchDataAsync("url2"); // State 1
        var data3 = await FetchDataAsync("url3"); // State 2
        
        return data1 + data2 + data3;
    }
    
    // ConfigureAwait(false) for libraries
    public async Task<string> LibraryMethodAsync(string url)
    {
        using var client = new HttpClient();
        
        // Don't capture SynchronizationContext (better performance)
        var response = await client.GetStringAsync(url).ConfigureAwait(false);
        
        // Continuation may run on different thread
        // Don't access UI elements or HttpContext here
        return response.ToUpper();
    }
    
    // Common mistake: async void (only for event handlers)
    public async void AsyncVoidBad() // AVOID - can't catch exceptions
    {
        await Task.Delay(100);
        throw new Exception("Lost!"); // Exception can't be caught by caller
    }
    
    // Correct: async Task
    public async Task AsyncTaskGood()
    {
        await Task.Delay(100);
        throw new Exception("Catchable"); // Exception propagates through Task
    }
    
    // Async event handler (only valid async void usage)
    public async void Button_Click(object sender, EventArgs e)
    {
        try
        {
            await FetchDataAsync("url");
        }
        catch (Exception ex)
        {
            // Must handle exceptions here
            Console.WriteLine(ex.Message);
        }
    }
    
    // Scalability demonstration
    public async Task ScalabilityDemo()
    {
        // Synchronous: 100 threads blocked
        var syncTasks = Enumerable.Range(0, 100)
            .Select(i => Task.Run(() => FetchDataSync($"url{i}")));
        
        // Asynchronous: threads return to pool during I/O
        var asyncTasks = Enumerable.Range(0, 100)
            .Select(i => FetchDataAsync($"url{i}"));
        
        await Task.WhenAll(asyncTasks);
    }
    
    // ValueTask for high-performance scenarios
    public async ValueTask<int> GetCachedValueAsync(string key)
    {
        // If cached, return synchronously without Task allocation
        if (_cache.TryGetValue(key, out int value))
            return value; // No heap allocation
        
        // If not cached, await
        value = await FetchFromDatabaseAsync(key);
        _cache[key] = value;
        return value;
    }
    
    private Dictionary<string, int> _cache = new();
    private async Task<int> FetchFromDatabaseAsync(string key)
    {
        await Task.Delay(10);
        return 42;
    }
}

// SynchronizationContext behavior
public class SyncContextDemo
{
    // ASP.NET Core: No SynchronizationContext (thread pool)
    public async Task AspNetCoreAsync()
    {
        Console.WriteLine($"Before: {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(100);
        Console.WriteLine($"After: {Thread.CurrentThread.ManagedThreadId}");
        // Different thread IDs - OK
    }
    
    // WPF/WinForms: UI SynchronizationContext
    public async Task WpfAsync()
    {
        // Runs on UI thread
        Console.WriteLine($"Before: {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(100);
        // Continuation marshaled back to UI thread
        Console.WriteLine($"After: {Thread.CurrentThread.ManagedThreadId}");
        // Same thread ID
        
        // Can safely access UI elements
        // txtResult.Text = "Done";
    }
}
```

---

### Question 12: What is the difference between Task and Thread? When should you use each?

**Short Theory:**  
Thread is a low-level OS construct that represents an actual execution thread with its own stack. Task is a higher-level abstraction representing a unit of work that may or may not run on a dedicated thread. Tasks use the ThreadPool for CPU-bound work and can represent asynchronous I/O without any thread. Tasks support composition (WhenAll, WhenAny), cancellation, and exception handling better than raw threads.

**Why do we use it?**  
Tasks provide efficient resource utilization through thread pooling and async I/O. Creating threads is expensive (1MB stack per thread), while Tasks reuse pooled threads. For I/O operations, Tasks don't use threads at all—they use OS-level async APIs. Tasks also enable modern async/await patterns and better error handling compared to manual thread management.

**Key Interview Points:**
- Thread: 1MB stack, expensive creation, manual lifecycle management
- Task: lightweight, pooled threads or threadless I/O, built-in composition
- Use Thread only for: long-running background work with `Thread.IsBackground`
- Use Task for: async I/O, parallel CPU work, modern async patterns
- Task.Run for CPU work, async/await for I/O work

**Coding Example:**
```csharp
public class TaskVsThreadDemo
{
    // Thread: low-level, explicit control
    public void UseThread()
    {
        var thread = new Thread(() =>
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000); // Blocking
            Console.WriteLine("Thread work done");
        });
        
        thread.IsBackground = true; // Don't prevent app exit
        thread.Priority = ThreadPriority.Normal;
        thread.Start();
        
        // Must manually join or let it run
        thread.Join(); // Block until complete
    }
    
    // Task: high-level, pooled
    public async Task UseTask()
    {
        var task = Task.Run(() =>
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine("Task work done");
        });
        
        await task; // Non-blocking wait
    }
    
    // CPU-bound work: Task.Run
    public async Task<int> CpuBoundWork()
    {
        return await Task.Run(() =>
        {
            // Expensive calculation on thread pool thread
            int sum = 0;
            for (int i = 0; i < 1000000; i++)
                sum += i;
            return sum;
        });
    }
    
    // I/O-bound work: async/await (no Task.Run)
    public async Task<string> IoBoundWork()
    {
        using var client = new HttpClient();
        
        // NO thread blocked during network call
        return await client.GetStringAsync("https://api.example.com");
    }
    
    // WRONG: Task.Run for I/O (wastes thread)
    public async Task<string> IoBoundWorkWrong()
    {
        return await Task.Run(async () =>
        {
            using var client = new HttpClient();
            // Wastes thread from pool just to await
            return await client.GetStringAsync("https://api.example.com");
        });
    }
    
    // Thread pool exhaustion demo
    public void ThreadPoolExhaustion()
    {
        ThreadPool.GetMaxThreads(out int maxWorker, out int maxIO);
        Console.WriteLine($"Max threads: {maxWorker}");
        
        // Bad: Blocking thread pool threads
        var tasks = new List<Task>();
        for (int i = 0; i < 1000; i++)
        {
            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(10000); // Blocks thread for 10s
            }));
        }
        
        // Thread pool exhausted, new tasks queue up
        Task.WaitAll(tasks.ToArray());
    }
    
    // Correct: Async I/O doesn't exhaust threads
    public async Task ScalableAsync()
    {
        var tasks = new List<Task<string>>();
        for (int i = 0; i < 1000; i++)
        {
            tasks.Add(IoBoundWork()); // No threads blocked
        }
        
        await Task.WhenAll(tasks); // Handles 1000 concurrent requests
    }
    
    // Long-running task: Use Thread or LongRunning hint
    public void LongRunningWork()
    {
        // Option 1: Dedicated thread
        var thread = new Thread(() =>
        {
            while (true)
            {
                // Background processing
                Thread.Sleep(1000);
            }
        })
        {
            IsBackground = true
        };
        thread.Start();
        
        // Option 2: Task with LongRunning hint
        Task.Factory.StartNew(() =>
        {
            while (true)
            {
                // Background processing
                Thread.Sleep(1000);
            }
        }, TaskCreationOptions.LongRunning); // Creates dedicated thread
    }
    
    // Task composition (advantage over threads)
    public async Task TaskComposition()
    {
        var task1 = IoBoundWork();
        var task2 = IoBoundWork();
        var task3 = IoBoundWork();
        
        // Wait for all
        await Task.WhenAll(task1, task2, task3);
        
        // Wait for any
        var completedTask = await Task.WhenAny(task1, task2, task3);
        
        // Timeout
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        try
        {
            await IoBoundWork().WaitAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Timed out");
        }
    }
    
    // Exception handling
    public async Task ExceptionHandling()
    {
        // Task: exceptions captured and re-thrown on await
        try
        {
            await Task.Run(() => throw new InvalidOperationException("Task error"));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
        
        // Thread: exceptions crash app unless handled inside thread
        var thread = new Thread(() =>
        {
            try
            {
                throw new InvalidOperationException("Thread error");
            }
            catch (Exception ex)
            {
                // Must handle here or app crashes
                Console.WriteLine($"Caught in thread: {ex.Message}");
            }
        });
        thread.Start();
    }
    
    // Performance comparison
    public void PerformanceComparison()
    {
        int iterations = 1000;
        
        // Threads: expensive creation
        var sw = System.Diagnostics.Stopwatch.StartNew();
        var threads = new List<Thread>();
        for (int i = 0; i < iterations; i++)
        {
            var thread = new Thread(() => { });
            threads.Add(thread);
            thread.Start();
        }
        threads.ForEach(t => t.Join());
        sw.Stop();
        Console.WriteLine($"Threads: {sw.ElapsedMilliseconds}ms");
        
        // Tasks: pooled, much faster
        sw.Restart();
        var tasks = new List<Task>();
        for (int i = 0; i < iterations; i++)
        {
            tasks.Add(Task.Run(() => { }));
        }
        Task.WaitAll(tasks.ToArray());
        sw.Stop();
        Console.WriteLine($"Tasks: {sw.ElapsedMilliseconds}ms");
    }
}

// Guidelines
public class TaskThreadGuidelines
{
    /*
     * Use TASK when:
     * - Async I/O operations (database, HTTP, file)
     * - Parallel CPU-bound work (Parallel.ForEach, Task.WhenAll)
     * - Modern async/await patterns
     * - Need composition, cancellation, exception handling
     * - Short to medium duration work
     * 
     * Use THREAD when:
     * - Long-running background work (years)
     * - Need complete control over thread lifecycle
     * - Custom thread priority or apartment state (COM interop)
     * - Legacy code requiring explicit threads
     * 
     * NEVER:
     * - Use Thread for I/O operations
     * - Use Task.Run for wrapping async methods
     * - Block on tasks with .Result or .Wait() in async context
     */
}
```

---

### Question 13: Explain deadlocks in multithreading. How do you prevent and detect them?

**Short Theory:**  
A deadlock occurs when two or more threads are blocked forever, each waiting for a resource held by another. Classic scenario: Thread A locks Resource1 and waits for Resource2; Thread B locks Resource2 and waits for Resource1. Neither can proceed. Deadlocks require four conditions: mutual exclusion, hold and wait, no preemption, and circular wait.

**Why do we use it?**  
Understanding deadlocks is critical for building reliable concurrent systems. Deadlocks cause applications to hang indefinitely, requiring process restarts. Prevention through proper lock ordering, timeout mechanisms, and avoiding nested locks is essential. Detection involves thread dumps, deadlock detection tools, and monitoring for hung threads.

**Key Interview Points:**
- Four Coffman conditions must all be present for deadlock
- Prevention: consistent lock ordering, avoid nested locks, use timeouts
- Use lock-free collections (ConcurrentDictionary) to avoid locks entirely
- `async/await` deadlocks from blocking on tasks in synchronization contexts
- Monitor threads with debugger, performance counters, or APM tools

**Coding Example:**
```csharp
public class DeadlockDemo
{
    private readonly object _lock1 = new object();
    private readonly object _lock2 = new object();
    
    // DEADLOCK: Inconsistent lock ordering
    public void DeadlockScenario()
    {
        var thread1 = new Thread(() =>
        {
            lock (_lock1)
            {
                Console.WriteLine("Thread 1: Locked lock1");
                Thread.Sleep(100); // Simulate work
                
                lock (_lock2) // Waits for lock2
                {
                    Console.WriteLine("Thread 1: Locked lock2");
                }
            }
        });
        
        var thread2 = new Thread(() =>
        {
            lock (_lock2)
            {
                Console.WriteLine("Thread 2: Locked lock2");
                Thread.Sleep(100); // Simulate work
                
                lock (_lock1) // Waits for lock1 - DEADLOCK!
                {
                    Console.WriteLine("Thread 2: Locked lock1");
                }
            }
        });
        
        thread1.Start();
        thread2.Start();
        
        thread1.Join();
        thread2.Join(); // Will never complete
    }
    
    // SOLUTION 1: Consistent lock ordering
    public void ConsistentLockOrdering()
    {
        var thread1 = new Thread(() =>
        {
            lock (_lock1) // Always lock1 first
            {
                Console.WriteLine("Thread 1: Locked lock1");
                Thread.Sleep(100);
                
                lock (_lock2) // Then lock2
                {
                    Console.WriteLine("Thread 1: Locked both");
                }
            }
        });
        
        var thread2 = new Thread(() =>
        {
            lock (_lock1) // Always lock1 first (same order)
            {
                Console.WriteLine("Thread 2: Locked lock1");
                Thread.Sleep(100);
                
                lock (_lock2) // Then lock2
                {
                    Console.WriteLine("Thread 2: Locked both");
                }
            }
        });
        
        thread1.Start();
        thread2.Start();
        
        thread1.Join();
        thread2.Join(); // Completes successfully
    }
    
    // SOLUTION 2: Timeout with Monitor.TryEnter
    public void LockWithTimeout()
    {
        var thread1 = new Thread(() =>
        {
            if (Monitor.TryEnter(_lock1, TimeSpan.FromSeconds(5)))
            {
                try
                {
                    Console.WriteLine("Thread 1: Locked lock1");
                    Thread.Sleep(100);
                    
                    if (Monitor.TryEnter(_lock2, TimeSpan.FromSeconds(5)))
                    {
                        try
                        {
                            Console.WriteLine("Thread 1: Locked both");
                        }
                        finally
                        {
                            Monitor.Exit(_lock2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thread 1: Timeout on lock2");
                    }
                }
                finally
                {
                    Monitor.Exit(_lock1);
                }
            }
        });
        
        // Thread2 similar implementation
        thread1.Start();
    }
    
    // SOLUTION 3: Lock-free with concurrent collections
    private readonly ConcurrentDictionary<string, int> _concurrentData = new();
    
    public void LockFreeApproach()
    {
        // No locks needed, thread-safe by design
        Parallel.For(0, 100, i =>
        {
            _concurrentData.AddOrUpdate(
                $"key{i}",
                1,
                (key, oldValue) => oldValue + 1
            );
        });
    }
    
    // ASYNC/AWAIT DEADLOCK: Blocking on async
    public string AsyncDeadlock()
    {
        // Simulates ASP.NET or WPF SynchronizationContext
        var context = new MockSyncContext();
        SynchronizationContext.SetSynchronizationContext(context);
        
        // DEADLOCK: Blocking on async with SynchronizationContext
        var result = AsyncMethod().Result; // Blocks UI/request thread
        
        return result;
    }
    
    private async Task<string> AsyncMethod()
    {
        await Task.Delay(100); // Tries to resume on blocked thread
        return "Done";
    }
    
    // SOLUTION: Use async all the way
    public async Task<string> AsyncNoDeadlock()
    {
        return await AsyncMethod(); // No blocking
    }
    
    // SOLUTION: ConfigureAwait(false) in libraries
    private async Task<string> LibraryMethod()
    {
        await Task.Delay(100).ConfigureAwait(false);
        return "Done";
    }
    
    public string AsyncDeadlockFixed()
    {
        var context = new MockSyncContext();
        SynchronizationContext.SetSynchronizationContext(context);
        
        var result = LibraryMethod().Result; // No deadlock
        return result;
    }
    
    // Detecting deadlocks at runtime
    public void DetectDeadlock()
    {
        var timer = new System.Timers.Timer(5000); // Check every 5 seconds
        timer.Elapsed += (s, e) =>
        {
            // Get thread dump
            var threads = Process.GetCurrentProcess().Threads;
            foreach (ProcessThread thread in threads)
            {
                if (thread.ThreadState == System.Diagnostics.ThreadState.Wait)
                {
                    // Potential deadlock if wait time too long
                    Console.WriteLine($"Thread {thread.Id} waiting for {thread.WaitReason}");
                }
            }
        };
        timer.Start();
    }
    
    // Hierarchical locking (prevent circular dependencies)
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        private readonly object _lock = new object();
        
        public void Transfer(Account to, decimal amount)
        {
            // Lock in consistent order based on Id
            Account first = this.Id < to.Id ? this : to;
            Account second = this.Id < to.Id ? to : this;
            
            lock (first._lock)
            {
                lock (second._lock)
                {
                    if (this.Balance >= amount)
                    {
                        this.Balance -= amount;
                        to.Balance += amount;
                    }
                }
            }
        }
    }
    
    // Using Semaphore to limit concurrent access
    private static SemaphoreSlim _semaphore = new SemaphoreSlim(3, 3);
    
    public async Task SemaphoreExample()
    {
        await _semaphore.WaitAsync();
        try
        {
            // Only 3 threads can execute this block concurrently
            await Task.Delay(1000);
        }
        finally
        {
            _semaphore.Release();
        }
    }
}

// Mock SynchronizationContext for demonstration
public class MockSyncContext : SynchronizationContext
{
    public override void Post(SendOrPostCallback d, object state)
    {
        // Simulate posting to blocked thread
        d(state);
    }
}

// Deadlock prevention guidelines
public class DeadlockGuidelines
{
    /*
     * PREVENTION STRATEGIES:
     * 1. Consistent lock ordering (always acquire locks in same order)
     * 2. Avoid nested locks when possible
     * 3. Use Monitor.TryEnter with timeouts
     * 4. Use lock-free collections (Concurrent*)
     * 5. Keep lock duration minimal
     * 6. Use async/await instead of locks for I/O
     * 7. Never call external code inside locks
     * 
     * ASYNC/AWAIT DEADLOCKS:
     * 1. Never block on async with .Result or .Wait()
     * 2. Use async all the way up
     * 3. Use ConfigureAwait(false) in library code
     * 4. ASP.NET Core doesn't have SyncContext (less prone)
     * 
     * DETECTION:
     * 1. Visual Studio debugger (Debug > Windows > Threads)
     * 2. Performance Monitor (Thread Wait Time)
     * 3. WinDbg with !syncblk command
     * 4. Application Insights dependency tracking
     * 5. Timeout monitoring in production
     */
}
```

---

### Question 14: What are concurrent collections? When should you use them vs locks?

**Short Theory:**  
Concurrent collections (ConcurrentDictionary, ConcurrentQueue, ConcurrentBag, BlockingCollection) provide thread-safe operations without explicit locking. They use lock-free algorithms, fine-grained locking, and atomic operations internally. These collections are optimized for concurrent reads and writes, offering better performance than manually locking standard collections in multi-threaded scenarios.

**Why do we use it?**  
Concurrent collections eliminate manual lock management, reducing deadlock risks and simplifying code. They're optimized for specific concurrent patterns—ConcurrentDictionary for shared state, ConcurrentQueue for producer-consumer, ConcurrentBag for local work stealing. Performance is significantly better than lock-guarded regular collections in high-contention scenarios.

**Key Interview Points:**
- Lock-free operations for better scalability and no deadlock risk
- ConcurrentDictionary: thread-safe dictionary with atomic operations
- ConcurrentQueue: FIFO, no locks, ideal for producer-consumer
- ConcurrentBag: unordered, thread-local optimization for Parallel.ForEach
- BlockingCollection: producer-consumer with blocking take/add operations

**Coding Example:**
```csharp
public class ConcurrentCollectionsDemo
{
    // BAD: Regular Dictionary with locks
    private readonly Dictionary<string, int> _regularDict = new();
    private readonly object _dictLock = new object();
    
    public void RegularDictionaryWithLock()
    {
        Parallel.For(0, 1000, i =>
        {
            lock (_dictLock) // Contention point
            {
                if (!_regularDict.ContainsKey($"key{i}"))
                    _regularDict[$"key{i}"] = i;
            }
        });
    }
    
    // GOOD: ConcurrentDictionary (lock-free)
    private readonly ConcurrentDictionary<string, int> _concurrentDict = new();
    
    public void ConcurrentDictionaryExample()
    {
        Parallel.For(0, 1000, i =>
        {
            // No explicit lock needed, thread-safe
            _concurrentDict.TryAdd($"key{i}", i);
        });
        
        // Atomic operations
        _concurrentDict.AddOrUpdate(
            "counter",
            1, // Add value if key doesn't exist
            (key, oldValue) => oldValue + 1 // Update if exists
        );
        
        // GetOrAdd (lazy initialization, thread-safe)
        var value = _concurrentDict.GetOrAdd("key", k =>
        {
            // Factory method called only if key doesn't exist
            return ExpensiveComputation();
        });
    }
    
    private int ExpensiveComputation() => 42;
    
    // ConcurrentQueue: Producer-Consumer pattern
    private readonly ConcurrentQueue<WorkItem> _workQueue = new();
    
    public async Task ProducerConsumerExample()
    {
        // Producer
        var producerTask = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                _workQueue.Enqueue(new WorkItem { Id = i });
                Thread.Sleep(10);
            }
        });
        
        // Consumers
        var consumers = Enumerable.Range(0, 3).Select(id => Task.Run(() =>
        {
            while (!_workQueue.IsEmpty || !producerTask.IsCompleted)
            {
                if (_workQueue.TryDequeue(out var item))
                {
                    Console.WriteLine($"Consumer {id} processing {item.Id}");
                    Thread.Sleep(50);
                }
            }
        }));
        
        await Task.WhenAll(consumers.Append(producerTask));
    }
    
    // BlockingCollection: Producer-Consumer with blocking
    private readonly BlockingCollection<WorkItem> _blockingQueue = 
        new BlockingCollection<WorkItem>(boundedCapacity: 10);
    
    public async Task BlockingCollectionExample()
    {
        var cts = new CancellationTokenSource();
        
        // Producer
        var producer = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                // Blocks if queue is full (capacity 10)
                _blockingQueue.Add(new WorkItem { Id = i });
                Console.WriteLine($"Produced {i}");
            }
            _blockingQueue.CompleteAdding();
        }, cts.Token);
        
        // Consumer
        var consumer = Task.Run(() =>
        {
            // Take blocks until item available
            foreach (var item in _blockingQueue.GetConsumingEnumerable())
            {
                Console.WriteLine($"Consumed {item.Id}");
                Thread.Sleep(100); // Simulate slow processing
            }
        }, cts.Token);
        
        await Task.WhenAll(producer, consumer);
    }
    
    // ConcurrentBag: Unordered collection (thread-local optimization)
    private readonly ConcurrentBag<int> _bag = new();
    
    public void ConcurrentBagExample()
    {
        // Ideal for Parallel.ForEach where each thread adds items
        Parallel.ForEach(Enumerable.Range(0, 1000), i =>
        {
            // Thread-local optimization: minimal contention
            _bag.Add(i * i);
        });
        
        // Retrieve items (unordered)
        while (_bag.TryTake(out int item))
        {
            Console.WriteLine(item);
        }
    }
    
    // ConcurrentStack (LIFO)
    private readonly ConcurrentStack<string> _stack = new();
    
    public void ConcurrentStackExample()
    {
        // Push
        Parallel.For(0, 100, i =>
        {
            _stack.Push($"Item{i}");
        });
        
        // Pop
        if (_stack.TryPop(out string item))
        {
            Console.WriteLine($"Popped: {item}");
        }
        
        // Peek
        if (_stack.TryPeek(out string peeked))
        {
            Console.WriteLine($"Peeked: {peeked}");
        }
    }
    
    // Performance comparison
    public void PerformanceComparison()
    {
        int operations = 100000;
        
        // Regular Dictionary with lock
        var dict = new Dictionary<int, int>();
        var lockObj = new object();
        var sw = System.Diagnostics.Stopwatch.StartNew();
        
        Parallel.For(0, operations, i =>
        {
            lock (lockObj)
            {
                dict[i] = i;
            }
        });
        sw.Stop();
        Console.WriteLine($"Dictionary with lock: {sw.ElapsedMilliseconds}ms");
        
        // ConcurrentDictionary
        var concurrentDict = new ConcurrentDictionary<int, int>();
        sw.Restart();
        
        Parallel.For(0, operations, i =>
        {
            concurrentDict[i] = i;
        });
        sw.Stop();
        Console.WriteLine($"ConcurrentDictionary: {sw.ElapsedMilliseconds}ms");
    }
    
    // Cache implementation with ConcurrentDictionary
    public class ThreadSafeCache<TKey, TValue>
    {
        private readonly ConcurrentDictionary<TKey, Lazy<TValue>> _cache = new();
        
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
        {
            // Lazy ensures factory called only once per key
            var lazy = _cache.GetOrAdd(key, k => new Lazy<TValue>(() => valueFactory(k)));
            return lazy.Value;
        }
        
        public bool TryRemove(TKey key)
        {
            return _cache.TryRemove(key, out _);
        }
    }
    
    // Real-world example: Request rate limiter
    public class RateLimiter
    {
        private readonly ConcurrentDictionary<string, ConcurrentQueue<DateTime>> _requests = new();
        private readonly int _maxRequestsPerMinute;
        
        public RateLimiter(int maxRequestsPerMinute)
        {
            _maxRequestsPerMinute = maxRequestsPerMinute;
        }
        
        public bool AllowRequest(string clientId)
        {
            var now = DateTime.UtcNow;
            var queue = _requests.GetOrAdd(clientId, _ => new ConcurrentQueue<DateTime>());
            
            // Remove old requests
            while (queue.TryPeek(out var oldest) && (now - oldest).TotalMinutes > 1)
            {
                queue.TryDequeue(out _);
            }
            
            // Check limit
            if (queue.Count >= _maxRequestsPerMinute)
                return false;
            
            queue.Enqueue(now);
            return true;
        }
    }
    
    // ImmutableCollections for functional patterns
    public void ImmutableCollectionsExample()
    {
        // System.Collections.Immutable NuGet package
        var list = System.Collections.Immutable.ImmutableList<int>.Empty;
        
        // Returns new instance, original unchanged
        var newList = list.Add(1).Add(2).Add(3);
        
        Console.WriteLine(list.Count); // 0
        Console.WriteLine(newList.Count); // 3
        
        // Thread-safe by design (immutability)
        // No locks needed for concurrent reads
    }
}

public class WorkItem
{
    public int Id { get; set; }
}

// Usage guidelines
public class ConcurrentCollectionGuidelines
{
    /*
     * Use CONCURRENTDICTIONARY when:
     * - Shared state across threads
     * - Frequent reads and writes
     * - Need atomic operations (AddOrUpdate, GetOrAdd)
     * - Cache implementations
     * 
     * Use CONCURRENTQUEUE when:
     * - FIFO producer-consumer pattern
     * - Task scheduling
     * - Message queues
     * 
     * Use CONCURRENTBAG when:
     * - Order doesn't matter
     * - Each thread produces and consumes its own items
     * - Parallel.ForEach scenarios
     * 
     * Use CONCURRENTSTACK when:
     * - LIFO operations
     * - Undo/redo functionality
     * 
     * Use BLOCKINGCOLLECTION when:
     * - Producer-consumer with backpressure
     * - Need blocking Take/Add operations
     * - Bounded queue with flow control
     * 
     * Use LOCKS when:
     * - Complex multi-step operations
     * - Coordinating multiple resources
     * - Very low contention scenarios
     * 
     * Use IMMUTABLE COLLECTIONS when:
     * - Functional programming patterns
     * - Need snapshot isolation
     * - Frequent reads, rare writes
     */
}
```

---

### Question 15: Explain the difference between lock, Monitor, Mutex, and Semaphore.

**Short Theory:**  
`lock` is a syntactic sugar for Monitor.Enter/Exit, providing automatic cleanup. Monitor offers advanced features like Wait/Pulse for thread signaling. Mutex is a system-wide synchronization primitive that works across processes. Semaphore limits concurrent access to a resource pool (e.g., max 5 threads), unlike locks which allow only one thread. SemaphoreSlim is a lightweight async-compatible alternative.

**Why do we use it?**  
Different synchronization needs require different primitives. `lock` is sufficient for 90% of cases. Monitor provides condition variables for producer-consumer patterns. Mutex enables inter-process synchronization (single-instance applications). Semaphore/SemaphoreSlim manages resource pools (connection limits, rate limiting). SemaphoreSlim supports async/await, crucial for modern applications.

**Key Interview Points:**
- `lock` = syntactic sugar for Monitor, not inter-process capable
- Monitor supports Wait/Pulse for conditional locking
- Mutex works across processes, heavier weight than Monitor
- Semaphore: allows N threads concurrently (resource pool management)
- SemaphoreSlim: lighter, async-compatible, in-process only

**Coding Example:**
```csharp
public class SynchronizationPrimitivesDemo
{
    // LOCK: Most common, simple syntax
    private readonly object _lockObject = new object();
    private int _counter = 0;
    
    public void LockExample()
    {
        lock (_lockObject)
        {
            _counter++;
            // Automatic Monitor.Exit even if exception thrown
        }
        
        // Equivalent to:
        bool lockTaken = false;
        try
        {
            Monitor.Enter(_lockObject, ref lockTaken);
            _counter++;
        }
        finally
        {
            if (lockTaken)
                Monitor.Exit(_lockObject);
        }
    }
    
    // MONITOR: Advanced features (Wait/Pulse)
    private readonly object _monitorLock = new object();
    private Queue<int> _queue = new Queue<int>();
    private const int MaxQueueSize = 10;
    
    public void ProducerWithMonitor(int item)
    {
        lock (_monitorLock)
        {
            // Wait while queue is full
            while (_queue.Count >= MaxQueueSize)
            {
                Monitor.Wait(_monitorLock); // Releases lock and waits
            }
            
            _queue.Enqueue(item);
            Console.WriteLine($"Produced: {item}");
            
            // Signal waiting consumers
            Monitor.Pulse(_monitorLock);
        }
    }
    
    public int ConsumerWithMonitor()
    {
        lock (_monitorLock)
        {
            // Wait while queue is empty
            while (_queue.Count == 0)
            {
                Monitor.Wait(_monitorLock); // Releases lock and waits
            }
            
            int item = _queue.Dequeue();
            Console.WriteLine($"Consumed: {item}");
            
            // Signal waiting producers
            Monitor.Pulse(_monitorLock);
            
            return item;
        }
    }
    
    // Monitor.TryEnter with timeout
    public bool TryLockWithTimeout()
    {
        bool lockAcquired = false;
        try
        {
            lockAcquired = Monitor.TryEnter(_lockObject, TimeSpan.FromSeconds(5));
            if (lockAcquired)
            {
                // Critical section
                _counter++;
                return true;
            }
            else
            {
                Console.WriteLine("Lock timeout");
                return false;
            }
        }
        finally
        {
            if (lockAcquired)
                Monitor.Exit(_lockObject);
        }
    }
    
    // MUTEX: Inter-process synchronization
    private static Mutex _mutex = new Mutex(false, "Global\\MyAppMutex");
    
    public void MutexExample()
    {
        try
        {
            // Try to acquire mutex
            if (_mutex.WaitOne(TimeSpan.FromSeconds(5)))
            {
                try
                {
                    // Critical section (only one process at a time)
                    Console.WriteLine("Mutex acquired");
                    Thread.Sleep(1000);
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }
            else
            {
                Console.WriteLine("Another process has the mutex");
            }
        }
        catch (AbandonedMutexException)
        {
            // Previous process crashed without releasing
            Console.WriteLine("Mutex was abandoned");
        }
    }
    
    // Single-instance application with Mutex
    public class SingleInstanceApp
    {
        private static Mutex _singleInstanceMutex;
        
        public static bool TryStart()
        {
            bool createdNew;
            _singleInstanceMutex = new Mutex(true, "Global\\MyUniqueAppName", out createdNew);
            
            if (!createdNew)
            {
                Console.WriteLine("Application already running");
                return false;
            }
            
            return true;
        }
        
        public static void Stop()
        {
            _singleInstanceMutex?.ReleaseMutex();
            _singleInstanceMutex?.Dispose();
        }
    }
    
    // SEMAPHORE: Limit concurrent access (resource pool)
    private static Semaphore _semaphore = new Semaphore(3, 3); // Max 3 concurrent
    
    public void SemaphoreExample()
    {
        Console.WriteLine("Waiting to enter...");
        _semaphore.WaitOne(); // Blocks if 3 threads already inside
        
        try
        {
            // Only 3 threads can be here simultaneously
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} entered");
            Thread.Sleep(2000);
        }
        finally
        {
            _semaphore.Release();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} exited");
        }
    }
    
    // SEMAPHORESLIM: Lightweight, async-compatible
    private static SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(3, 3);
    
    public async Task SemaphoreSlimExample()
    {
        Console.WriteLine("Waiting to enter...");
        await _semaphoreSlim.WaitAsync(); // Async wait
        
        try
        {
            // Only 3 threads can be here simultaneously
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} entered");
            await Task.Delay(2000);
        }
        finally
        {
            _semaphoreSlim.Release();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} exited");
        }
    }
    
    // Real-world: Connection pool limit with SemaphoreSlim
    public class ConnectionPool
    {
        private readonly SemaphoreSlim _semaphore;
        private readonly int _maxConnections;
        
        public ConnectionPool(int maxConnections)
        {
            _maxConnections = maxConnections;
            _semaphore = new SemaphoreSlim(maxConnections, maxConnections);
        }
        
        public async Task<Connection> GetConnectionAsync()
        {
            await _semaphore.WaitAsync();
            try
            {
                return new Connection(this);
            }
            catch
            {
                _semaphore.Release();
                throw;
            }
        }
        
        internal void ReturnConnection(Connection connection)
        {
            _semaphore.Release();
        }
        
        public class Connection : IDisposable
        {
            private readonly ConnectionPool _pool;
            private bool _disposed = false;
            
            internal Connection(ConnectionPool pool)
            {
                _pool = pool;
            }
            
            public void Dispose()
            {
                if (!_disposed)
                {
                    _pool.ReturnConnection(this);
                    _disposed = true;
                }
            }
        }
    }
    
    // Real-world: Rate limiter with SemaphoreSlim
    public class RateLimiter
    {
        private readonly SemaphoreSlim _semaphore;
        private readonly TimeSpan _timeUnit;
        
        public RateLimiter(int maxRequests, TimeSpan timeUnit)
        {
            _semaphore = new SemaphoreSlim(maxRequests, maxRequests);
            _timeUnit = timeUnit;
        }
        
        public async Task<T> ExecuteAsync<T>(Func<Task<T>> action)
        {
            await _semaphore.WaitAsync();
            
            try
            {
                return await action();
            }
            finally
            {
                // Release after time unit expires
                _ = Task.Run(async () =>
                {
                    await Task.Delay(_timeUnit);
                    _semaphore.Release();
                });
            }
        }
    }
    
    // ReaderWriterLockSlim: Multiple readers, single writer
    private readonly ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();
    private Dictionary<string, string> _cache = new Dictionary<string, string>();
    
    public string Read(string key)
    {
        _rwLock.EnterReadLock();
        try
        {
            // Multiple threads can read simultaneously
            return _cache.TryGetValue(key, out string value) ? value : null;
        }
        finally
        {
            _rwLock.ExitReadLock();
        }
    }
    
    public void Write(string key, string value)
    {
        _rwLock.EnterWriteLock();
        try
        {
            // Only one thread can write
            _cache[key] = value;
        }
        finally
        {
            _rwLock.ExitWriteLock();
        }
    }
    
    // Performance comparison
    public void PerformanceComparison()
    {
        int iterations = 1000000;
        
        // lock
        var lockObj = new object();
        var sw = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            lock (lockObj) { }
        }
        sw.Stop();
        Console.WriteLine($"lock: {sw.ElapsedMilliseconds}ms");
        
        // Monitor
        sw.Restart();
        for (int i = 0; i < iterations; i++)
        {
            Monitor.Enter(lockObj);
            Monitor.Exit(lockObj);
        }
        sw.Stop();
        Console.WriteLine($"Monitor: {sw.ElapsedMilliseconds}ms");
        
        // Mutex (much slower)
        var mutex = new Mutex();
        sw.Restart();
        for (int i = 0; i < 10000; i++) // Fewer iterations due to cost
        {
            mutex.WaitOne();
            mutex.ReleaseMutex();
        }
        sw.Stop();
        Console.WriteLine($"Mutex (10k): {sw.ElapsedMilliseconds}ms");
        
        // SemaphoreSlim
        var sem = new SemaphoreSlim(1, 1);
        sw.Restart();
        for (int i = 0; i < iterations; i++)
        {
            sem.Wait();
            sem.Release();
        }
        sw.Stop();
        Console.WriteLine($"SemaphoreSlim: {sw.ElapsedMilliseconds}ms");
    }
}

// Guidelines
public class SynchronizationGuidelines
{
    /*
     * Use LOCK when:
     * - Simple mutual exclusion in single process
     * - Short critical sections
     * - Default choice for most scenarios
     * 
     * Use MONITOR when:
     * - Need Wait/Pulse for producer-consumer
     * - Conditional waiting with signaling
     * - Same process only
     * 
     * Use MUTEX when:
     * - Inter-process synchronization
     * - Single-instance applications
     * - System-wide locks
     * - Note: Much slower than Monitor
     * 
     * Use SEMAPHORE when:
     * - Limit concurrent access (resource pool)
     * - Inter-process semaphore needed
     * - Allow N threads simultaneously
     * 
     * Use SEMAPHORESLIM when:
     * - Same as Semaphore but in-process only
     * - Need async/await support
     * - Better performance than Semaphore
     * - Connection pools, rate limiting
     * 
     * Use READERWRITERLOCKSLIM when:
     * - Many readers, few writers
     * - Read operations outnumber writes 10:1 or more
     * - Caching scenarios
     */
}
```

---

### Question 16: What is thread safety? How do you make a class thread-safe?

**Short Theory:**  
Thread safety means a class or method can be used safely by multiple threads concurrently without data corruption or unexpected behavior. Techniques include immutability, synchronization primitives (lock, Interlocked), concurrent collections, and thread-local storage. Thread-safe code ensures atomicity of operations, proper visibility of changes, and maintains invariants under concurrent access.

**Why do we use it?**  
In multi-threaded environments, unsynchronized shared state leads to race conditions, data corruption, and non-deterministic bugs that are hard to reproduce. Thread-safe design prevents these issues. However, perfect thread safety often impacts performance through synchronization overhead. The key is choosing the right level of thread safety for your use case.

**Key Interview Points:**
- Immutability is the simplest thread safety—no shared mutable state
- Interlocked operations for atomic increments without locks
- ThreadLocal<T> for per-thread state without synchronization
- Read-only collections vs truly immutable collections
- Thread-safe doesn't mean deadlock-proof or always correct

**Coding Example:**
```csharp
// NOT THREAD-SAFE: Race condition
public class UnsafeCounter
{
    private int _count = 0;
    
    public void Increment()
    {
        _count++; // Not atomic: read, increment, write
    }
    
    public int GetCount() => _count;
}

// THREAD-SAFE: Using lock
public class SafeCounterWithLock
{
    private int _count = 0;
    private readonly object _lock = new object();
    
    public void Increment()
    {
        lock (_lock)
        {
            _count++;
        }
    }
    
    public int GetCount()
    {
        lock (_lock)
        {
            return _count;
        }
    }
}

// THREAD-SAFE: Using Interlocked (better performance)
public class SafeCounterInterlocked
{
    private int _count = 0;
    
    public void Increment()
    {
        Interlocked.Increment(ref _count); // Atomic operation
    }
    
    public int GetCount()
    {
        return Interlocked.CompareExchange(ref _count, 0, 0); // Atomic read
    }
}

// IMMUTABLE: Inherently thread-safe
public sealed class ImmutablePerson
{
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }
    
    public ImmutablePerson(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    
    // Create modified copy instead of mutating
    public ImmutablePerson WithAge(int newAge)
    {
        return new ImmutablePerson(FirstName, LastName, newAge);
    }
}

// Thread-safe singleton (lazy initialization)
public sealed class ThreadSafeSingleton
{
    // Lazy<T> is thread-safe by default
    private static readonly Lazy<ThreadSafeSingleton> _instance =
        new Lazy<ThreadSafeSingleton>(() => new ThreadSafeSingleton());
    
    public static ThreadSafeSingleton Instance => _instance.Value;
    
    private ThreadSafeSingleton()
    {
        // Private constructor
    }
}

// Thread-safe cache with double-check locking
public class ThreadSafeCache<TKey, TValue>
{
    private readonly Dictionary<TKey, TValue> _cache = new Dictionary<TKey, TValue>();
    private readonly object _lock = new object();
    
    public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
    {
        // First check (no lock)
        if (_cache.TryGetValue(key, out TValue value))
            return value;
        
        lock (_lock)
        {
            // Double-check inside lock
            if (_cache.TryGetValue(key, out value))
                return value;
            
            // Create and cache
            value = valueFactory(key);
            _cache[key] = value;
            return value;
        }
    }
}

// ThreadLocal: Per-thread state
public class ThreadLocalExample
{
    private static ThreadLocal<Random> _threadRandom = new ThreadLocal<Random>(() => new Random());
    
    public int GetRandomNumber()
    {
        // Each thread gets its own Random instance
        return _threadRandom.Value.Next();
    }
    
    // StringBuilder per thread (avoid allocation)
    private static ThreadLocal<StringBuilder> _stringBuilder =
        new ThreadLocal<StringBuilder>(() => new StringBuilder());
    
    public string BuildString(string[] parts)
    {
        var sb = _stringBuilder.Value;
        sb.Clear();
        
        foreach (var part in parts)
            sb.Append(part);
        
        return sb.ToString();
    }
}

// Volatile: Prevent compiler optimizations
public class VolatileExample
{
    // Without volatile, thread might cache this value
    private volatile bool _stopRequested = false;
    
    public void RequestStop()
    {
        _stopRequested = true; // Write is immediately visible to other threads
    }
    
    public void WorkerThread()
    {
        while (!_stopRequested) // Read is not cached
        {
            // Do work
        }
    }
}

// Real-world: Thread-safe event aggregator
public class ThreadSafeEventAggregator
{
    private readonly ConcurrentDictionary<Type, List<Delegate>> _subscriptions = new();
    private readonly ConcurrentDictionary<Type, object> _locks = new();
    
    public void Subscribe<TEvent>(Action<TEvent> handler)
    {
        var eventType = typeof(TEvent);
        var lockObj = _locks.GetOrAdd(eventType, _ => new object());
        
        lock (lockObj)
        {
            var handlers = _subscriptions.GetOrAdd(eventType, _ => new List<Delegate>());
            handlers.Add(handler);
        }
    }
    
    public void Publish<TEvent>(TEvent eventData)
    {
        var eventType = typeof(TEvent);
        
        if (_subscriptions.TryGetValue(eventType, out var handlers))
        {
            // Create copy to avoid modification during iteration
            Delegate[] handlersCopy;
            var lockObj = _locks[eventType];
            
            lock (lockObj)
            {
                handlersCopy = handlers.ToArray();
            }
            
            foreach (Action<TEvent> handler in handlersCopy)
            {
                handler(eventData);
            }
        }
    }
}

// Read-write scenarios with ReaderWriterLockSlim
public class ThreadSafeRepository<T>
{
    private readonly List<T> _items = new List<T>();
    private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();
    
    public T Get(int index)
    {
        _lock.EnterReadLock();
        try
        {
            return _items[index];
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }
    
    public IEnumerable<T> GetAll()
    {
        _lock.EnterReadLock();
        try
        {
            // Return copy to avoid lock holding during iteration
            return _items.ToList();
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }
    
    public void Add(T item)
    {
        _lock.EnterWriteLock();
        try
        {
            _items.Add(item);
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }
}

// Async-safe locking with SemaphoreSlim
public class AsyncThreadSafeResource
{
    private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
    private int _value = 0;
    
    public async Task<int> IncrementAsync()
    {
        await _semaphore.WaitAsync();
        try
        {
            // Simulate async work
            await Task.Delay(10);
            return ++_value;
        }
        finally
        {
            _semaphore.Release();
        }
    }
}

// Demonstrating race condition
public class RaceConditionDemo
{
    private int _count = 0;
    
    public void DemonstrateRaceCondition()
    {
        var tasks = Enumerable.Range(0, 1000)
            .Select(_ => Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    _count++; // RACE CONDITION
                }
            }));
        
        Task.WaitAll(tasks.ToArray());
        
        // Expected: 1,000,000
        // Actual: Much less due to race condition
        Console.WriteLine($"Count: {_count}");
    }
}

// Thread-safety levels
public class ThreadSafetyLevels
{
    /*
     * IMMUTABLE (Highest safety):
     * - No mutable state
     * - Inherently thread-safe
     * - Example: String, ImmutableList<T>
     * 
     * THREAD-SAFE (Full safety):
     * - Can be used concurrently without external synchronization
     * - Example: ConcurrentDictionary, Interlocked operations
     * 
     * INSTANCE THREAD-SAFE (Conditional):
     * - Safe if each thread uses different instance
     * - Not safe if same instance shared
     * - Example: StringBuilder, List<T>
     * 
     * NOT THREAD-SAFE (Requires external synchronization):
     * - Must be protected with locks
     * - Example: Regular collections
     */
}

// Guidelines
public class ThreadSafetyGuidelines
{
    /*
     * MAKE THREAD-SAFE:
     * 1. Prefer immutability
     * 2. Use Interlocked for simple atomic operations
     * 3. Use concurrent collections for shared state
     * 4. Use locks for complex multi-step operations
     * 5. Use ThreadLocal for per-thread state
     * 6. Use volatile for flags and simple values
     * 
     * AVOID:
     * 1. Double-checked locking (unless necessary)
     * 2. Locking on 'this' or public objects
     * 3. Calling external code inside locks
     * 4. Assuming operations are atomic (they're usually not)
     * 
     * TESTING:
     * 1. Use stress tests with many threads
     * 2. Tools: Concurrency Visualizer, Thread Sanitizer
     * 3. Code reviews focusing on shared state
     * 4. Look for race conditions in all shared mutable state
     */
}
```

---

### Question 17: Explain Parallel.ForEach vs regular foreach. When would you use parallel processing?

**Short Theory:**  
`Parallel.ForEach` partitions the source collection and processes chunks concurrently on multiple thread pool threads. Unlike sequential `foreach`, it doesn't guarantee order and introduces overhead for thread coordination. It's effective for CPU-bound operations on large collections where per-item processing time exceeds partitioning overhead (~100+ microseconds per item).

**Why do we use it?**  
Modern CPUs have multiple cores that remain idle with sequential processing. Parallel.ForEach utilizes all cores, dramatically reducing processing time for CPU-bound operations (image processing, calculations, transformations). However, it's counterproductive for I/O-bound work (use async/await) or small collections (overhead exceeds benefit).

**Key Interview Points:**
- Only beneficial for CPU-bound operations, not I/O-bound
- Collection size matters: overhead significant for <10,000 items
- Per-item work must be substantial (>100 microseconds)
- Thread-safety required for shared state access
- PLINQ (AsParallel()) alternative for LINQ queries

**Coding Example:**
```csharp
public class ParallelProcessingDemo
{
    // Sequential foreach
    public List<int> SequentialProcessing(List<int> numbers)
    {
        var results = new List<int>();
        
        foreach (var number in numbers)
        {
            results.Add(ExpensiveComputation(number));
        }
        
        return results;
    }
    
    // Parallel.ForEach
    public List<int> ParallelProcessing(List<int> numbers)
    {
        var results = new ConcurrentBag<int>(); // Thread-safe collection
        
        Parallel.ForEach(numbers, number =>
        {
            results.Add(ExpensiveComputation(number));
        });
        
        return results.ToList();
    }
    
    // CPU-bound expensive operation
    private int ExpensiveComputation(int input)
    {
        // Simulate CPU work (hashing, encryption, calculations)
        int result = input;
        for (int i = 0; i < 1000; i++)
        {
            result = result * 31 + i;
        }
        return result;
    }
    
    // Performance comparison
    public void PerformanceComparison()
    {
        var numbers = Enumerable.Range(0, 100000).ToList();
        
        // Sequential
        var sw = System.Diagnostics.Stopwatch.StartNew();
        var seqResults = SequentialProcessing(numbers);
        sw.Stop();
        Console.WriteLine($"Sequential: {sw.ElapsedMilliseconds}ms");
        
        // Parallel
        sw.Restart();
        var parResults = ParallelProcessing(numbers);
        sw.Stop();
        Console.WriteLine($"Parallel: {sw.ElapsedMilliseconds}ms");
    }
    
    // Parallel.ForEach with options
    public void ParallelWithOptions()
    {
        var numbers = Enumerable.Range(0, 1000).ToList();
        
        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount, // Default
            CancellationToken = CancellationToken.None
        };
        
        Parallel.ForEach(numbers, options, number =>
        {
            Console.WriteLine($"Processing {number} on thread {Thread.CurrentThread.ManagedThreadId}");
        });
    }
    
    // Parallel.For (index-based)
    public void ParallelFor()
    {
        Parallel.For(0, 1000, i =>
        {
            Console.WriteLine($"Index {i} on thread {Thread.CurrentThread.ManagedThreadId}");
        });
    }
    
    // WRONG: Parallel for I/O-bound work
    public async Task ParallelIoBoundWrong(List<string> urls)
    {
        var results = new ConcurrentBag<string>();
        
        // BAD: Wastes threads waiting for I/O
        Parallel.ForEach(urls, url =>
        {
            using var client = new HttpClient();
            var result = client.GetStringAsync(url).Result; // Blocking!
            results.Add(result);
        });
    }
    
    // CORRECT: Async for I/O-bound work
    public async Task<List<string>> AsyncIoBoundCorrect(List<string> urls)
    {
        var tasks = urls.Select(async url =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url); // Non-blocking
        });
        
        return (await Task.WhenAll(tasks)).ToList();
    }
    
    // PLINQ: Parallel LINQ
    public void PlinqExample()
    {
        var numbers = Enumerable.Range(0, 1000000);
        
        // Sequential LINQ
        var seqQuery = numbers
            .Where(n => n % 2 == 0)
            .Select(n => n * n)
            .ToList();
        
        // Parallel LINQ
        var parQuery = numbers
            .AsParallel()
            .Where(n => n % 2 == 0)
            .Select(n => n * n)
            .ToList();
        
        // Ordered parallel (slower but maintains order)
        var orderedQuery = numbers
            .AsParallel()
            .AsOrdered()
            .Where(n => n % 2 == 0)
            .Select(n => n * n)
            .ToList();
    }
    
    // Partitioning strategies
    public void PartitioningExample()
    {
        var numbers = Enumerable.Range(0, 10000);
        
        // Default partitioning
        Parallel.ForEach(numbers, number =>
        {
            ExpensiveComputation(number);
        });
        
        // Custom partitioner (for load balancing)
        var partitioner = Partitioner.Create(0, numbers.Count(), 100); // Chunks of 100
        
        Parallel.ForEach(partitioner, range =>
        {
            for (int i = range.Item1; i < range.Item2; i++)
            {
                ExpensiveComputation(i);
            }
        });
    }
    
    // Handling exceptions in parallel
    public void ParallelExceptionHandling()
    {
        try
        {
            Parallel.ForEach(Enumerable.Range(0, 100), i =>
            {
                if (i % 10 == 0)
                    throw new InvalidOperationException($"Error at {i}");
            });
        }
        catch (AggregateException ae)
        {
            // All exceptions collected in AggregateException
            foreach (var ex in ae.InnerExceptions)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    
    // Early exit with cancellation
    public void ParallelWithCancellation()
    {
        var cts = new CancellationTokenSource();
        var options = new ParallelOptions { CancellationToken = cts.Token };
        
        try
        {
            Parallel.ForEach(Enumerable.Range(0, 1000), options, (i, state) =>
            {
                if (i == 500)
                {
                    cts.Cancel(); // Stop all iterations
                    return;
                }
                
                Console.WriteLine(i);
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Parallel loop cancelled");
        }
    }
    
    // Parallel.ForEach with local state (thread-local aggregation)
    public int ParallelWithThreadLocalState(List<int> numbers)
    {
        int total = 0;
        object lockObj = new object();
        
        Parallel.ForEach(
            numbers,
            () => 0, // Thread-local initializer
            (number, state, threadLocal) =>
            {
                // Each thread accumulates in its own variable
                return threadLocal + number;
            },
            threadLocal =>
            {
                // Aggregate thread-local results
                lock (lockObj)
                {
                    total += threadLocal;
                }
            }
        );
        
        return total;
    }
    
    // Real-world: Image processing
    public void ParallelImageProcessing(List<Image> images)
    {
        Parallel.ForEach(images, new ParallelOptions
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount
        }, image =>
        {
            // CPU-intensive operations
            ApplyFilter(image);
            ResizeImage(image);
            CompressImage(image);
        });
    }
    
    private void ApplyFilter(Image img) { /* CPU work */ }
    private void ResizeImage(Image img) { /* CPU work */ }
    private void CompressImage(Image img) { /* CPU work */ }
    
    // When NOT to use parallel
    public void WhenNotToUseParallel()
    {
        var smallList = Enumerable.Range(0, 10).ToList();
        
        // BAD: Overhead > benefit
        Parallel.ForEach(smallList, i =>
        {
            Console.WriteLine(i); // Too simple
        });
        
        // GOOD: Sequential for small/simple operations
        foreach (var i in smallList)
        {
            Console.WriteLine(i);
        }
    }
}

public class Image { /* Image data */ }

// Guidelines
public class ParallelProcessingGuidelines
{
    /*
     * Use PARALLEL.FOREACH when:
     * - CPU-bound operations (calculations, transformations)
     * - Large collections (>10,000 items)
     * - Per-item work is substantial (>100 microseconds)
     * - Order doesn't matter or you can handle unordered results
     * - Operations are independent (no shared state)
     * 
     * Use SEQUENTIAL FOREACH when:
     * - I/O-bound operations (use async/await instead)
     * - Small collections (<1,000 items)
     * - Quick operations (<10 microseconds)
     * - Order matters and must be preserved
     * - Operations have dependencies
     * 
     * Use PLINQ when:
     * - Complex LINQ queries on large datasets
     * - Need declarative syntax
     * - Same conditions as Parallel.ForEach
     * 
     * Use ASYNC/AWAIT when:
     * - I/O-bound operations (database, HTTP, file)
     * - Need to scale concurrent requests
     * - Avoid thread blocking
     * 
     * PERFORMANCE TIPS:
     * 1. Measure before parallelizing
     * 2. Avoid shared mutable state
     * 3. Use thread-local aggregation
     * 4. Choose appropriate partition size
     * 5. Consider Amdahl's Law (parallel portion limits speedup)
     */
}
```

---

### Question 18: What is the difference between cancellation tokens and timeouts? How do you implement cancellation properly?

**Short Theory:**  
CancellationToken enables cooperative cancellation of asynchronous operations. The caller creates a CancellationTokenSource and passes its token to async methods, which periodically check `IsCancellationRequested` or call `ThrowIfCancellationRequested()`. Timeouts can be implemented through CancellationTokenSource or Task.WaitAsync. Cancellation is cooperative—methods must explicitly check the token.

**Why do we use it?**  
Cancellation prevents wasted resources on obsolete operations (user navigated away, request timeout, application shutdown). It's critical for responsive UIs and efficient server resource management. Proper cancellation cleanup prevents resource leaks, zombie threads, and unexpected behavior. Timeouts protect against hanging operations and enforce SLAs.

**Key Interview Points:**
- Cancellation is cooperative—method must check token
- `ThrowIfCancellationRequested()` throws OperationCanceledException
- Link tokens to create hierarchical cancellation
- Dispose CancellationTokenSource after use to prevent leaks
- Use `WaitAsync()` for timeout-based cancellation in .NET 6+

**Coding Example:**
```csharp
public class CancellationDemo
{
    // Basic cancellation pattern
    public async Task<string> FetchDataAsync(string url, CancellationToken cancellationToken)
    {
        using var client = new HttpClient();
        
        // Pass token to async method
        var response = await client.GetStringAsync(url, cancellationToken);
        
        return response;
    }
    
    // Usage with cancellation
    public async Task UsageExample()
    {
        using var cts = new CancellationTokenSource();
        
        try
        {
            var task = FetchDataAsync("https://api.example.com", cts.Token);
            
            // Cancel after 5 seconds
            cts.CancelAfter(TimeSpan.FromSeconds(5));
            
            var result = await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation cancelled");
        }
    }
    
    // Manual cancellation checking in loops
    public async Task ProcessLargeDataset(List<int> data, CancellationToken cancellationToken)
    {
        foreach (var item in data)
        {
            // Check cancellation periodically
            cancellationToken.ThrowIfCancellationRequested();
            
            // Process item
            await ProcessItemAsync(item);
        }
    }
    
    private async Task ProcessItemAsync(int item)
    {
        await Task.Delay(100);
    }
    
    // Cancellation with cleanup
    public async Task<Stream> OpenFileWithCleanupAsync(string path, CancellationToken cancellationToken)
    {
        var stream = new FileStream(path, FileMode.Open);
        
        try
        {
            // Register cleanup action
            using var registration = cancellationToken.Register(() =>
            {
                stream?.Dispose();
                Console.WriteLine("Cleaned up file stream");
            });
            
            // Simulate async work
            await Task.Delay(1000, cancellationToken);
            
            return stream;
        }
        catch
        {
            stream?.Dispose();
            throw;
        }
    }
    
    // Timeout using CancellationTokenSource
    public async Task<string> WithTimeoutOld(Task<string> task, TimeSpan timeout)
    {
        using var cts = new CancellationTokenSource(timeout);
        
        try
        {
            return await task.WaitAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {
            throw new TimeoutException($"Operation timed out after {timeout}");
        }
    }
    
    // .NET 6+ WaitAsync with timeout
    public async Task<string> WithTimeoutNew(Task<string> task, TimeSpan timeout)
    {
        try
        {
            return await task.WaitAsync(timeout);
        }
        catch (TimeoutException)
        {
            Console.WriteLine("Operation timed out");
            throw;
        }
    }
    
    // Linked cancellation tokens
    public async Task LinkedCancellationExample()
    {
        using var appShutdownCts = new CancellationTokenSource();
        using var requestCts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        
        // Combine tokens: cancels if either source cancels
        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(
            appShutdownCts.Token,
            requestCts.Token
        );
        
        try
        {
            await FetchDataAsync("https://api.example.com", linkedCts.Token);
        }
        catch (OperationCanceledException)
        {
            if (appShutdownCts.Token.IsCancellationRequested)
                Console.WriteLine("Cancelled due to app shutdown");
            else if (requestCts.Token.IsCancellationRequested)
                Console.WriteLine("Cancelled due to request timeout");
        }
    }
    
    // Cancellation with Parallel.ForEach
    public void ParallelWithCancellation(List<int> items)
    {
        using var cts = new CancellationTokenSource();
        
        var options = new ParallelOptions
        {
            CancellationToken = cts.Token
        };
        
        try
        {
            Parallel.ForEach(items, options, (item, state) =>
            {
                if (item == 100)
                    cts.Cancel(); // Cancel remaining iterations
                
                Console.WriteLine($"Processing {item}");
                Thread.Sleep(100);
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Parallel operation cancelled");
        }
    }
    
    // Polling vs callback pattern
    public async Task PollingPattern(CancellationToken cancellationToken)
    {
        // Check periodically
        while (!cancellationToken.IsCancellationRequested)
        {
            await Task.Delay(1000);
            Console.WriteLine("Working...");
        }
        
        Console.WriteLine("Stopped via polling");
    }
    
    public async Task CallbackPattern(CancellationToken cancellationToken)
    {
        var tcs = new TaskCompletionSource<bool>();
        
        // Register callback
        using var registration = cancellationToken.Register(() =>
        {
            Console.WriteLine("Cancelled via callback");
            tcs.TrySetCanceled();
        });
        
        // Wait for cancellation or completion
        await Task.WhenAny(tcs.Task, Task.Delay(10000));
    }
    
    // Graceful shutdown pattern
    public class BackgroundService
    {
        private readonly CancellationTokenSource _cts = new();
        private Task _backgroundTask;
        
        public void Start()
        {
            _backgroundTask = RunAsync(_cts.Token);
        }
        
        public async Task StopAsync()
        {
            _cts.Cancel();
            
            try
            {
                // Wait for graceful shutdown (with timeout)
                await _backgroundTask.WaitAsync(TimeSpan.FromSeconds(30));
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Graceful shutdown timeout");
            }
            finally
            {
                _cts.Dispose();
            }
        }
        
        private async Task RunAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    await DoWorkAsync(cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    // Expected during shutdown
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    await Task.Delay(5000, cancellationToken);
                }
            }
            
            Console.WriteLine("Background service stopped");
        }
        
        private async Task DoWorkAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(1000, cancellationToken);
        }
    }
    
    // Real-world: HTTP request with cancellation
    public async Task<string> HttpRequestWithCancellation(string url, int timeoutSeconds)
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutSeconds));
        using var client = new HttpClient();
        
        try
        {
            var response = await client.GetAsync(url, cts.Token);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (OperationCanceledException)
        {
            throw new TimeoutException($"Request to {url} timed out");
        }
    }
    
    // Real-world: Database query with cancellation
    public async Task<List<User>> GetUsersAsync(CancellationToken cancellationToken)
    {
        // using var connection = new SqlConnection(_connectionString);
        // await connection.OpenAsync(cancellationToken);
        
        // using var command = new SqlCommand("SELECT * FROM Users", connection);
        // command.CommandTimeout = 30;
        
        var users = new List<User>();
        
        // using var reader = await command.ExecuteReaderAsync(cancellationToken);
        // while (await reader.ReadAsync(cancellationToken))
        // {
        //     cancellationToken.ThrowIfCancellationRequested();
        //     users.Add(MapUser(reader));
        // }
        
        return users;
    }
    
    // Avoiding common mistakes
    public class CancellationMistakes
    {
        // MISTAKE 1: Not disposing CancellationTokenSource
        public async Task MistakeNotDisposing()
        {
            var cts = new CancellationTokenSource(); // LEAK: Not disposed
            await Task.Delay(1000, cts.Token);
        }
        
        // CORRECT
        public async Task CorrectDisposing()
        {
            using var cts = new CancellationTokenSource();
            await Task.Delay(1000, cts.Token);
        }
        
        // MISTAKE 2: Swallowing OperationCanceledException
        public async Task MistakeSwallowing(CancellationToken cancellationToken)
        {
            try
            {
                await Task.Delay(1000, cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // BAD: Silent swallowing prevents proper cancellation
            }
        }
        
        // CORRECT
        public async Task CorrectHandling(CancellationToken cancellationToken)
        {
            try
            {
                await Task.Delay(1000, cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // Cleanup if needed
                throw; // Re-throw to propagate cancellation
            }
        }
        
        // MISTAKE 3: Not checking cancellation in long-running loops
        public async Task MistakeNotChecking(List<int> items, CancellationToken cancellationToken)
        {
            foreach (var item in items)
            {
                // BAD: Never checks cancellation
                await ProcessItemAsync(item);
            }
        }
        
        // CORRECT
        public async Task CorrectChecking(List<int> items, CancellationToken cancellationToken)
        {
            foreach (var item in items)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await ProcessItemAsync(item);
            }
        }
        
        private async Task ProcessItemAsync(int item)
        {
            await Task.Delay(100);
        }
    }
}

public class User { }

// Guidelines
public class CancellationGuidelines
{
    /*
     * IMPLEMENTING CANCELLATION:
     * 1. Accept CancellationToken parameter in async methods
     * 2. Pass token to all async operations
     * 3. Check cancellationToken.IsCancellationRequested in loops
     * 4. Use ThrowIfCancellationRequested() for automatic exception
     * 5. Always dispose CancellationTokenSource
     * 
     * HANDLING CANCELLATION:
     * 1. Catch OperationCanceledException specifically
     * 2. Perform cleanup in catch/finally blocks
     * 3. Re-throw after cleanup to propagate cancellation
     * 4. Register cleanup callbacks with token.Register()
     * 
     * TIMEOUT VS CANCELLATION:
     * - Timeout: Time-based automatic cancellation
     * - Cancellation: User/application-initiated
     * - Use CancellationTokenSource(timeout) or WaitAsync(timeout)
     * 
     * BEST PRACTICES:
     * 1. Default CancellationToken.None for optional cancellation
     * 2. Link tokens for hierarchical cancellation
     * 3. Set reasonable timeout values
     * 4. Test cancellation paths explicitly
     * 5. Document cancellation behavior in XML comments
     */
}
```

---

### Question 19: Explain Task.Run, Task.Factory.StartNew, and when to use each.

**Short Theory:**  
`Task.Run` is a simplified API for queuing work to the thread pool, defaulting to Task.Factory.StartNew with optimal settings for most scenarios. `Task.Factory.StartNew` provides granular control over task creation (scheduler, options, parent-child relationships) but requires careful parameter selection to avoid pitfalls. Task.Run is preferred for 95% of use cases; StartNew is for advanced scenarios requiring specific task schedulers or long-running tasks.

**Why do we use it?**  
Task.Run abstracts complexity and prevents common mistakes (forgetting TaskCreationOptions.DenyChildAttach, wrong scheduler). StartNew's flexibility is needed for custom schedulers, explicit parent-child tasks, or long-running operations requiring dedicated threads. Using Task.Run keeps code simple and maintainable while StartNew handles edge cases.

**Key Interview Points:**
- Task.Run: preferred default, unwraps nested Task<Task<T>> automatically
- StartNew: advanced control, but easy to misuse without proper options
- Use TaskCreationOptions.LongRunning for operations that block threads extensively
- Never use Task.Run to wrap already-async methods (double thread pool scheduling)
- Task.Factory.StartNew needed for custom TaskScheduler

**Coding Example:**
```csharp
public class TaskCreationDemo
{
    // Task.Run - Simple and safe (preferred)
    public async Task<int> TaskRunExample()
    {
        var result = await Task.Run(() =>
        {
            // CPU-bound work on thread pool
            Thread.Sleep(1000);
            return 42;
        });
        
        return result;
    }
    
    // Task.Run with async lambda (automatic unwrapping)
    public async Task<string> TaskRunAsyncLambda()
    {
        var result = await Task.Run(async () =>
        {
            await Task.Delay(1000);
            return "Done";
        }); // Returns Task<string>, not Task<Task<string>>
        
        return result;
    }
    
    // Task.Factory.StartNew - Granular control
    public async Task<int> StartNewExample()
    {
        var task = Task.Factory.StartNew(() =>
        {
            Thread.Sleep(1000);
            return 42;
        },
        CancellationToken.None,
        TaskCreationOptions.DenyChildAttach,
        TaskScheduler.Default);
        
        return await task;
    }
    
    // PITFALL: StartNew with async lambda (nested Task)
    public async Task<string> StartNewPitfall()
    {
        var task = Task.Factory.StartNew(async () =>
        {
            await Task.Delay(1000);
            return "Done";
        }); // Returns Task<Task<string>>
        
        // Need to unwrap manually
        return await await task; // Double await!
    }
    
    // Long-running task with Task.Factory.StartNew
    public void LongRunningTask()
    {
        Task.Factory.StartNew(() =>
        {
            while (true)
            {
                // Long-running background work
                Thread.Sleep(1000);
                Console.WriteLine("Background work");
            }
        },
        TaskCreationOptions.LongRunning); // Creates dedicated thread
    }
    
    // Long-running task with Task.Run (not ideal)
    public void LongRunningTaskRun()
    {
        // BAD: Blocks thread pool thread indefinitely
        Task.Run(() =>
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Background work");
            }
        }); // No LongRunning option available
    }
    
    // Custom TaskScheduler example
    public async Task CustomSchedulerExample()
    {
        var customScheduler = new LimitedConcurrencyLevelTaskScheduler(2);
        
        var task = Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"Running on custom scheduler, Thread: {Thread.CurrentThread.ManagedThreadId}");
            return 42;
        },
        CancellationToken.None,
        TaskCreationOptions.None,
        customScheduler); // Custom scheduler
        
        await task;
    }
    
    // Parent-child task relationship
    public async Task ParentChildTasks()
    {
        var parentTask = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("Parent started");
            
            // Create attached child task
            var childTask = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Child completed");
            },
            TaskCreationOptions.AttachedToParent);
            
            Console.WriteLine("Parent ending");
        });
        
        await parentTask; // Waits for both parent and child
        Console.WriteLine("Parent task completed (child also done)");
    }
    
    // WRONG: Task.Run for I/O (double scheduling)
    public async Task<string> WrongTaskRunForIo()
    {
        // BAD: Wastes thread from pool
        return await Task.Run(async () =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.example.com");
            // Thread blocked just to await another async operation
        });
    }
    
    // CORRECT: Direct await for I/O
    public async Task<string> CorrectIoOperation()
    {
        using var client = new HttpClient();
        return await client.GetStringAsync("https://api.example.com");
    }
    
    // Comparison of Task.Run vs StartNew
    public async Task ComparisonDemo()
    {
        // Task.Run - simple, safe, recommended
        var taskRun = Task.Run(() =>
        {
            return CalculateAsync();
        }); // Automatically unwraps Task<Task<int>> to Task<int>
        
        int result1 = await taskRun;
        
        // Task.Factory.StartNew - complex, requires unwrapping
        var taskStartNew = Task.Factory.StartNew(() =>
        {
            return CalculateAsync();
        }); // Returns Task<Task<int>>
        
        int result2 = await await taskStartNew; // Manual unwrapping needed
    }
    
    private async Task<int> CalculateAsync()
    {
        await Task.Delay(100);
        return 42;
    }
    
    // Cancellation with Task.Run
    public async Task TaskRunWithCancellation(CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                Thread.Sleep(10);
            }
        }, cancellationToken);
    }
    
    // Real-world: Offloading CPU work in ASP.NET
    public async Task<IActionResult> ProcessImageAsync(byte[] imageData)
    {
        // Offload CPU-intensive work from request thread
        var processedImage = await Task.Run(() =>
        {
            return ApplyImageFilters(imageData);
        });
        
        return new FileContentResult(processedImage, "image/jpeg");
    }
    
    private byte[] ApplyImageFilters(byte[] data)
    {
        // CPU-intensive image processing
        Thread.Sleep(1000);
        return data;
    }
    
    // Task.Delay vs Thread.Sleep
    public async Task TaskDelayVsThreadSleep()
    {
        // Task.Delay: Non-blocking, returns control
        await Task.Delay(1000); // Thread returns to pool
        
        // Thread.Sleep: Blocking, wastes thread
        Thread.Sleep(1000); // Thread blocked for 1 second
    }
    
    // Task.Yield - yield execution
    public async Task TaskYieldExample()
    {
        Console.WriteLine("Before yield");
        
        // Yield to allow other operations
        await Task.Yield();
        
        Console.WriteLine("After yield (may be on different thread)");
    }
}

// Custom TaskScheduler (limited concurrency)
public class LimitedConcurrencyLevelTaskScheduler : TaskScheduler
{
    private readonly int _maxDegreeOfParallelism;
    private readonly LinkedList<Task> _tasks = new LinkedList<Task>();
    private int _delegatesQueuedOrRunning = 0;
    
    public LimitedConcurrencyLevelTaskScheduler(int maxDegreeOfParallelism)
    {
        _maxDegreeOfParallelism = maxDegreeOfParallelism;
    }
    
    protected override IEnumerable<Task> GetScheduledTasks()
    {
        return _tasks;
    }
    
    protected override void QueueTask(Task task)
    {
        lock (_tasks)
        {
            _tasks.AddLast(task);
            
            if (_delegatesQueuedOrRunning < _maxDegreeOfParallelism)
            {
                ++_delegatesQueuedOrRunning;
                ThreadPool.QueueUserWorkItem(_ => ProcessTasks());
            }
        }
    }
    
    private void ProcessTasks()
    {
        while (true)
        {
            Task task;
            lock (_tasks)
            {
                if (_tasks.Count == 0)
                {
                    --_delegatesQueuedOrRunning;
                    break;
                }
                
                task = _tasks.First.Value;
                _tasks.RemoveFirst();
            }
            
            TryExecuteTask(task);
        }
    }
    
    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
    {
        return false;
    }
    
    public override int MaximumConcurrencyLevel => _maxDegreeOfParallelism;
}

public interface IActionResult { }
public class FileContentResult : IActionResult
{
    public FileContentResult(byte[] data, string contentType) { }
}

// Guidelines
public class TaskCreationGuidelines
{
    /*
     * Use TASK.RUN when:
     * - CPU-bound work in async context
     * - Offloading synchronous work to thread pool
     * - Simple task creation (95% of cases)
     * - Working with async lambdas
     * 
     * Use TASK.FACTORY.STARTNEW when:
     * - Need custom TaskScheduler
     * - Long-running tasks (use LongRunning option)
     * - Parent-child task relationships
     * - Granular control over task options
     * 
     * NEVER:
     * - Use Task.Run for I/O-bound work (use async/await)
     * - Use Task.Run to wrap already-async methods
     * - Use StartNew without proper options (use Task.Run instead)
     * - Block on tasks with .Result or .Wait() in async code
     * 
     * LONG-RUNNING TASKS:
     * - Use Task.Factory.StartNew with LongRunning option
     * - Or create explicit Thread for very long-running work
     * - Don't use Task.Run (no LongRunning option available)
     * 
     * REMEMBER:
     * - Task.Run is safer and simpler
     * - StartNew requires careful parameter selection
     * - Task.Run unwraps nested tasks automatically
     * - StartNew returns Task<Task<T>> with async lambdas
     */
}
```

---

### Question 20: What are synchronization contexts? How do they affect async/await behavior?

**Short Theory:**  
SynchronizationContext is an abstraction that represents a "place" where code executes—UI thread in WPF/WinForms, ASP.NET request context (legacy), or thread pool. When awaiting, the compiler captures the current SynchronizationContext and uses it to resume execution. This ensures UI code resumes on the UI thread. ASP.NET Core removed SynchronizationContext for better performance. ConfigureAwait(false) prevents context capture.

**Why do we use it?**  
SynchronizationContext enables awaited code to automatically return to the proper execution context—critical for UI thread affinity in desktop apps. However, capturing context has performance overhead. Libraries use ConfigureAwait(false) to avoid unnecessary context switches. Understanding this prevents deadlocks (blocking on async in UI contexts) and improves performance in high-throughput scenarios.

**Key Interview Points:**
- UI apps (WPF, WinForms) have UI SynchronizationContext; marshals continuations to UI thread
- ASP.NET Core has no SynchronizationContext (thread pool agnostic)
- ConfigureAwait(false) prevents context capture, improves performance
- Blocking on async (Result, Wait) with SynchronizationContext causes deadlocks
- Task.Run doesn't capture SynchronizationContext

**Coding Example:**
```csharp
public class SynchronizationContextDemo
{
    // WPF/WinForms: UI SynchronizationContext
    public async Task WpfExample()
    {
        // Running on UI thread
        Console.WriteLine($"Before await: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"SyncContext: {SynchronizationContext.Current?.GetType().Name}");
        
        await Task.Delay(1000); // Async operation
        
        // Resumes on UI thread (context captured)
        Console.WriteLine($"After await: {Thread.CurrentThread.ManagedThreadId}");
        
        // Safe to access UI elements
        // textBox.Text = "Done";
    }
    
    // ASP.NET Core: No SynchronizationContext
    public async Task AspNetCoreExample()
    {
        // Running on thread pool thread
        Console.WriteLine($"Before await: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"SyncContext: {SynchronizationContext.Current?.GetType().Name ?? "null"}");
        
        await Task.Delay(1000);
        
        // May resume on different thread pool thread
        Console.WriteLine($"After await: {Thread.CurrentThread.ManagedThreadId}");
        // Thread IDs likely different - OK in ASP.NET Core
    }
    
    // ConfigureAwait(false) - Don't capture context
    public async Task LibraryMethod()
    {
        using var client = new HttpClient();
        
        // Don't capture SynchronizationContext
        var response = await client.GetStringAsync("https://api.example.com")
            .ConfigureAwait(false);
        
        // May resume on any thread pool thread
        // DON'T access UI elements here
        
        return response.ToUpper();
    }
    
    // DEADLOCK: Blocking on async in UI context
    public string DeadlockExample()
    {
        // Simulated UI context
        var uiContext = new MockUiSynchronizationContext();
        SynchronizationContext.SetSynchronizationContext(uiContext);
        
        // DEADLOCK: Blocking on async
        var result = FetchDataAsync().Result; // UI thread blocked
        
        // FetchDataAsync tries to resume on blocked UI thread
        return result;
    }
    
    private async Task<string> FetchDataAsync()
    {
        await Task.Delay(1000); // Tries to resume on UI thread
        return "Done";
    }
    
    // SOLUTION 1: Use async all the way
    public async Task<string> NoDeadlockAsync()
    {
        return await FetchDataAsync(); // No blocking
    }
    
    // SOLUTION 2: ConfigureAwait(false)
    private async Task<string> FetchDataWithConfigureAwait()
    {
        await Task.Delay(1000).ConfigureAwait(false); // Don't capture context
        return "Done";
    }
    
    public string NoDeadlockConfigureAwait()
    {
        var uiContext = new MockUiSynchronizationContext();
        SynchronizationContext.SetSynchronizationContext(uiContext);
        
        var result = FetchDataWithConfigureAwait().Result; // No deadlock
        return result;
    }
    
    // Explicit context switching
    public async Task ExplicitContextSwitch()
    {
        // Capture current context
        var originalContext = SynchronizationContext.Current;
        
        // Switch to thread pool
        await Task.Run(() =>
        {
            Console.WriteLine("On thread pool");
            Console.WriteLine($"SyncContext: {SynchronizationContext.Current?.GetType().Name ?? "null"}");
        });
        
        // Back to original context
        Console.WriteLine("Back to original context");
    }
    
    // Task.Run doesn't capture context
    public async Task TaskRunNoContext()
    {
        var uiContext = new MockUiSynchronizationContext();
        SynchronizationContext.SetSynchronizationContext(uiContext);
        
        await Task.Run(async () =>
        {
            // No SynchronizationContext here
            Console.WriteLine($"SyncContext: {SynchronizationContext.Current?.GetType().Name ?? "null"}");
            
            await Task.Delay(1000);
            
            // Still no context after await
            Console.WriteLine($"After await: {SynchronizationContext.Current?.GetType().Name ?? "null"}");
        });
    }
    
    // Real-world: UI progress reporting
    public async Task ReportProgressAsync(IProgress<int> progress)
    {
        for (int i = 0; i <= 100; i += 10)
        {
            // Do work on thread pool
            await Task.Run(() => Thread.Sleep(100));
            
            // Report progress (marshaled to UI thread automatically)
            progress?.Report(i);
        }
    }
    
    // Usage in WPF
    public async Task WpfProgressExample()
    {
        var progress = new Progress<int>(value =>
        {
            // This callback runs on UI thread
            // progressBar.Value = value;
            Console.WriteLine($"Progress: {value}%");
        });
        
        await ReportProgressAsync(progress);
    }
    
    // Library code pattern
    public async Task<string> LibraryCodePattern()
    {
        // Library code should use ConfigureAwait(false)
        var data1 = await FetchData1().ConfigureAwait(false);
        var data2 = await FetchData2().ConfigureAwait(false);
        var data3 = await FetchData3().ConfigureAwait(false);
        
        // All continuations run on thread pool
        return data1 + data2 + data3;
    }
    
    private async Task<string> FetchData1()
    {
        await Task.Delay(100).ConfigureAwait(false);
        return "A";
    }
    
    private async Task<string> FetchData2()
    {
        await Task.Delay(100).ConfigureAwait(false);
        return "B";
    }
    
    private async Task<string> FetchData3()
    {
        await Task.Delay(100).ConfigureAwait(false);
        return "C";
    }
    
    // Application code pattern (UI)
    public async Task ApplicationCodePattern()
    {
        // Application code uses default context
        var result = await LibraryCodePattern(); // No ConfigureAwait needed
        
        // Safe to access UI here
        // textBox.Text = result;
    }
    
    // Performance impact of context capture
    public async Task PerformanceComparison()
    {
        var uiContext = new MockUiSynchronizationContext();
        SynchronizationContext.SetSynchronizationContext(uiContext);
        
        int iterations = 1000;
        
        // With context capture
        var sw = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            await Task.Yield(); // Captures context
        }
        sw.Stop();
        Console.WriteLine($"With context: {sw.ElapsedMilliseconds}ms");
        
        // Without context capture
        sw.Restart();
        for (int i = 0; i < iterations; i++)
        {
            await Task.Yield().ConfigureAwait(false);
        }
        sw.Stop();
        Console.WriteLine($"Without context: {sw.ElapsedMilliseconds}ms");
    }
    
    // Custom SynchronizationContext
    public class CustomSynchronizationContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object state)
        {
            Console.WriteLine("Posting to custom context");
            ThreadPool.QueueUserWorkItem(_ => d(state));
        }
        
        public override void Send(SendOrPostCallback d, object state)
        {
            Console.WriteLine("Sending to custom context");
            d(state);
        }
    }
}

// Mock UI SynchronizationContext for testing
public class MockUiSynchronizationContext : SynchronizationContext
{
    private readonly BlockingCollection<(SendOrPostCallback, object)> _queue = new();
    private readonly Thread _thread;
    
    public MockUiSynchronizationContext()
    {
        _thread = new Thread(ProcessQueue) { IsBackground = true };
        _thread.Start();
    }
    
    public override void Post(SendOrPostCallback d, object state)
    {
        _queue.Add((d, state));
    }
    
    public override void Send(SendOrPostCallback d, object state)
    {
        if (Thread.CurrentThread == _thread)
        {
            d(state);
        }
        else
        {
            var mre = new ManualResetEventSlim();
            _queue.Add((s =>
            {
                try { d(s); }
                finally { mre.Set(); }
            }, state));
            mre.Wait();
        }
    }
    
    private void ProcessQueue()
    {
        foreach (var (callback, state) in _queue.GetConsumingEnumerable())
        {
            callback(state);
        }
    }
}

// Guidelines
public class SynchronizationContextGuidelines
{
    /*
     * SYNCHRONIZATION CONTEXTS:
     * - WPF/WinForms: UI SynchronizationContext (single UI thread)
     * - ASP.NET (legacy): AspNetSynchronizationContext (one thread per request)
     * - ASP.NET Core: None (thread pool agnostic)
     * - Console/Background: None (thread pool)
     * 
     * CONFIGUREAWAIT(FALSE):
     * Use in:
     * - Library code (always)
     * - Performance-critical paths
     * - Code that doesn't need specific thread
     * 
     * Don't use in:
     * - Application UI code (need to return to UI thread)
     * - Code accessing thread-specific state (HttpContext, UI elements)
     * 
     * DEADLOCK PREVENTION:
     * 1. Never block on async with .Result or .Wait() in UI code
     * 2. Use async all the way up
     * 3. Use ConfigureAwait(false) in library code
     * 4. ASP.NET Core doesn't have context (less prone to deadlocks)
     * 
     * BEST PRACTICES:
     * 1. Library code: Always ConfigureAwait(false)
     * 2. Application code: Default (capture context)
     * 3. Avoid Task.Run in ASP.NET Core (already on thread pool)
     * 4. Use IProgress<T> for UI progress reporting
     * 5. Test with different SynchronizationContexts
     */
}
```

---

**Batch 2 completed. Continue with next batch.**

---

## Batch 3: LINQ, Collections & Delegates (Questions 21-30)

### Question 21: Explain deferred execution in LINQ. What are the implications in production code?

**Short Theory:**  
LINQ uses deferred execution—queries are not executed when defined, but when enumerated (foreach, ToList, Count, etc.). The query is re-evaluated each time it's enumerated. This enables composability and efficiency but can cause unexpected behavior if the source data changes between definition and execution. Immediate execution methods (ToList, ToArray, Count) force evaluation and cache results.

**Why do we use it?**  
Deferred execution allows building complex queries through composition without intermediate allocations. It enables streaming data processing where results are yielded as needed. However, it can cause performance issues if queries are enumerated multiple times or if closures capture changing state. Understanding when to materialize results with ToList() is critical for production code.

**Key Interview Points:**
- Query definition and execution are separate; execution happens on enumeration
- Multiple enumerations re-execute the entire query (performance impact)
- Closure variables captured at execution time, not definition time
- IEnumerable = deferred, materialized collections = immediate
- Use ToList()/ToArray() to materialize when query will be enumerated multiple times

**Coding Example:**
```csharp
public class DeferredExecutionDemo
{
    // Deferred execution - query not executed yet
    public void DeferredExecutionExample()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        // Query defined but NOT executed
        var query = numbers.Where(n => n > 2).Select(n => n * 2);
        
        Console.WriteLine("Query defined, not executed yet");
        
        // Modify source after query definition
        numbers.Add(6);
        numbers.Add(7);
        
        // Query executed HERE (includes new items)
        foreach (var item in query)
        {
            Console.WriteLine(item); // 6, 8, 12, 14 (includes 6 and 7)
        }
    }
    
    // Multiple enumeration problem
    public void MultipleEnumerationProblem()
    {
        var numbers = Enumerable.Range(1, 1000);
        
        // Deferred query
        var expensiveQuery = numbers.Where(n => ExpensiveOperation(n));
        
        // PROBLEM: Query executed 3 times
        Console.WriteLine($"Count: {expensiveQuery.Count()}"); // Execution 1
        Console.WriteLine($"First: {expensiveQuery.First()}"); // Execution 2
        
        foreach (var item in expensiveQuery) // Execution 3
        {
            Console.WriteLine(item);
        }
    }
    
    private bool ExpensiveOperation(int n)
    {
        Thread.Sleep(1); // Simulate expensive operation
        return n > 500;
    }
    
    // Solution: Materialize query once
    public void MaterializeQueryOnce()
    {
        var numbers = Enumerable.Range(1, 1000);
        
        // Execute and cache results
        var results = numbers.Where(n => ExpensiveOperation(n)).ToList();
        
        // Multiple uses of cached results (no re-execution)
        Console.WriteLine($"Count: {results.Count}");
        Console.WriteLine($"First: {results.First()}");
        
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }
    
    // Closure variable capture timing
    public void ClosureCaptureIssue()
    {
        var threshold = 5;
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Query captures 'threshold' by reference
        var query = numbers.Where(n => n > threshold);
        
        // Change threshold before execution
        threshold = 8;
        
        // Query uses NEW threshold value (8, not 5)
        foreach (var item in query)
        {
            Console.WriteLine(item); // 9, 10 (threshold was 8 at execution)
        }
    }
    
    // Immediate execution methods
    public void ImmediateExecutionMethods()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        // These execute immediately
        var list = numbers.Where(n => n > 2).ToList(); // Execute now
        var array = numbers.Where(n => n > 2).ToArray(); // Execute now
        var count = numbers.Where(n => n > 2).Count(); // Execute now
        var first = numbers.Where(n => n > 2).First(); // Execute now
        var sum = numbers.Where(n => n > 2).Sum(); // Execute now
        
        // Modifying source doesn't affect results
        numbers.Add(6);
        numbers.Add(7);
        
        Console.WriteLine(list.Count); // Still 3 (not affected by Add)
    }
    
    // Streaming vs buffering operators
    public void StreamingVsBuffering()
    {
        var numbers = Enumerable.Range(1, 1000000);
        
        // Streaming: yields results one at a time
        var streamingQuery = numbers
            .Where(n => n % 2 == 0)  // Streaming
            .Select(n => n * 2)       // Streaming
            .Take(10);                // Streaming
        
        // Memory efficient: processes one item at a time
        foreach (var item in streamingQuery)
        {
            Console.WriteLine(item);
        }
        
        // Buffering: requires entire sequence in memory
        var bufferingQuery = numbers
            .OrderBy(n => n)    // Buffering (must see all items)
            .Take(10);
        
        // Less efficient: must load and sort all items
        foreach (var item in bufferingQuery)
        {
            Console.WriteLine(item);
        }
    }
    
    // Real-world: Database query pitfall
    public async Task DatabaseQueryPitfall()
    {
        // using var context = new MyDbContext();
        
        // Deferred query (not executed)
        // var query = context.Users.Where(u => u.IsActive);
        
        // PITFALL: Multiple database calls
        // var count = await query.CountAsync();        // DB call 1
        // var users = await query.ToListAsync();       // DB call 2
        // var firstUser = await query.FirstAsync();    // DB call 3
        
        // SOLUTION: Materialize once
        // var users = await context.Users.Where(u => u.IsActive).ToListAsync();
        // var count = users.Count;                     // In-memory
        // var firstUser = users.First();               // In-memory
    }
    
    // Real-world: Avoid closure over changing state
    public List<User> GetUsersByStatus(List<User> users, UserStatus initialStatus)
    {
        var currentStatus = initialStatus;
        
        // WRONG: Query captures 'currentStatus'
        var query = users.Where(u => u.Status == currentStatus);
        
        // This changes the captured variable
        if (DateTime.Now.Hour > 12)
            currentStatus = UserStatus.Premium;
        
        // Query uses CHANGED status value
        return query.ToList(); // Unexpected results
    }
    
    // CORRECT: Materialize immediately or use local copy
    public List<User> GetUsersByStatusFixed(List<User> users, UserStatus initialStatus)
    {
        var statusCopy = initialStatus; // Local copy
        
        // Capture immutable local copy
        return users.Where(u => u.Status == statusCopy).ToList();
    }
    
    // Query composition benefits
    public IEnumerable<User> BuildDynamicQuery(List<User> users, string nameFilter, int? ageFilter)
    {
        IEnumerable<User> query = users;
        
        // Build query conditionally (deferred execution enables this)
        if (!string.IsNullOrEmpty(nameFilter))
            query = query.Where(u => u.Name.Contains(nameFilter));
        
        if (ageFilter.HasValue)
            query = query.Where(u => u.Age >= ageFilter.Value);
        
        // Query only executed when enumerated
        return query;
    }
    
    // Performance comparison
    public void PerformanceComparison()
    {
        var numbers = Enumerable.Range(1, 1000000);
        
        // Deferred with multiple enumerations (slow)
        var query = numbers.Where(n => n % 2 == 0).Select(n => n * 2);
        
        var sw = System.Diagnostics.Stopwatch.StartNew();
        var count1 = query.Count();
        var first1 = query.First();
        var list1 = query.ToList();
        sw.Stop();
        Console.WriteLine($"Multiple enumerations: {sw.ElapsedMilliseconds}ms");
        
        // Materialized once (fast)
        sw.Restart();
        var materialized = numbers.Where(n => n % 2 == 0).Select(n => n * 2).ToList();
        var count2 = materialized.Count;
        var first2 = materialized.First();
        var list2 = materialized;
        sw.Stop();
        Console.WriteLine($"Single materialization: {sw.ElapsedMilliseconds}ms");
    }
}

public enum UserStatus { Active, Inactive, Premium }
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public UserStatus Status { get; set; }
}

// Guidelines
public class DeferredExecutionGuidelines
{
    /*
     * WHEN TO MATERIALIZE (ToList/ToArray):
     * - Query will be enumerated multiple times
     * - Results needed for Count, First, Any in combination
     * - Source data might change between enumerations
     * - Working with database queries (avoid N+1)
     * - Need snapshot of data at specific point
     * 
     * WHEN TO KEEP DEFERRED:
     * - Single enumeration only
     * - Building composable query pipelines
     * - Streaming large datasets
     * - Conditional query building
     * - Memory-constrained environments
     * 
     * COMMON PITFALLS:
     * 1. Multiple enumerations causing performance issues
     * 2. Closure capturing changing variables
     * 3. Database queries executing multiple times
     * 4. Assuming query executes at definition time
     * 5. Not understanding streaming vs buffering operators
     * 
     * BEST PRACTICES:
     * 1. Materialize if enumerating more than once
     * 2. Be aware of closure capture timing
     * 3. Use ToList() for in-memory operations after DB query
     * 4. Profile and measure query performance
     * 5. Understand which LINQ operators buffer vs stream
     */
}
```

---

### Question 22: What is the difference between IEnumerable<T> and IQueryable<T>? When should you use each?

**Short Theory:**  
IEnumerable<T> represents an in-memory collection that can be enumerated. LINQ to Objects executes on the client side. IQueryable<T> represents a query against a data source (database, web service) with an expression tree that can be translated to the target query language (SQL, OData). Filtering with IQueryable translates to server-side WHERE clauses; with IEnumerable, all data is loaded then filtered in-memory.

**Why do we use it?**  
IQueryable enables efficient server-side filtering, reducing data transfer and improving performance dramatically. Loading 1 million database rows then filtering in-memory is catastrophic; IQueryable translates the filter to SQL, returning only needed rows. However, IQueryable has limitations—complex expressions may not translate, causing client-side evaluation. Understanding when to use each prevents performance disasters.

**Key Interview Points:**
- IEnumerable: in-memory, LINQ to Objects, executes client-side
- IQueryable: query provider (DB, API), expression trees, server-side execution
- IQueryable to IEnumerable transition forces client-side evaluation (dangerous with large datasets)
- Not all operations translate to SQL; unsupported operations cause exceptions or client evaluation
- Use IQueryable for database queries, IEnumerable for in-memory collections

**Coding Example:**
```csharp
public class EnumerableVsQueryableDemo
{
    // IEnumerable - In-memory collection
    public void IEnumerableExample()
    {
        List<int> numbers = Enumerable.Range(1, 1000).ToList();
        IEnumerable<int> enumerable = numbers;
        
        // LINQ to Objects: executes in-memory
        var result = enumerable
            .Where(n => n > 500)
            .Select(n => n * 2)
            .ToList();
        
        // All filtering done in .NET code, in-memory
    }
    
    // IQueryable - Database query
    public async Task IQueryableExample()
    {
        // using var context = new MyDbContext();
        // IQueryable<User> queryable = context.Users;
        
        // LINQ to Entities: translates to SQL
        // var result = await queryable
        //     .Where(u => u.Age > 25)              // WHERE Age > 25 in SQL
        //     .Select(u => new { u.Name, u.Age })  // SELECT Name, Age in SQL
        //     .ToListAsync();
        
        // Only matching rows returned from database
    }
    
    // Performance difference demonstration
    public async Task PerformanceDifference()
    {
        // Scenario: 1 million users in database
        
        // BAD: IEnumerable (loads ALL data)
        // using var context = new MyDbContext();
        // IEnumerable<User> enumerable = context.Users.AsEnumerable();
        
        // Downloads 1 million rows, then filters in-memory!
        // var result = enumerable.Where(u => u.Age > 25).ToList();
        // SQL: SELECT * FROM Users (ALL rows)
        
        // GOOD: IQueryable (filters at database)
        // IQueryable<User> queryable = context.Users;
        
        // Only downloads matching rows
        // var result = await queryable.Where(u => u.Age > 25).ToListAsync();
        // SQL: SELECT * FROM Users WHERE Age > 25
    }
    
    // Explicit conversion and its impact
    public async Task ConversionImpact()
    {
        // using var context = new MyDbContext();
        
        // Start with IQueryable
        // IQueryable<User> queryable = context.Users
        //     .Where(u => u.IsActive); // SQL WHERE clause
        
        // Convert to IEnumerable (switches to client evaluation)
        // IEnumerable<User> enumerable = queryable.AsEnumerable();
        
        // This filter now executes in-memory!
        // var result = enumerable
        //     .Where(u => u.Age > 25)  // In-memory filter
        //     .ToList();
        
        // SQL: SELECT * FROM Users WHERE IsActive = 1
        // Then filters Age > 25 in .NET code
    }
    
    // Expression tree vs delegate
    public void ExpressionTreeVsDelegate()
    {
        // IEnumerable uses Func<T, bool> (delegate)
        IEnumerable<int> enumerable = new[] { 1, 2, 3, 4, 5 };
        var enumerableResult = enumerable.Where(n => n > 2); // Func<int, bool>
        
        // IQueryable uses Expression<Func<T, bool>> (expression tree)
        IQueryable<int> queryable = enumerable.AsQueryable();
        var queryableResult = queryable.Where(n => n > 2); // Expression<Func<int, bool>>
        
        // Expression tree can be analyzed and translated to SQL
    }
    
    // Operations that don't translate to SQL
    public async Task UnsupportedOperations()
    {
        // using var context = new MyDbContext();
        
        // This works in IEnumerable but might fail in IQueryable
        // var result = await context.Users
        //     .Where(u => ComplexBusinessLogic(u))  // Can't translate to SQL!
        //     .ToListAsync();
        
        // SOLUTION: Filter what you can in SQL, then apply complex logic
        // var users = await context.Users
        //     .Where(u => u.IsActive)  // SQL filter
        //     .ToListAsync();           // Materialize
        
        // var filtered = users
        //     .Where(u => ComplexBusinessLogic(u))  // In-memory filter
        //     .ToList();
    }
    
    private bool ComplexBusinessLogic(User user)
    {
        // Complex C# logic that can't translate to SQL
        return user.Name.Length > 5 && DateTime.Now.Hour > 12;
    }
    
    // Real-world: Proper layering
    public class UserRepository
    {
        // Return IQueryable for composable queries
        public IQueryable<User> GetActiveUsers()
        {
            // using var context = new MyDbContext();
            // return context.Users.Where(u => u.IsActive);
            return Enumerable.Empty<User>().AsQueryable();
        }
        
        // Caller can add filters (still executed at DB)
        public async Task<List<User>> GetActiveUsersByAge(int minAge)
        {
            var query = GetActiveUsers()
                .Where(u => u.Age >= minAge)  // Added to SQL WHERE clause
                .OrderBy(u => u.Name);        // Added to SQL ORDER BY
            
            // return await query.ToListAsync();
            return await Task.FromResult(query.ToList());
        }
    }
    
    // Real-world: Repository pattern with IEnumerable
    public class UserService
    {
        // Return IEnumerable when data already materialized
        public async Task<IEnumerable<User>> GetProcessedUsers()
        {
            // using var context = new MyDbContext();
            
            // Get data from database
            // var users = await context.Users.ToListAsync();
            var users = new List<User>();
            
            // Process in-memory (can't be done in SQL)
            return users.Select(u => new User
            {
                Name = u.Name.ToUpper(),
                Age = u.Age,
                // Complex processing...
            });
        }
    }
    
    // Mixing IQueryable and IEnumerable
    public async Task MixingQueryableEnumerable()
    {
        // using var context = new MyDbContext();
        
        // Start with IQueryable (DB query)
        // var dbQuery = context.Users
        //     .Where(u => u.IsActive)           // SQL
        //     .Where(u => u.Age > 25);          // SQL
        
        // Materialize (execute query)
        // var users = await dbQuery.ToListAsync();
        
        // Continue with IEnumerable (in-memory)
        // var processed = users
        //     .Where(u => ComplexBusinessLogic(u))  // In-memory
        //     .Select(u => new UserDto { Name = u.Name })
        //     .ToList();
    }
    
    // Provider-specific behavior
    public void ProviderBehavior()
    {
        // Different providers have different translation capabilities
        
        // EF Core might translate this
        // var efQuery = context.Users
        //     .Where(u => u.Name.StartsWith("A"));
        // SQL: WHERE Name LIKE 'A%'
        
        // Custom LINQ provider might not support it
        // Depends on provider's expression visitor implementation
    }
    
    // Testing implications
    public class TestingConsiderations
    {
        // Testing IQueryable is harder (requires DB or mock provider)
        public async Task TestWithDatabase()
        {
            // Requires actual database or in-memory provider
            // using var context = new MyDbContext();
            // var result = await context.Users.Where(u => u.Age > 25).ToListAsync();
        }
        
        // Testing IEnumerable is easier
        public void TestWithInMemory()
        {
            var users = new List<User>
            {
                new User { Name = "Alice", Age = 30 },
                new User { Name = "Bob", Age = 20 }
            };
            
            var result = users.Where(u => u.Age > 25).ToList();
            // Easy to test, no database needed
        }
    }
    
    // Performance monitoring
    public async Task MonitorQueryPerformance()
    {
        // using var context = new MyDbContext();
        
        // Enable query logging to see generated SQL
        // context.Database.Log = Console.WriteLine;
        
        // var result = await context.Users
        //     .Where(u => u.Age > 25)
        //     .ToListAsync();
        
        // Check logs for:
        // - Generated SQL
        // - Client evaluation warnings
        // - Query execution time
    }
}

public class UserDto
{
    public string Name { get; set; }
}

// Guidelines
public class EnumerableQueryableGuidelines
{
    /*
     * Use IQUERYABLE<T> when:
     * - Working with database queries (EF Core, Dapper)
     * - Need server-side filtering/sorting/paging
     * - Large datasets where loading all data is impractical
     * - Building composable query APIs
     * - Want to defer query execution to provider
     * 
     * Use IENUMERABLE<T> when:
     * - Working with in-memory collections (List, Array)
     * - Data already materialized
     * - Complex operations that can't translate to SQL
     * - Unit testing with mock data
     * - Processing after database retrieval
     * 
     * TRANSITION POINTS:
     * - ToList(), ToArray(), AsEnumerable() convert IQueryable to IEnumerable
     * - After transition, all operations are in-memory
     * - Plan transition point carefully for performance
     * 
     * COMMON MISTAKES:
     * 1. Using AsEnumerable() too early (loads all data)
     * 2. Not checking for client evaluation warnings
     * 3. Assuming all LINQ operations work with IQueryable
     * 4. Returning IQueryable from APIs (tight coupling to data layer)
     * 5. Not materializing before applying non-translatable logic
     * 
     * BEST PRACTICES:
     * 1. Filter and sort at database level (IQueryable)
     * 2. Materialize with ToList() when switching to complex logic
     * 3. Monitor generated SQL queries
     * 4. Use IEnumerable for repository return types (hide IQueryable)
     * 5. Test query translation in integration tests
     */
}
```

---

### Question 23: Explain delegates, Func, Action, and Predicate. When would you use each?

**Short Theory:**  
Delegates are type-safe function pointers that reference methods with matching signatures. `Func<T>` is a built-in generic delegate that returns a value (last type parameter). `Action<T>` returns void. `Predicate<T>` returns bool and takes one parameter (equivalent to Func<T, bool>). Custom delegates are rarely needed as Func/Action cover most scenarios with up to 16 parameters.

**Why do we use it?**  
Delegates enable callback patterns, event handling, LINQ operations, and strategy patterns without tight coupling. They support functional programming paradigms in C#. Func/Action provide standard signatures eliminating boilerplate delegate declarations. Understanding delegates is fundamental to async programming, events, and LINQ—core C# features used daily in production.

**Key Interview Points:**
- Delegates are reference types that encapsulate methods
- Func returns value, Action returns void, Predicate returns bool
- Multicast delegates can reference multiple methods (invocation list)
- Lambda expressions and anonymous methods are syntactic sugar for delegates
- Closures capture variables from outer scope (can cause memory leaks)

**Coding Example:**
```csharp
public class DelegatesDemo
{
    // Custom delegate declaration (rarely needed)
    public delegate int MathOperation(int a, int b);
    
    // Using custom delegate
    public void CustomDelegateExample()
    {
        MathOperation add = (a, b) => a + b;
        MathOperation multiply = (a, b) => a * b;
        
        Console.WriteLine(add(5, 3));        // 8
        Console.WriteLine(multiply(5, 3));   // 15
        
        // Method reference
        MathOperation subtract = Subtract;
        Console.WriteLine(subtract(5, 3));   // 2
    }
    
    private int Subtract(int a, int b) => a - b;
    
    // Func - returns a value
    public void FuncExample()
    {
        // Func<input1, input2, ..., output>
        Func<int, int, int> add = (a, b) => a + b;
        Func<string, int> getLength = s => s.Length;
        Func<int> getRandom = () => new Random().Next();
        
        Console.WriteLine(add(5, 3));           // 8
        Console.WriteLine(getLength("Hello"));  // 5
        Console.WriteLine(getRandom());         // Random number
    }
    
    // Action - returns void
    public void ActionExample()
    {
        // Action<input1, input2, ...>
        Action<string> print = message => Console.WriteLine(message);
        Action<int, int> printSum = (a, b) => Console.WriteLine(a + b);
        Action doSomething = () => Console.WriteLine("Done");
        
        print("Hello");         // Hello
        printSum(5, 3);         // 8
        doSomething();          // Done
    }
    
    // Predicate - returns bool (single parameter)
    public void PredicateExample()
    {
        // Predicate<T> is equivalent to Func<T, bool>
        Predicate<int> isEven = n => n % 2 == 0;
        Predicate<string> isNullOrEmpty = string.IsNullOrEmpty;
        
        Console.WriteLine(isEven(4));                    // True
        Console.WriteLine(isNullOrEmpty(""));            // True
        
        // Used with List<T>.FindAll, Array.FindAll
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = numbers.FindAll(isEven);
    }
    
    // Multicast delegates
    public void MulticastDelegateExample()
    {
        Action<string> logger = null;
        
        // Add multiple methods to invocation list
        logger += message => Console.WriteLine($"Console: {message}");
        logger += message => File.AppendAllText("log.txt", message + "\n");
        logger += message => Debug.WriteLine($"Debug: {message}");
        
        // Invokes all methods in order
        logger("Important message");
        
        // Remove method
        logger -= message => Console.WriteLine($"Console: {message}");
    }
    
    // Closures - capturing variables
    public void ClosureExample()
    {
        int counter = 0;
        
        Func<int> increment = () =>
        {
            counter++; // Captures 'counter' from outer scope
            return counter;
        };
        
        Console.WriteLine(increment()); // 1
        Console.WriteLine(increment()); // 2
        Console.WriteLine(increment()); // 3
        Console.WriteLine(counter);     // 3 (modified by closure)
    }
    
    // Closure pitfall in loops
    public void ClosurePitfallLoop()
    {
        var actions = new List<Action>();
        
        // WRONG: Closure captures loop variable reference
        for (int i = 0; i < 5; i++)
        {
            actions.Add(() => Console.WriteLine(i));
        }
        
        // All print 5 (value of i after loop)
        foreach (var action in actions)
            action();
        
        // CORRECT: Capture loop variable copy
        actions.Clear();
        for (int i = 0; i < 5; i++)
        {
            int copy = i; // Local copy
            actions.Add(() => Console.WriteLine(copy));
        }
        
        // Prints 0, 1, 2, 3, 4
        foreach (var action in actions)
            action();
    }
    
    // Higher-order functions
    public void HigherOrderFunctions()
    {
        // Function that takes function as parameter
        int result = ApplyOperation(5, 3, (a, b) => a + b);
        Console.WriteLine(result); // 8
        
        // Function that returns function
        Func<int, int> multiplier = CreateMultiplier(10);
        Console.WriteLine(multiplier(5)); // 50
    }
    
    private int ApplyOperation(int a, int b, Func<int, int, int> operation)
    {
        return operation(a, b);
    }
    
    private Func<int, int> CreateMultiplier(int factor)
    {
        return x => x * factor;
    }
    
    // Strategy pattern with delegates
    public class PaymentProcessor
    {
        private readonly Func<decimal, string> _paymentStrategy;
        
        public PaymentProcessor(Func<decimal, string> paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        
        public string ProcessPayment(decimal amount)
        {
            return _paymentStrategy(amount);
        }
    }
    
    public void StrategyPatternExample()
    {
        // Credit card payment
        var creditCardProcessor = new PaymentProcessor(
            amount => $"Charged ${amount} to credit card"
        );
        
        // PayPal payment
        var paypalProcessor = new PaymentProcessor(
            amount => $"Transferred ${amount} via PayPal"
        );
        
        Console.WriteLine(creditCardProcessor.ProcessPayment(100));
        Console.WriteLine(paypalProcessor.ProcessPayment(50));
    }
    
    // Callback pattern
    public async Task CallbackPatternExample()
    {
        await DownloadFileAsync("url", 
            progress => Console.WriteLine($"Progress: {progress}%"),
            () => Console.WriteLine("Download complete"));
    }
    
    private async Task DownloadFileAsync(string url, Action<int> onProgress, Action onComplete)
    {
        for (int i = 0; i <= 100; i += 10)
        {
            await Task.Delay(100);
            onProgress(i);
        }
        onComplete();
    }
    
    // LINQ with delegates
    public void LinqWithDelegates()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Where takes Func<T, bool>
        Func<int, bool> isEven = n => n % 2 == 0;
        var evenNumbers = numbers.Where(isEven);
        
        // Select takes Func<T, TResult>
        Func<int, int> square = n => n * n;
        var squares = numbers.Select(square);
        
        // OrderBy takes Func<T, TKey>
        Func<int, int> keySelector = n => n;
        var ordered = numbers.OrderBy(keySelector);
    }
    
    // Func vs Action usage patterns
    public class DataProcessor
    {
        // Use Func when returning value
        public Func<string, string> Transform { get; set; } = s => s.ToUpper();
        
        // Use Action when performing operation
        public Action<string> Log { get; set; } = Console.WriteLine;
        
        public string Process(string input)
        {
            Log($"Processing: {input}");
            var result = Transform(input);
            Log($"Result: {result}");
            return result;
        }
    }
    
    // Async delegates
    public async Task AsyncDelegatesExample()
    {
        // Func returning Task
        Func<string, Task<int>> asyncOperation = async url =>
        {
            using var client = new HttpClient();
            var response = await client.GetStringAsync(url);
            return response.Length;
        };
        
        var length = await asyncOperation("https://example.com");
        
        // Action returning Task
        Func<string, Task> asyncAction = async message =>
        {
            await Task.Delay(100);
            Console.WriteLine(message);
        };
        
        await asyncAction("Hello");
    }
    
    // Memory leak with closures
    public class MemoryLeakExample
    {
        private List<Action> _callbacks = new List<Action>();
        
        public void RegisterCallback()
        {
            var largeData = new byte[1000000]; // 1MB
            
            // Closure captures largeData
            _callbacks.Add(() =>
            {
                Console.WriteLine(largeData.Length);
            });
            
            // largeData kept alive by closure even after method returns
        }
        
        // Solution: Don't capture large objects, or clear callbacks
        public void RegisterCallbackFixed()
        {
            var largeData = new byte[1000000];
            var dataLength = largeData.Length; // Capture only what's needed
            
            _callbacks.Add(() =>
            {
                Console.WriteLine(dataLength); // Only int captured, not byte array
            });
        }
    }
    
    // Real-world: Validation pipeline
    public class Validator<T>
    {
        private readonly List<Func<T, (bool isValid, string error)>> _rules = new();
        
        public void AddRule(Func<T, (bool, string)> rule)
        {
            _rules.Add(rule);
        }
        
        public (bool isValid, List<string> errors) Validate(T item)
        {
            var errors = new List<string>();
            
            foreach (var rule in _rules)
            {
                var (isValid, error) = rule(item);
                if (!isValid)
                    errors.Add(error);
            }
            
            return (errors.Count == 0, errors);
        }
    }
    
    public void ValidationExample()
    {
        var validator = new Validator<User>();
        
        validator.AddRule(u => 
            (u.Age >= 18, "Must be 18 or older"));
        
        validator.AddRule(u => 
            (!string.IsNullOrEmpty(u.Name), "Name is required"));
        
        var user = new User { Name = "", Age = 16 };
        var (isValid, errors) = validator.Validate(user);
        
        if (!isValid)
            errors.ForEach(Console.WriteLine);
    }
}

// Guidelines
public class DelegateGuidelines
{
    /*
     * Use FUNC<T> when:
     * - Need to return a value
     * - Transformation operations
     * - LINQ projections
     * - Factory methods
     * 
     * Use ACTION<T> when:
     * - Perform operation without return value
     * - Callbacks
     * - Event-like notifications
     * - Side effects
     * 
     * Use PREDICATE<T> when:
     * - List<T>.FindAll, Array.FindAll
     * - Boolean testing (though Func<T, bool> is more common)
     * 
     * Use CUSTOM DELEGATES when:
     * - Need more than 16 parameters (rare)
     * - Want semantic naming (ProcessPaymentDelegate)
     * - Framework/API design requiring specific signatures
     * 
     * CLOSURE CONSIDERATIONS:
     * 1. Be aware of captured variables
     * 2. Avoid capturing large objects
     * 3. Watch for loop variable capture pitfalls
     * 4. Consider memory implications of closures
     * 5. Use WeakReference for long-lived delegates
     * 
     * BEST PRACTICES:
     * 1. Prefer Func/Action over custom delegates
     * 2. Use lambda expressions for brevity
     * 3. Name delegates meaningfully when assigned to variables
     * 4. Be cautious with multicast delegates and exceptions
     * 5. Document delegate parameters and expected behavior
     */
}
```

---

### Question 24: What are events in C#? How do they differ from delegates?

**Short Theory:**  
Events are a specialized use of delegates that implement the publish-subscribe pattern. An event is a delegate wrapped with access restrictions—only the declaring class can invoke it, while external classes can only subscribe/unsubscribe. Events use the `event` keyword and conventionally follow the EventHandler pattern with sender and EventArgs. This encapsulation prevents external code from clearing subscribers or directly invoking the event.

**Why do we use it?**  
Events provide a safe, decoupled notification mechanism essential for UI frameworks, plugin architectures, and reactive systems. The access restrictions prevent subscribers from interfering with each other (clearing the invocation list) or incorrectly triggering events. Events enable loose coupling—publishers don't need references to subscribers, and subscribers don't control event lifecycle. This is fundamental to extensible, maintainable systems.

**Key Interview Points:**
- Events are delegates with access restrictions (subscribe/unsubscribe only)
- Only declaring class can raise (invoke) event
- EventHandler<TEventArgs> is standard pattern: sender and args
- Memory leak risk: subscribers keep publishers alive if not unsubscribed
- Weak events (WeakEventManager) solve memory leak issues

**Coding Example:**
```csharp
public class EventsDemo
{
    // Standard event pattern
    public class Button
    {
        // Event declaration using EventHandler
        public event EventHandler<ClickEventArgs> Clicked;
        
        // Protected virtual method to raise event
        protected virtual void OnClicked(ClickEventArgs e)
        {
            // Null-conditional operator for thread safety
            Clicked?.Invoke(this, e);
        }
        
        public void Click()
        {
            Console.WriteLine("Button clicked");
            OnClicked(new ClickEventArgs { ClickTime = DateTime.Now });
        }
    }
    
    public class ClickEventArgs : EventArgs
    {
        public DateTime ClickTime { get; set; }
    }
    
    // Subscribing to events
    public void EventSubscriptionExample()
    {
        var button = new Button();
        
        // Subscribe with method
        button.Clicked += Button_Clicked;
        
        // Subscribe with lambda
        button.Clicked += (sender, args) =>
        {
            Console.WriteLine($"Lambda: Clicked at {args.ClickTime}");
        };
        
        button.Click();
        
        // Unsubscribe
        button.Clicked -= Button_Clicked;
    }
    
    private void Button_Clicked(object sender, ClickEventArgs e)
    {
        Console.WriteLine($"Event handler: Clicked at {e.ClickTime}");
    }
    
    // Event vs Delegate comparison
    public class EventVsDelegate
    {
        // Delegate field (problematic)
        public Action<string> MessageReceivedDelegate;
        
        // Event (safe)
        public event Action<string> MessageReceivedEvent;
        
        public void SendMessage(string message)
        {
            MessageReceivedDelegate?.Invoke(message);
            MessageReceivedEvent?.Invoke(message);
        }
    }
    
    public void EventVsDelegateDemo()
    {
        var obj = new EventVsDelegate();
        
        // Delegate: External code can do anything
        obj.MessageReceivedDelegate = msg => Console.WriteLine($"A: {msg}");
        obj.MessageReceivedDelegate += msg => Console.WriteLine($"B: {msg}");
        obj.MessageReceivedDelegate = null; // Clear all subscribers!
        obj.MessageReceivedDelegate?.Invoke("External invoke"); // Can invoke directly
        
        // Event: Restricted access
        obj.MessageReceivedEvent += msg => Console.WriteLine($"A: {msg}");
        obj.MessageReceivedEvent += msg => Console.WriteLine($"B: {msg}");
        // obj.MessageReceivedEvent = null; // ERROR: Can't assign
        // obj.MessageReceivedEvent?.Invoke("test"); // ERROR: Can't invoke
    }
    
    // Custom event accessor
    public class CustomEventAccessor
    {
        private EventHandler<EventArgs> _customEvent;
        private readonly object _eventLock = new object();
        
        public event EventHandler<EventArgs> CustomEvent
        {
            add
            {
                lock (_eventLock)
                {
                    Console.WriteLine("Subscriber added");
                    _customEvent += value;
                }
            }
            remove
            {
                lock (_eventLock)
                {
                    Console.WriteLine("Subscriber removed");
                    _customEvent -= value;
                }
            }
        }
        
        public void RaiseEvent()
        {
            _customEvent?.Invoke(this, EventArgs.Empty);
        }
    }
    
    // Memory leak with events
    public class Publisher
    {
        public event EventHandler DataChanged;
        
        public void ChangeData()
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }
    }
    
    public class Subscriber
    {
        private readonly Publisher _publisher;
        
        public Subscriber(Publisher publisher)
        {
            _publisher = publisher;
            _publisher.DataChanged += OnDataChanged;
            // If Subscriber not disposed, Publisher keeps it alive!
        }
        
        private void OnDataChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Data changed");
        }
        
        // Must unsubscribe to prevent leak
        public void Dispose()
        {
            _publisher.DataChanged -= OnDataChanged;
        }
    }
    
    // Weak event pattern (prevents memory leaks)
    public class WeakEventManager<TEventArgs> where TEventArgs : EventArgs
    {
        private readonly List<WeakReference<EventHandler<TEventArgs>>> _handlers = new();
        
        public void AddHandler(EventHandler<TEventArgs> handler)
        {
            _handlers.Add(new WeakReference<EventHandler<TEventArgs>>(handler));
        }
        
        public void RemoveHandler(EventHandler<TEventArgs> handler)
        {
            _handlers.RemoveAll(wr =>
            {
                if (wr.TryGetTarget(out var target))
                    return target == handler;
                return true; // Remove dead references
            });
        }
        
        public void Raise(object sender, TEventArgs args)
        {
            var deadReferences = new List<WeakReference<EventHandler<TEventArgs>>>();
            
            foreach (var weakHandler in _handlers)
            {
                if (weakHandler.TryGetTarget(out var handler))
                {
                    handler(sender, args);
                }
                else
                {
                    deadReferences.Add(weakHandler);
                }
            }
            
            // Clean up dead references
            foreach (var dead in deadReferences)
                _handlers.Remove(dead);
        }
    }
    
    // Async event handlers
    public class AsyncEventExample
    {
        public event Func<object, EventArgs, Task> AsyncEvent;
        
        protected virtual async Task OnAsyncEvent(EventArgs e)
        {
            var handlers = AsyncEvent;
            if (handlers != null)
            {
                // Invoke all handlers and wait for completion
                var tasks = handlers.GetInvocationList()
                    .Cast<Func<object, EventArgs, Task>>()
                    .Select(handler => handler(this, e));
                
                await Task.WhenAll(tasks);
            }
        }
        
        public async Task TriggerAsync()
        {
            await OnAsyncEvent(EventArgs.Empty);
        }
    }
    
    public async Task AsyncEventUsage()
    {
        var publisher = new AsyncEventExample();
        
        publisher.AsyncEvent += async (sender, args) =>
        {
            await Task.Delay(100);
            Console.WriteLine("Handler 1");
        };
        
        publisher.AsyncEvent += async (sender, args) =>
        {
            await Task.Delay(200);
            Console.WriteLine("Handler 2");
        };
        
        await publisher.TriggerAsync();
    }
    
    // Event aggregator pattern
    public interface IEventAggregator
    {
        void Subscribe<TEvent>(Action<TEvent> handler);
        void Publish<TEvent>(TEvent eventData);
    }
    
    public class EventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<Delegate>> _subscribers = new();
        private readonly object _lock = new object();
        
        public void Subscribe<TEvent>(Action<TEvent> handler)
        {
            lock (_lock)
            {
                var eventType = typeof(TEvent);
                if (!_subscribers.ContainsKey(eventType))
                    _subscribers[eventType] = new List<Delegate>();
                
                _subscribers[eventType].Add(handler);
            }
        }
        
        public void Publish<TEvent>(TEvent eventData)
        {
            List<Delegate> handlers;
            lock (_lock)
            {
                var eventType = typeof(TEvent);
                if (!_subscribers.TryGetValue(eventType, out var list))
                    return;
                
                handlers = list.ToList(); // Copy to avoid modification during iteration
            }
            
            foreach (Action<TEvent> handler in handlers)
            {
                handler(eventData);
            }
        }
    }
    
    public class UserLoggedInEvent
    {
        public string Username { get; set; }
        public DateTime LoginTime { get; set; }
    }
    
    public void EventAggregatorExample()
    {
        var eventAggregator = new EventAggregator();
        
        // Component 1 subscribes
        eventAggregator.Subscribe<UserLoggedInEvent>(e =>
        {
            Console.WriteLine($"Logger: {e.Username} logged in");
        });
        
        // Component 2 subscribes
        eventAggregator.Subscribe<UserLoggedInEvent>(e =>
        {
            Console.WriteLine($"Analytics: Track login for {e.Username}");
        });
        
        // Publisher
        eventAggregator.Publish(new UserLoggedInEvent
        {
            Username = "john.doe",
            LoginTime = DateTime.Now
        });
    }
    
    // Observable pattern (Reactive Extensions style)
    public class Observable<T>
    {
        private readonly List<IObserver<T>> _observers = new();
        
        public IDisposable Subscribe(IObserver<T> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }
        
        public void Publish(T value)
        {
            foreach (var observer in _observers.ToList())
            {
                observer.OnNext(value);
            }
        }
        
        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<T>> _observers;
            private readonly IObserver<T> _observer;
            
            public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            
            public void Dispose()
            {
                _observers.Remove(_observer);
            }
        }
    }
    
    // Real-world: Domain events
    public abstract class DomainEvent
    {
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
    }
    
    public class OrderPlacedEvent : DomainEvent
    {
        public string OrderId { get; set; }
        public decimal TotalAmount { get; set; }
    }
    
    public class OrderEventHandlers
    {
        public void OnOrderPlaced(OrderPlacedEvent e)
        {
            Console.WriteLine($"Order {e.OrderId} placed for ${e.TotalAmount}");
            // Send confirmation email
            // Update inventory
            // Notify warehouse
        }
    }
    
    // Exception handling in events
    public class SafeEventInvoker
    {
        public event EventHandler<EventArgs> SafeEvent;
        
        protected virtual void OnSafeEvent()
        {
            var handlers = SafeEvent;
            if (handlers == null) return;
            
            foreach (EventHandler<EventArgs> handler in handlers.GetInvocationList())
            {
                try
                {
                    handler(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    // Log exception but continue with other handlers
                    Console.WriteLine($"Handler exception: {ex.Message}");
                }
            }
        }
    }
}

// Guidelines
public class EventGuidelines
{
    /*
     * Use EVENTS when:
     * - Implementing publish-subscribe pattern
     * - Multiple subscribers need notification
     * - Loose coupling required
     * - UI interactions, lifecycle notifications
     * 
     * Use DELEGATES when:
     * - Single callback needed
     * - Strategy pattern implementation
     * - LINQ-style operations
     * - Return value needed from callback
     * 
     * EVENT NAMING:
     * - Use PascalCase
     * - Past tense: ButtonClicked, DataReceived
     * - Or Present tense: ButtonClick, DataReceive
     * 
     * MEMORY LEAKS:
     * - Always unsubscribe in Dispose()
     * - Use weak events for long-lived publishers
     * - Be careful with lambda subscriptions (hard to unsubscribe)
     * - Static events are particularly dangerous
     * 
     * BEST PRACTICES:
     * 1. Use EventHandler<TEventArgs> pattern
     * 2. Make event raising method protected virtual (OnEventName)
     * 3. Use null-conditional operator (?.Invoke)
     * 4. Handle exceptions in event handlers
     * 5. Document thread safety requirements
     * 6. Consider async event handlers carefully
     * 7. Use event aggregator for complex pub-sub scenarios
     * 
     * THREAD SAFETY:
     * - Events are not thread-safe by default
     * - Use Interlocked for add/remove operations
     * - Copy delegate reference before invoking
     * - Consider SynchronizationContext for UI events
     */
}
```

---

### Question 25: Explain exception handling best practices. When should you catch, rethrow, or let exceptions bubble up?

**Short Theory:**  
Exceptions represent unexpected errors disrupting normal program flow. Proper handling involves: catch only when you can handle meaningfully, use specific exception types, preserve stack traces with `throw;` (not `throw ex;`), clean up resources in `finally` or `using`, and avoid exceptions for control flow. Exception filters (`when`) enable conditional catching. Async methods require special handling to prevent swallowed exceptions.

**Why do we use it?**  
Proper exception handling prevents silent failures, provides clear error diagnostics, and ensures resource cleanup. Catching too broadly masks bugs; catching too specifically clutters code. Understanding when to catch vs. propagate is crucial for maintainable systems. Performance matters—exceptions are expensive (stack trace capture), so avoid them in normal flow paths. Logging at the right layer enables debugging without cluttering every method.

**Key Interview Points:**
- Use specific exceptions, avoid catching `Exception` unless absolutely necessary
- `throw;` preserves stack trace, `throw ex;` resets it
- Exceptions are expensive—don't use for control flow
- Exception filters (`when`) avoid catch-and-rethrow pattern
- Async exceptions require `await` to bubble up properly

**Coding Example:**
```csharp
public class ExceptionHandlingDemo
{
    // WRONG: Catching all exceptions
    public void CatchAllBad()
    {
        try
        {
            DoSomething();
        }
        catch (Exception ex) // TOO BROAD
        {
            Console.WriteLine(ex.Message);
            // Swallows critical exceptions like OutOfMemoryException
        }
    }
    
    // CORRECT: Catch specific exceptions
    public void CatchSpecificGood()
    {
        try
        {
            DoSomething();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Null argument provided");
            // Handle specifically
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation");
            // Handle specifically
        }
        // Let other exceptions bubble up
    }
    
    // WRONG: Resetting stack trace
    public void RethrowWrong()
    {
        try
        {
            DoSomething();
        }
        catch (Exception ex)
        {
            Log(ex);
            throw ex; // WRONG: Resets stack trace
        }
    }
    
    // CORRECT: Preserving stack trace
    public void RethrowCorrect()
    {
        try
        {
            DoSomething();
        }
        catch (Exception ex)
        {
            Log(ex);
            throw; // CORRECT: Preserves stack trace
        }
    }
    
    // Exception filters (C# 6+)
    public async Task<string> ExceptionFilters(string url)
    {
        try
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url);
        }
        catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            // Handle 404 specifically
            return "Resource not found";
        }
        catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            // Handle 401 specifically
            throw new UnauthorizedAccessException("Authentication required", ex);
        }
        // Other HttpRequestException instances bubble up
    }
    
    // Resource cleanup with using
    public void ResourceCleanup()
    {
        // Automatic disposal even if exception occurs
        using (var stream = new FileStream("file.txt", FileMode.Open))
        {
            // Use stream
            throw new Exception("Oops");
        } // stream.Dispose() called automatically
    }
    
    // Try-finally for cleanup
    public void TryFinallyCleanup()
    {
        FileStream stream = null;
        try
        {
            stream = new FileStream("file.txt", FileMode.Open);
            // Use stream
        }
        catch (IOException ex)
        {
            Log(ex);
            throw;
        }
        finally
        {
            // Always executed, even if exception thrown
            stream?.Dispose();
        }
    }
    
    // Custom exceptions
    public class BusinessRuleViolationException : Exception
    {
        public string RuleName { get; }
        
        public BusinessRuleViolationException(string ruleName, string message)
            : base(message)
        {
            RuleName = ruleName;
        }
        
        public BusinessRuleViolationException(string ruleName, string message, Exception innerException)
            : base(message, innerException)
        {
            RuleName = ruleName;
        }
    }
    
    // When to throw custom exceptions
    public void ProcessOrder(Order order)
    {
        if (order == null)
            throw new ArgumentNullException(nameof(order));
        
        if (order.Amount < 0)
            throw new ArgumentException("Amount cannot be negative", nameof(order));
        
        if (order.Amount > 10000)
            throw new BusinessRuleViolationException(
                "MaxOrderAmount",
                "Order amount exceeds maximum allowed"
            );
    }
    
    // Async exception handling
    public async Task AsyncExceptionHandling()
    {
        try
        {
            // WRONG: Fire and forget (exception swallowed)
            _ = Task.Run(() => throw new Exception("Lost"));
            
            // CORRECT: Await to catch exceptions
            await Task.Run(() => throw new Exception("Caught"));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
    }
    
    // Multiple async operations
    public async Task MultipleAsyncOperations()
    {
        try
        {
            var task1 = FetchDataAsync("url1");
            var task2 = FetchDataAsync("url2");
            var task3 = FetchDataAsync("url3");
            
            // WhenAll aggregates exceptions
            await Task.WhenAll(task1, task2, task3);
        }
        catch (Exception ex)
        {
            // Only first exception caught
            // Use AggregateException to get all
        }
        
        // Better: Handle AggregateException
        try
        {
            var task1 = FetchDataAsync("url1");
            var task2 = FetchDataAsync("url2");
            var task3 = FetchDataAsync("url3");
            
            await Task.WhenAll(task1, task2, task3);
        }
        catch (AggregateException ae)
        {
            foreach (var ex in ae.InnerExceptions)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    
    private async Task<string> FetchDataAsync(string url)
    {
        await Task.Delay(100);
        throw new Exception($"Failed to fetch {url}");
    }
    
    // Exception for control flow (AVOID)
    public int ParseNumberBad(string input)
    {
        try
        {
            return int.Parse(input); // Throws if invalid
        }
        catch (FormatException)
        {
            return 0; // Using exception for control flow
        }
    }
    
    // Correct: Use TryParse pattern
    public int ParseNumberGood(string input)
    {
        return int.TryParse(input, out int result) ? result : 0;
    }
    
    // Layered exception handling
    public class DataAccessLayer
    {
        public User GetUser(int id)
        {
            try
            {
                // Database access
                throw new SqlException("Connection failed");
            }
            catch (SqlException ex)
            {
                // Wrap in domain exception
                throw new DataAccessException($"Failed to retrieve user {id}", ex);
            }
        }
    }
    
    public class BusinessLogicLayer
    {
        private readonly DataAccessLayer _dal = new();
        
        public User GetUserProfile(int id)
        {
            try
            {
                return _dal.GetUser(id);
            }
            catch (DataAccessException ex)
            {
                // Log at business layer
                Log(ex);
                throw; // Propagate to caller
            }
        }
    }
    
    public class PresentationLayer
    {
        private readonly BusinessLogicLayer _bll = new();
        
        public string DisplayUserProfile(int id)
        {
            try
            {
                var user = _bll.GetUserProfile(id);
                return $"User: {user.Name}";
            }
            catch (DataAccessException ex)
            {
                // Handle at presentation layer
                return "Unable to load user profile. Please try again.";
            }
            catch (Exception ex)
            {
                // Unexpected exception
                Log(ex);
                return "An unexpected error occurred.";
            }
        }
    }
    
    // Global exception handler (ASP.NET Core)
    public class GlobalExceptionHandler
    {
        public async Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.StatusCode = ex switch
            {
                ArgumentException => 400,
                UnauthorizedAccessException => 401,
                KeyNotFoundException => 404,
                BusinessRuleViolationException => 422,
                _ => 500
            };
            
            var response = new
            {
                error = ex.Message,
                type = ex.GetType().Name
            };
            
            await context.Response.WriteAsJsonAsync(response);
        }
    }
    
    // Exception handling with transactions
    public async Task TransactionExceptionHandling()
    {
        // using var transaction = await _context.Database.BeginTransactionAsync();
        
        try
        {
            // Operation 1
            // await _context.SaveChangesAsync();
            
            // Operation 2 (might fail)
            // await ExternalApiCall();
            
            // Operation 3
            // await _context.SaveChangesAsync();
            
            // await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            // await transaction.RollbackAsync();
            Log(ex);
            throw; // Rethrow after rollback
        }
    }
    
    // Retry logic with exceptions
    public async Task<T> RetryOnException<T>(Func<Task<T>> operation, int maxRetries = 3)
    {
        int attempt = 0;
        while (true)
        {
            try
            {
                return await operation();
            }
            catch (Exception ex) when (attempt < maxRetries)
            {
                attempt++;
                Console.WriteLine($"Attempt {attempt} failed: {ex.Message}");
                await Task.Delay(TimeSpan.FromSeconds(Math.Pow(2, attempt))); // Exponential backoff
            }
        }
    }
    
    // Usage
    public async Task<string> FetchWithRetry()
    {
        return await RetryOnException(async () =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.example.com");
        });
    }
    
    private void DoSomething() { }
    private void Log(Exception ex) { }
}

public class Order
{
    public decimal Amount { get; set; }
}

public class SqlException : Exception
{
    public SqlException(string message) : base(message) { }
}

public class DataAccessException : Exception
{
    public DataAccessException(string message, Exception innerException)
        : base(message, innerException) { }
}

public class HttpContext
{
    public HttpResponse Response { get; set; }
}

public class HttpResponse
{
    public int StatusCode { get; set; }
    public Task WriteAsJsonAsync(object obj) => Task.CompletedTask;
}

// Guidelines
public class ExceptionHandlingGuidelines
{
    /*
     * WHEN TO CATCH:
     * - You can handle the exception meaningfully
     * - You need to clean up resources
     * - You want to wrap in more specific exception
     * - You're at application boundary (API, UI)
     * 
     * WHEN TO LET BUBBLE:
     * - You can't handle it meaningfully
     * - It's a programming error (ArgumentNullException)
     * - Higher layer has better context
     * 
     * RETHROWING:
     * - Use `throw;` to preserve stack trace
     * - Use `throw ex;` NEVER (resets stack trace)
     * - Wrap in new exception with InnerException for context
     * 
     * EXCEPTION FILTERS:
     * - Use `when` clause for conditional catching
     * - Avoids catch-and-rethrow pattern
     * - Can include logging without catching
     * 
     * CUSTOM EXCEPTIONS:
     * - Inherit from Exception
     * - Provide multiple constructors
     * - Include InnerException parameter
     * - Add domain-specific properties
     * - Use for business rule violations
     * 
     * ASYNC EXCEPTIONS:
     * - Always await tasks to propagate exceptions
     * - Handle AggregateException for Task.WhenAll
     * - Use Task.WhenAny for timeout scenarios
     * 
     * PERFORMANCE:
     * - Exceptions are expensive (~1000x slower than if-check)
     * - Use TryParse pattern instead of catching
     * - Don't use exceptions for control flow
     * - Cache exception creation in hot paths
     * 
     * LOGGING:
     * - Log at appropriate layer (usually boundary)
     * - Include context (user, request ID, timestamp)
     * - Log full exception including stack trace
     * - Use structured logging
     * 
     * AVOID:
     * 1. Empty catch blocks
     * 2. Catching System.Exception without rethrowing
     * 3. Throwing System.Exception (use specific types)
     * 4. Using exceptions for control flow
     * 5. Swallowing exceptions in async void methods
     */
}
```

---

**Batch 3 completed (Questions 21-25). Continue with next batch.**

---

## Batch 4: Object-Oriented Design & SOLID Principles (Questions 26-30)

### Question 26: Explain the difference between abstract classes and interfaces. When would you use each?

**Short Theory:**  
Abstract classes can contain implementation (concrete methods), state (fields), constructors, and access modifiers. Interfaces (pre-C# 8) only define contracts with no implementation. C# 8+ allows default interface methods. A class can inherit one abstract class but implement multiple interfaces. Abstract classes represent "is-a" relationships; interfaces represent "can-do" capabilities. Abstract classes support protected members; interfaces are implicitly public.

**Why do we use it?**  
Interfaces enable multiple inheritance of type, crucial for composition over inheritance. They define contracts without dictating implementation, enabling loose coupling and testability (dependency injection, mocking). Abstract classes provide common functionality and enforce template methods, reducing duplication. The choice impacts extensibility, testability, and API design. Understanding this is fundamental to SOLID principles and clean architecture.

**Key Interview Points:**
- Use interface for capabilities/contracts (IDisposable, IComparable, IRepository)
- Use abstract class for shared implementation and template methods
- Interfaces enable multiple inheritance; abstract classes provide single inheritance
- C# 8+ default interface methods blur the line but shouldn't be overused
- Consider versioning: adding members breaks interfaces but not abstract classes

**Coding Example:**
```csharp
// Interface - contract/capability
public interface IPaymentProcessor
{
    Task<PaymentResult> ProcessPaymentAsync(decimal amount, string currency);
    Task<bool> RefundAsync(string transactionId);
    bool SupportsRecurring { get; }
}

// Multiple interfaces - composition
public interface ILoggable
{
    void Log(string message);
}

public interface IValidatable
{
    bool Validate();
}

// Concrete implementation with multiple interfaces
public class CreditCardProcessor : IPaymentProcessor, ILoggable, IValidatable
{
    public bool SupportsRecurring => true;
    
    public async Task<PaymentResult> ProcessPaymentAsync(decimal amount, string currency)
    {
        Log($"Processing ${amount} {currency}");
        if (!Validate()) return PaymentResult.Failed;
        
        await Task.Delay(100); // Simulate API call
        return PaymentResult.Success;
    }
    
    public async Task<bool> RefundAsync(string transactionId)
    {
        await Task.Delay(100);
        return true;
    }
    
    public void Log(string message) => Console.WriteLine($"[CreditCard] {message}");
    
    public bool Validate() => true; // Validate card details
}

// Abstract class - shared implementation and template method
public abstract class PaymentProcessorBase
{
    protected readonly ILogger _logger;
    protected readonly IConfiguration _config;
    
    protected PaymentProcessorBase(ILogger logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }
    
    // Template method pattern
    public async Task<PaymentResult> ProcessPaymentAsync(decimal amount, string currency)
    {
        _logger.Log("Payment started");
        
        // Common validation
        if (amount <= 0)
        {
            _logger.Log("Invalid amount");
            return PaymentResult.Failed;
        }
        
        // Hook for subclass-specific logic
        var result = await ProcessPaymentInternalAsync(amount, currency);
        
        // Common post-processing
        await SaveTransactionAsync(result);
        _logger.Log("Payment completed");
        
        return result;
    }
    
    // Abstract method - must be implemented by subclasses
    protected abstract Task<PaymentResult> ProcessPaymentInternalAsync(decimal amount, string currency);
    
    // Virtual method - can be overridden
    protected virtual async Task SaveTransactionAsync(PaymentResult result)
    {
        // Default implementation
        await Task.Delay(10);
    }
    
    // Concrete method - shared by all subclasses
    protected string FormatAmount(decimal amount, string currency)
    {
        return $"{amount:F2} {currency}";
    }
}

// Concrete implementation of abstract class
public class StripePaymentProcessor : PaymentProcessorBase
{
    public StripePaymentProcessor(ILogger logger, IConfiguration config)
        : base(logger, config)
    {
    }
    
    protected override async Task<PaymentResult> ProcessPaymentInternalAsync(decimal amount, string currency)
    {
        // Stripe-specific implementation
        _logger.Log($"Calling Stripe API for {FormatAmount(amount, currency)}");
        await Task.Delay(100);
        return PaymentResult.Success;
    }
    
    // Override virtual method if needed
    protected override async Task SaveTransactionAsync(PaymentResult result)
    {
        // Custom transaction saving
        await base.SaveTransactionAsync(result);
        _logger.Log("Transaction saved to Stripe database");
    }
}

// C# 8+ Default Interface Implementation
public interface INotificationService
{
    Task SendAsync(string message);
    
    // Default implementation (C# 8+)
    Task SendBatchAsync(IEnumerable<string> messages)
    {
        // Default behavior
        var tasks = messages.Select(m => SendAsync(m));
        return Task.WhenAll(tasks);
    }
    
    // Default property
    int MaxRetries => 3;
}

public class EmailNotificationService : INotificationService
{
    public async Task SendAsync(string message)
    {
        await Task.Delay(50);
        Console.WriteLine($"Email sent: {message}");
    }
    
    // Can optionally override default implementation
    // public async Task SendBatchAsync(IEnumerable<string> messages) { }
}

// When to use which - Real-world scenarios
public class RealWorldExamples
{
    // INTERFACE: Repository pattern (contract for data access)
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
    
    // ABSTRACT CLASS: Base repository with common implementation
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        
        protected RepositoryBase(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        
        // Common implementation
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        
        public virtual async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        
        public virtual async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
        
        public virtual async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
    
    // Concrete repository with specific behavior
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(DbContext context) : base(context) { }
        
        // Override for custom behavior
        public override async Task<IEnumerable<User>> GetAllAsync()
        {
            // Custom query with includes
            return await _dbSet
                .Where(u => u.IsActive)
                .OrderBy(u => u.Name)
                .ToListAsync();
        }
        
        // Additional specific methods
        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}

// Multiple inheritance with interfaces
public interface IReadable
{
    string Read();
}

public interface IWriteable
{
    void Write(string content);
}

public interface ISeekable
{
    void Seek(long position);
}

// File implements all capabilities
public class FileStream : IReadable, IWriteable, ISeekable
{
    public string Read() => "File content";
    public void Write(string content) => Console.WriteLine($"Writing: {content}");
    public void Seek(long position) => Console.WriteLine($"Seeking to: {position}");
}

// Network stream only readable/writeable (not seekable)
public class NetworkStream : IReadable, IWriteable
{
    public string Read() => "Network data";
    public void Write(string content) => Console.WriteLine($"Sending: {content}");
}

// Interface segregation principle
public interface IUserReader
{
    Task<User> GetUserAsync(int id);
}

public interface IUserWriter
{
    Task SaveUserAsync(User user);
}

// Read-only service
public class UserQueryService : IUserReader
{
    public async Task<User> GetUserAsync(int id)
    {
        await Task.Delay(10);
        return new User();
    }
}

// Full CRUD service
public class UserService : IUserReader, IUserWriter
{
    public async Task<User> GetUserAsync(int id)
    {
        await Task.Delay(10);
        return new User();
    }
    
    public async Task SaveUserAsync(User user)
    {
        await Task.Delay(10);
    }
}

// Abstract class with protected state
public abstract class Vehicle
{
    protected string _vin;
    protected int _mileage;
    
    protected Vehicle(string vin)
    {
        _vin = vin;
    }
    
    public abstract void Start();
    
    protected void IncrementMileage(int miles)
    {
        _mileage += miles;
    }
}

public class Car : Vehicle
{
    public Car(string vin) : base(vin) { }
    
    public override void Start()
    {
        Console.WriteLine("Car started");
    }
    
    public void Drive(int miles)
    {
        IncrementMileage(miles); // Access protected method
    }
}

// Versioning consideration
public interface IUserServiceV1
{
    Task<User> GetUserAsync(int id);
}

// Breaking change - new interface version
public interface IUserServiceV2 : IUserServiceV1
{
    Task<User> GetUserByEmailAsync(string email);
}

// Non-breaking with default implementation (C# 8+)
public interface IUserServiceV3 : IUserServiceV2
{
    Task<List<User>> SearchUsersAsync(string query)
    {
        // Default implementation - doesn't break existing implementations
        return Task.FromResult(new List<User>());
    }
}

// Testing benefits
public class PaymentServiceTests
{
    // Easy to mock interfaces
    public async Task TestPaymentProcessing()
    {
        // Mock interface
        var mockProcessor = new Mock<IPaymentProcessor>();
        mockProcessor
            .Setup(p => p.ProcessPaymentAsync(It.IsAny<decimal>(), It.IsAny<string>()))
            .ReturnsAsync(PaymentResult.Success);
        
        var service = new PaymentService(mockProcessor.Object);
        var result = await service.ProcessOrderAsync(100m);
        
        // Assert result
    }
}

public class PaymentService
{
    private readonly IPaymentProcessor _processor;
    
    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }
    
    public async Task<bool> ProcessOrderAsync(decimal amount)
    {
        var result = await _processor.ProcessPaymentAsync(amount, "USD");
        return result == PaymentResult.Success;
    }
}

// Supporting types
public enum PaymentResult { Success, Failed, Pending }
public interface ILogger { void Log(string message); }
public interface IConfiguration { string GetValue(string key); }
public class DbContext { public DbSet<T> Set<T>() where T : class => null; }
public class DbSet<T> where T : class
{
    public Task<T> FindAsync(int id) => Task.FromResult<T>(null);
    public Task<List<T>> ToListAsync() => Task.FromResult(new List<T>());
    public Task AddAsync(T entity) => Task.CompletedTask;
    public void Update(T entity) { }
    public void Remove(T entity) { }
}

public class Mock<T> where T : class
{
    public Mock<T> Setup(System.Linq.Expressions.Expression<Func<T, object>> expression) => this;
    public void ReturnsAsync(object value) { }
    public T Object => default;
}

public static class It
{
    public static T IsAny<T>() => default;
}

// Guidelines
public class InterfaceVsAbstractClassGuidelines
{
    /*
     * Use INTERFACE when:
     * - Defining contracts/capabilities (IDisposable, IComparable)
     * - Need multiple inheritance
     * - Unrelated classes should implement same behavior
     * - Designing for testability (dependency injection)
     * - Plugin architecture
     * - No shared implementation needed
     * 
     * Use ABSTRACT CLASS when:
     * - Sharing code among related classes
     * - Need protected members or instance fields
     * - Template method pattern
     * - Providing default behavior with option to override
     * - Versioning concerns (can add members without breaking)
     * - Need constructors to initialize state
     * 
     * C# 8+ DEFAULT INTERFACE METHODS:
     * - Use sparingly for versioning
     * - Don't replicate abstract class functionality
     * - Keep defaults simple
     * - Consider explicit implementation
     * 
     * DESIGN CONSIDERATIONS:
     * 1. Favor composition over inheritance
     * 2. Interfaces for "can-do", abstract for "is-a"
     * 3. Keep interfaces small (Interface Segregation)
     * 4. Abstract classes for frameworks, interfaces for libraries
     * 5. Consider versioning strategy upfront
     * 
     * COMMON PATTERNS:
     * - Interface for contract, abstract base for common implementation
     * - Multiple interfaces for capabilities
     * - Abstract class as template method holder
     * - Interface for dependency injection points
     */
}
```

---

### Question 27: Explain the Single Responsibility Principle (SRP). How do you identify violations?

**Short Theory:**  
SRP states that a class should have only one reason to change, meaning it should have a single, well-defined responsibility. A class handles one actor's concerns. Violations manifest as classes with multiple unrelated methods, frequent changes for different reasons, or names like "Manager," "Helper," or "Utility." SRP prevents ripple effects where changes in one feature break another because they're coupled in the same class.

**Why do we use it?**  
SRP reduces coupling, making code easier to test, maintain, and understand. Classes with single responsibilities are easier to name, reason about, and modify without side effects. Violations lead to fragile code where changing invoice calculation breaks email sending because both are in InvoiceManager. SRP is foundational—violating it makes other SOLID principles harder to follow and creates tightly coupled systems.

**Key Interview Points:**
- One reason to change = one responsibility
- Avoid "God classes" and classes with unrelated methods
- Class names reveal violations: Manager, Helper, Util suggest multiple responsibilities
- Each class serves one actor/stakeholder
- Easier testing—mock fewer dependencies with focused classes

**Coding Example:**
```csharp
// VIOLATION: Multiple responsibilities
public class UserManagerBad
{
    // Responsibility 1: User data persistence
    public void SaveUser(User user)
    {
        // Database logic
        Console.WriteLine("Saving to database...");
    }
    
    // Responsibility 2: Email notifications
    public void SendWelcomeEmail(User user)
    {
        // Email logic
        Console.WriteLine($"Sending email to {user.Email}");
    }
    
    // Responsibility 3: User validation
    public bool ValidateUser(User user)
    {
        // Validation logic
        return !string.IsNullOrEmpty(user.Email);
    }
    
    // Responsibility 4: Password hashing
    public string HashPassword(string password)
    {
        // Cryptography logic
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }
    
    // Responsibility 5: Logging
    public void LogActivity(string activity)
    {
        // Logging logic
        Console.WriteLine($"[{DateTime.Now}] {activity}");
    }
}

// Problems with UserManagerBad:
// - Change email template? Modify UserManager
// - Change database? Modify UserManager
// - Change validation rules? Modify UserManager
// - Change password algorithm? Modify UserManager
// - Change logging format? Modify UserManager
// - Testing requires mocking all dependencies

// CORRECT: Single Responsibility per class
public class UserRepository
{
    // Single responsibility: User persistence
    private readonly IDbConnection _connection;
    
    public UserRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public async Task SaveAsync(User user)
    {
        // Only database logic here
        await _connection.ExecuteAsync("INSERT INTO Users...");
    }
    
    public async Task<User> GetByIdAsync(int id)
    {
        return await _connection.QueryFirstOrDefaultAsync<User>("SELECT * FROM Users WHERE Id = @Id", new { Id = id });
    }
}

public class EmailService
{
    // Single responsibility: Email sending
    private readonly IEmailClient _emailClient;
    
    public EmailService(IEmailClient emailClient)
    {
        _emailClient = emailClient;
    }
    
    public async Task SendWelcomeEmailAsync(string email, string name)
    {
        var message = $"Welcome {name}!";
        await _emailClient.SendAsync(email, "Welcome", message);
    }
}

public class UserValidator
{
    // Single responsibility: User validation
    public ValidationResult Validate(User user)
    {
        var errors = new List<string>();
        
        if (string.IsNullOrEmpty(user.Email))
            errors.Add("Email is required");
        
        if (!user.Email.Contains("@"))
            errors.Add("Email is invalid");
        
        if (string.IsNullOrEmpty(user.Name))
            errors.Add("Name is required");
        
        return new ValidationResult(errors.Count == 0, errors);
    }
}

public class PasswordHasher
{
    // Single responsibility: Password hashing
    public string Hash(string password)
    {
        // Use proper hashing (BCrypt, Argon2)
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
    
    public bool Verify(string password, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(password, hash);
    }
}

public class ActivityLogger
{
    // Single responsibility: Activity logging
    private readonly ILogger _logger;
    
    public ActivityLogger(ILogger logger)
    {
        _logger = logger;
    }
    
    public void LogUserActivity(int userId, string activity)
    {
        _logger.Log($"User {userId}: {activity}");
    }
}

// Orchestration with focused classes
public class UserRegistrationService
{
    private readonly UserRepository _userRepository;
    private readonly EmailService _emailService;
    private readonly UserValidator _validator;
    private readonly PasswordHasher _passwordHasher;
    private readonly ActivityLogger _logger;
    
    public UserRegistrationService(
        UserRepository userRepository,
        EmailService emailService,
        UserValidator validator,
        PasswordHasher passwordHasher,
        ActivityLogger logger)
    {
        _userRepository = userRepository;
        _emailService = emailService;
        _validator = validator;
        _passwordHasher = passwordHasher;
        _logger = logger;
    }
    
    public async Task<RegistrationResult> RegisterUserAsync(string email, string name, string password)
    {
        // Orchestrate single-responsibility classes
        var user = new User { Email = email, Name = name };
        
        // Validate
        var validationResult = _validator.Validate(user);
        if (!validationResult.IsValid)
            return RegistrationResult.Failed(validationResult.Errors);
        
        // Hash password
        user.PasswordHash = _passwordHasher.Hash(password);
        
        // Save
        await _userRepository.SaveAsync(user);
        
        // Send email
        await _emailService.SendWelcomeEmailAsync(user.Email, user.Name);
        
        // Log
        _logger.LogUserActivity(user.Id, "User registered");
        
        return RegistrationResult.Success();
    }
}

// Benefits: Easy to test individual components
public class UserValidatorTests
{
    // Test validation in isolation - no dependencies
    public void ValidateUser_EmptyEmail_ReturnsInvalid()
    {
        var validator = new UserValidator();
        var user = new User { Email = "", Name = "Test" };
        
        var result = validator.Validate(user);
        
        // Assert result is invalid
    }
}

public class UserRegistrationServiceTests
{
    // Test orchestration with mocked dependencies
    public async Task RegisterUser_ValidUser_SendsEmail()
    {
        var mockEmailService = new Mock<EmailService>();
        var mockRepository = new Mock<UserRepository>();
        // ... setup other mocks
        
        var service = new UserRegistrationService(
            mockRepository.Object,
            mockEmailService.Object,
            new UserValidator(),
            new PasswordHasher(),
            Mock.Of<ActivityLogger>()
        );
        
        await service.RegisterUserAsync("test@test.com", "Test", "password");
        
        // Verify email was sent
        mockEmailService.Verify(e => e.SendWelcomeEmailAsync(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
}

// Real-world example: Report generation
// VIOLATION: Multiple responsibilities
public class ReportGeneratorBad
{
    public void GenerateReport(int reportId)
    {
        // 1. Fetch data
        var data = FetchDataFromDatabase(reportId);
        
        // 2. Calculate metrics
        var metrics = CalculateMetrics(data);
        
        // 3. Format as PDF
        var pdf = FormatAsPdf(metrics);
        
        // 4. Upload to storage
        UploadToS3(pdf);
        
        // 5. Send notification
        SendEmailNotification(reportId);
    }
    
    private object FetchDataFromDatabase(int id) => null;
    private object CalculateMetrics(object data) => null;
    private byte[] FormatAsPdf(object metrics) => null;
    private void UploadToS3(byte[] pdf) { }
    private void SendEmailNotification(int id) { }
}

// CORRECT: Separated responsibilities
public class ReportDataRepository
{
    public async Task<ReportData> GetReportDataAsync(int reportId)
    {
        // Single responsibility: Data access
        await Task.Delay(10);
        return new ReportData();
    }
}

public class ReportMetricsCalculator
{
    public ReportMetrics Calculate(ReportData data)
    {
        // Single responsibility: Business calculations
        return new ReportMetrics();
    }
}

public class PdfFormatter
{
    public byte[] Format(ReportMetrics metrics)
    {
        // Single responsibility: PDF formatting
        return new byte[0];
    }
}

public class StorageService
{
    public async Task<string> UploadAsync(byte[] content, string fileName)
    {
        // Single responsibility: File storage
        await Task.Delay(10);
        return $"https://storage.example.com/{fileName}";
    }
}

public class NotificationService
{
    public async Task NotifyReportReadyAsync(string recipientEmail, string reportUrl)
    {
        // Single responsibility: Notifications
        await Task.Delay(10);
    }
}

// Orchestrator
public class ReportGenerationService
{
    private readonly ReportDataRepository _dataRepository;
    private readonly ReportMetricsCalculator _calculator;
    private readonly PdfFormatter _pdfFormatter;
    private readonly StorageService _storageService;
    private readonly NotificationService _notificationService;
    
    public ReportGenerationService(
        ReportDataRepository dataRepository,
        ReportMetricsCalculator calculator,
        PdfFormatter pdfFormatter,
        StorageService storageService,
        NotificationService notificationService)
    {
        _dataRepository = dataRepository;
        _calculator = calculator;
        _pdfFormatter = pdfFormatter;
        _storageService = storageService;
        _notificationService = notificationService;
    }
    
    public async Task GenerateAndDistributeReportAsync(int reportId, string recipientEmail)
    {
        var data = await _dataRepository.GetReportDataAsync(reportId);
        var metrics = _calculator.Calculate(data);
        var pdf = _pdfFormatter.Format(metrics);
        var url = await _storageService.UploadAsync(pdf, $"report_{reportId}.pdf");
        await _notificationService.NotifyReportReadyAsync(recipientEmail, url);
    }
}

// Identifying violations
public class SRPViolationDetection
{
    /*
     * RED FLAGS:
     * 1. Class names with "And", "Manager", "Helper", "Utility"
     * 2. Many public methods with unrelated purposes
     * 3. Changes for different reasons touch same class
     * 4. Difficulty naming class without "And"
     * 5. Hard to write focused unit tests
     * 6. Many dependencies injected
     * 7. Long classes (>300 lines often indicate violations)
     * 
     * EXAMPLE VIOLATIONS:
     * - OrderManager: calculates totals, saves to DB, sends emails
     * - UserHelper: validates, hashes passwords, sends SMS
     * - DataProcessor: reads files, transforms data, generates reports
     * 
     * HOW TO REFACTOR:
     * 1. Identify distinct responsibilities
     * 2. Extract each to separate class
     * 3. Use composition/orchestration to coordinate
     * 4. Apply dependency injection
     * 5. Name classes by their single purpose
     */
}

// Supporting types
public interface IDbConnection
{
    Task<int> ExecuteAsync(string sql, object parameters = null);
    Task<T> QueryFirstOrDefaultAsync<T>(string sql, object parameters = null);
}

public interface IEmailClient
{
    Task SendAsync(string to, string subject, string body);
}

public class ValidationResult
{
    public bool IsValid { get; }
    public List<string> Errors { get; }
    
    public ValidationResult(bool isValid, List<string> errors)
    {
        IsValid = isValid;
        Errors = errors;
    }
}

public class RegistrationResult
{
    public bool Success { get; private set; }
    public List<string> Errors { get; private set; }
    
    public static RegistrationResult Success() => new RegistrationResult { Success = true };
    public static RegistrationResult Failed(List<string> errors) => new RegistrationResult { Errors = errors };
}

public class ReportData { }
public class ReportMetrics { }

// Guidelines
public class SRPGuidelines
{
    /*
     * SINGLE RESPONSIBILITY PRINCIPLE:
     * - A class should have only one reason to change
     * - Each class serves one actor/stakeholder
     * - Cohesion: things that change together, stay together
     * 
     * BENEFITS:
     * 1. Easier to understand and maintain
     * 2. Lower coupling between components
     * 3. Easier to test (fewer mocks needed)
     * 4. Changes isolated to single class
     * 5. Better reusability
     * 
     * HOW TO APPLY:
     * 1. Identify distinct responsibilities
     * 2. One responsibility per class
     * 3. Use composition for orchestration
     * 4. Apply at class, method, and module levels
     * 
     * COMMON MISTAKES:
     * 1. Too granular (one method per class)
     * 2. Ignoring cohesion (splitting related behavior)
     * 3. Creating "manager" classes that coordinate too much
     * 4. Not refactoring when responsibilities grow
     * 
     * BALANCE:
     * - Don't over-engineer with too many tiny classes
     * - Group cohesive operations together
     * - Refactor when new reasons to change emerge
     * - Consider team size and project complexity
     */
}
```

---

### Question 28: Explain Dependency Injection (DI) and Inversion of Control (IoC). How do they improve code quality?

**Short Theory:**  
Dependency Injection is a pattern where dependencies are provided to a class rather than created internally. Inversion of Control inverts the flow—frameworks call application code rather than application controlling flow. DI is achieved through constructor injection (preferred), property injection, or method injection. IoC containers (DI containers) manage object lifetimes and resolve dependencies automatically. This enables loose coupling, testability, and adheres to Dependency Inversion Principle.

**Why do we use it?**  
DI enables unit testing by allowing mock injection without modifying production code. It centralizes dependency management and configuration. Changing implementations requires no code changes—just container configuration. IoC containers handle complex object graphs, lifetime management (singleton, scoped, transient), and circular dependency detection. This is fundamental to modern architecture—ASP.NET Core, Spring, and most frameworks are built around DI.

**Key Interview Points:**
- Constructor injection is preferred—makes dependencies explicit and enables immutability
- DI container manages lifetime: Singleton (one instance), Scoped (per request), Transient (each time)
- Depend on abstractions (interfaces), not concretions (classes)
- Avoid service locator pattern—it hides dependencies
- Property injection for optional dependencies only

**Coding Example:**
```csharp
// WITHOUT DI - Tight coupling (BAD)
public class OrderServiceBad
{
    private readonly OrderRepository _repository;
    private readonly EmailService _emailService;
    private readonly PaymentGateway _paymentGateway;
    
    public OrderServiceBad()
    {
        // Creating dependencies - TIGHT COUPLING
        _repository = new OrderRepository();
        _emailService = new EmailService();
        _paymentGateway = new PaymentGateway();
    }
    
    public void PlaceOrder(Order order)
    {
        _repository.Save(order);
        _emailService.SendConfirmation(order);
        _paymentGateway.ProcessPayment(order);
    }
    
    // Problems:
    // - Can't test without real database/email/payment
    // - Can't swap implementations
    // - Hard to configure different environments
    // - Hidden dependencies (not visible in constructor)
}

// WITH DI - Loose coupling (GOOD)
public interface IOrderRepository
{
    Task SaveAsync(Order order);
}

public interface IEmailService
{
    Task SendConfirmationAsync(Order order);
}

public interface IPaymentGateway
{
    Task<PaymentResult> ProcessPaymentAsync(Order order);
}

public class OrderService
{
    private readonly IOrderRepository _repository;
    private readonly IEmailService _emailService;
    private readonly IPaymentGateway _paymentGateway;
    
    // Constructor injection - dependencies explicit
    public OrderService(
        IOrderRepository repository,
        IEmailService emailService,
        IPaymentGateway paymentGateway)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        _paymentGateway = paymentGateway ?? throw new ArgumentNullException(nameof(paymentGateway));
    }
    
    public async Task PlaceOrderAsync(Order order)
    {
        await _repository.SaveAsync(order);
        await _emailService.SendConfirmationAsync(order);
        await _paymentGateway.ProcessPaymentAsync(order);
    }
}

// DI Container registration (ASP.NET Core)
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Transient: new instance each time
        services.AddTransient<IEmailService, EmailService>();
        
        // Scoped: one instance per HTTP request
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<OrderService>();
        
        // Singleton: one instance for application lifetime
        services.AddSingleton<IPaymentGateway, StripePaymentGateway>();
        
        // Factory pattern for complex creation
        services.AddTransient<INotificationService>(provider =>
        {
            var config = provider.GetRequiredService<IConfiguration>();
            var useSms = config.GetValue<bool>("UseSmsNotifications");
            
            return useSms
                ? new SmsNotificationService()
                : new EmailNotificationService();
        });
    }
}

// Lifetime scopes explained
public class LifetimeScopesExample
{
    public void ExplainLifetimes()
    {
        /*
         * TRANSIENT:
         * - New instance every time requested
         * - Use for: Lightweight, stateless services
         * - Example: Validators, formatters, helpers
         * 
         * SCOPED:
         * - One instance per scope (HTTP request in ASP.NET Core)
         * - Use for: DbContext, repositories, unit of work
         * - Example: Per-request services
         * 
         * SINGLETON:
         * - One instance for application lifetime
         * - Use for: Stateless services, caches, configurations
         * - Example: Logging, configuration, caches
         * - WARNING: Must be thread-safe!
         */
    }
}

// Testing with DI
public class OrderServiceTests
{
    [Fact]
    public async Task PlaceOrder_ValidOrder_SavesOrder()
    {
        // Arrange - create mocks
        var mockRepository = new Mock<IOrderRepository>();
        var mockEmailService = new Mock<IEmailService>();
        var mockPaymentGateway = new Mock<IPaymentGateway>();
        
        mockPaymentGateway
            .Setup(g => g.ProcessPaymentAsync(It.IsAny<Order>()))
            .ReturnsAsync(PaymentResult.Success);
        
        // Inject mocks
        var service = new OrderService(
            mockRepository.Object,
            mockEmailService.Object,
            mockPaymentGateway.Object
        );
        
        var order = new Order { Id = 1, Total = 100 };
        
        // Act
        await service.PlaceOrderAsync(order);
        
        // Assert
        mockRepository.Verify(r => r.SaveAsync(order), Times.Once);
        mockEmailService.Verify(e => e.SendConfirmationAsync(order), Times.Once);
    }
}

// Property injection (for optional dependencies)
public class LoggingService
{
    // Optional dependency via property
    public ILogger Logger { get; set; } = new NullLogger();
    
    public void LogMessage(string message)
    {
        Logger.Log(message); // Uses NullLogger if not injected
    }
}

// Method injection (rarely used)
public class ReportGenerator
{
    public byte[] GenerateReport(ReportData data, IFormatter formatter)
    {
        // formatter injected per method call
        return formatter.Format(data);
    }
}

// Service locator pattern (ANTI-PATTERN - avoid)
public class ServiceLocatorAntiPattern
{
    public void ProcessOrder(Order order)
    {
        // BAD: Hidden dependency
        var repository = ServiceLocator.Get<IOrderRepository>();
        var emailService = ServiceLocator.Get<IEmailService>();
        
        // Problems:
        // - Dependencies not visible
        // - Hard to test
        // - Runtime errors if not registered
        // - Tight coupling to ServiceLocator
    }
}

// Complex dependency graph
public interface IUserService { }
public interface IOrderService { }
public interface IInventoryService { }
public interface IShippingService { }

public class ECommerceOrchestrator
{
    private readonly IUserService _userService;
    private readonly IOrderService _orderService;
    private readonly IInventoryService _inventoryService;
    private readonly IShippingService _shippingService;
    
    public ECommerceOrchestrator(
        IUserService userService,
        IOrderService orderService,
        IInventoryService inventoryService,
        IShippingService shippingService)
    {
        _userService = userService;
        _orderService = orderService;
        _inventoryService = inventoryService;
        _shippingService = shippingService;
    }
    
    // Container automatically resolves all dependencies recursively
}

// Circular dependency detection
public class ServiceA
{
    // BAD: Circular dependency (A depends on B, B depends on A)
    public ServiceA(ServiceB serviceB) { }
}

public class ServiceB
{
    public ServiceB(ServiceA serviceA) { }
    // DI container will throw exception at startup
}

// Real-world: Multiple implementations
public interface IPaymentProcessor
{
    Task<PaymentResult> ProcessAsync(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public async Task<PaymentResult> ProcessAsync(decimal amount)
    {
        await Task.Delay(100);
        return PaymentResult.Success;
    }
}

public class PayPalProcessor : IPaymentProcessor
{
    public async Task<PaymentResult> ProcessAsync(decimal amount)
    {
        await Task.Delay(100);
        return PaymentResult.Success;
    }
}

// Strategy pattern with DI
public class PaymentService
{
    private readonly IEnumerable<IPaymentProcessor> _processors;
    
    public PaymentService(IEnumerable<IPaymentProcessor> processors)
    {
        _processors = processors; // All registered implementations
    }
    
    public async Task<PaymentResult> ProcessPaymentAsync(PaymentMethod method, decimal amount)
    {
        var processor = method switch
        {
            PaymentMethod.CreditCard => _processors.OfType<CreditCardProcessor>().First(),
            PaymentMethod.PayPal => _processors.OfType<PayPalProcessor>().First(),
            _ => throw new NotSupportedException()
        };
        
        return await processor.ProcessAsync(amount);
    }
}

// Configuration
public class ConfigurationServices
{
    public void Configure(IServiceCollection services, IConfiguration config)
    {
        // Register both implementations
        services.AddTransient<IPaymentProcessor, CreditCardProcessor>();
        services.AddTransient<IPaymentProcessor, PayPalProcessor>();
        
        // Service will receive all implementations
        services.AddScoped<PaymentService>();
    }
}

// Decorators with DI
public interface IDataCache
{
    Task<T> GetAsync<T>(string key);
    Task SetAsync<T>(string key, T value);
}

public class RedisCache : IDataCache
{
    public async Task<T> GetAsync<T>(string key)
    {
        await Task.Delay(10);
        return default;
    }
    
    public async Task SetAsync<T>(string key, T value)
    {
        await Task.Delay(10);
    }
}

public class LoggingCacheDecorator : IDataCache
{
    private readonly IDataCache _innerCache;
    private readonly ILogger _logger;
    
    public LoggingCacheDecorator(IDataCache innerCache, ILogger logger)
    {
        _innerCache = innerCache;
        _logger = logger;
    }
    
    public async Task<T> GetAsync<T>(string key)
    {
        _logger.Log($"Cache GET: {key}");
        return await _innerCache.GetAsync<T>(key);
    }
    
    public async Task SetAsync<T>(string key, T value)
    {
        _logger.Log($"Cache SET: {key}");
        await _innerCache.SetAsync(key, value);
    }
}

// Register decorator
public class DecoratorRegistration
{
    public void Configure(IServiceCollection services)
    {
        // Register implementation
        services.AddSingleton<RedisCache>();
        
        // Register decorator
        services.AddSingleton<IDataCache>(provider =>
        {
            var cache = provider.GetRequiredService<RedisCache>();
            var logger = provider.GetRequiredService<ILogger>();
            return new LoggingCacheDecorator(cache, logger);
        });
    }
}

// Avoiding captive dependencies
public class CaptiveDependencyProblem
{
    public void ConfigureBad(IServiceCollection services)
    {
        // BAD: Singleton capturing Scoped service
        services.AddSingleton<SingletonService>();
        services.AddScoped<IScopedDependency, ScopedService>();
        
        // SingletonService constructor injects IScopedDependency
        // Scoped instance captured for entire app lifetime!
    }
    
    public void ConfigureGood(IServiceCollection services)
    {
        // GOOD: Use factory for scoped resolution
        services.AddSingleton<SingletonService>();
        services.AddScoped<IScopedDependency, ScopedService>();
        
        // Resolve scoped service using IServiceProvider
    }
}

public class SingletonService
{
    private readonly IServiceProvider _serviceProvider;
    
    public SingletonService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public void DoWork()
    {
        using var scope = _serviceProvider.CreateScope();
        var scopedService = scope.ServiceProvider.GetRequiredService<IScopedDependency>();
        // Use scoped service
    }
}

public interface IScopedDependency { }
public class ScopedService : IScopedDependency { }

// Supporting types
public enum PaymentMethod { CreditCard, PayPal }
public interface INotificationService { }
public class SmsNotificationService : INotificationService { }
public class EmailNotificationService : INotificationService { }
public class NullLogger : ILogger { public void Log(string message) { } }
public interface IFormatter { byte[] Format(ReportData data); }
public static class ServiceLocator { public static T Get<T>() => default; }
public class IServiceCollection : List<object> { }
public static class ServiceCollectionExtensions
{
    public static void AddTransient<TInterface, TImplementation>(this IServiceCollection services) { }
    public static void AddScoped<TInterface, TImplementation>(this IServiceCollection services) { }
    public static void AddSingleton<TInterface, TImplementation>(this IServiceCollection services) { }
    public static void AddTransient<T>(this IServiceCollection services, Func<IServiceProvider, T> factory) { }
    public static void AddSingleton<T>(this IServiceCollection services, Func<IServiceProvider, T> factory) { }
    public static void AddScoped<T>(this IServiceCollection services) { }
}
public interface IServiceProvider
{
    T GetRequiredService<T>();
    IServiceScope CreateScope();
}
public interface IServiceScope : IDisposable
{
    IServiceProvider ServiceProvider { get; }
}
public interface IConfiguration
{
    T GetValue<T>(string key);
}
public class FakeAttribute : Attribute { }

// Guidelines
public class DependencyInjectionGuidelines
{
    /*
     * DEPENDENCY INJECTION BENEFITS:
     * 1. Loose coupling - depend on abstractions
     * 2. Testability - easy to mock dependencies
     * 3. Flexibility - swap implementations via configuration
     * 4. Maintainability - centralized dependency management
     * 5. Single Responsibility - classes don't create dependencies
     * 
     * CONSTRUCTOR INJECTION (Preferred):
     * - Makes dependencies explicit
     * - Enables immutability (readonly fields)
     * - Fails fast if dependencies missing
     * - Easy to test
     * 
     * LIFETIME SCOPES:
     * - Transient: Use for lightweight, stateless
     * - Scoped: Use for per-request (DbContext)
     * - Singleton: Use for thread-safe, stateless
     * 
     * BEST PRACTICES:
     * 1. Depend on interfaces, not classes
     * 2. Use constructor injection by default
     * 3. Property injection only for optional dependencies
     * 4. Avoid service locator pattern
     * 5. Register at composition root (Startup/Program)
     * 6. Don't inject IServiceProvider (except for factories)
     * 7. Watch for captive dependencies
     * 
     * COMMON MISTAKES:
     * 1. Injecting too many dependencies (>5 indicates SRP violation)
     * 2. Registering with wrong lifetime
     * 3. Circular dependencies
     * 4. Singleton capturing scoped/transient
     * 5. Using service locator instead of injection
     * 
     * TESTING:
     * - Use mocking frameworks (Moq, NSubstitute)
     * - Inject test implementations
     * - Avoid testing DI container itself
     */
}

public class FactAttribute : Attribute { }
```

---

### Question 29: Explain the Repository pattern. What problems does it solve?

**Short Theory:**  
The Repository pattern abstracts data access logic by providing a collection-like interface for domain entities. It encapsulates queries, inserts, updates, and deletes behind an interface, separating business logic from data access concerns. Repositories work with domain models, not database-specific types. They enable unit of work pattern for transactions and provide centralized data access logic. Generic repositories reduce boilerplate but can over-abstract domain needs.

**Why do we use it?**  
Repositories decouple business logic from data access technology (EF Core, Dapper, MongoDB). Changing databases requires updating only repository implementations, not business logic. They enable testing without databases by mocking repository interfaces. Repositories prevent leaking data access concerns (IQueryable) into business layers. They centralize query logic, making optimization and caching easier. However, over-abstraction can hide database capabilities and create unnecessary layers.

**Key Interview Points:**
- Mediates between domain and data mapping layers
- Encapsulates data access logic and query construction
- Enables testing without database dependencies
- Generic repositories reduce boilerplate but may over-abstract
- Unit of Work pattern often used with repositories for transactions

**Coding Example:**
```csharp
// WITHOUT Repository - Direct DbContext usage (problematic)
public class OrderServiceWithoutRepository
{
    private readonly AppDbContext _context;
    
    public OrderServiceWithoutRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Order>> GetActiveOrdersAsync()
    {
        // Business logic mixed with data access
        return await _context.Orders
            .Where(o => o.Status == OrderStatus.Active)
            .Include(o => o.Items)
            .ToListAsync();
        
        // Problems:
        // - Business logic knows about EF Core
        // - Hard to test without database
        // - Query logic scattered across services
        // - Can't swap data access technology
    }
}

// WITH Repository - Clean separation
public interface IOrderRepository
{
    Task<Order> GetByIdAsync(int id);
    Task<IEnumerable<Order>> GetActiveOrdersAsync();
    Task<IEnumerable<Order>> GetOrdersByCustomerAsync(int customerId);
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
    Task DeleteAsync(int id);
    Task<int> GetTotalOrderCountAsync();
}

public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _context;
    
    public OrderRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Order> GetByIdAsync(int id)
    {
        return await _context.Orders
            .Include(o => o.Items)
            .Include(o => o.Customer)
            .FirstOrDefaultAsync(o => o.Id == id);
    }
    
    public async Task<IEnumerable<Order>> GetActiveOrdersAsync()
    {
        return await _context.Orders
            .Where(o => o.Status == OrderStatus.Active)
            .Include(o => o.Items)
            .ToListAsync();
    }
    
    public async Task<IEnumerable<Order>> GetOrdersByCustomerAsync(int customerId)
    {
        return await _context.Orders
            .Where(o => o.CustomerId == customerId)
            .OrderByDescending(o => o.OrderDate)
            .ToListAsync();
    }
    
    public async Task AddAsync(Order order)
    {
        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
    }
    
    public async Task UpdateAsync(Order order)
    {
        _context.Orders.Update(order);
        await _context.SaveChangesAsync();
    }
    
    public async Task DeleteAsync(int id)
    {
        var order = await GetByIdAsync(id);
        if (order != null)
        {
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
    
    public async Task<int> GetTotalOrderCountAsync()
    {
        return await _context.Orders.CountAsync();
    }
}

// Business service uses repository
public class OrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IEmailService _emailService;
    
    public OrderService(IOrderRepository orderRepository, IEmailService emailService)
    {
        _orderRepository = orderRepository;
        _emailService = emailService;
    }
    
    public async Task<bool> ProcessOrderAsync(int orderId)
    {
        // Business logic separated from data access
        var order = await _orderRepository.GetByIdAsync(orderId);
        
        if (order == null)
            return false;
        
        // Business logic
        order.Status = OrderStatus.Processing;
        await _orderRepository.UpdateAsync(order);
        
        await _emailService.SendConfirmationAsync(order);
        
        return true;
    }
    
    public async Task<OrderStatistics> GetCustomerStatisticsAsync(int customerId)
    {
        var orders = await _orderRepository.GetOrdersByCustomerAsync(customerId);
        
        return new OrderStatistics
        {
            TotalOrders = orders.Count(),
            TotalAmount = orders.Sum(o => o.Total)
        };
    }
}

// Testing with repository
public class OrderServiceTests
{
    [Fact]
    public async Task ProcessOrder_ValidOrder_UpdatesStatus()
    {
        // Arrange
        var mockRepository = new Mock<IOrderRepository>();
        var mockEmailService = new Mock<IEmailService>();
        
        var order = new Order { Id = 1, Status = OrderStatus.Pending };
        mockRepository.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(order);
        
        var service = new OrderService(mockRepository.Object, mockEmailService.Object);
        
        // Act
        var result = await service.ProcessOrderAsync(1);
        
        // Assert
        Assert.True(result);
        Assert.Equal(OrderStatus.Processing, order.Status);
        mockRepository.Verify(r => r.UpdateAsync(order), Times.Once);
    }
}

// Generic Repository (reduces boilerplate)
public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;
    
    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    
    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }
    
    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
    
    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }
    
    public virtual async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    
    public virtual async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }
    
    public virtual async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

// Specific repository extends generic
public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context) { }
    
    // Domain-specific query
    public async Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold)
    {
        return await _dbSet
            .Where(p => p.StockQuantity < threshold)
            .OrderBy(p => p.StockQuantity)
            .ToListAsync();
    }
    
    // Domain-specific query
    public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(string category)
    {
        return await _dbSet
            .Where(p => p.Category == category && p.IsActive)
            .ToListAsync();
    }
}

public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
    Task<IEnumerable<Product>> GetProductsByCategoryAsync(string category);
}

// Unit of Work pattern with repositories
public interface IUnitOfWork : IDisposable
{
    IOrderRepository Orders { get; }
    IProductRepository Products { get; }
    ICustomerRepository Customers { get; }
    
    Task<int> CompleteAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IOrderRepository _orders;
    private IProductRepository _products;
    private ICustomerRepository _customers;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public IOrderRepository Orders =>
        _orders ??= new OrderRepository(_context);
    
    public IProductRepository Products =>
        _products ??= new ProductRepository(_context);
    
    public ICustomerRepository Customers =>
        _customers ??= new CustomerRepository(_context);
    
    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }
    
    public async Task BeginTransactionAsync()
    {
        await _context.Database.BeginTransactionAsync();
    }
    
    public async Task CommitTransactionAsync()
    {
        await _context.Database.CommitTransactionAsync();
    }
    
    public async Task RollbackTransactionAsync()
    {
        await _context.Database.RollbackTransactionAsync();
    }
    
    public void Dispose()
    {
        _context.Dispose();
    }
}

// Using Unit of Work
public class OrderProcessingService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public OrderProcessingService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task ProcessOrderAsync(Order order)
    {
        await _unitOfWork.BeginTransactionAsync();
        
        try
        {
            // Add order
            await _unitOfWork.Orders.AddAsync(order);
            
            // Update product stock
            foreach (var item in order.Items)
            {
                var product = await _unitOfWork.Products.GetByIdAsync(item.ProductId);
                product.StockQuantity -= item.Quantity;
                await _unitOfWork.Products.UpdateAsync(product);
            }
            
            // All changes saved together
            await _unitOfWork.CompleteAsync();
            await _unitOfWork.CommitTransactionAsync();
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync();
            throw;
        }
    }
}

// Specification pattern (advanced querying)
public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    Expression<Func<T, object>> OrderBy { get; }
    Expression<Func<T, object>> OrderByDescending { get; }
}

public class BaseSpecification<T> : ISpecification<T>
{
    public Expression<Func<T, bool>> Criteria { get; private set; }
    public List<Expression<Func<T, object>>> Includes { get; } = new();
    public Expression<Func<T, object>> OrderBy { get; private set; }
    public Expression<Func<T, object>> OrderByDescending { get; private set; }
    
    protected void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }
    
    protected void ApplyCriteria(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }
    
    protected void ApplyOrderBy(Expression<Func<T, object>> orderByExpression)
    {
        OrderBy = orderByExpression;
    }
    
    protected void ApplyOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
    {
        OrderByDescending = orderByDescExpression;
    }
}

public class ActiveOrdersSpecification : BaseSpecification<Order>
{
    public ActiveOrdersSpecification(int customerId)
    {
        ApplyCriteria(o => o.CustomerId == customerId && o.Status == OrderStatus.Active);
        AddInclude(o => o.Items);
        AddInclude(o => o.Customer);
        ApplyOrderByDescending(o => o.OrderDate);
    }
}

// Repository with specification
public class RepositoryWithSpecification<T> : Repository<T> where T : class
{
    public RepositoryWithSpecification(AppDbContext context) : base(context) { }
    
    public async Task<IEnumerable<T>> FindWithSpecificationAsync(ISpecification<T> spec)
    {
        var query = _dbSet.AsQueryable();
        
        if (spec.Criteria != null)
            query = query.Where(spec.Criteria);
        
        query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
        
        if (spec.OrderBy != null)
            query = query.OrderBy(spec.OrderBy);
        
        if (spec.OrderByDescending != null)
            query = query.OrderByDescending(spec.OrderByDescending);
        
        return await query.ToListAsync();
    }
}

// Usage
public class OrderServiceWithSpec
{
    private readonly RepositoryWithSpecification<Order> _repository;
    
    public OrderServiceWithSpec(RepositoryWithSpecification<Order> repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<Order>> GetCustomerActiveOrdersAsync(int customerId)
    {
        var spec = new ActiveOrdersSpecification(customerId);
        return await _repository.FindWithSpecificationAsync(spec);
    }
}

// Supporting types
public class AppDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int StockQuantity { get; set; }
    public bool IsActive { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public enum OrderStatus { Pending, Active, Processing, Completed, Cancelled }

public class OrderStatistics
{
    public int TotalOrders { get; set; }
    public decimal TotalAmount { get; set; }
}

public interface ICustomerRepository : IRepository<Customer> { }
public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(AppDbContext context) : base(context) { }
}

// Guidelines
public class RepositoryPatternGuidelines
{
    /*
     * REPOSITORY PATTERN BENEFITS:
     * 1. Separation of concerns (business logic vs data access)
     * 2. Testability (easy to mock)
     * 3. Centralized data access logic
     * 4. Technology independence
     * 5. Query reusability
     * 
     * WHEN TO USE:
     * - Complex domain logic
     * - Need to swap data access technology
     * - Multiple data sources
     * - Testing without database
     * 
     * WHEN NOT TO USE:
     * - Simple CRUD applications
     * - ORM (EF Core) already provides abstraction
     * - Over-abstraction adds complexity
     * 
     * GENERIC vs SPECIFIC:
     * Generic:
     * - Reduces boilerplate
     * - Works for simple CRUD
     * - May over-abstract domain needs
     * 
     * Specific:
     * - Domain-driven queries
     * - Better expressiveness
     * - More flexible
     * 
     * BEST PRACTICES:
     * 1. Return domain entities, not DTOs
     * 2. Don't expose IQueryable (leaky abstraction)
     * 3. Keep repositories focused on single entity
     * 4. Use Unit of Work for transactions
     * 5. Consider specification pattern for complex queries
     * 6. Don't create repository for every table
     * 
     * ANTI-PATTERNS:
     * 1. Generic repository without specific methods
     * 2. Repositories doing business logic
     * 3. Exposing IQueryable outside repository
     * 4. Too many repositories (one per table)
     * 5. Repositories calling other repositories
     */
}
```

---

### Question 30: What is the difference between composition and inheritance? When should you favor composition?

**Short Theory:**  
Inheritance creates "is-a" relationships where derived classes inherit implementation from base classes (tight coupling). Composition creates "has-a" relationships where classes contain instances of other classes (loose coupling). Inheritance is appropriate for true specialization; composition for behavior reuse. "Favor composition over inheritance" means preferring to build functionality through collaboration rather than extension, enabling more flexible, maintainable designs.

**Why do we use it?**  
Composition avoids inheritance hierarchies that become fragile and difficult to change. It enables runtime behavior changes—inject different implementations rather than derive new classes. Composition supports multiple behaviors (inject many interfaces); inheritance allows one base class. Testing is easier with composition—mock injected dependencies. Composition aligns with SOLID principles, especially Dependency Inversion and Interface Segregation.

**Key Interview Points:**
- Inheritance: tight coupling, compile-time relationships, "is-a"
- Composition: loose coupling, runtime flexibility, "has-a"
- Prefer composition for behavior reuse, inheritance for true specialization
- Composition enables strategy pattern, decorator pattern
- Deep inheritance hierarchies are brittle and hard to maintain

**Coding Example:**
```csharp
// INHERITANCE APPROACH (problematic for behavior reuse)
public class Vehicle
{
    public virtual void Start() => Console.WriteLine("Vehicle starting");
    public virtual void Stop() => Console.WriteLine("Vehicle stopping");
}

public class Car : Vehicle
{
    public override void Start() => Console.WriteLine("Car starting");
}

public class ElectricCar : Car
{
    // What if we need FlyingCar or SwimmingCar?
    // Inheritance creates rigid hierarchy
}

// Problem: Need flying vehicle
public class FlyingVehicle : Vehicle
{
    public void Fly() => Console.WriteLine("Flying");
}

// Problem: Need flying car - multiple inheritance not supported!
// public class FlyingCar : Car, FlyingVehicle { } // ERROR

// COMPOSITION APPROACH (flexible)
public interface IEngine
{
    void Start();
    void Stop();
}

public interface IFlyingCapability
{
    void TakeOff();
    void Land();
}

public interface ISwimmingCapability
{
    void Dive();
    void Surface();
}

public class GasolineEngine : IEngine
{
    public void Start() => Console.WriteLine("Gasoline engine starting");
    public void Stop() => Console.WriteLine("Gasoline engine stopping");
}

public class ElectricEngine : IEngine
{
    public void Start() => Console.WriteLine("Electric engine starting");
    public void Stop() => Console.WriteLine("Electric engine stopping");
}

public class JetPropulsion : IFlyingCapability
{
    public void TakeOff() => Console.WriteLine("Jet taking off");
    public void Land() => Console.WriteLine("Jet landing");
}

public class Propeller : IFlyingCapability
{
    public void TakeOff() => Console.WriteLine("Propeller taking off");
    public void Land() => Console.WriteLine("Propeller landing");
}

// Composition: Vehicle HAS capabilities
public class ComposableVehicle
{
    private readonly IEngine _engine;
    private readonly IFlyingCapability _flyingCapability;
    private readonly ISwimmingCapability _swimmingCapability;
    
    public ComposableVehicle(
        IEngine engine,
        IFlyingCapability flyingCapability = null,
        ISwimmingCapability swimmingCapability = null)
    {
        _engine = engine;
        _flyingCapability = flyingCapability;
        _swimmingCapability = swimmingCapability;
    }
    
    public void Start() => _engine.Start();
    public void Stop() => _engine.Stop();
    
    public void Fly()
    {
        if (_flyingCapability != null)
        {
            _flyingCapability.TakeOff();
        }
        else
        {
            throw new NotSupportedException("This vehicle cannot fly");
        }
    }
    
    public void Swim()
    {
        if (_swimmingCapability != null)
        {
            _swimmingCapability.Dive();
        }
        else
        {
            throw new NotSupportedException("This vehicle cannot swim");
        }
    }
}

// Usage: Create any combination at runtime
public class CompositionExamples
{
    public void CreateVehicles()
    {
        // Regular car
        var car = new ComposableVehicle(new GasolineEngine());
        car.Start();
        
        // Electric car
        var electricCar = new ComposableVehicle(new ElectricEngine());
        electricCar.Start();
        
        // Flying car with jet propulsion
        var flyingCar = new ComposableVehicle(
            new GasolineEngine(),
            new JetPropulsion()
        );
        flyingCar.Start();
        flyingCar.Fly();
        
        // Amphibious vehicle
        var amphibiousVehicle = new ComposableVehicle(
            new ElectricEngine(),
            swimmingCapability: new WaterPropulsion()
        );
        amphibiousVehicle.Start();
        amphibiousVehicle.Swim();
        
        // Flying submarine!
        var flyingSub = new ComposableVehicle(
            new ElectricEngine(),
            new Propeller(),
            new WaterPropulsion()
        );
    }
}

public class WaterPropulsion : ISwimmingCapability
{
    public void Dive() => Console.WriteLine("Diving");
    public void Surface() => Console.WriteLine("Surfacing");
}

// When to use inheritance: True specialization
public abstract class Animal
{
    public abstract void MakeSound();
    
    // Common behavior
    public void Sleep() => Console.WriteLine("Sleeping");
}

public class Dog : Animal
{
    // Dog IS-A Animal (true specialization)
    public override void MakeSound() => Console.WriteLine("Woof");
}

public class Cat : Animal
{
    // Cat IS-A Animal (true specialization)
    public override void MakeSound() => Console.WriteLine("Meow");
}

// Real-world: Payment processing
// INHERITANCE (rigid)
public abstract class PaymentProcessorInheritance
{
    public abstract Task<bool> ProcessAsync(decimal amount);
}

public class CreditCardProcessorInheritance : PaymentProcessorInheritance
{
    public override async Task<bool> ProcessAsync(decimal amount)
    {
        await Task.Delay(100);
        return true;
    }
}

// COMPOSITION (flexible)
public interface IPaymentValidator
{
    bool Validate(PaymentRequest request);
}

public interface IPaymentGateway
{
    Task<PaymentResponse> ChargeAsync(decimal amount);
}

public interface IFraudDetection
{
    bool IsFraudulent(PaymentRequest request);
}

public class PaymentProcessorComposition
{
    private readonly IPaymentValidator _validator;
    private readonly IPaymentGateway _gateway;
    private readonly IFraudDetection _fraudDetection;
    private readonly ILogger _logger;
    
    public PaymentProcessorComposition(
        IPaymentValidator validator,
        IPaymentGateway gateway,
        IFraudDetection fraudDetection,
        ILogger logger)
    {
        _validator = validator;
        _gateway = gateway;
        _fraudDetection = fraudDetection;
        _logger = logger;
    }
    
    public async Task<bool> ProcessAsync(PaymentRequest request)
    {
        // Compose behavior from multiple components
        _logger.Log("Processing payment");
        
        if (!_validator.Validate(request))
            return false;
        
        if (_fraudDetection.IsFraudulent(request))
            return false;
        
        var response = await _gateway.ChargeAsync(request.Amount);
        return response.Success;
    }
}

// Strategy pattern (composition)
public interface IShippingStrategy
{
    decimal CalculateCost(double weight, double distance);
}

public class StandardShipping : IShippingStrategy
{
    public decimal CalculateCost(double weight, double distance)
    {
        return (decimal)(weight * 0.5 + distance * 0.1);
    }
}

public class ExpressShipping : IShippingStrategy
{
    public decimal CalculateCost(double weight, double distance)
    {
        return (decimal)(weight * 1.0 + distance * 0.2);
    }
}

public class ShippingCalculator
{
    private IShippingStrategy _strategy;
    
    public ShippingCalculator(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }
    
    // Change strategy at runtime
    public void SetStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public decimal Calculate(double weight, double distance)
    {
        return _strategy.CalculateCost(weight, distance);
    }
}

// Decorator pattern (composition)
public interface ICoffee
{
    string GetDescription();
    decimal GetCost();
}

public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Simple coffee";
    public decimal GetCost() => 2.00m;
}

public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;
    
    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    
    public abstract string GetDescription();
    public abstract decimal GetCost();
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }
    
    public override string GetDescription() => _coffee.GetDescription() + ", milk";
    public override decimal GetCost() => _coffee.GetCost() + 0.50m;
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }
    
    public override string GetDescription() => _coffee.GetDescription() + ", sugar";
    public override decimal GetCost() => _coffee.GetCost() + 0.25m;
}

// Usage: Compose decorators
public class DecoratorExample
{
    public void MakeCoffee()
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()}: ${coffee.GetCost()}");
        
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()}: ${coffee.GetCost()}");
        
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()}: ${coffee.GetCost()}");
        
        // Simple coffee, milk, sugar: $2.75
    }
}

// Fragile base class problem with inheritance
public class BaseClass
{
    public virtual void DoSomething()
    {
        Console.WriteLine("Base implementation");
    }
}

public class DerivedClass : BaseClass
{
    public override void DoSomething()
    {
        base.DoSomething(); // Depends on base implementation
        Console.WriteLine("Derived implementation");
    }
}

// If base class changes, derived classes may break
public class ChangedBaseClass : BaseClass
{
    public override void DoSomething()
    {
        // Behavior changed - breaks DerivedClass expectations
        Console.WriteLine("Different base implementation");
    }
}

// Composition avoids this problem
public interface IAction
{
    void Execute();
}

public class BaseAction : IAction
{
    public void Execute() => Console.WriteLine("Base action");
}

public class ComposedAction
{
    private readonly IAction _action;
    
    public ComposedAction(IAction action)
    {
        _action = action;
    }
    
    public void Execute()
    {
        _action.Execute(); // Depends on interface, not implementation
        Console.WriteLine("Additional action");
    }
}

// Supporting types
public class PaymentRequest
{
    public decimal Amount { get; set; }
}

public class PaymentResponse
{
    public bool Success { get; set; }
}

// Guidelines
public class CompositionVsInheritanceGuidelines
{
    /*
     * USE INHERITANCE when:
     * - True "is-a" relationship (Dog is-a Animal)
     * - Liskov Substitution Principle applies
     * - Shared implementation needed
     * - Polymorphism required
     * - Framework requires it (UI controls, etc.)
     * 
     * USE COMPOSITION when:
     * - "Has-a" or "uses-a" relationship
     * - Need multiple behaviors
     * - Want runtime flexibility
     * - Behaviors change independently
     * - Testing with mocks needed
     * 
     * COMPOSITION BENEFITS:
     * 1. Loose coupling
     * 2. Runtime flexibility
     * 3. Multiple behaviors (multiple interfaces)
     * 4. Easier testing
     * 5. Avoids fragile base class problem
     * 6. Better adheres to SOLID principles
     * 
     * INHERITANCE PITFALLS:
     * 1. Tight coupling to base class
     * 2. Fragile base class problem
     * 3. Deep hierarchies hard to understand
     * 4. Can't change at runtime
     * 5. Single base class limitation
     * 
     * BEST PRACTICES:
     * 1. Favor composition over inheritance
     * 2. Use inheritance for specialization, not code reuse
     * 3. Keep inheritance hierarchies shallow (2-3 levels max)
     * 4. Prefer interfaces + composition
     * 5. Use abstract classes only for true abstraction
     * 6. Consider strategy, decorator patterns
     * 
     * WHEN BOTH:
     * - Interface inheritance (contracts)
     * - Composition for implementation
     * - Example: IRepository interface + composed implementation
     */
}
```

---

**Batch 4 completed. Continue with next batch.**

---

## Batch 5: Serialization & Performance Optimization (Questions 31-35)

### Question 31: Compare System.Text.Json vs Newtonsoft.Json (Json.NET). When would you use each?

**Short Theory:**  
System.Text.Json is the modern, built-in JSON library in .NET (since .NET Core 3.0), optimized for performance and memory efficiency. Newtonsoft.Json (Json.NET) is a mature third-party library with extensive features and customization options. System.Text.Json is faster (up to 2x) with less allocation but has fewer features. Newtonsoft.Json supports more edge cases, complex scenarios, and has broader type support. System.Text.Json is strict by default; Newtonsoft is lenient.

**Why do we use it?**  
System.Text.Json reduces dependencies and provides better performance for high-throughput APIs. It's the default for ASP.NET Core 3.0+. However, Newtonsoft.Json offers features like LINQ to JSON (JObject), better DateTime handling, more converters, and complex type support. Migration from Newtonsoft to System.Text.Json may break existing code due to behavior differences. Understanding both is critical for maintaining legacy code and optimizing new applications.

**Key Interview Points:**
- System.Text.Json: faster, less memory, built-in, strict defaults
- Newtonsoft.Json: more features, flexible, mature, lenient
- System.Text.Json case-sensitive by default; Newtonsoft case-insensitive
- System.Text.Json doesn't support fields, only properties
- Newtonsoft has better support for circular references and polymorphism

**Coding Example:**
```csharp
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Model for testing
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public Address Address { get; set; }
    public List<string> Hobbies { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
}

// BASIC SERIALIZATION COMPARISON
public class SerializationComparison
{
    public void CompareBasicUsage()
    {
        var person = new Person
        {
            Id = 1,
            Name = "John Doe",
            BirthDate = new DateTime(1990, 1, 1),
            Address = new Address { Street = "123 Main St", City = "Seattle" },
            Hobbies = new List<string> { "Reading", "Coding" }
        };
        
        // System.Text.Json
        var jsonSystem = System.Text.Json.JsonSerializer.Serialize(person);
        var deserializedSystem = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonSystem);
        
        // Newtonsoft.Json
        var jsonNewtonsoft = Newtonsoft.Json.JsonConvert.SerializeObject(person);
        var deserializedNewtonsoft = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(jsonNewtonsoft);
    }
}

// CASE SENSITIVITY DIFFERENCES
public class CaseSensitivityDemo
{
    public void DemonstrateCaseSensitivity()
    {
        var json = @"{""id"": 1, ""name"": ""John""}"; // lowercase
        
        // System.Text.Json - CASE SENSITIVE by default (FAILS)
        try
        {
            var person = System.Text.Json.JsonSerializer.Deserialize<Person>(json);
            // person.Id = 0, person.Name = null (properties not matched)
        }
        catch { }
        
        // System.Text.Json - Case insensitive option
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var personCaseInsensitive = System.Text.Json.JsonSerializer.Deserialize<Person>(json, options);
        // Now works: person.Id = 1, person.Name = "John"
        
        // Newtonsoft.Json - CASE INSENSITIVE by default (WORKS)
        var personNewtonsoft = JsonConvert.DeserializeObject<Person>(json);
        // Works: person.Id = 1, person.Name = "John"
    }
}

// NAMING POLICIES
public class NamingPolicyDemo
{
    public void DemonstrateNamingPolicies()
    {
        var person = new Person { Id = 1, Name = "John" };
        
        // System.Text.Json - camelCase
        var optionsCamel = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        var jsonCamel = System.Text.Json.JsonSerializer.Serialize(person, optionsCamel);
        // Output: { "id": 1, "name": "John", "birthDate": "..." }
        
        // System.Text.Json - snake_case (custom)
        var optionsSnake = new JsonSerializerOptions
        {
            PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
            WriteIndented = true
        };
        
        // Newtonsoft.Json - camelCase
        var settingsCamel = new JsonSerializerSettings
        {
            ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
            Formatting = Formatting.Indented
        };
        var jsonNewtonsoftCamel = JsonConvert.SerializeObject(person, settingsCamel);
        
        // Newtonsoft.Json - snake_case
        var settingsSnake = new JsonSerializerSettings
        {
            ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver
            {
                NamingStrategy = new Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy()
            },
            Formatting = Formatting.Indented
        };
        var jsonNewtonsoftSnake = JsonConvert.SerializeObject(person, settingsSnake);
    }
}

// Custom naming policy for System.Text.Json
public class SnakeCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        if (string.IsNullOrEmpty(name)) return name;
        
        var result = new StringBuilder();
        result.Append(char.ToLower(name[0]));
        
        for (int i = 1; i < name.Length; i++)
        {
            if (char.IsUpper(name[i]))
            {
                result.Append('_');
                result.Append(char.ToLower(name[i]));
            }
            else
            {
                result.Append(name[i]);
            }
        }
        
        return result.ToString();
    }
}

// CUSTOM CONVERTERS
// System.Text.Json converter
public class DateTimeCustomConverter : JsonConverter<DateTime>
{
    private const string Format = "yyyy-MM-dd";
    
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTime.ParseExact(reader.GetString(), Format, null);
    }
    
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format));
    }
}

// Newtonsoft.Json converter
public class DateTimeNewtonsoftConverter : JsonConverter<DateTime>
{
    private const string Format = "yyyy-MM-dd";
    
    public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
    {
        return DateTime.ParseExact(reader.Value.ToString(), Format, null);
    }
    
    public override void WriteJson(JsonWriter writer, DateTime value, Newtonsoft.Json.JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString(Format));
    }
}

public class CustomConverterDemo
{
    public void UseCustomConverters()
    {
        var person = new Person { BirthDate = new DateTime(1990, 1, 1) };
        
        // System.Text.Json with custom converter
        var optionsSystem = new JsonSerializerOptions();
        optionsSystem.Converters.Add(new DateTimeCustomConverter());
        var jsonSystem = System.Text.Json.JsonSerializer.Serialize(person, optionsSystem);
        
        // Newtonsoft with custom converter
        var settingsNewtonsoft = new JsonSerializerSettings();
        settingsNewtonsoft.Converters.Add(new DateTimeNewtonsoftConverter());
        var jsonNewtonsoft = JsonConvert.SerializeObject(person, settingsNewtonsoft);
    }
}

// IGNORING PROPERTIES
public class PersonWithIgnore
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // System.Text.Json
    [System.Text.Json.Serialization.JsonIgnore]
    public string PasswordSystem { get; set; }
    
    // Newtonsoft.Json
    [Newtonsoft.Json.JsonIgnore]
    public string PasswordNewtonsoft { get; set; }
    
    // Both
    [System.Text.Json.Serialization.JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    public string PasswordBoth { get; set; }
}

// NULL HANDLING
public class NullHandlingDemo
{
    public void DemonstrateNullHandling()
    {
        var person = new Person { Id = 1, Name = null };
        
        // System.Text.Json - include nulls by default
        var jsonSystemDefault = System.Text.Json.JsonSerializer.Serialize(person);
        // Output: { "Id": 1, "Name": null, ... }
        
        // System.Text.Json - ignore nulls
        var optionsIgnoreNull = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        var jsonSystemIgnoreNull = System.Text.Json.JsonSerializer.Serialize(person, optionsIgnoreNull);
        // Output: { "Id": 1, ... } (Name omitted)
        
        // Newtonsoft.Json - include nulls by default
        var jsonNewtonsoftDefault = JsonConvert.SerializeObject(person);
        // Output: { "Id": 1, "Name": null, ... }
        
        // Newtonsoft.Json - ignore nulls
        var settingsIgnoreNull = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };
        var jsonNewtonsoftIgnoreNull = JsonConvert.SerializeObject(person, settingsIgnoreNull);
        // Output: { "Id": 1, ... } (Name omitted)
    }
}

// CIRCULAR REFERENCE HANDLING
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Department Department { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; } = new();
}

public class CircularReferenceDemo
{
    public void HandleCircularReferences()
    {
        var dept = new Department { Id = 1, Name = "Engineering" };
        var emp = new Employee { Id = 1, Name = "John", Department = dept };
        dept.Employees.Add(emp);
        
        // System.Text.Json - NO built-in circular reference support (throws exception)
        try
        {
            var jsonSystem = System.Text.Json.JsonSerializer.Serialize(dept);
            // Throws JsonException: A possible object cycle was detected
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
        // System.Text.Json - use ReferenceHandler (preview)
        var optionsWithRef = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve
        };
        var jsonSystemWithRef = System.Text.Json.JsonSerializer.Serialize(dept, optionsWithRef);
        // Output includes $id and $ref metadata
        
        // Newtonsoft.Json - built-in circular reference support
        var settingsCircular = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            // or ReferenceLoopHandling.Serialize (with $ref)
        };
        var jsonNewtonsoft = JsonConvert.SerializeObject(dept, settingsCircular);
        // Works: ignores circular references
    }
}

// LINQ TO JSON (Newtonsoft only)
public class LinqToJsonDemo
{
    public void DemonstrateJObject()
    {
        var json = @"{
            ""id"": 1,
            ""name"": ""John"",
            ""address"": {
                ""street"": ""123 Main St"",
                ""city"": ""Seattle""
            },
            ""hobbies"": [""Reading"", ""Coding""]
        }";
        
        // Newtonsoft.Json - JObject for dynamic access
        var jObject = JObject.Parse(json);
        var name = jObject["name"]?.ToString();
        var city = jObject["address"]?["city"]?.ToString();
        var firstHobby = jObject["hobbies"]?[0]?.ToString();
        
        // Modify
        jObject["name"] = "Jane";
        jObject["address"]?["city"] = "Portland";
        
        // Query with LINQ
        var hobbies = jObject["hobbies"]?.Select(h => h.ToString()).ToList();
        
        // System.Text.Json - use JsonDocument (read-only)
        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;
        var nameSystem = root.GetProperty("name").GetString();
        var citySystem = root.GetProperty("address").GetProperty("city").GetString();
        
        // System.Text.Json - mutable with JsonNode (.NET 6+)
        var jsonNode = System.Text.Json.Nodes.JsonNode.Parse(json);
        var nameNode = jsonNode["name"]?.ToString();
        jsonNode["name"] = "Jane"; // Can modify
    }
}

// POLYMORPHIC SERIALIZATION
public abstract class Shape
{
    public string Type { get; set; }
}

public class Circle : Shape
{
    public double Radius { get; set; }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class PolymorphicDemo
{
    public void SerializePolymorphic()
    {
        List<Shape> shapes = new()
        {
            new Circle { Type = "Circle", Radius = 5 },
            new Rectangle { Type = "Rectangle", Width = 10, Height = 5 }
        };
        
        // Newtonsoft.Json - TypeNameHandling
        var settingsTyped = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Objects,
            Formatting = Formatting.Indented
        };
        var jsonNewtonsoft = JsonConvert.SerializeObject(shapes, settingsTyped);
        // Includes $type metadata
        var deserializedNewtonsoft = JsonConvert.DeserializeObject<List<Shape>>(jsonNewtonsoft, settingsTyped);
        // Correctly deserializes to Circle and Rectangle
        
        // System.Text.Json - requires custom converter or discriminator
        var optionsPolymorphic = new JsonSerializerOptions();
        optionsPolymorphic.Converters.Add(new ShapeConverter());
        var jsonSystem = System.Text.Json.JsonSerializer.Serialize(shapes, optionsPolymorphic);
    }
}

// Custom polymorphic converter for System.Text.Json
public class ShapeConverter : JsonConverter<Shape>
{
    public override Shape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("Type").GetString();
        
        return type switch
        {
            "Circle" => System.Text.Json.JsonSerializer.Deserialize<Circle>(root.GetRawText(), options),
            "Rectangle" => System.Text.Json.JsonSerializer.Deserialize<Rectangle>(root.GetRawText(), options),
            _ => throw new NotSupportedException($"Type {type} not supported")
        };
    }
    
    public override void Write(Utf8JsonWriter writer, Shape value, JsonSerializerOptions options)
    {
        System.Text.Json.JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}

// PERFORMANCE COMPARISON
public class PerformanceComparison
{
    public void BenchmarkSerialization()
    {
        var people = Enumerable.Range(1, 10000)
            .Select(i => new Person
            {
                Id = i,
                Name = $"Person {i}",
                BirthDate = DateTime.Now.AddYears(-30),
                Address = new Address { Street = $"{i} Main St", City = "Seattle" },
                Hobbies = new List<string> { "Reading", "Coding" }
            })
            .ToList();
        
        // System.Text.Json - FASTER (typically 1.5-2x)
        var sw1 = Stopwatch.StartNew();
        var jsonSystem = System.Text.Json.JsonSerializer.Serialize(people);
        sw1.Stop();
        Console.WriteLine($"System.Text.Json: {sw1.ElapsedMilliseconds}ms, Size: {jsonSystem.Length}");
        
        // Newtonsoft.Json - SLOWER but more features
        var sw2 = Stopwatch.StartNew();
        var jsonNewtonsoft = JsonConvert.SerializeObject(people);
        sw2.Stop();
        Console.WriteLine($"Newtonsoft.Json: {sw2.ElapsedMilliseconds}ms, Size: {jsonNewtonsoft.Length}");
    }
}

// MIGRATION GUIDE
public class MigrationConsiderations
{
    /*
     * BREAKING CHANGES when migrating from Newtonsoft to System.Text.Json:
     * 
     * 1. CASE SENSITIVITY:
     *    - Newtonsoft: case-insensitive by default
     *    - System.Text.Json: case-sensitive by default
     *    - Solution: Set PropertyNameCaseInsensitive = true
     * 
     * 2. PROPERTY vs FIELDS:
     *    - Newtonsoft: serializes fields
     *    - System.Text.Json: only properties
     *    - Solution: Convert fields to properties
     * 
     * 3. MISSING PROPERTIES:
     *    - Newtonsoft: ignores missing properties
     *    - System.Text.Json: ignores by default but stricter
     *    - Solution: Test thoroughly
     * 
     * 4. CIRCULAR REFERENCES:
     *    - Newtonsoft: ReferenceLoopHandling
     *    - System.Text.Json: ReferenceHandler.Preserve (limited)
     *    - Solution: Restructure data or use Newtonsoft
     * 
     * 5. DATETIME FORMATS:
     *    - Newtonsoft: flexible parsing
     *    - System.Text.Json: ISO 8601 by default
     *    - Solution: Custom converters
     * 
     * 6. LINQ TO JSON:
     *    - Newtonsoft: JObject, JArray, JToken
     *    - System.Text.Json: JsonDocument (read-only), JsonNode (.NET 6+)
     *    - Solution: Use JsonDocument or keep Newtonsoft for dynamic JSON
     * 
     * 7. POLYMORPHISM:
     *    - Newtonsoft: TypeNameHandling
     *    - System.Text.Json: Custom converters
     *    - Solution: Implement custom converters
     */
}

// DECISION MATRIX
public class DecisionGuide
{
    /*
     * USE SYSTEM.TEXT.JSON WHEN:
     * - Building new .NET 5+ applications
     * - Performance is critical (high-throughput APIs)
     * - Want to minimize dependencies
     * - JSON is simple and straightforward
     * - Using ASP.NET Core 3.0+ (default)
     * 
     * USE NEWTONSOFT.JSON WHEN:
     * - Maintaining legacy applications
     * - Need LINQ to JSON (dynamic JSON manipulation)
     * - Require extensive customization
     * - Complex polymorphic scenarios
     * - Circular references common
     * - Need maximum compatibility
     * - DateTime handling complexity
     * - Working with third-party libraries expecting Newtonsoft
     * 
     * BOTH:
     * - Can coexist in same project
     * - Use appropriate attributes for each
     * - Configure ASP.NET Core to use Newtonsoft if needed:
     *   services.AddControllers().AddNewtonsoftJson();
     */
}

// Supporting types
public class Stopwatch
{
    private DateTime _start;
    public long ElapsedMilliseconds => (long)(DateTime.Now - _start).TotalMilliseconds;
    public static Stopwatch StartNew()
    {
        var sw = new Stopwatch();
        sw._start = DateTime.Now;
        return sw;
    }
    public void Stop() { }
}

// Guidelines
public class SerializationGuidelines
{
    /*
     * SYSTEM.TEXT.JSON vs NEWTONSOFT.JSON:
     * 
     * PERFORMANCE:
     * - System.Text.Json: 1.5-2x faster, less memory
     * - Important for high-throughput scenarios
     * 
     * FEATURES:
     * - Newtonsoft: More mature, more features
     * - System.Text.Json: Catching up but still limited
     * 
     * BEST PRACTICES:
     * 1. Use System.Text.Json for new projects
     * 2. Keep Newtonsoft for complex scenarios
     * 3. Configure case-insensitive if needed
     * 4. Use custom converters for complex types
     * 5. Handle nulls appropriately
     * 6. Test migration thoroughly
     * 7. Consider performance for large payloads
     * 8. Use JsonDocument for read-only parsing
     * 9. Avoid circular references in design
     * 10. Document serialization behavior
     */
}
```

---

### Question 32: How would you optimize a slow C# application? What tools and techniques would you use?

**Short Theory:**  
Performance optimization follows: measure first (profiling), identify bottlenecks, optimize hot paths, verify improvements. Common culprits include inefficient algorithms (O(n²)), excessive allocations, database N+1 queries, lack of caching, synchronous I/O, and boxing. Tools include BenchmarkDotNet for micro-benchmarks, dotMemory/PerfView for memory analysis, Application Insights for production monitoring, and Visual Studio Profiler. Premature optimization is wasteful—profile to find actual bottlenecks.

**Why do we use it?**  
Optimization improves user experience (lower latency), reduces costs (fewer servers), and enables scalability. However, premature optimization wastes time and complicates code. Profiling identifies actual bottlenecks—often surprising. 80/20 rule: 20% of code causes 80% of slowness. Micro-optimizations in cold paths don't matter; hot path optimization matters significantly. Measuring before and after proves improvements and prevents regressions.

**Key Interview Points:**
- Always profile before optimizing—don't guess
- Optimize algorithms first (O(n²) → O(n log n)), then micro-optimizations
- Common issues: N+1 queries, excessive allocations, string concatenation, LINQ misuse
- Use BenchmarkDotNet for accurate measurements (JIT warmup, GC, outliers)
- Memory profilers find leaks and excessive allocations

**Coding Example:**
```csharp
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Text;

// PROFILING AND BENCHMARKING
public class PerformanceOptimizationExample
{
    public static void Main()
    {
        // Run benchmarks
        BenchmarkRunner.Run<StringConcatenationBenchmark>();
        BenchmarkRunner.Run<LinqOptimizationBenchmark>();
        BenchmarkRunner.Run<CollectionBenchmark>();
    }
}

// STRING CONCATENATION OPTIMIZATION
[MemoryDiagnoser]
public class StringConcatenationBenchmark
{
    private const int Iterations = 1000;
    
    // SLOW: String concatenation (creates new string each time)
    [Benchmark(Baseline = true)]
    public string StringConcatenation()
    {
        string result = "";
        for (int i = 0; i < Iterations; i++)
        {
            result += i.ToString(); // Creates new string each iteration
        }
        return result;
    }
    
    // FAST: StringBuilder
    [Benchmark]
    public string StringBuilderOptimized()
    {
        var sb = new StringBuilder(Iterations * 4); // Pre-allocate capacity
        for (int i = 0; i < Iterations; i++)
        {
            sb.Append(i);
        }
        return sb.ToString();
    }
    
    // Results (example):
    // StringConcatenation:     1,234.56 μs, 500 KB allocated
    // StringBuilderOptimized:      12.34 μs,   4 KB allocated
}

// LINQ OPTIMIZATION
[MemoryDiagnoser]
public class LinqOptimizationBenchmark
{
    private List<int> _numbers;
    
    [GlobalSetup]
    public void Setup()
    {
        _numbers = Enumerable.Range(1, 10000).ToList();
    }
    
    // SLOW: Multiple enumerations
    [Benchmark(Baseline = true)]
    public int MultipleEnumerations()
    {
        var evenNumbers = _numbers.Where(n => n % 2 == 0);
        var count = evenNumbers.Count(); // First enumeration
        var sum = evenNumbers.Sum();     // Second enumeration
        return sum / count;
    }
    
    // FAST: Single enumeration with ToList
    [Benchmark]
    public int SingleEnumeration()
    {
        var evenNumbers = _numbers.Where(n => n % 2 == 0).ToList(); // Materialize once
        var count = evenNumbers.Count;
        var sum = evenNumbers.Sum();
        return sum / count;
    }
    
    // FASTER: Manual loop (no LINQ overhead)
    [Benchmark]
    public int ManualLoop()
    {
        int sum = 0;
        int count = 0;
        foreach (var n in _numbers)
        {
            if (n % 2 == 0)
            {
                sum += n;
                count++;
            }
        }
        return sum / count;
    }
}

// COLLECTION OPTIMIZATION
[MemoryDiagnoser]
public class CollectionBenchmark
{
    private const int ItemCount = 10000;
    
    // SLOW: List without capacity
    [Benchmark(Baseline = true)]
    public List<int> ListWithoutCapacity()
    {
        var list = new List<int>(); // Starts with capacity 0, grows dynamically
        for (int i = 0; i < ItemCount; i++)
        {
            list.Add(i); // May trigger multiple resizes
        }
        return list;
    }
    
    // FAST: List with pre-allocated capacity
    [Benchmark]
    public List<int> ListWithCapacity()
    {
        var list = new List<int>(ItemCount); // Pre-allocate
        for (int i = 0; i < ItemCount; i++)
        {
            list.Add(i); // No resizes
        }
        return list;
    }
    
    // SLOW: Wrong collection type for lookups
    [Benchmark]
    public bool ListLookup()
    {
        var list = Enumerable.Range(1, ItemCount).ToList();
        return list.Contains(ItemCount - 1); // O(n)
    }
    
    // FAST: HashSet for lookups
    [Benchmark]
    public bool HashSetLookup()
    {
        var set = Enumerable.Range(1, ItemCount).ToHashSet();
        return set.Contains(ItemCount - 1); // O(1)
    }
}

// DATABASE N+1 QUERY PROBLEM
public class DatabaseOptimization
{
    // SLOW: N+1 queries
    public async Task<List<OrderDto>> GetOrdersWithCustomersSlowAsync()
    {
        var orders = await _context.Orders.ToListAsync(); // 1 query
        var result = new List<OrderDto>();
        
        foreach (var order in orders)
        {
            // N queries (one per order)
            var customer = await _context.Customers.FindAsync(order.CustomerId);
            result.Add(new OrderDto
            {
                OrderId = order.Id,
                CustomerName = customer.Name // Requires separate query
            });
        }
        
        return result; // Total: 1 + N queries
    }
    
    // FAST: Single query with Include
    public async Task<List<OrderDto>> GetOrdersWithCustomersFastAsync()
    {
        return await _context.Orders
            .Include(o => o.Customer) // Join in single query
            .Select(o => new OrderDto
            {
                OrderId = o.Id,
                CustomerName = o.Customer.Name
            })
            .ToListAsync(); // Total: 1 query
    }
    
    // EVEN FASTER: Projection without Include
    public async Task<List<OrderDto>> GetOrdersWithCustomersOptimalAsync()
    {
        return await _context.Orders
            .Select(o => new OrderDto
            {
                OrderId = o.Id,
                CustomerName = o.Customer.Name // EF generates join automatically
            })
            .ToListAsync(); // Single query, only needed columns
    }
}

// CACHING STRATEGIES
public class CachingOptimization
{
    private readonly IMemoryCache _cache;
    private readonly IDistributedCache _distributedCache;
    
    // NO CACHING: Database hit every time
    public async Task<Product> GetProductSlowAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }
    
    // MEMORY CACHE: Fast, in-process
    public async Task<Product> GetProductCachedAsync(int id)
    {
        var cacheKey = $"product_{id}";
        
        if (_cache.TryGetValue(cacheKey, out Product cachedProduct))
        {
            return cachedProduct;
        }
        
        var product = await _context.Products.FindAsync(id);
        
        var cacheOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
            SlidingExpiration = TimeSpan.FromMinutes(2)
        };
        
        _cache.Set(cacheKey, product, cacheOptions);
        
        return product;
    }
    
    // DISTRIBUTED CACHE: Shared across servers (Redis)
    public async Task<Product> GetProductDistributedCachedAsync(int id)
    {
        var cacheKey = $"product_{id}";
        var cachedData = await _distributedCache.GetStringAsync(cacheKey);
        
        if (cachedData != null)
        {
            return System.Text.Json.JsonSerializer.Deserialize<Product>(cachedData);
        }
        
        var product = await _context.Products.FindAsync(id);
        var serialized = System.Text.Json.JsonSerializer.Serialize(product);
        
        await _distributedCache.SetStringAsync(cacheKey, serialized, new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)
        });
        
        return product;
    }
}

// ASYNC/AWAIT OPTIMIZATION
public class AsyncOptimization
{
    // SLOW: Sequential async calls
    public async Task<(string, string, string)> GetDataSequentialAsync()
    {
        var data1 = await FetchData1Async(); // Wait 100ms
        var data2 = await FetchData2Async(); // Wait 100ms
        var data3 = await FetchData3Async(); // Wait 100ms
        return (data1, data2, data3);
        // Total time: 300ms
    }
    
    // FAST: Parallel async calls
    public async Task<(string, string, string)> GetDataParallelAsync()
    {
        var task1 = FetchData1Async(); // Start all
        var task2 = FetchData2Async();
        var task3 = FetchData3Async();
        
        await Task.WhenAll(task1, task2, task3); // Wait for all
        
        return (task1.Result, task2.Result, task3.Result);
        // Total time: 100ms (parallel execution)
    }
    
    private async Task<string> FetchData1Async()
    {
        await Task.Delay(100);
        return "Data1";
    }
    
    private async Task<string> FetchData2Async()
    {
        await Task.Delay(100);
        return "Data2";
    }
    
    private async Task<string> FetchData3Async()
    {
        await Task.Delay(100);
        return "Data3";
    }
}

// BOXING AVOIDANCE
public class BoxingOptimization
{
    // SLOW: Boxing value types
    [Benchmark(Baseline = true)]
    public void WithBoxing()
    {
        object obj = 42; // Boxing: int → object
        int value = (int)obj; // Unboxing: object → int
        // Each operation allocates on heap
    }
    
    // FAST: Generics (no boxing)
    [Benchmark]
    public void WithGenerics<T>(T value)
    {
        var result = value; // No boxing
    }
    
    // SLOW: ArrayList (boxes value types)
    public void ArrayListBoxing()
    {
        var list = new ArrayList();
        for (int i = 0; i < 1000; i++)
        {
            list.Add(i); // Boxing every int
        }
    }
    
    // FAST: List<T> (no boxing)
    public void ListGeneric()
    {
        var list = new List<int>(1000);
        for (int i = 0; i < 1000; i++)
        {
            list.Add(i); // No boxing
        }
    }
}

// SPAN<T> AND MEMORY<T> FOR ZERO-ALLOCATION
public class SpanOptimization
{
    // SLOW: Substring creates new string
    [Benchmark(Baseline = true)]
    public int ParseWithSubstring()
    {
        var input = "12345,67890";
        var firstPart = input.Substring(0, 5); // Allocates new string
        return int.Parse(firstPart);
    }
    
    // FAST: ReadOnlySpan<char> (zero allocation)
    [Benchmark]
    public int ParseWithSpan()
    {
        var input = "12345,67890".AsSpan();
        var firstPart = input.Slice(0, 5); // No allocation
        return int.Parse(firstPart);
    }
    
    // Array processing without allocation
    public void ProcessArrayWithSpan()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // SLOW: Take creates new array
        var firstFive = numbers.Take(5).ToArray();
        
        // FAST: Span creates view without allocation
        var firstFiveSpan = numbers.AsSpan().Slice(0, 5);
        foreach (var n in firstFiveSpan)
        {
            // Process without allocation
        }
    }
}

// PARALLEL PROCESSING
public class ParallelOptimization
{
    private List<int> _numbers;
    
    [GlobalSetup]
    public void Setup()
    {
        _numbers = Enumerable.Range(1, 1000000).ToList();
    }
    
    // SLOW: Sequential processing
    [Benchmark(Baseline = true)]
    public long SequentialSum()
    {
        long sum = 0;
        foreach (var n in _numbers)
        {
            sum += ExpensiveComputation(n);
        }
        return sum;
    }
    
    // FAST: Parallel processing
    [Benchmark]
    public long ParallelSum()
    {
        return _numbers.AsParallel().Sum(n => ExpensiveComputation(n));
    }
    
    // FASTER: Parallel.ForEach with local state
    [Benchmark]
    public long ParallelForEachSum()
    {
        long total = 0;
        Parallel.ForEach(_numbers,
            () => 0L, // Local init
            (n, state, localSum) => localSum + ExpensiveComputation(n), // Body
            localSum => Interlocked.Add(ref total, localSum) // Aggregation
        );
        return total;
    }
    
    private long ExpensiveComputation(int n)
    {
        // Simulate expensive operation
        return n * n;
    }
}

// PROFILING TOOLS
public class ProfilingTools
{
    /*
     * BENCHMARKDOTNET:
     * - Micro-benchmarking framework
     * - Accurate measurements (JIT warmup, GC, statistical analysis)
     * - Memory diagnostics
     * - Export to multiple formats
     * 
     * Usage:
     * [MemoryDiagnoser]
     * public class MyBenchmark
     * {
     *     [Benchmark]
     *     public void MethodToTest() { }
     * }
     * BenchmarkRunner.Run<MyBenchmark>();
     * 
     * VISUAL STUDIO PROFILER:
     * - CPU profiling (hot paths)
     * - Memory profiling (allocations, leaks)
     * - Database profiling (queries)
     * - Integrated with debugger
     * 
     * DOTMEMORY / DOTPERF (JetBrains):
     * - Memory snapshot analysis
     * - Object retention paths
     * - GC pressure analysis
     * - Traffic analysis
     * 
     * PERFVIEW (Microsoft):
     * - ETW-based profiling
     * - CPU sampling
     * - GC heap analysis
     * - Free and powerful
     * 
     * APPLICATION INSIGHTS:
     * - Production monitoring
     * - Dependency tracking
     * - Performance counters
     * - Distributed tracing
     */
}

// OPTIMIZATION CHECKLIST
public class OptimizationChecklist
{
    /*
     * STEP 1: MEASURE (DON'T GUESS)
     * - Profile application to find bottlenecks
     * - Use production-like data volumes
     * - Identify hot paths (20% causing 80% slowness)
     * 
     * STEP 2: ALGORITHM OPTIMIZATION
     * - Check algorithmic complexity (O(n²) → O(n log n))
     * - Use appropriate data structures
     * - Avoid nested loops when possible
     * 
     * STEP 3: DATABASE OPTIMIZATION
     * - Fix N+1 queries (use Include, joins)
     * - Add indexes for frequent queries
     * - Use projections (Select) to fetch only needed data
     * - Consider stored procedures for complex queries
     * - Connection pooling
     * 
     * STEP 4: CACHING
     * - Cache expensive computations
     * - Use appropriate cache (memory, distributed)
     * - Set proper expiration policies
     * - Cache invalidation strategy
     * 
     * STEP 5: ASYNC OPTIMIZATION
     * - Parallelize independent async operations
     * - Avoid Task.Wait() and .Result (causes deadlocks)
     * - Use ConfigureAwait(false) in libraries
     * 
     * STEP 6: MEMORY OPTIMIZATION
     * - Avoid unnecessary allocations
     * - Use object pooling for frequently created objects
     * - Use Span<T> for array slicing
     * - StringBuilder for string building
     * - Proper collection capacity
     * 
     * STEP 7: COMPILATION & JIT
     * - Consider ReadyToRun (R2R) for faster startup
     * - Profile-guided optimization (PGO)
     * - Tiered compilation (.NET Core 3.0+)
     * 
     * COMMON PITFALLS:
     * 1. Premature optimization
     * 2. Optimizing cold paths
     * 3. Not measuring improvements
     * 4. Sacrificing readability for micro-optimizations
     * 5. Ignoring algorithmic complexity
     */
}

// Supporting types
private DbContext _context;
public class OrderDto
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
}
public interface IMemoryCache
{
    bool TryGetValue(string key, out Product value);
    void Set(string key, Product value, MemoryCacheEntryOptions options);
}
public class MemoryCacheEntryOptions
{
    public TimeSpan? AbsoluteExpirationRelativeToNow { get; set; }
    public TimeSpan? SlidingExpiration { get; set; }
}
public interface IDistributedCache
{
    Task<string> GetStringAsync(string key);
    Task SetStringAsync(string key, string value, DistributedCacheEntryOptions options);
}
public class DistributedCacheEntryOptions
{
    public TimeSpan? AbsoluteExpirationRelativeToNow { get; set; }
}
public class GlobalSetupAttribute : Attribute { }
public class ArrayList : List<object> { }

// Guidelines
public class PerformanceGuidelines
{
    /*
     * PERFORMANCE OPTIMIZATION PRINCIPLES:
     * 
     * 1. MEASURE FIRST
     *    - Profile before optimizing
     *    - Use production-like data
     *    - Establish baselines
     * 
     * 2. OPTIMIZE ALGORITHMS
     *    - Check Big O complexity
     *    - Choose right data structures
     *    - Consider trade-offs
     * 
     * 3. DATABASE PERFORMANCE
     *    - Avoid N+1 queries
     *    - Use indexes
     *    - Fetch only needed data
     *    - Connection pooling
     * 
     * 4. CACHING STRATEGY
     *    - Cache expensive operations
     *    - Appropriate expiration
     *    - Invalidation strategy
     * 
     * 5. ASYNC BEST PRACTICES
     *    - Parallelize independent operations
     *    - Avoid blocking calls
     *    - Use Task.WhenAll
     * 
     * 6. MEMORY EFFICIENCY
     *    - Reduce allocations
     *    - Use Span<T>, Memory<T>
     *    - StringBuilder for strings
     *    - Pre-allocate collections
     * 
     * 7. BALANCE
     *    - Readability vs performance
     *    - Development time vs optimization
     *    - Premature optimization is root of evil
     */
}
```

---

**Batch 5 Progress: Questions 31-32 completed. Continue with Questions 33-35 next.**

---

### Question 33: Explain the Singleton pattern in C#. What are thread-safe implementations and their trade-offs?

**Short Theory:**  
The Singleton pattern ensures a class has only one instance and provides a global point of access to it. It's useful for shared resources like configuration, logging, or connection pools. Thread-safe implementations include: eager initialization (static constructor), lazy initialization with locks (double-check locking), Lazy<T> (simplest thread-safe approach), and static holder pattern. The pattern is controversial—often considered an anti-pattern due to tight coupling, difficulty testing, and hidden dependencies.

**Why do we use it?**  
Singletons control shared resources, prevent multiple instances of expensive objects, and coordinate global state. However, they introduce global state (hard to test), tight coupling (classes depend on concrete implementations), and concurrency issues if not properly thread-safe. Dependency Injection is often preferred over singletons for better testability. Understanding singleton implementations demonstrates threading knowledge and awareness of design trade-offs.

**Key Interview Points:**
- Eager vs Lazy initialization trade-offs (startup time vs memory)
- Thread-safe implementations: lock, Lazy<T>, static constructor
- Double-check locking pattern (pre-.NET 4.0 concern)
- Singleton violates Single Responsibility Principle (manages lifetime + business logic)
- Prefer DI with singleton scope over static singleton

**Coding Example:**
```csharp
// 1. EAGER INITIALIZATION (thread-safe)
public sealed class SingletonEager
{
    // Instance created at class load time (thread-safe by CLR)
    private static readonly SingletonEager _instance = new SingletonEager();
    
    // Private constructor prevents external instantiation
    private SingletonEager()
    {
        Console.WriteLine("SingletonEager instance created");
    }
    
    public static SingletonEager Instance => _instance;
    
    public void DoWork()
    {
        Console.WriteLine("Working...");
    }
}

// Usage
public class EagerExample
{
    public void UseEagerSingleton()
    {
        var instance1 = SingletonEager.Instance;
        var instance2 = SingletonEager.Instance;
        
        Console.WriteLine(ReferenceEquals(instance1, instance2)); // True
    }
}

// Pros: Simple, thread-safe, CLR guarantees initialization
// Cons: Instance created even if never used (memory waste)

// 2. LAZY INITIALIZATION WITH LOCK (thread-safe)
public sealed class SingletonLazy
{
    private static SingletonLazy _instance;
    private static readonly object _lock = new object();
    
    private SingletonLazy()
    {
        Console.WriteLine("SingletonLazy instance created");
    }
    
    public static SingletonLazy Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null) // Double-check
                    {
                        _instance = new SingletonLazy();
                    }
                }
            }
            return _instance;
        }
    }
}

// Pros: Lazy initialization (created only when needed)
// Cons: Lock overhead on every access, complex double-check pattern

// 3. LAZY<T> PATTERN (RECOMMENDED - thread-safe and simple)
public sealed class SingletonLazyT
{
    // Lazy<T> handles thread-safety internally
    private static readonly Lazy<SingletonLazyT> _instance =
        new Lazy<SingletonLazyT>(() => new SingletonLazyT());
    
    private SingletonLazyT()
    {
        Console.WriteLine("SingletonLazyT instance created");
    }
    
    public static SingletonLazyT Instance => _instance.Value;
    
    public void DoWork()
    {
        Console.WriteLine("Working with Lazy<T>");
    }
}

// Pros: Thread-safe, lazy, simple, no locks needed after init
// Cons: Requires .NET 4.0+
```

---

### Question 34: Explain the Factory pattern and Abstract Factory pattern. When would you use each?

**Short Theory:**  
The Factory Method pattern defines an interface for creating objects but lets subclasses decide which class to instantiate. It promotes loose coupling by eliminating direct constructor calls. Abstract Factory provides an interface for creating families of related objects without specifying concrete classes. Factory Method creates one product; Abstract Factory creates multiple related products. Both enable Open/Closed Principle—adding new types doesn't require modifying existing code.

**Why do we use it?**  
Factory patterns decouple object creation from usage, enabling flexibility and testability. They centralize creation logic, making it easier to manage complex instantiation (dependencies, configuration). Abstract Factory ensures related objects are used together (e.g., UI themes). Factories enable runtime selection based on configuration or user input. They're fundamental to frameworks (ASP.NET Core DI) and plugins. Understanding factories demonstrates SOLID principles and design flexibility.

**Key Interview Points:**
- Factory Method: single product creation, subclasses choose type
- Abstract Factory: families of related products
- Both eliminate "new" keyword in client code (loose coupling)
- Enable dependency injection and testing
- Real-world: UI theme factories, data access layer factories

**Coding Example:**
```csharp
// SIMPLE FACTORY (Not GoF pattern, but common)
public enum ShippingMethod
{
    Standard,
    Express,
    Overnight
}

// Simple factory centralizes creation logic
public class ShippingCalculatorFactory
{
    public static IShippingCalculator Create(ShippingMethod method)
    {
        return method switch
        {
            ShippingMethod.Standard => new StandardShipping(),
            ShippingMethod.Express => new ExpressShipping(),
            ShippingMethod.Overnight => new OvernightShipping(),
            _ => throw new ArgumentException("Invalid shipping method")
        };
    }
}

public interface IShippingCalculator
{
    decimal CalculateCost(double weight, double distance);
    int GetDeliveryDays();
}
```

---

### Question 35: What are microservices? Explain key C# patterns for building resilient microservices.

**Short Theory:**  
Microservices are independently deployable services that own their data and communicate via APIs (REST, gRPC, message queues). Key patterns include: Circuit Breaker (prevent cascading failures), Retry with exponential backoff, Bulkhead (isolate resources), API Gateway (single entry point), Service Discovery, and Health Checks. Libraries like Polly implement resilience patterns. Microservices trade complexity for scalability, independence, and fault isolation.

**Why do we use it?**  
Microservices enable independent scaling, technology diversity, and team autonomy. However, they introduce distributed system challenges: network failures, partial failures, eventual consistency, and complexity. Resilience patterns are critical—without them, microservices amplify failures (cascading failures). Circuit breakers prevent calling failing services. Retries handle transient failures. Bulkheads prevent resource exhaustion. Understanding these patterns is essential for building production-ready distributed systems.

**Key Interview Points:**
- Circuit Breaker: prevent calling failing services (open/half-open/closed states)
- Retry with exponential backoff and jitter
- Bulkhead: isolate thread pools/resources to prevent cascading failures
- Polly library implements resilience patterns in C#
- Distributed tracing (correlation IDs) for debugging

**Coding Example:**
```csharp
using Polly;

// RETRY PATTERN WITH EXPONENTIAL BACKOFF
public class RetryPatternExample
{
    private readonly HttpClient _httpClient;
    
    // POLLY: Retry with exponential backoff
    public async Task<string> CallServiceWithPollyRetryAsync(string url)
    {
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(
                retryCount: 3,
                sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), // 2, 4, 8 seconds
                onRetry: (exception, timeSpan, retry, context) =>
                {
                    Console.WriteLine($"Retry {retry} after {timeSpan.TotalSeconds}s due to: {exception.Message}");
                });
        
        return await retryPolicy.ExecuteAsync(async () =>
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        });
    }
}

// CIRCUIT BREAKER PATTERN
public class CircuitBreakerExample
{
    public async Task<string> CallServiceWithCircuitBreakerAsync(string url)
    {
        var circuitBreakerPolicy = Policy
            .Handle<HttpRequestException>()
            .CircuitBreakerAsync(
                exceptionsAllowedBeforeBreaking: 3, // Open after 3 consecutive failures
                durationOfBreak: TimeSpan.FromSeconds(30), // Stay open for 30s
                onBreak: (exception, duration) =>
                {
                    Console.WriteLine($"Circuit breaker opened for {duration.TotalSeconds}s");
                },
                onReset: () =>
                {
                    Console.WriteLine("Circuit breaker reset");
                });
        
        return await circuitBreakerPolicy.ExecuteAsync(async () =>
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        });
    }
}
```

---

**Batch 5 completed (Questions 31-35). Continue with next batch.**

---

## Batch 6: LINQ, Entity Framework Core & Testing (Questions 36-40)

### Question 36: Explain advanced LINQ concepts: Expression Trees, Compiled Queries, and AsNoTracking. When would you use each?

**Short Theory:**  
Expression Trees represent code as data (Expression<Func<T, bool>>), enabling runtime query construction and translation (EF Core translates to SQL). Compiled Queries pre-compile LINQ queries for performance when executed repeatedly with different parameters. AsNoTracking() tells EF Core to skip change tracking for read-only queries, reducing memory and improving performance. Expression Trees enable dynamic queries; AsNoTracking optimizes read performance; Compiled Queries cache query plans.

**Why do we use it?**  
Expression Trees power LINQ providers (EF Core, IQueryable) by converting C# expressions into database queries. Dynamic queries (filters, sorting) are built using Expression Trees. AsNoTracking significantly improves read performance (30-40% faster) by avoiding change tracking overhead. Compiled Queries eliminate repeated query compilation overhead for frequently executed queries. Understanding these is critical for performance tuning and building dynamic query systems.

**Key Interview Points:**
- Expression<Func<T, bool>> is data; Func<T, bool> is executable code
- Expression Trees enable IQueryable translation to SQL
- AsNoTracking() for read-only queries (no updates needed)
- Compiled Queries cache execution plans for repeated queries
- Dynamic LINQ requires Expression Tree manipulation

**Coding Example:**
```csharp
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

// EXPRESSION TREES vs DELEGATES
public class ExpressionTreesExample
{
    public void DemonstrateExpressionVsDelegate()
    {
        // Delegate (Func) - executable code
        Func<int, bool> funcDelegate = x => x > 5;
        bool result1 = funcDelegate(10); // Executes immediately
        
        // Expression Tree - code as data
        Expression<Func<int, bool>> expression = x => x > 5;
        
        // Can inspect the expression tree
        Console.WriteLine($"Expression Body: {expression.Body}");
        Console.WriteLine($"Expression Type: {expression.Body.NodeType}");
        
        // Compile and execute
        Func<int, bool> compiled = expression.Compile();
        bool result2 = compiled(10);
    }
    
    // Building Expression Trees dynamically
    public Expression<Func<Product, bool>> BuildDynamicPredicate(string propertyName, object value)
    {
        // Parameter: x =>
        var parameter = Expression.Parameter(typeof(Product), "x");
        
        // Property access: x.PropertyName
        var property = Expression.Property(parameter, propertyName);
        
        // Constant: value
        var constant = Expression.Constant(value);
        
        // Comparison: x.PropertyName == value
        var equality = Expression.Equal(property, constant);
        
        // Lambda: x => x.PropertyName == value
        return Expression.Lambda<Func<Product, bool>>(equality, parameter);
    }
    
    public void UseDynamicPredicate()
    {
        using var context = new ApplicationDbContext();
        
        // Build predicate at runtime
        var predicate = BuildDynamicPredicate("Name", "Laptop");
        
        // Use in query (translates to SQL)
        var products = context.Products.Where(predicate).ToList();
        // SQL: SELECT * FROM Products WHERE Name = 'Laptop'
    }
}

// EXPRESSION TREE MANIPULATION
public class DynamicQueryBuilder
{
    // Combine multiple predicates with AND
    public Expression<Func<T, bool>> And<T>(
        Expression<Func<T, bool>> expr1,
        Expression<Func<T, bool>> expr2)
    {
        var parameter = Expression.Parameter(typeof(T));
        
        var leftVisitor = new ReplaceParameterVisitor(expr1.Parameters[0], parameter);
        var left = leftVisitor.Visit(expr1.Body);
        
        var rightVisitor = new ReplaceParameterVisitor(expr2.Parameters[0], parameter);
        var right = rightVisitor.Visit(expr2.Body);
        
        return Expression.Lambda<Func<T, bool>>(
            Expression.AndAlso(left, right),
            parameter);
    }
    
    // Usage: Dynamic filtering
    public List<Product> FilterProducts(decimal? minPrice, decimal? maxPrice, string category)
    {
        using var context = new ApplicationDbContext();
        
        // Start with always-true predicate
        Expression<Func<Product, bool>> predicate = p => true;
        
        // Add filters dynamically
        if (minPrice.HasValue)
        {
            Expression<Func<Product, bool>> minPricePredicate = p => p.Price >= minPrice.Value;
            predicate = And(predicate, minPricePredicate);
        }
        
        if (maxPrice.HasValue)
        {
            Expression<Func<Product, bool>> maxPricePredicate = p => p.Price <= maxPrice.Value;
            predicate = And(predicate, maxPricePredicate);
        }
        
        if (!string.IsNullOrEmpty(category))
        {
            Expression<Func<Product, bool>> categoryPredicate = p => p.Category == category;
            predicate = And(predicate, categoryPredicate);
        }
        
        return context.Products.Where(predicate).ToList();
        // Translates to SQL with WHERE clause
    }
}

// Expression visitor for parameter replacement
public class ReplaceParameterVisitor : ExpressionVisitor
{
    private readonly ParameterExpression _oldParameter;
    private readonly ParameterExpression _newParameter;
    
    public ReplaceParameterVisitor(ParameterExpression oldParameter, ParameterExpression newParameter)
    {
        _oldParameter = oldParameter;
        _newParameter = newParameter;
    }
    
    protected override Expression VisitParameter(ParameterExpression node)
    {
        return node == _oldParameter ? _newParameter : base.VisitParameter(node);
    }
}

// ASNOTRACKING FOR READ-ONLY QUERIES
public class AsNoTrackingExample
{
    public void DemonstrateTracking()
    {
        using var context = new ApplicationDbContext();
        
        // WITH TRACKING (default)
        var productsTracked = context.Products.ToList();
        // EF Core tracks all entities in ChangeTracker
        // Memory overhead for change detection
        // Slower query execution
        
        Console.WriteLine($"Tracked entities: {context.ChangeTracker.Entries().Count()}");
        
        // WITHOUT TRACKING (read-only)
        var productsUntracked = context.Products.AsNoTracking().ToList();
        // No change tracking
        // 30-40% faster
        // Lower memory usage
        
        Console.WriteLine($"Tracked entities: {context.ChangeTracker.Entries().Count()}"); // Still same count
    }
    
    // Read-only queries should always use AsNoTracking
    public async Task<List<ProductDto>> GetProductsForDisplayAsync()
    {
        using var context = new ApplicationDbContext();
        
        return await context.Products
            .AsNoTracking() // No updates needed
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            })
            .ToListAsync();
    }
    
    // Update scenario - tracking needed
    public async Task UpdateProductPriceAsync(int productId, decimal newPrice)
    {
        using var context = new ApplicationDbContext();
        
        // WITH tracking (required for updates)
        var product = await context.Products.FindAsync(productId);
        product.Price = newPrice;
        
        await context.SaveChangesAsync(); // Detects changes and updates
    }
}

// PERFORMANCE COMPARISON: Tracking vs NoTracking
[MemoryDiagnoser]
public class TrackingPerformanceBenchmark
{
    private ApplicationDbContext _context;
    
    [GlobalSetup]
    public void Setup()
    {
        _context = new ApplicationDbContext();
    }
    
    [Benchmark(Baseline = true)]
    public List<Product> WithTracking()
    {
        return _context.Products.ToList();
    }
    
    [Benchmark]
    public List<Product> WithoutTracking()
    {
        return _context.Products.AsNoTracking().ToList();
    }
    
    // Results (10,000 records):
    // WithTracking:    120 ms, 15 MB allocated
    // WithoutTracking:  80 ms,  8 MB allocated (33% faster)
}

// COMPILED QUERIES
public class CompiledQueriesExample
{
    // Query compiled once, reused multiple times
    private static readonly Func<ApplicationDbContext, int, Product> _getProductById =
        EF.CompileQuery((ApplicationDbContext context, int id) =>
            context.Products.FirstOrDefault(p => p.Id == id));
    
    private static readonly Func<ApplicationDbContext, string, IEnumerable<Product>> _getProductsByCategory =
        EF.CompileQuery((ApplicationDbContext context, string category) =>
            context.Products.Where(p => p.Category == category));
    
    public Product GetProductById(int id)
    {
        using var context = new ApplicationDbContext();
        return _getProductById(context, id);
        // Query plan cached, no recompilation
    }
    
    public List<Product> GetProductsByCategory(string category)
    {
        using var context = new ApplicationDbContext();
        return _getProductsByCategory(context, category).ToList();
    }
}

// COMPILED QUERIES PERFORMANCE
[MemoryDiagnoser]
public class CompiledQueryBenchmark
{
    private ApplicationDbContext _context;
    
    private static readonly Func<ApplicationDbContext, int, Product> _compiledQuery =
        EF.CompileQuery((ApplicationDbContext context, int id) =>
            context.Products.FirstOrDefault(p => p.Id == id));
    
    [GlobalSetup]
    public void Setup()
    {
        _context = new ApplicationDbContext();
    }
    
    [Benchmark(Baseline = true)]
    public Product RegularQuery()
    {
        return _context.Products.FirstOrDefault(p => p.Id == 1);
        // Query compiled every time
    }
    
    [Benchmark]
    public Product CompiledQuery()
    {
        return _compiledQuery(_context, 1);
        // Query compiled once
    }
    
    // Results (1000 iterations):
    // RegularQuery:   1200 ms
    // CompiledQuery:   800 ms (33% faster)
}

// IQUERYABLE vs IENUMERABLE
public class QueryableVsEnumerableExample
{
    public void DemonstrateQueryableTranslation()
    {
        using var context = new ApplicationDbContext();
        
        // IQueryable - translates to SQL (GOOD)
        IQueryable<Product> queryable = context.Products;
        var expensiveProducts = queryable
            .Where(p => p.Price > 100) // Translated to SQL WHERE
            .Take(10);                  // Translated to SQL TOP 10
        
        // SQL: SELECT TOP 10 * FROM Products WHERE Price > 100
        
        // IEnumerable - executes in memory (BAD)
        IEnumerable<Product> enumerable = context.Products.AsEnumerable();
        var expensiveProductsMemory = enumerable
            .Where(p => p.Price > 100) // ALL products loaded into memory first!
            .Take(10);
        
        // SQL: SELECT * FROM Products (loads everything!)
        // Then filters in C#
    }
}

// EXPRESSION TREE USAGE IN SPECIFICATIONS
public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
}

public class ProductsByCategorySpec : ISpecification<Product>
{
    public ProductsByCategorySpec(string category)
    {
        Criteria = p => p.Category == category;
    }
    
    public Expression<Func<Product, bool>> Criteria { get; }
    public List<Expression<Func<Product, object>>> Includes { get; } = new();
}

public static class SpecificationExtensions
{
    public static IQueryable<T> ApplySpecification<T>(
        this IQueryable<T> query,
        ISpecification<T> spec) where T : class
    {
        if (spec.Criteria != null)
            query = query.Where(spec.Criteria); // Expression Tree applied
        
        query = spec.Includes.Aggregate(query, (current, include) =>
            current.Include(include));
        
        return query;
    }
}

// Usage
public class SpecificationUsage
{
    public List<Product> GetProducts(string category)
    {
        using var context = new ApplicationDbContext();
        
        var spec = new ProductsByCategorySpec(category);
        return context.Products
            .ApplySpecification(spec)
            .AsNoTracking()
            .ToList();
    }
}

// DYNAMIC SORTING WITH EXPRESSION TREES
public class DynamicSorting
{
    public IQueryable<T> ApplySort<T>(IQueryable<T> query, string sortBy, bool descending)
    {
        if (string.IsNullOrEmpty(sortBy))
            return query;
        
        var parameter = Expression.Parameter(typeof(T), "x");
        var property = Expression.Property(parameter, sortBy);
        var lambda = Expression.Lambda(property, parameter);
        
        var methodName = descending ? "OrderByDescending" : "OrderBy";
        
        var resultExpression = Expression.Call(
            typeof(Queryable),
            methodName,
            new Type[] { typeof(T), property.Type },
            query.Expression,
            Expression.Quote(lambda));
        
        return query.Provider.CreateQuery<T>(resultExpression);
    }
    
    public List<Product> GetSortedProducts(string sortBy, bool descending)
    {
        using var context = new ApplicationDbContext();
        
        var query = context.Products.AsQueryable();
        query = ApplySort(query, sortBy, descending);
        
        return query.ToList();
        // Translates to SQL: ORDER BY [sortBy] ASC/DESC
    }
}

// PROJECTION PERFORMANCE
public class ProjectionExample
{
    // BAD: Load entire entity
    public List<Product> GetAllProducts()
    {
        using var context = new ApplicationDbContext();
        return context.Products.ToList();
        // Loads ALL columns
    }
    
    // GOOD: Project to DTO (select only needed columns)
    public List<ProductDto> GetProductDtos()
    {
        using var context = new ApplicationDbContext();
        return context.Products
            .AsNoTracking()
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
                // Only 3 columns selected
            })
            .ToList();
        // SQL: SELECT Id, Name, Price FROM Products
    }
}

// Supporting types
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public int StockQuantity { get; set; }
}

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=TestDb");
    }
}

// Guidelines
public class LinqAdvancedGuidelines
{
    /*
     * EXPRESSION TREES:
     * - Code as data (Expression<Func<T, bool>>)
     * - Enables IQueryable translation to SQL
     * - Used for dynamic queries
     * - Can be inspected and modified
     * - Required for LINQ providers (EF Core)
     * 
     * ASNOTRACKING():
     * - Use for ALL read-only queries
     * - 30-40% performance improvement
     * - Lower memory usage
     * - Required for projections/DTOs
     * - Don't use when updating entities
     * 
     * COMPILED QUERIES:
     * - Cache query execution plan
     * - Use for frequently executed queries
     * - Significant performance gain
     * - Pre-.NET Core 2.0 had more impact
     * - EF Core has automatic query caching
     * 
     * IQUERYABLE vs IENUMERABLE:
     * - IQueryable: SQL translation (database)
     * - IEnumerable: In-memory processing
     * - Keep IQueryable as long as possible
     * - Don't use .AsEnumerable() prematurely
     * 
     * BEST PRACTICES:
     * 1. Use AsNoTracking() for read-only queries
     * 2. Project to DTOs with Select()
     * 3. Build dynamic queries with Expression Trees
     * 4. Keep IQueryable (don't materialize early)
     * 5. Use compiled queries for hot paths
     * 6. Avoid N+1 queries (use Include/projection)
     * 7. Monitor generated SQL
     * 8. Benchmark performance improvements
     */
}
```

---

### Question 37: Explain Entity Framework Core relationships and navigation properties. How do you handle circular references?

**Short Theory:**  
EF Core supports One-to-One, One-to-Many, and Many-to-Many relationships via navigation properties. Navigation properties enable object graph traversal without explicit joins. Circular references occur when related entities reference each other (Order → Customer → Orders). Solutions include DTOs (map to flat structures), JsonIgnore attributes, ReferenceHandler.Preserve, or configuring serialization to ignore cycles. Lazy loading can cause N+1 queries; prefer eager loading (Include) or explicit loading.

**Why do we use it?**  
Navigation properties provide intuitive object-oriented access to related data. However, they can cause performance issues (N+1 queries with lazy loading) and serialization problems (circular references break JSON serialization). Understanding relationships is critical for database design and query optimization. Circular reference handling is essential for APIs—without it, serialization throws exceptions. Knowing Include vs Select optimization prevents loading unnecessary data.

**Key Interview Points:**
- One-to-Many: ICollection<T> navigation property
- Many-to-Many: EF Core 5+ supports without join entity
- Circular references break JSON serialization
- Solutions: DTOs, [JsonIgnore], ReferenceHandler.Preserve
- Include for eager loading; Select for projection (better performance)

**Coding Example:**
```csharp
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

// ONE-TO-MANY RELATIONSHIP
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    // Navigation property (one customer has many orders)
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    
    // Foreign key
    public int CustomerId { get; set; }
    
    // Navigation property (many orders belong to one customer)
    public Customer Customer { get; set; }
}

// ONE-TO-ONE RELATIONSHIP
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    
    // Navigation property (one user has one profile)
    public UserProfile Profile { get; set; }
}

public class UserProfile
{
    public int Id { get; set; }
    public string Bio { get; set; }
    public string Avatar { get; set; }
    
    // Foreign key (same as primary key)
    public int UserId { get; set; }
    
    // Navigation property
    public User User { get; set; }
}

// MANY-TO-MANY RELATIONSHIP (EF Core 5+)
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Navigation property (many students have many courses)
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    
    // Navigation property (many courses have many students)
    public ICollection<Student> Students { get; set; } = new List<Student>();
}

// DbContext configuration
public class SchoolDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // One-to-Many configuration
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
        
        // One-to-One configuration
        modelBuilder.Entity<UserProfile>()
            .HasOne(p => p.User)
            .WithOne(u => u.Profile)
            .HasForeignKey<UserProfile>(p => p.UserId);
        
        // Many-to-Many configuration (EF Core 5+)
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Courses)
            .WithMany(c => c.Students)
            .UsingEntity(j => j.ToTable("StudentCourses")); // Optional: specify join table name
    }
}

// CIRCULAR REFERENCE PROBLEM
public class CircularReferenceDemo
{
    public void DemonstrateCircularReference()
    {
        using var context = new SchoolDbContext();
        
        // Load customer with orders
        var customer = context.Customers
            .Include(c => c.Orders)
            .FirstOrDefault();
        
        // Try to serialize
        try
        {
            var json = System.Text.Json.JsonSerializer.Serialize(customer);
            // Throws: JsonException: A possible object cycle was detected
            // Customer → Orders → Order.Customer → Orders → ...
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Circular reference error: {ex.Message}");
        }
    }
}

// SOLUTION 1: DTOs (RECOMMENDED)
public class CustomerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<OrderDto> Orders { get; set; }
}

public class OrderDto
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    // No Customer navigation property (breaks cycle)
}

public class CustomerService
{
    public CustomerDto GetCustomer(int id)
    {
        using var context = new SchoolDbContext();
        
        return context.Customers
            .Where(c => c.Id == id)
            .Select(c => new CustomerDto
            {
                Id = c.Id,
                Name = c.Name,
                Orders = c.Orders.Select(o => new OrderDto
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    Total = o.Total
                }).ToList()
            })
            .FirstOrDefault();
        
        // No circular reference, safe to serialize
    }
}

// SOLUTION 2: [JsonIgnore] Attribute
public class CustomerWithJsonIgnore
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<OrderWithJsonIgnore> Orders { get; set; }
}

public class OrderWithJsonIgnore
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    public int CustomerId { get; set; }
    
    // Ignore this property during serialization
    [JsonIgnore]
    public CustomerWithJsonIgnore Customer { get; set; }
}

// SOLUTION 3: ReferenceHandler.Preserve
public class ReferenceHandlerExample
{
    public string SerializeWithReferenceHandler()
    {
        using var context = new SchoolDbContext();
        
        var customer = context.Customers
            .Include(c => c.Orders)
            .FirstOrDefault();
        
        var options = new System.Text.Json.JsonSerializerOptions
        {
            ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve,
            WriteIndented = true
        };
        
        return System.Text.Json.JsonSerializer.Serialize(customer, options);
        
        // Output includes $id and $ref metadata
        // {
        //   "$id": "1",
        //   "Id": 1,
        //   "Name": "John",
        //   "Orders": [
        //     {
        //       "$id": "2",
        //       "Customer": { "$ref": "1" }
        //     }
        //   ]
        // }
    }
}

// SOLUTION 4: ReferenceHandler.IgnoreCycles (.NET 6+)
public class IgnoreCyclesExample
{
    public string SerializeIgnoringCycles()
    {
        using var context = new SchoolDbContext();
        
        var customer = context.Customers
            .Include(c => c.Orders)
            .FirstOrDefault();
        
        var options = new System.Text.Json.JsonSerializerOptions
        {
            ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles,
            WriteIndented = true
        };
        
        return System.Text.Json.JsonSerializer.Serialize(customer, options);
        
        // Cycles are replaced with null
        // {
        //   "Id": 1,
        //   "Name": "John",
        //   "Orders": [
        //     {
        //       "Id": 1,
        //       "Customer": null  // Cycle ignored
        //     }
        //   ]
        // }
    }
}

// EAGER LOADING vs LAZY LOADING vs EXPLICIT LOADING
public class LoadingStrategiesExample
{
    // EAGER LOADING (Include)
    public Customer EagerLoading(int customerId)
    {
        using var context = new SchoolDbContext();
        
        return context.Customers
            .Include(c => c.Orders) // Load orders with customer
            .FirstOrDefault(c => c.Id == customerId);
        
        // Single SQL query with JOIN
        // SELECT * FROM Customers c
        // LEFT JOIN Orders o ON c.Id = o.CustomerId
        // WHERE c.Id = @customerId
    }
    
    // LAZY LOADING (Requires proxies)
    public void LazyLoading(int customerId)
    {
        // Enable lazy loading in DbContext
        // optionsBuilder.UseLazyLoadingProxies();
        
        using var context = new SchoolDbContext();
        
        var customer = context.Customers.FirstOrDefault(c => c.Id == customerId);
        // SQL: SELECT * FROM Customers WHERE Id = @customerId
        
        // Orders loaded when accessed (N+1 query problem!)
        foreach (var order in customer.Orders)
        {
            // SQL: SELECT * FROM Orders WHERE CustomerId = @customerId
            Console.WriteLine(order.Total);
        }
    }
    
    // EXPLICIT LOADING
    public void ExplicitLoading(int customerId)
    {
        using var context = new SchoolDbContext();
        
        var customer = context.Customers.FirstOrDefault(c => c.Id == customerId);
        // SQL: SELECT * FROM Customers WHERE Id = @customerId
        
        // Explicitly load orders
        context.Entry(customer)
            .Collection(c => c.Orders)
            .Load();
        // SQL: SELECT * FROM Orders WHERE CustomerId = @customerId
    }
    
    // PROJECTION (BEST for read-only)
    public List<CustomerDto> ProjectionLoading()
    {
        using var context = new SchoolDbContext();
        
        return context.Customers
            .Select(c => new CustomerDto
            {
                Id = c.Id,
                Name = c.Name,
                Orders = c.Orders.Select(o => new OrderDto
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    Total = o.Total
                }).ToList()
            })
            .ToList();
        
        // Single SQL query with efficient SELECT
        // No tracking overhead
        // No circular reference issues
    }
}

// N+1 QUERY PROBLEM
public class NPlusOneExample
{
    // BAD: N+1 queries
    public void NPlusOneProblem()
    {
        using var context = new SchoolDbContext();
        
        var customers = context.Customers.ToList(); // 1 query
        
        foreach (var customer in customers) // N queries
        {
            // Each access triggers separate query
            var orderCount = customer.Orders.Count; // Query per customer!
        }
        
        // Total: 1 + N queries (if 100 customers = 101 queries!)
    }
    
    // GOOD: Single query with Include
    public void SolutionWithInclude()
    {
        using var context = new SchoolDbContext();
        
        var customers = context.Customers
            .Include(c => c.Orders)
            .ToList(); // 1 query with JOIN
        
        foreach (var customer in customers)
        {
            var orderCount = customer.Orders.Count; // No additional query
        }
        
        // Total: 1 query
    }
}

// MULTIPLE INCLUDES
public class MultipleIncludesExample
{
    public void LoadMultipleLevels()
    {
        using var context = new SchoolDbContext();
        
        // Include multiple levels
        var orders = context.Orders
            .Include(o => o.Customer)
                .ThenInclude(c => c.Orders) // Nested include
            .ToList();
        
        // Include multiple collections
        var customers = context.Customers
            .Include(c => c.Orders)
            .Include(c => c.Profile)
            .ToList();
    }
}

// FILTERED INCLUDE (EF Core 5+)
public class FilteredIncludeExample
{
    public List<Customer> GetCustomersWithRecentOrders()
    {
        using var context = new SchoolDbContext();
        
        var cutoffDate = DateTime.Now.AddMonths(-6);
        
        return context.Customers
            .Include(c => c.Orders.Where(o => o.OrderDate >= cutoffDate)) // Filter related data
            .ToList();
        
        // SQL: Includes WHERE clause in JOIN
    }
}

// AUTOMAPPER FOR DTO MAPPING
public class AutoMapperExample
{
    public void ConfigureAutoMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Customer, CustomerDto>();
            cfg.CreateMap<Order, OrderDto>();
        });
        
        var mapper = config.CreateMapper();
        
        using var context = new SchoolDbContext();
        
        var customer = context.Customers
            .Include(c => c.Orders)
            .FirstOrDefault();
        
        var dto = mapper.Map<CustomerDto>(customer);
        // Automatically maps properties, breaks circular reference
    }
}

// Supporting types
public class MapperConfiguration
{
    public MapperConfiguration(Action<object> configure) { }
    public object CreateMapper() => null;
}

// Guidelines
public class EFCoreRelationshipsGuidelines
{
    /*
     * EF CORE RELATIONSHIPS:
     * 
     * ONE-TO-MANY:
     * - ICollection<T> on "one" side
     * - Single reference on "many" side
     * - Foreign key property
     * 
     * ONE-TO-ONE:
     * - Single reference on both sides
     * - One side has foreign key
     * 
     * MANY-TO-MANY:
     * - ICollection<T> on both sides
     * - EF Core 5+ handles join table automatically
     * 
     * CIRCULAR REFERENCES:
     * Solution 1: DTOs (RECOMMENDED)
     * - Map to flat structures
     * - Breaks circular reference
     * - Better API design
     * 
     * Solution 2: [JsonIgnore]
     * - Quick fix
     * - One-directional navigation
     * 
     * Solution 3: ReferenceHandler
     * - Preserve: Adds $id/$ref metadata
     * - IgnoreCycles: Replaces cycles with null
     * 
     * LOADING STRATEGIES:
     * Eager Loading (Include):
     * + Single query
     * + No N+1 problem
     * - May load unnecessary data
     * 
     * Lazy Loading:
     * + Loads only when accessed
     * - N+1 query problem
     * - Requires proxies
     * 
     * Explicit Loading:
     * + Control when to load
     * - Multiple queries
     * 
     * Projection (Select to DTO):
     * + Best performance
     * + No tracking overhead
     * + No circular references
     * - Requires mapping
     * 
     * BEST PRACTICES:
     * 1. Use DTOs for APIs
     * 2. Prefer projection over Include
     * 3. Avoid lazy loading in production
     * 4. Use AsNoTracking for read-only
     * 5. Monitor generated SQL
     * 6. Use filtered includes when possible
     * 7. Avoid loading entire object graphs
     * 8. Consider using AutoMapper
     */
}
```

---

**Batch 6 Progress: Questions 36-37 completed. Continue with Questions 38-40 next.**

---

### Question 38: Explain Unit Testing best practices. What is AAA pattern and how do you use mocking frameworks?

**Short Theory:**  
Unit tests verify individual components in isolation. AAA pattern (Arrange-Act-Assert) structures tests: Arrange sets up dependencies, Act executes the method, Assert verifies results. Mocking frameworks (Moq, NSubstitute) create test doubles for dependencies. Tests should be FIRST: Fast, Independent, Repeatable, Self-validating, Timely. Avoid testing implementation details—test behavior and outcomes.

**Why do we use it?**  
Unit tests catch regressions early, enable refactoring with confidence, and serve as documentation. Mocking isolates the system under test from external dependencies (databases, APIs). Without proper tests, changes risk breaking functionality. AAA pattern improves test readability. Understanding testing is essential for senior roles—production code requires comprehensive test coverage.

**Key Interview Points:**
- AAA: Arrange (setup), Act (execute), Assert (verify)
- Mock external dependencies to isolate unit under test
- Test behavior, not implementation details
- One assertion per test (or related assertions)
- Tests should be fast (<100ms per test)

**Coding Example:**
```csharp
using Xunit;
using Moq;

// Service to test
public class OrderService
{
    private readonly IOrderRepository _repository;
    private readonly IEmailService _emailService;
    
    public OrderService(IOrderRepository repository, IEmailService emailService)
    {
        _repository = repository;
        _emailService = emailService;
    }
    
    public async Task<bool> PlaceOrderAsync(Order order)
    {
        if (order.Total <= 0)
            return false;
        
        await _repository.SaveAsync(order);
        await _emailService.SendConfirmationAsync(order.CustomerEmail);
        return true;
    }
}

// Unit tests with AAA pattern
public class OrderServiceTests
{
    [Fact]
    public async Task PlaceOrder_ValidOrder_ReturnsTrue()
    {
        // ARRANGE
        var mockRepository = new Mock<IOrderRepository>();
        var mockEmailService = new Mock<IEmailService>();
        var service = new OrderService(mockRepository.Object, mockEmailService.Object);
        var order = new Order { Total = 100, CustomerEmail = "test@test.com" };
        
        // ACT
        var result = await service.PlaceOrderAsync(order);
        
        // ASSERT
        Assert.True(result);
        mockRepository.Verify(r => r.SaveAsync(order), Times.Once);
        mockEmailService.Verify(e => e.SendConfirmationAsync(order.CustomerEmail), Times.Once);
    }
    
    [Fact]
    public async Task PlaceOrder_InvalidTotal_ReturnsFalse()
    {
        // ARRANGE
        var mockRepository = new Mock<IOrderRepository>();
        var mockEmailService = new Mock<IEmailService>();
        var service = new OrderService(mockRepository.Object, mockEmailService.Object);
        var order = new Order { Total = 0 };
        
        // ACT
        var result = await service.PlaceOrderAsync(order);
        
        // ASSERT
        Assert.False(result);
        mockRepository.Verify(r => r.SaveAsync(It.IsAny<Order>()), Times.Never);
    }
}

// Supporting types
public interface IOrderRepository
{
    Task SaveAsync(Order order);
}

public interface IEmailService
{
    Task SendConfirmationAsync(string email);
}

public class Order
{
    public decimal Total { get; set; }
    public string CustomerEmail { get; set; }
}
```

---

### Question 39: What is Test-Driven Development (TDD)? Explain the Red-Green-Refactor cycle.

**Short Theory:**  
TDD is a development approach where tests are written before implementation. The cycle: Red (write failing test), Green (write minimal code to pass), Refactor (improve code without breaking tests). TDD ensures testability, prevents over-engineering, and provides immediate feedback. It's controversial—some find it slow initially but beneficial long-term. TDD works best for business logic, less so for UI or exploratory code.

**Why do we use it?**  
TDD forces clear requirements before coding and ensures all code has test coverage. It catches bugs earlier (during development, not QA). Tests serve as living documentation and enable fearless refactoring. However, TDD requires discipline and can slow initial development. It's valuable for critical business logic and APIs where correctness is paramount.

**Key Interview Points:**
- Red-Green-Refactor: fail → pass → improve
- Write test first, then minimal implementation
- Refactor with confidence (tests catch regressions)
- Not suitable for all scenarios (UI, prototypes)
- Enforces SOLID principles and testable design

**Coding Example:**
```csharp
// TDD Example: String Calculator Kata

// RED: Write failing test
public class StringCalculatorTests
{
    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("");
        Assert.Equal(0, result);
    }
}

// GREEN: Minimal implementation to pass
public class StringCalculator
{
    public int Add(string numbers)
    {
        return 0; // Simplest code to pass test
    }
}

// RED: Next test
[Fact]
public void Add_SingleNumber_ReturnsNumber()
{
    var calculator = new StringCalculator();
    var result = calculator.Add("5");
    Assert.Equal(5, result);
}

// GREEN: Implement
public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;
        
        return int.Parse(numbers);
    }
}

// RED: Next test (two numbers)
[Fact]
public void Add_TwoNumbers_ReturnsSum()
{
    var calculator = new StringCalculator();
    var result = calculator.Add("1,2");
    Assert.Equal(3, result);
}

// GREEN: Implement
public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;
        
        var parts = numbers.Split(',');
        return parts.Sum(p => int.Parse(p));
    }
}

// REFACTOR: Clean up code (tests still pass)
public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;
        
        return numbers
            .Split(',')
            .Select(int.Parse)
            .Sum();
    }
}
```

---

### Question 40: Explain async/await best practices and common pitfalls. What is ConfigureAwait(false)?

**Short Theory:**  
async/await enables non-blocking asynchronous programming. Best practices: always await or return Task, use async all the way up, avoid async void (except event handlers), don't block with .Result/.Wait(). ConfigureAwait(false) prevents capturing SynchronizationContext—essential in library code to avoid deadlocks and improve performance. Common pitfalls: async void, blocking calls causing deadlocks, not awaiting Tasks.

**Why do we use it?**  
async/await improves scalability by freeing threads during I/O operations. Server applications handle more concurrent requests without additional threads. ConfigureAwait(false) is critical for libraries—without it, continuations capture context causing performance issues and potential deadlocks. Understanding async is mandatory for modern C# development.

**Key Interview Points:**
- Always return Task, not void (except event handlers)
- Use ConfigureAwait(false) in library code
- Don't block async code with .Result or .Wait()
- async void causes unhandled exceptions
- Async all the way—no mixing sync and async

**Coding Example:**
```csharp
// GOOD PRACTICES
public class AsyncBestPractices
{
    // Good: Async all the way
    public async Task<string> GetDataAsync()
    {
        var result = await _httpClient.GetStringAsync("https://api.example.com/data");
        return result;
    }
    
    // Good: ConfigureAwait(false) in library code
    public async Task<string> LibraryMethodAsync()
    {
        var data = await FetchDataAsync().ConfigureAwait(false);
        // No need to resume on original context
        return data.ToUpper();
    }
}

// COMMON PITFALLS
public class AsyncPitfalls
{
    // BAD: async void (unhandled exceptions crash app)
    public async void BadMethod() // ❌ Don't do this
    {
        await Task.Delay(100);
        throw new Exception("This crashes the app!");
    }
    
    // GOOD: async Task
    public async Task GoodMethod()
    {
        await Task.Delay(100);
        // Exceptions can be caught by caller
    }
    
    // BAD: Blocking async with .Result (causes deadlock)
    public string DeadlockExample()
    {
        return GetDataAsync().Result; // ❌ Deadlock in UI/ASP.NET contexts
    }
    
    // GOOD: Async all the way
    public async Task<string> ProperAsync()
    {
        return await GetDataAsync(); // ✅ No blocking
    }
    
    private readonly HttpClient _httpClient = new HttpClient();
    private async Task<string> GetDataAsync() => await _httpClient.GetStringAsync("url");
    private async Task<string> FetchDataAsync() => await Task.FromResult("data");
}

// ConfigureAwait explanation
public class ConfigureAwaitExample
{
    // Library code: Always use ConfigureAwait(false)
    public async Task<int> LibraryMethod()
    {
        await Task.Delay(1000).ConfigureAwait(false);
        // Continuation doesn't need original context
        return 42;
    }
    
    // UI code: Don't use ConfigureAwait(false) if updating UI
    public async Task ButtonClickAsync()
    {
        await Task.Delay(1000); // Need UI context to update controls
        _textBox.Text = "Done"; // Runs on UI thread
    }
}
```

---

**Batch 6 completed (Questions 36-40). Continue with next batch.**

---

## Batch 7: ASP.NET Core Advanced Topics (Questions 41-45)

### Question 41: Explain ASP.NET Core Middleware pipeline. How do you create custom middleware?

**Short Theory:**  
Middleware are components that handle HTTP requests/responses in a pipeline. Each middleware can process the request, call next middleware, and process the response. Order matters—authentication before authorization, exception handling first. Use `app.Use()` for inline, `app.UseMiddleware<T>()` for class-based. Middleware runs for every request, so performance is critical.

**Why do we use it?**  
Middleware enables cross-cutting concerns like logging, authentication, error handling without cluttering controllers. The pipeline is flexible and composable. Custom middleware handles specific requirements (request throttling, custom headers, telemetry). Understanding middleware is essential for ASP.NET Core architecture.

**Key Interview Points:**
- Pipeline executes in order: request → middleware chain → response
- `next()` calls next middleware; not calling it short-circuits
- Order matters: exception handling → CORS → auth → routing → endpoints
- Two forms: inline (`Use`) and class-based (`UseMiddleware`)
- Middleware is singleton—avoid storing per-request state in fields

**Coding Example:**
```csharp
// Custom middleware class
public class RequestTimingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestTimingMiddleware> _logger;
    
    public RequestTimingMiddleware(RequestDelegate next, ILogger<RequestTimingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        var sw = Stopwatch.StartNew();
        
        // Before next middleware
        _logger.LogInformation($"Request started: {context.Request.Path}");
        
        await _next(context); // Call next middleware
        
        // After next middleware (response)
        sw.Stop();
        _logger.LogInformation($"Request completed in {sw.ElapsedMilliseconds}ms");
    }
}

// Register in Program.cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware order is critical
app.UseExceptionHandler("/error"); // First: catch exceptions
app.UseHttpsRedirection();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<RequestTimingMiddleware>(); // Custom middleware
app.MapControllers();

app.Run();

// Extension method for cleaner registration
public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseRequestTiming(this IApplicationBuilder app)
    {
        return app.UseMiddleware<RequestTimingMiddleware>();
    }
}

// Usage: app.UseRequestTiming();
```

---

### Question 42: Explain Dependency Injection lifetimes in ASP.NET Core. When to use Transient, Scoped, Singleton?

**Short Theory:**  
DI lifetimes control service instance creation: **Transient** (new instance per request), **Scoped** (one instance per HTTP request), **Singleton** (one instance for application lifetime). Transient for lightweight stateless services, Scoped for EF DbContext and per-request state, Singleton for expensive objects and thread-safe services. Captive dependency occurs when longer-lived service depends on shorter-lived one—causes bugs.

**Why do we use it?**  
Choosing correct lifetime prevents memory leaks, threading issues, and stale data. DbContext must be Scoped—Singleton causes threading issues, Transient hurts performance. Singleton services must be thread-safe. Captive dependencies (e.g., Singleton depending on Scoped) cause serious bugs. This is a critical architectural decision.

**Key Interview Points:**
- **Transient**: New instance every time (ILogger, stateless services)
- **Scoped**: One instance per request (DbContext, UnitOfWork)
- **Singleton**: One instance for app lifetime (Configuration, caches)
- Avoid captive dependencies (longer lifetime → shorter lifetime)
- Singletons must be thread-safe

**Coding Example:**
```csharp
// Service registrations
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        // Transient: New instance every time
        builder.Services.AddTransient<IEmailService, EmailService>();
        
        // Scoped: One per HTTP request
        builder.Services.AddScoped<IOrderService, OrderService>();
        builder.Services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(connectionString)); // DbContext is Scoped by default
        
        // Singleton: One for entire app lifetime
        builder.Services.AddSingleton<ICacheService, MemoryCacheService>();
        
        var app = builder.Build();
        app.MapControllers();
        app.Run();
    }
}

// Example services
public interface IEmailService { Task SendAsync(string to, string body); }
public class EmailService : IEmailService
{
    // Transient: Lightweight, stateless
    public async Task SendAsync(string to, string body)
    {
        await Task.CompletedTask; // Send email
    }
}

public class OrderService : IOrderService
{
    private readonly AppDbContext _context; // Scoped dependency
    
    public OrderService(AppDbContext context)
    {
        _context = context; // Safe: both are Scoped
    }
    
    public async Task<Order> CreateOrderAsync(Order order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        return order;
    }
}

// ANTI-PATTERN: Captive Dependency
public class BadSingletonService // Singleton
{
    private readonly AppDbContext _context; // ❌ Scoped service in Singleton!
    
    // This causes threading issues and stale data
    public BadSingletonService(AppDbContext context)
    {
        _context = context; // NEVER do this
    }
}

// CORRECT: Use IServiceProvider for shorter-lived dependencies
public class GoodSingletonService
{
    private readonly IServiceProvider _serviceProvider;
    
    public GoodSingletonService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public async Task ProcessAsync()
    {
        using var scope = _serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        // Use context safely within scope
    }
}
```

---

### Question 43: How do you implement API versioning in ASP.NET Core?

**Short Theory:**  
API versioning maintains backward compatibility while evolving APIs. Common strategies: **URL versioning** (`/api/v1/products`), **Query string** (`/api/products?api-version=1.0`), **Header versioning** (`Api-Version: 1.0`), **Media type** (`Accept: application/vnd.api.v1+json`). Use `Microsoft.AspNetCore.Mvc.Versioning` package. Deprecation policies inform clients about sunset dates.

**Why do we use it?**  
APIs evolve—breaking changes break clients. Versioning allows gradual migration. URL versioning is most visible, header versioning is cleanest. Versioning strategy should be documented in API guidelines. Essential for public APIs and microservices communication.

**Key Interview Points:**
- URL versioning: Most common, visible in Swagger
- Query string: Backward compatible with existing URLs
- Header versioning: Clean URLs, harder to test
- Support multiple versions simultaneously
- Use deprecation headers for sunset warnings

**Coding Example:**
```csharp
// Install: Microsoft.AspNetCore.Mvc.Versioning
// Program.cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true; // Adds api-supported-versions header
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-Api-Version")
    );
});

var app = builder.Build();
app.MapControllers();
app.Run();

// Version 1.0 Controller
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ProductsV1Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Version = "1.0", Products = new[] { "Product1", "Product2" } });
    }
}

// Version 2.0 Controller with breaking changes
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class ProductsV2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // New response format in v2.0
        return Ok(new 
        { 
            Version = "2.0", 
            Data = new[] 
            { 
                new { Id = 1, Name = "Product1", Price = 10.99 },
                new { Id = 2, Name = "Product2", Price = 20.99 }
            }
        });
    }
}

// Deprecated version with warning
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0", Deprecated = true)] // Mark as deprecated
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        Response.Headers.Add("X-API-Warn", "This version is deprecated. Migrate to v2.0");
        return Ok(new { Message = "v1.0 - Deprecated" });
    }
}
```

---

### Question 44: Explain JWT authentication in ASP.NET Core. How do you secure APIs with JWT?

**Short Theory:**  
JWT (JSON Web Token) is a stateless authentication mechanism with three parts: Header (algorithm), Payload (claims), Signature (verification). Server issues JWT on login, client includes it in Authorization header (`Bearer <token>`). Server validates signature without database lookup. Use HTTPS, short expiration, refresh tokens, and secure secret keys. JWTs can't be revoked—use short lifetimes.

**Why do we use it?**  
JWTs enable stateless authentication—no server-side session storage. Perfect for microservices and APIs. Scales horizontally since no session state. Contains user claims (roles, permissions). Trade-off: Can't revoke before expiration (use refresh tokens and blacklists for critical scenarios).

**Key Interview Points:**
- Three parts: Header.Payload.Signature (Base64Url encoded)
- Stateless: No database lookup per request
- Include claims (sub, roles, exp, iat)
- Use HTTPS always, secure secret key (min 256 bits)
- Short access token lifetime (5-15 min), refresh tokens for renewal
- Can't revoke—use blacklist or short expiration

**Coding Example:**
```csharp
// Program.cs - JWT configuration
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

// JWT generation service
public class JwtService
{
    private readonly IConfiguration _config;
    
    public JwtService(IConfiguration config) => _config = config;
    
    public string GenerateToken(string userId, string email, string[] roles)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId),
            new Claim(JwtRegisteredClaimNames.Email, email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Role, string.Join(",", roles))
        };
        
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        
        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(15), // Short lifetime
            signingCredentials: creds
        );
        
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

// Login endpoint
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;
    
    public AuthController(JwtService jwtService) => _jwtService = jwtService;
    
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        // Validate credentials (simplified)
        if (request.Email == "user@test.com" && request.Password == "password")
        {
            var token = _jwtService.GenerateToken("123", request.Email, new[] { "Admin" });
            return Ok(new { Token = token });
        }
        
        return Unauthorized();
    }
}

// Protected endpoint
[ApiController]
[Route("api/[controller]")]
[Authorize] // Requires valid JWT
public class SecureController : ControllerBase
{
    [HttpGet]
    [Authorize(Roles = "Admin")] // Role-based authorization
    public IActionResult GetSecureData()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        return Ok(new { Message = "Secure data", UserId = userId });
    }
}

public record LoginRequest(string Email, string Password);
```

---

### Question 45: What is gRPC? How does it differ from REST APIs?

**Short Theory:**  
gRPC is a high-performance RPC framework using HTTP/2 and Protocol Buffers (binary serialization). Compared to REST: gRPC is faster (binary vs JSON), supports bidirectional streaming, has code generation from .proto files, but less human-readable. REST is easier to debug, widely supported, browser-friendly. Use gRPC for microservice-to-microservice communication, REST for public APIs.

**Why do we use it?**  
gRPC offers 5-10x better performance than REST for inter-service communication. HTTP/2 enables multiplexing, server push, and header compression. Strongly-typed contracts prevent versioning issues. Streaming supports real-time scenarios. Trade-off: harder to debug, requires HTTP/2, not browser-native (needs gRPC-Web). Ideal for internal microservices.

**Key Interview Points:**
- gRPC: Binary (Protobuf), HTTP/2, streaming, code generation
- REST: JSON, HTTP/1.1, stateless, human-readable
- gRPC is faster (5-10x) but harder to debug
- gRPC streaming: Unary, Server, Client, Bidirectional
- Use gRPC internally, REST for public APIs

**Coding Example:**
```csharp
// 1. Define .proto file (greeter.proto)
syntax = "proto3";
option csharp_namespace = "GrpcDemo";

service Greeter {
  rpc SayHello (HelloRequest) returns (HelloReply);
  rpc SayHelloStream (HelloRequest) returns (stream HelloReply); // Server streaming
}

message HelloRequest {
  string name = 1;
}

message HelloReply {
  string message = 1;
}

// 2. gRPC Service implementation
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    
    public GreeterService(ILogger<GreeterService> logger) => _logger = logger;
    
    // Unary RPC (single request/response)
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        _logger.LogInformation($"Received: {request.Name}");
        return Task.FromResult(new HelloReply { Message = $"Hello {request.Name}" });
    }
    
    // Server streaming RPC
    public override async Task SayHelloStream(HelloRequest request, 
        IServerStreamWriter<HelloReply> responseStream, ServerCallContext context)
    {
        for (int i = 0; i < 5; i++)
        {
            await responseStream.WriteAsync(new HelloReply 
            { 
                Message = $"Hello {request.Name} - Message {i + 1}" 
            });
            await Task.Delay(1000); // Simulate streaming
        }
    }
}

// 3. Program.cs - gRPC server
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();

var app = builder.Build();
app.MapGrpcService<GreeterService>();
app.Run();

// 4. gRPC Client
public class GreeterClient
{
    private readonly Greeter.GreeterClient _client;
    
    public GreeterClient()
    {
        var channel = GrpcChannel.ForAddress("https://localhost:5001");
        _client = new Greeter.GreeterClient(channel);
    }
    
    public async Task CallUnaryAsync()
    {
        var reply = await _client.SayHelloAsync(new HelloRequest { Name = "World" });
        Console.WriteLine($"Response: {reply.Message}");
    }
    
    public async Task CallStreamingAsync()
    {
        using var call = _client.SayHelloStream(new HelloRequest { Name = "Streaming" });
        
        await foreach (var response in call.ResponseStream.ReadAllAsync())
        {
            Console.WriteLine($"Received: {response.Message}");
        }
    }
}
```

---

**Batch 7 completed (Questions 41-45). Continue with next batch.**

---

## Batch 8: Distributed Systems & Architecture Patterns (Questions 46-50)

### Question 46: Explain message queues. When would you use RabbitMQ vs Azure Service Bus vs Kafka?

**Short Theory:**  
Message queues decouple services using async messaging. Producer sends messages, consumer processes them independently. **RabbitMQ**: General-purpose, supports complex routing, AMQP protocol. **Azure Service Bus**: Cloud-native, built-in retry/dead-letter, sessions, managed service. **Kafka**: High-throughput event streaming, log-based, event replay, distributed by design. Use RabbitMQ for complex routing, Service Bus for Azure ecosystem, Kafka for event streaming and analytics.

**Why do we use it?**  
Queues enable async processing, load leveling, and fault tolerance. Services don't fail together—queue buffers messages during outages. Essential for scalable microservices. Without queues, synchronous calls create tight coupling and cascading failures. Message durability ensures no data loss.

**Key Interview Points:**
- Decouple services, enable async processing
- RabbitMQ: Complex routing, exchange types (direct, topic, fanout)
- Service Bus: Cloud-native, sessions, duplicate detection, managed
- Kafka: Event streaming, high throughput, replay capability
- Patterns: Publish-Subscribe, Point-to-Point, Competing Consumers

**Coding Example:**
```csharp
// RabbitMQ Example with MassTransit
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        // Configure RabbitMQ with MassTransit
        builder.Services.AddMassTransit(x =>
        {
            x.AddConsumer<OrderCreatedConsumer>();
            
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("rabbitmq://localhost", h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });
                
                cfg.ReceiveEndpoint("order-queue", e =>
                {
                    e.ConfigureConsumer<OrderCreatedConsumer>(context);
                });
            });
        });
        
        var app = builder.Build();
        app.MapControllers();
        app.Run();
    }
}

// Message contract
public record OrderCreatedEvent(int OrderId, decimal Total, DateTime CreatedAt);

// Producer
public class OrderService
{
    private readonly IPublishEndpoint _publishEndpoint;
    
    public OrderService(IPublishEndpoint publishEndpoint) => _publishEndpoint = publishEndpoint;
    
    public async Task CreateOrderAsync(Order order)
    {
        // Save order to database
        // ...
        
        // Publish event to queue
        await _publishEndpoint.Publish(new OrderCreatedEvent(
            order.Id, 
            order.Total, 
            DateTime.UtcNow
        ));
    }
}

// Consumer
public class OrderCreatedConsumer : IConsumer<OrderCreatedEvent>
{
    private readonly ILogger<OrderCreatedConsumer> _logger;
    private readonly IEmailService _emailService;
    
    public OrderCreatedConsumer(ILogger<OrderCreatedConsumer> logger, IEmailService emailService)
    {
        _logger = logger;
        _emailService = emailService;
    }
    
    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        var order = context.Message;
        _logger.LogInformation($"Processing order {order.OrderId}");
        
        // Send confirmation email
        await _emailService.SendOrderConfirmationAsync(order.OrderId);
        
        // Message is auto-acknowledged on success
        // Exceptions trigger retry/dead-letter
    }
}

// Supporting types
public class Order { public int Id { get; set; } public decimal Total { get; set; } }
public interface IEmailService { Task SendOrderConfirmationAsync(int orderId); }
```

---

### Question 47: What is CQRS? When should you use it and what are the trade-offs?

**Short Theory:**  
CQRS (Command Query Responsibility Segregation) separates read and write models. Commands mutate state (CreateOrder), Queries return data (GetOrders). Advanced CQRS uses separate databases for reads/writes—write to normalized DB, project to denormalized read DB. Use for complex domains with different read/write patterns. Trade-off: increased complexity, eventual consistency, more code.

**Why do we use it?**  
CQRS optimizes reads and writes independently. Read model can be denormalized for performance, write model stays normalized for consistency. Enables event sourcing, horizontal scaling of reads, and separate security models. Don't use for simple CRUD apps—overhead isn't worth it. Best for complex domains (e-commerce, finance).

**Key Interview Points:**
- Separate models for reads (queries) and writes (commands)
- Commands: Mutate state, return void or ID
- Queries: Return data, never mutate
- Can use separate databases (read DB, write DB)
- Eventual consistency between read/write models
- Use with MediatR for clean implementation

**Coding Example:**
```csharp
// Install: MediatR, MediatR.Extensions.Microsoft.DependencyInjection

// Command (Write)
public record CreateOrderCommand(string CustomerEmail, List<OrderItem> Items) 
    : IRequest<int>;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
{
    private readonly AppDbContext _context;
    private readonly IPublishEndpoint _publishEndpoint;
    
    public CreateOrderCommandHandler(AppDbContext context, IPublishEndpoint publishEndpoint)
    {
        _context = context;
        _publishEndpoint = publishEndpoint;
    }
    
    public async Task<int> Handle(CreateOrderCommand request, CancellationToken ct)
    {
        var order = new Order
        {
            CustomerEmail = request.CustomerEmail,
            Items = request.Items,
            Total = request.Items.Sum(i => i.Price * i.Quantity),
            CreatedAt = DateTime.UtcNow
        };
        
        _context.Orders.Add(order);
        await _context.SaveChangesAsync(ct);
        
        // Publish event for read model update
        await _publishEndpoint.Publish(new OrderCreatedEvent(order.Id, order.Total), ct);
        
        return order.Id;
    }
}

// Query (Read)
public record GetOrderByIdQuery(int OrderId) : IRequest<OrderDto>;

public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
{
    private readonly IOrderReadRepository _readRepo; // Separate read repository
    
    public GetOrderByIdQueryHandler(IOrderReadRepository readRepo) => _readRepo = readRepo;
    
    public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken ct)
    {
        // Query optimized read model (could be different DB)
        return await _readRepo.GetOrderByIdAsync(request.OrderId);
    }
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public OrdersController(IMediator mediator) => _mediator = mediator;
    
    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
    {
        var orderId = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetOrder), new { id = orderId }, null);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        var order = await _mediator.Send(new GetOrderByIdQuery(id));
        return Ok(order);
    }
}

// DTOs
public record OrderDto(int Id, string CustomerEmail, decimal Total, DateTime CreatedAt);
public record OrderItem(string ProductId, int Quantity, decimal Price);
public record OrderCreatedEvent(int OrderId, decimal Total);
```

---

### Question 48: Explain Event Sourcing. How does it differ from traditional state-based persistence?

**Short Theory:**  
Event Sourcing stores all state changes as immutable events instead of current state. To get current state, replay all events. Traditional: Store "Account Balance = $100". Event Sourcing: Store "AccountCreated($0) → Deposited($100) → Withdrawn($50)". Provides complete audit trail, time travel, debugging. Trade-off: complexity, eventual consistency, event versioning, replay performance.

**Why do we use it?**  
Event Sourcing provides perfect audit trail—every state change is recorded. Enables temporal queries ("What was balance on Jan 1?"), debugging (replay events), and event replay for analytics. Essential for financial systems, audit requirements. Downside: can't easily query current state (need snapshots), schema evolution is hard.

**Key Interview Points:**
- Store events, not state (append-only log)
- Rebuild state by replaying events
- Immutable events—never delete or update
- Use snapshots for performance (avoid replaying millions of events)
- Event versioning for schema evolution
- Combine with CQRS for read models

**Coding Example:**
```csharp
// Domain Events
public abstract record DomainEvent(Guid AggregateId, DateTime OccurredAt);
public record AccountCreatedEvent(Guid AggregateId, string Owner, DateTime OccurredAt) 
    : DomainEvent(AggregateId, OccurredAt);
public record MoneyDepositedEvent(Guid AggregateId, decimal Amount, DateTime OccurredAt) 
    : DomainEvent(AggregateId, OccurredAt);
public record MoneyWithdrawnEvent(Guid AggregateId, decimal Amount, DateTime OccurredAt) 
    : DomainEvent(AggregateId, OccurredAt);

// Aggregate (Account)
public class Account
{
    public Guid Id { get; private set; }
    public string Owner { get; private set; }
    public decimal Balance { get; private set; }
    private readonly List<DomainEvent> _uncommittedEvents = new();
    
    // Create new account
    public static Account Create(Guid id, string owner)
    {
        var account = new Account();
        account.Apply(new AccountCreatedEvent(id, owner, DateTime.UtcNow));
        return account;
    }
    
    // Commands
    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Amount must be positive");
        Apply(new MoneyDepositedEvent(Id, amount, DateTime.UtcNow));
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount > Balance) throw new InvalidOperationException("Insufficient funds");
        Apply(new MoneyWithdrawnEvent(Id, amount, DateTime.UtcNow));
    }
    
    // Apply events to change state
    private void Apply(DomainEvent @event)
    {
        When(@event);
        _uncommittedEvents.Add(@event);
    }
    
    private void When(DomainEvent @event)
    {
        switch (@event)
        {
            case AccountCreatedEvent e:
                Id = e.AggregateId;
                Owner = e.Owner;
                Balance = 0;
                break;
            case MoneyDepositedEvent e:
                Balance += e.Amount;
                break;
            case MoneyWithdrawnEvent e:
                Balance -= e.Amount;
                break;
        }
    }
    
    // Rebuild state from events
    public static Account FromEvents(IEnumerable<DomainEvent> events)
    {
        var account = new Account();
        foreach (var @event in events)
        {
            account.When(@event);
        }
        return account;
    }
    
    public IReadOnlyList<DomainEvent> GetUncommittedEvents() => _uncommittedEvents;
}

// Event Store
public class EventStore
{
    private readonly List<DomainEvent> _events = new(); // In-memory for demo
    
    public async Task SaveEventsAsync(Guid aggregateId, IEnumerable<DomainEvent> events)
    {
        _events.AddRange(events);
        await Task.CompletedTask;
    }
    
    public async Task<IEnumerable<DomainEvent>> GetEventsAsync(Guid aggregateId)
    {
        return await Task.FromResult(_events.Where(e => e.AggregateId == aggregateId));
    }
}

// Usage
var account = Account.Create(Guid.NewGuid(), "John Doe");
account.Deposit(100);
account.Withdraw(30);

var eventStore = new EventStore();
await eventStore.SaveEventsAsync(account.Id, account.GetUncommittedEvents());

// Rebuild from events
var events = await eventStore.GetEventsAsync(account.Id);
var rebuiltAccount = Account.FromEvents(events);
Console.WriteLine($"Balance: {rebuiltAccount.Balance}"); // 70
```

---

### Question 49: How do you implement distributed caching with Redis in ASP.NET Core?

**Short Theory:**  
Redis is an in-memory distributed cache supporting strings, lists, sets, hashes. Use `IDistributedCache` abstraction in ASP.NET Core. Cache aside pattern: Check cache → if miss, fetch from DB → store in cache. Set expiration policies (sliding, absolute). Redis supports pub/sub, cache invalidation, distributed locks. Use for session state, API responses, expensive queries.

**Why do we use it?**  
Redis dramatically reduces database load and latency (sub-millisecond reads). Distributed cache shared across multiple servers—scales horizontally. In-memory storage in `IMemoryCache` doesn't work for multi-server deployments. Redis also handles session state in load-balanced environments. Essential for high-traffic applications.

**Key Interview Points:**
- Redis: In-memory, distributed, key-value store
- Use `IDistributedCache` for abstraction
- Cache-aside pattern: Check cache first, fallback to DB
- Set expiration: Sliding (extends on access), Absolute (fixed time)
- Cache invalidation: Time-based, event-based (pub/sub)
- Use for: Session state, API responses, lookup data

**Coding Example:**
```csharp
// Install: Microsoft.Extensions.Caching.StackExchangeRedis

// Program.cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
    options.InstanceName = "MyApp:";
});

builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();
app.MapControllers();
app.Run();

// Service with caching
public class ProductService : IProductService
{
    private readonly IDistributedCache _cache;
    private readonly AppDbContext _context;
    private readonly ILogger<ProductService> _logger;
    
    public ProductService(IDistributedCache cache, AppDbContext context, 
        ILogger<ProductService> logger)
    {
        _cache = cache;
        _context = context;
        _logger = logger;
    }
    
    public async Task<Product> GetProductByIdAsync(int id)
    {
        var cacheKey = $"product:{id}";
        
        // Check cache first
        var cachedProduct = await _cache.GetStringAsync(cacheKey);
        if (cachedProduct != null)
        {
            _logger.LogInformation($"Cache HIT for {cacheKey}");
            return JsonSerializer.Deserialize<Product>(cachedProduct);
        }
        
        // Cache miss - fetch from database
        _logger.LogInformation($"Cache MISS for {cacheKey}");
        var product = await _context.Products.FindAsync(id);
        
        if (product != null)
        {
            // Store in cache with expiration
            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
                SlidingExpiration = TimeSpan.FromMinutes(2)
            };
            
            await _cache.SetStringAsync(cacheKey, 
                JsonSerializer.Serialize(product), 
                options);
        }
        
        return product;
    }
    
    public async Task UpdateProductAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        
        // Invalidate cache
        await _cache.RemoveAsync($"product:{product.Id}");
        _logger.LogInformation($"Cache invalidated for product:{product.Id}");
    }
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    
    public ProductsController(IProductService productService) => _productService = productService;
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);
        return product != null ? Ok(product) : NotFound();
    }
}

public interface IProductService 
{ 
    Task<Product> GetProductByIdAsync(int id);
    Task UpdateProductAsync(Product product);
}
public class Product { public int Id { get; set; } public string Name { get; set; } }
```

---

### Question 50: Explain resilience patterns: Circuit Breaker, Retry, and Timeout with Polly.

**Short Theory:**  
Resilience patterns handle transient failures. **Retry**: Retry failed operations (exponential backoff). **Circuit Breaker**: Stop calling failing service temporarily (prevents cascading failures). **Timeout**: Cancel operations taking too long. **Polly** library implements these patterns. Circuit breaker has states: Closed (normal), Open (failing, reject calls), Half-Open (testing recovery). Combine patterns for robust systems.

**Why do we use it?**  
Distributed systems fail—network issues, service outages, timeouts. Without resilience, one failing service crashes entire system (cascading failure). Circuit breaker prevents hammering failing services. Retry handles transient errors. Timeout prevents thread exhaustion. Essential for microservices and external API calls.

**Key Interview Points:**
- Retry: Exponential backoff, jitter, max attempts
- Circuit Breaker: Closed → Open → Half-Open states
- Timeout: Prevent long-running operations from blocking
- Combine patterns: Timeout + Retry + Circuit Breaker
- Use Polly for clean policy configuration
- Monitor circuit breaker state (metrics/alerts)

**Coding Example:**
```csharp
// Install: Polly, Polly.Extensions.Http

// Program.cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IExternalApiService, ExternalApiService>()
    .AddPolicyHandler(GetRetryPolicy())
    .AddPolicyHandler(GetCircuitBreakerPolicy())
    .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(10)));

var app = builder.Build();
app.MapControllers();
app.Run();

// Retry policy with exponential backoff
static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
{
    return HttpPolicyExtensions
        .HandleTransientHttpError() // 5xx, 408, network failures
        .WaitAndRetryAsync(
            retryCount: 3,
            sleepDurationProvider: retryAttempt => 
                TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), // 2, 4, 8 seconds
            onRetry: (outcome, timespan, retryCount, context) =>
            {
                Console.WriteLine($"Retry {retryCount} after {timespan.TotalSeconds}s");
            });
}

// Circuit breaker policy
static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
{
    return HttpPolicyExtensions
        .HandleTransientHttpError()
        .CircuitBreakerAsync(
            handledEventsAllowedBeforeBreaking: 5, // Open after 5 failures
            durationOfBreak: TimeSpan.FromSeconds(30), // Stay open for 30s
            onBreak: (outcome, timespan) =>
            {
                Console.WriteLine($"Circuit breaker OPEN for {timespan.TotalSeconds}s");
            },
            onReset: () => Console.WriteLine("Circuit breaker CLOSED"),
            onHalfOpen: () => Console.WriteLine("Circuit breaker HALF-OPEN (testing)")
        );
}

// Service using HttpClient with policies
public class ExternalApiService : IExternalApiService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<ExternalApiService> _logger;
    
    public ExternalApiService(HttpClient httpClient, ILogger<ExternalApiService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
    
    public async Task<string> GetDataAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("https://api.example.com/data");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (BrokenCircuitException)
        {
            _logger.LogError("Circuit breaker is OPEN - rejecting call");
            throw;
        }
        catch (TimeoutRejectedException)
        {
            _logger.LogError("Request timed out");
            throw;
        }
    }
}

public interface IExternalApiService { Task<string> GetDataAsync(); }
```

---

**Batch 8 completed (Questions 46-50). Continue with next batch.**

---

## Batch 9: Advanced C# Features & Security (Questions 51-55)

### Question 51: Explain Span<T> and Memory<T>. How do they improve performance?

**Short Theory:**  
`Span<T>` is a stack-only ref struct providing safe access to contiguous memory (arrays, stack, unmanaged memory) without allocations. `Memory<T>` is heap-allocatable and supports async. Use for high-performance scenarios: parsing, string manipulation, buffer operations. Span eliminates string allocations via slicing. Cannot use in async methods (stack-only). ArrayPool + Span = zero-allocation patterns.

**Why do we use it?**  
Traditional string operations create garbage (Substring creates new string). Span enables zero-allocation slicing and manipulation. Critical for high-throughput APIs (parsing requests, serialization). Reduces GC pressure by 50-90% in hot paths. Modern .NET APIs (Stream, UTF8, JSON) support Span. Essential knowledge for performance-critical code.

**Key Interview Points:**
- Span<T>: Stack-only, zero-allocation, contiguous memory view
- Memory<T>: Heap-allocatable, async-compatible
- ReadOnlySpan for immutable views
- Use with ArrayPool for buffer pooling
- Cannot use Span in async methods (use Memory instead)
- Slicing creates views without copying

**Coding Example:**
```csharp
// Traditional approach (allocations)
public class TraditionalParsing
{
    public int[] ParseCsv(string csv)
    {
        var parts = csv.Split(','); // Allocates string array
        var result = new int[parts.Length];
        
        for (int i = 0; i < parts.Length; i++)
        {
            result[i] = int.Parse(parts[i]); // Each part is a new string
        }
        
        return result;
    }
}

// Modern approach with Span (zero-allocation)
public class SpanParsing
{
    public int[] ParseCsv(ReadOnlySpan<char> csv)
    {
        var result = new List<int>();
        
        while (csv.Length > 0)
        {
            int commaIndex = csv.IndexOf(',');
            ReadOnlySpan<char> segment = commaIndex >= 0 
                ? csv.Slice(0, commaIndex) // View, no allocation
                : csv;
            
            result.Add(int.Parse(segment));
            
            csv = commaIndex >= 0 ? csv.Slice(commaIndex + 1) : ReadOnlySpan<char>.Empty;
        }
        
        return result.ToArray();
    }
}

// ArrayPool with Span for buffer reuse
public class BufferPoolExample
{
    public async Task ProcessLargeDataAsync(Stream stream)
    {
        var buffer = ArrayPool<byte>.Shared.Rent(4096); // Rent from pool
        
        try
        {
            int bytesRead;
            while ((bytesRead = await stream.ReadAsync(buffer.AsMemory(0, 4096))) > 0)
            {
                var span = buffer.AsSpan(0, bytesRead); // Zero-allocation view
                ProcessData(span);
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer); // Return to pool
        }
    }
    
    private void ProcessData(ReadOnlySpan<byte> data)
    {
        // Process without allocating
    }
}

// String slicing without allocation
public class StringSpanExample
{
    public bool IsValidEmail(ReadOnlySpan<char> email)
    {
        int atIndex = email.IndexOf('@');
        if (atIndex <= 0) return false;
        
        var localPart = email.Slice(0, atIndex); // No allocation
        var domain = email.Slice(atIndex + 1);   // No allocation
        
        return localPart.Length > 0 && domain.Contains('.', StringComparison.Ordinal);
    }
}
```

---

### Question 52: What is MemoryCache vs DistributedCache? When to use each?

**Short Theory:**  
`IMemoryCache` stores data in-process (RAM), fast but not shared across servers. `IDistributedCache` stores in external cache (Redis, SQL), shared across instances but slower. Use MemoryCache for single-server apps and small datasets. Use DistributedCache for multi-server deployments, session state, and data that must be consistent across instances. Hybrid: L1 (Memory) + L2 (Redis).

**Why do we use it?**  
MemoryCache is 100x faster than Redis but doesn't scale horizontally. In load-balanced environments, MemoryCache causes inconsistencies (each server has different data). DistributedCache ensures consistency but adds network latency. Choose based on deployment model and data consistency requirements.

**Key Interview Points:**
- MemoryCache: In-process, fast, not shared
- DistributedCache: External, slower, shared across servers
- MemoryCache for: Lookups, configuration, single-server
- DistributedCache for: Session, multi-server, consistency
- Hybrid pattern: MemoryCache (L1) + Redis (L2)
- Memory eviction policies: LRU, size limits, expiration

**Coding Example:**
```csharp
// MemoryCache example
public class MemoryCacheService
{
    private readonly IMemoryCache _cache;
    
    public MemoryCacheService(IMemoryCache cache) => _cache = cache;
    
    public async Task<Product> GetProductAsync(int id)
    {
        return await _cache.GetOrCreateAsync($"product:{id}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
            entry.Size = 1; // For size-based eviction
            entry.Priority = CacheItemPriority.High;
            
            // Fetch from database
            return await FetchFromDatabaseAsync(id);
        });
    }
}

// DistributedCache example
public class DistributedCacheService
{
    private readonly IDistributedCache _cache;
    
    public DistributedCacheService(IDistributedCache cache) => _cache = cache;
    
    public async Task<User> GetUserAsync(string userId)
    {
        var cacheKey = $"user:{userId}";
        var cached = await _cache.GetStringAsync(cacheKey);
        
        if (cached != null)
            return JsonSerializer.Deserialize<User>(cached);
        
        var user = await FetchUserFromDbAsync(userId);
        
        await _cache.SetStringAsync(cacheKey, 
            JsonSerializer.Serialize(user),
            new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1)
            });
        
        return user;
    }
    
    private Task<User> FetchUserFromDbAsync(string userId) => Task.FromResult(new User());
}

// Hybrid caching pattern (L1 + L2)
public class HybridCacheService
{
    private readonly IMemoryCache _memoryCache;
    private readonly IDistributedCache _distributedCache;
    
    public HybridCacheService(IMemoryCache memoryCache, IDistributedCache distributedCache)
    {
        _memoryCache = memoryCache;
        _distributedCache = distributedCache;
    }
    
    public async Task<T> GetOrCreateAsync<T>(string key, Func<Task<T>> factory)
    {
        // L1: Check memory cache (fast)
        if (_memoryCache.TryGetValue(key, out T value))
            return value;
        
        // L2: Check distributed cache
        var cached = await _distributedCache.GetStringAsync(key);
        if (cached != null)
        {
            value = JsonSerializer.Deserialize<T>(cached);
            _memoryCache.Set(key, value, TimeSpan.FromMinutes(5)); // Store in L1
            return value;
        }
        
        // Cache miss: Fetch from source
        value = await factory();
        
        // Store in both caches
        await _distributedCache.SetStringAsync(key, JsonSerializer.Serialize(value));
        _memoryCache.Set(key, value, TimeSpan.FromMinutes(5));
        
        return value;
    }
}

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } }
public class User { public string Id { get; set; } public string Name { get; set; } }
Task<Product> FetchFromDatabaseAsync(int id) => Task.FromResult(new Product());
```

---

### Question 53: Explain OWASP Top 10 vulnerabilities. How do you prevent SQL Injection and XSS?

**Short Theory:**  
OWASP Top 10: Injection, Broken Auth, Sensitive Data Exposure, XXE, Broken Access Control, Security Misconfiguration, XSS, Insecure Deserialization, Vulnerable Components, Insufficient Logging. **SQL Injection**: Use parameterized queries/EF Core, never concatenate SQL. **XSS**: Sanitize output, use Content Security Policy, encode HTML. **CSRF**: Use anti-forgery tokens. Validate input, encode output, principle of least privilege.

**Why do we use it?**  
Security vulnerabilities lead to data breaches, financial loss, and reputation damage. SQL Injection allows attackers to read/modify database. XSS executes malicious scripts in user browsers. Senior engineers must understand security—it's not optional. Defense in depth: multiple security layers.

**Key Interview Points:**
- SQL Injection: Use parameterized queries, ORM (EF Core)
- XSS: Encode output, Content Security Policy (CSP)
- CSRF: Anti-forgery tokens in forms
- Broken Auth: Strong passwords, MFA, secure session management
- Always validate input, encode output
- Use HTTPS, secure headers, least privilege

**Coding Example:**
```csharp
// SQL INJECTION PREVENTION

// BAD: Vulnerable to SQL injection
public async Task<User> GetUserBad(string username)
{
    var sql = $"SELECT * FROM Users WHERE Username = '{username}'";
    // Input: ' OR '1'='1 -- (returns all users)
    return await _context.Users.FromSqlRaw(sql).FirstOrDefaultAsync();
}

// GOOD: Parameterized query
public async Task<User> GetUserGood(string username)
{
    return await _context.Users
        .FromSqlInterpolated($"SELECT * FROM Users WHERE Username = {username}")
        .FirstOrDefaultAsync();
    // EF Core automatically parameterizes {username}
}

// BEST: Use LINQ (no raw SQL)
public async Task<User> GetUserBest(string username)
{
    return await _context.Users
        .Where(u => u.Username == username)
        .FirstOrDefaultAsync();
}

// XSS PREVENTION

// BAD: Direct output (XSS vulnerable)
public IActionResult DisplayCommentBad(string comment)
{
    // If comment = "<script>alert('XSS')</script>", script executes
    return Content($"<div>{comment}</div>", "text/html");
}

// GOOD: Razor auto-encodes
// Razor view: <div>@Model.Comment</div>
// Output: &lt;script&gt;alert('XSS')&lt;/script&gt;

// Manual encoding when needed
public string SanitizeHtml(string input)
{
    return System.Net.WebUtility.HtmlEncode(input);
}

// CSRF PREVENTION
[HttpPost]
[ValidateAntiForgeryToken] // Validates CSRF token
public async Task<IActionResult> CreateOrder([FromForm] OrderModel model)
{
    // Token validated by framework
    var order = new Order { /* ... */ };
    await _context.SaveChangesAsync();
    return Ok();
}

// API: Use SameSite cookies
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true; // Prevent JavaScript access
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // HTTPS only
    options.Cookie.SameSite = SameSiteMode.Strict; // CSRF protection
});

// Content Security Policy
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy", 
        "default-src 'self'; script-src 'self'; style-src 'self'");
    await next();
});

// Supporting types
public class User { public string Username { get; set; } }
public class OrderModel { public int ProductId { get; set; } }
public class Order { }
```

---

### Question 54: What are C# Records? When to use Records vs Classes?

**Short Theory:**  
Records (C# 9+) are immutable reference types optimized for data models. Provide value-based equality, with-expressions for non-destructive mutation, deconstruction, and concise syntax. Use records for DTOs, API models, immutable data. Use classes for entities with identity, mutable state, and behavior. Record structs (C# 10) are value types with record features.

**Why do we use it?**  
Records reduce boilerplate for data objects. Value equality (compare by content, not reference) is natural for DTOs. Immutability prevents bugs in concurrent scenarios. With-expressions create modified copies cleanly. Records are perfect for API contracts, events, and functional patterns.

**Key Interview Points:**
- Records: Immutable, value equality, reference type
- Use for: DTOs, API models, events, immutable data
- Classes: Identity-based equality, mutable, behavior-rich
- With-expressions for non-destructive mutation
- Record structs for value type records
- Automatically generated: Equals, GetHashCode, ToString, Deconstruct

**Coding Example:**
```csharp
// Record definition (concise syntax)
public record PersonRecord(string FirstName, string LastName, int Age);

// Equivalent class (verbose)
public class PersonClass
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }
    
    public PersonClass(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    
    // Must manually implement Equals, GetHashCode, ToString, etc.
}

// Value equality
var person1 = new PersonRecord("John", "Doe", 30);
var person2 = new PersonRecord("John", "Doe", 30);

Console.WriteLine(person1 == person2); // True (value equality)

var class1 = new PersonClass("John", "Doe", 30);
var class2 = new PersonClass("John", "Doe", 30);
Console.WriteLine(class1 == class2); // False (reference equality)

// With-expressions (non-destructive mutation)
var john = new PersonRecord("John", "Doe", 30);
var olderJohn = john with { Age = 31 }; // Creates new record
Console.WriteLine(john.Age);      // 30 (original unchanged)
Console.WriteLine(olderJohn.Age); // 31

// Deconstruction
var (firstName, lastName, age) = person1;
Console.WriteLine(firstName); // John

// Record for API DTOs
public record CreateOrderRequest(string CustomerEmail, List<OrderItemDto> Items);
public record OrderItemDto(int ProductId, int Quantity);
public record OrderResponse(int OrderId, decimal Total, DateTime CreatedAt);

// Record for domain events
public record OrderCreatedEvent(int OrderId, string CustomerEmail, decimal Total, DateTime OccurredAt);

// Record struct (value type)
public record struct Point(int X, int Y); // Stack-allocated, value equality

// When to use Classes: Entities with identity
public class Order // Entity with identity (Id)
{
    public int Id { get; private set; }
    public string CustomerEmail { get; private set; }
    public decimal Total { get; private set; }
    private List<OrderItem> _items = new();
    
    public void AddItem(OrderItem item)
    {
        _items.Add(item);
        RecalculateTotal();
    }
    
    private void RecalculateTotal() => Total = _items.Sum(i => i.Price);
}
```

---

### Question 55: Explain Async Streams (IAsyncEnumerable). When would you use them?

**Short Theory:**  
`IAsyncEnumerable<T>` (C# 8+) enables async iteration with `await foreach`. Yields items asynchronously as they're produced. Use for streaming large datasets (database queries, API pagination, file processing) without loading everything into memory. Supports cancellation tokens. More memory-efficient than `Task<List<T>>`.

**Why do we use it?**  
Loading millions of records into List causes OutOfMemoryException. IAsyncEnumerable streams data—process one item at a time. Essential for large datasets, real-time data feeds, and backpressure scenarios. EF Core supports it natively. Reduces memory footprint from GB to KB.

**Key Interview Points:**
- Stream data asynchronously without loading all into memory
- Use `yield return` in async methods
- Consume with `await foreach`
- Supports CancellationToken
- Perfect for: Large datasets, pagination, file streams
- EF Core: `.AsAsyncEnumerable()`

**Coding Example:**
```csharp
// Producer: Async stream from database
public class ProductRepository
{
    private readonly AppDbContext _context;
    
    public ProductRepository(AppDbContext context) => _context = context;
    
    // Returns async stream (no ToListAsync)
    public async IAsyncEnumerable<Product> GetAllProductsAsync(
        [EnumeratorCancellation] CancellationToken ct = default)
    {
        await foreach (var product in _context.Products.AsAsyncEnumerable().WithCancellation(ct))
        {
            // Process or transform if needed
            yield return product;
        }
    }
}

// Producer: Generate async stream
public async IAsyncEnumerable<int> GenerateNumbersAsync(int count, 
    [EnumeratorCancellation] CancellationToken ct = default)
{
    for (int i = 0; i < count; i++)
    {
        ct.ThrowIfCancellationRequested();
        await Task.Delay(100, ct); // Simulate async work
        yield return i;
    }
}

// Consumer: Process stream
public class ProductService
{
    private readonly ProductRepository _repository;
    
    public ProductService(ProductRepository repository) => _repository = repository;
    
    public async Task ProcessAllProductsAsync(CancellationToken ct)
    {
        await foreach (var product in _repository.GetAllProductsAsync(ct))
        {
            // Process one at a time (memory-efficient)
            Console.WriteLine($"Processing: {product.Name}");
            await DoSomethingAsync(product);
            
            // Early exit if needed
            if (ct.IsCancellationRequested)
                break;
        }
    }
    
    private Task DoSomethingAsync(Product product) => Task.CompletedTask;
}

// API pagination with async streams
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductRepository _repository;
    
    public ProductsController(ProductRepository repository) => _repository = repository;
    
    [HttpGet("stream")]
    public async IAsyncEnumerable<Product> StreamProducts(
        [EnumeratorCancellation] CancellationToken ct)
    {
        await foreach (var product in _repository.GetAllProductsAsync(ct))
        {
            yield return product; // Streams to client
        }
    }
}

// LINQ with async streams
public async Task<List<Product>> GetExpensiveProductsAsync(CancellationToken ct)
{
    var expensiveProducts = new List<Product>();
    
    await foreach (var product in _repository.GetAllProductsAsync(ct))
    {
        if (product.Price > 100)
            expensiveProducts.Add(product);
    }
    
    return expensiveProducts;
}

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } }
public class AppDbContext : DbContext 
{ 
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
}
```

---

**Batch 9 completed (Questions 51-55). Continue with next batch.**

---

## Batch 10: Design Patterns & Advanced Concepts (Questions 56-60)

### Question 56: Explain the Repository and Unit of Work patterns. Are they necessary with EF Core?

**Short Theory:**  
**Repository** abstracts data access, provides collection-like interface for domain objects. **Unit of Work** tracks changes and commits them as a single transaction. EF Core's `DbContext` is already a Unit of Work, `DbSet<T>` is a repository. Some argue patterns are redundant with EF Core. Use repositories for: testability (mock data access), isolating EF from domain, switching ORMs, complex query encapsulation.

**Why do we use it?**  
Repositories decouple business logic from data access technology. Makes testing easier (mock repositories). Unit of Work ensures transactional consistency. Debate: Generic repositories can be anti-pattern (leaky abstraction). Modern approach: thin repositories for complex queries only, use DbContext directly in simple cases.

**Key Interview Points:**
- Repository: Abstracts data access, collection-like interface
- Unit of Work: Tracks changes, single transaction commit
- DbContext IS a Unit of Work, DbSet IS a repository
- Use for: Testability, abstraction, complex queries
- Generic Repository<T> can be anti-pattern
- Modern approach: Use DbContext directly or thin repositories

**Coding Example:**
```csharp
// Repository interface
public interface IOrderRepository
{
    Task<Order> GetByIdAsync(int id);
    Task<IEnumerable<Order>> GetOrdersByCustomerAsync(string customerId);
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
}

// Repository implementation
public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _context;
    
    public OrderRepository(AppDbContext context) => _context = context;
    
    public async Task<Order> GetByIdAsync(int id)
    {
        return await _context.Orders
            .Include(o => o.Items)
            .FirstOrDefaultAsync(o => o.Id == id);
    }
    
    public async Task<IEnumerable<Order>> GetOrdersByCustomerAsync(string customerId)
    {
        return await _context.Orders
            .Where(o => o.CustomerId == customerId)
            .OrderByDescending(o => o.CreatedAt)
            .ToListAsync();
    }
    
    public async Task AddAsync(Order order)
    {
        await _context.Orders.AddAsync(order);
    }
    
    public async Task UpdateAsync(Order order)
    {
        _context.Orders.Update(order);
    }
}

// Unit of Work interface
public interface IUnitOfWork : IDisposable
{
    IOrderRepository Orders { get; }
    IProductRepository Products { get; }
    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}

// Unit of Work implementation
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IDbContextTransaction _transaction;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        Orders = new OrderRepository(context);
        Products = new ProductRepository(context);
    }
    
    public IOrderRepository Orders { get; }
    public IProductRepository Products { get; }
    
    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    
    public async Task BeginTransactionAsync()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
    }
    
    public async Task CommitTransactionAsync()
    {
        await _transaction?.CommitAsync();
    }
    
    public async Task RollbackTransactionAsync()
    {
        await _transaction?.RollbackAsync();
    }
    
    public void Dispose() => _context.Dispose();
}

// Service using Unit of Work
public class OrderService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public OrderService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    public async Task CreateOrderAsync(Order order)
    {
        await _unitOfWork.BeginTransactionAsync();
        
        try
        {
            await _unitOfWork.Orders.AddAsync(order);
            
            // Update product inventory in same transaction
            foreach (var item in order.Items)
            {
                var product = await _unitOfWork.Products.GetByIdAsync(item.ProductId);
                product.Stock -= item.Quantity;
                await _unitOfWork.Products.UpdateAsync(product);
            }
            
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync();
            throw;
        }
    }
}

// Supporting types
public class Order { public int Id { get; set; } public string CustomerId { get; set; } public DateTime CreatedAt { get; set; } public List<OrderItem> Items { get; set; } }
public class OrderItem { public int ProductId { get; set; } public int Quantity { get; set; } }
public class Product { public int Id { get; set; } public int Stock { get; set; } }
public interface IProductRepository { Task<Product> GetByIdAsync(int id); Task UpdateAsync(Product product); }
public class ProductRepository : IProductRepository 
{ 
    private readonly AppDbContext _context;
    public ProductRepository(AppDbContext context) => _context = context;
    public async Task<Product> GetByIdAsync(int id) => await _context.Products.FindAsync(id);
    public async Task UpdateAsync(Product product) { _context.Products.Update(product); await Task.CompletedTask; }
}
public class AppDbContext : DbContext { public DbSet<Order> Orders { get; set; } public DbSet<Product> Products { get; set; } }
```

---

### Question 57: Explain Reflection in C#. What are the performance implications?

**Short Theory:**  
Reflection inspects and invokes types, methods, properties at runtime. Use cases: Serialization, DI containers, ORM mapping, plugin systems. Access with `typeof`, `GetType()`, `Assembly`. Can invoke private members, create instances, get attributes. Performance: 100-1000x slower than direct calls. Use source generators or expression trees for hot paths. Cache reflected metadata.

**Why do we use it?**  
Reflection enables framework-level code (ASP.NET Core, EF Core, JSON serializers). Required for dynamic scenarios: plugin loading, generic factory patterns, attribute-based configuration. Trade-off: Performance cost and type safety loss. Avoid in hot paths—use compiled expressions or source generators instead.

**Key Interview Points:**
- Inspect types, methods, properties at runtime
- Use for: Serialization, DI, plugins, dynamic invocation
- Performance: 100-1000x slower than direct calls
- Cache Type, MethodInfo, PropertyInfo for reuse
- Alternatives: Expression trees, source generators
- Can access private members (use carefully)

**Coding Example:**
```csharp
// Basic reflection examples
public class ReflectionExamples
{
    public void BasicReflection()
    {
        var type = typeof(Person);
        
        // Get properties
        foreach (var prop in type.GetProperties())
        {
            Console.WriteLine($"Property: {prop.Name}, Type: {prop.PropertyType}");
        }
        
        // Create instance
        var person = Activator.CreateInstance(type) as Person;
        
        // Set property value
        var nameProp = type.GetProperty("Name");
        nameProp.SetValue(person, "John Doe");
        
        // Get property value
        var name = nameProp.GetValue(person);
        Console.WriteLine($"Name: {name}");
    }
}

// Attribute-based processing
[AttributeUsage(AttributeTargets.Property)]
public class RequiredAttribute : Attribute { }

public class Person
{
    [Required]
    public string Name { get; set; }
    
    public int Age { get; set; }
}

public class Validator
{
    public List<string> Validate<T>(T obj)
    {
        var errors = new List<string>();
        var type = typeof(T);
        
        foreach (var prop in type.GetProperties())
        {
            var attr = prop.GetCustomAttribute<RequiredAttribute>();
            if (attr != null)
            {
                var value = prop.GetValue(obj);
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    errors.Add($"{prop.Name} is required");
                }
            }
        }
        
        return errors;
    }
}

// Performance: Reflection vs Direct call
public class PerformanceComparison
{
    public void DirectCall()
    {
        var person = new Person { Name = "John" };
        var name = person.Name; // Fast: ~1ns
    }
    
    public void ReflectionCall()
    {
        var person = new Person { Name = "John" };
        var prop = typeof(Person).GetProperty("Name");
        var name = prop.GetValue(person); // Slow: ~100-1000ns
    }
    
    // Better: Cache PropertyInfo
    private static readonly PropertyInfo NameProperty = typeof(Person).GetProperty("Name");
    
    public void CachedReflectionCall()
    {
        var person = new Person { Name = "John" };
        var name = NameProperty.GetValue(person); // Better, but still slower
    }
}

// Plugin loading with reflection
public class PluginLoader
{
    public IEnumerable<IPlugin> LoadPlugins(string pluginDirectory)
    {
        var plugins = new List<IPlugin>();
        var dlls = Directory.GetFiles(pluginDirectory, "*.dll");
        
        foreach (var dll in dlls)
        {
            var assembly = Assembly.LoadFrom(dll);
            
            foreach (var type in assembly.GetTypes())
            {
                if (typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface)
                {
                    var plugin = Activator.CreateInstance(type) as IPlugin;
                    plugins.Add(plugin);
                }
            }
        }
        
        return plugins;
    }
}

public interface IPlugin { void Execute(); }
```

---

### Question 58: What are Expression Trees? How are they used in LINQ and EF Core?

**Short Theory:**  
Expression trees represent code as data structures (AST). `Expression<Func<T, bool>>` is a tree, not compiled code. LINQ providers (EF Core, LINQ-to-SQL) parse expression trees to generate SQL. Use `Expression` API to build dynamic queries, create compiled delegates. Compiled expressions are 100x faster than reflection. Used in ORMs, auto-mappers, validation frameworks.

**Why do we use it?**  
Expression trees enable LINQ-to-SQL translation—EF Core parses `Where(x => x.Age > 18)` to SQL `WHERE Age > 18`. Allow dynamic query building without string concatenation. Compiled expressions offer reflection-like flexibility with near-native performance. Essential for framework builders and advanced query scenarios.

**Key Interview Points:**
- Represent code as data (AST)
- Expression<Func<T, bool>> vs Func<T, bool>
- LINQ providers parse trees to SQL/queries
- Build dynamic queries programmatically
- Compile expressions for performance
- Used by: EF Core, AutoMapper, FluentValidation

**Coding Example:**
```csharp
// Expression vs Func
public class ExpressionVsFunc
{
    public void Example()
    {
        // Func: Compiled code (cannot inspect)
        Func<int, bool> funcGreaterThanFive = x => x > 5;
        var result1 = funcGreaterThanFive(10); // Executes in memory
        
        // Expression: Data structure (can inspect and translate)
        Expression<Func<int, bool>> exprGreaterThanFive = x => x > 5;
        // EF Core can translate this to SQL: WHERE Value > 5
        
        var compiled = exprGreaterThanFive.Compile();
        var result2 = compiled(10); // Execute after compiling
    }
}

// Dynamic query building
public class DynamicQueryBuilder
{
    public IQueryable<Product> BuildQuery(AppDbContext context, string searchTerm, decimal? minPrice)
    {
        var query = context.Products.AsQueryable();
        
        // Dynamic filtering
        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(p => p.Name.Contains(searchTerm));
        }
        
        if (minPrice.HasValue)
        {
            query = query.Where(p => p.Price >= minPrice.Value);
        }
        
        return query;
    }
}

// Building expressions programmatically
public class ExpressionBuilder
{
    public Expression<Func<Product, bool>> BuildPriceFilter(decimal minPrice, decimal maxPrice)
    {
        var parameter = Expression.Parameter(typeof(Product), "p");
        var property = Expression.Property(parameter, "Price");
        
        var minValue = Expression.Constant(minPrice);
        var maxValue = Expression.Constant(maxPrice);
        
        var greaterThan = Expression.GreaterThanOrEqual(property, minValue);
        var lessThan = Expression.LessThanOrEqual(property, maxValue);
        var andExpression = Expression.AndAlso(greaterThan, lessThan);
        
        return Expression.Lambda<Func<Product, bool>>(andExpression, parameter);
        // Result: p => p.Price >= minPrice && p.Price <= maxPrice
    }
}

// Compiled expression for performance (alternative to reflection)
public class PropertyAccessor<T>
{
    private static readonly Dictionary<string, Func<T, object>> _cache = new();
    
    public Func<T, object> GetPropertyGetter(string propertyName)
    {
        if (_cache.TryGetValue(propertyName, out var getter))
            return getter;
        
        var parameter = Expression.Parameter(typeof(T), "obj");
        var property = Expression.Property(parameter, propertyName);
        var convert = Expression.Convert(property, typeof(object));
        var lambda = Expression.Lambda<Func<T, object>>(convert, parameter);
        
        getter = lambda.Compile(); // Compile to delegate (fast)
        _cache[propertyName] = getter;
        
        return getter;
    }
}

// Usage in generic mapper (AutoMapper-like)
public class SimpleMapper
{
    public TDest Map<TSource, TDest>(TSource source) where TDest : new()
    {
        var dest = new TDest();
        var sourceType = typeof(TSource);
        var destType = typeof(TDest);
        
        foreach (var sourceProp in sourceType.GetProperties())
        {
            var destProp = destType.GetProperty(sourceProp.Name);
            if (destProp != null && destProp.CanWrite)
            {
                // Use compiled expression instead of reflection
                var accessor = new PropertyAccessor<TSource>().GetPropertyGetter(sourceProp.Name);
                var value = accessor(source);
                destProp.SetValue(dest, value);
            }
        }
        
        return dest;
    }
}

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } }
public class AppDbContext : DbContext { public DbSet<Product> Products { get; set; } }
```

---

### Question 59: Explain the Decorator pattern. How is it used in ASP.NET Core?

**Short Theory:**  
Decorator adds behavior to objects dynamically without modifying original class. Wraps object, intercepts calls, adds functionality (logging, caching, validation). ASP.NET Core uses decorators extensively: middleware (decorates request pipeline), ILogger (decorator chain), HttpClient handlers. Alternative to inheritance for cross-cutting concerns. Follows Open-Closed Principle.

**Why do we use it?**  
Decorators enable composition over inheritance. Add features without modifying existing code. Stack multiple decorators (LoggingDecorator → CachingDecorator → Service). More flexible than inheritance—combine behaviors at runtime. Essential for cross-cutting concerns (logging, caching, retry, validation).

**Key Interview Points:**
- Wrap objects to add behavior dynamically
- Alternative to inheritance (composition over inheritance)
- Stack multiple decorators (pipeline pattern)
- Used in: Middleware, HttpClient handlers, DI decorators
- Follows Open-Closed Principle
- Example: LoggingDecorator wraps service, adds logging

**Coding Example:**
```csharp
// Service interface
public interface IOrderService
{
    Task<Order> GetOrderAsync(int id);
    Task CreateOrderAsync(Order order);
}

// Core implementation
public class OrderService : IOrderService
{
    private readonly AppDbContext _context;
    
    public OrderService(AppDbContext context) => _context = context;
    
    public async Task<Order> GetOrderAsync(int id)
    {
        return await _context.Orders.FindAsync(id);
    }
    
    public async Task CreateOrderAsync(Order order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
    }
}

// Logging decorator
public class LoggingOrderServiceDecorator : IOrderService
{
    private readonly IOrderService _inner;
    private readonly ILogger<LoggingOrderServiceDecorator> _logger;
    
    public LoggingOrderServiceDecorator(IOrderService inner, ILogger<LoggingOrderServiceDecorator> logger)
    {
        _inner = inner;
        _logger = logger;
    }
    
    public async Task<Order> GetOrderAsync(int id)
    {
        _logger.LogInformation($"Getting order {id}");
        var order = await _inner.GetOrderAsync(id);
        _logger.LogInformation($"Retrieved order {id}");
        return order;
    }
    
    public async Task CreateOrderAsync(Order order)
    {
        _logger.LogInformation("Creating order");
        await _inner.CreateOrderAsync(order);
        _logger.LogInformation($"Created order {order.Id}");
    }
}

// Caching decorator
public class CachingOrderServiceDecorator : IOrderService
{
    private readonly IOrderService _inner;
    private readonly IMemoryCache _cache;
    
    public CachingOrderServiceDecorator(IOrderService inner, IMemoryCache cache)
    {
        _inner = inner;
        _cache = cache;
    }
    
    public async Task<Order> GetOrderAsync(int id)
    {
        return await _cache.GetOrCreateAsync($"order:{id}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
            return await _inner.GetOrderAsync(id);
        });
    }
    
    public async Task CreateOrderAsync(Order order)
    {
        await _inner.CreateOrderAsync(order);
        _cache.Remove($"order:{order.Id}"); // Invalidate cache
    }
}

// DI registration (stacking decorators)
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddOrderServiceWithDecorators(this IServiceCollection services)
    {
        // Core service
        services.AddScoped<OrderService>();
        
        // Wrap with caching
        services.AddScoped<IOrderService>(provider =>
        {
            var core = provider.GetRequiredService<OrderService>();
            var cache = provider.GetRequiredService<IMemoryCache>();
            var cached = new CachingOrderServiceDecorator(core, cache);
            
            // Wrap with logging
            var logger = provider.GetRequiredService<ILogger<LoggingOrderServiceDecorator>>();
            return new LoggingOrderServiceDecorator(cached, logger);
        });
        
        return services;
    }
}

// Usage: Core → Cache → Logging
// Request → LoggingDecorator → CachingDecorator → OrderService

// Supporting types
public class Order { public int Id { get; set; } public string CustomerEmail { get; set; } }
public class AppDbContext : DbContext { public DbSet<Order> Orders { get; set; } }
```

---

### Question 60: What are Source Generators in C#? How do they improve performance?

**Short Theory:**  
Source Generators (C# 9+) generate code at compile-time by analyzing syntax trees. Roslyn analyzer creates C# code added to compilation. Use cases: Serialization (System.Text.Json), DI registration, DTO mapping, boilerplate reduction. Benefits: Zero runtime reflection cost, AOT compatibility, compile-time errors. Alternative to T4 templates and runtime code generation.

**Why do we use it?**  
Eliminates runtime reflection overhead—code generated at compile-time. System.Text.Json uses source generators for 40% faster serialization. Enables AOT scenarios (Blazor WebAssembly, native AOT). Catch errors at compile-time instead of runtime. Future direction: Replace reflection-heavy frameworks with generators.

**Key Interview Points:**
- Generate code at compile-time (Roslyn analyzer)
- Zero runtime reflection cost
- Use for: Serialization, DI, mapping, boilerplate
- System.Text.Json uses generators (40% faster)
- Enables AOT compilation
- Alternative to: T4 templates, reflection, runtime codegen

**Coding Example:**
```csharp
// Using System.Text.Json with source generators

// 1. Mark context for source generation
[JsonSerializable(typeof(Person))]
[JsonSerializable(typeof(List<Person>))]
internal partial class AppJsonContext : JsonSerializerContext { }

// 2. Use generated serialization (no reflection)
public class SerializationExample
{
    public string SerializeWithGenerator(Person person)
    {
        // Uses compile-time generated code (fast)
        return JsonSerializer.Serialize(person, AppJsonContext.Default.Person);
    }
    
    public Person DeserializeWithGenerator(string json)
    {
        // Uses compile-time generated code (fast)
        return JsonSerializer.Deserialize(json, AppJsonContext.Default.Person);
    }
    
    // Old way (reflection-based, slower)
    public string SerializeOldWay(Person person)
    {
        return JsonSerializer.Serialize(person); // Uses reflection
    }
}

// Creating a simple source generator (simplified example)
// This would be in a separate analyzer project

/*
[Generator]
public class AutoNotifyGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context) { }
    
    public void Execute(GeneratorExecutionContext context)
    {
        // Find classes with [AutoNotify] attribute
        // Generate INotifyPropertyChanged implementation
        
        var source = @"
using System.ComponentModel;

namespace Generated
{
    public partial class Person : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}";
        
        context.AddSource("Person.g.cs", source);
    }
}
*/

// Consumer code (developer writes this)
[AutoNotify] // Attribute triggers source generator
public partial class Person
{
    // Generator creates Name property with INotifyPropertyChanged
}

// Performance comparison
public class PerformanceBenchmark
{
    private readonly Person _person = new() { Name = "John", Age = 30 };
    
    public void BenchmarkReflection()
    {
        // Old way: Reflection-based (slower)
        for (int i = 0; i < 10000; i++)
        {
            var json = JsonSerializer.Serialize(_person); // ~1000ms
        }
    }
    
    public void BenchmarkSourceGenerator()
    {
        // New way: Source generator (faster)
        for (int i = 0; i < 10000; i++)
        {
            var json = JsonSerializer.Serialize(_person, AppJsonContext.Default.Person); // ~600ms
        }
    }
}

// Supporting types
public class Person { public string Name { get; set; } public int Age { get; set; } }

[AttributeUsage(AttributeTargets.Class)]
public class AutoNotifyAttribute : Attribute { }
```

---

**Batch 10 completed (Questions 56-60). Continue with next batch.**

---

## Batch 11: Modern .NET Technologies (Questions 61-65)

### Question 61: Explain Integration Testing in ASP.NET Core with WebApplicationFactory.

**Short Theory:**  
Integration tests verify multiple components working together. `WebApplicationFactory<T>` creates in-memory test server with real HTTP pipeline. Tests full request/response cycle without network. Use in-memory database or test database. Override services for testing (mock external APIs). More comprehensive than unit tests but slower. Essential for API testing.

**Why do we use it?**  
Integration tests catch issues unit tests miss: routing, middleware, authentication, model binding, serialization. WebApplicationFactory provides realistic test environment without deploying. Test entire API endpoints end-to-end. Balance: Unit tests (fast, many) + Integration tests (slower, fewer) = confidence.

**Key Interview Points:**
- Test multiple components together (controllers, services, DB)
- WebApplicationFactory creates in-memory test server
- Use in-memory database or test containers
- Override services with ConfigureTestServices
- Test full HTTP pipeline (routing, middleware, auth)
- Slower than unit tests, faster than E2E tests

**Coding Example:**
```csharp
// Install: Microsoft.AspNetCore.Mvc.Testing, Microsoft.EntityFrameworkCore.InMemory

// Test class
public class ProductsApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private readonly HttpClient _client;
    
    public ProductsApiTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                // Replace real DB with in-memory
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<AppDbContext>));
                if (descriptor != null) services.Remove(descriptor);
                
                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseInMemoryDatabase("TestDb");
                });
                
                // Seed test data
                var sp = services.BuildServiceProvider();
                using var scope = sp.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated();
                db.Products.Add(new Product { Id = 1, Name = "Test Product", Price = 10.99m });
                db.SaveChanges();
            });
        });
        
        _client = _factory.CreateClient();
    }
    
    [Fact]
    public async Task GetProduct_ReturnsSuccess()
    {
        // Act
        var response = await _client.GetAsync("/api/products/1");
        
        // Assert
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var product = JsonSerializer.Deserialize<Product>(json);
        
        Assert.Equal("Test Product", product.Name);
    }
    
    [Fact]
    public async Task CreateProduct_ReturnsCreated()
    {
        // Arrange
        var newProduct = new { Name = "New Product", Price = 20.99 };
        var content = new StringContent(JsonSerializer.Serialize(newProduct), Encoding.UTF8, "application/json");
        
        // Act
        var response = await _client.PostAsync("/api/products", content);
        
        // Assert
        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
    }
}

// Program.cs (make Program class accessible)
public partial class Program { }

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } }
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; } 
}
```

---

### Question 62: What is GraphQL? How does it differ from REST? Explain Hot Chocolate implementation.

**Short Theory:**  
GraphQL is a query language for APIs—clients specify exact data needed. Single endpoint, flexible queries, strongly-typed schema. REST: Multiple endpoints, fixed responses, over/under-fetching. Hot Chocolate is .NET GraphQL server. GraphQL features: Queries (read), Mutations (write), Subscriptions (real-time), resolvers, schema stitching. Use for complex UIs needing flexible data fetching.

**Why do we use it?**  
GraphQL eliminates over-fetching (REST returns too much data) and under-fetching (multiple requests needed). Single request for complex data. Strongly-typed schema with introspection. Perfect for mobile apps (bandwidth sensitive) and complex dashboards. Trade-off: More complex than REST, caching harder, learning curve.

**Key Interview Points:**
- Single endpoint, clients specify exact data needed
- No over-fetching or under-fetching
- Strongly-typed schema with introspection
- Queries (read), Mutations (write), Subscriptions (real-time)
- Hot Chocolate: .NET GraphQL server
- Use for: Complex UIs, mobile apps, microservices aggregation

**Coding Example:**
```csharp
// Install: HotChocolate.AspNetCore

// Domain model
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}

// Query type (read operations)
public class Query
{
    public IQueryable<Product> GetProducts([Service] AppDbContext context)
    {
        return context.Products;
    }
    
    public async Task<Product> GetProductById(int id, [Service] AppDbContext context)
    {
        return await context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
    }
}

// Mutation type (write operations)
public class Mutation
{
    public async Task<Product> CreateProduct(string name, decimal price, int categoryId, [Service] AppDbContext context)
    {
        var product = new Product { Name = name, Price = price, CategoryId = categoryId };
        context.Products.Add(product);
        await context.SaveChangesAsync();
        return product;
    }
    
    public async Task<Product> UpdateProduct(int id, string name, decimal price, [Service] AppDbContext context)
    {
        var product = await context.Products.FindAsync(id);
        if (product == null) throw new Exception("Product not found");
        
        product.Name = name;
        product.Price = price;
        await context.SaveChangesAsync();
        return product;
    }
}

// Program.cs configuration
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddFiltering()
    .AddSorting()
    .AddProjections();

var app = builder.Build();

app.MapGraphQL();
app.Run();

// Example GraphQL queries:

// Query: Get specific fields only
/*
{
  products {
    id
    name
    price
    category {
      name
    }
  }
}
*/

// Query with filtering
/*
{
  products(where: { price: { gt: 10 } }) {
    name
    price
  }
}
*/

// Mutation: Create product
/*
mutation {
  createProduct(name: "New Product", price: 29.99, categoryId: 1) {
    id
    name
  }
}
*/

public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
```

---

### Question 63: Explain SignalR. How do you implement real-time communication?

**Short Theory:**  
SignalR enables real-time bidirectional communication between server and clients. Automatically chooses transport: WebSockets (preferred), Server-Sent Events, Long Polling. Use cases: Chat apps, live dashboards, notifications, collaborative editing. Hub pattern: Server hub broadcasts to connected clients. Supports groups, typed hubs, scaling with Redis backplane.

**Why do we use it?**  
Real-time updates without polling. Server pushes data to clients instantly. WebSockets provide full-duplex communication. SignalR abstracts transport complexity—falls back automatically. Essential for dashboards, chat, live feeds, gaming. Alternative to polling (reduces latency and server load).

**Key Interview Points:**
- Real-time bidirectional communication (server ↔ client)
- Automatic transport selection (WebSockets, SSE, Long Polling)
- Hub pattern: Clients connect to hubs
- Supports: Broadcasting, groups, typed hubs
- Scale with Redis backplane for multi-server
- Use for: Chat, dashboards, notifications, collaboration

**Coding Example:**
```csharp
// Install: Microsoft.AspNetCore.SignalR

// Hub definition
public class ChatHub : Hub
{
    // Receive message from client
    public async Task SendMessage(string user, string message)
    {
        // Broadcast to all clients
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
    
    // Send to specific group
    public async Task SendToGroup(string groupName, string user, string message)
    {
        await Clients.Group(groupName).SendAsync("ReceiveMessage", user, message);
    }
    
    // Join group
    public async Task JoinGroup(string groupName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        await Clients.Group(groupName).SendAsync("UserJoined", Context.ConnectionId);
    }
    
    // Leave group
    public async Task LeaveGroup(string groupName)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
    }
    
    // Connection lifecycle
    public override async Task OnConnectedAsync()
    {
        await Clients.All.SendAsync("UserConnected", Context.ConnectionId);
        await base.OnConnectedAsync();
    }
    
    public override async Task OnDisconnectedAsync(Exception exception)
    {
        await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
        await base.OnDisconnectedAsync(exception);
    }
}

// Program.cs configuration
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

// Scale with Redis backplane (for multi-server)
// builder.Services.AddSignalR().AddStackExchangeRedis("redis-connection-string");

var app = builder.Build();

app.MapHub<ChatHub>("/chatHub");
app.Run();

// Strongly-typed hub
public interface IChatClient
{
    Task ReceiveMessage(string user, string message);
    Task UserJoined(string connectionId);
}

public class TypedChatHub : Hub<IChatClient>
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.ReceiveMessage(user, message); // Type-safe
    }
}

// JavaScript client example
/*
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();

connection.on("ReceiveMessage", (user, message) => {
    console.log(`${user}: ${message}`);
});

connection.start();

// Send message
connection.invoke("SendMessage", "John", "Hello World");
*/

// C# client example
public class SignalRClient
{
    private HubConnection _connection;
    
    public async Task ConnectAsync()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl("https://localhost:5001/chatHub")
            .Build();
        
        _connection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            Console.WriteLine($"{user}: {message}");
        });
        
        await _connection.StartAsync();
    }
    
    public async Task SendMessageAsync(string user, string message)
    {
        await _connection.InvokeAsync("SendMessage", user, message);
    }
}
```

---

### Question 64: Explain Background Services and Hosted Services in ASP.NET Core.

**Short Theory:**  
Background services run tasks outside request pipeline. Implement `IHostedService` or inherit `BackgroundService`. Use for: Scheduled jobs, queue processing, periodic cleanup, monitoring. `BackgroundService` provides `ExecuteAsync` for long-running tasks. Use `IHostApplicationLifetime` for graceful shutdown. Multiple hosted services run concurrently.

**Why do we use it?**  
Applications need background tasks: Send emails, process queues, cleanup expired data, health checks. Hosted services lifecycle-managed by ASP.NET Core host. Alternative to Windows Services or separate worker processes. Integrated with DI and configuration. Critical for async processing and scheduled tasks.

**Key Interview Points:**
- Run tasks outside HTTP request pipeline
- IHostedService or BackgroundService base class
- Use for: Scheduled jobs, queue processing, cleanup
- Multiple services run concurrently
- Support graceful shutdown with CancellationToken
- Use Hangfire or Quartz.NET for complex scheduling

**Coding Example:**
```csharp
// Simple background service
public class EmailSenderService : BackgroundService
{
    private readonly ILogger<EmailSenderService> _logger;
    private readonly IServiceProvider _serviceProvider;
    
    public EmailSenderService(ILogger<EmailSenderService> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Email Sender Service started");
        
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var emailQueue = scope.ServiceProvider.GetRequiredService<IEmailQueue>();
                
                var email = await emailQueue.DequeueAsync(stoppingToken);
                if (email != null)
                {
                    await SendEmailAsync(email);
                    _logger.LogInformation($"Sent email to {email.To}");
                }
                
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Email Sender Service");
            }
        }
        
        _logger.LogInformation("Email Sender Service stopped");
    }
    
    private Task SendEmailAsync(Email email) => Task.CompletedTask;
}

// Timed background service (runs periodically)
public class DataCleanupService : BackgroundService
{
    private readonly ILogger<DataCleanupService> _logger;
    private readonly IServiceProvider _serviceProvider;
    private readonly TimeSpan _interval = TimeSpan.FromHours(24);
    
    public DataCleanupService(ILogger<DataCleanupService> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Running data cleanup");
            
            using var scope = _serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            
            // Delete old records
            var cutoffDate = DateTime.UtcNow.AddDays(-90);
            var oldRecords = await context.Logs.Where(l => l.CreatedAt < cutoffDate).ToListAsync(stoppingToken);
            context.Logs.RemoveRange(oldRecords);
            await context.SaveChangesAsync(stoppingToken);
            
            _logger.LogInformation($"Deleted {oldRecords.Count} old records");
            
            await Task.Delay(_interval, stoppingToken);
        }
    }
}

// IHostedService implementation (more control)
public class QueuedHostedService : IHostedService
{
    private readonly ILogger<QueuedHostedService> _logger;
    private Timer _timer;
    
    public QueuedHostedService(ILogger<QueuedHostedService> logger)
    {
        _logger = logger;
    }
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Queued Hosted Service starting");
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(5));
        return Task.CompletedTask;
    }
    
    private void DoWork(object state)
    {
        _logger.LogInformation("Queued Hosted Service work executing");
    }
    
    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Queued Hosted Service stopping");
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }
}

// Registration in Program.cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<EmailSenderService>();
builder.Services.AddHostedService<DataCleanupService>();
builder.Services.AddHostedService<QueuedHostedService>();

var app = builder.Build();
app.Run();

// Supporting types
public interface IEmailQueue { Task<Email> DequeueAsync(CancellationToken ct); }
public class Email { public string To { get; set; } public string Subject { get; set; } public string Body { get; set; } }
public class AppDbContext : DbContext { public DbSet<LogEntry> Logs { get; set; } }
public class LogEntry { public int Id { get; set; } public DateTime CreatedAt { get; set; } }
```

---

### Question 65: Explain containerization with Docker. How do you containerize ASP.NET Core apps?

**Short Theory:**  
Containers package app with dependencies into isolated, portable units. Docker is container platform. Dockerfile defines image: base image, copy files, restore packages, build, expose port. Multi-stage builds reduce image size (build stage + runtime stage). Docker Compose orchestrates multiple containers (app + database + redis). Benefits: Consistent environments, easy deployment, scaling.

**Why do we use it?**  
"Works on my machine" problem solved—containers ensure consistency. Deploy anywhere: dev, staging, production, cloud. Lightweight vs VMs (share kernel). Microservices run in separate containers. Kubernetes orchestrates at scale. Essential for modern cloud-native applications and CI/CD pipelines.

**Key Interview Points:**
- Package app + dependencies into isolated container
- Dockerfile: Instructions to build image
- Multi-stage builds reduce size (build + runtime)
- Docker Compose for multi-container apps
- Benefits: Consistency, portability, isolation
- Use with Kubernetes for orchestration at scale

**Coding Example:**
```dockerfile
# Multi-stage Dockerfile for ASP.NET Core

# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies (cached layer)
COPY ["MyApp/MyApp.csproj", "MyApp/"]
RUN dotnet restore "MyApp/MyApp.csproj"

# Copy source and build
COPY . .
WORKDIR "/src/MyApp"
RUN dotnet build "MyApp.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "MyApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Runtime (smaller image)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Non-root user for security
RUN addgroup --system --gid 1000 appuser && \
    adduser --system --uid 1000 --ingroup appuser appuser
USER appuser

EXPOSE 8080
EXPOSE 8081

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyApp.dll"]
```

```yaml
# docker-compose.yml - Multi-container setup
version: '3.8'

services:
  web:
    build:
      context: .
      dockerfile: Dockerfile
    ports:
      - "5000:8080"
    environment:
      - ASPNETCORE_ENVIRONMENT=Production
      - ConnectionStrings__DefaultConnection=Server=db;Database=MyAppDb;User Id=sa;Password=YourStrong@Passw0rd;
    depends_on:
      - db
      - redis
    networks:
      - app-network

  db:
    image: mcr.microsoft.com/mssql/server:2022-latest
    environment:
      - ACCEPT_EULA=Y
      - SA_PASSWORD=YourStrong@Passw0rd
    ports:
      - "1433:1433"
    volumes:
      - sql-data:/var/opt/mssql
    networks:
      - app-network

  redis:
    image: redis:7-alpine
    ports:
      - "6379:6379"
    volumes:
      - redis-data:/data
    networks:
      - app-network

volumes:
  sql-data:
  redis-data:

networks:
  app-network:
    driver: bridge
```

```bash
# Docker commands

# Build image
docker build -t myapp:latest .

# Run container
docker run -d -p 5000:8080 --name myapp-container myapp:latest

# Run with docker-compose
docker-compose up -d

# View logs
docker logs myapp-container

# Stop and remove
docker-compose down

# Push to registry
docker tag myapp:latest myregistry.azurecr.io/myapp:latest
docker push myregistry.azurecr.io/myapp:latest
```

```csharp
// Program.cs - Docker-aware configuration
var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel for containers
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080); // HTTP
    options.ListenAnyIP(8081, listenOptions =>
    {
        listenOptions.UseHttps(); // HTTPS
    });
});

// Health checks for container orchestration
builder.Services.AddHealthChecks()
    .AddDbContextCheck<AppDbContext>()
    .AddRedis(builder.Configuration.GetConnectionString("Redis"));

var app = builder.Build();

app.MapHealthChecks("/health");
app.Run();
```

---

**Batch 11 completed (Questions 61-65). Continue with next batch.**

---

## Batch 12: Cloud & Performance (Questions 66-70)

### Question 66: Explain Minimal APIs in .NET. When to use Minimal APIs vs Controllers?

**Short Theory:**  
Minimal APIs (.NET 6+) define endpoints directly in Program.cs without controllers. Lightweight, less ceremony, faster startup. Use lambda expressions or local functions for handlers. Support filters, validation, OpenAPI. Best for: Microservices, simple APIs, serverless functions. Use Controllers for: Complex apps, many endpoints, attribute-heavy logic, separation of concerns.

**Why do we use it?**  
Reduce boilerplate for simple APIs. 30% faster startup than controllers. Less memory overhead. Perfect for microservices and cloud functions. Still support DI, routing, validation, Swagger. Trade-off: Less structured than MVC, harder to organize with many endpoints.

**Key Interview Points:**
- Define routes directly in Program.cs (no controllers)
- Faster startup, less memory than MVC
- Support: DI, routing, filters, validation, OpenAPI
- Use for: Microservices, simple APIs, lambdas
- Controllers for: Complex apps, many endpoints
- Can mix Minimal APIs and Controllers

**Coding Example:**
```csharp
// Minimal API example
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET endpoint
app.MapGet("/api/products", async (AppDbContext db) =>
{
    return await db.Products.ToListAsync();
});

// GET with route parameter
app.MapGet("/api/products/{id}", async (int id, AppDbContext db) =>
{
    var product = await db.Products.FindAsync(id);
    return product is not null ? Results.Ok(product) : Results.NotFound();
});

// POST endpoint with validation
app.MapPost("/api/products", async (Product product, AppDbContext db) =>
{
    if (string.IsNullOrEmpty(product.Name))
        return Results.BadRequest("Name is required");
    
    db.Products.Add(product);
    await db.SaveChangesAsync();
    
    return Results.Created($"/api/products/{product.Id}", product);
})
.WithName("CreateProduct")
.Produces<Product>(StatusCodes.Status201Created)
.ProducesValidationProblem();

// PUT endpoint
app.MapPut("/api/products/{id}", async (int id, Product updatedProduct, AppDbContext db) =>
{
    var product = await db.Products.FindAsync(id);
    if (product is null) return Results.NotFound();
    
    product.Name = updatedProduct.Name;
    product.Price = updatedProduct.Price;
    await db.SaveChangesAsync();
    
    return Results.NoContent();
});

// DELETE endpoint
app.MapDelete("/api/products/{id}", async (int id, AppDbContext db) =>
{
    var product = await db.Products.FindAsync(id);
    if (product is null) return Results.NotFound();
    
    db.Products.Remove(product);
    await db.SaveChangesAsync();
    
    return Results.NoContent();
});

// Group endpoints
var productsGroup = app.MapGroup("/api/products")
    .WithTags("Products")
    .RequireAuthorization();

productsGroup.MapGet("/", async (AppDbContext db) => await db.Products.ToListAsync());
productsGroup.MapGet("/{id}", async (int id, AppDbContext db) => await db.Products.FindAsync(id));

// Endpoint filters
app.MapGet("/api/admin/products", async (AppDbContext db) =>
{
    return await db.Products.ToListAsync();
})
.AddEndpointFilter(async (context, next) =>
{
    // Custom logic before handler
    var result = await next(context);
    // Custom logic after handler
    return result;
});

app.Run();

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } }
public class AppDbContext : DbContext { public DbSet<Product> Products { get; set; } }
```

---

### Question 67: Explain Azure Service Bus vs Azure Storage Queues. When to use each?

**Short Theory:**  
**Azure Service Bus**: Enterprise messaging with sessions, transactions, dead-letter queue, duplicate detection, topics/subscriptions, scheduled messages. Supports FIFO, large messages (256KB-1MB). **Storage Queues**: Simple, cheap, unlimited size, REST API, best-effort ordering. Use Service Bus for: Complex scenarios, reliability, pub-sub. Use Storage Queues for: Simple queuing, cost-sensitive, audit logs.

**Why do we use it?**  
Service Bus provides enterprise features: guaranteed order, transactions, duplicate detection. Storage Queues are simpler and cheaper but lack advanced features. Choose based on requirements: Service Bus for mission-critical, Storage Queues for simple async processing. Service Bus integrates better with enterprise apps.

**Key Interview Points:**
- Service Bus: Enterprise features, FIFO, sessions, pub-sub
- Storage Queues: Simple, cheap, unlimited size
- Service Bus: 256KB-1MB messages, dead-letter, duplicate detection
- Storage Queues: 64KB messages, best-effort ordering
- Use Service Bus for: Complex scenarios, reliability
- Use Storage Queues for: Simple queuing, cost optimization

**Coding Example:**
```csharp
// Azure Service Bus example
// Install: Azure.Messaging.ServiceBus

public class ServiceBusService
{
    private readonly ServiceBusClient _client;
    private readonly ServiceBusSender _sender;
    
    public ServiceBusService(string connectionString, string queueName)
    {
        _client = new ServiceBusClient(connectionString);
        _sender = _client.CreateSender(queueName);
    }
    
    // Send message
    public async Task SendMessageAsync(Order order)
    {
        var message = new ServiceBusMessage(JsonSerializer.Serialize(order))
        {
            MessageId = order.Id.ToString(),
            SessionId = order.CustomerId, // Enable sessions
            ScheduledEnqueueTime = DateTime.UtcNow.AddMinutes(5) // Scheduled delivery
        };
        
        await _sender.SendMessageAsync(message);
    }
    
    // Receive messages
    public async Task ReceiveMessagesAsync(string queueName)
    {
        var receiver = _client.CreateReceiver(queueName);
        
        while (true)
        {
            var message = await receiver.ReceiveMessageAsync(TimeSpan.FromSeconds(30));
            if (message == null) break;
            
            try
            {
                var order = JsonSerializer.Deserialize<Order>(message.Body.ToString());
                await ProcessOrderAsync(order);
                
                // Complete (delete) message
                await receiver.CompleteMessageAsync(message);
            }
            catch (Exception ex)
            {
                // Move to dead-letter queue
                await receiver.DeadLetterMessageAsync(message, "ProcessingFailed", ex.Message);
            }
        }
    }
    
    private Task ProcessOrderAsync(Order order) => Task.CompletedTask;
}

// Azure Storage Queue example
// Install: Azure.Storage.Queues

public class StorageQueueService
{
    private readonly QueueClient _queueClient;
    
    public StorageQueueService(string connectionString, string queueName)
    {
        _queueClient = new QueueClient(connectionString, queueName);
        _queueClient.CreateIfNotExists();
    }
    
    // Send message
    public async Task SendMessageAsync(string message)
    {
        await _queueClient.SendMessageAsync(Convert.ToBase64String(Encoding.UTF8.GetBytes(message)));
    }
    
    // Receive messages
    public async Task ReceiveMessagesAsync()
    {
        while (true)
        {
            var messages = await _queueClient.ReceiveMessagesAsync(maxMessages: 10);
            
            if (!messages.Value.Any()) break;
            
            foreach (var message in messages.Value)
            {
                try
                {
                    var content = Encoding.UTF8.GetString(Convert.FromBase64String(message.MessageText));
                    await ProcessMessageAsync(content);
                    
                    // Delete message
                    await _queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt);
                }
                catch (Exception)
                {
                    // Message becomes visible again after visibility timeout
                }
            }
        }
    }
    
    private Task ProcessMessageAsync(string content) => Task.CompletedTask;
}

// Supporting types
public class Order { public int Id { get; set; } public string CustomerId { get; set; } public decimal Total { get; set; } }
```

---

### Question 68: What is Blazor? Explain Blazor Server vs Blazor WebAssembly.

**Short Theory:**  
Blazor enables building web UIs with C# instead of JavaScript. **Blazor Server**: Runs on server, SignalR connection to client, small payload, instant load. **Blazor WebAssembly**: Runs in browser via WebAssembly, offline capable, larger download. **Blazor Hybrid**: Native mobile/desktop with WebView. Use Server for internal apps, WebAssembly for public apps, Hybrid for desktop/mobile.

**Why do we use it?**  
Share C# code between frontend and backend. Leverage existing .NET libraries. No JavaScript required (can interop if needed). Blazor Server has low latency but requires persistent connection. WebAssembly is SPA-like but has large initial download. Choose based on deployment model and connectivity requirements.

**Key Interview Points:**
- Build web UIs with C# (not JavaScript)
- Server: Runs on server, SignalR connection, low bandwidth
- WebAssembly: Runs in browser, offline, larger download
- Share code/libraries with backend
- Component-based (similar to React/Vue)
- JavaScript interop available when needed

**Coding Example:**
```csharp
// Blazor Component (Counter.razor)
@page "/counter"
@inject IProductService ProductService

<PageTitle>Products</PageTitle>

<h1>Product List</h1>

@if (products == null)
{
    <p><em>Loading...</em></p>
}
else
{
    <table class="table">
        <thead>
            <tr>
                <th>Name</th>
                <th>Price</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var product in products)
            {
                <tr>
                    <td>@product.Name</td>
                    <td>@product.Price.ToString("C")</td>
                    <td>
                        <button class="btn btn-primary" @onclick="() => EditProduct(product.Id)">
                            Edit
                        </button>
                    </td>
                </tr>
            }
        </tbody>
    </table>
}

<button class="btn btn-success" @onclick="AddProduct">Add Product</button>

@code {
    private List<Product>? products;
    
    protected override async Task OnInitializedAsync()
    {
        products = await ProductService.GetProductsAsync();
    }
    
    private void EditProduct(int id)
    {
        // Navigate or show edit form
    }
    
    private void AddProduct()
    {
        // Show add form
    }
}

// Reusable component (ProductCard.razor)
<div class="card">
    <div class="card-body">
        <h5 class="card-title">@Product.Name</h5>
        <p class="card-text">@Product.Price.ToString("C")</p>
        <button class="btn btn-primary" @onclick="OnEdit">Edit</button>
    </div>
</div>

@code {
    [Parameter]
    public Product Product { get; set; } = default!;
    
    [Parameter]
    public EventCallback<int> OnEdit { get; set; }
}

// Program.cs - Blazor Server
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

// Program.cs - Blazor WebAssembly
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});

builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();

// JavaScript interop
@inject IJSRuntime JS

@code {
    private async Task ShowAlert(string message)
    {
        await JS.InvokeVoidAsync("alert", message);
    }
    
    private async Task<string> GetLocalStorage(string key)
    {
        return await JS.InvokeAsync<string>("localStorage.getItem", key);
    }
}

// Supporting types
public interface IProductService { Task<List<Product>> GetProductsAsync(); }
public class ProductService : IProductService 
{ 
    public Task<List<Product>> GetProductsAsync() => 
        Task.FromResult(new List<Product> { new() { Id = 1, Name = "Product 1", Price = 10.99m } });
}
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } }
```

---

### Question 69: Explain BenchmarkDotNet. How do you measure and optimize performance?

**Short Theory:**  
BenchmarkDotNet provides accurate .NET performance benchmarking. Measures execution time, memory allocations, CPU cycles. Handles warmup, outliers, statistics. Use `[Benchmark]` attribute, compare implementations with `[Params]`. Reports mean, median, StdDev, allocations. Essential for performance optimization decisions—measure before optimizing.

**Why do we use it?**  
Microbenchmarks are hard—JIT, GC, CPU cache affect results. BenchmarkDotNet handles complexities: warmup, iterations, statistical analysis. Make data-driven optimization decisions. Compare algorithm implementations objectively. Avoid premature optimization—benchmark proves necessity.

**Key Interview Points:**
- Accurate .NET performance benchmarking
- Measures: Time, memory allocations, CPU
- Handles warmup, JIT, GC interference
- Use [Benchmark] attribute, compare with [Params]
- Reports statistics: Mean, Median, StdDev, Gen0/1/2
- Essential for data-driven optimization

**Coding Example:**
```csharp
// Install: BenchmarkDotNet

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// Benchmark class
[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 5)]
public class StringConcatBenchmark
{
    [Params(10, 100, 1000)]
    public int ItemCount { get; set; }
    
    [Benchmark(Baseline = true)]
    public string StringConcat()
    {
        var result = "";
        for (int i = 0; i < ItemCount; i++)
        {
            result += i.ToString(); // Allocates new string each time
        }
        return result;
    }
    
    [Benchmark]
    public string StringBuilder()
    {
        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < ItemCount; i++)
        {
            sb.Append(i);
        }
        return sb.ToString();
    }
    
    [Benchmark]
    public string StringCreate()
    {
        return string.Create(ItemCount * 4, ItemCount, (span, count) =>
        {
            int pos = 0;
            for (int i = 0; i < count; i++)
            {
                var str = i.ToString();
                str.AsSpan().CopyTo(span.Slice(pos));
                pos += str.Length;
            }
        });
    }
}

// LINQ optimization benchmark
[MemoryDiagnoser]
public class LinqBenchmark
{
    private List<int> _numbers;
    
    [GlobalSetup]
    public void Setup()
    {
        _numbers = Enumerable.Range(1, 1000).ToList();
    }
    
    [Benchmark(Baseline = true)]
    public int LinqWhere()
    {
        return _numbers.Where(x => x > 500).Sum();
    }
    
    [Benchmark]
    public int ForLoop()
    {
        int sum = 0;
        for (int i = 0; i < _numbers.Count; i++)
        {
            if (_numbers[i] > 500)
                sum += _numbers[i];
        }
        return sum;
    }
    
    [Benchmark]
    public int Span()
    {
        var span = CollectionsMarshal.AsSpan(_numbers);
        int sum = 0;
        for (int i = 0; i < span.Length; i++)
        {
            if (span[i] > 500)
                sum += span[i];
        }
        return sum;
    }
}

// Async benchmark
[MemoryDiagnoser]
public class AsyncBenchmark
{
    [Benchmark]
    public async Task<int> AsyncAwait()
    {
        return await Task.FromResult(42);
    }
    
    [Benchmark]
    public Task<int> TaskFromResult()
    {
        return Task.FromResult(42);
    }
    
    [Benchmark]
    public ValueTask<int> ValueTask()
    {
        return new ValueTask<int>(42);
    }
}

// Run benchmarks
public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StringConcatBenchmark>();
        // Or run all benchmarks in assembly
        // BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}

/* Example output:
|         Method | ItemCount |        Mean |     Error |   Gen0 | Allocated |
|--------------- |---------- |------------:|----------:|-------:|----------:|
|   StringConcat |        10 |    157.3 ns |   3.21 ns | 0.0610 |     384 B |
| StringBuilder  |        10 |    134.6 ns |   2.45 ns | 0.0267 |     168 B |
|   StringCreate |        10 |     98.2 ns |   1.87 ns | 0.0191 |     120 B |
*/
```

---

### Question 70: Explain the Strategy pattern. How is it used in ASP.NET Core?

**Short Theory:**  
Strategy pattern defines family of algorithms, encapsulates each, makes them interchangeable. Context uses strategy interface, concrete strategies implement algorithms. Runtime algorithm selection. Use for: Payment processing (Credit Card, PayPal, Bitcoin), logging (File, Database, Cloud), compression (Zip, Gzip, Brotli). Alternative to conditional statements and inheritance.

**Why do we use it?**  
Eliminates long if-else chains. Add new strategies without modifying existing code (Open-Closed Principle). Switch algorithms at runtime. Testable—mock strategies easily. ASP.NET Core uses internally: Middleware (different processing strategies), Authentication (multiple schemes), Model binding (different sources).

**Key Interview Points:**
- Define family of interchangeable algorithms
- Context uses strategy interface
- Select strategy at runtime
- Eliminates if-else chains
- Use for: Payment, logging, compression, validation
- Follows Open-Closed Principle

**Coding Example:**
```csharp
// Strategy interface
public interface IPaymentStrategy
{
    Task<PaymentResult> ProcessPaymentAsync(decimal amount, PaymentDetails details);
}

// Concrete strategies
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public async Task<PaymentResult> ProcessPaymentAsync(decimal amount, PaymentDetails details)
    {
        // Process credit card
        await Task.Delay(100); // Simulate API call
        return new PaymentResult { Success = true, TransactionId = Guid.NewGuid().ToString() };
    }
}

public class PayPalPaymentStrategy : IPaymentStrategy
{
    public async Task<PaymentResult> ProcessPaymentAsync(decimal amount, PaymentDetails details)
    {
        // Process PayPal
        await Task.Delay(150);
        return new PaymentResult { Success = true, TransactionId = Guid.NewGuid().ToString() };
    }
}

public class CryptoPaymentStrategy : IPaymentStrategy
{
    public async Task<PaymentResult> ProcessPaymentAsync(decimal amount, PaymentDetails details)
    {
        // Process cryptocurrency
        await Task.Delay(200);
        return new PaymentResult { Success = true, TransactionId = Guid.NewGuid().ToString() };
    }
}

// Context
public class PaymentProcessor
{
    private readonly IEnumerable<IPaymentStrategy> _strategies;
    
    public PaymentProcessor(IEnumerable<IPaymentStrategy> strategies)
    {
        _strategies = strategies;
    }
    
    public async Task<PaymentResult> ProcessAsync(PaymentMethod method, decimal amount, PaymentDetails details)
    {
        // Select strategy based on method
        var strategy = method switch
        {
            PaymentMethod.CreditCard => _strategies.OfType<CreditCardPaymentStrategy>().First(),
            PaymentMethod.PayPal => _strategies.OfType<PayPalPaymentStrategy>().First(),
            PaymentMethod.Crypto => _strategies.OfType<CryptoPaymentStrategy>().First(),
            _ => throw new NotSupportedException($"Payment method {method} not supported")
        };
        
        return await strategy.ProcessPaymentAsync(amount, details);
    }
}

// DI registration
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPaymentStrategies(this IServiceCollection services)
    {
        services.AddScoped<IPaymentStrategy, CreditCardPaymentStrategy>();
        services.AddScoped<IPaymentStrategy, PayPalPaymentStrategy>();
        services.AddScoped<IPaymentStrategy, CryptoPaymentStrategy>();
        services.AddScoped<PaymentProcessor>();
        
        return services;
    }
}

// Controller usage
[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly PaymentProcessor _processor;
    
    public PaymentsController(PaymentProcessor processor) => _processor = processor;
    
    [HttpPost]
    public async Task<IActionResult> ProcessPayment([FromBody] PaymentRequest request)
    {
        var result = await _processor.ProcessAsync(request.Method, request.Amount, request.Details);
        
        return result.Success 
            ? Ok(new { TransactionId = result.TransactionId })
            : BadRequest(new { Error = result.ErrorMessage });
    }
}

// Alternative: Factory pattern for strategy selection
public class PaymentStrategyFactory
{
    private readonly IServiceProvider _serviceProvider;
    
    public PaymentStrategyFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public IPaymentStrategy GetStrategy(PaymentMethod method)
    {
        return method switch
        {
            PaymentMethod.CreditCard => _serviceProvider.GetRequiredService<CreditCardPaymentStrategy>(),
            PaymentMethod.PayPal => _serviceProvider.GetRequiredService<PayPalPaymentStrategy>(),
            PaymentMethod.Crypto => _serviceProvider.GetRequiredService<CryptoPaymentStrategy>(),
            _ => throw new NotSupportedException()
        };
    }
}

// Supporting types
public enum PaymentMethod { CreditCard, PayPal, Crypto }
public class PaymentDetails { public string AccountInfo { get; set; } }
public class PaymentResult { public bool Success { get; set; } public string TransactionId { get; set; } public string ErrorMessage { get; set; } }
public class PaymentRequest { public PaymentMethod Method { get; set; } public decimal Amount { get; set; } public PaymentDetails Details { get; set; } }
```

---

**Batch 12 completed (Questions 66-70). Continue with next batch.**

---

## Batch 13: Observability & Advanced Patterns (Questions 71-75)

### Question 71: Explain structured logging with Serilog. Why is it better than traditional logging?

**Short Theory:**  
Structured logging captures log data as structured objects, not strings. Serilog uses message templates with properties (`Log.Information("User {UserId} logged in", userId)`). Query logs by properties, not regex. Sinks: Console, File, Elasticsearch, Seq, Application Insights. Enrichers add context (machine, thread, correlation ID). Better than string logging—searchable, analyzable, machine-readable.

**Why do we use it?**  
Traditional logs are unstructured strings—hard to query. Structured logs enable filtering by properties: `WHERE UserId = 123`. Essential for distributed systems and log aggregation. Serilog is high-performance, flexible sink system. Correlation IDs track requests across services. Critical for production debugging and monitoring.

**Key Interview Points:**
- Structured logs: Properties, not strings
- Message templates: `"User {UserId} logged in"`
- Query by properties, not regex
- Sinks: File, Elasticsearch, Seq, AppInsights
- Enrichers: Add context (correlation ID, machine name)
- Better searchability and analytics

**Coding Example:**
```csharp
// Install: Serilog.AspNetCore, Serilog.Sinks.Console, Serilog.Sinks.File, Serilog.Sinks.Seq

// Program.cs
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .Enrich.WithMachineName()
    .Enrich.WithThreadId()
    .Enrich.WithProperty("Application", "MyApp")
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}")
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
    .WriteTo.Seq("http://localhost:5341") // Seq log server
    .CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();

// Request logging middleware
app.UseSerilogRequestLogging(options =>
{
    options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
    {
        diagnosticContext.Set("UserAgent", httpContext.Request.Headers["User-Agent"]);
        diagnosticContext.Set("ClientIP", httpContext.Connection.RemoteIpAddress);
    };
});

app.MapControllers();

try
{
    Log.Information("Starting application");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application failed to start");
}
finally
{
    Log.CloseAndFlush();
}

// Service with structured logging
public class OrderService
{
    private readonly ILogger<OrderService> _logger;
    
    public OrderService(ILogger<OrderService> logger) => _logger = logger;
    
    public async Task<Order> CreateOrderAsync(Order order)
    {
        // Structured logging with properties
        _logger.LogInformation("Creating order for customer {CustomerId} with {ItemCount} items, Total: {Total:C}",
            order.CustomerId, order.Items.Count, order.Total);
        
        // Query in Seq: CustomerId = "CUST123"
        
        try
        {
            // Process order
            _logger.LogDebug("Validating order {OrderId}", order.Id);
            
            // Success
            _logger.LogInformation("Order {OrderId} created successfully in {ElapsedMs}ms",
                order.Id, 123);
            
            return order;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to create order for customer {CustomerId}", order.CustomerId);
            throw;
        }
    }
}

// LogContext for correlation
public class CorrelationMiddleware
{
    private readonly RequestDelegate _next;
    
    public CorrelationMiddleware(RequestDelegate next) => _next = next;
    
    public async Task InvokeAsync(HttpContext context)
    {
        var correlationId = context.Request.Headers["X-Correlation-ID"].FirstOrDefault()
            ?? Guid.NewGuid().ToString();
        
        // Push correlation ID to log context
        using (LogContext.PushProperty("CorrelationId", correlationId))
        {
            context.Response.Headers.Add("X-Correlation-ID", correlationId);
            await _next(context);
        }
    }
}

// Custom enricher
public class UserEnricher : ILogEventEnricher
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    
    public UserEnricher(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext?.User?.Identity?.IsAuthenticated == true)
        {
            var userIdProperty = propertyFactory.CreateProperty("UserId", httpContext.User.FindFirst("sub")?.Value);
            logEvent.AddPropertyIfAbsent(userIdProperty);
        }
    }
}

// Supporting types
public class Order { public int Id { get; set; } public string CustomerId { get; set; } public decimal Total { get; set; } public List<OrderItem> Items { get; set; } }
public class OrderItem { public int ProductId { get; set; } public int Quantity { get; set; } }
```

---

### Question 72: Explain Application Monitoring with Application Insights and OpenTelemetry.

**Short Theory:**  
Application Insights provides telemetry: requests, dependencies, exceptions, custom events, metrics. Automatic instrumentation for ASP.NET Core. OpenTelemetry is vendor-neutral observability (traces, metrics, logs). Use distributed tracing to track requests across microservices. Custom metrics for business KPIs. Alerting on anomalies. Essential for production monitoring and performance troubleshooting.

**Why do we use it?**  
Production visibility: response times, failure rates, dependencies. Distributed tracing shows request flow across services. Custom telemetry tracks business metrics (orders/hour, revenue). Proactive alerts prevent outages. Application Insights integrates with Azure. OpenTelemetry provides vendor flexibility. Cannot operate production services blind.

**Key Interview Points:**
- Telemetry: Requests, dependencies, exceptions, metrics
- Distributed tracing across microservices
- Custom metrics for business KPIs
- Application Insights: Azure monitoring
- OpenTelemetry: Vendor-neutral standard
- Alerts and dashboards for proactive monitoring

**Coding Example:**
```csharp
// Install: Microsoft.ApplicationInsights.AspNetCore

// Program.cs - Application Insights
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationInsightsTelemetry(options =>
{
    options.ConnectionString = builder.Configuration["ApplicationInsights:ConnectionString"];
});

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();

// Custom telemetry
public class OrderService
{
    private readonly TelemetryClient _telemetry;
    private readonly ILogger<OrderService> _logger;
    
    public OrderService(TelemetryClient telemetry, ILogger<OrderService> logger)
    {
        _telemetry = telemetry;
        _logger = logger;
    }
    
    public async Task<Order> CreateOrderAsync(Order order)
    {
        var sw = Stopwatch.StartNew();
        
        try
        {
            // Track custom event
            _telemetry.TrackEvent("OrderCreated", new Dictionary<string, string>
            {
                { "CustomerId", order.CustomerId },
                { "OrderValue", order.Total.ToString() }
            });
            
            // Track custom metric
            _telemetry.TrackMetric("OrderValue", order.Total);
            
            // Simulate external dependency
            await TrackDependencyAsync("PaymentGateway", "ProcessPayment", async () =>
            {
                await Task.Delay(100);
                return true;
            });
            
            sw.Stop();
            _telemetry.TrackMetric("OrderCreationTime", sw.ElapsedMilliseconds);
            
            return order;
        }
        catch (Exception ex)
        {
            _telemetry.TrackException(ex, new Dictionary<string, string>
            {
                { "OrderId", order.Id.ToString() },
                { "CustomerId", order.CustomerId }
            });
            throw;
        }
    }
    
    private async Task<T> TrackDependencyAsync<T>(string dependencyType, string name, Func<Task<T>> operation)
    {
        var sw = Stopwatch.StartNew();
        bool success = true;
        
        try
        {
            return await operation();
        }
        catch
        {
            success = false;
            throw;
        }
        finally
        {
            sw.Stop();
            _telemetry.TrackDependency(dependencyType, name, DateTimeOffset.UtcNow, sw.Elapsed, success);
        }
    }
}

// OpenTelemetry example
// Install: OpenTelemetry.Extensions.Hosting, OpenTelemetry.Instrumentation.AspNetCore

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenTelemetry()
    .WithTracing(tracing =>
    {
        tracing
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation()
            .AddSqlClientInstrumentation()
            .AddConsoleExporter()
            .AddJaegerExporter(options =>
            {
                options.AgentHost = "localhost";
                options.AgentPort = 6831;
            });
    })
    .WithMetrics(metrics =>
    {
        metrics
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation()
            .AddPrometheusExporter();
    });

// Custom activity tracking
public class CustomTracingService
{
    private static readonly ActivitySource ActivitySource = new("MyApp");
    
    public async Task ProcessOrderAsync(Order order)
    {
        using var activity = ActivitySource.StartActivity("ProcessOrder");
        activity?.SetTag("order.id", order.Id);
        activity?.SetTag("customer.id", order.CustomerId);
        
        await Task.Delay(100);
        
        using var childActivity = ActivitySource.StartActivity("ValidateOrder");
        childActivity?.SetTag("validation.result", "success");
        await Task.Delay(50);
    }
}

// Supporting types
public class Order { public int Id { get; set; } public string CustomerId { get; set; } public decimal Total { get; set; } }
```

---

### Question 73: What is the Saga pattern? How do you handle distributed transactions?

**Short Theory:**  
Saga pattern manages distributed transactions across microservices using compensating transactions. Two types: **Choreography** (event-driven, services react to events) and **Orchestration** (central coordinator). Each step has compensating action to undo on failure. No ACID guarantees—eventual consistency. Use for: Multi-service workflows, long-running processes. Alternative to distributed transactions (2PC is impractical in microservices).

**Why do we use it?**  
Distributed transactions (2PC) don't scale in microservices—network failures, lock timeouts. Saga provides eventual consistency with compensation. Order saga: Reserve inventory → Process payment → Ship order. If payment fails, release inventory (compensate). Critical for e-commerce, booking systems. Trade-off: Complexity, eventual consistency.

**Key Interview Points:**
- Manage distributed transactions with compensation
- Choreography: Event-driven, decentralized
- Orchestration: Central coordinator
- Each step has compensating action
- Eventual consistency, not ACID
- Use for: Multi-service workflows, long-running processes

**Coding Example:**
```csharp
// Saga Orchestration example with MassTransit

// Saga state
public class OrderSagaState : SagaStateMachineInstance
{
    public Guid CorrelationId { get; set; }
    public string CurrentState { get; set; }
    public int OrderId { get; set; }
    public string CustomerId { get; set; }
    public decimal Amount { get; set; }
    public int InventoryReservationId { get; set; }
    public string PaymentTransactionId { get; set; }
}

// Saga definition
public class OrderSaga : MassTransitStateMachine<OrderSagaState>
{
    public State InventoryReserved { get; private set; }
    public State PaymentProcessed { get; private set; }
    public State OrderCompleted { get; private set; }
    public State OrderFailed { get; private set; }
    
    public Event<OrderSubmitted> OrderSubmittedEvent { get; private set; }
    public Event<InventoryReserved> InventoryReservedEvent { get; private set; }
    public Event<InventoryReservationFailed> InventoryReservationFailedEvent { get; private set; }
    public Event<PaymentProcessed> PaymentProcessedEvent { get; private set; }
    public Event<PaymentFailed> PaymentFailedEvent { get; private set; }
    
    public OrderSaga()
    {
        InstanceState(x => x.CurrentState);
        
        Event(() => OrderSubmittedEvent, x => x.CorrelateById(m => m.Message.OrderId));
        Event(() => InventoryReservedEvent, x => x.CorrelateById(m => m.Message.OrderId));
        Event(() => InventoryReservationFailedEvent, x => x.CorrelateById(m => m.Message.OrderId));
        Event(() => PaymentProcessedEvent, x => x.CorrelateById(m => m.Message.OrderId));
        Event(() => PaymentFailedEvent, x => x.CorrelateById(m => m.Message.OrderId));
        
        Initially(
            When(OrderSubmittedEvent)
                .Then(context =>
                {
                    context.Saga.OrderId = context.Message.OrderId;
                    context.Saga.CustomerId = context.Message.CustomerId;
                    context.Saga.Amount = context.Message.Amount;
                })
                .Publish(context => new ReserveInventory(context.Saga.OrderId, context.Message.Items))
                .TransitionTo(InventoryReserved)
        );
        
        During(InventoryReserved,
            When(InventoryReservedEvent)
                .Then(context => context.Saga.InventoryReservationId = context.Message.ReservationId)
                .Publish(context => new ProcessPayment(context.Saga.OrderId, context.Saga.Amount))
                .TransitionTo(PaymentProcessed),
            
            When(InventoryReservationFailedEvent)
                .TransitionTo(OrderFailed)
                .Finalize()
        );
        
        During(PaymentProcessed,
            When(PaymentProcessedEvent)
                .Then(context => context.Saga.PaymentTransactionId = context.Message.TransactionId)
                .Publish(context => new ShipOrder(context.Saga.OrderId))
                .TransitionTo(OrderCompleted)
                .Finalize(),
            
            When(PaymentFailedEvent)
                // Compensate: Release inventory
                .Publish(context => new ReleaseInventory(context.Saga.InventoryReservationId))
                .TransitionTo(OrderFailed)
                .Finalize()
        );
    }
}

// Events
public record OrderSubmitted(Guid OrderId, string CustomerId, decimal Amount, List<OrderItem> Items);
public record ReserveInventory(Guid OrderId, List<OrderItem> Items);
public record InventoryReserved(Guid OrderId, int ReservationId);
public record InventoryReservationFailed(Guid OrderId, string Reason);
public record ProcessPayment(Guid OrderId, decimal Amount);
public record PaymentProcessed(Guid OrderId, string TransactionId);
public record PaymentFailed(Guid OrderId, string Reason);
public record ReleaseInventory(int ReservationId);
public record ShipOrder(Guid OrderId);

// Service handling inventory
public class InventoryService : IConsumer<ReserveInventory>
{
    public async Task Consume(ConsumeContext<ReserveInventory> context)
    {
        try
        {
            // Reserve inventory
            var reservationId = await ReserveItemsAsync(context.Message.Items);
            
            await context.Publish(new InventoryReserved(context.Message.OrderId, reservationId));
        }
        catch
        {
            await context.Publish(new InventoryReservationFailed(context.Message.OrderId, "Out of stock"));
        }
    }
    
    private Task<int> ReserveItemsAsync(List<OrderItem> items) => Task.FromResult(12345);
}

// Supporting types
public class OrderItem { public int ProductId { get; set; } public int Quantity { get; set; } }
```

---

### Question 74: Explain the Observer pattern and how C# events implement it.

**Short Theory:**  
Observer pattern defines one-to-many dependency—when subject changes, observers are notified. C# events implement observer pattern: publisher raises event, subscribers handle it. Delegates enable type-safe event handling. Use for: UI updates, domain events, pub-sub messaging. EventHandler<T> is standard delegate. Unsubscribe to prevent memory leaks (`-=`).

**Why do we use it?**  
Decouple components—publisher doesn't know subscribers. Add/remove observers dynamically. Essential for reactive systems, UI frameworks, domain events. C# events are language-level observer pattern. Weak events prevent memory leaks in long-lived subscriptions.

**Key Interview Points:**
- One-to-many: Subject notifies observers
- C# events implement observer pattern
- Publisher raises, subscribers handle
- Use `+=` to subscribe, `-=` to unsubscribe
- EventHandler<T> standard delegate
- Prevent memory leaks by unsubscribing

**Coding Example:**
```csharp
// Subject (Publisher)
public class OrderService
{
    // Event declaration
    public event EventHandler<OrderCreatedEventArgs> OrderCreated;
    
    public async Task<Order> CreateOrderAsync(Order order)
    {
        // Save order
        await SaveOrderAsync(order);
        
        // Raise event
        OnOrderCreated(new OrderCreatedEventArgs(order));
        
        return order;
    }
    
    protected virtual void OnOrderCreated(OrderCreatedEventArgs e)
    {
        // Thread-safe event invocation
        OrderCreated?.Invoke(this, e);
    }
    
    private Task SaveOrderAsync(Order order) => Task.CompletedTask;
}

// Event args
public class OrderCreatedEventArgs : EventArgs
{
    public Order Order { get; }
    
    public OrderCreatedEventArgs(Order order)
    {
        Order = order;
    }
}

// Observers (Subscribers)
public class EmailNotificationService
{
    public EmailNotificationService(OrderService orderService)
    {
        // Subscribe to event
        orderService.OrderCreated += OnOrderCreated;
    }
    
    private async void OnOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        await SendEmailAsync(e.Order.CustomerId, "Order confirmation");
    }
    
    private Task SendEmailAsync(string customerId, string subject) => Task.CompletedTask;
}

public class InventoryService
{
    public InventoryService(OrderService orderService)
    {
        orderService.OrderCreated += OnOrderCreated;
    }
    
    private async void OnOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        await UpdateInventoryAsync(e.Order.Items);
    }
    
    private Task UpdateInventoryAsync(List<OrderItem> items) => Task.CompletedTask;
}

// Generic observer pattern
public interface IObserver<T>
{
    void OnNext(T value);
    void OnError(Exception error);
    void OnCompleted();
}

public interface IObservable<T>
{
    IDisposable Subscribe(IObserver<T> observer);
}

// Implementation
public class StockPriceMonitor : IObservable<decimal>
{
    private readonly List<IObserver<decimal>> _observers = new();
    
    public IDisposable Subscribe(IObserver<decimal> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        
        return new Unsubscriber(_observers, observer);
    }
    
    public void UpdatePrice(decimal price)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(price);
        }
    }
    
    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<decimal>> _observers;
        private readonly IObserver<decimal> _observer;
        
        public Unsubscriber(List<IObserver<decimal>> observers, IObserver<decimal> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        
        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}

public class StockDisplay : IObserver<decimal>
{
    public void OnNext(decimal price)
    {
        Console.WriteLine($"Stock price: {price:C}");
    }
    
    public void OnError(Exception error)
    {
        Console.WriteLine($"Error: {error.Message}");
    }
    
    public void OnCompleted()
    {
        Console.WriteLine("Monitoring completed");
    }
}

// Usage
var monitor = new StockPriceMonitor();
var display = new StockDisplay();
using var subscription = monitor.Subscribe(display);

monitor.UpdatePrice(100.50m);
monitor.UpdatePrice(101.25m);

// Supporting types
public class Order { public int Id { get; set; } public string CustomerId { get; set; } public List<OrderItem> Items { get; set; } }
public class OrderItem { public int ProductId { get; set; } public int Quantity { get; set; } }
```

---

### Question 75: Explain API Gateway pattern and Ocelot implementation.

**Short Theory:**  
API Gateway is single entry point for microservices. Routes requests to appropriate services, handles cross-cutting concerns: authentication, rate limiting, caching, load balancing, request aggregation. Ocelot is .NET API Gateway. BFF (Backend for Frontend) pattern uses different gateways per client type. Alternative to client calling services directly.

**Why do we use it?**  
Clients don't need to know service locations or handle multiple calls. Gateway provides unified API, security enforcement, protocol translation (REST to gRPC). Centralized logging, monitoring, rate limiting. Simplifies client code. Essential for microservices architecture. Trade-off: Single point of failure (use redundancy), adds latency.

**Key Interview Points:**
- Single entry point for microservices
- Routes requests to appropriate services
- Cross-cutting: Auth, rate limiting, caching, aggregation
- Ocelot: .NET API Gateway
- BFF pattern: Different gateways per client
- Simplifies clients, centralizes concerns

**Coding Example:**
```csharp
// Install: Ocelot

// ocelot.json configuration
/*
{
  "Routes": [
    {
      "DownstreamPathTemplate": "/api/products",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        { "Host": "localhost", "Port": 5001 }
      ],
      "UpstreamPathTemplate": "/products",
      "UpstreamHttpMethod": [ "GET", "POST" ],
      "RateLimitOptions": {
        "EnableRateLimiting": true,
        "Period": "1m",
        "Limit": 100
      }
    },
    {
      "DownstreamPathTemplate": "/api/orders/{id}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        { "Host": "localhost", "Port": 5002 }
      ],
      "UpstreamPathTemplate": "/orders/{id}",
      "UpstreamHttpMethod": [ "GET", "PUT", "DELETE" ],
      "AuthenticationOptions": {
        "AuthenticationProviderKey": "Bearer"
      }
    },
    {
      "DownstreamPathTemplate": "/api/users/{userId}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        { "Host": "localhost", "Port": 5003 }
      ],
      "UpstreamPathTemplate": "/users/{userId}",
      "UpstreamHttpMethod": [ "GET" ],
      "FileCacheOptions": {
        "TtlSeconds": 30
      }
    }
  ],
  "GlobalConfiguration": {
    "BaseUrl": "https://api.myapp.com",
    "RateLimitOptions": {
      "DisableRateLimitHeaders": false,
      "QuotaExceededMessage": "Rate limit exceeded",
      "HttpStatusCode": 429
    }
  }
}
*/

// Program.cs - API Gateway
var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer("Bearer", options =>
    {
        options.Authority = "https://auth.myapp.com";
        options.Audience = "api";
    });

builder.Services.AddOcelot();

var app = builder.Build();

app.UseOcelot().Wait();

app.Run();

// Custom middleware for Ocelot
public class CustomHeaderMiddleware
{
    private readonly RequestDelegate _next;
    
    public CustomHeaderMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        context.Request.Headers.Add("X-Gateway", "Ocelot");
        context.Request.Headers.Add("X-Request-Id", Guid.NewGuid().ToString());
        
        await _next(context);
    }
}

// Request aggregation example
/*
{
  "Routes": [],
  "Aggregates": [
    {
      "RouteKeys": [
        "ProductDetails",
        "ProductReviews",
        "ProductInventory"
      ],
      "UpstreamPathTemplate": "/products/{id}/summary"
    }
  ]
}
*/

// BFF (Backend for Frontend) pattern
// Mobile Gateway (ocelot-mobile.json) - Simplified responses
// Web Gateway (ocelot-web.json) - Full data

// Load balancing configuration
/*
{
  "Routes": [
    {
      "DownstreamPathTemplate": "/api/products",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        { "Host": "service1", "Port": 5001 },
        { "Host": "service2", "Port": 5001 },
        { "Host": "service3", "Port": 5001 }
      ],
      "LoadBalancerOptions": {
        "Type": "RoundRobin"
      }
    }
  ]
}
*/

// Service discovery with Consul
builder.Services.AddOcelot()
    .AddConsul();

/*
{
  "Routes": [
    {
      "DownstreamPathTemplate": "/api/products",
      "ServiceName": "product-service",
      "LoadBalancerOptions": {
        "Type": "LeastConnection"
      }
    }
  ],
  "GlobalConfiguration": {
    "ServiceDiscoveryProvider": {
      "Host": "localhost",
      "Port": 8500,
      "Type": "Consul"
    }
  }
}
*/
```

---

**Batch 13 completed (Questions 71-75). Continue with next batch.**

---

## Batch 14: Code Quality & Advanced Features (Questions 76-80)

### Question 76: Explain nullable reference types in C#. How do they prevent null reference exceptions?

**Short Theory:**  
Nullable reference types (C# 8+) enable compiler warnings for potential null references. `string?` is nullable, `string` is non-nullable. Compiler analyzes null flow, warns on dereference without null check. Enable with `<Nullable>enable</Nullable>` in csproj. Use null-forgiving operator `!` when compiler can't infer safety. Reduces NullReferenceExceptions by making nullability explicit.

**Why do we use it?**  
NullReferenceException is most common runtime error. Nullable reference types catch issues at compile-time. Makes API contracts explicit: nullable vs non-nullable parameters. Improves code quality and documentation. Essential for new projects—prevents "billion-dollar mistake."

**Key Interview Points:**
- string? is nullable, string is non-nullable
- Compiler analyzes null flow, issues warnings
- Enable with <Nullable>enable</Nullable>
- Null-forgiving operator: variable!
- Use null checks or null-coalescing (??, ??=)
- Prevents NullReferenceException at compile-time

**Coding Example:**
```csharp
// Enable in .csproj
// <Nullable>enable</Nullable>

public class ProductService
{
    // Non-nullable parameter
    public Product GetProduct(string productId) // productId cannot be null
    {
        if (string.IsNullOrEmpty(productId))
            throw new ArgumentException("Product ID required");
        
        // Return non-nullable Product
        return new Product { Id = productId, Name = "Product 1" };
    }
    
    // Nullable return type
    public Product? FindProduct(string productId) // Can return null
    {
        if (productId == "invalid")
            return null; // OK - nullable return type
        
        return new Product { Id = productId, Name = "Product 1" };
    }
    
    // Using nullable parameters
    public void ProcessOrder(string customerId, string? couponCode) // couponCode is optional
    {
        Console.WriteLine($"Customer: {customerId}");
        
        if (couponCode != null) // Null check required
        {
            Console.WriteLine($"Coupon: {couponCode.ToUpper()}"); // Safe after null check
        }
        
        // Or use null-coalescing
        var discount = couponCode ?? "NONE";
    }
}

// Null flow analysis
public class NullFlowExample
{
    public void Example(string? nullableString)
    {
        // Warning: nullableString may be null
        // var length = nullableString.Length; // CS8602 warning
        
        // Safe: Null check
        if (nullableString != null)
        {
            var length = nullableString.Length; // OK - compiler knows it's not null
        }
        
        // Safe: Null-coalescing
        var length2 = (nullableString ?? "").Length;
        
        // Safe: Null-conditional
        var length3 = nullableString?.Length ?? 0;
        
        // Null-forgiving operator (use carefully)
        var length4 = nullableString!.Length; // Tells compiler: "I know it's not null"
    }
}

// Constructor with nullable references
public class User
{
    public string Name { get; set; } // Non-nullable
    public string? Email { get; set; } // Nullable
    
    public User(string name, string? email = null)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Email = email;
    }
    
    public void SendEmail()
    {
        if (Email != null)
        {
            Console.WriteLine($"Sending to {Email}");
        }
    }
}

// Attributes for better null analysis
public class DatabaseService
{
    // NotNull attribute - guarantees non-null return
    [return: NotNull]
    public string? GetConnectionString()
    {
        return Environment.GetEnvironmentVariable("ConnectionString") 
            ?? throw new InvalidOperationException("Connection string not found");
    }
    
    // MaybeNull attribute
    public void TryGetValue(string key, [MaybeNull] out string value)
    {
        value = key == "valid" ? "result" : null;
    }
}

// Nullable in generic types
public class Repository<T> where T : class
{
    public T? FindById(int id) // Nullable T
    {
        return default; // Can return null
    }
    
    public T GetById(int id) // Non-nullable T
    {
        return FindById(id) ?? throw new KeyNotFoundException();
    }
}

// Supporting types
public class Product { public string Id { get; set; } = ""; public string Name { get; set; } = ""; }
```

---

### Question 77: Explain pattern matching in C#. What are the different pattern types?

**Short Theory:**  
Pattern matching tests if value matches pattern. Types: **Type patterns** (`obj is string s`), **Property patterns** (`obj is { Age: > 18 }`), **Positional patterns** (deconstruction), **Relational patterns** (`> 10`), **Logical patterns** (`and`, `or`, `not`). Use in: is expressions, switch expressions, switch statements. C# 11 adds list patterns. Reduces type checking boilerplate.

**Why do we use it?**  
Pattern matching is more concise and readable than traditional type checking. Switch expressions eliminate fallthrough errors. Property patterns simplify complex conditions. Essential for discriminated unions and parsing. Modern C# code uses pattern matching extensively.

**Key Interview Points:**
- Type pattern: `obj is string s`
- Property pattern: `person is { Age: > 18 }`
- Relational pattern: `value is > 0 and < 100`
- Logical patterns: and, or, not
- Switch expressions (C# 8+)
- List patterns (C# 11+)

**Coding Example:**
```csharp
// Type patterns
public decimal CalculateDiscount(object customer)
{
    return customer switch
    {
        PremiumCustomer premium => premium.Tier == 1 ? 0.20m : 0.15m,
        RegularCustomer => 0.10m,
        null => 0m,
        _ => throw new ArgumentException("Unknown customer type")
    };
}

// Property patterns
public string GetShippingCost(Order order)
{
    return order switch
    {
        { Total: > 100, ShippingCountry: "US" } => "Free",
        { Total: > 50 } => "$5",
        { Items.Count: > 10 } => "$10",
        _ => "$15"
    };
}

// Relational and logical patterns
public string ClassifyAge(int age)
{
    return age switch
    {
        < 0 => "Invalid",
        >= 0 and < 13 => "Child",
        >= 13 and < 20 => "Teen",
        >= 20 and < 65 => "Adult",
        >= 65 => "Senior",
        _ => "Unknown"
    };
}

// Positional patterns (deconstruction)
public record Point(int X, int Y);

public string ClassifyPoint(Point point)
{
    return point switch
    {
        (0, 0) => "Origin",
        (var x, 0) => $"On X-axis at {x}",
        (0, var y) => $"On Y-axis at {y}",
        (var x, var y) when x == y => "On diagonal",
        (var x, var y) => $"Point at ({x}, {y})"
    };
}

// Nested patterns
public decimal CalculatePrice(Product product)
{
    return product switch
    {
        { Category: "Electronics", Brand: "Premium", Price: > 1000 } => product.Price * 0.90m,
        { Category: "Electronics", InStock: true } => product.Price * 0.95m,
        { Category: "Clothing", Season: "Winter" } => product.Price * 0.80m,
        _ => product.Price
    };
}

// List patterns (C# 11)
public string AnalyzeArray(int[] numbers)
{
    return numbers switch
    {
        [] => "Empty",
        [var single] => $"Single element: {single}",
        [var first, var second] => $"Two elements: {first}, {second}",
        [var first, .., var last] => $"Multiple elements, first: {first}, last: {last}",
        [1, 2, ..] => "Starts with 1, 2",
        [.., 99, 100] => "Ends with 99, 100"
    };
}

// var pattern
public bool IsValid(object value)
{
    return value switch
    {
        string { Length: > 0 } s when s.StartsWith("A") => true,
        int n when n > 0 => true,
        _ => false
    };
}

// Not pattern
public bool IsNotNull(object? value)
{
    return value is not null;
}

// Combining patterns
public string ProcessPayment(Payment payment)
{
    return payment switch
    {
        { Status: "Completed" or "Pending", Amount: > 0 } => "Valid payment",
        { Status: "Failed" or "Cancelled" } => "Invalid payment",
        not null => "Unknown status",
        _ => "Null payment"
    };
}

// Property pattern with nested objects
public bool IsEligibleForDiscount(Customer customer)
{
    return customer is 
    { 
        Membership: { IsActive: true, Level: > 2 },
        Orders: { Count: > 5 },
        TotalSpent: > 1000
    };
}

// Supporting types
public class PremiumCustomer { public int Tier { get; set; } }
public class RegularCustomer { }
public class Order { public decimal Total { get; set; } public string ShippingCountry { get; set; } = ""; public List<OrderItem> Items { get; set; } = new(); }
public class OrderItem { }
public class Product { public string Category { get; set; } = ""; public string Brand { get; set; } = ""; public decimal Price { get; set; } public bool InStock { get; set; } public string Season { get; set; } = ""; }
public class Payment { public string Status { get; set; } = ""; public decimal Amount { get; set; } }
public class Customer { public Membership Membership { get; set; } = new(); public List<Order> Orders { get; set; } = new(); public decimal TotalSpent { get; set; } }
public class Membership { public bool IsActive { get; set; } public int Level { get; set; } }
```

---

### Question 78: What is Domain-Driven Design (DDD)? Explain key concepts: Entities, Value Objects, Aggregates.

**Short Theory:**  
DDD focuses on complex domain logic and collaboration with domain experts. **Entity**: Object with identity (Order with ID). **Value Object**: Immutable, equality by value (Money, Address). **Aggregate**: Cluster of entities with root entity enforcing invariants. **Repository**: Persist/retrieve aggregates. **Domain Events**: Track state changes. Bounded Context separates models. Use for complex business domains, not simple CRUD.

**Why do we use it?**  
Complex domains require rich models, not anemic entities. DDD ensures business logic lives in domain, not services. Aggregates enforce consistency boundaries. Value objects prevent primitive obsession. Domain events decouple components. Essential for complex business apps (finance, e-commerce). Overkill for simple CRUD.

**Key Interview Points:**
- Entity: Has identity (ID), mutable
- Value Object: No identity, immutable, value equality
- Aggregate: Consistency boundary with root entity
- Repository: Persist/retrieve aggregates only
- Domain Events: Track state changes
- Use for complex domains, not simple CRUD

**Coding Example:**
```csharp
// Value Object - Money
public record Money(decimal Amount, string Currency)
{
    public Money Add(Money other)
    {
        if (Currency != other.Currency)
            throw new InvalidOperationException("Cannot add different currencies");
        
        return new Money(Amount + other.Amount, Currency);
    }
    
    public static Money Zero(string currency) => new(0, currency);
}

// Value Object - Address
public record Address(string Street, string City, string ZipCode, string Country)
{
    public bool IsInSameCity(Address other) => City == other.City;
}

// Entity - OrderItem (has identity within Order)
public class OrderItem
{
    public int Id { get; private set; }
    public string ProductId { get; private set; }
    public int Quantity { get; private set; }
    public Money Price { get; private set; }
    
    public OrderItem(int id, string productId, int quantity, Money price)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be positive");
        
        Id = id;
        ProductId = productId;
        Quantity = quantity;
        Price = price;
    }
    
    public Money GetTotal() => new Money(Price.Amount * Quantity, Price.Currency);
}

// Aggregate Root - Order
public class Order
{
    public int Id { get; private set; }
    public string CustomerId { get; private set; }
    public OrderStatus Status { get; private set; }
    private readonly List<OrderItem> _items = new();
    public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();
    private readonly List<DomainEvent> _domainEvents = new();
    
    public Order(int id, string customerId)
    {
        Id = id;
        CustomerId = customerId;
        Status = OrderStatus.Draft;
        
        _domainEvents.Add(new OrderCreatedEvent(id, customerId));
    }
    
    // Business logic in aggregate
    public void AddItem(string productId, int quantity, Money price)
    {
        if (Status != OrderStatus.Draft)
            throw new InvalidOperationException("Cannot modify submitted order");
        
        var item = new OrderItem(_items.Count + 1, productId, quantity, price);
        _items.Add(item);
        
        _domainEvents.Add(new OrderItemAddedEvent(Id, productId, quantity));
    }
    
    public void Submit()
    {
        if (Status != OrderStatus.Draft)
            throw new InvalidOperationException("Order already submitted");
        
        if (!_items.Any())
            throw new InvalidOperationException("Cannot submit empty order");
        
        Status = OrderStatus.Submitted;
        _domainEvents.Add(new OrderSubmittedEvent(Id, GetTotal()));
    }
    
    public Money GetTotal()
    {
        if (!_items.Any()) return Money.Zero("USD");
        
        var total = Money.Zero(_items[0].Price.Currency);
        foreach (var item in _items)
        {
            total = total.Add(item.GetTotal());
        }
        return total;
    }
    
    public IReadOnlyList<DomainEvent> GetDomainEvents() => _domainEvents.AsReadOnly();
    public void ClearDomainEvents() => _domainEvents.Clear();
}

// Domain Events
public abstract record DomainEvent(DateTime OccurredAt);
public record OrderCreatedEvent(int OrderId, string CustomerId) : DomainEvent(DateTime.UtcNow);
public record OrderItemAddedEvent(int OrderId, string ProductId, int Quantity) : DomainEvent(DateTime.UtcNow);
public record OrderSubmittedEvent(int OrderId, Money Total) : DomainEvent(DateTime.UtcNow);

// Repository interface (persist aggregate root only)
public interface IOrderRepository
{
    Task<Order?> GetByIdAsync(int id);
    Task SaveAsync(Order order);
}

// Application Service (coordinates use case)
public class OrderService
{
    private readonly IOrderRepository _repository;
    private readonly IEventBus _eventBus;
    
    public OrderService(IOrderRepository repository, IEventBus eventBus)
    {
        _repository = repository;
        _eventBus = eventBus;
    }
    
    public async Task CreateOrderAsync(string customerId, List<OrderItemDto> items)
    {
        var order = new Order(GenerateOrderId(), customerId);
        
        foreach (var item in items)
        {
            order.AddItem(item.ProductId, item.Quantity, new Money(item.Price, "USD"));
        }
        
        order.Submit();
        
        await _repository.SaveAsync(order);
        
        // Publish domain events
        foreach (var domainEvent in order.GetDomainEvents())
        {
            await _eventBus.PublishAsync(domainEvent);
        }
        
        order.ClearDomainEvents();
    }
    
    private int GenerateOrderId() => new Random().Next(1, 10000);
}

// Supporting types
public enum OrderStatus { Draft, Submitted, Confirmed, Shipped, Delivered, Cancelled }
public record OrderItemDto(string ProductId, int Quantity, decimal Price);
public interface IEventBus { Task PublishAsync(DomainEvent domainEvent); }
```

---

### Question 79: Explain the Adapter pattern. When would you use it?

**Short Theory:**  
Adapter (Wrapper) converts interface of class into another interface clients expect. Makes incompatible interfaces work together. Two forms: **Object Adapter** (composition) and **Class Adapter** (inheritance). Use for: Legacy system integration, third-party library wrapping, interface standardization. Common in API integrations, data source abstractions.

**Why do we use it?**  
Integrate systems with incompatible interfaces without modifying source code. Wrap third-party libraries for easier testing and switching. Standardize interfaces across different implementations. Essential when working with legacy code or external APIs. Follows Open-Closed Principle.

**Key Interview Points:**
- Convert one interface to another
- Makes incompatible interfaces compatible
- Object adapter uses composition
- Use for: Legacy integration, third-party wrappers
- Enables interface standardization
- Essential for working with external systems

**Coding Example:**
```csharp
// Target interface (what client expects)
public interface IPaymentGateway
{
    Task<PaymentResult> ProcessPaymentAsync(decimal amount, string currency, string cardToken);
    Task<RefundResult> RefundAsync(string transactionId, decimal amount);
}

// Adaptee 1 - Stripe API (incompatible interface)
public class StripeApi
{
    public async Task<StripeChargeResponse> CreateCharge(
        int amountInCents, string currencyCode, string source)
    {
        await Task.Delay(100); // Simulate API call
        return new StripeChargeResponse 
        { 
            Id = "ch_" + Guid.NewGuid(), 
            Status = "succeeded" 
        };
    }
    
    public async Task<StripeRefundResponse> CreateRefund(string chargeId, int amountInCents)
    {
        await Task.Delay(100);
        return new StripeRefundResponse { Id = "re_" + Guid.NewGuid(), Status = "succeeded" };
    }
}

// Adapter for Stripe
public class StripePaymentAdapter : IPaymentGateway
{
    private readonly StripeApi _stripeApi;
    
    public StripePaymentAdapter(StripeApi stripeApi)
    {
        _stripeApi = stripeApi;
    }
    
    public async Task<PaymentResult> ProcessPaymentAsync(decimal amount, string currency, string cardToken)
    {
        // Adapt interface: dollars to cents, call Stripe API
        var amountInCents = (int)(amount * 100);
        var response = await _stripeApi.CreateCharge(amountInCents, currency, cardToken);
        
        return new PaymentResult
        {
            Success = response.Status == "succeeded",
            TransactionId = response.Id
        };
    }
    
    public async Task<RefundResult> RefundAsync(string transactionId, decimal amount)
    {
        var amountInCents = (int)(amount * 100);
        var response = await _stripeApi.CreateRefund(transactionId, amountInCents);
        
        return new RefundResult
        {
            Success = response.Status == "succeeded",
            RefundId = response.Id
        };
    }
}

// Adaptee 2 - PayPal API (different incompatible interface)
public class PayPalApi
{
    public async Task<PayPalPaymentResponse> ExecutePayment(
        string paymentAmount, string currencyType, string paymentMethod)
    {
        await Task.Delay(150);
        return new PayPalPaymentResponse 
        { 
            PaymentId = "PAY-" + Guid.NewGuid(), 
            State = "approved" 
        };
    }
    
    public async Task<PayPalRefundResponse> ProcessRefund(string paymentId, string refundAmount)
    {
        await Task.Delay(150);
        return new PayPalRefundResponse { RefundId = "REF-" + Guid.NewGuid(), Status = "completed" };
    }
}

// Adapter for PayPal
public class PayPalPaymentAdapter : IPaymentGateway
{
    private readonly PayPalApi _payPalApi;
    
    public PayPalPaymentAdapter(PayPalApi payPalApi)
    {
        _payPalApi = payPalApi;
    }
    
    public async Task<PaymentResult> ProcessPaymentAsync(decimal amount, string currency, string cardToken)
    {
        // Adapt interface: format amount as string, call PayPal API
        var response = await _payPalApi.ExecutePayment(
            amount.ToString("F2"), currency, cardToken);
        
        return new PaymentResult
        {
            Success = response.State == "approved",
            TransactionId = response.PaymentId
        };
    }
    
    public async Task<RefundResult> RefundAsync(string transactionId, decimal amount)
    {
        var response = await _payPalApi.ProcessRefund(transactionId, amount.ToString("F2"));
        
        return new RefundResult
        {
            Success = response.Status == "completed",
            RefundId = response.RefundId
        };
    }
}

// Client code (works with standardized interface)
public class PaymentService
{
    private readonly IPaymentGateway _paymentGateway;
    
    public PaymentService(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway; // Can be Stripe or PayPal adapter
    }
    
    public async Task<bool> ProcessOrderPaymentAsync(decimal amount)
    {
        var result = await _paymentGateway.ProcessPaymentAsync(amount, "USD", "card_token");
        return result.Success;
    }
}

// DI registration
builder.Services.AddScoped<StripeApi>();
builder.Services.AddScoped<PayPalApi>();

// Switch implementation easily
builder.Services.AddScoped<IPaymentGateway>(provider =>
{
    var config = provider.GetRequiredService<IConfiguration>();
    var gateway = config["PaymentGateway"];
    
    return gateway switch
    {
        "Stripe" => new StripePaymentAdapter(provider.GetRequiredService<StripeApi>()),
        "PayPal" => new PayPalPaymentAdapter(provider.GetRequiredService<PayPalApi>()),
        _ => throw new NotSupportedException()
    };
});

// Supporting types
public class PaymentResult { public bool Success { get; set; } public string TransactionId { get; set; } = ""; }
public class RefundResult { public bool Success { get; set; } public string RefundId { get; set; } = ""; }
public class StripeChargeResponse { public string Id { get; set; } = ""; public string Status { get; set; } = ""; }
public class StripeRefundResponse { public string Id { get; set; } = ""; public string Status { get; set; } = ""; }
public class PayPalPaymentResponse { public string PaymentId { get; set; } = ""; public string State { get; set; } = ""; }
public class PayPalRefundResponse { public string RefundId { get; set; } = ""; public string Status { get; set; } = ""; }
```

---

### Question 80: Explain init-only properties and records with inheritance in C#.

**Short Theory:**  
Init-only properties (C# 9) allow setting during initialization only, immutable after. `public string Name { get; init; }`. Use with object initializers and with-expressions. Records support inheritance: `record Derived : Base`. Derived records inherit with-expressions, equality. Use `sealed` to prevent further inheritance. Positional records use primary constructors. Combine for immutable domain models.

**Why do we use it?**  
Immutability prevents bugs in concurrent scenarios and makes code easier to reason about. Init-only properties provide flexibility during construction, immutability after. Record inheritance enables hierarchies with value semantics. Perfect for DTOs, domain models, configuration objects.

**Key Interview Points:**
- init-only: Set during initialization, readonly after
- Works with object initializers and with-expressions
- Records support inheritance with value semantics
- Positional records use primary constructors
- Use sealed to prevent inheritance
- Immutability benefits: Thread-safe, predictable

**Coding Example:**
```csharp
// Init-only properties
public class Person
{
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = "";
    public int Age { get; init; }
    
    // Can be set during initialization
    // var person = new Person { FirstName = "John", Age = 30 };
    // person.Age = 31; // ❌ Compile error - cannot modify after init
}

// Record inheritance
public record Vehicle(string Brand, string Model, int Year)
{
    public virtual string GetDescription() => $"{Year} {Brand} {Model}";
}

public record Car(string Brand, string Model, int Year, int Doors) 
    : Vehicle(Brand, Model, Year)
{
    public override string GetDescription() => $"{base.GetDescription()} ({Doors} doors)";
}

public record Motorcycle(string Brand, string Model, int Year, string Type) 
    : Vehicle(Brand, Model, Year)
{
    public override string GetDescription() => $"{base.GetDescription()} - {Type}";
}

// Usage
var car = new Car("Toyota", "Camry", 2024, 4);
var bike = new Motorcycle("Harley", "Sportster", 2024, "Cruiser");

Console.WriteLine(car.GetDescription()); // 2024 Toyota Camry (4 doors)
Console.WriteLine(bike.GetDescription()); // 2024 Harley Sportster - Cruiser

// With-expressions with inheritance
var newCar = car with { Year = 2025 }; // Creates new Car with updated year

// Record with additional properties
public record Product(string Id, string Name, decimal Price)
{
    public string Category { get; init; } = "General";
    public bool InStock { get; init; } = true;
}

var product = new Product("P123", "Laptop", 999.99m) 
{ 
    Category = "Electronics",
    InStock = true
};

// Sealed records (prevent inheritance)
public sealed record ImmutableConfig(string ConnectionString, int Timeout)
{
    public bool EnableRetry { get; init; } = true;
}

// Record class vs record struct
public record class PersonClass(string Name, int Age); // Reference type (default)
public record struct PersonStruct(string Name, int Age); // Value type

// Complex record hierarchy
public abstract record Shape(string Color)
{
    public abstract double CalculateArea();
}

public record Circle(string Color, double Radius) : Shape(Color)
{
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

public record Rectangle(string Color, double Width, double Height) : Shape(Color)
{
    public override double CalculateArea() => Width * Height;
}

// Using init with required modifier (C# 11)
public class Configuration
{
    public required string DatabaseUrl { get; init; }
    public required string ApiKey { get; init; }
    public int Timeout { get; init; } = 30;
}

// Usage: All required properties must be initialized
var config = new Configuration 
{ 
    DatabaseUrl = "localhost",
    ApiKey = "secret-key",
    Timeout = 60
};

// Domain model example
public record OrderDto(int Id, string CustomerId, DateTime CreatedAt)
{
    public List<OrderItemDto> Items { get; init; } = new();
    public decimal Total { get; init; }
}

public record OrderItemDto(string ProductId, int Quantity, decimal Price);

// Deconstruction with inheritance
var circle = new Circle("Red", 5.0);
var (color, radius) = circle; // Deconstruct inherited and own properties

// Value equality with inheritance
var circle1 = new Circle("Blue", 10.0);
var circle2 = new Circle("Blue", 10.0);
Console.WriteLine(circle1 == circle2); // True - value equality

// Supporting types for compilation
public interface IConfiguration { }
```

---

**Batch 14 completed (Questions 76-80). Continue with next batch.**

---

## Batch 15: Performance & Advanced Scenarios (Questions 81-85)

### Question 81: Explain ValueTask vs Task. When should you use ValueTask?

**Short Theory:**  
`ValueTask<T>` is a struct, `Task<T>` is a class (heap allocation). Use ValueTask when result is often synchronously available (cached, fast path). Avoids allocation if operation completes synchronously. Don't await ValueTask twice—convert to Task if needed. Best for high-performance hot paths (stream reads, cache lookups). Task is fine for most scenarios—don't optimize prematurely.

**Why do we use it?**  
Task allocates on heap even for synchronous completions (cache hit, validation). ValueTask eliminates allocation in sync path. Significant savings in high-throughput scenarios (1M+ operations). Trade-off: More complex semantics, can't await twice. Benchmark before using—Task is simpler and sufficient for most cases.

**Key Interview Points:**
- ValueTask is struct, Task is class
- Use when result often available synchronously
- Avoids heap allocation on fast path
- Cannot await ValueTask twice (convert to Task)
- Best for: Cache lookups, pooled operations
- Task is default—use ValueTask for proven hotspots

**Coding Example:**
```csharp
// Cache service with ValueTask
public class CacheService
{
    private readonly IMemoryCache _cache;
    private readonly IDatabase _database;
    
    public CacheService(IMemoryCache cache, IDatabase database)
    {
        _cache = cache;
        _database = database;
    }
    
    // ValueTask - often synchronous (cache hit)
    public ValueTask<User> GetUserAsync(int userId)
    {
        // Fast path - synchronous (cache hit)
        if (_cache.TryGetValue(userId, out User cachedUser))
        {
            return new ValueTask<User>(cachedUser); // No allocation
        }
        
        // Slow path - asynchronous (cache miss)
        return new ValueTask<User>(LoadUserAsync(userId));
    }
    
    private async Task<User> LoadUserAsync(int userId)
    {
        var user = await _database.GetUserAsync(userId);
        _cache.Set(userId, user, TimeSpan.FromMinutes(10));
        return user;
    }
    
    // BAD: Awaiting ValueTask twice
    public async Task BadExample(int userId)
    {
        var valueTask = GetUserAsync(userId);
        var user1 = await valueTask; // First await - OK
        // var user2 = await valueTask; // ❌ Second await - undefined behavior
    }
    
    // GOOD: Convert to Task if need to await multiple times
    public async Task GoodExample(int userId)
    {
        var task = GetUserAsync(userId).AsTask(); // Convert once
        var user1 = await task; // OK
        var user2 = await task; // OK
    }
}

// Regular Task - always asynchronous
public class OrderService
{
    private readonly IDatabase _database;
    
    public OrderService(IDatabase database) => _database = database;
    
    // Task - always async, heap allocation
    public async Task<Order> GetOrderAsync(int orderId)
    {
        return await _database.GetOrderAsync(orderId);
    }
}

// Comparison benchmark
public class ValueTaskBenchmark
{
    private readonly Random _random = new();
    private readonly Dictionary<int, string> _cache = new();
    
    [Benchmark(Baseline = true)]
    public async Task<string> UsingTask()
    {
        int count = 0;
        for (int i = 0; i < 1000; i++)
        {
            var result = await GetWithTask(i % 100);
            count += result.Length;
        }
        return count.ToString();
    }
    
    [Benchmark]
    public async Task<string> UsingValueTask()
    {
        int count = 0;
        for (int i = 0; i < 1000; i++)
        {
            var result = await GetWithValueTask(i % 100);
            count += result.Length;
        }
        return count.ToString();
    }
    
    private Task<string> GetWithTask(int id)
    {
        if (_cache.TryGetValue(id, out var value))
            return Task.FromResult(value); // Allocates Task
        
        value = $"Value_{id}";
        _cache[id] = value;
        return Task.FromResult(value);
    }
    
    private ValueTask<string> GetWithValueTask(int id)
    {
        if (_cache.TryGetValue(id, out var value))
            return new ValueTask<string>(value); // No allocation
        
        value = $"Value_{id}";
        _cache[id] = value;
        return new ValueTask<string>(value);
    }
}

// IAsyncDisposable with ValueTask
public class ResourceHandler : IAsyncDisposable
{
    private bool _disposed;
    
    public async ValueTask DisposeAsync()
    {
        if (_disposed) return;
        
        await CleanupAsync();
        _disposed = true;
        GC.SuppressFinalize(this);
    }
    
    private Task CleanupAsync() => Task.CompletedTask;
}

// Supporting types
public interface IDatabase 
{ 
    Task<User> GetUserAsync(int userId); 
    Task<Order> GetOrderAsync(int orderId); 
}
public class User { public int Id { get; set; } public string Name { get; set; } = ""; }
public class Order { public int Id { get; set; } }
```

---

### Question 82: Explain channel-based communication with System.Threading.Channels.

**Short Theory:**  
Channels provide thread-safe producer-consumer queues. `Channel<T>` separates reader and writer. Bounded channels (limit capacity, backpressure) vs Unbounded. Supports async iteration (`await foreach`). Better than BlockingCollection—async, cancellable. Use for: Producer-consumer patterns, background processing, pipeline stages. Alternative to manual locking and queues.

**Why do we use it?**  
Channels are high-performance, async-friendly producer-consumer. No locks needed—built-in synchronization. Bounded channels provide backpressure (prevent memory exhaustion). AsyncEnumerable integration with `ReadAllAsync()`. Essential for async pipelines and background workers. Cleaner than manual queue + lock code.

**Key Interview Points:**
- Thread-safe producer-consumer queue
- Bounded (capacity limit) vs Unbounded
- Async read/write operations
- Support async iteration (await foreach)
- Use for: Background processing, pipelines
- Better than BlockingCollection for async

**Coding Example:**
```csharp
// Install: System.Threading.Channels (built into .NET Core 3.0+)

// Unbounded channel example
public class EmailQueueService
{
    private readonly Channel<EmailMessage> _channel;
    
    public EmailQueueService()
    {
        _channel = Channel.CreateUnbounded<EmailMessage>(new UnboundedChannelOptions
        {
            SingleReader = true, // Optimization if single consumer
            SingleWriter = false
        });
    }
    
    // Producer - write to channel
    public async Task QueueEmailAsync(EmailMessage email)
    {
        await _channel.Writer.WriteAsync(email);
    }
    
    // Consumer - read from channel
    public async Task ProcessEmailsAsync(CancellationToken cancellationToken)
    {
        await foreach (var email in _channel.Reader.ReadAllAsync(cancellationToken))
        {
            await SendEmailAsync(email);
        }
    }
    
    private Task SendEmailAsync(EmailMessage email)
    {
        Console.WriteLine($"Sending email to {email.To}");
        return Task.CompletedTask;
    }
}

// Bounded channel with backpressure
public class OrderProcessingService : BackgroundService
{
    private readonly Channel<Order> _channel;
    
    public OrderProcessingService()
    {
        // Bounded channel - max 100 items
        _channel = Channel.CreateBounded<Order>(new BoundedChannelOptions(100)
        {
            FullMode = BoundedChannelFullMode.Wait // Block producer if full
        });
    }
    
    public async Task<bool> TryEnqueueOrderAsync(Order order, CancellationToken ct)
    {
        try
        {
            await _channel.Writer.WriteAsync(order, ct);
            return true;
        }
        catch (ChannelClosedException)
        {
            return false;
        }
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var order in _channel.Reader.ReadAllAsync(stoppingToken))
        {
            await ProcessOrderAsync(order);
        }
    }
    
    private async Task ProcessOrderAsync(Order order)
    {
        Console.WriteLine($"Processing order {order.Id}");
        await Task.Delay(100); // Simulate work
    }
}

// Pipeline pattern with multiple channels
public class DataPipeline
{
    private readonly Channel<string> _rawDataChannel;
    private readonly Channel<ProcessedData> _processedDataChannel;
    
    public DataPipeline()
    {
        _rawDataChannel = Channel.CreateBounded<string>(50);
        _processedDataChannel = Channel.CreateBounded<ProcessedData>(50);
    }
    
    // Stage 1: Receive raw data
    public async Task AddRawDataAsync(string data)
    {
        await _rawDataChannel.Writer.WriteAsync(data);
    }
    
    // Stage 2: Process data (consumer of stage 1, producer for stage 3)
    public async Task ProcessDataStageAsync(CancellationToken ct)
    {
        await foreach (var rawData in _rawDataChannel.Reader.ReadAllAsync(ct))
        {
            var processed = new ProcessedData { Value = rawData.ToUpper() };
            await _processedDataChannel.Writer.WriteAsync(processed, ct);
        }
    }
    
    // Stage 3: Save processed data
    public async Task SaveDataStageAsync(CancellationToken ct)
    {
        await foreach (var data in _processedDataChannel.Reader.ReadAllAsync(ct))
        {
            await SaveToDatabase(data);
        }
    }
    
    private Task SaveToDatabase(ProcessedData data) => Task.CompletedTask;
}

// Multiple producers, single consumer
public class LogAggregator
{
    private readonly Channel<LogEntry> _logChannel;
    
    public LogAggregator()
    {
        _logChannel = Channel.CreateUnbounded<LogEntry>();
    }
    
    // Multiple threads can call this (multiple producers)
    public async Task LogAsync(string source, string message)
    {
        await _logChannel.Writer.WriteAsync(new LogEntry
        {
            Source = source,
            Message = message,
            Timestamp = DateTime.UtcNow
        });
    }
    
    // Single consumer
    public async Task AggregateLogsAsync(CancellationToken ct)
    {
        await foreach (var log in _logChannel.Reader.ReadAllAsync(ct))
        {
            Console.WriteLine($"[{log.Timestamp:HH:mm:ss}] {log.Source}: {log.Message}");
        }
    }
}

// Try pattern (non-blocking)
public class NonBlockingQueue
{
    private readonly Channel<int> _channel;
    
    public NonBlockingQueue()
    {
        _channel = Channel.CreateBounded<int>(10);
    }
    
    public bool TryEnqueue(int item)
    {
        return _channel.Writer.TryWrite(item); // Returns false if full
    }
    
    public bool TryDequeue(out int item)
    {
        return _channel.Reader.TryRead(out item); // Returns false if empty
    }
}

// Supporting types
public class EmailMessage { public string To { get; set; } = ""; public string Subject { get; set; } = ""; }
public class Order { public int Id { get; set; } }
public class ProcessedData { public string Value { get; set; } = ""; }
public class LogEntry { public string Source { get; set; } = ""; public string Message { get; set; } = ""; public DateTime Timestamp { get; set; } }
```

---

### Question 83: What is the Outbox pattern? How does it ensure reliable messaging?

**Short Theory:**  
Outbox pattern ensures reliable message publishing in distributed systems. Store message in database alongside domain changes in same transaction. Separate process reads outbox table, publishes to message bus, marks as sent. Guarantees at-least-once delivery. Prevents lost messages due to message bus failures. Use with domain events, saga coordination. Trade-off: Additional table, polling overhead.

**Why do we use it?**  
Publishing to message bus outside transaction can fail—message lost or duplicate. Outbox ensures atomicity: save entity + outbox message in single transaction. If message bus is down, messages are retried. Essential for reliable distributed systems. Alternative to distributed transactions. Combines with Change Data Capture (CDC) or polling.

**Key Interview Points:**
- Store messages in DB alongside domain changes
- Single transaction ensures atomicity
- Separate process publishes messages
- Guarantees at-least-once delivery
- Prevents lost messages on failures
- Use with domain events, saga coordination

**Coding Example:**
```csharp
// Outbox message entity
public class OutboxMessage
{
    public Guid Id { get; set; }
    public string Type { get; set; } = "";
    public string Payload { get; set; } = "";
    public DateTime OccurredAt { get; set; }
    public DateTime? ProcessedAt { get; set; }
    public int RetryCount { get; set; }
}

// Domain event
public record OrderCreatedEvent(int OrderId, string CustomerId, decimal Total);

// Repository with outbox
public class OrderRepository
{
    private readonly AppDbContext _context;
    
    public OrderRepository(AppDbContext context) => _context = context;
    
    public async Task SaveOrderAsync(Order order, List<object> domainEvents)
    {
        // Start transaction
        using var transaction = await _context.Database.BeginTransactionAsync();
        
        try
        {
            // Save order
            _context.Orders.Add(order);
            
            // Save domain events to outbox (same transaction)
            foreach (var domainEvent in domainEvents)
            {
                var outboxMessage = new OutboxMessage
                {
                    Id = Guid.NewGuid(),
                    Type = domainEvent.GetType().Name,
                    Payload = JsonSerializer.Serialize(domainEvent),
                    OccurredAt = DateTime.UtcNow
                };
                
                _context.OutboxMessages.Add(outboxMessage);
            }
            
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            
            // At this point, both order and messages are saved atomically
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}

// Outbox processor (background service)
public class OutboxProcessorService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<OutboxProcessorService> _logger;
    
    public OutboxProcessorService(IServiceProvider serviceProvider, ILogger<OutboxProcessorService> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await ProcessOutboxMessagesAsync(stoppingToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing outbox messages");
            }
            
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }
    }
    
    private async Task ProcessOutboxMessagesAsync(CancellationToken ct)
    {
        using var scope = _serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        var messageBus = scope.ServiceProvider.GetRequiredService<IMessageBus>();
        
        // Get unprocessed messages
        var messages = await context.OutboxMessages
            .Where(m => m.ProcessedAt == null && m.RetryCount < 5)
            .OrderBy(m => m.OccurredAt)
            .Take(50)
            .ToListAsync(ct);
        
        foreach (var message in messages)
        {
            try
            {
                // Publish to message bus
                await PublishMessageAsync(messageBus, message);
                
                // Mark as processed
                message.ProcessedAt = DateTime.UtcNow;
                await context.SaveChangesAsync(ct);
                
                _logger.LogInformation($"Published outbox message {message.Id}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to publish message {message.Id}");
                message.RetryCount++;
                await context.SaveChangesAsync(ct);
            }
        }
    }
    
    private async Task PublishMessageAsync(IMessageBus messageBus, OutboxMessage message)
    {
        // Deserialize and publish based on type
        object domainEvent = message.Type switch
        {
            nameof(OrderCreatedEvent) => JsonSerializer.Deserialize<OrderCreatedEvent>(message.Payload)!,
            _ => throw new NotSupportedException($"Unknown message type: {message.Type}")
        };
        
        await messageBus.PublishAsync(domainEvent);
    }
}

// Application service using outbox
public class OrderService
{
    private readonly OrderRepository _repository;
    
    public OrderService(OrderRepository repository) => _repository = repository;
    
    public async Task CreateOrderAsync(Order order)
    {
        // Domain events to publish
        var events = new List<object>
        {
            new OrderCreatedEvent(order.Id, order.CustomerId, order.Total)
        };
        
        // Save order + events atomically
        await _repository.SaveOrderAsync(order, events);
        
        // Messages will be published asynchronously by OutboxProcessorService
    }
}

// EF Core configuration
public class AppDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OutboxMessage> OutboxMessages { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OutboxMessage>()
            .HasIndex(m => new { m.ProcessedAt, m.RetryCount });
    }
}

// Change Data Capture (CDC) alternative
// Instead of polling, use SQL Server Change Tracking or Debezium
// Captures changes in real-time without polling overhead

// Supporting types
public class Order { public int Id { get; set; } public string CustomerId { get; set; } = ""; public decimal Total { get; set; } }
public interface IMessageBus { Task PublishAsync(object message); }
```

---

### Question 84: Explain the Proxy pattern. How is it used in EF Core and AOP?

**Short Theory:**  
Proxy pattern provides surrogate/placeholder controlling access to another object. Types: **Virtual Proxy** (lazy loading), **Protection Proxy** (access control), **Remote Proxy** (network object), **Smart Proxy** (additional behavior). EF Core uses proxies for lazy loading and change tracking. AOP (Aspect-Oriented Programming) uses dynamic proxies for cross-cutting concerns (logging, caching, transactions).

**Why do we use it?**  
Proxies add behavior without modifying original class. EF Core lazy loading loads related entities on access. AOP proxies intercept method calls for logging, validation, caching. Enables separation of concerns—business logic separate from infrastructure. Castle DynamicProxy and DispatchProxy enable runtime proxy generation.

**Key Interview Points:**
- Surrogate controlling access to real object
- Virtual proxy: Lazy loading (EF Core)
- Protection proxy: Access control
- Smart proxy: Additional behavior (logging, caching)
- Used in: EF Core, AOP, RPC
- Castle DynamicProxy for runtime generation

**Coding Example:**
```csharp
// Virtual Proxy - Lazy Loading
public interface IDocument
{
    string GetContent();
}

// Real subject
public class Document : IDocument
{
    private readonly string _filename;
    
    public Document(string filename)
    {
        _filename = filename;
        LoadFromDisk(); // Expensive operation
    }
    
    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading {_filename} from disk...");
        Thread.Sleep(1000); // Simulate expensive load
    }
    
    public string GetContent() => $"Content of {_filename}";
}

// Proxy - defers loading until needed
public class DocumentProxy : IDocument
{
    private readonly string _filename;
    private Document? _realDocument;
    
    public DocumentProxy(string filename)
    {
        _filename = filename;
    }
    
    public string GetContent()
    {
        if (_realDocument == null)
        {
            Console.WriteLine("Lazy loading document...");
            _realDocument = new Document(_filename);
        }
        
        return _realDocument.GetContent();
    }
}

// Usage
var proxy = new DocumentProxy("large-file.txt");
// Document not loaded yet
Console.WriteLine("Proxy created");
var content = proxy.GetContent(); // Loads now

// Protection Proxy - Access Control
public interface IBankAccount
{
    decimal GetBalance();
    void Withdraw(decimal amount);
}

public class BankAccount : IBankAccount
{
    private decimal _balance = 1000m;
    
    public decimal GetBalance() => _balance;
    
    public void Withdraw(decimal amount)
    {
        if (amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}");
        }
    }
}

public class SecureBankAccountProxy : IBankAccount
{
    private readonly BankAccount _realAccount;
    private readonly string _userRole;
    
    public SecureBankAccountProxy(BankAccount realAccount, string userRole)
    {
        _realAccount = realAccount;
        _userRole = userRole;
    }
    
    public decimal GetBalance()
    {
        if (_userRole == "Admin" || _userRole == "Owner")
            return _realAccount.GetBalance();
        
        throw new UnauthorizedAccessException("Access denied");
    }
    
    public void Withdraw(decimal amount)
    {
        if (_userRole == "Owner")
        {
            _realAccount.Withdraw(amount);
        }
        else
        {
            throw new UnauthorizedAccessException("Only owner can withdraw");
        }
    }
}

// Dynamic Proxy with DispatchProxy (built-in .NET)
public class LoggingProxy<T> : DispatchProxy where T : class
{
    private T _target = default!;
    private ILogger _logger = default!;
    
    public static T Create(T target, ILogger logger)
    {
        var proxy = Create<T, LoggingProxy<T>>() as LoggingProxy<T>;
        proxy!._target = target;
        proxy._logger = logger;
        return proxy as T ?? throw new InvalidOperationException();
    }
    
    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
    {
        _logger.LogInformation($"Calling {targetMethod?.Name}");
        
        var sw = Stopwatch.StartNew();
        try
        {
            var result = targetMethod?.Invoke(_target, args);
            sw.Stop();
            
            _logger.LogInformation($"{targetMethod?.Name} completed in {sw.ElapsedMilliseconds}ms");
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"{targetMethod?.Name} failed");
            throw;
        }
    }
}

// Usage with DispatchProxy
public interface IOrderService
{
    Task<Order> GetOrderAsync(int id);
    Task CreateOrderAsync(Order order);
}

public class OrderService : IOrderService
{
    public async Task<Order> GetOrderAsync(int id)
    {
        await Task.Delay(100);
        return new Order { Id = id };
    }
    
    public async Task CreateOrderAsync(Order order)
    {
        await Task.Delay(50);
    }
}

// Create proxy
var orderService = new OrderService();
var logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("Proxy");
var proxiedService = LoggingProxy<IOrderService>.Create(orderService, logger);

await proxiedService.GetOrderAsync(123); // Logged automatically

// EF Core Lazy Loading Proxy example
/*
// Enable proxies in EF Core
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString)
        .UseLazyLoadingProxies(); // Enable lazy loading
});

public class Order
{
    public int Id { get; set; }
    public virtual Customer Customer { get; set; } // virtual enables proxy
}

// Access triggers lazy load
var order = context.Orders.First();
var customerName = order.Customer.Name; // Customer loaded on access
*/

// Supporting types
public class Order { public int Id { get; set; } public string CustomerId { get; set; } = ""; public decimal Total { get; set; } }
```

---

### Question 85: Explain global error handling in ASP.NET Core with middleware and filters.

**Short Theory:**  
Global error handling catches unhandled exceptions across application. Three approaches: **Exception Middleware** (`app.UseExceptionHandler`), **Custom Middleware**, **Exception Filters** (MVC only). Middleware catches all exceptions, filters catch controller exceptions only. Use Problem Details (RFC 7807) for consistent API errors. Log exceptions, return appropriate status codes, hide internal details in production.

**Why do we use it?**  
Unhandled exceptions crash requests or expose sensitive info. Centralized error handling provides consistent responses, logging, monitoring. Problem Details standardizes error format for clients. Essential for production apps—catch all errors, log them, return safe responses. Different strategies for APIs vs web apps.

**Key Interview Points:**
- UseExceptionHandler: Built-in middleware
- Custom middleware: Full control over error handling
- Exception filters: MVC/API controllers only
- Problem Details (RFC 7807) for API errors
- Log all exceptions, hide details in production
- Return appropriate status codes (400, 401, 404, 500)

**Coding Example:**
```csharp
// 1. Built-in Exception Handler Middleware
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Detailed errors in dev
}
else
{
    app.UseExceptionHandler("/error"); // Production error handler
}

// Error endpoint
app.MapGet("/error", (HttpContext context) =>
{
    var exception = context.Features.Get<IExceptionHandlerFeature>();
    
    return Results.Problem(
        title: "An error occurred",
        statusCode: StatusCodes.Status500InternalServerError,
        detail: app.Environment.IsDevelopment() ? exception?.Error.Message : null
    );
});

app.MapControllers();
app.Run();

// 2. Custom Exception Middleware (more control)
public class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalExceptionMiddleware> _logger;
    private readonly IWebHostEnvironment _env;
    
    public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger, IWebHostEnvironment env)
    {
        _next = next;
        _logger = logger;
        _env = env;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred");
            await HandleExceptionAsync(context, ex);
        }
    }
    
    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/problem+json";
        
        var (statusCode, title, detail) = exception switch
        {
            ValidationException => (StatusCodes.Status400BadRequest, "Validation Error", exception.Message),
            UnauthorizedAccessException => (StatusCodes.Status401Unauthorized, "Unauthorized", "Access denied"),
            KeyNotFoundException => (StatusCodes.Status404NotFound, "Not Found", exception.Message),
            _ => (StatusCodes.Status500InternalServerError, "Internal Server Error", 
                  _env.IsDevelopment() ? exception.Message : "An error occurred")
        };
        
        context.Response.StatusCode = statusCode;
        
        var problemDetails = new ProblemDetails
        {
            Status = statusCode,
            Title = title,
            Detail = detail,
            Instance = context.Request.Path
        };
        
        if (_env.IsDevelopment())
        {
            problemDetails.Extensions["trace"] = exception.StackTrace;
        }
        
        await context.Response.WriteAsJsonAsync(problemDetails);
    }
}

// Register middleware
app.UseMiddleware<GlobalExceptionMiddleware>();

// 3. Exception Filter (MVC/API only)
public class GlobalExceptionFilter : IExceptionFilter
{
    private readonly ILogger<GlobalExceptionFilter> _logger;
    private readonly IWebHostEnvironment _env;
    
    public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger, IWebHostEnvironment env)
    {
        _logger = logger;
        _env = env;
    }
    
    public void OnException(ExceptionContext context)
    {
        _logger.LogError(context.Exception, "Exception in action {Action}", context.ActionDescriptor.DisplayName);
        
        var statusCode = context.Exception switch
        {
            ValidationException => StatusCodes.Status400BadRequest,
            UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
            KeyNotFoundException => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };
        
        var problemDetails = new ProblemDetails
        {
            Status = statusCode,
            Title = GetTitle(context.Exception),
            Detail = _env.IsDevelopment() ? context.Exception.Message : "An error occurred",
            Instance = context.HttpContext.Request.Path
        };
        
        context.Result = new ObjectResult(problemDetails) { StatusCode = statusCode };
        context.ExceptionHandled = true;
    }
    
    private string GetTitle(Exception exception) => exception switch
    {
        ValidationException => "Validation Error",
        UnauthorizedAccessException => "Unauthorized",
        KeyNotFoundException => "Not Found",
        _ => "Internal Server Error"
    };
}

// Register filter globally
builder.Services.AddControllers(options =>
{
    options.Filters.Add<GlobalExceptionFilter>();
});

// 4. Custom exceptions for different scenarios
public class ValidationException : Exception
{
    public ValidationException(string message) : base(message) { }
}

public class BusinessRuleException : Exception
{
    public string ErrorCode { get; }
    
    public BusinessRuleException(string errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }
}

// Controller with specific error handling
[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetOrder(int id)
    {
        if (id <= 0)
            throw new ValidationException("Order ID must be positive");
        
        if (id == 999)
            throw new KeyNotFoundException($"Order {id} not found");
        
        return Ok(new { Id = id, Status = "Completed" });
    }
    
    [HttpPost]
    public IActionResult CreateOrder([FromBody] CreateOrderRequest request)
    {
        if (request.Total < 0)
            throw new BusinessRuleException("NEGATIVE_TOTAL", "Order total cannot be negative");
        
        return CreatedAtAction(nameof(GetOrder), new { id = 123 }, null);
    }
}

// Supporting types
public class CreateOrderRequest { public decimal Total { get; set; } }
```

---

**Batch 15 completed (Questions 81-85). Continue with next batch.**

---

## Batch 16: Advanced Topics & Best Practices (Questions 86-90)

### Question 86: Explain Code-First vs Database-First in EF Core. When to use each?

**Short Theory:**  
**Code-First**: Define entities in C#, EF generates database via migrations. Full control, version-controlled schema, easier testing. **Database-First**: Existing database, scaffold entities with `Scaffold-DbContext`. Use for legacy databases, DBA-controlled schemas. **Model-First** deprecated. Code-First is modern standard—enables CI/CD, testability, domain-driven design.

**Why do we use it?**  
Code-First enables version control for schema, automated deployments, easier collaboration. Migrations track schema evolution. Database-First necessary for existing databases, enterprise DBAs controlling schema. New projects: Code-First. Legacy systems: Database-First initially, migrate to Code-First. Team preference and constraints drive choice.

**Key Interview Points:**
- Code-First: C# classes define schema, migrations generate DB
- Database-First: Existing DB, scaffold entities
- Code-First advantages: Version control, testability, CI/CD
- Database-First for: Legacy systems, DBA-controlled schemas
- Migrations track schema changes
- Modern standard: Code-First with migrations

**Coding Example:**
```csharp
// CODE-FIRST APPROACH

// 1. Define entities
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public List<Product> Products { get; set; } = new();
}

// 2. Configure DbContext
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configuration
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Price).HasColumnType("decimal(18,2)");
            
            entity.HasOne(p => p.Category)
                  .WithMany(c => c.Products)
                  .HasForeignKey(p => p.CategoryId);
        });
        
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
        });
        
        // Seed data
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" }
        );
    }
}

// 3. Create migration
// dotnet ef migrations add InitialCreate
// dotnet ef database update

// 4. Migration file (auto-generated)
/*
public partial class InitialCreate : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Categories",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(maxLength: 100, nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Categories", x => x.Id); });
        
        migrationBuilder.CreateTable(
            name: "Products",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(maxLength: 200, nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                CategoryId = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Products", x => x.Id);
                table.ForeignKey(
                    name: "FK_Products_Categories_CategoryId",
                    column: x => x.CategoryId,
                    principalTable: "Categories",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });
    }
    
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(name: "Products");
        migrationBuilder.DropTable(name: "Categories");
    }
}
*/

// DATABASE-FIRST APPROACH

// 1. Scaffold from existing database
// dotnet ef dbcontext scaffold "Server=.;Database=MyDb;Trusted_Connection=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models

// 2. Generated DbContext
/*
public partial class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Auto-generated configurations based on DB schema
        OnModelCreatingPartial(modelBuilder);
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
*/

// 3. Extend generated models with partial classes
public partial class Product
{
    // Add domain logic without modifying generated code
    public bool IsExpensive() => Price > 1000;
}

// HYBRID APPROACH (recommended for existing databases)
// 1. Start with Database-First (scaffold once)
// 2. Switch to Code-First (enable migrations)
// 3. Future changes via migrations

// Enable migrations on existing DB
// dotnet ef migrations add InitialFromExisting --context MyDbContext

// Custom migration for existing DB (empty Up/Down)
/*
public partial class InitialFromExisting : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        // Empty - DB already exists
    }
    
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        // Empty
    }
}
*/
```

---

### Question 87: Explain the Template Method pattern. How is it used in ASP.NET Core?

**Short Theory:**  
Template Method defines algorithm skeleton in base class, subclasses override specific steps. Base class controls flow, derived classes provide implementation. Use abstract or virtual methods for customizable steps. ASP.NET Core uses in: Middleware pipeline, Model binding, Authorization handlers. Alternative to Strategy pattern—inheritance vs composition.

**Why do we use it?**  
Reuse common algorithm structure while allowing customization. Base class enforces order of operations. Reduces code duplication—shared logic in base, variations in derived. Common in frameworks (ASP.NET, XUnit). Trade-off: Inheritance coupling vs Strategy's composition flexibility.

**Key Interview Points:**
- Define algorithm skeleton in base class
- Subclasses override specific steps
- Base class controls execution flow
- Use abstract/virtual methods for steps
- Used in: Middleware, authorization, testing frameworks
- Alternative to Strategy (inheritance vs composition)

**Coding Example:**
```csharp
// Template Method pattern
public abstract class DataImporter
{
    // Template method - defines algorithm structure
    public async Task<ImportResult> ImportDataAsync(string source)
    {
        Console.WriteLine("Starting import process...");
        
        // Step 1: Validate (common)
        if (!ValidateSource(source))
        {
            return new ImportResult { Success = false, Error = "Invalid source" };
        }
        
        // Step 2: Open connection (customizable)
        await OpenConnectionAsync(source);
        
        // Step 3: Read data (customizable)
        var data = await ReadDataAsync();
        
        // Step 4: Transform (optional hook)
        data = TransformData(data);
        
        // Step 5: Save (customizable)
        await SaveDataAsync(data);
        
        // Step 6: Close connection (customizable)
        await CloseConnectionAsync();
        
        Console.WriteLine("Import completed");
        return new ImportResult { Success = true, RecordsProcessed = data.Count };
    }
    
    // Common implementation
    protected virtual bool ValidateSource(string source)
    {
        return !string.IsNullOrEmpty(source);
    }
    
    // Required implementations in derived classes
    protected abstract Task OpenConnectionAsync(string source);
    protected abstract Task<List<string>> ReadDataAsync();
    protected abstract Task SaveDataAsync(List<string> data);
    protected abstract Task CloseConnectionAsync();
    
    // Optional hook - can override if needed
    protected virtual List<string> TransformData(List<string> data)
    {
        return data; // Default: no transformation
    }
}

// Concrete implementation 1: CSV Import
public class CsvDataImporter : DataImporter
{
    private StreamReader? _reader;
    
    protected override Task OpenConnectionAsync(string source)
    {
        _reader = new StreamReader(source);
        Console.WriteLine($"Opened CSV file: {source}");
        return Task.CompletedTask;
    }
    
    protected override async Task<List<string>> ReadDataAsync()
    {
        var data = new List<string>();
        while (!_reader!.EndOfStream)
        {
            var line = await _reader.ReadLineAsync();
            if (line != null) data.Add(line);
        }
        Console.WriteLine($"Read {data.Count} lines from CSV");
        return data;
    }
    
    protected override List<string> TransformData(List<string> data)
    {
        // CSV-specific transformation
        return data.Select(line => line.ToUpper()).ToList();
    }
    
    protected override Task SaveDataAsync(List<string> data)
    {
        Console.WriteLine($"Saving {data.Count} records to database");
        return Task.CompletedTask;
    }
    
    protected override Task CloseConnectionAsync()
    {
        _reader?.Dispose();
        Console.WriteLine("Closed CSV file");
        return Task.CompletedTask;
    }
}

// Concrete implementation 2: API Import
public class ApiDataImporter : DataImporter
{
    private HttpClient? _httpClient;
    
    protected override Task OpenConnectionAsync(string source)
    {
        _httpClient = new HttpClient { BaseAddress = new Uri(source) };
        Console.WriteLine($"Connected to API: {source}");
        return Task.CompletedTask;
    }
    
    protected override async Task<List<string>> ReadDataAsync()
    {
        var response = await _httpClient!.GetStringAsync("/data");
        var data = JsonSerializer.Deserialize<List<string>>(response) ?? new();
        Console.WriteLine($"Retrieved {data.Count} records from API");
        return data;
    }
    
    protected override Task SaveDataAsync(List<string> data)
    {
        Console.WriteLine($"Saving {data.Count} records to database");
        return Task.CompletedTask;
    }
    
    protected override Task CloseConnectionAsync()
    {
        _httpClient?.Dispose();
        Console.WriteLine("Closed API connection");
        return Task.CompletedTask;
    }
}

// Usage
var csvImporter = new CsvDataImporter();
var result = await csvImporter.ImportDataAsync("data.csv");

var apiImporter = new ApiDataImporter();
var apiResult = await apiImporter.ImportDataAsync("https://api.example.com");

// ASP.NET Core example: Custom Authorization Handler (uses Template Method)
public abstract class BaseAuthorizationHandler<TRequirement> : AuthorizationHandler<TRequirement>
    where TRequirement : IAuthorizationRequirement
{
    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        TRequirement requirement)
    {
        // Template method pattern
        var user = context.User;
        
        // Step 1: Check authentication
        if (!user.Identity?.IsAuthenticated ?? true)
        {
            return;
        }
        
        // Step 2: Check specific requirement (customizable)
        if (await CheckRequirementAsync(context, requirement))
        {
            context.Succeed(requirement);
        }
    }
    
    // Derived classes implement specific check
    protected abstract Task<bool> CheckRequirementAsync(
        AuthorizationHandlerContext context,
        TRequirement requirement);
}

// Concrete handler
public class MinimumAgeRequirement : IAuthorizationRequirement
{
    public int MinimumAge { get; }
    public MinimumAgeRequirement(int minimumAge) => MinimumAge = minimumAge;
}

public class MinimumAgeHandler : BaseAuthorizationHandler<MinimumAgeRequirement>
{
    protected override Task<bool> CheckRequirementAsync(
        AuthorizationHandlerContext context,
        MinimumAgeRequirement requirement)
    {
        var ageClaim = context.User.FindFirst(c => c.Type == "age");
        if (ageClaim != null && int.TryParse(ageClaim.Value, out int age))
        {
            return Task.FromResult(age >= requirement.MinimumAge);
        }
        return Task.FromResult(false);
    }
}

// Supporting types
public class ImportResult { public bool Success { get; set; } public int RecordsProcessed { get; set; } public string Error { get; set; } = ""; }
```

---

### Question 88: Explain rate limiting and throttling in APIs. How to implement with AspNetCoreRateLimit?

**Short Theory:**  
Rate limiting restricts requests per time window to prevent abuse and ensure fair usage. Types: **Per IP** (limit by client IP), **Per User** (authenticated users), **Per Endpoint** (specific API routes). Strategies: Fixed window, Sliding window, Token bucket, Leaky bucket. Return HTTP 429 (Too Many Requests). Essential for public APIs, DDoS protection, cost control.

**Why do we use it?**  
Prevent API abuse, protect resources, ensure fair usage among clients. Without limits, single client can exhaust resources. Rate limiting prevents DDoS, reduces costs (cloud APIs charged per request). SLA enforcement—free tier limited, paid tier higher limits. Critical for public APIs and multi-tenant systems.

**Key Interview Points:**
- Limit requests per time window
- Types: Per IP, per user, per endpoint
- Strategies: Fixed window, sliding window, token bucket
- Return HTTP 429 Too Many Requests
- Use for: API protection, fair usage, cost control
- AspNetCoreRateLimit or .NET 7+ built-in

**Coding Example:**
```csharp
// .NET 7+ Built-in Rate Limiting
// Install: Microsoft.AspNetCore.RateLimiting

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRateLimiter(options =>
{
    // Fixed window - 10 requests per minute
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.Window = TimeSpan.FromMinutes(1);
        opt.PermitLimit = 10;
        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        opt.QueueLimit = 2;
    });
    
    // Sliding window - smoother than fixed
    options.AddSlidingWindowLimiter("sliding", opt =>
    {
        opt.Window = TimeSpan.FromMinutes(1);
        opt.PermitLimit = 10;
        opt.SegmentsPerWindow = 6; // 10 second segments
    });
    
    // Token bucket - burst support
    options.AddTokenBucketLimiter("token", opt =>
    {
        opt.TokenLimit = 100;
        opt.ReplenishmentPeriod = TimeSpan.FromMinutes(1);
        opt.TokensPerPeriod = 10;
        opt.AutoReplenishment = true;
    });
    
    // Concurrency limiter
    options.AddConcurrencyLimiter("concurrent", opt =>
    {
        opt.PermitLimit = 5;
        opt.QueueLimit = 2;
    });
    
    // Global rate limit
    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(context =>
    {
        return RateLimitPartition.GetFixedWindowLimiter(
            partitionKey: context.User.Identity?.Name ?? context.Connection.RemoteIpAddress?.ToString() ?? "anonymous",
            factory: _ => new FixedWindowRateLimiterOptions
            {
                Window = TimeSpan.FromMinutes(1),
                PermitLimit = 100
            });
    });
    
    options.OnRejected = async (context, cancellationToken) =>
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
        await context.HttpContext.Response.WriteAsync("Rate limit exceeded. Try again later.", cancellationToken);
    };
});

var app = builder.Build();

app.UseRateLimiter();

// Apply to specific endpoints
app.MapGet("/api/products", () => "Products list")
    .RequireRateLimiting("fixed");

app.MapGet("/api/orders", () => "Orders list")
    .RequireRateLimiting("sliding");

app.MapControllers();
app.Run();

// Apply to controller
[ApiController]
[Route("api/[controller]")]
[EnableRateLimiting("token")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(new[] { "User1", "User2" });
    }
    
    [HttpGet("{id}")]
    [DisableRateLimiting] // Disable for specific action
    public IActionResult GetUser(int id)
    {
        return Ok(new { Id = id, Name = "User" });
    }
}

// AspNetCoreRateLimit (more features)
// Install: AspNetCoreRateLimit

builder.Services.AddMemoryCache();
builder.Services.Configure<IpRateLimitOptions>(options =>
{
    options.EnableEndpointRateLimiting = true;
    options.StackBlockedRequests = false;
    options.HttpStatusCode = 429;
    options.RealIpHeader = "X-Real-IP";
    options.ClientIdHeader = "X-ClientId";
    
    // General rules
    options.GeneralRules = new List<RateLimitRule>
    {
        new RateLimitRule
        {
            Endpoint = "*",
            Period = "1m",
            Limit = 100
        },
        new RateLimitRule
        {
            Endpoint = "*",
            Period = "1h",
            Limit = 1000
        },
        new RateLimitRule
        {
            Endpoint = "POST:/api/orders",
            Period = "1m",
            Limit = 10
        }
    };
});

builder.Services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
builder.Services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
builder.Services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();

// Custom rate limit strategy
public class CustomRateLimitStrategy
{
    public async Task<bool> IsAllowedAsync(string clientId, string endpoint)
    {
        // Custom logic: Check database, Redis, or business rules
        var limit = await GetLimitForClientAsync(clientId);
        var usage = await GetCurrentUsageAsync(clientId, endpoint);
        
        return usage < limit;
    }
    
    private Task<int> GetLimitForClientAsync(string clientId)
    {
        // Get from database based on subscription tier
        return Task.FromResult(100);
    }
    
    private Task<int> GetCurrentUsageAsync(string clientId, string endpoint)
    {
        // Get from Redis
        return Task.FromResult(50);
    }
}

// Response headers with rate limit info
app.Use(async (context, next) =>
{
    await next();
    
    // Add rate limit headers
    context.Response.Headers.Add("X-Rate-Limit-Limit", "100");
    context.Response.Headers.Add("X-Rate-Limit-Remaining", "95");
    context.Response.Headers.Add("X-Rate-Limit-Reset", DateTimeOffset.UtcNow.AddMinutes(1).ToUnixTimeSeconds().ToString());
});

// Supporting types
public interface IIpPolicyStore { }
public interface IRateLimitCounterStore { }
public interface IRateLimitConfiguration { }
public interface IProcessingStrategy { }
public class MemoryCacheIpPolicyStore : IIpPolicyStore { }
public class MemoryCacheRateLimitCounterStore : IRateLimitCounterStore { }
public class RateLimitConfiguration : IRateLimitConfiguration { }
public class AsyncKeyLockProcessingStrategy : IProcessingStrategy { }
public class IpRateLimitOptions { public bool EnableEndpointRateLimiting { get; set; } public bool StackBlockedRequests { get; set; } public int HttpStatusCode { get; set; } public string RealIpHeader { get; set; } = ""; public string ClientIdHeader { get; set; } = ""; public List<RateLimitRule> GeneralRules { get; set; } = new(); }
public class RateLimitRule { public string Endpoint { get; set; } = ""; public string Period { get; set; } = ""; public int Limit { get; set; } }
```

---

### Question 89: Explain the Builder pattern. How is it used with Fluent APIs?

**Short Theory:**  
Builder pattern constructs complex objects step-by-step using fluent interface. Separates construction from representation. Chain method calls for readable configuration. Use when: Many optional parameters, immutable objects, complex validation. ASP.NET Core uses extensively: `WebApplicationBuilder`, `IServiceCollection`, `DbContextOptionsBuilder`. Alternative to telescoping constructors and option objects.

**Why do we use it?**  
Complex objects with many parameters are hard to construct. Builder provides readable, maintainable API. Enforces required parameters, allows optional configuration. Fluent interface improves readability. Common in .NET: LINQ, Entity Framework, ASP.NET Core configuration. Essential for framework and library design.

**Key Interview Points:**
- Construct complex objects step-by-step
- Fluent interface (method chaining)
- Separates construction from representation
- Use for: Many parameters, immutable objects
- ASP.NET Core: WebApplicationBuilder, IServiceCollection
- Alternative to telescoping constructors

**Coding Example:**
```csharp
// Traditional constructor problem (telescoping constructors)
public class EmailBad
{
    public EmailBad(string to, string subject, string body) { }
    public EmailBad(string to, string subject, string body, string cc) { }
    public EmailBad(string to, string subject, string body, string cc, string bcc) { }
    public EmailBad(string to, string subject, string body, string cc, string bcc, List<string> attachments) { }
    // Too many constructors!
}

// Builder pattern solution
public class Email
{
    public string To { get; private set; } = "";
    public string Subject { get; private set; } = "";
    public string Body { get; private set; } = "";
    public string? Cc { get; private set; }
    public string? Bcc { get; private set; }
    public List<string> Attachments { get; private set; } = new();
    public bool IsHtml { get; private set; }
    
    private Email() { } // Private constructor
    
    public class Builder
    {
        private readonly Email _email = new();
        
        // Required parameters in constructor
        public Builder(string to, string subject, string body)
        {
            _email.To = to;
            _email.Subject = subject;
            _email.Body = body;
        }
        
        // Optional parameters via fluent methods
        public Builder WithCc(string cc)
        {
            _email.Cc = cc;
            return this;
        }
        
        public Builder WithBcc(string bcc)
        {
            _email.Bcc = bcc;
            return this;
        }
        
        public Builder AddAttachment(string attachment)
        {
            _email.Attachments.Add(attachment);
            return this;
        }
        
        public Builder AsHtml()
        {
            _email.IsHtml = true;
            return this;
        }
        
        public Email Build()
        {
            // Validation before building
            if (string.IsNullOrEmpty(_email.To))
                throw new InvalidOperationException("To is required");
            
            return _email;
        }
    }
}

// Usage - fluent and readable
var email = new Email.Builder("user@example.com", "Hello", "Welcome!")
    .WithCc("manager@example.com")
    .AddAttachment("report.pdf")
    .AddAttachment("invoice.pdf")
    .AsHtml()
    .Build();

// Complex query builder
public interface IQueryBuilder<T>
{
    IQueryBuilder<T> Where(Expression<Func<T, bool>> predicate);
    IQueryBuilder<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector);
    IQueryBuilder<T> Take(int count);
    IQueryBuilder<T> Skip(int count);
    IQueryable<T> Build();
}

public class ProductQueryBuilder : IQueryBuilder<Product>
{
    private IQueryable<Product> _query;
    
    public ProductQueryBuilder(IQueryable<Product> baseQuery)
    {
        _query = baseQuery;
    }
    
    public IQueryBuilder<Product> Where(Expression<Func<Product, bool>> predicate)
    {
        _query = _query.Where(predicate);
        return this;
    }
    
    public IQueryBuilder<Product> OrderBy<TKey>(Expression<Func<Product, TKey>> keySelector)
    {
        _query = _query.OrderBy(keySelector);
        return this;
    }
    
    public IQueryBuilder<Product> Take(int count)
    {
        _query = _query.Take(count);
        return this;
    }
    
    public IQueryBuilder<Product> Skip(int count)
    {
        _query = _query.Skip(count);
        return this;
    }
    
    public IQueryable<Product> Build() => _query;
}

// Usage
var products = new ProductQueryBuilder(context.Products)
    .Where(p => p.Price > 100)
    .OrderBy(p => p.Name)
    .Skip(10)
    .Take(20)
    .Build()
    .ToList();

// HTTP Request Builder
public class HttpRequestBuilder
{
    private readonly HttpRequestMessage _request = new();
    
    public HttpRequestBuilder(HttpMethod method, string uri)
    {
        _request.Method = method;
        _request.RequestUri = new Uri(uri);
    }
    
    public HttpRequestBuilder WithHeader(string name, string value)
    {
        _request.Headers.Add(name, value);
        return this;
    }
    
    public HttpRequestBuilder WithBearerToken(string token)
    {
        _request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        return this;
    }
    
    public HttpRequestBuilder WithContent(HttpContent content)
    {
        _request.Content = content;
        return this;
    }
    
    public HttpRequestBuilder WithJsonContent<T>(T data)
    {
        _request.Content = JsonContent.Create(data);
        return this;
    }
    
    public HttpRequestMessage Build() => _request;
}

// Usage
var request = new HttpRequestBuilder(HttpMethod.Post, "https://api.example.com/orders")
    .WithBearerToken("token123")
    .WithHeader("X-Request-Id", Guid.NewGuid().ToString())
    .WithJsonContent(new { ProductId = 1, Quantity = 2 })
    .Build();

// ASP.NET Core configuration builder pattern
var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString))
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true
        };
    });

// Test data builder
public class OrderTestBuilder
{
    private int _id = 1;
    private string _customerId = "CUST123";
    private decimal _total = 100m;
    private List<OrderItem> _items = new();
    
    public OrderTestBuilder WithId(int id)
    {
        _id = id;
        return this;
    }
    
    public OrderTestBuilder WithCustomer(string customerId)
    {
        _customerId = customerId;
        return this;
    }
    
    public OrderTestBuilder WithTotal(decimal total)
    {
        _total = total;
        return this;
    }
    
    public OrderTestBuilder AddItem(int productId, int quantity)
    {
        _items.Add(new OrderItem { ProductId = productId, Quantity = quantity });
        return this;
    }
    
    public Order Build()
    {
        return new Order
        {
            Id = _id,
            CustomerId = _customerId,
            Total = _total,
            Items = _items
        };
    }
}

// Usage in tests
var testOrder = new OrderTestBuilder()
    .WithId(123)
    .WithCustomer("CUST456")
    .AddItem(1, 2)
    .AddItem(2, 1)
    .Build();

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; public decimal Price { get; set; } }
public class Order { public int Id { get; set; } public string CustomerId { get; set; } = ""; public decimal Total { get; set; } public List<OrderItem> Items { get; set; } = new(); }
public class OrderItem { public int ProductId { get; set; } public int Quantity { get; set; } }
public class AppDbContext : DbContext { public DbSet<Product> Products { get; set; } }
```

---

### Question 90: Explain database connection pooling. How does it work in ADO.NET and EF Core?

**Short Theory:**  
Connection pooling reuses database connections instead of creating new ones. Creating connections is expensive (TCP handshake, authentication). Pool maintains ready connections, reduces latency by 90%. Configured via connection string: `Max Pool Size`, `Min Pool Size`, `Connection Lifetime`. EF Core uses ADO.NET pooling automatically. DbContext pooling (`AddDbContextPool`) further optimizes by reusing DbContext instances.

**Why do we use it?**  
Creating database connections is slow (100-500ms). Pooling reuses connections—millisecond access. Essential for high-throughput applications. Without pooling, connection exhaustion under load. Proper configuration critical—too small hurts performance, too large wastes resources. Monitor pool health in production.

**Key Interview Points:**
- Reuse connections instead of creating new
- Reduces latency by 90% (no handshake/auth)
- Configure: Max Pool Size, Min Pool Size
- EF Core uses ADO.NET pooling automatically
- DbContext pooling for additional optimization
- Monitor connection pool health

**Coding Example:**
```csharp
// Connection string with pooling configuration
var connectionString = "Server=localhost;Database=MyDb;User Id=sa;Password=pass;" +
    "Max Pool Size=100;" +        // Maximum connections in pool
    "Min Pool Size=5;" +           // Minimum connections maintained
    "Connection Lifetime=300;" +   // Recycle connections after 5 minutes
    "Pooling=true;";               // Enable pooling (default)

// ADO.NET connection pooling (automatic)
public class AdoNetExample
{
    private readonly string _connectionString;
    
    public AdoNetExample(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public async Task<List<Product>> GetProductsAsync()
    {
        // Connection automatically returned to pool when disposed
        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync(); // Gets from pool or creates new
        
        using var command = new SqlCommand("SELECT * FROM Products", connection);
        using var reader = await command.ExecuteReaderAsync();
        
        var products = new List<Product>();
        while (await reader.ReadAsync())
        {
            products.Add(new Product
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Price = reader.GetDecimal(2)
            });
        }
        
        return products;
        // Connection returned to pool here (dispose)
    }
}

// EF Core with default pooling
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Uses ADO.NET connection pooling automatically
public class ProductService
{
    private readonly AppDbContext _context;
    
    public ProductService(AppDbContext context) => _context = context;
    
    public async Task<List<Product>> GetProductsAsync()
    {
        // Connection borrowed from pool, returned after query
        return await _context.Products.ToListAsync();
    }
}

// DbContext pooling (more aggressive optimization)
builder.Services.AddDbContextPool<AppDbContext>(options =>
    options.UseSqlServer(connectionString),
    poolSize: 128); // Number of DbContext instances to pool

// DbContext pooling reuses DbContext instances (not just connections)
// Faster than creating new DbContext per request

// Monitor connection pool
public class ConnectionPoolMonitor
{
    public void DisplayPoolStatistics()
    {
        // SQL Server specific
        var stats = new[]
        {
            "Total Connections",
            "Pooled Connections",
            "Non-Pooled Connections",
            "Active Connections"
        };
        
        // Use performance counters or SQL queries
        // SELECT * FROM sys.dm_exec_connections
    }
}

// Connection leak prevention
public class ConnectionLeakExample
{
    private readonly string _connectionString;
    
    public ConnectionLeakExample(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    // BAD: Connection not disposed (leak)
    public async Task<int> BadExampleAsync()
    {
        var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();
        
        var command = new SqlCommand("SELECT COUNT(*) FROM Products", connection);
        var count = (int)await command.ExecuteScalarAsync()!;
        
        // ❌ Connection never returned to pool (leak)
        return count;
    }
    
    // GOOD: Always dispose connections
    public async Task<int> GoodExampleAsync()
    {
        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();
        
        using var command = new SqlCommand("SELECT COUNT(*) FROM Products", connection);
        var count = (int)await command.ExecuteScalarAsync()!;
        
        return count;
        // ✅ Connection returned to pool
    }
}

// Connection pool exhaustion handling
public class PoolExhaustionExample
{
    public async Task SimulatePoolExhaustionAsync(string connectionString)
    {
        var tasks = new List<Task>();
        
        // Create many concurrent operations
        for (int i = 0; i < 200; i++) // More than Max Pool Size
        {
            tasks.Add(Task.Run(async () =>
            {
                try
                {
                    using var connection = new SqlConnection(connectionString);
                    await connection.OpenAsync();
                    
                    // Long-running query
                    await Task.Delay(5000);
                }
                catch (InvalidOperationException ex) when (ex.Message.Contains("pool"))
                {
                    // Connection pool exhausted
                    Console.WriteLine("Pool exhausted!");
                }
            }));
        }
        
        await Task.WhenAll(tasks);
    }
}

// Connection string builder
public class ConnectionStringExample
{
    public string BuildConnectionString()
    {
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = "localhost",
            InitialCatalog = "MyDatabase",
            UserID = "sa",
            Password = "password",
            
            // Pooling configuration
            Pooling = true,
            MaxPoolSize = 100,
            MinPoolSize = 10,
            ConnectionLifetime = 300, // Seconds
            
            // Timeout configuration
            ConnectTimeout = 30,
            CommandTimeout = 60,
            
            // Security
            Encrypt = true,
            TrustServerCertificate = false
        };
        
        return builder.ConnectionString;
    }
}

// Custom pool implementation (for non-SQL databases)
public class GenericConnectionPool<TConnection> where TConnection : class, IDisposable, new()
{
    private readonly ConcurrentBag<TConnection> _pool = new();
    private readonly int _maxSize;
    private int _currentSize;
    
    public GenericConnectionPool(int maxSize)
    {
        _maxSize = maxSize;
    }
    
    public TConnection GetConnection()
    {
        if (_pool.TryTake(out var connection))
        {
            return connection;
        }
        
        if (_currentSize < _maxSize)
        {
            Interlocked.Increment(ref _currentSize);
            return new TConnection();
        }
        
        throw new InvalidOperationException("Pool exhausted");
    }
    
    public void ReturnConnection(TConnection connection)
    {
        _pool.Add(connection);
    }
}

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; public decimal Price { get; set; } }
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; } 
}
```

---

**Batch 16 completed (Questions 86-90). Continue with final batch.**

---

## Batch 17: Advanced Performance & Architecture (Questions 91-95)

### Question 91: Explain IMemoryCache vs IDistributedCache. When to use each?

**Short Theory:**  
**IMemoryCache**: In-process cache, fastest, lost on restart/scale-out. Use for: Single server, small data, low latency required. **IDistributedCache**: External cache (Redis, SQL), shared across instances, survives restarts. Use for: Multi-server, session state, large data. IDistributedCache stores byte arrays (serialize data). IMemoryCache stores objects directly. Choose based on deployment architecture.

**Why do we use it?**  
Caching reduces database load, improves response time. IMemoryCache fastest but not scalable. IDistributedCache enables horizontal scaling—multiple servers share cache. Session state requires distributed cache in load-balanced environments. Performance trade-off: IMemoryCache microseconds, Redis milliseconds. Choose based on scale requirements.

**Key Interview Points:**
- IMemoryCache: In-process, fast, lost on restart
- IDistributedCache: External, shared, survives restart
- IMemoryCache for: Single server, low latency
- IDistributedCache for: Multi-server, session state
- IDistributedCache uses byte arrays (serialization)
- Redis common implementation for IDistributedCache

**Coding Example:**
```csharp
// IMemoryCache example
public class ProductCacheService
{
    private readonly IMemoryCache _cache;
    private readonly AppDbContext _context;
    
    public ProductCacheService(IMemoryCache cache, AppDbContext context)
    {
        _cache = cache;
        _context = context;
    }
    
    public async Task<Product?> GetProductAsync(int id)
    {
        var cacheKey = $"product_{id}";
        
        // Try get from cache
        if (_cache.TryGetValue(cacheKey, out Product? cachedProduct))
        {
            return cachedProduct;
        }
        
        // Not in cache, get from database
        var product = await _context.Products.FindAsync(id);
        
        if (product != null)
        {
            // Store in cache with options
            var cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
                SlidingExpiration = TimeSpan.FromMinutes(2),
                Priority = CacheItemPriority.Normal
            };
            
            // Add eviction callback
            cacheOptions.RegisterPostEvictionCallback((key, value, reason, state) =>
            {
                Console.WriteLine($"Cache evicted: {key}, Reason: {reason}");
            });
            
            _cache.Set(cacheKey, product, cacheOptions);
        }
        
        return product;
    }
    
    public void RemoveProduct(int id)
    {
        _cache.Remove($"product_{id}");
    }
    
    public async Task<List<Product>> GetExpensiveProductsAsync()
    {
        return await _cache.GetOrCreateAsync("expensive_products", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5);
            return await _context.Products.Where(p => p.Price > 1000).ToListAsync();
        }) ?? new List<Product>();
    }
}

// IDistributedCache example (Redis)
// Install: Microsoft.Extensions.Caching.StackExchangeRedis
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
    options.InstanceName = "MyApp_";
});

public class DistributedProductCacheService
{
    private readonly IDistributedCache _cache;
    private readonly AppDbContext _context;
    
    public DistributedProductCacheService(IDistributedCache cache, AppDbContext context)
    {
        _cache = cache;
        _context = context;
    }
    
    public async Task<Product?> GetProductAsync(int id)
    {
        var cacheKey = $"product_{id}";
        
        // Get from distributed cache
        var cachedBytes = await _cache.GetAsync(cacheKey);
        
        if (cachedBytes != null)
        {
            // Deserialize
            var cachedJson = Encoding.UTF8.GetString(cachedBytes);
            return JsonSerializer.Deserialize<Product>(cachedJson);
        }
        
        // Not in cache, get from database
        var product = await _context.Products.FindAsync(id);
        
        if (product != null)
        {
            // Serialize and store
            var json = JsonSerializer.Serialize(product);
            var bytes = Encoding.UTF8.GetBytes(json);
            
            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1),
                SlidingExpiration = TimeSpan.FromMinutes(10)
            };
            
            await _cache.SetAsync(cacheKey, bytes, options);
        }
        
        return product;
    }
    
    public async Task RemoveProductAsync(int id)
    {
        await _cache.RemoveAsync($"product_{id}");
    }
    
    // String extension methods
    public async Task SetStringAsync(string key, string value, TimeSpan? expiry = null)
    {
        await _cache.SetStringAsync(key, value, new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = expiry ?? TimeSpan.FromMinutes(30)
        });
    }
    
    public async Task<string?> GetStringAsync(string key)
    {
        return await _cache.GetStringAsync(key);
    }
}

// Hybrid caching (L1: Memory, L2: Redis)
public class HybridCacheService
{
    private readonly IMemoryCache _memoryCache;
    private readonly IDistributedCache _distributedCache;
    private readonly AppDbContext _context;
    
    public HybridCacheService(IMemoryCache memoryCache, IDistributedCache distributedCache, AppDbContext context)
    {
        _memoryCache = memoryCache;
        _distributedCache = distributedCache;
        _context = context;
    }
    
    public async Task<Product?> GetProductAsync(int id)
    {
        var cacheKey = $"product_{id}";
        
        // L1: Check memory cache (fastest)
        if (_memoryCache.TryGetValue(cacheKey, out Product? product))
        {
            return product;
        }
        
        // L2: Check distributed cache
        var cachedBytes = await _distributedCache.GetAsync(cacheKey);
        if (cachedBytes != null)
        {
            var json = Encoding.UTF8.GetString(cachedBytes);
            product = JsonSerializer.Deserialize<Product>(json);
            
            // Store in L1 for faster subsequent access
            _memoryCache.Set(cacheKey, product, TimeSpan.FromMinutes(5));
            return product;
        }
        
        // L3: Get from database
        product = await _context.Products.FindAsync(id);
        
        if (product != null)
        {
            // Store in both caches
            var json = JsonSerializer.Serialize(product);
            var bytes = Encoding.UTF8.GetBytes(json);
            
            await _distributedCache.SetAsync(cacheKey, bytes, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1)
            });
            
            _memoryCache.Set(cacheKey, product, TimeSpan.FromMinutes(5));
        }
        
        return product;
    }
}

// Session state with IDistributedCache
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

public class SessionService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    
    public SessionService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    
    public void SetCart(List<int> productIds)
    {
        var session = _httpContextAccessor.HttpContext?.Session;
        var json = JsonSerializer.Serialize(productIds);
        session?.SetString("cart", json);
    }
    
    public List<int> GetCart()
    {
        var session = _httpContextAccessor.HttpContext?.Session;
        var json = session?.GetString("cart");
        return json != null ? JsonSerializer.Deserialize<List<int>>(json) ?? new() : new();
    }
}

// Cache-aside pattern
public class CacheAsideService
{
    private readonly IDistributedCache _cache;
    private readonly AppDbContext _context;
    
    public async Task<Product?> GetAsync(int id)
    {
        var key = $"product_{id}";
        
        // Read from cache
        var cached = await _cache.GetStringAsync(key);
        if (cached != null)
            return JsonSerializer.Deserialize<Product>(cached);
        
        // Cache miss - read from DB
        var product = await _context.Products.FindAsync(id);
        
        // Write to cache
        if (product != null)
            await _cache.SetStringAsync(key, JsonSerializer.Serialize(product));
        
        return product;
    }
    
    public async Task UpdateAsync(Product product)
    {
        // Write to DB
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        
        // Invalidate cache
        await _cache.RemoveAsync($"product_{product.Id}");
    }
}

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; public decimal Price { get; set; } }
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; } 
}
```

---

### Question 92: Explain the Mediator pattern and MediatR library. When to use it?

**Short Theory:**  
Mediator decouples components by routing communication through central mediator. Components don't reference each other directly. **MediatR**: Popular .NET library implementing mediator pattern. Handlers process requests (commands/queries). Use for: CQRS, clean architecture, reducing coupling. Requests are IRequest<TResponse>, handlers are IRequestHandler. Pipeline behaviors add cross-cutting concerns (validation, logging).

**Why do we use it?**  
Reduces coupling between components—no direct dependencies. Clean architecture—application layer uses mediator, handlers in application/infrastructure. CQRS separation—commands modify, queries read. Pipeline behaviors apply cross-cutting concerns without modifying handlers. Testability improved—mock mediator or handlers independently. Essential for complex domain logic.

**Key Interview Points:**
- Decouples components via central mediator
- MediatR: Commands, queries, handlers, notifications
- Use for: CQRS, clean architecture, reducing coupling
- Pipeline behaviors for cross-cutting concerns
- IRequest<T> and IRequestHandler<TRequest, TResponse>
- Notifications for events (one-to-many)

**Coding Example:**
```csharp
// Install: MediatR and MediatR.Extensions.Microsoft.DependencyInjection
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

// Command (write operation)
public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly AppDbContext _context;
    
    public CreateProductCommandHandler(AppDbContext context) => _context = context;
    
    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price
        };
        
        _context.Products.Add(product);
        await _context.SaveChangesAsync(cancellationToken);
        
        return product.Id;
    }
}

// Query (read operation)
public record GetProductQuery(int Id) : IRequest<Product?>;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product?>
{
    private readonly AppDbContext _context;
    
    public GetProductQueryHandler(AppDbContext context) => _context = context;
    
    public async Task<Product?> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        return await _context.Products.FindAsync(new object[] { request.Id }, cancellationToken);
    }
}

// Controller using MediatR
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public ProductsController(IMediator mediator) => _mediator = mediator;
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(Get), new { id }, null);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var product = await _mediator.Send(new GetProductQuery(id));
        return product != null ? Ok(product) : NotFound();
    }
}

// Pipeline behavior - Validation
public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    
    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
    
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        // Run before handler
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var failures = _validators
                .Select(v => v.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();
            
            if (failures.Any())
                throw new ValidationException(failures);
        }
        
        // Call next in pipeline
        var response = await next();
        
        // Run after handler (if needed)
        return response;
    }
}

// Pipeline behavior - Logging
public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;
    
    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }
    
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Handling {RequestName}", typeof(TRequest).Name);
        
        var stopwatch = Stopwatch.StartNew();
        var response = await next();
        stopwatch.Stop();
        
        _logger.LogInformation("Handled {RequestName} in {ElapsedMs}ms", typeof(TRequest).Name, stopwatch.ElapsedMilliseconds);
        
        return response;
    }
}

// Register behaviors
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining<Program>();
    cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
    cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
});

// Notifications (one-to-many)
public record ProductCreatedNotification(int ProductId, string Name) : INotification;

public class SendEmailHandler : INotificationHandler<ProductCreatedNotification>
{
    public Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Sending email for product: {notification.Name}");
        return Task.CompletedTask;
    }
}

public class UpdateCacheHandler : INotificationHandler<ProductCreatedNotification>
{
    public Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Updating cache for product: {notification.ProductId}");
        return Task.CompletedTask;
    }
}

// Publish notification
public class CreateProductWithNotificationHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly AppDbContext _context;
    private readonly IMediator _mediator;
    
    public CreateProductWithNotificationHandler(AppDbContext context, IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }
    
    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product { Name = request.Name, Price = request.Price };
        _context.Products.Add(product);
        await _context.SaveChangesAsync(cancellationToken);
        
        // Publish notification (all handlers execute)
        await _mediator.Publish(new ProductCreatedNotification(product.Id, product.Name), cancellationToken);
        
        return product.Id;
    }
}

// Complex command with result
public record PlaceOrderCommand(int CustomerId, List<OrderItemDto> Items) : IRequest<Result<int>>;

public class PlaceOrderCommandHandler : IRequestHandler<PlaceOrderCommand, Result<int>>
{
    private readonly AppDbContext _context;
    
    public PlaceOrderCommandHandler(AppDbContext context) => _context = context;
    
    public async Task<Result<int>> Handle(PlaceOrderCommand request, CancellationToken cancellationToken)
    {
        // Validate
        if (!request.Items.Any())
            return Result<int>.Failure("Order must have at least one item");
        
        // Create order
        var order = new Order { CustomerId = request.CustomerId };
        _context.Orders.Add(order);
        await _context.SaveChangesAsync(cancellationToken);
        
        return Result<int>.Success(order.Id);
    }
}

// Result wrapper
public class Result<T>
{
    public bool IsSuccess { get; init; }
    public T? Value { get; init; }
    public string? Error { get; init; }
    
    public static Result<T> Success(T value) => new() { IsSuccess = true, Value = value };
    public static Result<T> Failure(string error) => new() { IsSuccess = false, Error = error };
}

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; public decimal Price { get; set; } }
public class Order { public int Id { get; set; } public int CustomerId { get; set; } }
public class OrderItemDto { public int ProductId { get; set; } public int Quantity { get; set; } }
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
}
public interface IValidator<T> { ValidationResult Validate(ValidationContext<T> context); }
public class ValidationContext<T> { public ValidationContext(T instance) { } }
public class ValidationResult { public List<ValidationFailure> Errors { get; set; } = new(); }
public class ValidationFailure { public string PropertyName { get; set; } = ""; public string ErrorMessage { get; set; } = ""; }
public class ValidationException : Exception { public ValidationException(List<ValidationFailure> failures) : base("Validation failed") { } }
```

---

### Question 93: Explain versioning strategies for APIs. How to implement in ASP.NET Core?

**Short Theory:**  
API versioning maintains backward compatibility while evolving APIs. Strategies: **URL path** (/api/v1/products), **Query string** (?api-version=1.0), **Header** (X-API-Version), **Media type** (Accept: application/json;v=1). Use Microsoft.AspNetCore.Mvc.Versioning. Deprecation lifecycle: Announce → Mark deprecated → Remove after grace period. Choose strategy based on client requirements and caching needs.

**Why do we use it?**  
Breaking changes break existing clients. Versioning allows evolution without disruption. Multiple versions run simultaneously during migration. Clear deprecation path for old versions. Different strategies suit different scenarios: URL visible in browser, header for programmatic clients. Essential for public APIs with diverse clients.

**Key Interview Points:**
- Maintain backward compatibility during evolution
- Strategies: URL, query string, header, media type
- Microsoft.AspNetCore.Mvc.Versioning package
- Deprecation lifecycle: Announce → Deprecate → Remove
- Multiple versions run simultaneously
- Choose based on client needs and caching

**Coding Example:**
```csharp
// Install: Microsoft.AspNetCore.Mvc.Versioning
// Install: Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true; // Add version info to response headers
    
    // Multiple versioning strategies
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-API-Version"),
        new MediaTypeApiVersionReader("version")
    );
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

// URL Path versioning
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ProductsV1Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Version = "1.0", Products = new[] { "Product1", "Product2" } });
    }
}

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class ProductsV2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // V2 returns more data
        return Ok(new
        {
            Version = "2.0",
            Products = new[]
            {
                new { Id = 1, Name = "Product1", Price = 100 },
                new { Id = 2, Name = "Product2", Price = 200 }
            }
        });
    }
}

// Multiple versions in same controller
[ApiController]
[Route("api/[controller]")]
[ApiVersion("1.0")]
[ApiVersion("2.0")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    [MapToApiVersion("1.0")]
    public IActionResult GetV1()
    {
        return Ok(new { Version = "1.0", Orders = new[] { "Order1" } });
    }
    
    [HttpGet]
    [MapToApiVersion("2.0")]
    public IActionResult GetV2()
    {
        return Ok(new { Version = "2.0", Orders = new[] { new { Id = 1, Total = 100 } } });
    }
}

// Deprecated version
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0", Deprecated = true)]
[ApiVersion("2.0")]
public class CustomersController : ControllerBase
{
    [HttpGet]
    [MapToApiVersion("1.0")]
    public IActionResult GetV1()
    {
        // Add deprecation warning in response
        Response.Headers.Add("X-API-Deprecated", "true");
        Response.Headers.Add("X-API-Sunset", "2026-12-31");
        
        return Ok(new { Version = "1.0 (Deprecated)" });
    }
    
    [HttpGet]
    [MapToApiVersion("2.0")]
    public IActionResult GetV2()
    {
        return Ok(new { Version = "2.0" });
    }
}

// Version-specific models
public class ProductV1Dto
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

public class ProductV2Dto
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public string Category { get; set; } = "";
}

// Service with version-aware logic
public class ProductService
{
    private readonly AppDbContext _context;
    
    public ProductService(AppDbContext context) => _context = context;
    
    public async Task<object> GetProductsAsync(ApiVersion version)
    {
        var products = await _context.Products.ToListAsync();
        
        if (version.MajorVersion == 1)
        {
            return products.Select(p => new ProductV1Dto { Id = p.Id, Name = p.Name });
        }
        else
        {
            return products.Select(p => new ProductV2Dto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Category = "Electronics"
            });
        }
    }
}

// Custom version selector
public class CustomApiVersionSelector : IApiVersionSelector
{
    public ApiVersion SelectVersion(HttpRequest request, ApiVersionModel model)
    {
        // Custom logic: Use header, query, or default
        if (request.Headers.TryGetValue("X-API-Version", out var headerValue))
        {
            return ApiVersion.Parse(headerValue!);
        }
        
        return model.ImplementedApiVersions.OrderByDescending(v => v).FirstOrDefault() ?? new ApiVersion(1, 0);
    }
}

// Swagger with versioning
builder.Services.AddSwaggerGen(options =>
{
    var provider = builder.Services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();
    
    foreach (var description in provider.ApiVersionDescriptions)
    {
        options.SwaggerDoc(description.GroupName, new OpenApiInfo
        {
            Title = $"My API {description.ApiVersion}",
            Version = description.ApiVersion.ToString(),
            Description = description.IsDeprecated ? "This version is deprecated" : ""
        });
    }
});

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
    
    foreach (var description in provider.ApiVersionDescriptions)
    {
        options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
    }
});

// Version negotiation middleware
public class ApiVersionNegotiationMiddleware
{
    private readonly RequestDelegate _next;
    
    public ApiVersionNegotiationMiddleware(RequestDelegate next) => _next = next;
    
    public async Task InvokeAsync(HttpContext context)
    {
        // Extract version from various sources
        var version = context.Request.Query["api-version"].FirstOrDefault()
            ?? context.Request.Headers["X-API-Version"].FirstOrDefault()
            ?? "1.0";
        
        context.Items["ApiVersion"] = version;
        
        await _next(context);
    }
}

// Supporting types
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; public decimal Price { get; set; } }
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; } 
}
```

---

### Question 94: Explain the Specification pattern. How to use it with EF Core?

**Short Theory:**  
Specification encapsulates query logic into reusable, composable objects. Separates query criteria from repository. Specifications define business rules (e.g., "active products under $100"). Combine using AND/OR. Benefits: Reusable queries, testable business rules, DRY principle. Use with repository pattern for clean data access. Alternative to query methods in repository.

**Why do we use it?**  
Repositories with many query methods become bloated (GetActiveProducts, GetExpensiveProducts, GetActiveExpensiveProducts). Specifications make queries reusable and composable. Business logic centralized in specifications, not scattered. Easily testable—mock specifications. Essential for complex domain queries and clean architecture.

**Key Interview Points:**
- Encapsulate query logic in reusable objects
- Compose specifications with AND/OR
- Use with repository pattern
- Testable business rules
- Prevent repository method explosion
- EF Core: Implement with Expression<Func<T, bool>>

**Coding Example:**
```csharp
// Base specification
public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    Expression<Func<T, object>>? OrderBy { get; }
    Expression<Func<T, object>>? OrderByDescending { get; }
    int? Take { get; }
    int? Skip { get; }
}

public abstract class BaseSpecification<T> : ISpecification<T>
{
    public Expression<Func<T, bool>> Criteria { get; private set; } = null!;
    public List<Expression<Func<T, object>>> Includes { get; } = new();
    public Expression<Func<T, object>>? OrderBy { get; private set; }
    public Expression<Func<T, object>>? OrderByDescending { get; private set; }
    public int? Take { get; private set; }
    public int? Skip { get; private set; }
    
    protected void AddCriteria(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }
    
    protected void AddInclude(Expression<Func<T, object>> include)
    {
        Includes.Add(include);
    }
    
    protected void ApplyOrderBy(Expression<Func<T, object>> orderBy)
    {
        OrderBy = orderBy;
    }
    
    protected void ApplyOrderByDescending(Expression<Func<T, object>> orderByDescending)
    {
        OrderByDescending = orderByDescending;
    }
    
    protected void ApplyPaging(int skip, int take)
    {
        Skip = skip;
        Take = take;
    }
}

// Concrete specifications
public class ActiveProductsSpecification : BaseSpecification<Product>
{
    public ActiveProductsSpecification()
    {
        AddCriteria(p => p.IsActive);
    }
}

public class ExpensiveProductsSpecification : BaseSpecification<Product>
{
    public ExpensiveProductsSpecification(decimal minPrice)
    {
        AddCriteria(p => p.Price >= minPrice);
    }
}

public class ProductsInCategorySpecification : BaseSpecification<Product>
{
    public ProductsInCategorySpecification(int categoryId)
    {
        AddCriteria(p => p.CategoryId == categoryId);
        AddInclude(p => p.Category);
        ApplyOrderBy(p => p.Name);
    }
}

public class ProductsWithPagingSpecification : BaseSpecification<Product>
{
    public ProductsWithPagingSpecification(int page, int pageSize)
    {
        ApplyPaging((page - 1) * pageSize, pageSize);
        ApplyOrderBy(p => p.Name);
    }
}

// Specification evaluator (applies spec to IQueryable)
public static class SpecificationEvaluator
{
    public static IQueryable<T> GetQuery<T>(IQueryable<T> inputQuery, ISpecification<T> spec) where T : class
    {
        var query = inputQuery;
        
        // Apply criteria
        if (spec.Criteria != null)
        {
            query = query.Where(spec.Criteria);
        }
        
        // Apply includes
        query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
        
        // Apply ordering
        if (spec.OrderBy != null)
        {
            query = query.OrderBy(spec.OrderBy);
        }
        else if (spec.OrderByDescending != null)
        {
            query = query.OrderByDescending(spec.OrderByDescending);
        }
        
        // Apply paging
        if (spec.Skip.HasValue)
        {
            query = query.Skip(spec.Skip.Value);
        }
        
        if (spec.Take.HasValue)
        {
            query = query.Take(spec.Take.Value);
        }
        
        return query;
    }
}

// Repository with specifications
public interface IRepository<T> where T : class
{
    Task<List<T>> ListAsync(ISpecification<T> spec);
    Task<T?> FirstOrDefaultAsync(ISpecification<T> spec);
    Task<int> CountAsync(ISpecification<T> spec);
}

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    
    public Repository(AppDbContext context) => _context = context;
    
    public async Task<List<T>> ListAsync(ISpecification<T> spec)
    {
        var query = SpecificationEvaluator.GetQuery(_context.Set<T>(), spec);
        return await query.ToListAsync();
    }
    
    public async Task<T?> FirstOrDefaultAsync(ISpecification<T> spec)
    {
        var query = SpecificationEvaluator.GetQuery(_context.Set<T>(), spec);
        return await query.FirstOrDefaultAsync();
    }
    
    public async Task<int> CountAsync(ISpecification<T> spec)
    {
        var query = SpecificationEvaluator.GetQuery(_context.Set<T>(), spec);
        return await query.CountAsync();
    }
}

// Usage
public class ProductService
{
    private readonly IRepository<Product> _repository;
    
    public ProductService(IRepository<Product> repository) => _repository = repository;
    
    public async Task<List<Product>> GetActiveProductsAsync()
    {
        var spec = new ActiveProductsSpecification();
        return await _repository.ListAsync(spec);
    }
    
    public async Task<List<Product>> GetExpensiveProductsAsync(decimal minPrice)
    {
        var spec = new ExpensiveProductsSpecification(minPrice);
        return await _repository.ListAsync(spec);
    }
    
    public async Task<List<Product>> GetProductsInCategoryAsync(int categoryId, int page, int pageSize)
    {
        // Combine specifications
        var spec = new CombinedSpecification(categoryId, page, pageSize);
        return await _repository.ListAsync(spec);
    }
}

// Combined specification
public class CombinedSpecification : BaseSpecification<Product>
{
    public CombinedSpecification(int categoryId, int page, int pageSize)
    {
        AddCriteria(p => p.CategoryId == categoryId && p.IsActive);
        AddInclude(p => p.Category);
        ApplyOrderBy(p => p.Name);
        ApplyPaging((page - 1) * pageSize, pageSize);
    }
}

// Specification composition (AND/OR)
public class AndSpecification<T> : BaseSpecification<T>
{
    public AndSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        var parameter = Expression.Parameter(typeof(T));
        var leftExpression = Expression.Invoke(left.Criteria, parameter);
        var rightExpression = Expression.Invoke(right.Criteria, parameter);
        var andExpression = Expression.AndAlso(leftExpression, rightExpression);
        
        AddCriteria(Expression.Lambda<Func<T, bool>>(andExpression, parameter));
    }
}

public class OrSpecification<T> : BaseSpecification<T>
{
    public OrSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        var parameter = Expression.Parameter(typeof(T));
        var leftExpression = Expression.Invoke(left.Criteria, parameter);
        var rightExpression = Expression.Invoke(right.Criteria, parameter);
        var orExpression = Expression.OrElse(leftExpression, rightExpression);
        
        AddCriteria(Expression.Lambda<Func<T, bool>>(orExpression, parameter));
    }
}

// Extension methods for composition
public static class SpecificationExtensions
{
    public static ISpecification<T> And<T>(this ISpecification<T> left, ISpecification<T> right)
    {
        return new AndSpecification<T>(left, right);
    }
    
    public static ISpecification<T> Or<T>(this ISpecification<T> left, ISpecification<T> right)
    {
        return new OrSpecification<T>(left, right);
    }
}

// Usage with composition
var activeSpec = new ActiveProductsSpecification();
var expensiveSpec = new ExpensiveProductsSpecification(1000);
var combinedSpec = activeSpec.And(expensiveSpec);

var products = await _repository.ListAsync(combinedSpec);

// Supporting types
public class Product 
{ 
    public int Id { get; set; } 
    public string Name { get; set; } = ""; 
    public decimal Price { get; set; } 
    public bool IsActive { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
public class Category { public int Id { get; set; } public string Name { get; set; } = ""; }
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; } 
}
```

---

### Question 95: Explain health checks in ASP.NET Core. How to implement custom health checks?

**Short Theory:**  
Health checks expose application health status via HTTP endpoint. Types: **Liveness** (app running), **Readiness** (can handle requests), **Startup** (initialization complete). Built-in checks: DbContext, Redis, disk storage. Custom checks implement IHealthCheck. Returns Healthy/Degraded/Unhealthy. Used by: Kubernetes, load balancers, monitoring tools. Configure via AddHealthChecks().

**Why do we use it?**  
Orchestrators (Kubernetes) need to know if container is healthy—restart unhealthy instances. Load balancers route traffic only to ready instances. Monitoring systems track health trends. Health checks verify dependencies: database, cache, external APIs. Essential for production resilience, zero-downtime deployments, automatic recovery.

**Key Interview Points:**
- Expose health status via HTTP endpoint
- Types: Liveness, readiness, startup
- Built-in: DbContext, Redis, SQL, disk
- Custom checks: Implement IHealthCheck
- Returns: Healthy, Degraded, Unhealthy
- Used by: Kubernetes, load balancers, monitoring

**Coding Example:**
```csharp
// Install: Microsoft.Extensions.Diagnostics.HealthChecks
// Install: AspNetCore.HealthChecks.SqlServer
// Install: AspNetCore.HealthChecks.Redis

builder.Services.AddHealthChecks()
    .AddCheck("self", () => HealthCheckResult.Healthy())
    .AddSqlServer(connectionString, name: "database", tags: new[] { "db", "sql" })
    .AddRedis(redisConnectionString, name: "redis", tags: new[] { "cache" })
    .AddDbContextCheck<AppDbContext>(name: "dbcontext", tags: new[] { "ef" })
    .AddCheck<ExternalApiHealthCheck>("external-api", tags: new[] { "api" })
    .AddCheck<DiskStorageHealthCheck>("disk", tags: new[] { "storage" });

app.MapHealthChecks("/health");
app.MapHealthChecks("/health/ready", new HealthCheckOptions
{
    Predicate = check => check.Tags.Contains("ready")
});
app.MapHealthChecks("/health/live", new HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = WriteResponse
});

// Custom response writer
static Task WriteResponse(HttpContext context, HealthReport report)
{
    context.Response.ContentType = "application/json";
    
    var result = JsonSerializer.Serialize(new
    {
        status = report.Status.ToString(),
        checks = report.Entries.Select(e => new
        {
            name = e.Key,
            status = e.Value.Status.ToString(),
            description = e.Value.Description,
            duration = e.Value.Duration.TotalMilliseconds,
            exception = e.Value.Exception?.Message,
            data = e.Value.Data
        }),
        totalDuration = report.TotalDuration.TotalMilliseconds
    });
    
    return context.Response.WriteAsync(result);
}

// Custom health check - External API
public class ExternalApiHealthCheck : IHealthCheck
{
    private readonly HttpClient _httpClient;
    
    public ExternalApiHealthCheck(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }
    
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await _httpClient.GetAsync("https://api.example.com/health", cancellationToken);
            
            if (response.IsSuccessStatusCode)
            {
                return HealthCheckResult.Healthy("External API is responsive", new Dictionary<string, object>
                {
                    { "statusCode", (int)response.StatusCode },
                    { "responseTime", response.Headers.Date }
                });
            }
            
            return HealthCheckResult.Degraded($"External API returned {response.StatusCode}");
        }
        catch (Exception ex)
        {
            return HealthCheckResult.Unhealthy("External API is not reachable", ex);
        }
    }
}

// Custom health check - Disk storage
public class DiskStorageHealthCheck : IHealthCheck
{
    private readonly string _driveName;
    private readonly long _minimumFreeMegabytes;
    
    public DiskStorageHealthCheck(string driveName = "C:\\", long minimumFreeMegabytes = 1024)
    {
        _driveName = driveName;
        _minimumFreeMegabytes = minimumFreeMegabytes;
    }
    
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        try
        {
            var drive = new DriveInfo(_driveName);
            var freeSpaceMB = drive.AvailableFreeSpace / 1024 / 1024;
            
            var data = new Dictionary<string, object>
            {
                { "driveName", drive.Name },
                { "freeSpaceMB", freeSpaceMB },
                { "totalSizeMB", drive.TotalSize / 1024 / 1024 }
            };
            
            if (freeSpaceMB >= _minimumFreeMegabytes)
            {
                return Task.FromResult(HealthCheckResult.Healthy($"Disk has {freeSpaceMB}MB free", data));
            }
            
            if (freeSpaceMB >= _minimumFreeMegabytes / 2)
            {
                return Task.FromResult(HealthCheckResult.Degraded($"Disk space low: {freeSpaceMB}MB free", null, data));
            }
            
            return Task.FromResult(HealthCheckResult.Unhealthy($"Disk space critical: {freeSpaceMB}MB free", null, data));
        }
        catch (Exception ex)
        {
            return Task.FromResult(HealthCheckResult.Unhealthy("Failed to check disk storage", ex));
        }
    }
}

// Custom health check - Database query
public class DatabaseHealthCheck : IHealthCheck
{
    private readonly AppDbContext _context;
    
    public DatabaseHealthCheck(AppDbContext context) => _context = context;
    
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        try
        {
            var stopwatch = Stopwatch.StartNew();
            await _context.Database.ExecuteSqlRawAsync("SELECT 1", cancellationToken);
            stopwatch.Stop();
            
            var data = new Dictionary<string, object>
            {
                { "responseTimeMs", stopwatch.ElapsedMilliseconds }
            };
            
            if (stopwatch.ElapsedMilliseconds < 100)
            {
                return HealthCheckResult.Healthy("Database query fast", data);
            }
            
            if (stopwatch.ElapsedMilliseconds < 1000)
            {
                return HealthCheckResult.Degraded("Database query slow", null, data);
            }
            
            return HealthCheckResult.Unhealthy("Database query very slow", null, data);
        }
        catch (Exception ex)
        {
            return HealthCheckResult.Unhealthy("Database query failed", ex);
        }
    }
}

// Health check with tags
builder.Services.AddHealthChecks()
    .AddCheck("liveness", () => HealthCheckResult.Healthy(), tags: new[] { "live" })
    .AddCheck<DatabaseHealthCheck>("database", tags: new[] { "ready", "db" })
    .AddCheck<ExternalApiHealthCheck>("external-api", tags: new[] { "ready" });

// Separate endpoints by tags
app.MapHealthChecks("/health/live", new HealthCheckOptions
{
    Predicate = check => check.Tags.Contains("live")
});

app.MapHealthChecks("/health/ready", new HealthCheckOptions
{
    Predicate = check => check.Tags.Contains("ready")
});

// UI for health checks
// Install: AspNetCore.HealthChecks.UI
builder.Services.AddHealthChecksUI(options =>
{
    options.AddHealthCheckEndpoint("API", "/health");
    options.SetEvaluationTimeInSeconds(10);
    options.MaximumHistoryEntriesPerEndpoint(50);
}).AddInMemoryStorage();

app.MapHealthChecksUI(options => options.UIPath = "/health-ui");

// Kubernetes liveness/readiness probes
/*
livenessProbe:
  httpGet:
    path: /health/live
    port: 80
  initialDelaySeconds: 10
  periodSeconds: 10

readinessProbe:
  httpGet:
    path: /health/ready
    port: 80
  initialDelaySeconds: 5
  periodSeconds: 5
*/

// Health check publisher (alerts)
public class HealthCheckPublisher : IHealthCheckPublisher
{
    private readonly ILogger<HealthCheckPublisher> _logger;
    
    public HealthCheckPublisher(ILogger<HealthCheckPublisher> logger) => _logger = logger;
    
    public Task PublishAsync(HealthReport report, CancellationToken cancellationToken)
    {
        if (report.Status == HealthStatus.Unhealthy)
        {
            _logger.LogError("Health check failed: {Status}", report.Status);
            // Send alert (email, SMS, PagerDuty, etc.)
        }
        
        return Task.CompletedTask;
    }
}

builder.Services.AddSingleton<IHealthCheckPublisher, HealthCheckPublisher>();
builder.Services.Configure<HealthCheckPublisherOptions>(options =>
{
    options.Delay = TimeSpan.FromSeconds(5);
    options.Period = TimeSpan.FromSeconds(30);
});

// Supporting types
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; } 
}
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; }
```

---

**Batch 17 completed (Questions 91-95). Continue with final batch.**

---

## Batch 18: Final Advanced Topics (Questions 96-100)

### Question 96: Explain the Unit of Work pattern. How does EF Core implement it?

**Short Theory:**  
Unit of Work maintains list of changes to be committed as single transaction. Tracks inserts, updates, deletes—commits all or none. EF Core DbContext IS a Unit of Work. `SaveChanges()` commits transaction atomically. Use explicit transactions with `BeginTransaction()` for complex scenarios. Combine with Repository pattern for clean architecture. Ensures data consistency and ACID properties.

**Why do we use it?**  
Without Unit of Work, partial commits leave inconsistent data. All related changes must succeed together—order + order items + inventory update. DbContext tracks changes automatically. Explicit transactions for multi-context operations or business logic requiring multiple saves. Essential for data integrity in complex operations.

**Key Interview Points:**
- Commits multiple changes as single transaction
- DbContext is built-in Unit of Work
- SaveChanges() commits atomically
- Explicit transactions with BeginTransaction()
- Ensures ACID properties
- Use with repository pattern

**Coding Example:**
```csharp
// EF Core DbContext as Unit of Work
public class OrderService
{
    private readonly AppDbContext _context;
    
    public OrderService(AppDbContext context) => _context = context;
    
    public async Task<int> CreateOrderAsync(Order order)
    {
        // DbContext tracks all changes
        _context.Orders.Add(order);
        
        // Add order items
        foreach (var item in order.Items)
        {
            _context.OrderItems.Add(item);
        }
        
        // Update inventory
        var product = await _context.Products.FindAsync(order.Items.First().ProductId);
        if (product != null)
        {
            product.Stock -= order.Items.First().Quantity;
        }
        
        // Single transaction - all or nothing
        await _context.SaveChangesAsync();
        
        return order.Id;
    }
}

// Explicit transaction
public class TransactionService
{
    private readonly AppDbContext _context;
    
    public TransactionService(AppDbContext context) => _context = context;
    
    public async Task TransferFundsAsync(int fromAccountId, int toAccountId, decimal amount)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        
        try
        {
            // Debit from account
            var fromAccount = await _context.Accounts.FindAsync(fromAccountId);
            if (fromAccount == null || fromAccount.Balance < amount)
                throw new InvalidOperationException("Insufficient funds");
            
            fromAccount.Balance -= amount;
            await _context.SaveChangesAsync();
            
            // Credit to account
            var toAccount = await _context.Accounts.FindAsync(toAccountId);
            if (toAccount == null)
                throw new InvalidOperationException("Account not found");
            
            toAccount.Balance += amount;
            await _context.SaveChangesAsync();
            
            // Commit transaction
            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}

// Custom Unit of Work interface
public interface IUnitOfWork : IDisposable
{
    IRepository<Product> Products { get; }
    IRepository<Order> Orders { get; }
    IRepository<Customer> Customers { get; }
    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IDbContextTransaction? _transaction;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        Products = new Repository<Product>(context);
        Orders = new Repository<Order>(context);
        Customers = new Repository<Customer>(context);
    }
    
    public IRepository<Product> Products { get; }
    public IRepository<Order> Orders { get; }
    public IRepository<Customer> Customers { get; }
    
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
    
    public async Task BeginTransactionAsync()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
    }
    
    public async Task CommitAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
            await _transaction!.CommitAsync();
        }
        catch
        {
            await RollbackAsync();
            throw;
        }
        finally
        {
            _transaction?.Dispose();
        }
    }
    
    public async Task RollbackAsync()
    {
        await _transaction!.RollbackAsync();
        _transaction?.Dispose();
    }
    
    public void Dispose()
    {
        _transaction?.Dispose();
        _context.Dispose();
    }
}

// Service using Unit of Work
public class OrderManagementService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public OrderManagementService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    public async Task<int> PlaceOrderAsync(CreateOrderDto dto)
    {
        await _unitOfWork.BeginTransactionAsync();
        
        try
        {
            // Create order
            var order = new Order
            {
                CustomerId = dto.CustomerId,
                Total = dto.Total,
                CreatedDate = DateTime.UtcNow
            };
            
            await _unitOfWork.Orders.AddAsync(order);
            await _unitOfWork.SaveChangesAsync();
            
            // Update customer
            var customer = await _unitOfWork.Customers.GetByIdAsync(dto.CustomerId);
            if (customer != null)
            {
                customer.TotalOrders++;
                await _unitOfWork.SaveChangesAsync();
            }
            
            // Update inventory
            foreach (var item in dto.Items)
            {
                var product = await _unitOfWork.Products.GetByIdAsync(item.ProductId);
                if (product != null)
                {
                    product.Stock -= item.Quantity;
                }
            }
            await _unitOfWork.SaveChangesAsync();
            
            // Commit all changes
            await _unitOfWork.CommitAsync();
            return order.Id;
        }
        catch
        {
            await _unitOfWork.RollbackAsync();
            throw;
        }
    }
}

// Multiple DbContexts scenario
public class MultiContextService
{
    private readonly AppDbContext _appContext;
    private readonly LoggingDbContext _loggingContext;
    
    public MultiContextService(AppDbContext appContext, LoggingDbContext loggingContext)
    {
        _appContext = appContext;
        _loggingContext = loggingContext;
    }
    
    public async Task ProcessOrderAsync(Order order)
    {
        // Cannot use single SaveChanges - need distributed transaction
        using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
        
        try
        {
            // Save to app database
            _appContext.Orders.Add(order);
            await _appContext.SaveChangesAsync();
            
            // Save to logging database
            _loggingContext.AuditLogs.Add(new AuditLog
            {
                Action = "OrderCreated",
                EntityId = order.Id,
                Timestamp = DateTime.UtcNow
            });
            await _loggingContext.SaveChangesAsync();
            
            scope.Complete();
        }
        catch
        {
            // Both rollback automatically
            throw;
        }
    }
}

// Supporting types
public class Order { public int Id { get; set; } public int CustomerId { get; set; } public decimal Total { get; set; } public DateTime CreatedDate { get; set; } public List<OrderItem> Items { get; set; } = new(); public int Stock { get; set; } }
public class OrderItem { public int Id { get; set; } public int ProductId { get; set; } public int Quantity { get; set; } }
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; public int Stock { get; set; } }
public class Customer { public int Id { get; set; } public string Name { get; set; } = ""; public int TotalOrders { get; set; } }
public class Account { public int Id { get; set; } public decimal Balance { get; set; } }
public class AuditLog { public int Id { get; set; } public string Action { get; set; } = ""; public int EntityId { get; set; } public DateTime Timestamp { get; set; } }
public class CreateOrderDto { public int CustomerId { get; set; } public decimal Total { get; set; } public List<OrderItemDto> Items { get; set; } = new(); }
public class OrderItemDto { public int ProductId { get; set; } public int Quantity { get; set; } }
public interface IRepository<T> where T : class { Task<T?> GetByIdAsync(int id); Task AddAsync(T entity); }
public class Repository<T> : IRepository<T> where T : class { private readonly AppDbContext _context; public Repository(AppDbContext context) => _context = context; public Task<T?> GetByIdAsync(int id) => _context.Set<T>().FindAsync(id).AsTask(); public Task AddAsync(T entity) { _context.Set<T>().Add(entity); return Task.CompletedTask; } }
public class AppDbContext : DbContext { public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } public DbSet<Order> Orders { get; set; } public DbSet<OrderItem> OrderItems { get; set; } public DbSet<Product> Products { get; set; } public DbSet<Customer> Customers { get; set; } public DbSet<Account> Accounts { get; set; } }
public class LoggingDbContext : DbContext { public LoggingDbContext(DbContextOptions<LoggingDbContext> options) : base(options) { } public DbSet<AuditLog> AuditLogs { get; set; } }
```

---

### Question 97: Explain feature flags/toggles. How to implement in .NET?

**Short Theory:**  
Feature flags enable/disable features at runtime without deployment. Types: **Release toggles** (gradual rollout), **Experiment toggles** (A/B testing), **Ops toggles** (circuit breaker), **Permission toggles** (role-based). Use Microsoft.FeatureManagement. Configure in appsettings.json or Azure App Configuration. Benefits: Dark launches, canary releases, kill switches, A/B testing.

**Why do we use it?**  
Deploy code but control feature activation. Roll out gradually—10% users, then 50%, then 100%. Quick rollback without redeployment—disable flag. A/B testing different implementations. Operations control—disable expensive features under load. Trunk-based development—incomplete features in production but disabled. Essential for continuous delivery and risk mitigation.

**Key Interview Points:**
- Enable/disable features at runtime
- Types: Release, experiment, ops, permission
- Microsoft.FeatureManagement library
- Gradual rollout and A/B testing
- Quick rollback without deployment
- Use with: Azure App Configuration, LaunchDarkly

**Coding Example:**
```csharp
// Install: Microsoft.FeatureManagement.AspNetCore

// Configuration in appsettings.json
/*
{
  "FeatureManagement": {
    "NewCheckoutFlow": true,
    "PremiumFeatures": false,
    "BetaFeatures": {
      "EnabledFor": [
        {
          "Name": "Percentage",
          "Parameters": {
            "Value": 50
          }
        }
      ]
    },
    "AdminDashboard": {
      "EnabledFor": [
        {
          "Name": "TargetingFilter",
          "Parameters": {
            "Audience": {
              "Users": ["admin@example.com"],
              "Groups": ["Admins"]
            }
          }
        }
      ]
    }
  }
}
*/

builder.Services.AddFeatureManagement();

// Use in controller
[ApiController]
[Route("api/[controller]")]
public class CheckoutController : ControllerBase
{
    private readonly IFeatureManager _featureManager;
    
    public CheckoutController(IFeatureManager featureManager) => _featureManager = featureManager;
    
    [HttpPost]
    public async Task<IActionResult> ProcessCheckout(CheckoutRequest request)
    {
        if (await _featureManager.IsEnabledAsync("NewCheckoutFlow"))
        {
            return Ok(new { Message = "Using new checkout flow" });
        }
        
        return Ok(new { Message = "Using legacy checkout flow" });
    }
    
    [HttpGet("premium")]
    [FeatureGate("PremiumFeatures")] // Auto 404 if disabled
    public IActionResult GetPremiumFeatures()
    {
        return Ok(new { Features = new[] { "Advanced Analytics", "Priority Support" } });
    }
}

// Use in Razor views
/*
@inject IFeatureManager FeatureManager

@if (await FeatureManager.IsEnabledAsync("NewUI"))
{
    <div>New UI Component</div>
}
else
{
    <div>Legacy UI Component</div>
}
*/

// Custom feature filter
public class EnvironmentFilter : IFeatureFilter
{
    private readonly IWebHostEnvironment _environment;
    
    public EnvironmentFilter(IWebHostEnvironment environment) => _environment = environment;
    
    public Task<bool> EvaluateAsync(FeatureFilterEvaluationContext context)
    {
        var settings = context.Parameters.Get<EnvironmentFilterSettings>();
        var allowed = settings?.AllowedEnvironments ?? Array.Empty<string>();
        
        var isEnabled = allowed.Contains(_environment.EnvironmentName, StringComparer.OrdinalIgnoreCase);
        return Task.FromResult(isEnabled);
    }
}

public class EnvironmentFilterSettings
{
    public string[] AllowedEnvironments { get; set; } = Array.Empty<string>();
}

// Register custom filter
builder.Services.AddFeatureManagement()
    .AddFeatureFilter<EnvironmentFilter>();

// Time window filter
public class TimeWindowFilter : IFeatureFilter
{
    public Task<bool> EvaluateAsync(FeatureFilterEvaluationContext context)
    {
        var settings = context.Parameters.Get<TimeWindowSettings>();
        var now = DateTime.UtcNow;
        
        var isEnabled = now >= settings.Start && now <= settings.End;
        return Task.FromResult(isEnabled);
    }
}

public class TimeWindowSettings
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}

// Configuration
/*
{
  "FeatureManagement": {
    "HolidaySale": {
      "EnabledFor": [
        {
          "Name": "TimeWindowFilter",
          "Parameters": {
            "Start": "2026-12-24T00:00:00Z",
            "End": "2026-12-26T23:59:59Z"
          }
        }
      ]
    }
  }
}
*/

// Service with feature flags
public class NotificationService
{
    private readonly IFeatureManager _featureManager;
    private readonly IEmailService _emailService;
    private readonly ISmsService _smsService;
    
    public NotificationService(IFeatureManager featureManager, IEmailService emailService, ISmsService smsService)
    {
        _featureManager = featureManager;
        _emailService = emailService;
        _smsService = smsService;
    }
    
    public async Task SendNotificationAsync(string userId, string message)
    {
        // Always send email
        await _emailService.SendAsync(userId, message);
        
        // Send SMS only if feature enabled
        if (await _featureManager.IsEnabledAsync("SmsNotifications"))
        {
            await _smsService.SendAsync(userId, message);
        }
    }
}

// A/B testing variant selection
public class VariantFeatureFilter : IFeatureFilter
{
    public Task<bool> EvaluateAsync(FeatureFilterEvaluationContext context)
    {
        var settings = context.Parameters.Get<VariantSettings>();
        var userId = context.Parameters.Get<string>("UserId");
        
        // Consistent hash-based assignment
        var hash = userId.GetHashCode();
        var variant = Math.Abs(hash % 100);
        
        var isEnabled = variant < settings.Percentage;
        return Task.FromResult(isEnabled);
    }
}

public class VariantSettings
{
    public int Percentage { get; set; }
}

// Dynamic feature management with Azure App Configuration
// Install: Microsoft.Azure.AppConfiguration.AspNetCore
builder.Configuration.AddAzureAppConfiguration(options =>
{
    options.Connect(connectionString)
        .UseFeatureFlags(featureFlags =>
        {
            featureFlags.CacheExpirationInterval = TimeSpan.FromMinutes(1);
        });
});

// Middleware to refresh feature flags
app.UseAzureAppConfiguration();

// Feature flag with variants (different implementations)
public class SearchService
{
    private readonly IFeatureManager _featureManager;
    
    public SearchService(IFeatureManager featureManager) => _featureManager = featureManager;
    
    public async Task<List<Product>> SearchAsync(string query)
    {
        if (await _featureManager.IsEnabledAsync("ElasticSearch"))
        {
            return await SearchWithElasticAsync(query);
        }
        
        return await SearchWithSqlAsync(query);
    }
    
    private Task<List<Product>> SearchWithElasticAsync(string query) => Task.FromResult(new List<Product>());
    private Task<List<Product>> SearchWithSqlAsync(string query) => Task.FromResult(new List<Product>());
}

// Circuit breaker with feature flag
public class ExternalApiService
{
    private readonly IFeatureManager _featureManager;
    private readonly HttpClient _httpClient;
    
    public ExternalApiService(IFeatureManager featureManager, HttpClient httpClient)
    {
        _featureManager = featureManager;
        _httpClient = httpClient;
    }
    
    public async Task<string> GetDataAsync()
    {
        // Check if API is disabled (circuit breaker)
        if (!await _featureManager.IsEnabledAsync("ExternalApiEnabled"))
        {
            return "Service temporarily unavailable"; // Fallback
        }
        
        return await _httpClient.GetStringAsync("https://api.example.com/data");
    }
}

// Supporting types
public class CheckoutRequest { public int UserId { get; set; } public List<int> Items { get; set; } = new(); }
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; }
public interface IEmailService { Task SendAsync(string userId, string message); }
public interface ISmsService { Task SendAsync(string userId, string message); }
```

---

### Question 98: Explain background tasks with IHostedService and BackgroundService. When to use each?

**Short Theory:**  
**IHostedService**: Interface for long-running background tasks in ASP.NET Core. Start with app, stop with app. **BackgroundService**: Abstract base class simplifying IHostedService. Override ExecuteAsync for main logic. Use for: Periodic jobs, message queue consumers, monitoring. For scheduled jobs, use Quartz.NET or Hangfire. BackgroundService runs on thread pool—avoid blocking operations.

**Why do we use it?**  
Need background processing without blocking HTTP requests. Examples: Send emails, process queues, cleanup old data, health monitoring. IHostedService for full control over startup/shutdown. BackgroundService for simple loop-based tasks. Essential for async operations, ETL jobs, data synchronization. Alternative to Windows Services for .NET Core.

**Key Interview Points:**
- IHostedService: Background tasks with app lifecycle
- BackgroundService: Simplified base class
- Use for: Periodic jobs, queue consumers
- Runs on thread pool (avoid blocking)
- Alternative: Quartz.NET, Hangfire for scheduling
- Graceful shutdown with CancellationToken

**Coding Example:**
```csharp
// Simple BackgroundService
public class EmailSenderService : BackgroundService
{
    private readonly ILogger<EmailSenderService> _logger;
    private readonly IServiceProvider _services;
    
    public EmailSenderService(ILogger<EmailSenderService> logger, IServiceProvider services)
    {
        _logger = logger;
        _services = services;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Email Sender Service started");
        
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _services.CreateScope();
                var emailQueue = scope.ServiceProvider.GetRequiredService<IEmailQueue>();
                
                var emails = await emailQueue.GetPendingAsync();
                
                foreach (var email in emails)
                {
                    await SendEmailAsync(email);
                    await emailQueue.MarkSentAsync(email.Id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing emails");
            }
            
            await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
        }
        
        _logger.LogInformation("Email Sender Service stopped");
    }
    
    private Task SendEmailAsync(Email email)
    {
        _logger.LogInformation("Sending email to {To}", email.To);
        return Task.CompletedTask;
    }
}

// Register
builder.Services.AddHostedService<EmailSenderService>();

// IHostedService for full control
public class DataCleanupService : IHostedService, IDisposable
{
    private Timer? _timer;
    private readonly ILogger<DataCleanupService> _logger;
    private readonly IServiceProvider _services;
    
    public DataCleanupService(ILogger<DataCleanupService> logger, IServiceProvider services)
    {
        _logger = logger;
        _services = services;
    }
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Data Cleanup Service starting");
        
        // Run every hour
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromHours(1));
        
        return Task.CompletedTask;
    }
    
    private void DoWork(object? state)
    {
        _logger.LogInformation("Running data cleanup");
        
        using var scope = _services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        
        // Delete old records
        var cutoffDate = DateTime.UtcNow.AddDays(-30);
        var oldLogs = context.Logs.Where(l => l.CreatedDate < cutoffDate);
        context.Logs.RemoveRange(oldLogs);
        context.SaveChanges();
        
        _logger.LogInformation("Data cleanup completed");
    }
    
    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Data Cleanup Service stopping");
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }
    
    public void Dispose()
    {
        _timer?.Dispose();
    }
}

// Queue consumer
public class OrderProcessorService : BackgroundService
{
    private readonly ILogger<OrderProcessorService> _logger;
    private readonly IServiceProvider _services;
    
    public OrderProcessorService(ILogger<OrderProcessorService> logger, IServiceProvider services)
    {
        _logger = logger;
        _services = services;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var order in GetOrdersAsync(stoppingToken))
        {
            await ProcessOrderAsync(order);
        }
    }
    
    private async IAsyncEnumerable<Order> GetOrdersAsync([EnumeratorCancellation] CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            using var scope = _services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            
            var orders = await context.Orders.Where(o => !o.Processed).Take(10).ToListAsync(cancellationToken);
            
            foreach (var order in orders)
            {
                yield return order;
            }
            
            if (!orders.Any())
            {
                await Task.Delay(1000, cancellationToken);
            }
        }
    }
    
    private async Task ProcessOrderAsync(Order order)
    {
        _logger.LogInformation("Processing order {OrderId}", order.Id);
        
        using var scope = _services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        
        order.Processed = true;
        order.ProcessedDate = DateTime.UtcNow;
        await context.SaveChangesAsync();
    }
}

// Timed background service
public class HealthCheckService : BackgroundService
{
    private readonly ILogger<HealthCheckService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    
    public HealthCheckService(ILogger<HealthCheckService> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var timer = new PeriodicTimer(TimeSpan.FromMinutes(5));
        
        while (!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken))
        {
            await CheckHealthAsync();
        }
    }
    
    private async Task CheckHealthAsync()
    {
        try
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://api.example.com/health");
            
            if (response.IsSuccessStatusCode)
            {
                _logger.LogInformation("Health check passed");
            }
            else
            {
                _logger.LogWarning("Health check failed: {StatusCode}", response.StatusCode);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Health check error");
        }
    }
}

// Channel-based background service
public class NotificationChannel
{
    private readonly Channel<Notification> _channel = Channel.CreateUnbounded<Notification>();
    
    public async Task WriteAsync(Notification notification) => await _channel.Writer.WriteAsync(notification);
    
    public IAsyncEnumerable<Notification> ReadAllAsync(CancellationToken cancellationToken = default) 
        => _channel.Reader.ReadAllAsync(cancellationToken);
}

public class NotificationProcessorService : BackgroundService
{
    private readonly NotificationChannel _channel;
    private readonly ILogger<NotificationProcessorService> _logger;
    
    public NotificationProcessorService(NotificationChannel channel, ILogger<NotificationProcessorService> logger)
    {
        _channel = channel;
        _logger = logger;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var notification in _channel.ReadAllAsync(stoppingToken))
        {
            _logger.LogInformation("Processing notification: {Message}", notification.Message);
            await Task.Delay(100, stoppingToken); // Simulate work
        }
    }
}

builder.Services.AddSingleton<NotificationChannel>();
builder.Services.AddHostedService<NotificationProcessorService>();

// Graceful shutdown example
public class GracefulShutdownService : BackgroundService
{
    private readonly ILogger<GracefulShutdownService> _logger;
    
    public GracefulShutdownService(ILogger<GracefulShutdownService> logger) => _logger = logger;
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await DoWorkAsync(stoppingToken);
                await Task.Delay(1000, stoppingToken);
            }
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("Service is stopping, completing current work");
        }
    }
    
    private async Task DoWorkAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Working...");
        await Task.Delay(500, cancellationToken);
    }
    
    public override async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Service stopping gracefully");
        await base.StopAsync(cancellationToken);
    }
}

// Supporting types
public class Email { public int Id { get; set; } public string To { get; set; } = ""; public string Subject { get; set; } = ""; }
public interface IEmailQueue { Task<List<Email>> GetPendingAsync(); Task MarkSentAsync(int id); }
public class Order { public int Id { get; set; } public bool Processed { get; set; } public DateTime? ProcessedDate { get; set; } }
public class Log { public int Id { get; set; } public DateTime CreatedDate { get; set; } }
public class Notification { public string Message { get; set; } = ""; }
public class AppDbContext : DbContext { public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } public DbSet<Order> Orders { get; set; } public DbSet<Log> Logs { get; set; } }
```

---

### Question 99: Explain message idempotency. How to implement in distributed systems?

**Short Theory:**  
Idempotency ensures processing same message multiple times has same effect as once. Critical for at-least-once delivery systems (RabbitMQ, Azure Service Bus). Implementation: Store processed message IDs, use unique request IDs, database constraints. HTTP: PUT/DELETE idempotent, POST not. Use idempotency keys for payment APIs. Prevents duplicate orders, double charges, inconsistent state.

**Why do we use it?**  
Message queues guarantee at-least-once delivery—messages may arrive multiple times. Network retries cause duplicate requests. Without idempotency: Duplicate orders, double charges, corrupted data. Essential for payment systems, financial transactions, e-commerce. Idempotency tokens track processed requests. Combined with Unit of Work for atomicity.

**Key Interview Points:**
- Same operation produces same result multiple times
- Essential for at-least-once delivery
- Implementation: Message ID tracking, unique constraints
- HTTP: PUT/DELETE idempotent, POST not
- Use idempotency keys for critical operations
- Prevents: Duplicate orders, double charges

**Coding Example:**
```csharp
// Idempotency middleware
public class IdempotencyMiddleware
{
    private readonly RequestDelegate _next;
    
    public IdempotencyMiddleware(RequestDelegate next) => _next = next;
    
    public async Task InvokeAsync(HttpContext context, IIdempotencyStore store)
    {
        // Only for POST requests
        if (context.Request.Method != "POST")
        {
            await _next(context);
            return;
        }
        
        // Get idempotency key from header
        if (!context.Request.Headers.TryGetValue("Idempotency-Key", out var key) || string.IsNullOrEmpty(key))
        {
            await _next(context);
            return;
        }
        
        // Check if already processed
        var cached = await store.GetAsync(key!);
        if (cached != null)
        {
            context.Response.StatusCode = cached.StatusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(cached.ResponseBody);
            return;
        }
        
        // Capture response
        var originalBody = context.Response.Body;
        using var memoryStream = new MemoryStream();
        context.Response.Body = memoryStream;
        
        await _next(context);
        
        // Store response
        memoryStream.Seek(0, SeekOrigin.Begin);
        var responseBody = await new StreamReader(memoryStream).ReadToEndAsync();
        
        await store.SetAsync(key!, new IdempotencyRecord
        {
            StatusCode = context.Response.StatusCode,
            ResponseBody = responseBody
        });
        
        // Write to original stream
        memoryStream.Seek(0, SeekOrigin.Begin);
        await memoryStream.CopyToAsync(originalBody);
        context.Response.Body = originalBody;
    }
}

// Idempotency store
public interface IIdempotencyStore
{
    Task<IdempotencyRecord?> GetAsync(string key);
    Task SetAsync(string key, IdempotencyRecord record);
}

public class IdempotencyRecord
{
    public int StatusCode { get; set; }
    public string ResponseBody { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public class RedisIdempotencyStore : IIdempotencyStore
{
    private readonly IDistributedCache _cache;
    
    public RedisIdempotencyStore(IDistributedCache cache) => _cache = cache;
    
    public async Task<IdempotencyRecord?> GetAsync(string key)
    {
        var json = await _cache.GetStringAsync(key);
        return json != null ? JsonSerializer.Deserialize<IdempotencyRecord>(json) : null;
    }
    
    public async Task SetAsync(string key, IdempotencyRecord record)
    {
        var json = JsonSerializer.Serialize(record);
        await _cache.SetStringAsync(key, json, new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(24)
        });
    }
}

builder.Services.AddSingleton<IIdempotencyStore, RedisIdempotencyStore>();
app.UseMiddleware<IdempotencyMiddleware>();

// Database-based idempotency
public class ProcessedMessage
{
    public string MessageId { get; set; } = "";
    public DateTime ProcessedAt { get; set; }
    public string Result { get; set; } = "";
}

public class OrderService
{
    private readonly AppDbContext _context;
    
    public OrderService(AppDbContext context) => _context = context;
    
    public async Task<int> ProcessOrderAsync(string messageId, CreateOrderRequest request)
    {
        // Check if already processed
        var processed = await _context.ProcessedMessages.FindAsync(messageId);
        if (processed != null)
        {
            return int.Parse(processed.Result);
        }
        
        using var transaction = await _context.Database.BeginTransactionAsync();
        
        try
        {
            // Create order
            var order = new Order { Total = request.Total };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            
            // Mark as processed
            _context.ProcessedMessages.Add(new ProcessedMessage
            {
                MessageId = messageId,
                ProcessedAt = DateTime.UtcNow,
                Result = order.Id.ToString()
            });
            await _context.SaveChangesAsync();
            
            await transaction.CommitAsync();
            return order.Id;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}

// Message handler with idempotency
public class OrderCreatedMessageHandler
{
    private readonly IServiceProvider _services;
    
    public OrderCreatedMessageHandler(IServiceProvider services) => _services = services;
    
    public async Task HandleAsync(OrderCreatedMessage message)
    {
        using var scope = _services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        
        // Idempotency check
        if (await context.ProcessedMessages.AnyAsync(m => m.MessageId == message.MessageId))
        {
            return; // Already processed
        }
        
        // Process message
        var order = new Order
        {
            CustomerId = message.CustomerId,
            Total = message.Total
        };
        
        context.Orders.Add(order);
        
        // Mark processed in same transaction
        context.ProcessedMessages.Add(new ProcessedMessage
        {
            MessageId = message.MessageId,
            ProcessedAt = DateTime.UtcNow
        });
        
        await context.SaveChangesAsync();
    }
}

// Payment API with idempotency key
[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    
    public PaymentsController(IPaymentService paymentService) => _paymentService = paymentService;
    
    [HttpPost]
    public async Task<IActionResult> ProcessPayment([FromHeader(Name = "Idempotency-Key")] string idempotencyKey, PaymentRequest request)
    {
        if (string.IsNullOrEmpty(idempotencyKey))
        {
            return BadRequest("Idempotency-Key header required");
        }
        
        var result = await _paymentService.ProcessAsync(idempotencyKey, request);
        return Ok(result);
    }
}

// Optimistic concurrency for idempotency
public class InventoryService
{
    private readonly AppDbContext _context;
    
    public InventoryService(AppDbContext context) => _context = context;
    
    public async Task<bool> ReserveStockAsync(int productId, int quantity, string requestId)
    {
        var maxRetries = 3;
        
        for (int i = 0; i < maxRetries; i++)
        {
            try
            {
                var product = await _context.Products.FindAsync(productId);
                if (product == null) return false;
                
                // Check if already reserved with this requestId
                var existing = await _context.Reservations.FirstOrDefaultAsync(r => r.RequestId == requestId);
                if (existing != null)
                {
                    return true; // Already reserved (idempotent)
                }
                
                // Reserve stock
                if (product.Stock < quantity) return false;
                
                product.Stock -= quantity;
                
                _context.Reservations.Add(new Reservation
                {
                    ProductId = productId,
                    Quantity = quantity,
                    RequestId = requestId,
                    CreatedAt = DateTime.UtcNow
                });
                
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                // Retry on concurrency conflict
                if (i == maxRetries - 1) throw;
            }
        }
        
        return false;
    }
}

// Supporting types
public class Order { public int Id { get; set; } public int CustomerId { get; set; } public decimal Total { get; set; } }
public class CreateOrderRequest { public decimal Total { get; set; } }
public class OrderCreatedMessage { public string MessageId { get; set; } = ""; public int CustomerId { get; set; } public decimal Total { get; set; } }
public class PaymentRequest { public decimal Amount { get; set; } }
public class Product { public int Id { get; set; } public int Stock { get; set; } }
public class Reservation { public int Id { get; set; } public int ProductId { get; set; } public int Quantity { get; set; } public string RequestId { get; set; } = ""; public DateTime CreatedAt { get; set; } }
public interface IPaymentService { Task<object> ProcessAsync(string idempotencyKey, PaymentRequest request); }
public class AppDbContext : DbContext 
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
    public DbSet<ProcessedMessage> ProcessedMessages { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}
```

---

### Question 100: Explain eventual consistency in distributed systems. How to handle in .NET?

**Short Theory:**  
Eventual consistency means data becomes consistent over time, not immediately. CAP theorem: Choose 2 of Consistency, Availability, Partition tolerance. Distributed systems often choose AP (available + partition-tolerant) over CP. Use: CQRS with separate read/write stores, event sourcing, message queues. Handle with: Retry logic, compensating transactions, saga pattern. Accept stale reads, prioritize availability.

**Why do we use it?**  
Strong consistency requires distributed locks—slow and reduces availability. Microservices can't share databases—eventual consistency via events. Read replicas lag behind master. Geographically distributed systems can't synchronize instantly. Trade-off: Better performance and availability for temporary inconsistency. Essential for: Scalable systems, high availability, global distribution.

**Key Interview Points:**
- Data consistent over time, not immediately
- CAP theorem: Choose 2 of C, A, P
- Use: CQRS, event sourcing, microservices
- Handle: Retry, compensating transactions, saga
- Accept stale reads for availability
- Essential for scalable distributed systems

**Coding Example:**
```csharp
// CQRS with eventual consistency
public class OrderCommandService
{
    private readonly AppDbContext _context;
    private readonly IMessageBus _messageBus;
    
    public OrderCommandService(AppDbContext context, IMessageBus messageBus)
    {
        _context = context;
        _messageBus = messageBus;
    }
    
    public async Task<int> CreateOrderAsync(CreateOrderCommand command)
    {
        // Write to command database
        var order = new Order
        {
            CustomerId = command.CustomerId,
            Total = command.Total,
            Status = "Pending"
        };
        
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        
        // Publish event for read model update (eventual consistency)
        await _messageBus.PublishAsync(new OrderCreatedEvent
        {
            OrderId = order.Id,
            CustomerId = command.CustomerId,
            Total = command.Total,
            CreatedAt = DateTime.UtcNow
        });
        
        return order.Id;
    }
}

// Read model (eventually consistent)
public class OrderQueryService
{
    private readonly ReadDbContext _readContext;
    
    public OrderQueryService(ReadDbContext readContext) => _readContext = readContext;
    
    public async Task<OrderReadModel?> GetOrderAsync(int id)
    {
        // May be stale if event not yet processed
        return await _readContext.Orders.FindAsync(id);
    }
}

// Event handler updates read model
public class OrderCreatedEventHandler
{
    private readonly ReadDbContext _readContext;
    
    public OrderCreatedEventHandler(ReadDbContext readContext) => _readContext = readContext;
    
    public async Task HandleAsync(OrderCreatedEvent @event)
    {
        // Update read model
        var readModel = new OrderReadModel
        {
            OrderId = @event.OrderId,
            CustomerId = @event.CustomerId,
            Total = @event.Total,
            Status = "Pending",
            CreatedAt = @event.CreatedAt
        };
        
        _readContext.Orders.Add(readModel);
        await _readContext.SaveChangesAsync();
    }
}

// Retry with exponential backoff
public class RetryService
{
    public async Task<T> ExecuteWithRetryAsync<T>(Func<Task<T>> operation, int maxRetries = 3)
    {
        int retryCount = 0;
        
        while (true)
        {
            try
            {
                return await operation();
            }
            catch (Exception ex)
            {
                retryCount++;
                
                if (retryCount >= maxRetries)
                    throw;
                
                var delay = TimeSpan.FromSeconds(Math.Pow(2, retryCount));
                await Task.Delay(delay);
            }
        }
    }
}

// Compensating transaction (saga pattern)
public class OrderSagaOrchestrator
{
    private readonly IServiceProvider _services;
    
    public OrderSagaOrchestrator(IServiceProvider services) => _services = services;
    
    public async Task<bool> ProcessOrderAsync(CreateOrderCommand command)
    {
        var compensations = new Stack<Func<Task>>();
        
        try
        {
            // Step 1: Reserve inventory
            using var scope1 = _services.CreateScope();
            var inventory = scope1.ServiceProvider.GetRequiredService<IInventoryService>();
            await inventory.ReserveAsync(command.Items);
            compensations.Push(async () => await inventory.ReleaseAsync(command.Items));
            
            // Step 2: Process payment
            using var scope2 = _services.CreateScope();
            var payment = scope2.ServiceProvider.GetRequiredService<IPaymentService>();
            await payment.ChargeAsync(command.Total);
            compensations.Push(async () => await payment.RefundAsync(command.Total));
            
            // Step 3: Create order
            using var scope3 = _services.CreateScope();
            var orderService = scope3.ServiceProvider.GetRequiredService<OrderCommandService>();
            await orderService.CreateOrderAsync(command);
            
            return true;
        }
        catch
        {
            // Execute compensating transactions in reverse
            while (compensations.Any())
            {
                var compensate = compensations.Pop();
                try
                {
                    await compensate();
                }
                catch (Exception ex)
                {
                    // Log compensation failure
                    Console.WriteLine($"Compensation failed: {ex.Message}");
                }
            }
            
            return false;
        }
    }
}

// Version vector for conflict resolution
public class VersionVector
{
    private readonly Dictionary<string, int> _versions = new();
    
    public void Increment(string nodeId)
    {
        _versions[nodeId] = _versions.GetValueOrDefault(nodeId) + 1;
    }
    
    public bool HappensBefore(VersionVector other)
    {
        var allLessOrEqual = _versions.All(kv => kv.Value <= other._versions.GetValueOrDefault(kv.Key));
        var anyLess = _versions.Any(kv => kv.Value < other._versions.GetValueOrDefault(kv.Key));
        
        return allLessOrEqual && anyLess;
    }
    
    public bool IsConcurrent(VersionVector other)
    {
        return !HappensBefore(other) && !other.HappensBefore(this);
    }
}

// Conflict-free replicated data type (CRDT) - Counter
public class GCounter
{
    private readonly Dictionary<string, int> _counts = new();
    private readonly string _nodeId;
    
    public GCounter(string nodeId) => _nodeId = nodeId;
    
    public void Increment()
    {
        _counts[_nodeId] = _counts.GetValueOrDefault(_nodeId) + 1;
    }
    
    public int Value => _counts.Values.Sum();
    
    public void Merge(GCounter other)
    {
        foreach (var (nodeId, count) in other._counts)
        {
            _counts[nodeId] = Math.Max(_counts.GetValueOrDefault(nodeId), count);
        }
    }
}

// Optimistic UI updates (accept eventual consistency)
public class ProductService
{
    private readonly IDistributedCache _cache;
    private readonly AppDbContext _context;
    
    public ProductService(IDistributedCache cache, AppDbContext context)
    {
        _cache = cache;
        _context = context;
    }
    
    public async Task<Product?> GetProductAsync(int id)
    {
        // Try cache first (may be stale)
        var cacheKey = $"product_{id}";
        var cached = await _cache.GetStringAsync(cacheKey);
        
        if (cached != null)
        {
            return JsonSerializer.Deserialize<Product>(cached);
        }
        
        // Cache miss - get from database
        var product = await _context.Products.FindAsync(id);
        
        if (product != null)
        {
            // Cache with short TTL to balance consistency and performance
            await _cache.SetStringAsync(cacheKey, JsonSerializer.Serialize(product), new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1)
            });
        }
        
        return product;
    }
    
    public async Task UpdateProductAsync(Product product)
    {
        // Update database
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        
        // Invalidate cache (eventual consistency)
        await _cache.RemoveAsync($"product_{product.Id}");
        
        // Publish event for other services
        // Other caches will eventually be consistent
    }
}

// Detect and resolve conflicts
public class ConflictResolver
{
    public Product ResolveConflict(Product local, Product remote)
    {
        // Last-write-wins strategy
        if (remote.LastModified > local.LastModified)
        {
            return remote;
        }
        
        return local;
    }
    
    public Product MergeConflict(Product local, Product remote)
    {
        // Custom merge logic
        return new Product
        {
            Id = local.Id,
            Name = remote.LastModified > local.LastModified ? remote.Name : local.Name,
            Price = Math.Max(local.Price, remote.Price), // Take higher price
            LastModified = DateTime.UtcNow
        };
    }
}

// Supporting types
public class Order { public int Id { get; set; } public int CustomerId { get; set; } public decimal Total { get; set; } public string Status { get; set; } = ""; }
public class CreateOrderCommand { public int CustomerId { get; set; } public decimal Total { get; set; } public List<OrderItemDto> Items { get; set; } = new(); }
public class OrderItemDto { public int ProductId { get; set; } public int Quantity { get; set; } }
public class OrderCreatedEvent { public int OrderId { get; set; } public int CustomerId { get; set; } public decimal Total { get; set; } public DateTime CreatedAt { get; set; } }
public class OrderReadModel { public int OrderId { get; set; } public int CustomerId { get; set; } public decimal Total { get; set; } public string Status { get; set; } = ""; public DateTime CreatedAt { get; set; } }
public class Product { public int Id { get; set; } public string Name { get; set; } = ""; public decimal Price { get; set; } public DateTime LastModified { get; set; } }
public interface IMessageBus { Task PublishAsync<T>(T message); }
public interface IInventoryService { Task ReserveAsync(List<OrderItemDto> items); Task ReleaseAsync(List<OrderItemDto> items); }
public interface IPaymentService { Task ChargeAsync(decimal amount); Task RefundAsync(decimal amount); Task<object> ProcessAsync(string idempotencyKey, object request); }
public class AppDbContext : DbContext { public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } public DbSet<Order> Orders { get; set; } public DbSet<Product> Products { get; set; } }
public class ReadDbContext : DbContext { public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options) { } public DbSet<OrderReadModel> Orders { get; set; } }
```

---

## 🎉 Congratulations! All 100 Questions Completed! 🎉

This comprehensive C# interview preparation guide covers:

### Core Topics:
- **Fundamentals**: CLR, Memory Management, Async/Await, LINQ, Delegates, Events
- **OOP & SOLID**: Principles, Design Patterns (23 patterns covered)
- **Advanced C#**: Generics, Reflection, Expression Trees, Pattern Matching, Records, Nullable References

### Framework & Architecture:
- **ASP.NET Core**: Middleware, DI, Configuration, Minimal APIs, Blazor
- **EF Core**: Migrations, Query Optimization, Change Tracking, Connection Pooling
- **Architecture**: Clean Architecture, DDD, CQRS, Event Sourcing, Microservices

### Patterns & Practices:
- **Creational**: Singleton, Factory, Builder, Prototype
- **Structural**: Adapter, Decorator, Proxy, Facade
- **Behavioral**: Strategy, Observer, Template Method, Mediator, Specification

### Enterprise Features:
- **Resilience**: Polly, Circuit Breaker, Retry, Health Checks
- **Caching**: IMemoryCache, IDistributedCache, Redis, Hybrid Caching
- **Messaging**: RabbitMQ, Azure Service Bus, Message Queues, Outbox Pattern
- **Security**: JWT, OAuth 2.0, Authorization, Rate Limiting
- **Performance**: BenchmarkDotNet, ValueTask, Channels, Source Generators

### Distributed Systems:
- **Patterns**: Saga, Outbox, Idempotency, Unit of Work
- **Consistency**: Eventual Consistency, CQRS, Event Sourcing
- **Integration**: gRPC, GraphQL, SignalR, REST APIs, Versioning
- **Cloud**: Docker, Kubernetes, Azure Services, Application Insights

### Modern .NET:
- **C# 10+**: Records, Init-only, Pattern Matching, Global Usings
- **Background Tasks**: IHostedService, BackgroundService, Channels
- **Testing**: Unit Testing, Integration Testing, TDD
- **Monitoring**: Serilog, Application Insights, Structured Logging

**Perfect preparation for Senior/Principal Software Engineer interviews!**

Good luck with your interviews! 🚀