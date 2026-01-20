# C# / .NET Core – Interview Coding Questions (Part 2)

## Continued from Part 1...

### EF Core - Writing optimized LINQ queries

**Problem:** Write efficient LINQ queries and avoid common performance pitfalls.

**Solution:**

```csharp
public class OptimizedLinqQueries
{
    private readonly AppDbContext _context;
    
    public OptimizedLinqQueries(AppDbContext context)
    {
        _context = context;
    }
    
    // ? BAD: Loading everything into memory then filtering
    public List<Customer> BadQuery()
    {
        var allCustomers = _context.Customers.ToList(); // Loads ALL customers!
        return allCustomers.Where(c => c.IsActive).ToList();
    }
    
    // ? GOOD: Filter at database level
    public async Task<List<Customer>> GoodQuery()
    {
        return await _context.Customers
            .Where(c => c.IsActive)
            .ToListAsync();
    }
    
    // ? BAD: Multiple database calls in a loop
    public async Task<List<OrderSummary>> BadLoopQuery()
    {
        var customers = await _context.Customers.ToListAsync();
        var summaries = new List<OrderSummary>();
        
        foreach (var customer in customers) // N+1 problem!
        {
            var orderCount = await _context.Orders
                .Where(o => o.CustomerId == customer.CustomerId)
                .CountAsync(); // Separate query for each customer
            
            summaries.Add(new OrderSummary
            {
                CustomerId = customer.CustomerId,
                OrderCount = orderCount
            });
        }
        
        return summaries;
    }
    
    // ? GOOD: Single query with grouping
    public async Task<List<OrderSummary>> GoodGroupQuery()
    {
        return await _context.Customers
            .Select(c => new OrderSummary
            {
                CustomerId = c.CustomerId,
                OrderCount = c.Orders.Count()
            })
            .ToListAsync();
    }
    
    // ? BAD: Using Contains with large collection
    public async Task<List<Product>> BadContains()
    {
        var productIds = Enumerable.Range(1, 10000).ToList();
        return await _context.Products
            .Where(p => productIds.Contains(p.ProductId)) // Massive IN clause
            .ToListAsync();
    }
    
    // ? GOOD: Batch the query
    public async Task<List<Product>> GoodBatchQuery()
    {
        var productIds = Enumerable.Range(1, 10000).ToList();
        const int batchSize = 1000;
        var results = new List<Product>();
        
        for (int i = 0; i < productIds.Count; i += batchSize)
        {
            var batch = productIds.Skip(i).Take(batchSize);
            var products = await _context.Products
                .Where(p => batch.Contains(p.ProductId))
                .ToListAsync();
            results.AddRange(products);
        }
        
        return results;
    }
    
    // ? BAD: Unnecessary sorting in memory
    public List<Customer> BadSort()
    {
        return _context.Customers
            .ToList() // Loads all into memory
            .OrderBy(c => c.Name) // Sorts in memory
            .ToList();
    }
    
    // ? GOOD: Sort at database level
    public async Task<List<Customer>> GoodSort()
    {
        return await _context.Customers
            .OrderBy(c => c.Name) // Database sorts
            .ToListAsync();
    }
    
    // ? BAD: Inefficient pagination
    public List<Product> BadPagination(int page, int pageSize)
    {
        return _context.Products
            .ToList() // Loads ALL products
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }
    
    // ? GOOD: Efficient pagination
    public async Task<List<Product>> GoodPagination(int page, int pageSize)
    {
        return await _context.Products
            .OrderBy(p => p.ProductId)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
    
    // ? GOOD: Using AsNoTracking for read-only queries
    public async Task<List<Customer>> ReadOnlyQuery()
    {
        return await _context.Customers
            .AsNoTracking() // Faster for read-only scenarios
            .Where(c => c.IsActive)
            .ToListAsync();
    }
    
    // ? GOOD: Compiled queries for frequently used queries
    private static readonly Func<AppDbContext, int, Task<Customer>> GetCustomerById =
        EF.CompileAsyncQuery((AppDbContext context, int id) =>
            context.Customers
                .Include(c => c.Orders)
                .FirstOrDefault(c => c.CustomerId == id));
    
    public async Task<Customer> GetCustomerOptimized(int id)
    {
        return await GetCustomerById(_context, id);
    }
}

public class OrderSummary
{
    public int CustomerId { get; set; }
    public int OrderCount { get; set; }
}
```

---

### Handling N+1 Problem

**Problem:** Identify and fix the N+1 query problem.

**Solution:**

```csharp
public class N1ProblemSolutions
{
    private readonly AppDbContext _context;
    
    public N1ProblemSolutions(AppDbContext context)
    {
        _context = context;
    }
    
    // ? N+1 PROBLEM EXAMPLE
    public async Task<List<CustomerWithOrdersDto>> N1Problem()
    {
        // Query 1: Get all customers
        var customers = await _context.Customers.ToListAsync();
        
        var result = new List<CustomerWithOrdersDto>();
        
        // N queries: One for each customer's orders
        foreach (var customer in customers)
        {
            var orders = await _context.Orders
                .Where(o => o.CustomerId == customer.CustomerId)
                .ToListAsync(); // SEPARATE QUERY!
            
            result.Add(new CustomerWithOrdersDto
            {
                CustomerName = customer.Name,
                Orders = orders
            });
        }
        
        // Total: 1 + N queries (if 100 customers = 101 queries!)
        return result;
    }
    
    // ? SOLUTION 1: Eager Loading with Include
    public async Task<List<CustomerWithOrdersDto>> Solution1_EagerLoading()
    {
        // Single query with JOIN
        return await _context.Customers
            .Include(c => c.Orders) // Include related data
            .Select(c => new CustomerWithOrdersDto
            {
                CustomerName = c.Name,
                Orders = c.Orders.ToList()
            })
            .ToListAsync();
        
        // Total: 1 query
    }
    
    // ? SOLUTION 2: Projection
    public async Task<List<CustomerWithOrderCountDto>> Solution2_Projection()
    {
        return await _context.Customers
            .Select(c => new CustomerWithOrderCountDto
            {
                CustomerName = c.Name,
                OrderCount = c.Orders.Count(), // Executed in SQL
                TotalAmount = c.Orders.Sum(o => o.TotalAmount)
            })
            .ToListAsync();
        
        // Total: 1 query with aggregation
    }
    
    // ? SOLUTION 3: Split Query (for large datasets)
    public async Task<List<CustomerWithOrdersDto>> Solution3_SplitQuery()
    {
        return await _context.Customers
            .Include(c => c.Orders)
            .AsSplitQuery() // Splits into separate queries
            .Select(c => new CustomerWithOrdersDto
            {
                CustomerName = c.Name,
                Orders = c.Orders.ToList()
            })
            .ToListAsync();
        
        // Total: 2 queries (better than N+1)
        // Query 1: SELECT * FROM Customers
        // Query 2: SELECT * FROM Orders WHERE CustomerId IN (...)
    }
    
    // ? SOLUTION 4: Batch Loading
    public async Task<List<CustomerWithOrdersDto>> Solution4_BatchLoading()
    {
        // Load customers
        var customers = await _context.Customers.ToListAsync();
        var customerIds = customers.Select(c => c.CustomerId).ToList();
        
        // Load all orders in one query
        var orders = await _context.Orders
            .Where(o => customerIds.Contains(o.CustomerId))
            .ToListAsync();
        
        // Group in memory
        var ordersLookup = orders.ToLookup(o => o.CustomerId);
        
        return customers.Select(c => new CustomerWithOrdersDto
        {
            CustomerName = c.Name,
            Orders = ordersLookup[c.CustomerId].ToList()
        }).ToList();
        
        // Total: 2 queries
    }
    
    // ? NESTED N+1 PROBLEM
    public async Task<List<CustomerOrderProductDto>> NestedN1Problem()
    {
        var customers = await _context.Customers.ToListAsync(); // Query 1
        
        var result = new List<CustomerOrderProductDto>();
        
        foreach (var customer in customers) // N queries
        {
            var orders = await _context.Orders
                .Where(o => o.CustomerId == customer.CustomerId)
                .ToListAsync();
            
            foreach (var order in orders) // N * M queries
            {
                var products = await _context.OrderItems
                    .Where(oi => oi.OrderId == order.OrderId)
                    .Include(oi => oi.Product)
                    .ToListAsync();
                
                // Process...
            }
        }
        
        return result;
        // Total: 1 + N + (N * M) queries!
    }
    
    // ? SOLUTION: Deep Include
    public async Task<List<CustomerOrderProductDto>> SolutionDeepInclude()
    {
        return await _context.Customers
            .Include(c => c.Orders)
                .ThenInclude(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
            .Select(c => new CustomerOrderProductDto
            {
                CustomerName = c.Name,
                Orders = c.Orders.Select(o => new OrderWithProductsDto
                {
                    OrderId = o.OrderId,
                    Products = o.OrderItems.Select(oi => oi.Product.ProductName).ToList()
                }).ToList()
            })
            .ToListAsync();
        
        // Total: 1 query with multiple JOINs
    }
}

public class CustomerWithOrdersDto
{
    public string CustomerName { get; set; }
    public List<Order> Orders { get; set; }
}

public class CustomerWithOrderCountDto
{
    public string CustomerName { get; set; }
    public int OrderCount { get; set; }
    public decimal TotalAmount { get; set; }
}

public class CustomerOrderProductDto
{
    public string CustomerName { get; set; }
    public List<OrderWithProductsDto> Orders { get; set; }
}

public class OrderWithProductsDto
{
    public int OrderId { get; set; }
    public List<string> Products { get; set; }
}
```

---

## ?? Microservices & Distributed Systems

### Implement Retry with Polly

**Problem:** Implement retry logic with Polly for resilient HTTP calls.

**Solution:**

```csharp
// Install: Install-Package Polly
// Install: Install-Package Microsoft.Extensions.Http.Polly

public class PollyRetryExamples
{
    // 1. SIMPLE RETRY
    public async Task<string> SimpleRetry()
    {
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .RetryAsync(3); // Retry 3 times
        
        return await retryPolicy.ExecuteAsync(async () =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.example.com/data");
        });
    }
    
    // 2. RETRY WITH WAIT (Exponential Backoff)
    public async Task<string> RetryWithExponentialBackoff()
    {
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(
                retryCount: 3,
                sleepDurationProvider: retryAttempt => 
                    TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), // 2, 4, 8 seconds
                onRetry: (exception, timeSpan, retryCount, context) =>
                {
                    Console.WriteLine($"Retry {retryCount} after {timeSpan.TotalSeconds}s due to: {exception.Message}");
                });
        
        return await retryPolicy.ExecuteAsync(async () =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.example.com/data");
        });
    }
    
    // 3. RETRY SPECIFIC HTTP STATUS CODES
    public async Task<HttpResponseMessage> RetrySpecificStatuses()
    {
        var retryPolicy = Policy
            .HandleResult<HttpResponseMessage>(r => 
                !r.IsSuccessStatusCode && 
                (r.StatusCode == System.Net.HttpStatusCode.RequestTimeout ||
                 r.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable))
            .WaitAndRetryAsync(
                retryCount: 3,
                sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(retryAttempt * 2));
        
        return await retryPolicy.ExecuteAsync(async () =>
        {
            using var client = new HttpClient();
            return await client.GetAsync("https://api.example.com/data");
        });
    }
    
    // 4. RETRY WITH JITTER (Avoid thundering herd)
    public async Task<string> RetryWithJitter()
    {
        var jitterer = new Random();
        
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(
                retryCount: 5,
                sleepDurationProvider: retryAttempt =>
                {
                    var exponentialBackoff = TimeSpan.FromSeconds(Math.Pow(2, retryAttempt));
                    var jitter = TimeSpan.FromMilliseconds(jitterer.Next(0, 1000));
                    return exponentialBackoff + jitter;
                });
        
        return await retryPolicy.ExecuteAsync(async () =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.example.com/data");
        });
    }
    
    // 5. CONFIGURE WITH HTTPCLIENTFACTORY
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient("RetryClient")
                .AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy());
        }
        
        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .OrResult(r => !r.IsSuccessStatusCode)
                .WaitAndRetryAsync(
                    retryCount: 3,
                    sleepDurationProvider: retryAttempt => 
                        TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                    onRetry: (outcome, timespan, retryCount, context) =>
                    {
                        Console.WriteLine($"Retry {retryCount} after {timespan.TotalSeconds}s");
                    });
        }
        
        private static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .OrResult(r => !r.IsSuccessStatusCode)
                .CircuitBreakerAsync(
                    handledEventsAllowedBeforeBreaking: 3,
                    durationOfBreak: TimeSpan.FromSeconds(30));
        }
    }
    
    // 6. USING HTTPCLIENT WITH POLLY
    public class ApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        
        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<string> GetDataWithRetry()
        {
            var client = _httpClientFactory.CreateClient("RetryClient");
            var response = await client.GetAsync("https://api.example.com/data");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
    
    // 7. FALLBACK POLICY
    public async Task<string> RetryWithFallback()
    {
        var fallbackPolicy = Policy<string>
            .Handle<HttpRequestException>()
            .FallbackAsync("Default fallback value");
        
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(retryAttempt));
        
        var policyWrap = Policy.WrapAsync(fallbackPolicy, retryPolicy);
        
        return await policyWrap.ExecuteAsync(async () =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.example.com/data");
        });
    }
    
    // 8. TIMEOUT POLICY
    public async Task<string> RetryWithTimeout()
    {
        var timeoutPolicy = Policy.TimeoutAsync<string>(
            TimeSpan.FromSeconds(10),
            Polly.Timeout.TimeoutStrategy.Pessimistic);
        
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .Or<TimeoutRejectedException>()
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(retryAttempt));
        
        var policyWrap = Policy.WrapAsync(retryPolicy, timeoutPolicy);
        
        return await policyWrap.ExecuteAsync(async () =>
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.example.com/data");
        });
    }
}
```

---

### Circuit Breaker Pattern

**Problem:** Implement Circuit Breaker pattern to prevent cascading failures.

**Solution:**

```csharp
public class CircuitBreakerExamples
{
    // 1. BASIC CIRCUIT BREAKER
    public class BasicCircuitBreaker
    {
        private readonly IAsyncPolicy<HttpResponseMessage> _circuitBreakerPolicy;
        
        public BasicCircuitBreaker()
        {
            _circuitBreakerPolicy = Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .OrResult(r => !r.IsSuccessStatusCode)
                .CircuitBreakerAsync(
                    handledEventsAllowedBeforeBreaking: 3, // Open circuit after 3 failures
                    durationOfBreak: TimeSpan.FromSeconds(30), // Stay open for 30 seconds
                    onBreak: (result, duration) =>
                    {
                        Console.WriteLine($"Circuit opened for {duration.TotalSeconds}s");
                    },
                    onReset: () =>
                    {
                        Console.WriteLine("Circuit reset");
                    },
                    onHalfOpen: () =>
                    {
                        Console.WriteLine("Circuit half-open, testing...");
                    });
        }
        
        public async Task<string> CallApiAsync()
        {
            try
            {
                var response = await _circuitBreakerPolicy.ExecuteAsync(async () =>
                {
                    using var client = new HttpClient();
                    return await client.GetAsync("https://api.example.com/data");
                });
                
                return await response.Content.ReadAsStringAsync();
            }
            catch (BrokenCircuitException)
            {
                Console.WriteLine("Circuit is open, request rejected");
                return "Service temporarily unavailable";
            }
        }
    }
    
    // 2. ADVANCED CIRCUIT BREAKER
    public class AdvancedCircuitBreaker
    {
        private readonly IAsyncPolicy<HttpResponseMessage> _policy;
        
        public AdvancedCircuitBreaker()
        {
            _policy = Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .Or<TaskCanceledException>()
                .OrResult(r => 
                    r.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable ||
                    r.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                .AdvancedCircuitBreakerAsync(
                    failureThreshold: 0.5, // Break if 50% of requests fail
                    samplingDuration: TimeSpan.FromSeconds(10), // Over 10 second window
                    minimumThroughput: 10, // Minimum 10 requests in window
                    durationOfBreak: TimeSpan.FromSeconds(30),
                    onBreak: (result, duration, context) =>
                    {
                        Console.WriteLine($"Circuit broken for {duration.TotalSeconds}s");
                    },
                    onReset: context =>
                    {
                        Console.WriteLine("Circuit closed");
                    },
                    onHalfOpen: () =>
                    {
                        Console.WriteLine("Circuit testing");
                    });
        }
        
        public async Task<string> ExecuteAsync()
        {
            var response = await _policy.ExecuteAsync(async () =>
            {
                using var client = new HttpClient();
                return await client.GetAsync("https://api.example.com/data");
            });
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
    
    // 3. CIRCUIT BREAKER WITH RETRY AND FALLBACK
    public class ResilientService
    {
        private readonly IAsyncPolicy<string> _resiliencePolicy;
        
        public ResilientService()
        {
            // Fallback policy
            var fallbackPolicy = Policy<string>
                .Handle<BrokenCircuitException>()
                .Or<HttpRequestException>()
                .FallbackAsync("Cached or default response");
            
            // Circuit breaker
            var circuitBreakerPolicy = Policy<string>
                .Handle<HttpRequestException>()
                .CircuitBreakerAsync(
                    handledEventsAllowedBeforeBreaking: 3,
                    durationOfBreak: TimeSpan.FromSeconds(30));
            
            // Retry policy
            var retryPolicy = Policy<string>
                .Handle<HttpRequestException>()
                .WaitAndRetryAsync(2, retryAttempt => 
                    TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
            
            // Combine policies (execution order: fallback -> circuit breaker -> retry)
            _resiliencePolicy = Policy.WrapAsync(
                fallbackPolicy,
                circuitBreakerPolicy,
                retryPolicy);
        }
        
        public async Task<string> GetDataAsync()
        {
            return await _resiliencePolicy.ExecuteAsync(async () =>
            {
                using var client = new HttpClient();
                var response = await client.GetAsync("https://api.example.com/data");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            });
        }
    }
    
    // 4. REGISTER WITH DEPENDENCY INJECTION
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICircuitBreakerStateStore, InMemoryCircuitBreakerStateStore>();
            
            services.AddHttpClient("ResilientApi")
                .AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy())
                .AddPolicyHandler(GetTimeoutPolicy());
        }
        
        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .OrResult(r => !r.IsSuccessStatusCode)
                .WaitAndRetryAsync(
                    retryCount: 3,
                    sleepDurationProvider: retryAttempt => 
                        TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }
        
        private static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .OrResult(r => !r.IsSuccessStatusCode)
                .AdvancedCircuitBreakerAsync(
                    failureThreshold: 0.5,
                    samplingDuration: TimeSpan.FromSeconds(10),
                    minimumThroughput: 8,
                    durationOfBreak: TimeSpan.FromSeconds(30));
        }
        
        private static IAsyncPolicy<HttpResponseMessage> GetTimeoutPolicy()
        {
            return Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(10));
        }
    }
    
    // 5. MONITORING CIRCUIT STATE
    public class CircuitBreakerMonitor
    {
        private CircuitState _circuitState = CircuitState.Closed;
        
        public IAsyncPolicy<HttpResponseMessage> CreateMonitoredPolicy()
        {
            return Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .CircuitBreakerAsync(
                    handledEventsAllowedBeforeBreaking: 3,
                    durationOfBreak: TimeSpan.FromSeconds(30),
                    onBreak: (result, duration) =>
                    {
                        _circuitState = CircuitState.Open;
                        Console.WriteLine($"Circuit OPEN - Duration: {duration}");
                        // Send alert, log metric, etc.
                    },
                    onReset: () =>
                    {
                        _circuitState = CircuitState.Closed;
                        Console.WriteLine("Circuit CLOSED");
                    },
                    onHalfOpen: () =>
                    {
                        _circuitState = CircuitState.HalfOpen;
                        Console.WriteLine("Circuit HALF-OPEN");
                    });
        }
        
        public CircuitState GetCircuitState() => _circuitState;
    }
    
    public enum CircuitState
    {
        Closed,
        Open,
        HalfOpen
    }
}
```

---

### Saga Pattern Flow

**Problem:** Implement Saga pattern for distributed transactions.

**Solution:**

```csharp
// SAGA PATTERN - Choreography-based (Event-driven)

public class OrderSaga
{
    // 1. SAGA ORCHESTRATOR
    public class OrderSagaOrchestrator
    {
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly IInventoryService _inventoryService;
        private readonly IShippingService _shippingService;
        
        public OrderSagaOrchestrator(
            IOrderService orderService,
            IPaymentService paymentService,
            IInventoryService inventoryService,
            IShippingService shippingService)
        {
            _orderService = orderService;
            _paymentService = paymentService;
            _inventoryService = inventoryService;
            _shippingService = shippingService;
        }
        
        public async Task<OrderResult> ProcessOrderAsync(CreateOrderCommand command)
        {
            var sagaContext = new SagaContext
            {
                OrderId = Guid.NewGuid(),
                CustomerId = command.CustomerId,
                Items = command.Items
            };
            
            try
            {
                // Step 1: Create order
                await _orderService.CreateOrderAsync(sagaContext);
                sagaContext.CompletedSteps.Add("OrderCreated");
                
                // Step 2: Reserve inventory
                await _inventoryService.ReserveInventoryAsync(sagaContext);
                sagaContext.CompletedSteps.Add("InventoryReserved");
                
                // Step 3: Process payment
                await _paymentService.ProcessPaymentAsync(sagaContext);
                sagaContext.CompletedSteps.Add("PaymentProcessed");
                
                // Step 4: Arrange shipping
                await _shippingService.ArrangeShippingAsync(sagaContext);
                sagaContext.CompletedSteps.Add("ShippingArranged");
                
                // Success - confirm order
                await _orderService.ConfirmOrderAsync(sagaContext.OrderId);
                
                return OrderResult.Success(sagaContext.OrderId);
            }
            catch (Exception ex)
            {
                // Failure - execute compensating transactions
                await CompensateAsync(sagaContext);
                
                return OrderResult.Failure(ex.Message);
            }
        }
        
        private async Task CompensateAsync(SagaContext context)
        {
            // Execute compensating transactions in reverse order
            if (context.CompletedSteps.Contains("ShippingArranged"))
            {
                await _shippingService.CancelShippingAsync(context.OrderId);
            }
            
            if (context.CompletedSteps.Contains("PaymentProcessed"))
            {
                await _paymentService.RefundPaymentAsync(context.OrderId);
            }
            
            if (context.CompletedSteps.Contains("InventoryReserved"))
            {
                await _inventoryService.ReleaseInventoryAsync(context.OrderId);
            }
            
            if (context.CompletedSteps.Contains("OrderCreated"))
            {
                await _orderService.CancelOrderAsync(context.OrderId);
            }
        }
    }
    
    // 2. SAGA CONTEXT
    public class SagaContext
    {
        public Guid OrderId { get; set; }
        public string CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
        public List<string> CompletedSteps { get; set; } = new();
        public Dictionary<string, object> Data { get; set; } = new();
    }
    
    // 3. EVENT-DRIVEN SAGA (Choreography)
    public class OrderCreatedEvent
    {
        public Guid OrderId { get; set; }
        public string CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
    }
    
    public class OrderCreatedEventHandler : IEventHandler<OrderCreatedEvent>
    {
        private readonly IInventoryService _inventoryService;
        private readonly IEventBus _eventBus;
        
        public OrderCreatedEventHandler(IInventoryService inventoryService, IEventBus eventBus)
        {
            _inventoryService = inventoryService;
            _eventBus = eventBus;
        }
        
        public async Task HandleAsync(OrderCreatedEvent @event)
        {
            try
            {
                // Reserve inventory
                await _inventoryService.ReserveInventoryAsync(@event.OrderId, @event.Items);
                
                // Publish success event
                await _eventBus.PublishAsync(new InventoryReservedEvent
                {
                    OrderId = @event.OrderId,
                    Items = @event.Items
                });
            }
            catch
            {
                // Publish failure event
                await _eventBus.PublishAsync(new InventoryReservationFailedEvent
                {
                    OrderId = @event.OrderId,
                    Reason = "Insufficient inventory"
                });
            }
        }
    }
    
    public class InventoryReservedEventHandler : IEventHandler<InventoryReservedEvent>
    {
        private readonly IPaymentService _paymentService;
        private readonly IEventBus _eventBus;
        
        public InventoryReservedEventHandler(IPaymentService paymentService, IEventBus eventBus)
        {
            _paymentService = paymentService;
            _eventBus = eventBus;
        }
        
        public async Task HandleAsync(InventoryReservedEvent @event)
        {
            try
            {
                // Process payment
                await _paymentService.ProcessPaymentAsync(@event.OrderId);
                
                // Publish success event
                await _eventBus.PublishAsync(new PaymentProcessedEvent
                {
                    OrderId = @event.OrderId
                });
            }
            catch
            {
                // Publish failure event - triggers compensation
                await _eventBus.PublishAsync(new PaymentFailedEvent
                {
                    OrderId = @event.OrderId
                });
            }
        }
    }
    
    // 4. COMPENSATION EVENT HANDLERS
    public class PaymentFailedEventHandler : IEventHandler<PaymentFailedEvent>
    {
        private readonly IInventoryService _inventoryService;
        private readonly IEventBus _eventBus;
        
        public PaymentFailedEventHandler(IInventoryService inventoryService, IEventBus eventBus)
        {
            _inventoryService = inventoryService;
            _eventBus = eventBus;
        }
        
        public async Task HandleAsync(PaymentFailedEvent @event)
        {
            // Compensate: Release inventory
            await _inventoryService.ReleaseInventoryAsync(@event.OrderId);
            
            // Publish compensation event
            await _eventBus.PublishAsync(new OrderCancelledEvent
            {
                OrderId = @event.OrderId,
                Reason = "Payment failed"
            });
        }
    }
    
    // 5. SAGA STATE MACHINE
    public class OrderSagaStateMachine
    {
        private OrderSagaState _state = OrderSagaState.Initial;
        
        public async Task<bool> TransitionAsync(SagaEvent @event)
        {
            var previousState = _state;
            
            _state = (@event, _state) switch
            {
                (SagaEvent.OrderCreated, OrderSagaState.Initial) => OrderSagaState.OrderCreated,
                (SagaEvent.InventoryReserved, OrderSagaState.OrderCreated) => OrderSagaState.InventoryReserved,
                (SagaEvent.PaymentProcessed, OrderSagaState.InventoryReserved) => OrderSagaState.PaymentProcessed,
                (SagaEvent.ShippingArranged, OrderSagaState.PaymentProcessed) => OrderSagaState.Completed,
                
                // Compensation transitions
                (SagaEvent.PaymentFailed, OrderSagaState.InventoryReserved) => OrderSagaState.Compensating,
                (SagaEvent.InventoryReleaseFailed, _) => OrderSagaState.Failed,
                
                _ => _state // Invalid transition, keep current state
            };
            
            return _state != previousState;
        }
        
        public OrderSagaState CurrentState => _state;
    }
    
    public enum OrderSagaState
    {
        Initial,
        OrderCreated,
        InventoryReserved,
        PaymentProcessed,
        Completed,
        Compensating,
        Failed
    }
    
    public enum SagaEvent
    {
        OrderCreated,
        InventoryReserved,
        PaymentProcessed,
        ShippingArranged,
        PaymentFailed,
        InventoryReleaseFailed
    }
}

// Interfaces and supporting classes
public interface IEventHandler<T>
{
    Task HandleAsync(T @event);
}

public interface IEventBus
{
    Task PublishAsync<T>(T @event);
}

public interface IOrderService
{
    Task CreateOrderAsync(OrderSaga.SagaContext context);
    Task ConfirmOrderAsync(Guid orderId);
    Task CancelOrderAsync(Guid orderId);
}

public interface IPaymentService
{
    Task ProcessPaymentAsync(OrderSaga.SagaContext context);
    Task ProcessPaymentAsync(Guid orderId);
    Task RefundPaymentAsync(Guid orderId);
}

public interface IInventoryService
{
    Task ReserveInventoryAsync(OrderSaga.SagaContext context);
    Task ReserveInventoryAsync(Guid orderId, List<OrderItem> items);
    Task ReleaseInventoryAsync(Guid orderId);
}

public interface IShippingService
{
    Task ArrangeShippingAsync(OrderSaga.SagaContext context);
    Task CancelShippingAsync(Guid orderId);
}

public class CreateOrderCommand
{
    public string CustomerId { get; set; }
    public List<OrderItem> Items { get; set; }
}

public class OrderResult
{
    public bool IsSuccess { get; set; }
    public Guid OrderId { get; set; }
    public string ErrorMessage { get; set; }
    
    public static OrderResult Success(Guid orderId) => 
        new OrderResult { IsSuccess = true, OrderId = orderId };
    
    public static OrderResult Failure(string error) => 
        new OrderResult { IsSuccess = false, ErrorMessage = error };
}

public class InventoryReservedEvent
{
    public Guid OrderId { get; set; }
    public List<OrderItem> Items { get; set; }
}

public class InventoryReservationFailedEvent
{
    public Guid OrderId { get; set; }
    public string Reason { get; set; }
}

public class PaymentProcessedEvent
{
    public Guid OrderId { get; set; }
}

public class PaymentFailedEvent
{
    public Guid OrderId { get; set; }
}

public class OrderCancelledEvent
{
    public Guid OrderId { get; set; }
    public string Reason { get; set; }
}

/*
 * SAGA PATTERN SUMMARY:
 * 
 * Orchestration-based:
 * ? Central coordinator controls flow
 * ? Easy to understand and debug
 * ? Clear compensation logic
 * ? Single point of failure
 * ? Tight coupling
 * 
 * Choreography-based:
 * ? Loose coupling
 * ? No single point of failure
 * ? Services independently react to events
 * ? Harder to understand flow
 * ? Difficult to debug
 * 
 * Use Cases:
 * - E-commerce order processing
 * - Travel booking systems
 * - Financial transactions
 * - Multi-step workflows
 */
```

---

## ?? Most Asked Quick Reference

### Top 20 Must-Know Problems

```csharp
// 1. Second highest number
public int SecondHighest(int[] nums)
{
    return nums.Distinct().OrderByDescending(x => x).Skip(1).First();
}

// 2. Thread-safe Singleton
public sealed class Singleton
{
    private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
    public static Singleton Instance => _instance.Value;
}

// 3. Async/await example
public async Task<int> GetDataAsync()
{
    await Task.Delay(1000);
    return 42;
}

// 4. LINQ grouping
var grouped = customers.GroupBy(c => c.City)
    .Select(g => new { City = g.Key, Count = g.Count() });

// 5. REST API with pagination
[HttpGet]
public async Task<ActionResult<PagedResult<Product>>> GetProducts(
    [FromQuery] int page = 1,
    [FromQuery] int pageSize = 10)
{
    return await _service.GetPagedProductsAsync(page, pageSize);
}

// 6. SQL duplicate removal
WITH CTE AS (
    SELECT *, ROW_NUMBER() OVER (PARTITION BY Email ORDER BY Id) AS RowNum
    FROM Users
)
DELETE FROM CTE WHERE RowNum > 1;

// 7. Retry with Polly
var retryPolicy = Policy
    .Handle<HttpRequestException>()
    .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

// 8. LRU Cache - See implementation above

// 9. Dependency Injection lifetimes
services.AddTransient<IService, Service>(); // New instance each time
services.AddScoped<IService, Service>(); // New instance per request
services.AddSingleton<IService, Service>(); // Single instance

// 10. Saga pattern - See implementation above
```

---

## ?? Interview Preparation Checklist

### For 7+ Years Experience

#### Must Know ?
- [ ] LINQ (Distinct, GroupBy, SelectMany, Join)
- [ ] Async/await patterns
- [ ] Thread safety (lock, SemaphoreSlim, ConcurrentDictionary)
- [ ] SOLID principles with examples
- [ ] Factory and Strategy patterns
- [ ] EF Core optimization (N+1 problem, eager/lazy loading)
- [ ] REST API best practices
- [ ] Dependency Injection lifetimes
- [ ] Polly (Retry, Circuit Breaker)
- [ ] Microservices patterns (Saga, Event-driven)

#### Good to Know ??
- [ ] LRU Cache implementation
- [ ] Immutable classes and records
- [ ] Advanced SQL queries
- [ ] Middleware implementation
- [ ] Global exception handling
- [ ] Rate limiting
- [ ] JWT authentication
- [ ] Docker and Kubernetes basics
- [ ] Message queues (RabbitMQ, Azure Service Bus)
- [ ] CQRS and Event Sourcing

#### System Design Topics ???
- [ ] URL Shortener
- [ ] E-commerce Order Management
- [ ] Payment Processing System
- [ ] Notification Service
- [ ] API Gateway
- [ ] Distributed Caching
- [ ] Load Balancing
- [ ] Database Sharding

---

## ?? Additional Resources

### Books
- "C# in Depth" by Jon Skeet
- "Clean Code" by Robert C. Martin
- "Design Patterns" by Gang of Four
- "Microservices Patterns" by Chris Richardson

### Online Resources
- Microsoft Learn
- Pluralsight
- LeetCode (for algorithms)
- GitHub repositories with .NET samples

### Practice Platforms
- HackerRank
- CodeWars
- LeetCode
- Interview.io

---

**Good luck with your interviews! ??**

Remember: 
- Understand the "why" behind patterns, not just the "how"
- Practice explaining your solutions
- Consider edge cases
- Think about performance and scalability
- Ask clarifying questions before coding
