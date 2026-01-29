var words = new List<string>
{
    "one",
    "two",
};

words[0] = "eins";
words[1] = "zwei";
//words[2] = "element does not exist yet, cannot edit";
Console.WriteLine($"Count of elements is: {words.Count}");

words.Add("hello");
Console.WriteLine($"Count of elements is: {words.Count}");

words.Remove("zwei");
words.Remove("nonexistent element"); //does nothing, no element matching argument
words.RemoveAt(0);

var moreWords = new[] { "drei", "vier", "fünf" };
words.AddRange(moreWords);

Console.WriteLine("Index of element 'vier' is " + words.IndexOf("vier"));
Console.WriteLine("Index of element 'sechs' is " + words.IndexOf("sechs")); //returns -1, as "sechs" does not exist in the list

//check if element exists in the list, returns bool
Console.WriteLine($"Contains 'fünf'?: {words.Contains("fünf")}");
Console.WriteLine($"Contains 'sieben'?: {words.Contains("sieben")}");
foreach (var word in words)
{
    Console.WriteLine(word);
}

words.Clear(); //removes all elements from the list
Console.WriteLine($"Count of elements is: {words.Count}");






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