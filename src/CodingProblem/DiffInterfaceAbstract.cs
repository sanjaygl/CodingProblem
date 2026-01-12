namespace CodingProblem
{
    /*
        What is the difference between Interface and Abstract Class in C#? 
        
        Key Differences:
        1. A class can implement multiple interfaces, but inherit from only one abstract class
        2. Abstract classes can have concrete methods; interfaces (prior to C# 8.0) only have abstract members
        3. Abstract classes can have fields; interfaces cannot
        4. Abstract class members are private by default; interface members are public
        5. Abstract classes can have constructors; interfaces cannot
        6. Abstract classes support single inheritance; interfaces support multiple inheritance
    */

    // Example 1: Interface - Contract for behavior
    public interface IDrawable
    {
        void Draw();
        string GetColor();
    }

    public interface IResizable
    {
        void Resize(int width, int height);
    }

    // Example 2: Abstract Class - Base class with shared functionality
    public abstract class Shape
    {
        protected string name;
        protected string color;

        // Constructor in abstract class
        protected Shape(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // Abstract method - must be implemented by derived classes
        public abstract double CalculateArea();

        // Concrete method - shared implementation
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Shape: {name}, Color: {color}, Area: {CalculateArea():F2}");
        }

        // Concrete method with implementation
        public string GetName()
        {
            return name;
        }
    }

    // Example 3: Class implementing multiple interfaces
    public class Rectangle : Shape, IDrawable, IResizable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height, string color)
            : base("Rectangle", color)
        {
            this.width = width;
            this.height = height;
        }

        // Implementing abstract method from Shape
        public override double CalculateArea()
        {
            return width * height;
        }

        // Implementing IDrawable interface
        public void Draw()
        {
            Console.WriteLine($"Drawing a {color} rectangle with width {width} and height {height}");
        }

        public string GetColor()
        {
            return color;
        }

        // Implementing IResizable interface
        public void Resize(int newWidth, int newHeight)
        {
            width = newWidth;
            height = newHeight;
            Console.WriteLine($"Rectangle resized to {width}x{height}");
        }
    }

    // Example 4: Another concrete class inheriting from abstract class
    public class Circle : Shape, IDrawable
    {
        private double radius;

        public Circle(double radius, string color)
            : base("Circle", color)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {color} circle with radius {radius}");
        }

        public string GetColor()
        {
            return color;
        }
    }

    internal class DiffInterfaceAbstract
    {
        public static void Run()
        {
            Console.WriteLine("=== Interface vs Abstract Class Demo ===\n");

            // Creating objects
            Rectangle rectangle = new Rectangle(5, 10, "Red");
            Circle circle = new Circle(7, "Blue");

            // Using abstract class methods
            Console.WriteLine("--- Abstract Class Functionality ---");
            rectangle.DisplayInfo();
            circle.DisplayInfo();

            Console.WriteLine("\n--- Interface Functionality ---");
            // Using interface methods
            rectangle.Draw();
            circle.Draw();

            // Multiple interface implementation (only Rectangle implements IResizable)
            Console.WriteLine("\n--- Multiple Interface Implementation ---");
            rectangle.Resize(8, 12);
            rectangle.DisplayInfo();

            // Polymorphism with interfaces
            Console.WriteLine("\n--- Polymorphism with Interfaces ---");
            IDrawable[] drawables = { rectangle, circle };
            foreach (var drawable in drawables)
            {
                drawable.Draw();
            }

            // Polymorphism with abstract classes
            Console.WriteLine("\n--- Polymorphism with Abstract Classes ---");
            Shape[] shapes = { rectangle, circle };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetName()} area: {shape.CalculateArea():F2}");
            }
        }
    }
}
