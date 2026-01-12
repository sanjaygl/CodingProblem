# Interface vs Abstract Class - Cross Questions

## Fundamental Concepts

### 1. **What is the difference between an interface and an abstract class in C#?**
**Answer:** 
- A class can implement multiple interfaces but inherit from only one abstract class
- Abstract classes can have concrete methods with implementation; interfaces (before C# 8.0) only had abstract members
- Abstract classes can have fields and constructors; interfaces cannot
- Abstract class members are private by default; interface members are public
- Abstract classes support single inheritance; interfaces support multiple inheritance

### 2. **Can an abstract class implement an interface?**
**Answer:** Yes, an abstract class can implement one or more interfaces. The abstract class can either provide implementation for interface members or leave them for derived classes to implement.

```csharp
public interface IExample
{
    void DoWork();
}

public abstract class BaseClass : IExample
{
    public void DoWork() // Can be implemented
    {
        // Implementation
    }
    
    // Or leave it abstract
    public abstract void DoWork();
}
```

### 3. **Can an interface inherit from another interface?**
**Answer:** Yes, an interface can inherit from one or multiple interfaces. This is called interface inheritance.

```csharp
public interface IBase
{
    void Method1();
}

public interface IDerived : IBase
{
    void Method2();
}
```

### 4. **Can we have a constructor in an interface?**
**Answer:** No, interfaces cannot have constructors because they cannot be instantiated directly. Only classes (including abstract classes) can have constructors.

### 5. **Can abstract classes have private methods?**
**Answer:** Yes, abstract classes can have private, protected, internal, and public methods. This allows for encapsulation and helper methods.

## Advanced Concepts

### 6. **What are default interface methods (C# 8.0+)?**
**Answer:** Starting from C# 8.0, interfaces can have default implementations for methods. This allows adding new methods to interfaces without breaking existing implementations.

```csharp
public interface ILogger
{
    void Log(string message);
    
    // Default implementation
    void LogError(string error)
    {
        Log($"ERROR: {error}");
    }
}
```

### 7. **Can an abstract class be sealed?**
**Answer:** No, an abstract class cannot be sealed. The `abstract` keyword means the class must be inherited, while `sealed` means it cannot be inherited. These are mutually exclusive.

### 8. **What is the difference between abstract methods and virtual methods?**
**Answer:**
- **Abstract methods:** Have no implementation in the base class and MUST be overridden in derived classes
- **Virtual methods:** Have an implementation in the base class and MAY be overridden in derived classes (optional)

```csharp
public abstract class Base
{
    public abstract void MustOverride();    // Must be implemented
    public virtual void CanOverride() { }   // Optional to override
}
```

### 9. **Can interfaces have static members?**
**Answer:** Yes (C# 8.0+), interfaces can have static members including static methods, fields, and properties.

```csharp
public interface IConstants
{
    static int MaxValue = 100;
    static void StaticMethod() { }
}
```

### 10. **When should you use an abstract class vs an interface?**
**Answer:**

**Use Abstract Class when:**
- You want to share code among several closely related classes
- You need to declare non-public members
- You need to define fields or constructors
- You want to provide a common base with some implementation

**Use Interface when:**
- You expect unrelated classes to implement your interface
- You want to specify the behavior of a particular data type
- You need multiple inheritance
- You want to define a contract without any implementation

## Practical Scenarios

### 11. **Can a class implement two interfaces with the same method signature?**
**Answer:** Yes, a class can implement multiple interfaces with the same method signature. A single implementation satisfies both interfaces.

```csharp
public interface IA { void DoWork(); }
public interface IB { void DoWork(); }

public class MyClass : IA, IB
{
    public void DoWork() // Satisfies both interfaces
    {
        // Implementation
    }
}
```

### 12. **What is explicit interface implementation?**
**Answer:** Explicit interface implementation is when you implement an interface member by fully qualifying it with the interface name. This is useful when implementing multiple interfaces with conflicting member names.

```csharp
public interface IA { void Method(); }
public interface IB { void Method(); }

public class MyClass : IA, IB
{
    void IA.Method() { } // Explicit implementation
    void IB.Method() { } // Explicit implementation
}
```

### 13. **Can abstract classes have fields while interfaces cannot?**
**Answer:** Yes, abstract classes can have instance fields (variables), while interfaces cannot have instance fields. However, interfaces can have static fields (C# 8.0+).

```csharp
public abstract class BaseClass
{
    protected int value; // Instance field allowed
}

public interface IExample
{
    // int value; // Not allowed
    static int StaticValue = 10; // Allowed in C# 8.0+
}
```

### 14. **Can you instantiate an abstract class or interface?**
**Answer:** No, you cannot directly instantiate either an abstract class or an interface. However, you can create instances of concrete classes that inherit from abstract classes or implement interfaces.

```csharp
// Shape shape = new Shape(); // ERROR - cannot instantiate
Shape shape = new Circle(); // OK - Circle is concrete
```

### 15. **What happens if a derived class doesn't implement all abstract methods?**
**Answer:** The derived class must also be declared as abstract. Only concrete (non-abstract) classes must implement all abstract methods.

```csharp
public abstract class Base
{
    public abstract void Method1();
    public abstract void Method2();
}

public abstract class Derived : Base
{
    public override void Method1() { } // Implements only one
    // Method2 remains abstract
}

public class Concrete : Derived
{
    public override void Method2() { } // Must implement remaining
}
```

## Design Patterns

### 16. **How are interfaces used in Dependency Injection?**
**Answer:** Interfaces are commonly used in Dependency Injection to define contracts, allowing loose coupling between components. This makes code more testable and maintainable.

```csharp
public interface IRepository
{
    void Save(object data);
}

public class Service
{
    private readonly IRepository _repository;
    
    public Service(IRepository repository) // Inject interface
    {
        _repository = repository;
    }
}
```

### 17. **What is the Template Method pattern and how does it relate to abstract classes?**
**Answer:** The Template Method pattern uses abstract classes to define the skeleton of an algorithm, deferring some steps to subclasses. Abstract methods in the base class are overridden to provide specific behavior.

```csharp
public abstract class DataProcessor
{
    public void Process() // Template method
    {
        ReadData();
        ProcessData();
        WriteData();
    }
    
    protected abstract void ReadData();
    protected abstract void ProcessData();
    protected abstract void WriteData();
}
```

### 18. **Can interfaces have properties?**
**Answer:** Yes, interfaces can define properties. Implementing classes must provide the property implementation.

```csharp
public interface IEntity
{
    int Id { get; set; }
    string Name { get; }
}

public class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; private set; }
}
```

## Performance and Best Practices

### 19. **Is there a performance difference between interfaces and abstract classes?**
**Answer:** The performance difference is negligible. Both use virtual method dispatch. The choice should be based on design requirements rather than performance.

### 20. **What are marker interfaces?**
**Answer:** Marker interfaces (or tag interfaces) are empty interfaces used to mark classes as having certain characteristics. Example: `ISerializable`, `ICloneable`.

```csharp
public interface ISpecialProcessing { }

public class MyClass : ISpecialProcessing
{
    // Class is marked for special processing
}

// Usage
if (obj is ISpecialProcessing)
{
    // Perform special processing
}
```

### 21. **Can abstract classes have static methods?**
**Answer:** Yes, abstract classes can have static methods just like regular classes.

```csharp
public abstract class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    public abstract int Multiply(int a, int b);
}
```

### 22. **What is the purpose of abstract properties?**
**Answer:** Abstract properties force derived classes to provide their own implementation for getting/setting values, allowing each derived class to handle the property differently.

```csharp
public abstract class Entity
{
    public abstract int Id { get; set; }
    public abstract string GetDisplayName();
}
```

### 23. **Can you have an abstract class with no abstract methods?**
**Answer:** Yes, you can have an abstract class with no abstract methods. This is useful when you want to prevent direct instantiation of a class while providing common functionality.

```csharp
public abstract class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
```

### 24. **What is interface segregation principle (ISP)?**
**Answer:** ISP states that clients should not be forced to depend on interfaces they don't use. It's better to have many specific interfaces than one general-purpose interface.

```csharp
// Bad - Fat interface
public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

// Good - Segregated interfaces
public interface IWorkable { void Work(); }
public interface IFeedable { void Eat(); }
public interface ISleepable { void Sleep(); }
```

### 25. **Can abstract classes implement the Singleton pattern?**
**Answer:** While technically possible, it's not common because abstract classes cannot be instantiated directly. However, you can implement Singleton in a concrete class derived from an abstract class.

```csharp
public abstract class Configuration
{
    protected abstract void Initialize();
}

public sealed class AppConfiguration : Configuration
{
    private static readonly AppConfiguration _instance = new();
    private AppConfiguration() { }
    public static AppConfiguration Instance => _instance;
    
    protected override void Initialize() { }
}
```

## Bonus Questions

### 26. **What are covariant and contravariant interfaces?**
**Answer:** Covariant (`out`) and contravariant (`in`) allow for more flexible type conversions with generic interfaces.

```csharp
public interface ICovariant<out T>
{
    T GetItem();
}

public interface IContravariant<in T>
{
    void SetItem(T item);
}
```

### 27. **Can you use access modifiers with interface members in C# 8.0+?**
**Answer:** Yes, starting from C# 8.0, interface members can have access modifiers when they have default implementations.

```csharp
public interface IExample
{
    void PublicMethod();
    
    protected void ProtectedMethod() { }
    private void PrivateHelper() { }
}
```

### 28. **What is the liskov substitution principle and how does it relate to abstract classes?**
**Answer:** The Liskov Substitution Principle states that objects of a derived class should be able to replace objects of the base class without affecting program correctness. Abstract classes should be designed with this principle in mind.

### 29. **Can you have async methods in interfaces?**
**Answer:** Yes, interfaces can declare async method signatures using `Task` or `Task<T>` return types.

```csharp
public interface IAsyncService
{
    Task<string> GetDataAsync();
    Task ProcessAsync(string data);
}
```

### 30. **What is the difference between IS-A and CAN-DO relationships?**
**Answer:**
- **IS-A (Abstract Class):** Represents inheritance - "A Dog IS-A Animal"
- **CAN-DO (Interface):** Represents capability - "A Dog CAN-DO Run, Bark, Eat"

```csharp
// IS-A relationship
public abstract class Animal { }
public class Dog : Animal { } // Dog IS-A Animal

// CAN-DO relationship
public interface IRunnable { void Run(); }
public class Dog : IRunnable { } // Dog CAN-DO Run
```

---

## Summary Tips for Interviews

1. **Remember the key differences:** Multiple inheritance, constructors, fields, default implementations
2. **Know when to use each:** Abstract classes for shared code, interfaces for contracts
3. **Understand C# evolution:** Be aware of features added in C# 8.0+ (default implementations, static members)
4. **Think about design principles:** SOLID principles, especially ISP and LSP
5. **Be practical:** Provide real-world examples from your experience
6. **Know common patterns:** Dependency Injection, Template Method, Strategy Pattern

