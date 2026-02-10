Console.ReadKey();

//object initializer
//var person = new Person
//{
//    Name = "John",
//    YearOfBirth = 1981
//};

//assign the name by constructor, and DOB by initializer
//var person = new Person("John")
//{
//    //uses the name in the initializer because constructor is called first, then overridden by initializer
//    Name = "Adam",
//    YearOfBirth = 1981
//};

//with object initializer, we can choose what properties are set. with a constructor, we must assign all values
var person = new Person
{
    Name = "John",
    YearOfBirth = 1981
};
class Person
{
    //if these were private (or private setter), object initializer would not be possible
    //public string Name { get; set; }
    //public int YearOfBirth { get; set; }

    public string Name { get; set; }
    //with init only setter, we can assign value to property only during object construction 
    public int YearOfBirth { get; init; }
    //public Person(string name)
    //{
    //    Name = name;
    //}
    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
}