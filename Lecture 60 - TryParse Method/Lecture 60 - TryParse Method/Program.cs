using System.Runtime.Intrinsics.Arm;

//Console.WriteLine("Enter a number: ");
//var userInput = Console.ReadLine();
bool isParsingSuccessful;
do
{
    Console.WriteLine("Enter a number: ");
    var userInput = Console.ReadLine();

    isParsingSuccessful = int.TryParse(userInput, out int number);

    if (isParsingSuccessful)
    {
        Console.WriteLine($"Parsing worked, number is: {number}");
    }
    else
    {
        Console.WriteLine("Parsing was not successful.");
    }
} while (!isParsingSuccessful);

//if (isParsingSuccessful)
//{
//    Console.WriteLine($"Parsing worked, number is: {number}");
//}
//else
//{
//    Console.WriteLine("Parsing was not successful.");
//}

    Console.ReadKey();