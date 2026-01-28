//getting annoyed with putting all code examples in the Todo list project. for better organization of lecture material, I created a simple template to use for each lecture. 
var numbers = new[] { 10, -8, 2, 12, -17 };
int nonPositiveCount;
//write a method containing a list of only the positive numbers from numbers array
//return an integer of how many negative numbers exist in the array
var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
foreach(var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}
Console.WriteLine($"Count of non positive: {nonPositiveCount}");
Console.ReadKey();

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();

    foreach(int number in numbers)
    {
        if (number > 0 )
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result;
}