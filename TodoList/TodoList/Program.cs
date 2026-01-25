using System.ComponentModel.Design;
//Console.WriteLine("Hello, World!");
//Console.WriteLine("[S]ee all TODOs]");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

////reads line from console and stores it in userInput variable
//var userInput = Console.ReadLine();
int a = 4, b = 2, c = 10;
Console.WriteLine("First is: " + a + ", second is: " + b + ", third is: " + c);

//string interpolation
Console.WriteLine($"First is: {a}, second is: {b}, third is: {c}");

//adding an expression
Console.WriteLine($"Sum is: {a + b + c}, second is: {b}, third is: {c}");

//if (userInput == "S" || userInput == "s")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userInput == "A" || userInput == "a")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userInput == "R" || userInput == "r")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userInput == "E" || userInput == "e")
//{
//    PrintSelectedOption("Exit");
//}
Console.ReadKey(); //preventing window from closing immediately
//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}