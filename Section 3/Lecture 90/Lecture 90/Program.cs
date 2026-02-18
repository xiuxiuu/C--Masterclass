var names = new Names();
var path = names.BuildFilePath();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    names.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    names.WriteToTextFile();
}
Console.WriteLine(names.Format());

Console.ReadLine();

<<<<<<< HEAD
class NamesValidator
{
    public bool IsValid(string name)
=======
public class Names
{
    private readonly List<string> _names = new List<string>();

    public void AddName(string name)
    {
        if (IsValidName(name))
        {
            _names.Add(name);
        }
    }

    private bool IsValidName(string name)
>>>>>>> ba3ac23 (Lecture 90 - SRP Intro)
    {
        return
            name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
<<<<<<< HEAD
}

class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();
    }

    public void Write(string filePath, List<string> strings) =>
        File.WriteAllText(filePath, string.Join(Separator, strings));

}
public class Names
{
    private readonly List<string> _names = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();
    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            _names.Add(name);
        }
    }
=======

    public void ReadFromTextFile()
    {
        var fileContents = File.ReadAllText(BuildFilePath());
        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        foreach (var name in namesFromFile)
        {
            AddName(name);
        }
    }

    public void WriteToTextFile() =>
        File.WriteAllText(BuildFilePath(), Format());

>>>>>>> ba3ac23 (Lecture 90 - SRP Intro)
    public string BuildFilePath()
    {
        //we could imagine this is much more complicated
        //for example that path is provided by the user and validated
        return "names.txt";
    }

    public string Format() =>
        string.Join(Environment.NewLine, _names);
}