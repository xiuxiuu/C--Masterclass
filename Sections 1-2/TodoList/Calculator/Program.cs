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
        if (operation == "A" || operation == "a")
        {
            Calculate(firstNumberInt, "+", secondNumberInt);
        }
        else if (operation == "S" || operation == "s")
        {
            Calculate(firstNumberInt, "-", secondNumberInt);
        }
        else if (operation == "M" || operation == "m")
        {
            Calculate(firstNumberInt, "*", secondNumberInt);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }

    private static void Calculate(int a, string operation, int b)
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
        Console.WriteLine(a + operation + b + "=" + result);
    }
}