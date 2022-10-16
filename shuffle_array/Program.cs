// See https://aka.ms/new-console-template for more information

var randeyshon = new Random();
List<int> array = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

var shuffle_array= array.OrderBy(x => randeyshon.Next());
foreach (var x in shuffle_array){
Console.WriteLine($"{x}");

}
