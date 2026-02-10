var rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Width is: {rectangle1.Width}");
Console.WriteLine($"Height is: {rectangle1.GetHeight()}");
Console.WriteLine($"Area is: {rectangle1.CalculateArea()}");
Console.WriteLine($"Circumference is: {rectangle1.CalculateCircumference}");

var rectangle2 = new Rectangle(2, 3);
Console.WriteLine($"Width is: {rectangle2.Width}");
Console.WriteLine($"Height is: {rectangle2.GetHeight()}");
Console.WriteLine($"Area is: {rectangle2.CalculateArea}");
Console.WriteLine($"Circumference is: {rectangle2.CalculateCircumference}");

Console.ReadKey();
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

    //computed properties, should never be performance-heavy
    public string Description => $"A rectangle with width {Width} and height {_height}";
}