var rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Width is: {rectangle1.Width}");
//rectangle1.Width = 15;
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

    //backing field
    //private int _width;
    private int _height;

    public int Width { get; private set; }
    //public int Width
    //{
    //    get
    //    {
    //        return _width;
    //    }
    //    private set
    //    {
    //        if (value > 10)
    //        {
    //            _width = value;
    //        }
    //    }
    //}
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
}


//fields: variable-like
    //single access modifier
    //no separate getter and setter
    //cannot be overridden in derived classes
    //should always be private
//properties: method-like
    //separate access modifiers for getter and setter
    //getter or setter may be removed
    //can be overridden in derived classes
    //can safely be public