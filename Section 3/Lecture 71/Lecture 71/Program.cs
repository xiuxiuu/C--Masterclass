//var rectangle1 = new Rectangle(5, 10); //no constructor
var rectangle1 = new Rectangle();
Console.WriteLine($"Width is: {rectangle1.width}");
Console.WriteLine($"Height is: {rectangle1.height}");

Console.ReadKey();

class Rectangle
{
    int width;
    int height;
}