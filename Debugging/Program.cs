using System;
class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());

        var result = string.Empty;
        var currentString = string.Empty;
        GetFirstStrings(delimiter, numberOfStrings, ref result, ref currentString);
        GetLastString(numberOfStrings, ref result, ref currentString);

        Console.WriteLine(result);
    }

    static void GetLastString(int numberOfStrings, ref string result, ref string currentString)
    {
        for (int i = numberOfStrings - 1; i < numberOfStrings; i++)
        {
            currentString = Console.ReadLine();
            result += currentString;
        }
    }

    static void GetFirstStrings(string delimiter, int numberOfStrings, ref string result, ref string currentString)
    {
        for (int i = 0; i < numberOfStrings - 1; i++)
        {
            currentString = Console.ReadLine();
            result += currentString + delimiter;
        }
    }
}