using System.ComponentModel.Design;
var userInput = "";
var toDoList = new List<string>();
do
{
    Console.WriteLine("Hello!"); 
    Console.WriteLine("What would you like to do?:");
    Console.WriteLine("[S]ee all TODOs]");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "s":
        case "S":
            SeeAllToDos();
            break;
        case "a":
        case "A":
            AddAToDo();
            break;
        case "r":
        case "R":
            RemoveAToDo();
            break;
        case "E":
        case "e":
            break;
        default:
            Console.WriteLine("Invalid input.");
            break;
    }

} while (userInput != "E" && userInput != "e");

Console.ReadKey(); //preventing window from closing immediately

void SeeAllToDos()
{
    if (toDoList.Count == 0)
    {
        PrintNoToDosMessage();
    }
    else
    {
        int listNumber = 1;
        foreach (string toDoListItem in toDoList)
        {
            Console.WriteLine($"{listNumber}. {toDoListItem}");
            listNumber++;
        }
    }
}

void AddAToDo()
{
    var newToDo = "";
    Console.WriteLine("Enter a TODO description: ");
    newToDo = Console.ReadLine();
    if (newToDo == "")
    {
        Console.WriteLine("The description cannot be empty.");
    }
    else if (toDoList.Contains(newToDo))
    {
        Console.WriteLine("TODO already exists!");
    }
    else
    {
        toDoList.Add(newToDo);
    }
}

void RemoveAToDo()
{
    if (toDoList.Count == 0)
    {
        PrintNoToDosMessage();
    }
    else
    {
        Console.WriteLine("Select the index of the TODO you want to remove: ");
        SeeAllToDos();
        var toDoToRemove = int.TryParse(Console.ReadLine(), out int indexToRemove);
        
        /* Removed the instructor's check for an empty index by doing the Console.ReadLine()
         and .TryParse method in the same line. I know it was part of the assignment requirements 
         but I'm not actually getting graded for this and it was unnecessary. */
        
        if (toDoToRemove == false ||
            indexToRemove > toDoList.Count ||
            indexToRemove < 1)
        {
            Console.WriteLine("The given index is not valid.");
        }
        else
        {
            indexToRemove -= 1;
            Console.WriteLine($"TODO Removed: {toDoList[indexToRemove]}");
            toDoList.Remove(toDoList[indexToRemove]);
        }
    }
}

static void PrintNoToDosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}