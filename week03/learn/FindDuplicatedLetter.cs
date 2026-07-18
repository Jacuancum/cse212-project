public class FindDuplicatedLetter
{
    public static string Find(string text)
    {
        HashSet<char> seen = new HashSet<char>();
        foreach (char letter in text)
        {
            if (seen.Contains(letter))
            {
                return letter.ToString();
            }
            seen.Add(letter);
        }
        return "No duplicated letters found.";
        
    }
    public static void Run()
    {
        Console.WriteLine(Find("HELLO"));
        Console.WriteLine(Find("BANANA"));
        Console.WriteLine(Find("ABCDEF"));
        Console.WriteLine(Find("MISSISSIPPI"));
        Console.WriteLine(Find("PROGRAMMING"));
        Console.WriteLine(Find("CSE212"));
        Console.WriteLine(Find("DUPLICATE"));
        Console.WriteLine(Find("LETTER"));
        Console.WriteLine(Find("TESTING"));
        Console.WriteLine(Find("EXAMPLE"));
        Console.WriteLine(Find("NO DUPLICATES"));
        Console.WriteLine(Find("AABBCC"));
        Console.WriteLine(Find("XYZXYZ"));
        Console.WriteLine(Find("HELLO WORLD"));
        Console.WriteLine(Find("C# PROGRAMMING"));
        Console.WriteLine(Find("DUPLICATE LETTERS"));
        Console.WriteLine(Find("FIND THE DUPLICATE"));
        Console.WriteLine(Find("THIS IS A TEST"));
        Console.WriteLine(Find("ANOTHER EXAMPLE"));
        Console.WriteLine(Find("MY NAME IS JACOB"));
    }
}