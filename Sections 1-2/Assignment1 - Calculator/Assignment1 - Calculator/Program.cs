//my version:
    //also under the Todo List solution as another project, but I did not like it being stored as another project under the same solution as an entirely different project. 
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Hello!");
//        Console.WriteLine("Input the first number: ");
//        string firstNumberString = Console.ReadLine();
//        int firstNumberInt = int.Parse(firstNumberString);

//        Console.WriteLine("Input the second number: ");
//        string secondNumberString = Console.ReadLine();
//        int secondNumberInt = int.Parse(secondNumberString);

//        Console.WriteLine("What do you want to do with those numbers?\n" +
//            "[A]dd\n" +
//            "[S]ubtract\n" +
//            "[M]ultiply");
//        string operation = Console.ReadLine();
//        if (operation == "A" || operation == "a")
//        {
//            Calculate(firstNumberInt, "+", secondNumberInt);
//        }
//        else if (operation == "S" || operation == "s")
//        {
//            Calculate(firstNumberInt, "-", secondNumberInt);
//        }
//        else if (operation == "M" || operation == "m")
//        {
//            Calculate(firstNumberInt, "*", secondNumberInt);
//        }
//        else
//        {
//            Console.WriteLine("Invalid input!");
//        }

//        Console.WriteLine("Press any key to close");
//        Console.ReadKey();
//    }

//    private static void Calculate(int a, string operation, int b)
//    {
//        int result;
//        if (operation == "+")
//        {
//            result = a + b;
//        }
//        else if (operation == "-")
//        {
//            result = a - b;
//        }
//        else
//        {
//            result = a * b;
//        }
//        Console.WriteLine(a + operation + b + "=" + result);
//    }
//}




//instructor's version:
using System.Numerics;

Console.WriteLine("Hello");
Console.WriteLine("Input the first number: ");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number: ");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do?:");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var choice = Console.ReadLine();

if (/* refactoring: choice == "A" || choice == "a"*/EqualsCaseInsensitive(choice, "A"))
{
    var sum = number1 + number2;
    //refactoring:
    //Console.WriteLine(number1 + "+" + number2 + "=" + sum);
    PrintFinalEquation(number1, number2, sum, "+");
}
else if (/* refactoring: choice == "S" || choice == "s"*/ EqualsCaseInsensitive(choice, "S"))
{
    var difference = number1 - number2;
    //refactoring:
    //Console.WriteLine(number1 + "-" + number2 + "=" + difference);
    PrintFinalEquation(number1, number2, difference, "-");
}
else if (/* refactoring: choice == "M" || choice == "m"*/ EqualsCaseInsensitive(choice, "M"))
{
    var multiplied = number1 * number2;
    //refactoring:
    //Console.WriteLine(number1 + "*" + number2 + "=" + multiplied);
    PrintFinalEquation(number1, number2, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}
    Console.WriteLine("Press any key to close.");
Console.ReadKey();

void PrintFinalEquation (int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInsensitive (string left, string right)
{
    //personally, i believe this method is unnecessary. could just convert ToUpper in the if statements. however, an OR statement is faster than creating a new string object in memory and comparing the two
    return left.ToUpper() == right.ToUpper();
}