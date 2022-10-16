// See https://aka.ms/new-console-template for more information
string text="n093nfv034nie9";

var counttext= text.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;

Console.WriteLine(counttext);
