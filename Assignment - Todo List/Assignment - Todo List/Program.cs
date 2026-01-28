////finally, the actual Todo List assignment!!
///my version:
//using System.ComponentModel.Design;
//var userInput = "";
//var toDoList = new List<string>();
//do
//{
//    Console.WriteLine("Hello, World!"); //oops, forgot to remove this line
//    Console.WriteLine("What would you like to do?:");
//    Console.WriteLine("[S]ee all TODOs]");
//    Console.WriteLine("[A]dd a TODO");
//    Console.WriteLine("[R]emove a TODO");
//    Console.WriteLine("[E]xit");
//    userInput = Console.ReadLine();
//    bool toDoListHasToDos;
//    switch (userInput)
//    {
//        case "s":
//        case "S":
//            seeAllToDos(toDoList, out toDoListHasToDos);
//            break;
//        case "a":
//        case "A":
//            var newToDo = "";
//            Console.WriteLine("Enter a TODO description: ");
//            newToDo = Console.ReadLine();
//            if (newToDo == "")
//            {
//                Console.WriteLine("The description cannot be empty.");
//                break;
//            }
//            else if (toDoList.Contains(newToDo))
//            {
//                Console.WriteLine("TODO already exists!");
//                break;
//            }
//            else {
//                addAToDo(toDoList, newToDo);
//            }
//            break;
//        case "r":
//        case "R":
//            seeAllToDos(toDoList, out toDoListHasToDos);
//            if (toDoListHasToDos == false)
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Select the index of the TODO you want to remove: ");
//                var toDoToRemove = int.TryParse(Console.ReadLine(), out int number);
//                if (toDoToRemove == false)
//                {
//                    Console.WriteLine("The given index is not valid.");
//                }
//                else
//                {
//                    removeAToDo(toDoList, number);
//                }
//            }
//            break;
//        default:
//            Console.WriteLine("Invalid input.");
//            break;
//    }

//} while (userInput != "E" && userInput != "e");

//Console.ReadKey(); //preventing window from closing immediately

//void seeAllToDos(List<string> toDoList, out bool toDoListHasToDos)
//{
//    if (toDoList.Count == 0)
//    {
//        toDoListHasToDos = false;
//        Console.WriteLine("No TODOs have been added yet.");
//    }
//    else
//    {
//        toDoListHasToDos = true;
//        int listNumber = 1;
//        foreach (string toDoListItem in toDoList)
//        {
//            Console.WriteLine($"{listNumber}. {toDoListItem}");
//            listNumber++;
//        }
//    }
//}

//void addAToDo(List<string> toDoList, string newTodo)
//{
//    toDoList.Add(newTodo);
//}

//void removeAToDo(List<string> toDoList, int indexToRemove)
//{
//    indexToRemove-=1;

//    //if selected index is empty
//    if (toDoList[indexToRemove] == "")
//    {
//        Console.WriteLine("Selected index cannot be empty.");
//    }
//    else
//    {
//        Console.WriteLine($"TODO Removed: {toDoList[indexToRemove]}");
//        toDoList.Remove(toDoList[indexToRemove]);
//    }
//}




//instructor's version:
var todos = new List<string>();
Console.WriteLine("Hello!");
bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine("What would you like to do?:");
    Console.WriteLine("[S]ee all TODOs]");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "E":
        case "e":
            shallExit = true;
            break;
        case "S":
        case "s":
            Console.WriteLine("See all TODOs");
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove a TODO");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}

Console.ReadKey();
void AddTodo()
{
    bool isValidDescription = false;
    while (!isValidDescription)
    {
        Console.WriteLine("Enter the TODO description:");
        var description = Console.ReadLine();
        if (description == "")
        {
            Console.WriteLine("The description cannot be empty.");
        }
        else if (todos.Contains(description))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            isValidDescription = true;
            todos.Add(description);
        }
    }
}