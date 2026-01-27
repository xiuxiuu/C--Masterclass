//for (var i = 0; i < 20; i++)
//{
//    if (i % 3 == 0)
//    {
//        continue; //skips the iteration when i is multiple of 3
//    }
//    Console.WriteLine("i is: " + i);
//}

int userNumber;
do
{
    Console.WriteLine("Enter a number larger than 10:");
    var userInput = Console.ReadLine();
    if (userInput == "stop")
    {
        break;
    }
    bool isParsableToInt = userInput.All(char.IsDigit);
    if(!isParsableToInt)
    {
        userNumber = 0;
        continue;
    }
    userNumber = int.Parse(userInput);
} while (userNumber <= 10);

//using System.ComponentModel.Design;
//Console.WriteLine("Hello, World!");
//Console.WriteLine("[S]ee all TODOs]");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

////reads line from console and stores it in userInput variable
//var userInput = Console.ReadLine();

//switch(userInput)
//{
//    case "s":
//    case "S":
//        PrintSelectedOption("See all TODOs");
//        break;
//    case "a":
//    case "A":
//        PrintSelectedOption("Add a TODO");
//        break;
//    case "r":
//    case "R":
//        PrintSelectedOption("Remove a TODO");
//        break;
//    case "e":
//    case "E":
//        PrintSelectedOption("Exit");
//        break;
//    default:
//        Console.WriteLine("Invalid choice.");
//        break;
//}
Console.ReadKey(); //preventing window from closing immediately
//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}