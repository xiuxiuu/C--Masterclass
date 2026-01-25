using System.Runtime.InteropServices;

string ConvertPointsToGrade(int points)
{
    string GetGrade(int score) => score switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 50 => 'C',
        _ => 'D'
    };
    Console.WriteLine(GetGrade(85)); // Output: B

    string GetCategory(int number) => number switch
    {
        1 => "One",
        2 => "Two",
        3 => "Three",
        _ => "Other" //default case
    };
    Console.WriteLine(GetCategory(2)); // Output: Two

    //type pattern matching
    string DescribeObject(object obj) => obj switch
    {
        int n => $"It's an integer: {n}",
        string s => $"It's a string: {s}",
        bool b => $"It's a boolean: {b}",
        _ => "Unknown type"
    };
    Console.WriteLine(DescribeObject(42)); // Output: It's an integer: 42
    Console.WriteLine(DescribeObject("Hello")); // Output: It's a string: Hello
    Console.WriteLine(DescribeObject(true)); // Output: It's a boolean: True

    //positional pattern matching (with tuples)
    string WeatherAdvice(string weather, bool isWeekend) => (weather, isWeekend) switch
    {
        ("Sunny", true) => "Go to the beach!",
        ("Sunny", false) => "Enjoy a walk after work.",
        ("Rainy", _) => "Stay inside and read a book.",
        _ => "Just another day."
    };
    Console.WriteLine(WeatherAdvice("Sunny", true)); //Output: Go to the beach!

    //property pattern matching (matching object properties)

    class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
string GetDiscount(Person person) => person switch
{
    { Age < 12 } => "Child discount",
    { Age: >= 65 } => "Senior discount",
    _ => "Regular price"
};
Console.WriteLine(GetDiscount(new Person { Name = "Alice", Age = 10 })); //Output: Child discount
Console.WriteLine(GetDiscount(new Person { Name = "Bob", Age = 70 })); //Output: Senior discount
}