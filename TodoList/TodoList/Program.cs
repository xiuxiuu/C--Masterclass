using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs]");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

//reads line from console and stores it in userInput variable
var userInput = Console.ReadLine();
if (userInput == "S" || userInput == "s")
{
    PrintSelectedOption("See all TODOs");
}
else if (userInput == "A" || userInput == "a")
{
    PrintSelectedOption("Add a TODO");
}
else if (userInput == "R" || userInput == "r")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userInput == "E" || userInput == "e")
{
    PrintSelectedOption("Exit");
}
    Console.ReadKey(); //preventing window from closing immediately
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}