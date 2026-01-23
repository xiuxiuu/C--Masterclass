internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Input the first number: ");
        string firstNumberString = Console.ReadLine();
        int firstNumberInt = int.Parse(firstNumberString);

        Console.WriteLine("Input the second number: ");
        string secondNumberString = Console.ReadLine();
        int secondNumberInt = int.Parse(secondNumberString);

        Console.WriteLine("What do you want to do with those numbers?\n" +
            "[A]dd\n" +
            "[S]ubtract\n" +
            "[M]ultiply");
        string operation = Console.ReadLine();
        string operationOperator ="";
        int result = 0;
        bool validInput = false;
        if (operation == "A" || operation == "a")
        {
            validInput = true;
            result = Calculate(firstNumberInt, "+", secondNumberInt);
            operationOperator = "+";
        }
        else if (operation == "S" || operation == "s")
        {
            validInput = true;
            result = Calculate(firstNumberInt, "-", secondNumberInt);
            operationOperator = "-";
        }
        else if (operation == "M" || operation == "m")
        {
            validInput = true;
            result = Calculate(firstNumberInt, "*", secondNumberInt);
            operationOperator = "*";
        }
        else
        {
            validInput = false;
            Console.WriteLine("Invalid input!");
        }

        if (validInput == true)
        {
            Console.WriteLine(firstNumberString + operationOperator + secondNumberString + "=" + result);
        }
        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }

    private static int Calculate(int a, string operation, int b)
    {
        int result;
        if (operation == "+")
        {
            result = a + b;
        }
        else if (operation == "-")
        {
            result = a - b;
        }
        else
        {
            result = a * b;
        }
        return result;
    }
}