// See https://aka.ms/new-console-template for more information
List<string> words = new List<string>(){"learn", "current", "deal"};

var wordreplace = words.Select(x => x.Contains("ea")? x.Replace("ea","*"):x);

foreach (string word in wordreplace)
{
    Console.WriteLine($"{word}");    
}

