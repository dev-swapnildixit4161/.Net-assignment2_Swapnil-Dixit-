using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter a name (press Enter to finish): ");
            string name = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                break;
            }

            names.Add(name);

            string message = FormatLikes(names);
            Console.WriteLine(message);
        }
    }

    static string FormatLikes(List<string> names)
    {
        int count = names.Count;

        if (count == 0)
        {
            return "";
        }
        else if (count == 1)
        {
            return $"{names[0]} likes your post";
        }
        else if (count == 2)
        {
            return $"{names[0]} and {names[1]} like your post";
        }
        else
        {
            int othersCount = count - 2;
            return $"{string.Join(", ", names.Take(2))} and {othersCount} others like your post";
        }
    }
}
