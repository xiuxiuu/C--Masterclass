//var rectangle1 = new Rectangle(5, 10); //no constructor
var rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Width is: {rectangle1.Width}");
Console.WriteLine($"Height is: {rectangle1.Height}");

var rectangle2 = new Rectangle(2, 3);
Console.WriteLine($"Width is: {rectangle2.Width}");
Console.WriteLine($"Height is: {rectangle2.Height}");

//rectangle1.width = -5; //invalid state of the object, exposed implementation details of class
/*access modifiers
 * - private members can only bw accessed within the class it belongs to
 * - public members can be accessed everywhere
 */

Console.ReadKey();

class Rectangle
{
    //default access modifier is private, hence "'Rectangle.width' is inaccessible due to its protection level" error
    //int width;
    //int height;

    //in order to make width and height accessible outside of the Rectangle class, add public access modifier
    //public int width; //default value for int is 0
    //public int height;

    //as per convention, public properties should start with a capital letter
        //private field names should start with an underscore, followed by a lowercase letter
    public int Width = 3;
    public int Height = 4;
        //initialized values will be overwritten by constructor

    //constructor
    //must be named the same as the class it belongs to
    //no return type
    //can only be called at the moment of object creation
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    void DummyMethod()
    {
        //works because code belongs to Rectangle class
        Console.WriteLine($"Height is {Height}");
    }
}
