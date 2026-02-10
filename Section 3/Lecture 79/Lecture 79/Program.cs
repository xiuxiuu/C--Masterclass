var rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Width is: {rectangle1.Width}");
Console.WriteLine($"Height is: {rectangle1.GetHeight()}");
Console.WriteLine($"Area is: {rectangle1.CalculateArea()}");
Console.WriteLine($"Circumference is: {rectangle1.CalculateCircumference}");

var rectangle2 = new Rectangle(2, 3);

Console.WriteLine(Rectangle.DescribeGenerally());
//Console.WriteLine(rectangle1.DescribeGenerally());
//Console.WriteLine("Number of sides is " + rectangle1.NumberOfSides);
Console.WriteLine("Number of sides is " + Rectangle.NumberOfSides);
Console.WriteLine($"Width is: {rectangle2.Width}");
Console.WriteLine($"Height is: {rectangle2.GetHeight()}");
Console.WriteLine($"Area is: {rectangle2.CalculateArea}");
Console.WriteLine($"Circumference is: {rectangle2.CalculateCircumference}");

//var calculator = new Calculator();
Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
//Console.WriteLine($" 1 - 2 is {calculator.Subtract(1, 2)}");
//Console.WriteLine($"1 * 2 is {calculator.Multiply(1, 2)}");
Console.WriteLine($" 1 - 2 is {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

Console.ReadKey();

//stateless (has no state)
//static methods belong to a class as a whole, not to a specific instance
    //can't use the instance data (values of fields returned by properties)
//a static class cannot be instantiated; it only works as a container for methods
//static classes can only contain static methods
static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}

//stateful (has state - fields)
//non-static classes can contain static methods
class Rectangle
{

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
    }

    private int _height;

    public int Width { get; private set; }
    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }
    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }
    public int CalculateArea() => Width * _height;
    public int CalculateCircumference() => 2 * (Width + _height);
    public string Description => $"A rectangle with width {Width} and height {_height}";

    //if a private method doesn't use instance data, make it static
    public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles.";

    //the value is const, always will be the same for all instances of the class. all const fields are implicitly static
    public const int NumberOfSides = 4;
}