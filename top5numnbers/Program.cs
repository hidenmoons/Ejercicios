// See https://aka.ms/new-console-template for more information
List<int> top5= new List<int>() {78, -9, 0, 23, 54,  21, 7, 86};  

   var top5numbers = top5.OrderByDescending(x => x).Take(5);
    foreach(var number in top5numbers) {
    
    Console.WriteLine($"{number}");
    }
