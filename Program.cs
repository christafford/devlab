Console.WriteLine("Hello, and please choose an option");
Console.WriteLine("1: Compare two strings to see if they are the same");
Console.WriteLine("2: Check if one string is the same as another backwards (an anagram)");
Console.Write("Enter Choice: ");
var choice = Console.ReadLine();
string firstString = null;
string secondString = null;
bool result = false;

switch(choice)
{
    case "1":
        Console.Write("Enter first string: ");
        firstString = Console.ReadLine();
        Console.Write("Enter second string: ");
        secondString = Console.ReadLine();
        result = CheckStringsEqual(firstString, secondString);
        break;
    case "2":
        Console.Write("Enter first string: ");
        firstString = Console.ReadLine();
        Console.Write("Enter second string: ");
        secondString = Console.ReadLine();
        result = CheckAnagram(firstString, secondString);
        break;
    default:
        Console.WriteLine("Unknown choice, sorry.");
        break;
}

Console.WriteLine($"Result was: {result}");

bool CheckStringsEqual(string firstString, string secondString)
{
    // todo
    return firstString == secondString;
}

bool CheckAnagram(string firstString, string secondString)
{
    // todo
    return false;
}