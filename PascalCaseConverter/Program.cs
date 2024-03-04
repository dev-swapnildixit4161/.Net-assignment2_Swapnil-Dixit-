using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a few words separated by space:");
        string input = Console.ReadLine();

        string pascalCase = ConvertToPascalCase(input);
        
        Console.WriteLine("PascalCase variable name: " + pascalCase);
    }

    static string ConvertToPascalCase(string input)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        StringBuilder result = new StringBuilder();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            result.Append(textInfo.ToTitleCase(word.ToLower()));
        }

        return result.ToString().Replace(" ", "");
    }
}
