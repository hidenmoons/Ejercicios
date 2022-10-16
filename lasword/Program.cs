// See https://aka.ms/new-console-template for more information
List<string> wordlist = new List<string>(){"plane", "ferry", "car", "bike"};

var orderword = wordlist.OrderBy(x =>x).LastOrDefault(x => x.Contains("e"));


Console.WriteLine($"{orderword}");
