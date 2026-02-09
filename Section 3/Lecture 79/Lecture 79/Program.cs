var rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Width is: {rectangle1.Width}");
Console.WriteLine($"Height is: {rectangle1.Height}");
Console.WriteLine($"Area is: {rectangle1.CalculateArea()}");
Console.WriteLine($"Circumference is: {rectangle1.CalculateCircumference}");

var rectangle2 = new Rectangle(2, 3);
Console.WriteLine($"Width is: {rectangle2.Width}");
Console.WriteLine($"Height is: {rectangle2.Height}");
Console.WriteLine($"Area is: {rectangle2.CalculateArea}");
Console.WriteLine($"Circumference is: {rectangle2.CalculateCircumference}");

Console.ReadKey();
class Rectangle
{
    //value of const must be known at compile time, can't be declared in constructor
    const int NumberOfSides = 4;
    //readonly fields can be set in the constructor but cannot be changed outside of class declaration or constructor
    readonly int NumberOfSidesReadonly;
    public readonly int Width;
    public readonly int Height;

    public Rectangle(int width, int height)
    {
        NumberOfSidesReadonly = 4;
        Width = GetLengthOrDefault(width, nameof(Width));
        Height = GetLengthOrDefault(height, nameof(Height));
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
    public int CalculateArea() => Width * Height;
    public int CalculateCircumference() => 2 * (Width + Height);
}
